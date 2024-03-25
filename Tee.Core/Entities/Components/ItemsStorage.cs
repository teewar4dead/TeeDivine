using Tee.Core.Entities.Abilities.Items;
using Tee.Core.Entities.Abilities.Items.Neutrals;
using Tee.Core.Entities.Abilities.Items.Others;
using Tee.Core.Entities.Abilities.Items.Recipes;
using Tee.Core.Entities.Units;
using Tee.Core.Utilities;

namespace Tee.Core.Entities.Components
{
    public class ItemsStorage
    {
        public ItemsStorage(ActionManager actionManager)
        {
            actionManager.Subscribe<ItemAbyssalBlade>(item => AbyssalBlade = item);
            actionManager.Subscribe<ItemAegis>(item => Aegis = item);
            actionManager.Subscribe<ItemAeonDisk>(item => AeonDisk = item);
            actionManager.Subscribe<ItemAetherLens>(item => AetherLens = item);
            actionManager.Subscribe<ItemAghanimsShard>(item => AghanimsShard = item);
            actionManager.Subscribe<ItemAghanimsShardRoshan>(item => AghanimsShardRoshan = item);
            actionManager.Subscribe<ItemAncientJanggo>(item => AncientJanggo = item);
            actionManager.Subscribe<ItemArcaneBlink>(item => ArcaneBlink = item);
            actionManager.Subscribe<ItemArcaneBoots>(item => ArcaneBoots = item);
            actionManager.Subscribe<ItemArmlet>(item => Armlet = item);
            actionManager.Subscribe<ItemAssault>(item => Assault = item);
            actionManager.Subscribe<ItemBasher>(item => Basher = item);
            actionManager.Subscribe<ItemBeltOfStrength>(item => BeltOfStrength = item);
            actionManager.Subscribe<ItemBfury>(item => Bfury = item);
            actionManager.Subscribe<ItemBlackKingBar>(item => BlackKingBar = item);
            actionManager.Subscribe<ItemBladeMail>(item => BladeMail = item);
            actionManager.Subscribe<ItemBladeOfAlacrity>(item => BladeOfAlacrity = item);
            actionManager.Subscribe<ItemBladesOfAttack>(item => BladesOfAttack = item);
            actionManager.Subscribe<ItemBlightStone>(item => BlightStone = item);
            actionManager.Subscribe<ItemBlink>(item => Blink = item);
            actionManager.Subscribe<ItemBlitzKnuckles>(item => BlitzKnuckles = item);
            actionManager.Subscribe<ItemBloodGrenade>(item => BloodGrenade = item);
            actionManager.Subscribe<ItemBloodstone>(item => Bloodstone = item);
            actionManager.Subscribe<ItemBloodthorn>(item => Bloodthorn = item);
            actionManager.Subscribe<ItemBoots>(item => Boots = item);
            actionManager.Subscribe<ItemBootsOfBearing>(item => BootsOfBearing = item);
            actionManager.Subscribe<ItemBootsOfElves>(item => BootsOfElves = item);
            actionManager.Subscribe<ItemBottle>(item => Bottle = item);
            actionManager.Subscribe<ItemBracer>(item => Bracer = item);
            actionManager.Subscribe<ItemBranches>(item => Branches = item);
            actionManager.Subscribe<ItemBroadsword>(item => Broadsword = item);
            actionManager.Subscribe<ItemBuckler>(item => Buckler = item);
            actionManager.Subscribe<ItemButterfly>(item => Butterfly = item);
            actionManager.Subscribe<ItemChainmail>(item => Chainmail = item);
            actionManager.Subscribe<ItemCheese>(item => Cheese = item);
            actionManager.Subscribe<ItemCirclet>(item => Circlet = item);
            actionManager.Subscribe<ItemClarity>(item => Clarity = item);
            actionManager.Subscribe<ItemClaymore>(item => Claymore = item);
            actionManager.Subscribe<ItemCloak>(item => Cloak = item);
            actionManager.Subscribe<ItemCornucopia>(item => Cornucopia = item);
            actionManager.Subscribe<ItemCrimsonGuard>(item => CrimsonGuard = item);
            actionManager.Subscribe<ItemCrown>(item => Crown = item);
            actionManager.Subscribe<ItemCyclone>(item => Cyclone = item);
            actionManager.Subscribe<ItemDagon>(item => Dagon = item);
            actionManager.Subscribe<ItemDagon2>(item => Dagon2 = item);
            actionManager.Subscribe<ItemDagon3>(item => Dagon3 = item);
            actionManager.Subscribe<ItemDagon4>(item => Dagon4 = item);
            actionManager.Subscribe<ItemDagon5>(item => Dagon5 = item);
            actionManager.Subscribe<ItemDemonEdge>(item => DemonEdge = item);
            actionManager.Subscribe<ItemDesolator>(item => Desolator = item);
            actionManager.Subscribe<ItemDiadem>(item => Diadem = item);
            actionManager.Subscribe<ItemDiffusalBlade>(item => DiffusalBlade = item);
            actionManager.Subscribe<ItemDisperser>(item => Disperser = item);
            actionManager.Subscribe<ItemDragonLance>(item => DragonLance = item);
            actionManager.Subscribe<ItemDust>(item => Dust = item);
            actionManager.Subscribe<ItemEagle>(item => Eagle = item);
            actionManager.Subscribe<ItemEchoSabre>(item => EchoSabre = item);
            actionManager.Subscribe<ItemEnchantedMango>(item => EnchantedMango = item);
            actionManager.Subscribe<ItemEnergyBooster>(item => EnergyBooster = item);
            actionManager.Subscribe<ItemEternalShroud>(item => EternalShroud = item);
            actionManager.Subscribe<ItemEtherealBlade>(item => EtherealBlade = item);
            actionManager.Subscribe<ItemFaerieFire>(item => FaerieFire = item);
            actionManager.Subscribe<ItemFalconBlade>(item => FalconBlade = item);
            actionManager.Subscribe<ItemFlask>(item => Flask = item);
            actionManager.Subscribe<ItemFluffyHat>(item => FluffyHat = item);
            actionManager.Subscribe<ItemForceStaff>(item => ForceStaff = item);
            actionManager.Subscribe<ItemGauntlets>(item => Gauntlets = item);
            actionManager.Subscribe<ItemGem>(item => Gem = item);
            actionManager.Subscribe<ItemGhost>(item => Ghost = item);
            actionManager.Subscribe<ItemGlimmerCape>(item => GlimmerCape = item);
            actionManager.Subscribe<ItemGloves>(item => Gloves = item);
            actionManager.Subscribe<ItemGlovesOfTravel>(item => GlovesOfTravel = item);
            actionManager.Subscribe<ItemGreaterCrit>(item => GreaterCrit = item);
            actionManager.Subscribe<ItemGuardianGreaves>(item => GuardianGreaves = item);
            actionManager.Subscribe<ItemGungir>(item => Gungir = item);
            actionManager.Subscribe<ItemHandOfMidas>(item => HandOfMidas = item);
            actionManager.Subscribe<ItemHeaddress>(item => Headdress = item);
            actionManager.Subscribe<ItemHeart>(item => Heart = item);
            actionManager.Subscribe<ItemHeavensHalberd>(item => HeavensHalberd = item);
            actionManager.Subscribe<ItemHelmOfIronWill>(item => HelmOfIronWill = item);
            actionManager.Subscribe<ItemHelmOfTheDominator>(item => HelmOfTheDominator = item);
            actionManager.Subscribe<ItemHelmOfTheOverlord>(item => HelmOfTheOverlord = item);
            actionManager.Subscribe<ItemHolyLocket>(item => HolyLocket = item);
            actionManager.Subscribe<ItemHoodOfDefiance>(item => HoodOfDefiance = item);
            actionManager.Subscribe<ItemHurricanePike>(item => HurricanePike = item);
            actionManager.Subscribe<ItemHyperstone>(item => Hyperstone = item);
            actionManager.Subscribe<ItemInfusedRaindrop>(item => InfusedRaindrop = item);
            actionManager.Subscribe<ItemInvisSword>(item => InvisSword = item);
            actionManager.Subscribe<ItemJavelin>(item => Javelin = item);
            actionManager.Subscribe<ItemKaya>(item => Kaya = item);
            actionManager.Subscribe<ItemKayaAndSange>(item => KayaAndSange = item);
            actionManager.Subscribe<ItemLesserCrit>(item => LesserCrit = item);
            actionManager.Subscribe<ItemLifesteal>(item => Lifesteal = item);
            actionManager.Subscribe<ItemLotusOrb>(item => LotusOrb = item);
            actionManager.Subscribe<ItemMaelstrom>(item => Maelstrom = item);
            actionManager.Subscribe<ItemMageSlayer>(item => MageSlayer = item);
            actionManager.Subscribe<ItemMagicStick>(item => MagicStick = item);
            actionManager.Subscribe<ItemMagicWand>(item => MagicWand = item);
            actionManager.Subscribe<ItemManta>(item => Manta = item);
            actionManager.Subscribe<ItemMantle>(item => Mantle = item);
            actionManager.Subscribe<ItemMaskOfMadness>(item => MaskOfMadness = item);
            actionManager.Subscribe<ItemMedallionOfCourage>(item => MedallionOfCourage = item);
            actionManager.Subscribe<ItemMekansm>(item => Mekansm = item);
            actionManager.Subscribe<ItemMeteorHammer>(item => MeteorHammer = item);
            actionManager.Subscribe<ItemMithrilHammer>(item => MithrilHammer = item);
            actionManager.Subscribe<ItemMjollnir>(item => Mjollnir = item);
            actionManager.Subscribe<ItemMonkeyKingBar>(item => MonkeyKingBar = item);
            actionManager.Subscribe<ItemMoonShard>(item => MoonShard = item);
            actionManager.Subscribe<ItemMysticStaff>(item => MysticStaff = item);
            actionManager.Subscribe<ItemNullifier>(item => Nullifier = item);
            actionManager.Subscribe<ItemNullTalisman>(item => NullTalisman = item);
            actionManager.Subscribe<ItemOblivionStaff>(item => OblivionStaff = item);
            actionManager.Subscribe<ItemOctarineCore>(item => OctarineCore = item);
            actionManager.Subscribe<ItemOgreAxe>(item => OgreAxe = item);
            actionManager.Subscribe<ItemOrbOfCorrosion>(item => OrbOfCorrosion = item);
            actionManager.Subscribe<ItemOrbOfVenom>(item => OrbOfVenom = item);
            actionManager.Subscribe<ItemOrchid>(item => Orchid = item);
            actionManager.Subscribe<ItemOverwhelmingBlink>(item => OverwhelmingBlink = item);
            actionManager.Subscribe<ItemPavise>(item => Pavise = item);
            actionManager.Subscribe<ItemPers>(item => Pers = item);
            actionManager.Subscribe<ItemPhaseBoots>(item => PhaseBoots = item);
            actionManager.Subscribe<ItemPhylactery>(item => Phylactery = item);
            actionManager.Subscribe<ItemPipe>(item => Pipe = item);
            actionManager.Subscribe<ItemPlatemail>(item => Platemail = item);
            actionManager.Subscribe<ItemPointBooster>(item => PointBooster = item);
            actionManager.Subscribe<ItemPowerTreads>(item => PowerTreads = item);
            actionManager.Subscribe<ItemQuarterstaff>(item => Quarterstaff = item);
            actionManager.Subscribe<ItemQuellingBlade>(item => QuellingBlade = item);
            actionManager.Subscribe<ItemRadiance>(item => Radiance = item);
            actionManager.Subscribe<ItemRapier>(item => Rapier = item);
            actionManager.Subscribe<ItemReaver>(item => Reaver = item);
            actionManager.Subscribe<ItemRecipeMagicWand>(item => RecipeMagicWand = item);
            actionManager.Subscribe<ItemRefresher>(item => Refresher = item);
            actionManager.Subscribe<ItemRefresherShard>(item => RefresherShard = item);
            actionManager.Subscribe<ItemRelic>(item => Relic = item);
            actionManager.Subscribe<ItemRevenantsBrooch>(item => RevenantsBrooch = item);
            actionManager.Subscribe<ItemRingOfBasilius>(item => RingOfBasilius = item);
            actionManager.Subscribe<ItemRingOfHealth>(item => RingOfHealth = item);
            actionManager.Subscribe<ItemRingOfProtection>(item => RingOfProtection = item);
            actionManager.Subscribe<ItemRingOfRegen>(item => RingOfRegen = item);
            actionManager.Subscribe<ItemRingOfTarrasque>(item => RingOfTarrasque = item);
            actionManager.Subscribe<ItemRobe>(item => Robe = item);
            actionManager.Subscribe<ItemRodOfAtos>(item => RodOfAtos = item);
            actionManager.Subscribe<ItemSange>(item => Sange = item);
            actionManager.Subscribe<ItemSangeAndYasha>(item => SangeAndYasha = item);
            actionManager.Subscribe<ItemSatanic>(item => Satanic = item);
            actionManager.Subscribe<ItemShadowAmulet>(item => ShadowAmulet = item);
            actionManager.Subscribe<ItemSheepstick>(item => Sheepstick = item);
            actionManager.Subscribe<ItemShivasGuard>(item => ShivasGuard = item);
            actionManager.Subscribe<ItemSilverEdge>(item => SilverEdge = item);
            actionManager.Subscribe<ItemSkadi>(item => Skadi = item);
            actionManager.Subscribe<ItemSlippers>(item => Slippers = item);
            actionManager.Subscribe<ItemSmokeOfDeceit>(item => SmokeOfDeceit = item);
            actionManager.Subscribe<ItemSobiMask>(item => SobiMask = item);
            actionManager.Subscribe<ItemSolarCrest>(item => SolarCrest = item);
            actionManager.Subscribe<ItemSoulBooster>(item => SoulBooster = item);
            actionManager.Subscribe<ItemSoulRing>(item => SoulRing = item);
            actionManager.Subscribe<ItemSphere>(item => Sphere = item);
            actionManager.Subscribe<ItemSpiritVessel>(item => SpiritVessel = item);
            actionManager.Subscribe<ItemStaffOfWizardry>(item => StaffOfWizardry = item);
            actionManager.Subscribe<ItemStoutShield>(item => StoutShield = item);
            actionManager.Subscribe<ItemSwiftBlink>(item => SwiftBlink = item);
            actionManager.Subscribe<ItemTalismanOfEvasion>(item => TalismanOfEvasion = item);
            actionManager.Subscribe<ItemTango>(item => Tango = item);
            actionManager.Subscribe<ItemTangoSingle>(item => TangoSingle = item);
            actionManager.Subscribe<ItemTpscroll>(item => Tpscroll = item);
            actionManager.Subscribe<ItemTranquilBoots>(item => TranquilBoots = item);
            actionManager.Subscribe<ItemTravelBoots>(item => TravelBoots = item);
            actionManager.Subscribe<ItemTravelBoots2>(item => TravelBoots2 = item);
            actionManager.Subscribe<ItemUltimateOrb>(item => UltimateOrb = item);
            actionManager.Subscribe<ItemUltimateScepter>(item => UltimateScepter = item);
            actionManager.Subscribe<ItemUltimateScepter2>(item => UltimateScepter2 = item);
            actionManager.Subscribe<ItemUltimateScepterRoshan>(item => UltimateScepterRoshan = item);
            actionManager.Subscribe<ItemUrnOfShadows>(item => UrnOfShadows = item);
            actionManager.Subscribe<ItemVanguard>(item => Vanguard = item);
            actionManager.Subscribe<ItemVeilOfDiscord>(item => VeilOfDiscord = item);
            actionManager.Subscribe<ItemVitalityBooster>(item => VitalityBooster = item);
            actionManager.Subscribe<ItemVladmir>(item => Vladmir = item);
            actionManager.Subscribe<ItemVoidStone>(item => VoidStone = item);
            actionManager.Subscribe<ItemVoodooMask>(item => VoodooMask = item);
            actionManager.Subscribe<ItemWardObserver>(item => WardObserver = item);
            actionManager.Subscribe<ItemWardSentry>(item => WardSentry = item);
            actionManager.Subscribe<ItemWindLace>(item => WindLace = item);
            actionManager.Subscribe<ItemWindWaker>(item => WindWaker = item);
            actionManager.Subscribe<ItemWitchBlade>(item => WitchBlade = item);
            actionManager.Subscribe<ItemWraithBand>(item => WraithBand = item);
            actionManager.Subscribe<ItemWraithPact>(item => WraithPact = item);
            actionManager.Subscribe<ItemYasha>(item => Yasha = item);
            actionManager.Subscribe<ItemYashaAndKaya>(item => YashaAndKaya = item);
            actionManager.Subscribe<ItemApex>(item => Apex = item);
            actionManager.Subscribe<ItemArcaneRing>(item => ArcaneRing = item);
            actionManager.Subscribe<ItemAsceticCap>(item => AsceticCap = item);
            actionManager.Subscribe<ItemBallista>(item => Ballista = item);
            actionManager.Subscribe<ItemBarricade>(item => Barricade = item);
            actionManager.Subscribe<ItemBlackPowderBag>(item => BlackPowderBag = item);
            actionManager.Subscribe<ItemBlightedSpirit>(item => BlightedSpirit = item);
            actionManager.Subscribe<ItemBookOfShadows>(item => BookOfShadows = item);
            actionManager.Subscribe<ItemBottomlessChalice>(item => BottomlessChalice = item);
            actionManager.Subscribe<ItemBroomHandle>(item => BroomHandle = item);
            actionManager.Subscribe<ItemBullwhip>(item => Bullwhip = item);
            actionManager.Subscribe<ItemCeremonialRobe>(item => CeremonialRobe = item);
            actionManager.Subscribe<ItemChippedVest>(item => ChippedVest = item);
            actionManager.Subscribe<ItemCloakOfFlames>(item => CloakOfFlames = item);
            actionManager.Subscribe<ItemDaggerOfRistul>(item => DaggerOfRistul = item);
            actionManager.Subscribe<ItemDandelionAmulet>(item => DandelionAmulet = item);
            actionManager.Subscribe<ItemDefiantShell>(item => DefiantShell = item);
            actionManager.Subscribe<ItemDemonicon>(item => Demonicon = item);
            actionManager.Subscribe<ItemDesolator2>(item => Desolator2 = item);
            actionManager.Subscribe<ItemDragonScale>(item => DragonScale = item);
            actionManager.Subscribe<ItemDuelistGloves>(item => DuelistGloves = item);
            actionManager.Subscribe<ItemElvenTunic>(item => ElvenTunic = item);
            actionManager.Subscribe<ItemEnchantedQuiver>(item => EnchantedQuiver = item);
            actionManager.Subscribe<ItemEssenceRing>(item => EssenceRing = item);
            actionManager.Subscribe<ItemExMachina>(item => ExMachina = item);
            actionManager.Subscribe<ItemEyeOfTheVizier>(item => EyeOfTheVizier = item);
            actionManager.Subscribe<ItemFadedBroach>(item => FadedBroach = item);
            actionManager.Subscribe<ItemFallenSky>(item => FallenSky = item);
            actionManager.Subscribe<ItemFlicker>(item => Flicker = item);
            actionManager.Subscribe<ItemForceBoots>(item => ForceBoots = item);
            actionManager.Subscribe<ItemForceField>(item => ForceField = item);
            actionManager.Subscribe<ItemFortitudeRing>(item => FortitudeRing = item);
            actionManager.Subscribe<ItemGiantsRing>(item => GiantsRing = item);
            actionManager.Subscribe<ItemGossamerCape>(item => GossamerCape = item);
            actionManager.Subscribe<ItemGroveBow>(item => GroveBow = item);
            actionManager.Subscribe<ItemHarpoon>(item => Harpoon = item);
            actionManager.Subscribe<ItemHavocHammer>(item => HavocHammer = item);
            actionManager.Subscribe<ItemHeavyBlade>(item => HeavyBlade = item);
            actionManager.Subscribe<ItemHorizonsEquilibrium>(item => HorizonsEquilibrium = item);
            actionManager.Subscribe<ItemIcarusWings>(item => IcarusWings = item);
            actionManager.Subscribe<ItemIllusionstsCape>(item => IllusionstsCape = item);
            actionManager.Subscribe<ItemImpClaw>(item => ImpClaw = item);
            actionManager.Subscribe<ItemIronwoodTree>(item => IronwoodTree = item);
            actionManager.Subscribe<ItemKeenOptic>(item => KeenOptic = item);
            actionManager.Subscribe<ItemLanceOfPursuit>(item => LanceOfPursuit = item);
            actionManager.Subscribe<ItemManaclesOfPower>(item => ManaclesOfPower = item);
            actionManager.Subscribe<ItemMartyrsPlate>(item => MartyrsPlate = item);
            actionManager.Subscribe<ItemMindBreaker>(item => MindBreaker = item);
            actionManager.Subscribe<ItemMinotaurHorn>(item => MinotaurHorn = item);
            actionManager.Subscribe<ItemMirrorShield>(item => MirrorShield = item);
            actionManager.Subscribe<ItemMisericorde>(item => Misericorde = item);
            actionManager.Subscribe<ItemMysteriousHat>(item => MysteriousHat = item);
            actionManager.Subscribe<ItemNetherShawl>(item => NetherShawl = item);
            actionManager.Subscribe<ItemNinjaGear>(item => NinjaGear = item);
            actionManager.Subscribe<ItemOccultBracelet>(item => OccultBracelet = item);
            actionManager.Subscribe<ItemOceanHeart>(item => OceanHeart = item);
            actionManager.Subscribe<ItemOgreSealTotem>(item => OgreSealTotem = item);
            actionManager.Subscribe<ItemOrbOfDestruction>(item => OrbOfDestruction = item);
            actionManager.Subscribe<ItemPaintball>(item => Paintball = item);
            actionManager.Subscribe<ItemPaladinSword>(item => PaladinSword = item);
            actionManager.Subscribe<ItemPentaEdgedSword>(item => PentaEdgedSword = item);
            actionManager.Subscribe<ItemPhilosophersStone>(item => PhilosophersStone = item);
            actionManager.Subscribe<ItemPirateHat>(item => PirateHat = item);
            actionManager.Subscribe<ItemPogoStick>(item => PogoStick = item);
            actionManager.Subscribe<ItemPossessedMask>(item => PossessedMask = item);
            actionManager.Subscribe<ItemPrincesKnife>(item => PrincesKnife = item);
            actionManager.Subscribe<ItemPsychicHeadband>(item => PsychicHeadband = item);
            actionManager.Subscribe<ItemPupilsGift>(item => PupilsGift = item);
            actionManager.Subscribe<ItemQuickeningCharm>(item => QuickeningCharm = item);
            actionManager.Subscribe<ItemQuicksilverAmulet>(item => QuicksilverAmulet = item);
            actionManager.Subscribe<ItemRingOfAquila>(item => RingOfAquila = item);
            actionManager.Subscribe<ItemRoyalJelly>(item => RoyalJelly = item);
            actionManager.Subscribe<ItemSeedsOfSerenity>(item => SeedsOfSerenity = item);
            actionManager.Subscribe<ItemSeerStone>(item => SeerStone = item);
            actionManager.Subscribe<ItemSlimeVial>(item => SlimeVial = item);
            actionManager.Subscribe<ItemSparkOfCourage>(item => SparkOfCourage = item);
            actionManager.Subscribe<ItemSpecialistsArray>(item => SpecialistsArray = item);
            actionManager.Subscribe<ItemSpellPrism>(item => SpellPrism = item);
            actionManager.Subscribe<ItemSpiderLegs>(item => SpiderLegs = item);
            actionManager.Subscribe<ItemSpyGadget>(item => SpyGadget = item);
            actionManager.Subscribe<ItemStormcrafter>(item => Stormcrafter = item);
            actionManager.Subscribe<ItemTheLeveller>(item => TheLeveller = item);
            actionManager.Subscribe<ItemTimelessRelic>(item => TimelessRelic = item);
            actionManager.Subscribe<ItemTitanSliver>(item => TitanSliver = item);
            actionManager.Subscribe<ItemTricksterCloak>(item => TricksterCloak = item);
            actionManager.Subscribe<ItemTrustyShovel>(item => TrustyShovel = item);
            actionManager.Subscribe<ItemUnstableWand>(item => UnstableWand = item);
            actionManager.Subscribe<ItemVambrace>(item => Vambrace = item);
            actionManager.Subscribe<ItemVampireFangs>(item => VampireFangs = item);
            actionManager.Subscribe<ItemVengeancesShadow>(item => VengeancesShadow = item);
            actionManager.Subscribe<ItemVindicatorsAxe>(item => VindicatorsAxe = item);
            actionManager.Subscribe<ItemWandOfSanctitude>(item => WandOfSanctitude = item);
            actionManager.Subscribe<ItemAncientPerseverance>(item => AncientPerseverance = item);
            actionManager.Subscribe<ItemArcaneScout>(item => ArcaneScout = item);
            actionManager.Subscribe<ItemAssassinsDagger>(item => AssassinsDagger = item);
            actionManager.Subscribe<ItemClumsyNet>(item => ClumsyNet = item);
            actionManager.Subscribe<ItemComboBreaker>(item => ComboBreaker = item);
            actionManager.Subscribe<ItemCourier>(item => Courier = item);
            actionManager.Subscribe<ItemCraggyCoat>(item => CraggyCoat = item);
            actionManager.Subscribe<ItemDimensionalDoorway>(item => DimensionalDoorway = item);
            actionManager.Subscribe<ItemElixer>(item => Elixer = item);
            actionManager.Subscribe<ItemFamango>(item => Famango = item);
            actionManager.Subscribe<ItemFlyingCourier>(item => FlyingCourier = item);
            actionManager.Subscribe<ItemFusionRune>(item => FusionRune = item);
            actionManager.Subscribe<ItemGladiatorHelm>(item => GladiatorHelm = item);
            actionManager.Subscribe<ItemGrandmastersGlaive>(item => GrandmastersGlaive = item);
            actionManager.Subscribe<ItemGreaterFaerieFire>(item => GreaterFaerieFire = item);
            actionManager.Subscribe<ItemGreaterFamango>(item => GreaterFamango = item);
            actionManager.Subscribe<ItemGreaterMango>(item => GreaterMango = item);
            actionManager.Subscribe<ItemGreatFamango>(item => GreatFamango = item);
            actionManager.Subscribe<ItemHelmOfTheUndying>(item => HelmOfTheUndying = item);
            actionManager.Subscribe<ItemHermesSandals>(item => HermesSandals = item);
            actionManager.Subscribe<ItemHorizon>(item => Horizon = item);
            actionManager.Subscribe<ItemIronTalon>(item => IronTalon = item);
            actionManager.Subscribe<ItemLightRobes>(item => LightRobes = item);
            actionManager.Subscribe<ItemLunarCrest>(item => LunarCrest = item);
            actionManager.Subscribe<ItemMangoTree>(item => MangoTree = item);
            actionManager.Subscribe<ItemMechanicalArm>(item => MechanicalArm = item);
            actionManager.Subscribe<ItemMuertasGun>(item => MuertasGun = item);
            actionManager.Subscribe<ItemMutationTombstone>(item => MutationTombstone = item);
            actionManager.Subscribe<ItemNecronomicon>(item => Necronomicon = item);
            actionManager.Subscribe<ItemNecronomicon2>(item => Necronomicon2 = item);
            actionManager.Subscribe<ItemNecronomicon3>(item => Necronomicon3 = item);
            actionManager.Subscribe<ItemOakheart>(item => Oakheart = item);
            actionManager.Subscribe<ItemOfrenda>(item => Ofrenda = item);
            actionManager.Subscribe<ItemOfrendaPledge>(item => OfrendaPledge = item);
            actionManager.Subscribe<ItemOfrendaShovel>(item => OfrendaShovel = item);
            actionManager.Subscribe<ItemOverflowingElixir>(item => OverflowingElixir = item);
            actionManager.Subscribe<ItemPanicButton>(item => PanicButton = item);
            actionManager.Subscribe<ItemPhoenixAsh>(item => PhoenixAsh = item);
            actionManager.Subscribe<ItemPocketRoshan>(item => PocketRoshan = item);
            actionManager.Subscribe<ItemPocketTower>(item => PocketTower = item);
            actionManager.Subscribe<ItemPoorMansShield>(item => PoorMansShield = item);
            actionManager.Subscribe<ItemRepairKit>(item => RepairKit = item);
            actionManager.Subscribe<ItemRiverPainter>(item => RiverPainter = item);
            actionManager.Subscribe<ItemRiverPainter2>(item => RiverPainter2 = item);
            actionManager.Subscribe<ItemRiverPainter3>(item => RiverPainter3 = item);
            actionManager.Subscribe<ItemRiverPainter4>(item => RiverPainter4 = item);
            actionManager.Subscribe<ItemRiverPainter5>(item => RiverPainter5 = item);
            actionManager.Subscribe<ItemRiverPainter6>(item => RiverPainter6 = item);
            actionManager.Subscribe<ItemRiverPainter7>(item => RiverPainter7 = item);
            actionManager.Subscribe<ItemRoyaleWithCheese>(item => RoyaleWithCheese = item);
            actionManager.Subscribe<ItemSamplePicker>(item => SamplePicker = item);
            actionManager.Subscribe<ItemSamuraiTabi>(item => SamuraiTabi = item);
            actionManager.Subscribe<ItemSatchel>(item => Satchel = item);
            actionManager.Subscribe<ItemStarMace>(item => StarMace = item);
            actionManager.Subscribe<ItemSuperBlink>(item => SuperBlink = item);
            actionManager.Subscribe<ItemThirdEye>(item => ThirdEye = item);
            actionManager.Subscribe<ItemTier1Token>(item => Tier1Token = item);
            actionManager.Subscribe<ItemTier2Token>(item => Tier2Token = item);
            actionManager.Subscribe<ItemTier3Token>(item => Tier3Token = item);
            actionManager.Subscribe<ItemTier4Token>(item => Tier4Token = item);
            actionManager.Subscribe<ItemTier5Token>(item => Tier5Token = item);
            actionManager.Subscribe<ItemTomeOfAghanim>(item => TomeOfAghanim = item);
            actionManager.Subscribe<ItemTomeOfKnowledge>(item => TomeOfKnowledge = item);
            actionManager.Subscribe<ItemTomeOfOmniscience>(item => TomeOfOmniscience = item);
            actionManager.Subscribe<ItemTrident>(item => Trident = item);
            actionManager.Subscribe<ItemTurtleShell>(item => TurtleShell = item);
            actionManager.Subscribe<ItemVenomGland>(item => VenomGland = item);
            actionManager.Subscribe<ItemWandOfTheBrine>(item => WandOfTheBrine = item);
            actionManager.Subscribe<ItemWardDispenser>(item => WardDispenser = item);
            actionManager.Subscribe<ItemWarhammer>(item => Warhammer = item);
            actionManager.Subscribe<ItemWitchesSwitch>(item => WitchesSwitch = item);
            actionManager.Subscribe<ItemWitlessShako>(item => WitlessShako = item);
            actionManager.Subscribe<ItemWizardGlass>(item => WizardGlass = item);
            actionManager.Subscribe<ItemWoodlandStriders>(item => WoodlandStriders = item);
        }




