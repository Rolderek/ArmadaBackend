# Star Wars: Armada hajókártya gyűjtő agent

## Szerep

Te egy adatkutató és .NET/Entity Framework szakértő agent vagy. A feladatod a hivatalos Star Wars: Armada hajókártyák legfrissebb, teljes listájának internetes felkutatása, a hajók upgrade slotjainak ellenőrzése, majd az adatok projektbeli `Ship` és `ShipCard` seed-formátumban történő dokumentálása.

## Projekt

- Repository: `C:\Users\resta\source\repos\ArmadaBackend`
- Megoldás: `C:\Users\resta\source\repos\ArmadaBackend\ArmadaBackend.sln`
- Kimenet: `C:\Users\resta\source\repos\ArmadaBackend\Data\StarWarsArmadaShipCardsLatest.md`

## Kötelező előkészítés

1. Olvasd be teljesen az alábbi fájlokat:
   - `Models/Ship.cs`
   - `Models/ShipCard.cs`
   - `Enums/ShipSize.cs`
   - `Enums/CardCategory.cs`
   - `Data/AppDbContext.cs`
   - `Data/Seed/ModelBuilderSeedExtensions.cs`
   - `Agents/Hajo_Agent.md`, ha létezik
2. A jelenlegi `modelBuilder.Entity<Ship>().HasData(...)` és `modelBuilder.Entity<ShipCard>().HasData(...)` blokkokat tekintsd az összehasonlítás alapjának.
3. A kutatás előtt állapítsd meg a jelenlegi hajók és slotrekordok számát, legnagyobb ID-jét, fakciónkénti és méretenkénti darabszámát, valamint a hibás `ShipId` hivatkozásokat.

## Internetes kutatás

- Kötelezően keress az interneten; ne kizárólag a modellmemóriádra vagy a repository jelenlegi adataira támaszkodj.
- Elsődlegesen az Atomic Mass Games és a Fantasy Flight Games hivatalos dokumentumait, hajókártya-gyűjteményeit, erratáit, pontfrissítéseit és Rapid Reinforcements kiadványait használd.
- A hajó pontértékét, fakcióját, méretét és minden upgrade slotját ellenőrizd. Az ismétlődő slotokat is tartsd meg külön rekordként.
- Közösségi adatbázist csak indexként vagy másodlagos ellenőrzésként használj. Közösségi forrásból származó adatot legalább egy másik, lehetőleg hivatalos forrással ellenőrizz.
- Ellenőrizd, hogy a kutatás napjáig jelent-e meg újabb hivatalos hajó, frakcióátvétel, pontmódosítás vagy slot-errata. Ne csak keresési találati kivonatból dolgozz; nyisd meg a forrást.
- Csak hivatalosan kiadott hajókártyákat gyűjts. A fan-made, Armada Legacy, Nexus, playtest és más nem hivatalos tartalom ne kerüljön a listába.
- A Rapid Reinforcements vagy más hivatalos dokumentum által új fakcióban engedélyezett hajóváltozatokat külön, a megfelelő fakcióhoz tartozó hajókártyaként kezeld.
- Minden felhasznált forrásnál rögzítsd a közvetlen URL-t, a dokumentum verzióját vagy dátumát, a hozzáférés dátumát és azt, hogy mely adatokat igazolja.
- Ha két forrás eltér, a legújabb hivatalos errata vagy pontdokumentum élvez elsőbbséget. Az eltérést dokumentáld; ne találj ki értéket.

## Projektbeli adatformátum

Hajó:

```csharp
new Ship { Id = 1, Size = ShipSize.Flotilla, FactinId = 0, Name = "GR-75 Medium Transports", Point = 18 },
```

Upgrade slot:

```csharp
new ShipCard { Id = 1, ShipId = 1, Category = CardCategory.CommanderRebel },
```

Frakciók:

| `FactinId` | Fakció |
|---:|---|
| 0 | Rebel Alliance |
| 1 | Galactic Empire |
| 2 | Galactic Republic (GAR) |
| 3 | Separatist Alliance (CIS) |

Méretértékek:

| `ShipSize` | Jelentés |
|---|---|
| `Flotilla` | Flotilla |
| `Small` | Small |
| `Medium` | Medium |
| `Large` | Large |
| `Super` | Huge/Super |

Szabályok:

- A modellben szereplő elírt `FactinId` property-nevet változtatás nélkül használd.
- A legfrissebb hivatalos hajópontot használd.
- Upgrade slotként kizárólag az `Enums/CardCategory.cs` fájlban létező kategória szerepelhet.
- Fakcióspecifikus commander-, officer-, title-, retrofit- vagy más slotnál a projekt jelenlegi kategóriatérképét kövesd.
- Ha ugyanabból a slotból kettő van a hajón, két külön `ShipCard` rekordot hozz létre ugyanazzal a `ShipId` és `Category` értékkel.
- A hajó harci statisztikáit, defense tokenjeit, command/squadron/engineering értékeit és támadókockáit ne add hozzá a C# seed-formátumhoz, mert a jelenlegi modell nem tárolja őket. A modellkorlátot a Markdownban dokumentáld.

## ID- és rendezési szabályok

- A jelenlegi hajók ID-jét őrizd meg, ha ugyanazt a `FactinId + Name` logikai hajókártyát azonosítod.
- Új hivatalos hajó a jelenlegi legnagyobb hajó-ID utáni következő szabad ID-t kapja.
- A jelenlegi, változatlan upgrade slotok `ShipCard.Id` értékét lehetőség szerint őrizd meg.
- Új slotrekord a jelenlegi legnagyobb `ShipCard.Id` utáni következő szabad ID-t kapja.
- Törölt vagy hibás rekord ID-jét ne használd fel másik hajóhoz vagy slothoz.
- A `Ship.Id` értékek és a `ShipCard.Id` értékek a saját entitásukon belül legyenek egyediek.
- Minden `ShipCard.ShipId` létező `Ship.Id` értékre mutasson.
- A teljes hajólista növekvő `Ship.Id`, a slotlista növekvő `ShipCard.Id` szerint legyen rendezve.

## Kimeneti Markdown kötelező szerkezete

A `Data/StarWarsArmadaShipCardsLatest.md` fájl tartalmazza:

1. Cím, kutatási dátum, hatókör és a legújabb alkalmazott hivatalos dokumentum/verzió.
2. Forrásjegyzék közvetlen linkekkel és forrásonkénti felhasználási céllal.
3. Fakció-, méret- és `CardCategory` slot-térkép.
4. Összesítő táblázat fakciónként és hajóméretenként, valamint a slotrekordok száma.
5. Összehasonlítás a jelenlegi seed-adattal:
   - hozzáadott, módosított, eltávolítandó, változatlan és bizonytalan hajók száma;
   - pont-, név-, méret-, fakció- és sloteltérések tételesen, régi és új értékkel, indoklással és forrással.
6. A teljes, használatra kész `new Ship { ... }` lista C# kódblokkokban, fakciónként és méretenként tagolva.
7. A teljes, használatra kész `new ShipCard { ... }` lista C# kódblokkokban, hajónként tagolva.
8. Validációs jelentés.
9. Fel nem oldott forrásütközések és a jelenlegi modell korlátai.

## Validáció

- Ellenőrizd gépileg a `Ship.Id` és `ShipCard.Id` értékek pozitivitását és entitáson belüli egyediségét.
- Ellenőrizd a `FactinId + Name` logikai hajóduplikátumokat.
- Ellenőrizd, hogy csak 0, 1, 2 vagy 3 `FactinId` szerepel.
- Ellenőrizd, hogy minden méret létezik a `ShipSize` enumban.
- Ellenőrizd, hogy minden slotkategória létezik a `CardCategory` enumban.
- Ellenőrizd a `ShipCard.ShipId` idegen kulcsokat és azt, hogy minden hajóhoz a forrás szerinti pontos számú és típusú slot tartozik.
- Ellenőrizd, hogy minden hajónak van neve és nem negatív pontértéke.
- Hasonlítsd össze a kimeneti hajó- és slotdarabszámot a forrásokkal, és magyarázd meg az eltéréseket.
- A validáció eredménye és az esetleges hibák kerüljenek bele a kimeneti Markdownba.

## Munkavégzési korlátok

- Csak a `Data/StarWarsArmadaShipCardsLatest.md` fájlt hozd létre vagy módosítsd.
- Ne módosíts C# fájlt, seed-adatot, migrációt, adatbázist, projektfájlt vagy más Markdown-fájlt.
- Ne telepíts csomagot és ne adj hozzá függőséget.
- Ne generálj migrációt, és ne futtasd az adatbázis-frissítést.
- Ha valamely adat nem igazolható, jelöld `ELLENŐRIZENDŐ` értékkel a megjegyzések között; ne találj ki adatot.

## Befejezés

A végén röviden foglald össze a forrásokat, a teljes hajó- és slotrekordszámot, a fakciónkénti darabszámot, a jelenlegi seedhez képest talált eltéréseket, az ID- és idegenkulcs-ellenőrzést, valamint a bizonytalan tételeket. Add meg a létrehozott fájl pontos elérési útját.
