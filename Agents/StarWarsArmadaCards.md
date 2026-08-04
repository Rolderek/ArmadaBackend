# Star Wars: Armada – teljes upgrade-kártyalista

Ez a fájl az `AppDbContext.OnModelCreating()` metódusában használt `Card` seed-struktúrát követi:

```csharp
new Card { Id = ..., Category = CardCategory...., Name = @"...", Description = @"...", Point = ... }
```

## Hatókör és verzió

- 294 egyedi, hivatalosan kiadott upgrade-kártya.
- A 292 jelenleg használható FFG/AMG lap mellett szerepel a két történelmi, tiltott lap is: `Bail Organa` (Rebel Officer) és `Strategic Adviser`. Ezek leírása `[BANNED]` előtaggal kezdődik.
- Tartalmazza a Rapid Reinforcements I–II lapjait és a 2025. január 10-én hatályba lépett utolsó hivatalos AMG szöveg-/pontfrissítéseket.
- Nem tartalmaz hajó-, squadron-, objective-, campaign-, ARC-, Legacy-, Nexus- vagy más fan-made lapokat.
- Az `Id` értékek 1–294 között újra vannak generálva az enum sorrendje, azon belül a kártyanév alapján. Ezt a listát a jelenlegi `Card.HasData(...)` blokk cseréjére, nem pedig változatlan hozzáfűzésére érdemes használni.
- A leírások megtartják az adatforrás kettőspontos ikonkódjait (például `:nav:`, `:repair:`, `:hit:`, `:officer:`), hogy később veszteség nélkül lehessen őket UI-ikonokra cserélni.

## A jelenlegi modell korlátai

- A `Card` entitás nem tárol külön fakciót, tiltott/legális állapotot, egyediséget, hajóméretet vagy egyéb felszerelési korlátozást. Emiatt ez a seed-adat önmagában nem tud minden listaépítési szabályt kikényszeríteni.
- A `WeapTeam` és a `WeaponsTeamAndOffensiveRetrofit` enumértékek fakciófüggetlenek, miközben több ilyen lap fakcióhoz kötött (például `Caitken and Shollan`, `Clone Gunners`, illetve a boarding teamek).
- A `FleetCommandPRE` közös kategóriába kerülnek Republic-only, Separatist-only és kettős fakciójú lapok is. Ugyanezért a fakciószűrést később külön mezővel vagy kapcsolótáblával érdemes megoldani.

## Források

- AMG Armada Rules and OP: https://www.atomicmassgames.com/swarmadadocs/
- AMG Rules Reference 1.6.0: https://cdn.svc.asmodee.net/production-amgcom/uploads/2025/01/SWM_Rules_Reference_Guide_1.6.0_web.pdf
- AMG Errata 5.5: https://cdn.svc.asmodee.net/production-amgcom/uploads/2025/01/SWM_Errata_5.5.pdf
- AMG Rapid Reinforcements 2.3: https://cdn.svc.asmodee.net/production-amgcom/uploads/2025/01/SWM_RapidReinforcements_2.3.pdf
- FFG Upgrade Card Collection: https://images-cdn.fantasyflightgames.com/filer_public/2a/9d/2a9ddae5-850a-4351-bf83-e0ea78222727/starwarsarmada_upgradecardcollection.pdf
- Géppel olvasható közösségi index (a hivatalos lapokra szűrve): https://api.swarmada.wiki/upgrades/

## Kategória-összesítő

| Enum érték | `CardCategory` | Kártyák |
|---:|---|---:|
| 0 | `CommanderRebel` | 12 |
| 1 | `CommanderImperial` | 13 |
| 2 | `CommanderGAR` | 7 |
| 3 | `CommanderCIS` | 6 |
| 4 | `DefensiveRetrofitOG` | 7 |
| 5 | `DefensiveRetrofitPRE` | 1 |
| 6 | `ExperimentalRetrofit` | 4 |
| 7 | `FleetCommandOG` | 5 |
| 8 | `FleetCommandPRE` | 3 |
| 9 | `FleetSupport` | 7 |
| 10 | `IonCannons` | 9 |
| 11 | `OffensiveRetrofit` | 13 |
| 12 | `OffensiveRetrofitGAR` | 2 |
| 13 | `OffensiveRetrofitCIS` | 2 |
| 14 | `Officer` | 16 |
| 15 | `OfficerRebel` | 15 |
| 16 | `OfficerImperial` | 25 |
| 17 | `OfficerGAR` | 7 |
| 18 | `OfficerCIS` | 9 |
| 19 | `Ordnance` | 8 |
| 20 | `SuperweaponImperial` | 2 |
| 21 | `SuperweaponRebel` | 1 |
| 22 | `SupportTeam` | 7 |
| 23 | `SupportTeamCIS` | 1 |
| 24 | `TitleRebel` | 30 |
| 25 | `TitleImperial` | 30 |
| 26 | `TitleGAR` | 9 |
| 27 | `TitleCIS` | 10 |
| 28 | `Turbolasers` | 14 |
| 29 | `TurbolasersPRE` | 1 |
| 30 | `WeapTeam` | 12 |
| 31 | `WeaponsTeamAndOffensiveRetrofit` | 6 |
|  | **Összesen** | **294** |

## Seed-bejegyzések

## CommanderRebel (12)

```csharp
new Card { Id = 1, Category = CardCategory.CommanderRebel, Name = @"Admiral Ackbar", Description = @"Before a friendly ship's Attack step, it may choose to attack from only its left and right hull zones this round. If it does, it may add 2 red dice to its attack pool while attacking a ship.", Point = 38 },
new Card { Id = 2, Category = CardCategory.CommanderRebel, Name = @"Admiral Raddus", Description = @"Before deploying fleets, you may set aside 1 other friendly ship. At the start of any round, you may deploy that ship at distance 1 of a friendly ship. That ship cannot be deployed overlapping squadrons and cannot be the first ship to activate that round.", Point = 26 },
new Card { Id = 3, Category = CardCategory.CommanderRebel, Name = @"Commander Sato", Description = @"While a friendly ship is attacking a ship at distance 1 of a friendly squadron, before rolling attack dice, the attacker may replace up to 2 dice in its attack pool with an equal number of dice of any color or colors.", Point = 27 },
new Card { Id = 4, Category = CardCategory.CommanderRebel, Name = @"Garm Bel Iblis", Description = @"After deploying fleets, place 2 non-consecutive round tokens on this card. At the start of the Ship Phase during each round matching 1 of those tokens, each friendly ship may gain a number of command tokens equal to its command value.", Point = 25 },
new Card { Id = 5, Category = CardCategory.CommanderRebel, Name = @"General Cracken", Description = @"While a friendly small or medium ship is defending against a ship, if the defender is at speed 3 or higher, the attack is treated as obstructed.", Point = 26 },
new Card { Id = 6, Category = CardCategory.CommanderRebel, Name = @"General Dodonna", Description = @"Before an enemy ship is dealt a faceup damage card, look at the top 4 cards of the damage deck, place 1 on top of the deck and discard the others.", Point = 20 },
new Card { Id = 7, Category = CardCategory.CommanderRebel, Name = @"General Draven", Description = @"Choose command dials for this card after deploying fleets. At the start of each Ship Phase, you may reveal and discard 1 command dial from this card. If you do, until the end of the round, when an enemy ship spends a matching command dial, it resolves that dial as though it spent a token of the same type instead.", Point = 20 },
new Card { Id = 8, Category = CardCategory.CommanderRebel, Name = @"General Madine", Description = @"When a friendly ship is executing its first maneuver during its activation, during the Determine Course step, it may increase 1 yaw value by 1.", Point = 30 },
new Card { Id = 9, Category = CardCategory.CommanderRebel, Name = @"General Rieekan", Description = @"Once per round, when a friendly ship or friendly unique squadron is destroyed, it remains in the play area and is treated as if it was not destroyed until the end of the Status Phase.", Point = 34 },
new Card { Id = 10, Category = CardCategory.CommanderRebel, Name = @"Kyrsta Agate", Description = @"After you deploy, gain 1 non-:scatter: defense token. During your ""Spend Defense Tokens"" step, if your speed is not 0, you may discard 1 defense token to resolve the effect of that defense token. You cannot resolve the effect of each type of defense token more than once per attack.", Point = 25 },
new Card { Id = 11, Category = CardCategory.CommanderRebel, Name = @"Leia Organa", Description = @"When a friendly ship resolves a command by spending a command dial, if it has not resolved another command this round, it may resolve that command as if it also spent a matching command token. If it does, that ship cannot resolve additional commands this round.", Point = 28 },
new Card { Id = 12, Category = CardCategory.CommanderRebel, Name = @"Mon Mothma", Description = @"When a friendly ship resolves the :evade: token effect, it can cancel 1 die at medium range or reroll 1 additional die at close range or distance 1.", Point = 27 },
```

## CommanderImperial (13)

```csharp
new Card { Id = 13, Category = CardCategory.CommanderImperial, Name = @"Admiral Konstantine", Description = @"At the start of each Status Phase, you may choose any number of enemy ships at distance 1-5 of at least 2 friendly non-flotilla ships, 1 of which must be of medium or larger size class. For each chosen ship you may discard 1 :nav: token from it or increase or decrease its speed by 1 to a minimum of speed 1.", Point = 23 },
new Card { Id = 14, Category = CardCategory.CommanderImperial, Name = @"Admiral Motti", Description = @"The hull value of each friendly ship is increased according to its size class: Small ship: 1 Medium ship: 2 Large ship: 3", Point = 24 },
new Card { Id = 15, Category = CardCategory.CommanderImperial, Name = @"Admiral Ozzel", Description = @"During each friendly ship's Determine Course step, it may change its speed by 1.", Point = 20 },
new Card { Id = 16, Category = CardCategory.CommanderImperial, Name = @"Admiral Piett", Description = @"When a friendly ship spends only a command token to resolve a command, you may exhaust this card. If you do, that ship resolves that command as if it had spent a dial of the same type instead.", Point = 22 },
new Card { Id = 17, Category = CardCategory.CommanderImperial, Name = @"Admiral Screed", Description = @"Once per activation, when a friendly ship is attacking, it may spend 1 die to change a die to a face with a :critical: icon.", Point = 24 },
new Card { Id = 18, Category = CardCategory.CommanderImperial, Name = @"Admiral Sloane", Description = @"While a friendly squadron without ROGUE is attacking, it may spend 1 die with an :accuracy: icon to choose and spend 1 of the defender's defense tokens. While attacking a ship, it may also reroll 1 die with a :critical: icon.", Point = 24 },
new Card { Id = 19, Category = CardCategory.CommanderImperial, Name = @"Darth Vader", Description = @"While a friendly ship is attacking a ship, it may spend 1 defense token to reroll any number of dice in its attack pool.", Point = 34 },
new Card { Id = 20, Category = CardCategory.CommanderImperial, Name = @"Emperor Palpatine", Description = @"After deploying fleets, place 1 defense token of each type on this card. At the start of each Ship Phase you may discard 1 of those tokens. If you do, until the end of the round, if an enemy ship or squadron spends a matching token during its Spend Defense Tokens step, discard that token.", Point = 35 },
new Card { Id = 21, Category = CardCategory.CommanderImperial, Name = @"General Romodi", Description = @"While a friendly ship is attacking a ship, if the attack is obstructed by a ship or obstacle, the attacker does not remove a die (even if the attack is also obstructed by a card effect), and may add 1 red die to the attack pool.", Point = 28 },
new Card { Id = 22, Category = CardCategory.CommanderImperial, Name = @"General Tagge", Description = @"After deploying fleets, place 2 non-consecutive round tokens on this card. At the start of the Ship Phase during each round matching 1 of those tokens each friendly ship may recover 1 of its discarded defense tokens.", Point = 25 },
new Card { Id = 23, Category = CardCategory.CommanderImperial, Name = @"Grand Admiral Thrawn", Description = @"Choose command dials for this card after deploying fleets. At the start of each Ship Phase, you may reveal and discard 1 dial from this card. If you do, until the end of the round, when each friendly ship activates, it gains 1 additional dial matching that discarded dial.", Point = 32 },
new Card { Id = 24, Category = CardCategory.CommanderImperial, Name = @"Grand Moff Tarkin", Description = @"At the start of each Ship Phase, you may choose 1 command. Each friendly ship gains a command token matching that command.", Point = 28 },
new Card { Id = 25, Category = CardCategory.CommanderImperial, Name = @"Moff Jerjerrod", Description = @"While a friendly ship executes a maneuver, during the Determine Course step, that ship may suffer 1 damage to change the first yaw value of that maneuver to 'II'.", Point = 23 },
```

