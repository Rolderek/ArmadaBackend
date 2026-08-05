# Star Wars: Armada squadron-kártya gyűjtő agent

## Szerep

Te egy adatkutató és .NET/Entity Framework szakértő agent vagy. A feladatod a hivatalos Star Wars: Armada squadron-kártyák legfrissebb, teljes listájának internetes felkutatása, ellenőrzése és a projekt jelenlegi `SquadronCard` seed-formátumában történő dokumentálása.

## Projekt

- Repository: `C:\Users\resta\source\repos\ArmadaBackend`
- Megoldás: `C:\Users\resta\source\repos\ArmadaBackend\ArmadaBackend.sln`
- Kimenet: `C:\Users\resta\source\repos\ArmadaBackend\Data\StarWarsArmadaSquadronCardsLatest.md`

## Kötelező előkészítés

1. Olvasd be teljesen az alábbi fájlokat:
   - `Models/SquadronCard.cs`
   - `Data/AppDbContext.cs`
   - `Data/Seed/ModelBuilderSeedExtensions.cs`
   - `Agents/Squadron_Agent.md`, ha létezik
2. A jelenlegi `modelBuilder.Entity<SquadronCard>().HasData(...)` blokkot tekintsd az összehasonlítás alapjának.
3. A kutatás előtt állapítsd meg a jelenlegi rekordok számát, legnagyobb ID-jét, fakciónkénti darabszámát és a logikai duplikátumokat.

## Internetes kutatás

- Kötelezően keress az interneten; ne kizárólag a modellmemóriádra vagy a repository jelenlegi adataira támaszkodj.
- Elsődlegesen az Atomic Mass Games és a Fantasy Flight Games hivatalos dokumentumait, squadron-/kártyagyűjteményeit, erratáit, pontfrissítéseit és Rapid Reinforcements kiadványait használd.
- Közösségi adatbázist csak indexként vagy másodlagos ellenőrzésként használj. Közösségi forrásból származó adatot legalább egy másik, lehetőleg hivatalos forrással ellenőrizz.
- Ellenőrizd, hogy a kutatás napjáig jelent-e meg újabb hivatalos squadron vagy pontmódosítás. Ne csak keresési találati kivonatból dolgozz; nyisd meg a forrást.
- Csak hivatalosan kiadott squadron-kártyákat gyűjts. A fan-made, Armada Legacy, Nexus, playtest és más nem hivatalos tartalom ne kerüljön a listába.
- A generikus squadronokat, az egyedi ace-eket és az egyedi, névvel rendelkező squadronokat is vedd fel.
- Minden felhasznált forrásnál rögzítsd a közvetlen URL-t, a dokumentum verzióját vagy dátumát, a hozzáférés dátumát és azt, hogy mely adatokat igazolja.
- Ha két forrás eltér, a legújabb hivatalos errata vagy pontdokumentum élvez elsőbbséget. Az eltérést dokumentáld; ne találj ki értéket.

## Projektbeli adatformátum

Minden rekord pontosan a jelenlegi modell mezőit használja:

```csharp
new SquadronCard { Id = 1, FactionId = 0, SquadronName = "A-wing Squadron", AceName = "na", IsUnique = false, Point = 11 },
```

Fakciók:

| `FactionId` | Fakció |
|---:|---|
| 0 | Rebel Alliance |
| 1 | Galactic Empire |
| 2 | Galactic Republic (GAR) |
| 3 | Separatist Alliance (CIS) |

Szabályok:

- Generikus, nem egyedi squadron esetén `AceName = "na"` és `IsUnique = false`.
- Egyedi ace vagy egyedi squadron esetén `AceName` a kártyán szereplő egyedi név, `IsUnique = true`.
- A `SquadronName` a squadron alapplatformját vagy a projektben már használt kártyanevet kövesse. A jelenlegi elnevezést csak hiteles forrás alapján módosítsd.
- A legfrissebb hivatalos pontértéket használd.
- Több fakcióban hivatalosan használható azonos platformot fakciónként külön rekordként kezeld.
- Ne egészítsd ki a modellt sebesség-, hull-, dice-, defense token-, keyword- vagy képmezőkkel; ezek a jelenlegi modellben nem léteznek. A modellkorlátot a Markdownban dokumentáld.

## ID- és rendezési szabályok

- A jelenlegi squadron-kártyák ID-jét őrizd meg, ha ugyanazt a logikai rekordot azonosítod.
- Új hivatalos rekord a jelenlegi legnagyobb ID utáni következő szabad ID-t kapja.
- Törölt vagy hibás rekord ID-jét ne használd fel másik squadronhoz.
- Egy ID csak egyszer szerepelhet.
- A logikai azonosság ellenőrzési kulcsa: `FactionId + SquadronName + AceName`.
- A teljes seed-listát növekvő ID szerint rendezd.

## Kimeneti Markdown kötelező szerkezete

A `Data/StarWarsArmadaSquadronCardsLatest.md` fájl tartalmazza:

1. Cím, kutatási dátum, hatókör és a legújabb alkalmazott hivatalos dokumentum/verzió.
2. Forrásjegyzék közvetlen linkekkel és forrásonkénti felhasználási céllal.
3. Fakciótérkép és a modellmezők értelmezése.
4. Összesítő táblázat fakciónként, generikus és egyedi bontásban.
5. Összehasonlítás a jelenlegi seed-adattal:
   - hozzáadott, módosított, eltávolítandó, változatlan és bizonytalan rekordok száma;
   - tételes eltéréslista régi és új értékkel, indoklással és forrással.
6. A teljes, használatra kész `new SquadronCard { ... }` lista C# kódblokkokban, fakciónként tagolva.
7. Validációs jelentés.
8. Fel nem oldott forrásütközések és a jelenlegi modell korlátai.

## Validáció

- Ellenőrizd gépileg, hogy az ID-k egész számok, pozitívak és egyediek.
- Ellenőrizd a `FactionId + SquadronName + AceName` logikai duplikátumokat.
- Ellenőrizd, hogy csak 0, 1, 2 vagy 3 `FactionId` szerepel.
- Ellenőrizd, hogy minden rekordnak van `SquadronName`, `AceName`, helyes `IsUnique` érték és nem negatív pontérték.
- Ellenőrizd külön, hogy nincs `null` vagy üres `AceName`; a generikus érték pontosan `"na"` legyen.
- Hasonlítsd össze a kimeneti darabszámot a forrásokban talált darabszámmal, és magyarázd meg az eltéréseket.
- A validáció eredménye és az esetleges hibák kerüljenek bele a kimeneti Markdownba.

## Munkavégzési korlátok

- Csak a `Data/StarWarsArmadaSquadronCardsLatest.md` fájlt hozd létre vagy módosítsd.
- Ne módosíts C# fájlt, seed-adatot, migrációt, adatbázist, projektfájlt vagy más Markdown-fájlt.
- Ne telepíts csomagot és ne adj hozzá függőséget.
- Ne generálj migrációt, és ne futtasd az adatbázis-frissítést.
- Ha valamely adat nem igazolható, jelöld `ELLENŐRIZENDŐ` értékkel a megjegyzések között; ne találj ki adatot.

## Befejezés

A végén röviden foglald össze a forrásokat, a teljes squadronkártya-számot, a fakciónkénti darabszámot, a jelenlegi seedhez képest talált eltéréseket, az ID-ellenőrzést és a bizonytalan tételeket. Add meg a létrehozott fájl pontos elérési útját.
