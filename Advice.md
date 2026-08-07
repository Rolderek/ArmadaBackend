# Átfogó projektértékelés

## Összkép

A projekt jó irányba indult, de jelenleg inkább egy működő Star Wars: Armada-adatkatalógus és flotta-adatmodell prototípus, mint kész többfelhasználós flottaépítő backend.

Az alapot nem kell kidobni. Az ASP.NET Core + EF Core + SQL Server megfelelő választás, a hajók, upgrade-ek és squadronok törzsadatai értékesek. A következő fejlesztési szakasz előtt viszont érdemes rendbe tenni a domainmodellt, mert a későbbi challenge, tournament és statisztikai funkciók erre fognak épülni.

A referenciaoldal publikus felülete frakciónkénti flottaépítést, hajókat, squadronokat, három objective-típust, pontszámítást és nyomtatást kínál. A fiók feladata a flották mentése és megosztása. [Ryan Kingston Armada Fleet Builder](https://armada.ryankingston.com/), [FAQ](https://armada.ryankingston.com/faq/).

## Ami már most jó

- A projekt lefordul: 0 hiba, 3 nullable figyelmeztetés.
- Az EF Core kapcsolatok egy része már tudatosan van konfigurálva az [AppDbContext.cs](Data/AppDbContext.cs#L23) fájlban.
- Jó irány, hogy külön törzsadat a `Ship`, `Card`, `SquadronCard`, és külön entitás reprezentálja a flottába felvett hajót vagy upgrade-et.
- A `FleetElement → EquippedUpgrade` modell már alkalmas arra, hogy ugyanaz a hajótípus több külön konfigurációban szerepeljen.
- Van egyedi index ugyanazon upgrade ugyanarra a hajóra történő kétszeri felvétele ellen.
- A seed adatok szerkezetileg meglepően rendezettek:

  - 294 upgrade-kártya
  - 66 hajó
  - 504 hajó-upgrade-slot
  - 107 squadron
  - nincs duplikált ID
  - nincs hibás `ShipCard.ShipId`

- A migrációk és a Swagger már be vannak kötve.
- A nullable reference type engedélyezve van az [ArmadaBackend.csproj](ArmadaBackend.csproj#L3) fájlban.

Ez komoly előny: az Armada-adatok összegyűjtése sok munka, és ez a projektben már nagyrészt megtörtént.

## A legfontosabb hiányosságok

### 1. Még nincs valódi felhasználói rendszer

Nincs authentication, Identity/JWT, `User`, tulajdonjog vagy `[Authorize]`. A [Program.cs](Program.cs#L31) meghívja a `UseAuthorization()` metódust, de nincs mögötte konfigurált hitelesítés.

Következmények:

- egy flotta nem rendelhető felhasználóhoz;
- nem lehet megmondani, ki szerkesztheti vagy törölheti;
- az összes POST/PUT/DELETE katalógusvégpont publikus;
- jelenleg bárki módosíthatná a hajó- és kártyatörzsadatokat.

Legalább három jogosultsági szint kell majd:

- publikus: katalógusok és megosztott flották olvasása;
- bejelentkezett user: saját flották kezelése, challenge és eredményjelentés;
- admin/organizer: törzsadatok és tournamentek kezelése.

### 2. A flotta még csak egy váz

A [Fleet.cs](Models/Fleet.cs#L3) csak nevet, hajókat és squadronokat tartalmaz. Hiányzik legalább:

- `OwnerUserId`;
- frakció;
- szabályrendszer/verzió;
- pontlimit;
- publikus/privát állapot;
- objective-ek;
- létrehozási és módosítási idő;
- archivált vagy draft állapot;
- teljes pontérték;
- esetleges megosztási azonosító.

Nincs `FleetController`, így teljes flottát jelenleg nem lehet normál API-n keresztül létrehozni, lekérni vagy menteni. A `FleetElementController` mindössze az összes elemet listázza.

A [FleetElement.Point](Models/FleetELement.cs#L19) jó ötlet, de a jelenlegi `GetAll` nem tölti be a hajót és az upgrade-kártyákat, ezért az érték jellemzően 0 lesz.

### 3. A squadron kapcsolatot mindenképpen javítani kell

A [SquadronElement.cs](Models/SquadronElement.cs#L7) csak szöveges `SquadronName` mezőt tárol. Ez adatduplikációt és elgépelési lehetőséget jelent.

Ide `SquadronCardId` idegen kulcs kell. Így a név, pontérték, frakció és egyediség mindig a törzsadatból származhat. A projektben lévő `Javaslat.txt` ezt helyesen felismeri.

Az `"na"` érték helyett a nem létező ace-nevet `null`-lal érdemes reprezentálni.

### 4. A flottaépítési szabályok nincsenek kikényszerítve

Jelenleg az adatbázis nem akadályozza meg például ezeket:

- más frakcióhoz tartozó hajó vagy kártya használata;
- nem létező upgrade-slot használata;
- több commander;
- ugyanazon unique kártya vagy ace többszöri használata;
- tiltott kártya kiválasztása;
- pontlimit vagy squadron-limit túllépése;
- negatív pont vagy darabszám;
- tetszőleges, enumon kívüli kategóriaérték.

A `CardCategory` egyszerre próbálja tárolni a slot típusát és a frakcióspecifikus jogosultságot. Emiatt jelennek meg a [CardsController.cs](Controllers/CardsController.cs#L58) fájlban a `(CardCategory)5` jellegű „mágikus számok”.

Jobb lenne külön kezelni:

- `Faction`;
- `UpgradeSlotType`;
- kártya–frakció kapcsolat;
- unique/limited/banned státusz;
- méret- és egyéb felszerelési korlátozások;
- `RulesetVersion`.

### 5. Veszélyesek a törlési kapcsolatok

A hajó törlése cascade módon törli a rá hivatkozó `FleetElement` rekordokat, a kártya törlése pedig a felhasználók felszerelt upgrade-jeit.

Törzsadat törlése nem viheti magával a felhasználói flották részeit. Ezeknél inkább `Restrict/NoAction`, illetve archiválás vagy verziózás szükséges. A `Fleet → FleetElement` cascade viszont logikus.

### 6. Az API még prototípus-szintű

Néhány konkrét probléma:

- közvetlenül EF entitásokat fogad és küld, nincsenek DTO-k;
- nincs bemeneti validáció;
- nincs egységes hibaválasz vagy globális exception handling;
- nincs lapozás;
- az olvasási lekérdezéseknél nincs `AsNoTracking`;
- inkonzisztensek az útvonalak;
- a `ShipContoroller` elírás az API URL-be is bekerül;
- a `CardsController` delete route-ja `[HttpDelete("id:int")]`, ami valószínűleg nem a szándékolt `{id:int}`;
- több lista-lekérdezés nullt ellenőriz, pedig az EF üres listát ad;
- az ID szerinti kártyalekérdezés egy listát ad vissza egyetlen objektum vagy 404 helyett;
- nincs CORS-konfiguráció, ami külön hoston futó frontendnél probléma lesz.

A 3 fordítási figyelmeztetés is a nullable `Name` mezőkön végzett `ToLower()` hívásokhoz kapcsolódik.

## A jövőbeli funkciók szempontjából legfontosabb döntés

A csaták és tournamentek mindig a flotta egy változatlan pillanatképére hivatkozzanak, ne az élő flottára.

Ha a user később átírja a flottáját, vagy változik egy kártya pontértéke, egy régi tournament eredményének nem szabad megváltoznia. Ehhez célszerű:

- `Fleet` – szerkeszthető aktuális flotta;
- `FleetSnapshot` – leadáskor létrehozott változatlan másolat;
- `RulesetVersion` – az akkor érvényes pontok és tiltások verziója;
- `Match` – résztvevők, snapshotok, pontszámok, győztes;
- `Challenge` – kihívó, ellenfél, státusz, időpont;
- `Tournament`, `Participant`, `Round`, `Pairing`;
- eredményjelentési és ellenfél általi megerősítési státusz.

A user statisztikákat elsődlegesen a lezárt `Match` rekordokból érdemes számolni, nem külön kézzel frissített győzelem/vereség számlálókból.

## Javasolt fejlesztési sorrend

1. Domainmodell rendbetétele: `Faction`, squadron FK, objective, flotta metaadatai és szabályverzió.
2. Felhasználókezelés, flotta-tulajdonjog és jogosultságok.
3. Teljes flotta CRUD DTO-kkal és központi validációs szolgáltatással.
4. Flottaépítési szabályok és pontszámítás.
5. Automatizált tesztek: szabálytesztek és API/EF integrációs tesztek.
6. Challenge és `Match` + immutable `FleetSnapshot`.
7. Tournament kezelés.
8. Statisztikai lekérdezések, cache és teljesítményoptimalizálás.

A projekt .NET 9-et használ. Ez jelenleg még támogatott, de már maintenance fázisban van, és a támogatása 2026. november 10-én lejár. Új, hosszabb életű backendhez érdemes betervezni a .NET 10 LTS-re váltást, amely 2028 novemberéig támogatott. [Microsoft .NET támogatási szabályzat](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core).

Összességében: jó és értékes prototípus, különösen a törzsadatok miatt. A cél megvalósítható erre az alapra építve, de a következő mérföldkőnek nem a tournamentnek, hanem egy biztonságos, szabályosan validált, userhez kötött és verziózható flotta-MVP-nek kell lennie.

Forrásfájlt nem módosítottam. A munkafában már előtte is módosított volt a `Program.cs` és az `appsettings.json`; ezekhez nem nyúltam.