        //.
        public ItemAbyssalBlade? AbyssalBlade { get; private set; }
        public ItemAegis? Aegis { get; private set; }
        public ItemAeonDisk? AeonDisk { get; private set; }
        public ItemAetherLens? AetherLens { get; private set; }
        public ItemAghanimsShard? AghanimsShard { get; private set; }
        public ItemAghanimsShardRoshan? AghanimsShardRoshan { get; private set; }
        public ItemAncientJanggo? AncientJanggo { get; private set; }
        public ItemArcaneBlink? ArcaneBlink { get; private set; }
        public ItemArcaneBoots? ArcaneBoots { get; private set; }
        public ItemArmlet? Armlet { get; private set; }
        public ItemAssault? Assault { get; private set; }
        public ItemBasher? Basher { get; private set; }
        public ItemBeltOfStrength? BeltOfStrength { get; private set; }
        public ItemBfury? Bfury { get; private set; }
        public ItemBlackKingBar? BlackKingBar { get; private set; }
        public ItemBladeMail? BladeMail { get; private set; }
        public ItemBladeOfAlacrity? BladeOfAlacrity { get; private set; }
        public ItemBladesOfAttack? BladesOfAttack { get; private set; }
        public ItemBlightStone? BlightStone { get; private set; }
        public ItemBlink? Blink { get; private set; }
        public ItemBlitzKnuckles? BlitzKnuckles { get; private set; }
        public ItemBloodGrenade? BloodGrenade { get; private set; }
        public ItemBloodstone? Bloodstone { get; private set; }
        public ItemBloodthorn? Bloodthorn { get; private set; }
        public ItemBoots? Boots { get; private set; }
        public ItemBootsOfBearing? BootsOfBearing { get; private set; }
        public ItemBootsOfElves? BootsOfElves { get; private set; }
        public ItemBottle? Bottle { get; private set; }
        public ItemBracer? Bracer { get; private set; }
        public ItemBranches? Branches { get; private set; }
        public ItemBroadsword? Broadsword { get; private set; }
        public ItemBuckler? Buckler { get; private set; }
        public ItemButterfly? Butterfly { get; private set; }
        public ItemChainmail? Chainmail { get; private set; }
        public ItemCheese? Cheese { get; private set; }
        public ItemCirclet? Circlet { get; private set; }
        public ItemClarity? Clarity { get; private set; }
        public ItemClaymore? Claymore { get; private set; }
        public ItemCloak? Cloak { get; private set; }
        public ItemCornucopia? Cornucopia { get; private set; }
        public ItemCrimsonGuard? CrimsonGuard { get; private set; }
        public ItemCrown? Crown { get; private set; }
        public ItemCyclone? Cyclone { get; private set; }
        public ItemDagon? Dagon { get; private set; }
        public ItemDagon2? Dagon2 { get; private set; }
        public ItemDagon3? Dagon3 { get; private set; }
        public ItemDagon4? Dagon4 { get; private set; }
        public ItemDagon5? Dagon5 { get; private set; }
        public ItemDemonEdge? DemonEdge { get; private set; }
        public ItemDesolator? Desolator { get; private set; }
        public ItemDiadem? Diadem { get; private set; }
        public ItemDiffusalBlade? DiffusalBlade { get; private set; }
        public ItemDisperser? Disperser { get; private set; }
        public ItemDragonLance? DragonLance { get; private set; }
        public ItemDust? Dust { get; private set; }
        public ItemEagle? Eagle { get; private set; }
        public ItemEchoSabre? EchoSabre { get; private set; }
        public ItemEnchantedMango? EnchantedMango { get; private set; }
        public ItemEnergyBooster? EnergyBooster { get; private set; }
        public ItemEternalShroud? EternalShroud { get; private set; }
        public ItemEtherealBlade? EtherealBlade { get; private set; }
        public ItemFaerieFire? FaerieFire { get; private set; }
        public ItemFalconBlade? FalconBlade { get; private set; }
        public ItemFlask? Flask { get; private set; }
        public ItemFluffyHat? FluffyHat { get; private set; }
        public ItemForceStaff? ForceStaff { get; private set; }
        public ItemGauntlets? Gauntlets { get; private set; }
        public ItemGem? Gem { get; private set; }
        public ItemGhost? Ghost { get; private set; }
        public ItemGlimmerCape? GlimmerCape { get; private set; }
        public ItemGloves? Gloves { get; private set; }
        public ItemGlovesOfTravel? GlovesOfTravel { get; private set; }
        public ItemGreaterCrit? GreaterCrit { get; private set; }
        public ItemGuardianGreaves? GuardianGreaves { get; private set; }
        public ItemGungir? Gungir { get; private set; }
        public ItemHandOfMidas? HandOfMidas { get; private set; }
        public ItemHeaddress? Headdress { get; private set; }
        public ItemHeart? Heart { get; private set; }
        public ItemHeavensHalberd? HeavensHalberd { get; private set; }
        public ItemHelmOfIronWill? HelmOfIronWill { get; private set; }
        public ItemHelmOfTheDominator? HelmOfTheDominator { get; private set; }
        public ItemHelmOfTheOverlord? HelmOfTheOverlord { get; private set; }
        public ItemHolyLocket? HolyLocket { get; private set; }
        public ItemHoodOfDefiance? HoodOfDefiance { get; private set; }
        public ItemHurricanePike? HurricanePike { get; private set; }
        public ItemHyperstone? Hyperstone { get; private set; }
        public ItemInfusedRaindrop? InfusedRaindrop { get; private set; }
        public ItemInvisSword? InvisSword { get; private set; }
        public ItemJavelin? Javelin { get; private set; }
        public ItemKaya? Kaya { get; private set; }
        public ItemKayaAndSange? KayaAndSange { get; private set; }
        public ItemLesserCrit? LesserCrit { get; private set; }
        public ItemLifesteal? Lifesteal { get; private set; }
        public ItemLotusOrb? LotusOrb { get; private set; }
        public ItemMaelstrom? Maelstrom { get; private set; }
        public ItemMageSlayer? MageSlayer { get; private set; }
        public ItemMagicStick? MagicStick { get; private set; }
        public ItemMagicWand? MagicWand { get; private set; }
        public ItemManta? Manta { get; private set; }
        public ItemMantle? Mantle { get; private set; }
        public ItemMaskOfMadness? MaskOfMadness { get; private set; }
        public ItemMedallionOfCourage? MedallionOfCourage { get; private set; }
        public ItemMekansm? Mekansm { get; private set; }
        public ItemMeteorHammer? MeteorHammer { get; private set; }
        public ItemMithrilHammer? MithrilHammer { get; private set; }
        public ItemMjollnir? Mjollnir { get; private set; }
        public ItemMonkeyKingBar? MonkeyKingBar { get; private set; }
        public ItemMoonShard? MoonShard { get; private set; }
        public ItemMysticStaff? MysticStaff { get; private set; }
        public ItemNullifier? Nullifier { get; private set; }
        public ItemNullTalisman? NullTalisman { get; private set; }
        public ItemOblivionStaff? OblivionStaff { get; private set; }
        public ItemOctarineCore? OctarineCore { get; private set; }
        public ItemOgreAxe? OgreAxe { get; private set; }
        public ItemOrbOfCorrosion? OrbOfCorrosion { get; private set; }
        public ItemOrbOfVenom? OrbOfVenom { get; private set; }
        public ItemOrchid? Orchid { get; private set; }
        public ItemOverwhelmingBlink? OverwhelmingBlink { get; private set; }
        public ItemPavise? Pavise { get; private set; }
        public ItemPers? Pers { get; private set; }
        public ItemPhaseBoots? PhaseBoots { get; private set; }
        public ItemPhylactery? Phylactery { get; private set; }
        public ItemPipe? Pipe { get; private set; }
        public ItemPlatemail? Platemail { get; private set; }
        public ItemPointBooster? PointBooster { get; private set; }
        public ItemPowerTreads? PowerTreads { get; private set; }
        public ItemQuarterstaff? Quarterstaff { get; private set; }
        public ItemQuellingBlade? QuellingBlade { get; private set; }
        public ItemRadiance? Radiance { get; private set; }
        public ItemRapier? Rapier { get; private set; }
        public ItemReaver? Reaver { get; private set; }
        public ItemRecipeMagicWand? RecipeMagicWand { get; private set; }
        public ItemRefresher? Refresher { get; private set; }
        public ItemRefresherShard? RefresherShard { get; private set; }
        public ItemRelic? Relic { get; private set; }
        public ItemRevenantsBrooch? RevenantsBrooch { get; private set; }
        public ItemRingOfBasilius? RingOfBasilius { get; private set; }
        public ItemRingOfHealth? RingOfHealth { get; private set; }
        public ItemRingOfProtection? RingOfProtection { get; private set; }
        public ItemRingOfRegen? RingOfRegen { get; private set; }
        public ItemRingOfTarrasque? RingOfTarrasque { get; private set; }
        public ItemRobe? Robe { get; private set; }
        public ItemRodOfAtos? RodOfAtos { get; private set; }
        public ItemSange? Sange { get; private set; }
        public ItemSangeAndYasha? SangeAndYasha { get; private set; }
        public ItemSatanic? Satanic { get; private set; }
        public ItemShadowAmulet? ShadowAmulet { get; private set; }
        public ItemSheepstick? Sheepstick { get; private set; }
        public ItemShivasGuard? ShivasGuard { get; private set; }
        public ItemSilverEdge? SilverEdge { get; private set; }
        public ItemSkadi? Skadi { get; private set; }
        public ItemSlippers? Slippers { get; private set; }
        public ItemSmokeOfDeceit? SmokeOfDeceit { get; private set; }
        public ItemSobiMask? SobiMask { get; private set; }
        public ItemSolarCrest? SolarCrest { get; private set; }
        public ItemSoulBooster? SoulBooster { get; private set; }
        public ItemSoulRing? SoulRing { get; private set; }
        public ItemSphere? Sphere { get; private set; }
        public ItemSpiritVessel? SpiritVessel { get; private set; }
        public ItemStaffOfWizardry? StaffOfWizardry { get; private set; }
        public ItemStoutShield? StoutShield { get; private set; }
        public ItemSwiftBlink? SwiftBlink { get; private set; }
        public ItemTalismanOfEvasion? TalismanOfEvasion { get; private set; }
        public ItemTango? Tango { get; private set; }
        public ItemTangoSingle? TangoSingle { get; private set; }
        public ItemTpscroll? Tpscroll { get; private set; }
        public ItemTranquilBoots? TranquilBoots { get; private set; }
        public ItemTravelBoots? TravelBoots { get; private set; }
        public ItemTravelBoots2? TravelBoots2 { get; private set; }
        public ItemUltimateOrb? UltimateOrb { get; private set; }
        public ItemUltimateScepter? UltimateScepter { get; private set; }
        public ItemUltimateScepter2? UltimateScepter2 { get; private set; }
        public ItemUltimateScepterRoshan? UltimateScepterRoshan { get; private set; }
        public ItemUrnOfShadows? UrnOfShadows { get; private set; }
        public ItemVanguard? Vanguard { get; private set; }
        public ItemVeilOfDiscord? VeilOfDiscord { get; private set; }
        public ItemVitalityBooster? VitalityBooster { get; private set; }
        public ItemVladmir? Vladmir { get; private set; }
        public ItemVoidStone? VoidStone { get; private set; }
        public ItemVoodooMask? VoodooMask { get; private set; }
        public ItemWardObserver? WardObserver { get; private set; }
        public ItemWardSentry? WardSentry { get; private set; }
        public ItemWindLace? WindLace { get; private set; }
        public ItemWindWaker? WindWaker { get; private set; }
        public ItemWitchBlade? WitchBlade { get; private set; }
        public ItemWraithBand? WraithBand { get; private set; }
        public ItemWraithPact? WraithPact { get; private set; }
        public ItemYasha? Yasha { get; private set; }
        public ItemYashaAndKaya? YashaAndKaya { get; private set; }