## CommanderGAR (7)

```csharp
new Card { Id = 26, Category = CardCategory.CommanderGAR, Name = @"Admiral Tarkin", Description = @"At the start of each Ship Phase, you may discard 1 command token from this card. If you do, either you gain 1 matching command dial, or each friendly ship gains 1 matching command token.", Point = 30 },
new Card { Id = 27, Category = CardCategory.CommanderGAR, Name = @"Admiral Yularen", Description = @"When a friendly ship resolves a :squadron: command, if it spend a :squadron: token, it may activate 1 additional squadron. When a friendly ship resolves a :repair: command, it may spend engineering points on the following repair effect: Repair Squadron: Spend 2 points to choose a friendly squadron at distance 1-3. That squadron recovers 1 hull point.", Point = 24 },
new Card { Id = 28, Category = CardCategory.CommanderGAR, Name = @"Anakin Skywalker", Description = @"While a friendly ship is attacking a ship, if the defender is at distance 1-5 of at least 2 other friendly ships, 1 other friendly ship at distance 1-5 of the defender may spend 1 defense token. If it does, the attacker may reroll up to 3 dice.", Point = 27 },
new Card { Id = 29, Category = CardCategory.CommanderGAR, Name = @"Bail Organa", Description = @"When a friendly ship reveals a command, you may discard up to 1 token of each type from this card. For each token you discard, that ship gains 1 additional command dial matching that token's type.", Point = 28 },
new Card { Id = 30, Category = CardCategory.CommanderGAR, Name = @"Luminara Unduli", Description = @"While a friendly ship or unique squadron is defending, after the Spend Defense Tokens step, if it spent fewer than 2 defense tokens, it may either ready 1 of its defense tokens it did not spend, or choose another friendly ship at distance 1-5 and ready 1 of that ship's defense tokens.", Point = 25 },
new Card { Id = 31, Category = CardCategory.CommanderGAR, Name = @"Obi-Wan Kenobi", Description = @"While a friendly ship is defending, when it spends a readied :redirect: token, it may reduce the total damage by 1 before it suffers damage.", Point = 22 },
new Card { Id = 32, Category = CardCategory.CommanderGAR, Name = @"Plo Koon", Description = @"While a friendly squadron is attacking a ship that is at distance 1-3 of a friendly ship, the attacker may add 1 blue die set to an :accuracy: icon to its attack pool. That die cannot be rerolled or changed. Friendly squadrons without ADEPT gain GRIT while they are at distance 1 of a friendly squadron with ADEPT.", Point = 26 },
```

## CommanderCIS (6)

```csharp
new Card { Id = 33, Category = CardCategory.CommanderCIS, Name = @"Admiral Trench", Description = @"At the start of each Ship Phase, you may reveal and discard 1 command dial from this card. If you do, until the end of the round, when a friendly ship spends only a matching command token to resolve a command, that ship resolves that command as if it had spent a dial and token of the same type instead.", Point = 32 },
new Card { Id = 34, Category = CardCategory.CommanderCIS, Name = @"Count Dooku", Description = @"You must choose at least 2 types of command tokens for this card. At the start of each Ship Phase, you may discard 1 command token from this card. If you do, each enemy ship gains a raid token matching that command token.", Point = 27 },
new Card { Id = 35, Category = CardCategory.CommanderCIS, Name = @"General Grievous", Description = @"When a friendly ship or squadron is destroyed, you may choose 1 friendly ship or unique squadron at distance 1-5 of the destroyed ship or squadron. If you do, the chosen ship or unique squadron may either ready 1 of its defense tokens or recover 1 of its discarded defense tokens and then exhaust that token.", Point = 20 },
new Card { Id = 36, Category = CardCategory.CommanderCIS, Name = @"Kraken", Description = @"Once per activation, while a friendly ship is attacking a ship, if another friendly ship is at close-medium range of the defender, the attacker may change 1 die to a face with any 1 icon (and no other icons).", Point = 30 },
new Card { Id = 37, Category = CardCategory.CommanderCIS, Name = @"Mar Tuuk", Description = @"While a friendly ship is attacking, if the defending hull zone has at least 1 shield remaining, the attacker may add 1 red die to its attack pool. While a friendly ship is attacking a ship that has no shields remaining, after rolling the attack dice, the attacker must cancel 1 attack die.", Point = 28 },
new Card { Id = 38, Category = CardCategory.CommanderCIS, Name = @"TF-1726", Description = @"Once per activation, while a friendly ship is attacking a ship, the attacker adds 1 black die to its attack pool for each raid token the defender has, to a maximum of 2 additional dice.", Point = 26 },
```

## DefensiveRetrofitOG (7)

```csharp
new Card { Id = 39, Category = CardCategory.DefensiveRetrofitOG, Name = @"Advanced Projectors", Description = @"When you resolve the :redirect: token effect, you can choose more than one hull zone to suffer damage, which may include a nonadjacent hull zone", Point = 6 },
new Card { Id = 40, Category = CardCategory.DefensiveRetrofitOG, Name = @"Cluster Bombs", Description = @"After a squadron performs an attack against you, even if you are destroyed, you may discard this card to roll 4 blue dice. That squadron suffers 1 damage for each :hit: or :critical: icon rolled.", Point = 5 },
new Card { Id = 41, Category = CardCategory.DefensiveRetrofitOG, Name = @"Early Warning System", Description = @"At the start of each Ship Phase, you may choose 1 of your hull zones and mark it with a chaff token. Until the end of the round, while a ship or squadron is attacking that hull zone, the attack is obstructed. After the Status Phase, remove that chaff token.", Point = 7 },
new Card { Id = 42, Category = CardCategory.DefensiveRetrofitOG, Name = @"Electronic Countermeasures", Description = @"While defending you may exhaust this card to spend 1 defense token that your opponent targeted with an :accuracy: result.", Point = 7 },
new Card { Id = 43, Category = CardCategory.DefensiveRetrofitOG, Name = @"Reactive Gunnery", Description = @"While defending, you may exhaust this card and spend a readied defense token to resolve the :salvo: defense effect instead of that token's effect. You cannot resolve the :salvo: defense effect more than once per attack.", Point = 4 },
new Card { Id = 44, Category = CardCategory.DefensiveRetrofitOG, Name = @"Redundant Shields", Description = @"_Modification_. At the start of each Status Phase, you may recover 1 shield.", Point = 8 },
new Card { Id = 45, Category = CardCategory.DefensiveRetrofitOG, Name = @"Reinforced Blast Doors", Description = @"At the start of the Ship Phase, you may discard this card to discard up to 3 of your facedown damage cards.", Point = 5 },
```

## DefensiveRetrofitPRE (1)

```csharp
new Card { Id = 46, Category = CardCategory.DefensiveRetrofitPRE, Name = @"Thermal Shields", Description = @"While defending, after the attacker gathers dice, you may spend 1 :brace: token. If you do, choose and remove half of the dice in the attack pool, rounded down.", Point = 5 },
```

## ExperimentalRetrofit (4)

```csharp
new Card { Id = 47, Category = CardCategory.ExperimentalRetrofit, Name = @"G7-X Grav Well Projector", Description = @"Before deploying fleets, place 1 grav well token anywhere in the play area. When a ship deploys at distance 1-3 of a grav well token, its speed dial must be set to 0.", Point = 2 },
new Card { Id = 48, Category = CardCategory.ExperimentalRetrofit, Name = @"G-8 Experimental Projector", Description = @"Before an enemy ship at distance 1-5 resolves the Determine Course step, you may exhaust this card to temporarily reduce its speed by 1 to a minimum of speed 0 until the end of the maneuver.", Point = 8 },
new Card { Id = 49, Category = CardCategory.ExperimentalRetrofit, Name = @"Grav Shift Reroute", Description = @"Before deploying fleets, place 1 grav shift token anywhere in the play area. After deploying fleets, you may move each obstacle at distance 1-3 of that token to within distance 1-2 of that obstacle's current location. Obstacles cannot overlap tokens, obstacles, or ships.", Point = 2 },
new Card { Id = 50, Category = CardCategory.ExperimentalRetrofit, Name = @"Targeting Scrambler", Description = @"While a friendly ship at distance 1-3 is defending at close range, during the Spend Defense Tokens step, you may exhaust this card to force the attacker to reroll up to 4 dice of your choice.", Point = 5 },
```

## FleetCommandOG (5)

```csharp
new Card { Id = 51, Category = CardCategory.FleetCommandOG, Name = @"All Fighters, Follow Me!", Description = @"At the start of the Ship Phase, you may discard this card or spend a :squadron: token. If you do, until the end of the round, the speed of each squadron that a friendly ship activates is increased by 1, to a maximum of 5, until the end of that squadron's activation.", Point = 5 },
new Card { Id = 52, Category = CardCategory.FleetCommandOG, Name = @"Entrapment Formation!", Description = @"At the start of the Ship Phase, you may discard this card or spend a :nav: token. If you do, until the end of the round, each friendly ship may change its speed by 1 during its Determine Course step.", Point = 5 },
new Card { Id = 53, Category = CardCategory.FleetCommandOG, Name = @"Intensify Firepower!", Description = @"At the start of the Ship Phase, you may discard this card or spend a :confire: token. If you do, until the end of the round, while each friendly ship is attacking a ship, it may change 1 die to a face with 1 :hit: icon and no other icons.", Point = 6 },
new Card { Id = 54, Category = CardCategory.FleetCommandOG, Name = @"Shields to Maximum!", Description = @"At the start of the Ship Phase, you may discard this card or spend a :repair: token. If you do, until the end of the round, before a friendly ship reveals a command, it may recover 1 shield.", Point = 6 },
new Card { Id = 55, Category = CardCategory.FleetCommandOG, Name = @"Take Evasive Action!", Description = @"At the start of the Ship Phase, you may discard this card or spend a :nav: token. If you do, until the end of the round, each friendly ship may increase the last yaw value of its current speed by 1 during its Determine Course step.", Point = 6 },
```

## FleetCommandPRE (3)

```csharp
new Card { Id = 56, Category = CardCategory.FleetCommandPRE, Name = @"Hot Landing", Description = @"At the start of the Squadron Phase, friendly squadrons with adept gain grit until the end of the phase. When a friendly squadron with adept is destroyed, you may choose 1 enemy ship at distance 1-2 of that squadron. If you do, that ship gains 1 raid token of your choice.", Point = 3 },
new Card { Id = 57, Category = CardCategory.FleetCommandPRE, Name = @"Jedi Hostage", Description = @"When an enemy ship declares you as the target of a non-:salvo: attack, if this card is readied, the attacker gains a raid token of its choice, if able. When an enemy ship at close range reveals a command, it may discard a :squadron: dial to exhaust this card. While defending, if this card is exhausted, you cannot spend more than 1 defense token.", Point = 3 },
new Card { Id = 58, Category = CardCategory.FleetCommandPRE, Name = @"Mercy Mission", Description = @"Before deploying fleets, un-equip this card and choose 1 friendly small ship that is not your flagship. Equip this card to the chosen ship (even if it does not have a :fleet command: icon in its upgrade bar). At the end of the game, if you are within the enemy deployment zone, increase your score by 40 points; if you were destroyed, increase your opponent's score by 15 points.", Point = 5 },
```

## FleetSupport (7)

```csharp
new Card { Id = 59, Category = CardCategory.FleetSupport, Name = @"Bomber Command Center", Description = @"While a friendly squadron with Bomber at distance 1-5 is attacking a ship, it may reroll 1 die.", Point = 8 },
new Card { Id = 60, Category = CardCategory.FleetSupport, Name = @"Comms Net", Description = @"After the Reveal Command Dial Step, you may remove 1 command token from this ship to assign a matching token to another friendly ship at distance 1-5.", Point = 2 },
new Card { Id = 61, Category = CardCategory.FleetSupport, Name = @"Jamming Field", Description = @"While a squadron at distance 1-2 is attacking a squadron or defending against a squadron, the attack must be treated as obstructed.", Point = 2 },
new Card { Id = 62, Category = CardCategory.FleetSupport, Name = @"Munitions Resupply", Description = @"After your Reveal Command Dial step, you may exhaust this card and discard any number of :confire: tokens from it to choose that many friendly ships at distance 1-5. Assign each chosen ship a :confire: token.", Point = 3 },
new Card { Id = 63, Category = CardCategory.FleetSupport, Name = @"Parts Resupply", Description = @"After your Reveal Command Dial step, you may exhaust this card and discard any number of :repair: tokens from it to choose that many friendly ships at distance 1-5. Assign each chosen ship a :repair: token.", Point = 3 },
new Card { Id = 64, Category = CardCategory.FleetSupport, Name = @"Repair Crews", Description = @":repair:: Instead of spending engineering points, you may discard 1 damage card from 1 friendly ship at distance 1-2.", Point = 3 },
new Card { Id = 65, Category = CardCategory.FleetSupport, Name = @"Slicer Tools", Description = @"After you execute a maneuver, you may exhaust this card to choose an enemy ship at distance 1-3. Look at the top command dial assigned to that ship. Then you may either choose a new command on its top command dial or that ship gains 1 raid token of your choice that does not match its top command dial. If the chosen ship has no top command dial, it gains 1 raid token of your choice.", Point = 7 },
```

## IonCannons (9)

```csharp
new Card { Id = 66, Category = CardCategory.IonCannons, Name = @"Heavy Ion Emplacements", Description = @"BLUE :crit: : You may exhaust this card. If you do, the defending hull zone and each adjacent hull zone loses 1 shield.", Point = 9 },
new Card { Id = 67, Category = CardCategory.IonCannons, Name = @"High-Capacity Ion Turbines", Description = @"Modification. The battery armaments for your left and right hull zones are increased by 1 blue die.", Point = 6 },
new Card { Id = 68, Category = CardCategory.IonCannons, Name = @"Ion Cannon Batteries", Description = @"Blue :critical:: Choose and discard 1 command token from the defender. If the defender does not have any command tokens, the defending hull zone loses 1 shield instead.", Point = 5 },
new Card { Id = 69, Category = CardCategory.IonCannons, Name = @"Leading Shots", Description = @"While attacking, you may spend 1 blue die to reroll any number of dice in your attack pool.", Point = 5 },
new Card { Id = 70, Category = CardCategory.IonCannons, Name = @"MS-1 Ion Cannons", Description = @"Blue :crit:: Choose and exhaust 1 of the defender's upgrade cards.", Point = 2 },
new Card { Id = 71, Category = CardCategory.IonCannons, Name = @"NK-7 Ion Cannons", Description = @"Blue :critical: : Exhaust this card to force the defender to choose and discard 1 of its defense tokens.", Point = 6 },
new Card { Id = 72, Category = CardCategory.IonCannons, Name = @"Overload Pulse", Description = @"BLUE :crit: : Exhaust all of the defender's defense tokens.", Point = 6 },
new Card { Id = 73, Category = CardCategory.IonCannons, Name = @"Point Defense Ion Cannons", Description = @"While defending at close range or distance 1, during the Spend Defense Tokens step, you may force the attacker to reroll 1 die of your choice.", Point = 6 },
new Card { Id = 74, Category = CardCategory.IonCannons, Name = @"SW-7 Ion Batteries", Description = @"While attacking a ship, each of your unspent blue :accuracy: icons adds 1 damage to the damage total.", Point = 5 },
```

## OffensiveRetrofit (13)

```csharp
new Card { Id = 75, Category = CardCategory.OffensiveRetrofit, Name = @"Advanced Transponder Net", Description = @"Modification. Friendly heavy squadrons at distance 1-2 prevent engaged squadrons from attacking ships.", Point = 5 },
new Card { Id = 76, Category = CardCategory.OffensiveRetrofit, Name = @"Boosted Comms", Description = @":squadron: : You can activate friendly squadrons at close-long range (instead of close-medium).", Point = 4 },
new Card { Id = 77, Category = CardCategory.OffensiveRetrofit, Name = @"Disposable Capacitors", Description = @"When you activate, you may discard this card. If you do, the blue dice in your battery armament can be used while attacking ships at close-long range until the end of the round.", Point = 3 },
new Card { Id = 78, Category = CardCategory.OffensiveRetrofit, Name = @"Expanded Hangar Bay", Description = @"Your squadron value is increased by 1.", Point = 5 },
new Card { Id = 79, Category = CardCategory.OffensiveRetrofit, Name = @"Flag Bridge", Description = @"Medium or large ship only. Flagship only. Modification You gain 1 :fleet-command: icon in your upgrade bar. You cannot spend a command token to resolve a :fleet-command: card's effect.", Point = 0 },
new Card { Id = 80, Category = CardCategory.OffensiveRetrofit, Name = @"Flak Guns", Description = @"Treat each die in your anti-squadron armament as black. While performing a :salvo: attack, the black dice in your battery armament can be used at medium range and the blue dice in your battery armament can be used at long range.", Point = 3 },
new Card { Id = 81, Category = CardCategory.OffensiveRetrofit, Name = @"Hardened Bulkheads", Description = @"Large ship only. When you overlap a ship of a smaller size class (or are overlapped by a ship of a smaller size class), deal 1 fewer facedown damage card to your ship.", Point = 5 },
new Card { Id = 82, Category = CardCategory.OffensiveRetrofit, Name = @"Phylon Q7 Tractor Beams", Description = @"_Modification_. When you activate, you may exhaust this card to choose 1 enemy ship of your size class or smaller at distance 1-5. That ship must spend a :navigate: token or reduce its speed by 1 to a minimum of 1.", Point = 6 },
new Card { Id = 83, Category = CardCategory.OffensiveRetrofit, Name = @"Point-Defense Reroute", Description = @"While attacking a squadron at close range, you may reroll your :critical: icons", Point = 5 },
new Card { Id = 84, Category = CardCategory.OffensiveRetrofit, Name = @"Proximity Mines", Description = @"Before deploying fleets, you may discard this card to place a number of proximity mine tokens equal to half your engineering value, rounded down. You may place these mines anywhere in the play area beyond distance 5 of enemy ships (and distance 1 of each other).", Point = 4 },
new Card { Id = 85, Category = CardCategory.OffensiveRetrofit, Name = @"Quad Laser Turrets", Description = @"While defending at distance 1, if the attacker is a squadron, you have Counter 1.", Point = 5 },
new Card { Id = 86, Category = CardCategory.OffensiveRetrofit, Name = @"Rapid Launch Bays", Description = @"Before deploying fleets, you may set aside a number of friendly squadrons up to your squadron value next to your ship card. When you reveal a command, you may discard this card. If you do, place each squadron set aside with this card within distance 1-2 of you. Those squadrons cannot move during your activation.", Point = 6 },
new Card { Id = 87, Category = CardCategory.OffensiveRetrofit, Name = @"Reserve Hangar Deck", Description = @"When a friendly non-unique squadron with swarm at distance 1-5 is destroyed, you may discard this card. If you do, you may set that squadron's hull points to ""2"" and place that squadron unengaged at distance 1 with its activation slider toggled to the activated side.", Point = 4 },
```

## OffensiveRetrofitGAR (2)

```csharp
new Card { Id = 88, Category = CardCategory.OffensiveRetrofitGAR, Name = @"Hyperspace Rings", Description = @"Before deploying fleets, you may choose a number of friendly, non-rogue squadrons up to your squadron value. Those squadrons gain scout.", Point = 3 },
new Card { Id = 89, Category = CardCategory.OffensiveRetrofitGAR, Name = @"SPHA-T", Description = @"_Modification_. Decrease your squadron value by 2. Ignition (Close) Each of your front, left, or right firing arcs is also a special firing arc. You have a special battery armament of 5 blue dice and 1 black die. After you place your targeting token, exhaust this card. While this card is exhausted, you cannot place targeting tokens.", Point = 7 },
```

## OffensiveRetrofitCIS (2)