        //Neutrals
        public ItemApex? Apex { get; private set; }
        public ItemArcaneRing? ArcaneRing { get; private set; }
        public ItemAsceticCap? AsceticCap { get; private set; }
        public ItemBallista? Ballista { get; private set; }
        public ItemBarricade? Barricade { get; private set; }
        public ItemBlackPowderBag? BlackPowderBag { get; private set; }
        public ItemBlightedSpirit? BlightedSpirit { get; private set; }
        public ItemBookOfShadows? BookOfShadows { get; private set; }
        public ItemBottomlessChalice? BottomlessChalice { get; private set; }
        public ItemBroomHandle? BroomHandle { get; private set; }
        public ItemBullwhip? Bullwhip { get; private set; }
        public ItemCeremonialRobe? CeremonialRobe { get; private set; }
        public ItemChippedVest? ChippedVest { get; private set; }
        public ItemCloakOfFlames? CloakOfFlames { get; private set; }
        public ItemDaggerOfRistul? DaggerOfRistul { get; private set; }
        public ItemDandelionAmulet? DandelionAmulet { get; private set; }
        public ItemDefiantShell? DefiantShell { get; private set; }
        public ItemDemonicon? Demonicon { get; private set; }
        public ItemDesolator2? Desolator2 { get; private set; }
        public ItemDragonScale? DragonScale { get; private set; }
        public ItemDuelistGloves? DuelistGloves { get; private set; }
        public ItemElvenTunic? ElvenTunic { get; private set; }
        public ItemEnchantedQuiver? EnchantedQuiver { get; private set; }
        public ItemEssenceRing? EssenceRing { get; private set; }
        public ItemExMachina? ExMachina { get; private set; }
        public ItemEyeOfTheVizier? EyeOfTheVizier { get; private set; }
        public ItemFadedBroach? FadedBroach { get; private set; }
        public ItemFallenSky? FallenSky { get; private set; }
        public ItemFlicker? Flicker { get; private set; }
        public ItemForceBoots? ForceBoots { get; private set; }
        public ItemForceField? ForceField { get; private set; }
        public ItemFortitudeRing? FortitudeRing { get; private set; }
        public ItemGiantsRing? GiantsRing { get; private set; }
        public ItemGossamerCape? GossamerCape { get; private set; }
        public ItemGroveBow? GroveBow { get; private set; }
        public ItemHarpoon? Harpoon { get; private set; }
        public ItemHavocHammer? HavocHammer { get; private set; }
        public ItemHeavyBlade? HeavyBlade { get; private set; }
        public ItemHorizonsEquilibrium? HorizonsEquilibrium { get; private set; }
        public ItemIcarusWings? IcarusWings { get; private set; }
        public ItemIllusionstsCape? IllusionstsCape { get; private set; }
        public ItemImpClaw? ImpClaw { get; private set; }
        public ItemIronwoodTree? IronwoodTree { get; private set; }
        public ItemKeenOptic? KeenOptic { get; private set; }
        public ItemLanceOfPursuit? LanceOfPursuit { get; private set; }
        public ItemManaclesOfPower? ManaclesOfPower { get; private set; }
        public ItemMartyrsPlate? MartyrsPlate { get; private set; }
        public ItemMindBreaker? MindBreaker { get; private set; }
        public ItemMinotaurHorn? MinotaurHorn { get; private set; }
        public ItemMirrorShield? MirrorShield { get; private set; }
        public ItemMisericorde? Misericorde { get; private set; }
        public ItemMysteriousHat? MysteriousHat { get; private set; }
        public ItemNetherShawl? NetherShawl { get; private set; }
        public ItemNinjaGear? NinjaGear { get; private set; }
        public ItemOccultBracelet? OccultBracelet { get; private set; }
        public ItemOceanHeart? OceanHeart { get; private set; }
        public ItemOgreSealTotem? OgreSealTotem { get; private set; }
        public ItemOrbOfDestruction? OrbOfDestruction { get; private set; }
        public ItemPaintball? Paintball { get; private set; }
        public ItemPaladinSword? PaladinSword { get; private set; }
        public ItemPentaEdgedSword? PentaEdgedSword { get; private set; }
        public ItemPhilosophersStone? PhilosophersStone { get; private set; }
        public ItemPirateHat? PirateHat { get; private set; }
        public ItemPogoStick? PogoStick { get; private set; }
        public ItemPossessedMask? PossessedMask { get; private set; }
        public ItemPrincesKnife? PrincesKnife { get; private set; }
        public ItemPsychicHeadband? PsychicHeadband { get; private set; }
        public ItemPupilsGift? PupilsGift { get; private set; }
        public ItemQuickeningCharm? QuickeningCharm { get; private set; }
        public ItemQuicksilverAmulet? QuicksilverAmulet { get; private set; }
        public ItemRingOfAquila? RingOfAquila { get; private set; }
        public ItemRoyalJelly? RoyalJelly { get; private set; }
        public ItemSeedsOfSerenity? SeedsOfSerenity { get; private set; }
        public ItemSeerStone? SeerStone { get; private set; }
        public ItemSlimeVial? SlimeVial { get; private set; }
        public ItemSparkOfCourage? SparkOfCourage { get; private set; }
        public ItemSpecialistsArray? SpecialistsArray { get; private set; }
        public ItemSpellPrism? SpellPrism { get; private set; }
        public ItemSpiderLegs? SpiderLegs { get; private set; }
        public ItemSpyGadget? SpyGadget { get; private set; }
        public ItemStormcrafter? Stormcrafter { get; private set; }
        public ItemTheLeveller? TheLeveller { get; private set; }
        public ItemTimelessRelic? TimelessRelic { get; private set; }
        public ItemTitanSliver? TitanSliver { get; private set; }
        public ItemTricksterCloak? TricksterCloak { get; private set; }
        public ItemTrustyShovel? TrustyShovel { get; private set; }
        public ItemUnstableWand? UnstableWand { get; private set; }
        public ItemVambrace? Vambrace { get; private set; }
        public ItemVampireFangs? VampireFangs { get; private set; }
        public ItemVengeancesShadow? VengeancesShadow { get; private set; }
        public ItemVindicatorsAxe? VindicatorsAxe { get; private set; }
        public ItemWandOfSanctitude? WandOfSanctitude { get; private set; }