```csharp
new Card { Id = 90, Category = CardCategory.OffensiveRetrofitCIS, Name = @"B2 Rocket Troopers", Description = @"While performing a non-:salvo: attack against a ship at close-medium range, you may exhaust this card. If you do, the defender gains 1 raid token of your choice. While attacking a squadron, you may exhaust this card. If you do, add 1 die of a color already in your attack pool to your attack pool.", Point = 7 },
new Card { Id = 91, Category = CardCategory.OffensiveRetrofitCIS, Name = @"Hyperwave Signal Boost", Description = @"During the Squadron Phase, when it is your fleet's turn to activate squadrons, you may exhaust this card to choose a number of unactivated, friendly squadrons at close-long range up to your squadron value. This turn, activate each of those squadrons. While attacking, each of those squadrons with AI are treated as if activated by a :squadron: command.", Point = 3 },
```

## Officer (16)

```csharp
new Card { Id = 92, Category = CardCategory.Officer, Name = @"Chart Officer", Description = @"After you execute a maneuver, if you overlapped an obstacle, you may discard this card instead of resolving the effects of overlapping that obstacle.", Point = 2 },
new Card { Id = 93, Category = CardCategory.Officer, Name = @"Damage Control Officer", Description = @"When you resolve the :contain: defense effect, you can prevent the attacker from resolving any critical effects.", Point = 3 },
new Card { Id = 94, Category = CardCategory.Officer, Name = @"Defense Liaison", Description = @"Before you reveal a command, you may spend 1 command token to change that command to a :nav: or :repair: command.", Point = 3 },
new Card { Id = 95, Category = CardCategory.Officer, Name = @"Engineering Captain", Description = @"Before you reveal a command, you may change that command to a :repair: command.", Point = 6 },
new Card { Id = 96, Category = CardCategory.Officer, Name = @"Expert Shield Tech", Description = @"While defending, during the Spend Defense Tokens step, when you spend a :redirect: defense token, you may reduce the total damage from the attack by 1 instead of resolving that token's effect.", Point = 5 },
new Card { Id = 97, Category = CardCategory.Officer, Name = @"Flight Commander", Description = @"During your activation, you can resolve your :squadron: command after you execute a maneuver.", Point = 3 },
new Card { Id = 98, Category = CardCategory.Officer, Name = @"Hondo Ohnaka", Description = @"At the start of the ship phase, you may discard this card to choose 2 different command tokens and place them on 2 different ships. Then your opponent chooses 2 different command tokens you did not choose and places them on 2 different ships.", Point = 2 },
new Card { Id = 99, Category = CardCategory.Officer, Name = @"Intel Officer", Description = @"While attacking, after you roll your attack pool, you may exhaust this card to choose 1 defense token. If that token is spent during this attack, discard that token.", Point = 7 },
new Card { Id = 100, Category = CardCategory.Officer, Name = @"Navigation Officer", Description = @"Before you reveal a command, you may change that command to a :navigate: command.", Point = 6 },
new Card { Id = 101, Category = CardCategory.Officer, Name = @"Skilled First Officer", Description = @"Before you reveal a command, you may discard this card to discard your top command dial.", Point = 1 },
new Card { Id = 102, Category = CardCategory.Officer, Name = @"Strategic Adviser", Description = @"[BANNED - not legal in competitive events.] Large ship only. When it is your turn to activate, you may exhaust this card to pass your turn; your opponent activates a ship instead.", Point = 4 },
new Card { Id = 103, Category = CardCategory.Officer, Name = @"Support Officer", Description = @"At the start of the Command Phase, you may discard this card to discard all of your command dials.", Point = 2 },
new Card { Id = 104, Category = CardCategory.Officer, Name = @"Tactical Expert", Description = @"Before you reveal a command, you may change that command to a :concentrate fire: command.", Point = 6 },
new Card { Id = 105, Category = CardCategory.Officer, Name = @"Veteran Captain", Description = @"When you reveal a command, you may discard this card to gain 1 command token of your choice.", Point = 2 },
new Card { Id = 106, Category = CardCategory.Officer, Name = @"Weapons Liaison", Description = @"Before you reveal a command, you may spend 1 command token to change that command to a :confire: or :squadron: command.", Point = 3 },
new Card { Id = 107, Category = CardCategory.Officer, Name = @"Wing Commander", Description = @"Before you reveal a command, you may change that command to a :squadron: command.", Point = 6 },
```

## OfficerRebel (15)

```csharp
new Card { Id = 108, Category = CardCategory.OfficerRebel, Name = @"Adar Tallon", Description = @"After you resolve a :squadron: command, exhaust this card to toggle the activation slider of 1 squadron activated with that command", Point = 10 },
new Card { Id = 109, Category = CardCategory.OfficerRebel, Name = @"Ahsoka Tano", Description = @"During the activation of a friendly ship at distance 1-5, you may exhaust this card to discard 1 command token from that ship. If you do, that ship may gain 1 command token of any type.", Point = 2 },
new Card { Id = 110, Category = CardCategory.OfficerRebel, Name = @"Bail Organa", Description = @"[BANNED - not legal in competitive events.] Medium or large ship only. After deploying fleets, you may place 1 round token on this card. At the start of the Ship Phase of the round matching that token, if you are the second player you must activate; if you are the first player, you may gain up to 2 command tokens of your choice.", Point = 7 },
new Card { Id = 111, Category = CardCategory.OfficerRebel, Name = @"Captain Rex", Description = @":squadron:: You may choose 1 enemy ship at close range. That ship gains 1 raid token of your choice. While you are at distance 1-3 of an enemy ship, that ship can discard only 1 raid token of any type when it discards a command dial.", Point = 5 },
new Card { Id = 112, Category = CardCategory.OfficerRebel, Name = @"Ezra Bridger", Description = @"When you reveal a command, you may discard this card to move 1 obstacle at distance 1-2 so that it is within distance 1-2 of its current location.", Point = 3 },
new Card { Id = 113, Category = CardCategory.OfficerRebel, Name = @"General Draven", Description = @"While attacking a squadron with counter or intel, add 1 die of any color to your attack pool.", Point = 3 },
new Card { Id = 114, Category = CardCategory.OfficerRebel, Name = @"Kyrsta Agate", Description = @"Red or Blue :crit:: You may exhaust this card to ready 1 of your exhausted defense tokens. You can resolve this critical effect during a Salvo attack.", Point = 5 },
new Card { Id = 115, Category = CardCategory.OfficerRebel, Name = @"Lando Calrissian", Description = @"While defending, during the Spend Defense Tokens Step, you may discard this card to force the attacker to reroll 1 or more dice of your choice.", Point = 4 },
new Card { Id = 116, Category = CardCategory.OfficerRebel, Name = @"Leia Organa", Description = @"When you reveal a command, you may choose another friendly ship at distance 1-5 and change that ship's top command to your revealed command.", Point = 3 },
new Card { Id = 117, Category = CardCategory.OfficerRebel, Name = @"Major Derlin", Description = @"Before you suffer damage from an attack, you may exhaust this card to reduce the total damage by 1.", Point = 7 },
new Card { Id = 118, Category = CardCategory.OfficerRebel, Name = @"Raymus Antilles", Description = @"When you reveal a command, you may gain 1 matching command token without spending the command dial.", Point = 7 },
new Card { Id = 119, Category = CardCategory.OfficerRebel, Name = @"Sabine Wren", Description = @"At the start of the Ship Phase, you may discard this card to place 1 proximity mine token in the play area at distance 1-2 of an obstacle and beyond distance 3 of enemy ships.", Point = 4 },
new Card { Id = 120, Category = CardCategory.OfficerRebel, Name = @"Toryn Farr", Description = @"While another friendly ship or squadron at distance 1-3 is attacking, it may reroll 1 blue die.", Point = 7 },
new Card { Id = 121, Category = CardCategory.OfficerRebel, Name = @"Walex Blissex", Description = @"When you activate, you may discard this card to recover 1 of your discarded defense tokens.", Point = 5 },
new Card { Id = 122, Category = CardCategory.OfficerRebel, Name = @"Wedge Antilles", Description = @"Before the end of the Squadron Phase, you may spend 1 :squadron: token to choose up to 3 friendly non-unique squadrons without Strategic at distance 1-5. Those squadrons gain Cloak until the end of the round.", Point = 4 },
```

## OfficerImperial (25)

```csharp
new Card { Id = 123, Category = CardCategory.OfficerImperial, Name = @"Admiral Chiraneau", Description = @":Squadron:; Squadrons that you activate can move even if they are engaged. When an engaged squadron moves in this way, treat it as having a printed speed of 2.", Point = 10 },
new Card { Id = 124, Category = CardCategory.OfficerImperial, Name = @"Admiral Montferrat", Description = @"While defending against a ship, if your speed is 3 or higher, the attack is treated as obstructed. After you execute a maneuver, if you overlapped a ship, discard this card.", Point = 5 },
new Card { Id = 125, Category = CardCategory.OfficerImperial, Name = @"Admiral Ozzel", Description = @"At the start of the first round, you may execute a speed-1 maneuver.", Point = 2 },
new Card { Id = 126, Category = CardCategory.OfficerImperial, Name = @"Admiral Titus", Description = @"At the start of the first round, you may change 1 enemy ship's speed by 1.", Point = 2 },
new Card { Id = 127, Category = CardCategory.OfficerImperial, Name = @"Agent Kallus", Description = @"While attacking a unique squadron, add 1 die of any color to your attack pool.", Point = 3 },
new Card { Id = 128, Category = CardCategory.OfficerImperial, Name = @"Captain Brunson", Description = @"While defending at distance 1-2 of an obstacle, during the Spend Defense Tokens step, you may exhaust this card to choose and cancel 1 attack die.", Point = 9 },
new Card { Id = 129, Category = CardCategory.OfficerImperial, Name = @"Captain Needa", Description = @"At the start of the first round, you may replace 1 of your defense tokens with an :evade: defense token.", Point = 2 },
new Card { Id = 130, Category = CardCategory.OfficerImperial, Name = @"Commandant Aresko", Description = @"When another friendly ship at distance 1-3 reveals a command, you may exhaust this card to gain 1 command token of the same type.", Point = 7 },
new Card { Id = 131, Category = CardCategory.OfficerImperial, Name = @"Commander Beck", Description = @"During your activation, you may resolve a command as if you had spent a command token. If you do, gain 1 raid token of the matching type. You may resolve this effect twice per activation.", Point = 3 },
new Card { Id = 132, Category = CardCategory.OfficerImperial, Name = @"Commander Gherant", Description = @"While you are defending, the attacker cannot resolve critical effects. After you perform an attack against a ship, discard this card.", Point = 2 },
new Card { Id = 133, Category = CardCategory.OfficerImperial, Name = @"Commander Vanto", Description = @"After you resolve the first command during your activation, you may exhaust this card to gain 1 command token of any type.", Point = 7 },
new Card { Id = 134, Category = CardCategory.OfficerImperial, Name = @"Commander Woldar", Description = @"While a friendly, non-SWARM squadron at distance 1-3 is attacking a squadron, it may reroll 1 die of any color.", Point = 4 },
new Card { Id = 135, Category = CardCategory.OfficerImperial, Name = @"Darth Vader", Description = @"While a friendly ship at distance 1-5 attacking a ship, it may discard 1 of its :commander: or :officer: cards (other than Darth Vader) to reroll any number of dice in its attack pool.", Point = 4 },
new Card { Id = 136, Category = CardCategory.OfficerImperial, Name = @"Director Isard", Description = @"When you reveal a command, you may look at all command dials assigned to 1 enemy ship.", Point = 3 },
new Card { Id = 137, Category = CardCategory.OfficerImperial, Name = @"Director Krennic", Description = @":confire:: While attacking at medium-long range, if you spent a :confire: dial, you may also reroll any number of red dice in your attack pool. If you spent a :confire: token, you may also reroll up to 2 red dice in your attack pool.", Point = 8 },
new Card { Id = 138, Category = CardCategory.OfficerImperial, Name = @"Emperor Palpatine", Description = @"When an enemy ship or unique squadron declares you as the target of an attack, it must spend 1 of its defense tokens (if able).", Point = 3 },
new Card { Id = 139, Category = CardCategory.OfficerImperial, Name = @"Governor Pryce", Description = @"Once per activation, while performing an attack against an enemy ship, you may spend 1 shield from the attacking hull zone to change 1 die face to any face without an :accuracy: icon.", Point = 6 },
new Card { Id = 140, Category = CardCategory.OfficerImperial, Name = @"Iden Versio", Description = @"When you resolve the :evade: defense effect, you can cancel 1 die at close range or distance 1. :squadron:: You may discard this card to choose 1 enemy ship at close range. That ship gains 1 raid token of your choice.", Point = 6 },
new Card { Id = 141, Category = CardCategory.OfficerImperial, Name = @"Instructor Goran", Description = @"While a friendly non-HEAVY squadron is at distance 1-2, it has COUNTER 1 or increases its COUNTER value by 1.", Point = 7 },
new Card { Id = 142, Category = CardCategory.OfficerImperial, Name = @"Lira Wessex", Description = @"When you are dealt a faceup damage card, you may spend 1 :repair: token to flip that card facedown (without resolving its effect).", Point = 2 },
new Card { Id = 143, Category = CardCategory.OfficerImperial, Name = @"Minister Tua", Description = @"You gain an additional :defensive_retro: icon in your upgrade bar. You cannot equip this card to a medium or large ship with a :defensive_retro: icon in its upgrade bar.", Point = 2 },
new Card { Id = 144, Category = CardCategory.OfficerImperial, Name = @"Reeva Demesne", Description = @"After you are declared as the target of an attack, if the defending hull zone has at least 1 shield remaining, you may exhaust this card to ready 1 defense token.", Point = 4 },
new Card { Id = 145, Category = CardCategory.OfficerImperial, Name = @"Taskmaster Grint", Description = @"Choose the command token for this card after deploying fleets. When you reveal a command matching the token on this card, you may gain 1 matching command token without spending the command dial.", Point = 5 },
new Card { Id = 146, Category = CardCategory.OfficerImperial, Name = @"The Grand Inquisitor", Description = @"When an enemy ship at distance 1-5 changes its speed, you may exhaust this card to increase or decrease your speed by 1.", Point = 4 },
new Card { Id = 147, Category = CardCategory.OfficerImperial, Name = @"Wullf Yularen", Description = @"When you spend a command token, you may exhaust this card to gain 1 command token of the same type", Point = 7 },
```

## OfficerGAR (7)

```csharp
new Card { Id = 148, Category = CardCategory.OfficerGAR, Name = @"Adi Gallia", Description = @"While defending, when you suffer damage from an attack, you may suffer up to 1 of that damage on the shields of a hull zone adjacent to the defending hull zone for each defense token you spent during the Spend Defense Tokens step. If you do, suffer any remaining damage on the defending hull zone.", Point = 3 },
new Card { Id = 149, Category = CardCategory.OfficerGAR, Name = @"Ahsoka Tano", Description = @":squadron: : Each of up to 3 non-unique squadrons that you activate gain snipe 1 for each die in their anti-squadron armament, to a maximum of snipe 3, until the end of its activation.", Point = 6 },
new Card { Id = 150, Category = CardCategory.OfficerGAR, Name = @"Barriss Offee", Description = @"While defending, after the attacker declares the defending hull zone, you may spend 1 :redirect: token. If you do, at the start of the Resolve Damage step, choose a different hull zone to be the defending hull zone for this attack.", Point = 6 },
new Card { Id = 151, Category = CardCategory.OfficerGAR, Name = @"Clone Captain Silver", Description = @"When you execute a maneuver, during your Determine Course step, if you have not resolved a :navigate: command during this activation, you may exhaust this card to increase or decrease your speed by up to 3. If you do, you cannot resolve a :navigate: command during this activation. You can spend tokens from this card to ready it.", Point = 4 },
new Card { Id = 152, Category = CardCategory.OfficerGAR, Name = @"Clone Captain Zak", Description = @"While attacking from your side or rear hull zones, you may exhaust this card to add 1 die to your attack pool of a color already in your attack pool (you cannot add dice to a :salvo: attack). You can spend tokens from this card to ready it.", Point = 5 },
new Card { Id = 153, Category = CardCategory.OfficerGAR, Name = @"Clone Commander Wolffe", Description = @":squadron: : You may exhaust this card. If you do: Each of up to 3 squadrons that you activate without adept gain assault until the end of its activation. Each squadron that you activate with the *assault* keyword can spend a die with a :hit: or :accuracy: icon to resolve the assault effect. You can spend tokens from this card to ready it.", Point = 6 },
new Card { Id = 154, Category = CardCategory.OfficerGAR, Name = @"Clone Navigation Officer", Description = @"When you reveal a :confire:, :nav:, or :squadron: command, you may exhaust this card to choose a friendly ship at distance 1-5. That ship may gain 1 command token matching your command. You can spend tokens from this card to ready it.", Point = 4 },
```

## OfficerCIS (9)

```csharp
new Card { Id = 155, Category = CardCategory.OfficerCIS, Name = @"Asajj Ventress", Description = @"After you perform an attack targeting a ship that has 1 or more raid tokens, if the defender suffered one or more damage, you may remove 1 raid token and 1 command token from the defender. If you do, gain a matching command token.", Point = 2 },
new Card { Id = 156, Category = CardCategory.OfficerCIS, Name = @"Passel Argente", Description = @"When you reveal a command, you may place a matching command token on this card. Then, if you have at least 1 :nav:, 1 :squadron:, 1 :confire:, and 1 :repair: command token on this card, you may gain 1 additional command dial of your choice.", Point = 6 },
new Card { Id = 157, Category = CardCategory.OfficerCIS, Name = @"Rune Haako", Description = @"When you reveal a command, you may choose another friendly ship at distance 1-5. If you do, discard any number of command tokens from that ship, this card, or both, to gain 1 matching command token for each discarded token.", Point = 4 },
new Card { Id = 158, Category = CardCategory.OfficerCIS, Name = @"San Hill", Description = @"When a friendly ship at distance 1-5 resolves a :squad: command, you may discard 1 :squad: token from this card. If you do, that friendly ship may activate 1 additional squadron during that command.", Point = 3 },
new Card { Id = 159, Category = CardCategory.OfficerCIS, Name = @"Shu Mai", Description = @"After deploying fleets, you may place 2 non-consecutive round tokens on this card. During each round matching 1 of those tokens, while attacking a ship you may reroll up to 3 dice.", Point = 4 },
new Card { Id = 160, Category = CardCategory.OfficerCIS, Name = @"TI-99", Description = @"While a friendly unactivated squadron is at distance 1-3, it gains counter 3 or, if it has the printed counter keyword, gains an additional counter 1. After it performs a counter attack, toggle its activation slider to the activated side.", Point = 4 },
new Card { Id = 161, Category = CardCategory.OfficerCIS, Name = @"Tikkes", Description = @"When you reveal a command, you may place a matching command token on this card. If you do, gain a command token of your choice. During the Command Phase, if you have a command token on this card, you must choose that command on each command dial that is to be assigned to you and show those dials to your opponent. Then discard that command token.", Point = 2 },
new Card { Id = 162, Category = CardCategory.OfficerCIS, Name = @"T-series Tactical Droid", Description = @"When you spend only a :repair:, :nav: or :squadron: command token to resolve a command, you may exhaust this card. If you do, resolve that command as if you had spent a dial of the same type instead.", Point = 4 },
new Card { Id = 163, Category = CardCategory.OfficerCIS, Name = @"Wat Tambor", Description = @":repair: : You may spend up to 2 shields from any of your hull zones or any 1 hull zone on another friendly ship at distance 1-5 to gain twice that many additional engineering points.", Point = 9 },
```

## Ordnance (8)

```csharp
new Card { Id = 164, Category = CardCategory.Ordnance, Name = @"Assault Concussion Missiles", Description = @"BLACK :crit: : Exhaust this card. Each hull zone adjacent to the defending hull zone suffers 1 damage.", Point = 5 },
new Card { Id = 165, Category = CardCategory.Ordnance, Name = @"Assault Proton Torpedoes", Description = @"BLACK :crit: : Exhaust this card to deal 1 faceup damage card to the defender.", Point = 4 },
new Card { Id = 166, Category = CardCategory.Ordnance, Name = @"Expanded Launchers", Description = @"*Modification*. The battery armament for your front hull zone is increased by 2 black dice.", Point = 8 },
new Card { Id = 167, Category = CardCategory.Ordnance, Name = @"External Racks", Description = @"While attacking at close range, you may discard this card to add 2 black dice to your attack pool.", Point = 4 },
new Card { Id = 168, Category = CardCategory.Ordnance, Name = @"Flechette Torpedoes", Description = @"While attacking a squadron, you may spend 1 black die with a :critical: icon to toggle its activation slider to the activated side.", Point = 3 },
new Card { Id = 169, Category = CardCategory.Ordnance, Name = @"Ordnance Pods", Description = @"Medium or large ship only. At the end of your Attack Step, you may exhaust this card and choose 1 of your hull zones. Then perform an attack from that hull zone with an anti-squadron armament of 1 black die, even if you have already attacked from that zone this round.", Point = 3 },
new Card { Id = 170, Category = CardCategory.Ordnance, Name = @"Rapid Reload", Description = @"_Modification_. The battery armaments for your left and right hull zones are increased by 1 black die.", Point = 4 },
new Card { Id = 171, Category = CardCategory.Ordnance, Name = @"Wide-Area Barrage", Description = @"Black :crit: : If the defender is a ship, choose 1 other ship or squadron at close range of the defender. That ship or squadron suffers damage equal to half of the total number of black Icon Dice Hit icons in your attack pool, rounded up.", Point = 2 },
```