        //Others
        public ItemAncientPerseverance? AncientPerseverance { get; private set; }
        public ItemArcaneScout? ArcaneScout { get; private set; }
        public ItemAssassinsDagger? AssassinsDagger { get; private set; }
        public ItemClumsyNet? ClumsyNet { get; private set; }
        public ItemComboBreaker? ComboBreaker { get; private set; }
        public ItemCourier? Courier { get; private set; }
        public ItemCraggyCoat? CraggyCoat { get; private set; }
        public ItemDimensionalDoorway? DimensionalDoorway { get; private set; }
        public ItemElixer? Elixer { get; private set; }
        public ItemFamango? Famango { get; private set; }
        public ItemFlyingCourier? FlyingCourier { get; private set; }
        public ItemFusionRune? FusionRune { get; private set; }
        public ItemGladiatorHelm? GladiatorHelm { get; private set; }
        public ItemGrandmastersGlaive? GrandmastersGlaive { get; private set; }
        public ItemGreaterFaerieFire? GreaterFaerieFire { get; private set; }
        public ItemGreaterFamango? GreaterFamango { get; private set; }
        public ItemGreaterMango? GreaterMango { get; private set; }
        public ItemGreatFamango? GreatFamango { get; private set; }
        public ItemHelmOfTheUndying? HelmOfTheUndying { get; private set; }
        public ItemHermesSandals? HermesSandals { get; private set; }
        public ItemHorizon? Horizon { get; private set; }
        public ItemIronTalon? IronTalon { get; private set; }
        public ItemLightRobes? LightRobes { get; private set; }
        public ItemLunarCrest? LunarCrest { get; private set; }
        public ItemMangoTree? MangoTree { get; private set; }
        public ItemMechanicalArm? MechanicalArm { get; private set; }
        public ItemMuertasGun? MuertasGun { get; private set; }
        public ItemMutationTombstone? MutationTombstone { get; private set; }
        public ItemNecronomicon? Necronomicon { get; private set; }
        public ItemNecronomicon2? Necronomicon2 { get; private set; }
        public ItemNecronomicon3? Necronomicon3 { get; private set; }
        public ItemOakheart? Oakheart { get; private set; }
        public ItemOfrenda? Ofrenda { get; private set; }
        public ItemOfrendaPledge? OfrendaPledge { get; private set; }
        public ItemOfrendaShovel? OfrendaShovel { get; private set; }
        public ItemOverflowingElixir? OverflowingElixir { get; private set; }
        public ItemPanicButton? PanicButton { get; private set; }
        public ItemPhoenixAsh? PhoenixAsh { get; private set; }
        public ItemPocketRoshan? PocketRoshan { get; private set; }
        public ItemPocketTower? PocketTower { get; private set; }
        public ItemPoorMansShield? PoorMansShield { get; private set; }
        public ItemRepairKit? RepairKit { get; private set; }
        public ItemRiverPainter? RiverPainter { get; private set; }
        public ItemRiverPainter2? RiverPainter2 { get; private set; }
        public ItemRiverPainter3? RiverPainter3 { get; private set; }
        public ItemRiverPainter4? RiverPainter4 { get; private set; }
        public ItemRiverPainter5? RiverPainter5 { get; private set; }
        public ItemRiverPainter6? RiverPainter6 { get; private set; }
        public ItemRiverPainter7? RiverPainter7 { get; private set; }
        public ItemRoyaleWithCheese? RoyaleWithCheese { get; private set; }
        public ItemSamplePicker? SamplePicker { get; private set; }
        public ItemSamuraiTabi? SamuraiTabi { get; private set; }
        public ItemSatchel? Satchel { get; private set; }
        public ItemStarMace? StarMace { get; private set; }
        public ItemSuperBlink? SuperBlink { get; private set; }
        public ItemThirdEye? ThirdEye { get; private set; }
        public ItemTier1Token? Tier1Token { get; private set; }
        public ItemTier2Token? Tier2Token { get; private set; }
        public ItemTier3Token? Tier3Token { get; private set; }
        public ItemTier4Token? Tier4Token { get; private set; }
        public ItemTier5Token? Tier5Token { get; private set; }
        public ItemTomeOfAghanim? TomeOfAghanim { get; private set; }
        public ItemTomeOfKnowledge? TomeOfKnowledge { get; private set; }
        public ItemTomeOfOmniscience? TomeOfOmniscience { get; private set; }
        public ItemTrident? Trident { get; private set; }
        public ItemTurtleShell? TurtleShell { get; private set; }
        public ItemVenomGland? VenomGland { get; private set; }
        public ItemWandOfTheBrine? WandOfTheBrine { get; private set; }
        public ItemWardDispenser? WardDispenser { get; private set; }
        public ItemWarhammer? Warhammer { get; private set; }
        public ItemWitchesSwitch? WitchesSwitch { get; private set; }
        public ItemWitlessShako? WitlessShako { get; private set; }
        public ItemWizardGlass? WizardGlass { get; private set; }
        public ItemWoodlandStriders? WoodlandStriders { get; private set; }

    }
   


}