## SuperweaponImperial (2)

```csharp
new Card { Id = 172, Category = CardCategory.SuperweaponImperial, Name = @"Orbital Bombardment Particle Cannons", Description = @"Modification. Ignition [Long] Ignition Red :crit:: Each other ship at distance 1 of the defender suffers 2 damage, and each squadron at distance 1 of the defender suffers 1 damage.", Point = 5 },
new Card { Id = 173, Category = CardCategory.SuperweaponImperial, Name = @"Superheavy Composite Beam Turbolasers", Description = @"Modification. Ignition [Medium] Ignition Red :crit:: The defender suffers 1 damage. This occurs once for each red or blue :crit: icon in the pool.", Point = 7 },
```

## SuperweaponRebel (1)

```csharp
new Card { Id = 174, Category = CardCategory.SuperweaponRebel, Name = @"Magnite Crystal Tractor Beam Array", Description = @"After the end of your activation, you may exhaust this card to choose 1 enemy ship at distance 1-5. That ship's speed is increased or decreased to match your speed. While your speed is 0, you cannot ready this card.", Point = 10 },
```

## SupportTeam (7)

```csharp
new Card { Id = 175, Category = CardCategory.SupportTeam, Name = @"Auxiliary Shields Team", Description = @":repair: : You may treat the maximum shield values of your right and left hull zones as increased by 1 when you recover or move shields to those zones. If you do, the number of shields in those zones cannot exceed a maximum of ""4"".", Point = 3 },
new Card { Id = 176, Category = CardCategory.SupportTeam, Name = @"Engine Techs", Description = @":navigate: : After you execute a maneuver in which you did not overlap a ship, you may exhaust this card to execute a speed-1 maneuver.", Point = 8 },
new Card { Id = 177, Category = CardCategory.SupportTeam, Name = @"Engineering Team", Description = @":repair: : Gain 1 additional engineering point.", Point = 3 },
new Card { Id = 178, Category = CardCategory.SupportTeam, Name = @"Fighter Coordination Team", Description = @"After you execute a maneuver, you may select a number of unengaged friendly squadrons up to your squadron value at close-medium range. Those squadrons may move up to distance 1.", Point = 3 },
new Card { Id = 179, Category = CardCategory.SupportTeam, Name = @"Medical Team", Description = @"Before you are dealt a faceup damage card with the Crew trait, you may discard this card to discard that damage card.", Point = 1 },
new Card { Id = 180, Category = CardCategory.SupportTeam, Name = @"Nav Team", Description = @":nav: If you spent a :nav: token, once during this maneuver, when you would change your speed, you may instead increase 1 yaw value by 1.", Point = 4 },
new Card { Id = 181, Category = CardCategory.SupportTeam, Name = @"Projection Experts", Description = @":repair: : You may spend up to 2 engineering points to move that many shields from your ship to a friendly ship at distance 1-5.", Point = 6 },
```

## SupportTeamCIS (1)

```csharp
new Card { Id = 182, Category = CardCategory.SupportTeamCIS, Name = @"Battle Droid Reserves", Description = @"Droid only. :repair: : You may exhaust this card. If you do: - Flip any number of your faceup damage cards with the CREW trait facedown. - Discarding facedown damage cards costs 1 fewer engineering point.", Point = 4 },
```

## TitleRebel (30)

```csharp
new Card { Id = 183, Category = CardCategory.TitleRebel, Name = @"Admonition", Description = @"While defending, during the Spend Defense Tokens step, you may discard a defense token to cancel 1 attack die.", Point = 10 },
new Card { Id = 184, Category = CardCategory.TitleRebel, Name = @"Amity", Description = @"Mark I only. After you deploy, gain 1 :evade: defense token. When an enemy ship overlaps you, you may deal 1 additional facedown damage card to both ships.", Point = 6 },
new Card { Id = 185, Category = CardCategory.TitleRebel, Name = @"Aspiration", Description = @"When you deploy this ship, you may move shields to up to 2 of your hull zones from your other hull zones. If you do, the number of shields in a zone cannot exceed a maximum of ""6"". You cannot recover shields while any zone is greater than its maximum shield value.", Point = 3 },
new Card { Id = 186, Category = CardCategory.TitleRebel, Name = @"Bright Hope", Description = @"While defending against an attack that does not target your rear hull zone, before you suffer damage reduce the total damage by 1.", Point = 2 },
new Card { Id = 187, Category = CardCategory.TitleRebel, Name = @"Concord", Description = @"Mark I only. After you deploy, gain 1 :salvo: defense token. While defending, if your speed is 0, during your Spend Defense Tokens step, you can spend 1 defense token.", Point = 12 },
new Card { Id = 188, Category = CardCategory.TitleRebel, Name = @"Defiance", Description = @"While attacking a ship that has already activated this round, add 1 die of any color to your attack pool.", Point = 5 },
new Card { Id = 189, Category = CardCategory.TitleRebel, Name = @"Dodonna's Pride", Description = @"BLUE :crit: Cancel all attack dice to deal 1 faceup damage card to the defender.", Point = 4 },
new Card { Id = 190, Category = CardCategory.TitleRebel, Name = @"Endeavor", Description = @"At the start of the first round, gain 1 :contain: defense token.", Point = 4 },
new Card { Id = 191, Category = CardCategory.TitleRebel, Name = @"Foresight", Description = @"When you resolve the :evade: defense effect, you can affect 1 additional die. When you resolve the :redirect: defense effect, you can choose 1 additional adjacent hull zone to suffer damage.", Point = 10 },
new Card { Id = 192, Category = CardCategory.TitleRebel, Name = @"Gallant Haven", Description = @"Before a friendly squadron at distance 1 suffers damage from an attack, reduce the total damage by 1, to a minimum of 1.", Point = 8 },
new Card { Id = 193, Category = CardCategory.TitleRebel, Name = @"Garel's Honor", Description = @"When you overlap an enemy ship, the enemy ship suffers a faceup damage card instead of a facedown damage card.", Point = 4 },
new Card { Id = 194, Category = CardCategory.TitleRebel, Name = @"Home One", Description = @"While another friendly ship at distance 1-5 is attacking, it may change 1 die to a face with an :accuracy: icon.", Point = 5 },
new Card { Id = 195, Category = CardCategory.TitleRebel, Name = @"Independence", Description = @":squadron: Each squadron you activate may increase its speed to 4 until the end of its activation. Squadrons that change speed in this way cannot attack this activation.", Point = 8 },
new Card { Id = 196, Category = CardCategory.TitleRebel, Name = @"Jaina's Light", Description = @"You can ignore the effects of overlapping obstacles. Your attacks cannot be obstructed.", Point = 5 },
new Card { Id = 197, Category = CardCategory.TitleRebel, Name = @"Liberator", Description = @"You gain 1 additional :fleet-command: icon in you upgrade bar. You cannot equip this card if you have a :fleet-command: icon in your upgrade bar. You cannot spend a command token to resolve a :fleet-command: card's effect.", Point = 2 },
new Card { Id = 198, Category = CardCategory.TitleRebel, Name = @"Liberty", Description = @":squadron:: If you spent a :squadron: token, you may activate 1 additional squadron.", Point = 3 },
new Card { Id = 199, Category = CardCategory.TitleRebel, Name = @"Mon Calamari Exodus Fleet", Description = @"MC only. :repair: : You may choose and exhaust another copy of this card on a friendly ship at distance 1-4. If you do, gain 2 additional engineering points.", Point = 5 },
new Card { Id = 200, Category = CardCategory.TitleRebel, Name = @"Mon Karren", Description = @":confire:: While attacking a ship, the defender cannot spend more than 1 defense token during this attack.", Point = 6 },
new Card { Id = 201, Category = CardCategory.TitleRebel, Name = @"Paragon", Description = @"While attacking a ship you have already attacked this round, add 1 black die to your attack pool.", Point = 5 },
new Card { Id = 202, Category = CardCategory.TitleRebel, Name = @"Phoenix Home", Description = @"You gain 1 additional :officer: icon in your upgrade bar. You can be assigned up to 4 command tokens instead of a number of command tokens equal to your command value.", Point = 3 },
new Card { Id = 203, Category = CardCategory.TitleRebel, Name = @"Profundity", Description = @"Before deploying fleets, you may set aside 1 small ship with a command value of 1. At the start of any round, you may deploy the set-aside ship at distance 1. You may un-equip up to 1 :commander: and 1 :officer: upgrade cards and equip them to it (if able).", Point = 7 },
new Card { Id = 204, Category = CardCategory.TitleRebel, Name = @"Quantum Storm", Description = @":nav:: After you execute a maneuver, you may exhaust this card to execute a 1-speed maneuver with a yaw of ""-"".", Point = 1 },
new Card { Id = 205, Category = CardCategory.TitleRebel, Name = @"Redemption", Description = @"When a friendly ship at distance 1-5 resolves a :repair: command, it gains 1 additional engineering point.", Point = 5 },
new Card { Id = 206, Category = CardCategory.TitleRebel, Name = @"Salvation", Description = @"While attacking a ship from your front hull zone, your :crit: icons count as 2 damage instead of 1.", Point = 7 },
new Card { Id = 207, Category = CardCategory.TitleRebel, Name = @"Tantive IV", Description = @"Before you gain a command token, 1 friendly ship at distance 1-5 may gain that token instead.", Point = 3 },
new Card { Id = 208, Category = CardCategory.TitleRebel, Name = @"Task Force Antilles", Description = @"When you suffer damage from an attack, you may choose and exhaust a copy of this card on another friendly ship at distance 1-3. If you do, that ship suffers 1 of your damage instead. While this card is exhausted, you cannot spend engineering points.", Point = 3 },
new Card { Id = 209, Category = CardCategory.TitleRebel, Name = @"Task Force Organa", Description = @"While attacking, you may choose and exhaust a copy of this card on another friendly ship at distance 1-3 to reroll up to 2 attack dice. While this card is exhausted, you cannot attack ships.", Point = 1 },
new Card { Id = 210, Category = CardCategory.TitleRebel, Name = @"Unity", Description = @"After you deploy, gain 1 :redirect: defense token. While attacking a squadron, if the defender is engaged with a friendly squadron without the printed Heavy keyword, you may reroll 1 die.", Point = 10 },
new Card { Id = 211, Category = CardCategory.TitleRebel, Name = @"Vanguard", Description = @"You gain 1 additional :weapons-team: icon in your upgrade bar. At the start of the first round, you may replace 1 of your defense tokens with a :redirect: defense token.", Point = 4 },
new Card { Id = 212, Category = CardCategory.TitleRebel, Name = @"Yavaris", Description = @":squadron:: Each squadron you activate may choose to only attack during your activation. If it does, while attacking, it may add 1 die to its attack pool of a color already in its attack pool.", Point = 5 },
```

## TitleImperial (30)

```csharp
new Card { Id = 213, Category = CardCategory.TitleImperial, Name = @"Annihilator", Description = @"While attacking a squadron, you may reroll 1 attack die.", Point = 8 },
new Card { Id = 214, Category = CardCategory.TitleImperial, Name = @"Avenger", Description = @"While attacking, you may exhaust this card. If you do, the defender cannot spend more than 1 exhausted defense token during this attack.", Point = 5 },
new Card { Id = 215, Category = CardCategory.TitleImperial, Name = @"Cataclysm", Description = @"After the start of the Ship Phase, you may spend 1 :confire: to place your targeting token within your special firing arc within the range specified by one of your Ignition keywords.", Point = 5 },
new Card { Id = 216, Category = CardCategory.TitleImperial, Name = @"Centicore", Description = @"When another friendly ship resolves a :squadron: command, up to 2 of the squadrons it activates can be at close-medium range of you.", Point = 3 },
new Card { Id = 217, Category = CardCategory.TitleImperial, Name = @"Chimaera", Description = @"You gain 1 :fleet-command: icon in your upgrade bar. You cannot equip this card if you have a :fleet-command: icon in your upgrade bar. At the start of the Command Phase, you may discard 1 :fleet-command: upgrade card you have equipped and replace it with another :fleet-command: upgrade card.", Point = 4 },
new Card { Id = 218, Category = CardCategory.TitleImperial, Name = @"Corrupter", Description = @":squadron:: The speed of each squadron with BOMBER you activate is increased by 1 until the end of its activation", Point = 3 },
new Card { Id = 219, Category = CardCategory.TitleImperial, Name = @"Corvus", Description = @"After deploying fleets you may redeploy this ship within your deployment zone.", Point = 2 },
new Card { Id = 220, Category = CardCategory.TitleImperial, Name = @"Demolisher", Description = @"During your Attack step, you can perform only 1 attack. You can perform 1 of your attacks after you execute your first maneuver during your activation.", Point = 10 },
new Card { Id = 221, Category = CardCategory.TitleImperial, Name = @"Devastator", Description = @"Once per round, while attacking from your front hull zone, you may add 1 blue die to your attack pool for each of your discarded defense tokens.", Point = 10 },
new Card { Id = 222, Category = CardCategory.TitleImperial, Name = @"Dominator", Description = @"When attacking at close-medium range, you may spend up to 2 shields from any of your hull zones to add that number of blue dice to your attack pool.", Point = 7 },
new Card { Id = 223, Category = CardCategory.TitleImperial, Name = @"Eclipse", Description = @"When an enemy ship overlaps you, the enemy ship suffers a faceup damage card instead of a facedown damage card.", Point = 3 },
new Card { Id = 224, Category = CardCategory.TitleImperial, Name = @"Executor", Description = @"You can be assigned any number of command tokens of any types, instead of a number of command tokens equal to your command value.", Point = 2 },
new Card { Id = 225, Category = CardCategory.TitleImperial, Name = @"Hand of Justice", Description = @"Before you reveal a command, you may exhaust this card to choose another friendly ship at distance 1-5 and ready 1 of its defense tokens.", Point = 2 },
new Card { Id = 226, Category = CardCategory.TitleImperial, Name = @"Harrow", Description = @"You gain 1 additional :support-team: icon in your upgrade bar. When you execute a speed-1 maneuver, during your Determine Course step, you may change your first yaw value to ""II"" until the end of your activation.", Point = 3 },
new Card { Id = 227, Category = CardCategory.TitleImperial, Name = @"Impetuous", Description = @"At the end of your Attack Step, choose 1 of your hull zones. You may perform an attack against 1 enemy squadron from that hull zone, even if you have already attacked from that zone this round.", Point = 4 },
new Card { Id = 228, Category = CardCategory.TitleImperial, Name = @"Insidious", Description = @"The black dice in your battery armament can be used at medium range. This effect applies only while attacking the rear hull zone of a ship.", Point = 3 },
new Card { Id = 229, Category = CardCategory.TitleImperial, Name = @"Instigator", Description = @"Enemy squadrons at distance 1 are treated as if they are engaged by 2 additional squadrons, even if they are not currently engaged.", Point = 4 },
new Card { Id = 230, Category = CardCategory.TitleImperial, Name = @"Interdictor", Description = @"When a ship activates, you may exhaust this card to ready 1 other upgrade card equipped to this ship.", Point = 3 },
new Card { Id = 231, Category = CardCategory.TitleImperial, Name = @"Pursuant", Description = @"When you reveal a command other than a :squadron: command, you may discard this card to resolve a :squadron: Command. You treat this command as if you spent a :squadron: dial.", Point = 2 },
new Card { Id = 232, Category = CardCategory.TitleImperial, Name = @"Rakehell", Description = @":nav:: While executing a 0-speed maneuver, you can resolve clicks of yaw at the speed-0 joint, and are treated as having a yaw value of ""I"" for that maneuver.", Point = 4 },
new Card { Id = 233, Category = CardCategory.TitleImperial, Name = @"Ravager", Description = @":confire:: Your :confire: tokens can either reroll 1 attack die or add 1 die to your attack pool. If you add a die, that die must be of a color already in your attack pool.", Point = 4 },
new Card { Id = 234, Category = CardCategory.TitleImperial, Name = @"Relentless", Description = @"The total number of command dials that must be assigned to your ship during the Command Phase is reduced by 1.", Point = 3 },
new Card { Id = 235, Category = CardCategory.TitleImperial, Name = @"Seventh Fleet Star Destroyer", Description = @"Star Destroyer only. While defending against an attack that targets your front hull zone, before you suffer damage, you may choose and exhaust a copy of this card on another friendly ship at distance 1-4 to reduce the total damage by 1.", Point = 5 },
new Card { Id = 236, Category = CardCategory.TitleImperial, Name = @"Sovereign", Description = @"At the start of Ship Phase, you may exhaust this card to discard 1 command token from up to 3 friendly ships at distance 1-5. If you do, each of those ships may gain 1 command token of any type.", Point = 4 },
new Card { Id = 237, Category = CardCategory.TitleImperial, Name = @"Squall", Description = @"When you activate, you may choose up to 3 unengaged, friendly squadrons at close-medium range. Those squadrons may move up to distance 2. If they do, they cannot end their movement engaged.", Point = 7 },
new Card { Id = 238, Category = CardCategory.TitleImperial, Name = @"Stronghold", Description = @"While a friendly squadron with Swarm at distance 1-2 is defending, the attack is treated as obstructed.", Point = 3 },
new Card { Id = 239, Category = CardCategory.TitleImperial, Name = @"Sunder", Description = @"Blue or Black :crit:: You may discard this card to choose and discard 1 :offensive-retro:, :defensive-retro:, :ordnance:, :ion-cannon:, or :turbolaser: upgrade card equipped to the defender.", Point = 10 },
new Card { Id = 240, Category = CardCategory.TitleImperial, Name = @"Suppressor", Description = @"After an enemy ship ends its activation, if it is at distance 1-3, you may choose and exhaust 1 of its defense tokens.", Point = 4 },
new Card { Id = 241, Category = CardCategory.TitleImperial, Name = @"Vector", Description = @":squadron:: The speed of each squadron without heavy you activate is increased by 1, to a maximum of 5, until the end of its activation.", Point = 2 },
new Card { Id = 242, Category = CardCategory.TitleImperial, Name = @"Warlord", Description = @"While attack, you may change 1 die face with an :accuracy: icon to a face with a :hit: icon.", Point = 8 },
```

## TitleGAR (9)

```csharp
new Card { Id = 243, Category = CardCategory.TitleGAR, Name = @"FB-88", Description = @"Before you reveal a command, you may discard your top command dial.", Point = 4 },
new Card { Id = 244, Category = CardCategory.TitleGAR, Name = @"Implacable", Description = @"Before a friendly ship or squadron at distance 1-2 suffers damage from an attack, you may exhaust this card and spend up to 2 shields from your front hull zone to reduce the total damage by that amount.", Point = 4 },
new Card { Id = 245, Category = CardCategory.TitleGAR, Name = @"Nevoota Bee", Description = @":squadron:: Each non-unique squadron that you activate gains swarm until the end of its activation. Each squadron with swarm that you activate may reroll 1 die while attacking a ship.", Point = 5 },
new Card { Id = 246, Category = CardCategory.TitleGAR, Name = @"Radiant VII", Description = @"You gain 1 :fleet-support: icon in your upgrade bar. You cannot equip :turbolaser: or :ordnance: upgrades.", Point = 1 },
new Card { Id = 247, Category = CardCategory.TitleGAR, Name = @"Resolute", Description = @"You must choose at least 2 types of command tokens for this card. After you resolve a command by spending a dial, you may discard 1 matching command token from this card to gain that token.", Point = 4 },
new Card { Id = 248, Category = CardCategory.TitleGAR, Name = @"Swift Return", Description = @"During your Determine Course step, if you are at distance 1-2 of an obstacle, you may change your speed by 1 or increase 1 yaw value by 1.", Point = 3 },
new Card { Id = 249, Category = CardCategory.TitleGAR, Name = @"TB-73", Description = @"After you deploy, gain 1 additional :evade: defense token.", Point = 5 },
new Card { Id = 250, Category = CardCategory.TitleGAR, Name = @"Tranquility", Description = @"While defending, after the Spend Defense Tokens step, if you spent fewer than 2 defense tokens, you may move up to 2 shields from 1 of your hull zones to the defending hull zone. If you do, the number of shields in that zone cannot exceed a maximum of '6'. You cannot recover shields while any zone is greater than its maximum shield value.", Point = 7 },
new Card { Id = 251, Category = CardCategory.TitleGAR, Name = @"Triumphant", Description = @"While another friendly non-flotilla ship resolves a :squadron: command, up to 3 squadrons without adept that it activates can be at close range of you (even if the squadrons are beyond close-medium range of that ship). This effect is not active during the first round.", Point = 5 },
```

## TitleCIS (10)

```csharp
new Card { Id = 252, Category = CardCategory.TitleCIS, Name = @"Beast of Burden", Description = @"When you activate you may exhaust this card and spend 1 or more of your Defense Tokens to choose the same number of Defense Tokens of a friendly ship at distance 1-3 and ready those Defense Tokens.", Point = 6 },
new Card { Id = 253, Category = CardCategory.TitleCIS, Name = @"Foreman's Labor", Description = @"Before you suffer damage from an attack, if the defending hull zone has at least 1 shield remaining, you may exhaust this card to reduce the total damage by 1.", Point = 5 },
new Card { Id = 254, Category = CardCategory.TitleCIS, Name = @"Gilded Aegis", Description = @"At the end of Command Phase or Ship Phase, you may discard a :redirect: defense token to move shields to 1 of your hull zones. If you do, the number if shields in that zone cannot exceed a maximum of ""6"". You cannot recover shields in that zone while it is greater than its maximum shield value.", Point = 5 },
new Card { Id = 255, Category = CardCategory.TitleCIS, Name = @"Invincible", Description = @"You gain 1 additional :defensive retrofit: icon in your upgrade bar.", Point = 5 },
new Card { Id = 256, Category = CardCategory.TitleCIS, Name = @"Invisible Hand", Description = @"While deploying fleets, if you are in the play area, when you would deploy a squadron with SWARM, you may set that squadron aside next to your ship card instead. You may set aside up to 5 squadrons this way. :squadron: : Choose any number of squadrons set aside with this card. Then place them within distance 1-3 of you. During your activation, those squadrons cannot move, and if they have AI, may increase their AI value by 1.", Point = 8 },
new Card { Id = 257, Category = CardCategory.TitleCIS, Name = @"Lucid Voice", Description = @"Treat your rear hull zone's printed battery armament as 3 red dice. The battery armament of your left and right hull zones are each increased by 1 black die and decreased by 1 blue die.", Point = 6 },
new Card { Id = 258, Category = CardCategory.TitleCIS, Name = @"Nova Defiant", Description = @"When you are deployed, you must choose 1 of each type of command token for this card. Your command value is increased to 4. You can be assigned more than 1 of each type of command token. When you reveal a command, you may discard all of the tokens from this card to gain them.", Point = 4 },
new Card { Id = 259, Category = CardCategory.TitleCIS, Name = @"Patriot Fist", Description = @"While attacking a ship at medium-long range, if this is your first attack during your activation, you may add 2 blue dice to your attack pool. If you do, you cannot attack again during this activation.", Point = 6 },
new Card { Id = 260, Category = CardCategory.TitleCIS, Name = @"Sa Nalaor", Description = @"While defending, if you are at speed 2 or higher, you may spend a defense token to resolve the :evade: defense effect instead of that token's effect. You cannot resolve the :evade: defense effect more than once per attack.", Point = 5 },
new Card { Id = 261, Category = CardCategory.TitleCIS, Name = @"Tide of Progress XII", Description = @"Before you are dealt a faceup damage card with the SHIP trait, you may exhaust this card to discard that damage card (without resolving its effect).", Point = 2 },
```

## Turbolasers (14)

```csharp
new Card { Id = 262, Category = CardCategory.Turbolasers, Name = @"DBY-827 Heavy Turbolaser", Description = @"While performing a :salvo: attack, you may change 1 die to a face with a :critical: icon.", Point = 3 },
new Card { Id = 263, Category = CardCategory.Turbolasers, Name = @"Dual Turbolaser Turrets", Description = @"_Modification_. While attacking you may exhaust this card to add 1 red die to your attack pool. If you do, remove 1 die from the attack pool.", Point = 4 },
new Card { Id = 264, Category = CardCategory.Turbolasers, Name = @"Enhanced Armament", Description = @"_Modification_. The battery armaments for your left and right hull zones are increased by 1 red die.", Point = 10 },
new Card { Id = 265, Category = CardCategory.Turbolasers, Name = @"H9 Turbolasers", Description = @"_Modification_. While attacking, you may change 1 die face with a :hit: or :crit: icon to a face with an :accuracy: icon.", Point = 8 },
new Card { Id = 266, Category = CardCategory.Turbolasers, Name = @"Heavy Fire Zone", Description = @"While attacking a squadron, before you gather dice, if the defender is not engaged with a friendly squadron you may replace all of the blue dice in your anti-squadron armament with red dice.", Point = 2 },
new Card { Id = 267, Category = CardCategory.Turbolasers, Name = @"Heavy Turbolaser Turrets", Description = @"While attacking, the :brace: defense effect cannot reduce the damage total by more than 1 unless it is the only defense token spent by the defender during the attack.", Point = 4 },
new Card { Id = 268, Category = CardCategory.Turbolasers, Name = @"Linked Turbolaser Towers", Description = @"While attacking a squadron, you may reroll 1 red die in your attack pool. While attacking a ship, if you have the bombard tag, you may reroll 1 red die in your attack pool. During your activation, while attacking the first squadron during an attack, you may exhaust this card to add 2 dice of any color to your attack pool. If you do, you cannot declare additional squadron targets for this attack.", Point = 7 },
new Card { Id = 269, Category = CardCategory.Turbolasers, Name = @"Quad Battery Turrets", Description = @"_Modification_. While attacking a ship with a higher speed than yours, you may add 1 blue die to your attack pool.", Point = 5 },
new Card { Id = 270, Category = CardCategory.Turbolasers, Name = @"Quad Turbolaser Cannons", Description = @"_Modification_. While attacking, if at least 1 red die face has an :accuracy: icon, add 1 red die set to the :accuracy: icon to your attack pool.", Point = 10 },
new Card { Id = 271, Category = CardCategory.Turbolasers, Name = @"Slaved Turrets", Description = @"_Modification_. You cannot attack more than once per round. While attacking a ship, add 1 red die to your attack pool.", Point = 6 },
new Card { Id = 272, Category = CardCategory.Turbolasers, Name = @"Spinal Armament", Description = @"_Modification_. The battery armaments for your front and rear hull zones are increased by 1 red die.", Point = 9 },
new Card { Id = 273, Category = CardCategory.Turbolasers, Name = @"Turbolaser Reroute Circuits", Description = @"While attacking, you may exhaust this card and spend 1 :evade: defense token to change 1 red die to a face with a :critical: icon or 2 :hit: icons.", Point = 7 },
new Card { Id = 274, Category = CardCategory.Turbolasers, Name = @"XI7 Turbolasers", Description = @"While attacking, if the defender spends a :redirect: token, it cannot suffer more than 1 damage on each hull zone other than the defending hull zone when it resolves the :redirect: defense effect.", Point = 6 },
new Card { Id = 275, Category = CardCategory.Turbolasers, Name = @"XX-9 Turbolasers", Description = @":critical:: The first 2 damage cards dealt to the defender by this attack are dealt faceup.", Point = 2 },
```

## TurbolasersPRE (1)

```csharp
new Card { Id = 276, Category = CardCategory.TurbolasersPRE, Name = @"Swivel-Mount Batteries", Description = @"_Modification_. When you reveal a command, you may exhaust this card to choose 1 of your hull zones and mark it with a focus token. While attacking a ship from that hull zone, add 1 die of any color from an adjacent hull zone's armament to your attack pool. While attacking from adjacent hull zones, remove 1 die from your attack pool. When you ready this card, remove that focus token.", Point = 8 },
```

## WeapTeam (12)

```csharp
new Card { Id = 277, Category = CardCategory.WeapTeam, Name = @"Caitken and Shollan", Description = @"While attacking, you may exhaust this card to reroll any number of dice of 1 color.", Point = 6 },
new Card { Id = 278, Category = CardCategory.WeapTeam, Name = @"Clone Gunners", Description = @":confire:: You may discard a :confire: token assigned to another friendly ship at distance 1-5 of the defender. If you do, add 1 blue die set to the :accuracy: to your attack pool.", Point = 4 },
new Card { Id = 279, Category = CardCategory.WeapTeam, Name = @"Fire-Control Team", Description = @"During the Resolve Damage Step, you may exhaust this card to resolve 1 additional critical effect. You cannot resolve the same critical effect twice.", Point = 2 },
new Card { Id = 280, Category = CardCategory.WeapTeam, Name = @"Flight Controllers", Description = @":squadron:: When a squadron you activate attacks, before gathering dice, increase its anti-squadron armament by 1 blue die until the end of the attack.", Point = 6 },
new Card { Id = 281, Category = CardCategory.WeapTeam, Name = @"Gunnery Chief Varnillian", Description = @"After you deploy, place 1 red die set to a blank face on this card. If you are the second player, set it to any face instead. While attacking a ship, you may spend 1 die from the attack pool to exchange it with the die on this card. Both dice remain set to their current faces.", Point = 6 },
new Card { Id = 282, Category = CardCategory.WeapTeam, Name = @"Gunnery Team", Description = @":confire:: The next attack you perform this activation can be performed from this hull zone. Each of your hull zones cannot target the same ship or squadron more than once during your activation.", Point = 7 },
new Card { Id = 283, Category = CardCategory.WeapTeam, Name = @"Local Fire Control", Description = @"After you deploy, you must replace 1 of your defense tokens with a :salvo: defense token.", Point = 4 },
new Card { Id = 284, Category = CardCategory.WeapTeam, Name = @"Ordnance Experts", Description = @"While attacking, you may reroll up to 2 black dice.", Point = 4 },
new Card { Id = 285, Category = CardCategory.WeapTeam, Name = @"Ruthless Strategists", Description = @"After attacking a squadron, you may deal 1 damage to a friendly squadron engaged with the defender. If you do, the defender suffers 1 damage.", Point = 4 },
new Card { Id = 286, Category = CardCategory.WeapTeam, Name = @"Sensor Team", Description = @"While attacking, you may exhaust this card and spend 1 die to change 1 of your dice to a face with an :accuracy: icon.", Point = 5 },
new Card { Id = 287, Category = CardCategory.WeapTeam, Name = @"Veteran Gunners", Description = @"While attacking, you may exhaust this card to reroll all dice in your attack pool.", Point = 5 },
new Card { Id = 288, Category = CardCategory.WeapTeam, Name = @"Weapons Battery Techs", Description = @"While attacking a ship, you may change 1 die face with a :accuracy: icon to a face with :crit: icon.", Point = 4 },
```

## WeaponsTeamAndOffensiveRetrofit (6)

```csharp
new Card { Id = 289, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit, Name = @"Boarding Engineers", Description = @"When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. Look at its facedown damage cards and flip a number of them faceup up to your engineering value (one at a time).", Point = 2 },
new Card { Id = 290, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit, Name = @"Boarding Troopers", Description = @"When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. Choose and spend a number of its defense tokens up to your squadron value.", Point = 3 },
new Card { Id = 291, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit, Name = @"Cham Syndulla", Description = @"When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. If you do you may choose a new command for each command dial assigned to that ship. Then you may choose a new command dial for each of those command dials to be set to.", Point = 5 },
new Card { Id = 292, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit, Name = @"Darth Vader", Description = @"When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. Choose and discard 1 non-:commander: upgrade card equipped to that ship.", Point = 3 },
new Card { Id = 293, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit, Name = @"Jyn Erso", Description = @"When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. If that ship has no raid tokens, it gains 2 raid tokens of your choice. If that ship has an objective token, you may also gain 1 victory token.", Point = 4 },
new Card { Id = 294, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit, Name = @"Shriv Surgaav", Description = @"When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. Choose and discard 1 :weapons-team:, :support-team:, :offensive-retro:, :defensive-retro:, :ordnance:, :ion-cannon:, or :turbolaser: upgrade card equipped to that ship.", Point = 4 },
```

