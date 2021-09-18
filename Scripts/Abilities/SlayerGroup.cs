using Server.Engines.Shadowguard;
using Server.Mobiles;
using System;
using System.Collections.Generic;

namespace Server.Items
{
    public class SlayerGroup
    {
        private static readonly SlayerEntry[] m_TotalEntries;
        private static readonly SlayerGroup[] m_Groups;
        private SlayerGroup[] m_Opposition;
        private SlayerEntry m_Super;
        private SlayerEntry[] m_Entries;
        private Type[] m_FoundOn;

        static SlayerGroup()
        {
            SlayerGroup humanoid = new SlayerGroup();
            SlayerGroup undead = new SlayerGroup();
            SlayerGroup elemental = new SlayerGroup();
            SlayerGroup abyss = new SlayerGroup();
            SlayerGroup arachnid = new SlayerGroup();
            SlayerGroup reptilian = new SlayerGroup();
            SlayerGroup fey = new SlayerGroup();
            SlayerGroup eodon = new SlayerGroup();
            SlayerGroup eodonTribe = new SlayerGroup();
            SlayerGroup dino = new SlayerGroup();
            SlayerGroup myrmidex = new SlayerGroup();

            humanoid.Opposition = new[]
                {
                    undead
                };

            humanoid.FoundOn = new[]
                {
                    typeof(BoneKnight),     typeof(Lich),
                    typeof(LichLord)
                };

            humanoid.Super = new SlayerEntry
                (
                    SlayerName.Repond,

                    typeof(ClanCA), typeof(ClanCT),
                    typeof(ClanRS), typeof(ClanRC),
                    typeof(ClanSS), typeof(ClanSH),
                    typeof(Barracoon), typeof(MasterTheophilus),
                    typeof(Lurg), typeof(ArcticOgreLord),
                    typeof(Cyclops), typeof(Ettin),
                    typeof(EvilMage), typeof(EvilMageLord),
                    typeof(FrostTroll), typeof(MeerCaptain),
                    typeof(MeerEternal), typeof(MeerMage),
                    typeof(MeerWarrior), typeof(Ogre),
                    typeof(OgreLord), typeof(Orc),
                    typeof(OrcBomber), typeof(OrcBrute),
                    typeof(OrcCaptain), typeof(OrcChopper),
                    typeof(OrcScout), typeof(OrcishLord),
                    typeof(OrcishMage), typeof(Ratman),
                    typeof(RatmanArcher), typeof(RatmanMage),
                    typeof(SavageRider), typeof(SavageShaman),
                    typeof(Savage), typeof(Titan),
                    typeof(Troll),
                    typeof(Troglodyte), typeof(MougGuur),
                    typeof(Chiikkaha), typeof(Minotaur),
                    typeof(MinotaurGeneral), typeof(Medusa),
                    typeof(RakktaviRenowned), typeof(TikitaviRenowned),
                    typeof(VitaviRenowned), typeof(EnslavedGoblinScout),
                    typeof(EnslavedGoblinKeeper), typeof(EnslavedGreenGoblin),
                    typeof(EnslavedGreenGoblinAlchemist), typeof(EnslavedGoblinMage),
                    typeof(EnslavedGrayGoblin), typeof(GreenGoblinScout),
                    typeof(GreenGoblinAlchemist), typeof(GreenGoblin),
                    typeof(GrayGoblinMage), typeof(GrayGoblinKeeper),
                    typeof(GrayGoblin), typeof(GreenGoblinAlchemistRenowned),
                    typeof(GrayGoblinMageRenowned), typeof(CorgulTheSoulBinder),
                    typeof(PirateCrew), typeof(LizardmanWitchdoctor),
                    typeof(OrcFootSoldier), typeof(RatmanAssassin),
                    typeof(OgreBoneCrusher), typeof(TitanRockHunter),
                    typeof(CaveTrollWrong), typeof(HungryOgre),
                    typeof(Archmage), typeof(Fezzik)
                );

            humanoid.Entries = new[]
            {
                new SlayerEntry
                    (
                        SlayerName.OgreTrashing,

                        typeof(Ogre), typeof(OgreLord),
                        typeof(ArcticOgreLord), typeof(OgreBoneCrusher),
                        typeof(HungryOgre), typeof(Fezzik)
                    ),

                new SlayerEntry
                    (
                        SlayerName.OrcSlaying,

                        typeof(Orc), typeof(OrcBomber),
                        typeof(OrcBrute), typeof(OrcCaptain),
                        typeof(OrcChopper), typeof(OrcScout),
                        typeof(OrcishLord), typeof(OrcishMage),
                        typeof(OrcFootSoldier), typeof(PirateCrew) // PirateCrew are orcs.
                    ),

                new SlayerEntry
                    (
                        SlayerName.TrollSlaughter,

                        typeof(Troll), typeof(FrostTroll), typeof(CaveTrollWrong)
                    )
            };

            undead.Opposition = new[]
                {
                    humanoid
                };

            undead.Super = new SlayerEntry
                (
                    SlayerName.Silver,

                    typeof(AncientLich), typeof(AncientLichRenowned),
                    typeof(Bogle), typeof(BoneKnight),
                    typeof(BoneMagi), typeof(DarkGuardian),
                    typeof(DarknightCreeper), typeof(FleshGolem),
                    typeof(Ghoul), typeof(GoreFiend),
                    typeof(HellSteed), typeof(LadyOfTheSnow),
                    typeof(Lich), typeof(LichLord),
                    typeof(Mummy), typeof(PestilentBandage),
                    typeof(Revenant), typeof(RevenantLion),
                    typeof(RottingCorpse), typeof(Shade),
                    typeof(ShadowKnight), typeof(SkeletalKnight),
                    typeof(SkeletalMage), typeof(SkeletalMount),
                    typeof(Skeleton), typeof(Spectre),
                    typeof(Wraith), typeof(Zombie),
                    typeof(UnfrozenMummy), typeof(RedDeath),
                    typeof(SirPatrick), typeof(LadyJennifyr),
                    typeof(MasterMikael), typeof(MasterJonath),
                    typeof(LadyMarai), typeof(PrimevalLich),
                    typeof(Niporailem), typeof(DreamWraith),
                    typeof(EffeteUndeadGargoyle), typeof(UndeadGargoyle),
                    typeof(UndeadGuardian), typeof(PutridUndeadGargoyle),
                    typeof(PutridUndeadGuardian), typeof(Juonar),
                    typeof(Spellbinder), typeof(AngeredSpirit),
                    typeof(BoneSwordSlinger), typeof(CovetousRevenant),
                    typeof(DiseasedLich), typeof(VileCadaver),
                    typeof(GrizzledMare), typeof(SkeletalCat),
					typeof(CursedMetallicKnight), typeof(CursedMetallicMage)
                );

            undead.Entries = new SlayerEntry[0];

            fey.Opposition = new[]
                {
                    abyss
                };

            fey.Super = new SlayerEntry
                (
                    SlayerName.Fey,

                    typeof(Centaur), typeof(CuSidhe),
                    typeof(EtherealWarrior), typeof(Kirin),
                    typeof(LordOaks), typeof(Pixie),
                    typeof(PixieRenowned), typeof(Silvani),
                    typeof(Treefellow), typeof(Unicorn),
                    typeof(Wisp), typeof(MLDryad),
                    typeof(Satyr), typeof(Changeling),
                    typeof(InsaneDryad), typeof(CorporealBrume),
                    typeof(CrystalLatticeSeeker), typeof(LadyMelisande),
                    typeof(DreadHorn), typeof(Travesty),
                    typeof(ShimmeringEffusion), typeof(Guile),
                    typeof(Irk), typeof(DarkWisp),
                    typeof(FeralTreefellow)
                );

            fey.Entries = new SlayerEntry[0];

            elemental.Opposition = new[]
                {
                    abyss
                };

            elemental.FoundOn = new[]
                {
                    typeof(Balron),     typeof(Daemon),
                    typeof(Putrefier),  typeof(FireDaemonRenowned)
                };

            elemental.Super = new SlayerEntry
                (
                    SlayerName.ElementalBan,

                    typeof(LavaElemental), typeof(ToxicElemental),
                    typeof(AcidElemental), typeof(AcidElementalRenowned),
                    typeof(FireElementalRenowned), typeof(AgapiteElemental),
                    typeof(AirElemental), typeof(SummonedAirElemental),
                    typeof(BloodElemental), typeof(BronzeElemental),
                    typeof(CopperElemental), typeof(CrystalElemental),
                    typeof(DullCopperElemental), typeof(EarthElemental),
                    typeof(SummonedEarthElemental), typeof(Efreet),
                    typeof(FireElemental), typeof(SummonedFireElemental),
                    typeof(GoldenElemental), typeof(IceElemental),
                    typeof(KazeKemono), typeof(PoisonElemental),
                    typeof(RaiJu), typeof(SandVortex),
                    typeof(ShadowIronElemental), typeof(SnowElemental),
                    typeof(ValoriteElemental), typeof(VeriteElemental),
                    typeof(WaterElemental), typeof(SummonedWaterElemental),
                    typeof(Flurry), typeof(Mistral),
                    typeof(Tempest), typeof(UnboundEnergyVortex),
                    typeof(ChaosVortex), typeof(WindElemental),
                    typeof(FlameElemental), typeof(QuartzElemental),
                    typeof(VoidManifestation), typeof(DemonKnight),
                    typeof(CovetousEarthElemental), typeof(VenomElemental),
                    typeof(SearingElemental), typeof(VortexElemental),
                    typeof(CovetousWaterElemental)
                );

            elemental.Entries = new[]
                {
                    new SlayerEntry
                        (
                            SlayerName.BloodDrinking,

                            typeof(BloodElemental),     typeof(DemonKnight)
                        ),

                    new SlayerEntry
                        (
                            SlayerName.EarthShatter,

                            typeof(AgapiteElemental),   typeof(BronzeElemental),
                            typeof(CopperElemental),    typeof(DullCopperElemental),
                            typeof(EarthElemental),     typeof(SummonedEarthElemental),
                            typeof(GoldenElemental),    typeof(ShadowIronElemental),
                            typeof(ValoriteElemental),  typeof(VeriteElemental),
                            typeof(QuartzElemental),    typeof(DemonKnight),
                            typeof(CovetousEarthElemental)
                        ),

                    new SlayerEntry
                        (
                            SlayerName.ElementalHealth,

                            typeof(PoisonElemental),    typeof(DemonKnight),
                            typeof(VenomElemental)
                        ),

                    new SlayerEntry
                        (
                            SlayerName.FlameDousing,

                            typeof(FireElemental),          typeof(FireElementalRenowned),
                            typeof(SummonedFireElemental),  typeof(FlameElemental),
                            typeof(DemonKnight),            typeof(SearingElemental)
                        ),

                    new SlayerEntry
                        (
                            SlayerName.SummerWind,

                            typeof(SnowElemental),  typeof(IceElemental),
                            typeof(DemonKnight)
                        ),

                    new SlayerEntry
                        (
                            SlayerName.Vacuum,

                            typeof(AirElemental),   typeof(SummonedAirElemental),
                            typeof(Flurry),         typeof(Mistral),
                            typeof(Tempest),        typeof(UnboundEnergyVortex),
                            typeof(ChaosVortex),    typeof(WindElemental),
                            typeof(DemonKnight),    typeof(VortexElemental)
                        ),

                    new SlayerEntry
                        (
                            SlayerName.WaterDissipation,

                            typeof(WaterElemental),     typeof(SummonedWaterElemental),
                            typeof(DemonKnight),        typeof(CovetousWaterElemental)
                        )
                };

            abyss.Opposition = new[]
                {
                    elemental,
                    fey
                };

            abyss.FoundOn = new[]
                {
                    typeof(BloodElemental)
                };

            abyss.Super = new SlayerEntry
                (
                    SlayerName.Exorcism,

                    typeof(DevourerRenowned), typeof(FireDaemonRenowned),
                    typeof(AbysmalHorror), typeof(AbyssalInfernal),
                    typeof(ArcaneDaemon), typeof(Balron),
                    typeof(BoneDemon), typeof(ChaosDaemon),
                    typeof(Daemon), typeof(SummonedDaemon),
                    typeof(DemonKnight), typeof(Devourer),
                    typeof(EnslavedGargoyle), typeof(FanDancer),
                    typeof(FireGargoyle), typeof(Gargoyle),
                    typeof(GargoyleDestroyer), typeof(GargoyleEnforcer),
                    typeof(Gibberling), typeof(HordeMinion),
                    typeof(FireDaemon), typeof(IceFiend),
                    typeof(Imp), typeof(Impaler),
                    typeof(Moloch), typeof(Oni),
                    typeof(Ravager), typeof(Semidar),
                    typeof(StoneGargoyle), typeof(Succubus),
                    typeof(PatchworkSkeleton), typeof(TsukiWolf),
                    typeof(Szavetra), typeof(CrystalDaemon),
                    typeof(SlasherOfVeils), typeof(GargoyleShade),
                    typeof(Putrefier), typeof(ChiefParoxysmus),
                    typeof(Anzuanord), typeof(Ballem),
                    typeof(Betballem), typeof(SkeletalLich),
                    typeof(UsagralemBallem), typeof(EffetePutridGargoyle),
                    typeof(EffeteUndeadGargoyle), typeof(PitFiend),
                    typeof(ArchDaemon), typeof(AbyssalAbomination),
                    typeof(Virtuebane), typeof(LesserOni),
                    typeof(Lifestealer)
                );

            abyss.Entries = new[]
            {
                new SlayerEntry
                        (
                            SlayerName.GargoylesFoe,

                            typeof(EnslavedGargoyle),       typeof(FireGargoyle),
                            typeof(Gargoyle),               typeof(GargoyleDestroyer),
                            typeof(GargoyleEnforcer),       typeof(StoneGargoyle),
                            typeof(GargoyleShade),          typeof(EffetePutridGargoyle),
                            typeof(EffeteUndeadGargoyle),   typeof(DaemonMongbat),
                            typeof(CovetousDoppleganger),   typeof(CovetousFireDaemon),
                            typeof(GargoyleAssassin),       typeof(LesserOni)
                        )
            };

            arachnid.Opposition = new[]
                {
                    reptilian
                };

            arachnid.FoundOn = new[]
                {
                    typeof(AncientWyrm),    typeof(GreaterDragon),
                    typeof(Dragon),         typeof(OphidianMatriarch),
                    typeof(ShadowWyrm)
                };

            arachnid.Super = new SlayerEntry
                (
                    SlayerName.ArachnidDoom,

                    typeof(DreadSpider), typeof(FrostSpider),
                    typeof(GiantBlackWidow), typeof(GiantSpider),
                    typeof(Mephitis), typeof(Scorpion),
                    typeof(TerathanAvenger), typeof(TerathanDrone),
                    typeof(TerathanMatriarch), typeof(TerathanWarrior),
                    typeof(Miasma), typeof(SpeckledScorpion),
                    typeof(LadyLissith), typeof(LadySabrix),
                    typeof(Virulent), typeof(Silk),
                    typeof(Malefic), typeof(Navrey),
                    typeof(SentinelSpider), typeof(WolfSpider),
                    typeof(TrapdoorSpider), typeof(Anlorzen),
                    typeof(Anlorlem)
                );

            arachnid.Entries = new[]
            {
                new SlayerEntry
                    (
                        SlayerName.ScorpionsBane,

                        typeof(Scorpion),           typeof(Miasma),
                        typeof(SpeckledScorpion), typeof(DesertScorpion)
                    ),

                new SlayerEntry
                    (
                        SlayerName.SpidersDeath,

                        typeof(DreadSpider),        typeof(FrostSpider),
                        typeof(GiantBlackWidow),    typeof(GiantSpider),
                        typeof(Mephitis),           typeof(LadyLissith),
                        typeof(LadySabrix),         typeof(Virulent),
                        typeof(Silk),               typeof(Malefic),
                        typeof(Navrey),             typeof(SentinelSpider),
                        typeof(WolfSpider),         typeof(TrapdoorSpider),
                        typeof(Anlorzen)
                    ),

                new SlayerEntry
                    (
                        SlayerName.Terathan,

                        typeof(TerathanAvenger),    typeof(TerathanDrone),
                        typeof(TerathanMatriarch),  typeof(TerathanWarrior),
                        typeof(Anlorlem)
                    )
            };

            reptilian.Opposition = new[]
                {
                    arachnid
                };

            reptilian.FoundOn = new[]
                {
                    typeof(TerathanAvenger),    typeof(TerathanMatriarch)
                };

            reptilian.Super = new SlayerEntry
                (
                    SlayerName.ReptilianDeath,

                    typeof(Rikktor), typeof(Serado),
                    typeof(SkeletalDragonRenowned), typeof(WyvernRenowned),
                    typeof(AncientWyrm), typeof(DeepSeaSerpent),
                    typeof(GreaterDragon), typeof(Dragon),
                    typeof(Drake), typeof(GiantIceWorm),
                    typeof(IceSerpent), typeof(GiantSerpent),
                    typeof(Hiryu), typeof(IceSnake),
                    typeof(JukaLord), typeof(JukaMage),
                    typeof(JukaWarrior), typeof(LavaSerpent),
                    typeof(LavaSnake), typeof(LesserHiryu),
                    typeof(Lizardman), typeof(LizardmanDefender),
                    typeof(LizardmanSquatter), typeof(OphidianArchmage),
                    typeof(OphidianKnight), typeof(OphidianMage),
                    typeof(OphidianMatriarch), typeof(OphidianWarrior),
                    typeof(Reptalon), typeof(SeaSerpent),
                    typeof(Serado), typeof(SerpentineDragon),
                    typeof(ShadowWyrm), typeof(SilverSerpent),
                    typeof(SkeletalDragon), typeof(Snake),
                    typeof(SwampDragon), typeof(WhiteWyrm),
                    typeof(Wyvern), typeof(Yamandon),
                    typeof(Hydra), typeof(CrystalHydra),
                    typeof(CrystalSeaSerpent), typeof(Rend),
                    typeof(Thrasher), typeof(Abscess),
                    typeof(Grim), typeof(ChickenLizard),
                    typeof(StygianDragon), typeof(FairyDragon),
                    typeof(Skree), typeof(Slith),
                    typeof(StoneSlith), typeof(ToxicSlith),
                    typeof(Raptor), typeof(Kepetch),
                    typeof(KepetchAmbusher), typeof(FrostDragon),
                    typeof(ColdDrake), typeof(FrostDrake), typeof(Coil),
                    typeof(SkeletalDrake), typeof(CoralSnake)
                );

            reptilian.Entries = new[]
            {
                new SlayerEntry
                    (
                        SlayerName.DragonSlaying,

                        typeof(Rikktor), typeof(SkeletalDragonRenowned),
                        typeof(WyvernRenowned),     typeof(AncientWyrm),
                        typeof(GreaterDragon),      typeof(Dragon),
                        typeof(Drake),              typeof(Hiryu),
                        typeof(LesserHiryu),        typeof(Reptalon),
                        typeof(SerpentineDragon),   typeof(ShadowWyrm),
                        typeof(SkeletalDragon),     typeof(SwampDragon),
                        typeof(WhiteWyrm),          typeof(Wyvern),
                        typeof(Hydra),              typeof(CrystalHydra),
                        typeof(Rend),               typeof(Abscess),
                        typeof(Grim),               typeof(StygianDragon),
                        typeof(FairyDragon),        typeof(SkeletalDrake),
                        typeof(ColdDrake)
                    ),

                new SlayerEntry
                    (
                        SlayerName.LizardmanSlaughter,

                        typeof(Lizardman), typeof(LizardmanDefender),
                        typeof(LizardmanSquatter) 
                    ),

                new SlayerEntry
                    (
                        SlayerName.Ophidian,

                        typeof(OphidianArchmage),   typeof(OphidianKnight),
                        typeof(OphidianMage),       typeof(OphidianMatriarch),
                        typeof(OphidianWarrior)
                    ),

                new SlayerEntry
                    (
                        SlayerName.SnakesBane,

                        typeof(CrystalSeaSerpent),  typeof(Coil),
                        typeof(CoralSnake),         typeof(DeepSeaSerpent),
                        typeof(GiantIceWorm),       typeof(GiantSerpent),
                        typeof(IceSerpent),         typeof(IceSnake),
                        typeof(LavaSerpent),        typeof(LavaSnake),
                        typeof(SeaSerpent),         typeof(Serado),
                        typeof(SilverSerpent),      typeof(Snake),
                        typeof(Yamandon)
                    )
            };

            eodon.Opposition = new SlayerGroup[] { };
            eodon.FoundOn = new Type[] { };
            eodon.Super =
                new SlayerEntry(

                    SlayerName.Eodon,

                    typeof(Dimetrosaur), typeof(Gallusaurus),
                    typeof(Archaeosaurus), typeof(Najasaurus),
                    typeof(Saurosaurus), typeof(Allosaurus),
                    typeof(MyrmidexLarvae), typeof(MyrmidexDrone),
                    typeof(MyrmidexWarrior), typeof(DragonTurtle),
                    typeof(DragonTurtleHatchling), typeof(DesertScorpion),
                    typeof(TribeWarrior), typeof(TribeShaman),
                    typeof(TribeChieftan), typeof(WildTiger),
                    typeof(WildBlackTiger), typeof(WildWhiteTiger),
                    typeof(TRex), typeof(SilverbackGorilla));

            eodon.Entries = new SlayerEntry[] { };

            eodonTribe.Opposition = new SlayerGroup[] { };
            eodonTribe.FoundOn = new Type[] { };
            eodonTribe.Super = new SlayerEntry(SlayerName.EodonTribe, typeof(TribeWarrior), typeof(TribeShaman), typeof(TribeChieftan));
            eodonTribe.Entries = new SlayerEntry[] { };

            dino.Opposition = new[] { fey };
            dino.FoundOn = new Type[] { };
            dino.Super =
                new SlayerEntry(

                    SlayerName.Dinosaur,

                    typeof(Dimetrosaur), typeof(Gallusaurus),
                    typeof(Archaeosaurus), typeof(Najasaurus),
                    typeof(Saurosaurus), typeof(Allosaurus),
                    typeof(MyrmidexLarvae), typeof(MyrmidexDrone),
                    typeof(TRex), typeof(MyrmidexWarrior));

            dino.Entries = new SlayerEntry[] { };

            myrmidex.Opposition = new[] { fey };
            myrmidex.FoundOn = new Type[] { };
            myrmidex.Super = new SlayerEntry(

                SlayerName.Myrmidex,

                typeof(MyrmidexLarvae), typeof(MyrmidexDrone),
                typeof(MyrmidexWarrior));
            myrmidex.Entries = new SlayerEntry[] { };

            m_Groups = new[]
                {
                    humanoid,
                    undead,
                    elemental,
                    abyss,
                    arachnid,
                    reptilian,
                    fey,
                    eodon,
                    eodonTribe,
                    dino,
                    myrmidex
                };

            m_TotalEntries = CompileEntries(m_Groups);
        }

        public static SlayerEntry[] TotalEntries => m_TotalEntries;

        public static SlayerGroup[] Groups => m_Groups;

        public SlayerGroup[] Opposition
        {
            get => m_Opposition;
            set => m_Opposition = value;
        }
        public SlayerEntry Super
        {
            get => m_Super;
            set => m_Super = value;
        }
        public SlayerEntry[] Entries
        {
            get => m_Entries;
            set => m_Entries = value;
        }
        public Type[] FoundOn
        {
            get => m_FoundOn;
            set => m_FoundOn = value;
        }
        public static SlayerEntry GetEntryByName(SlayerName name)
        {
            int v = (int)name;

            if (v >= 0 && v < m_TotalEntries.Length)
                return m_TotalEntries[v];

            return null;
        }

        public static SlayerName GetLootSlayerType(Type type)
        {
            for (int i = 0; i < m_Groups.Length; ++i)
            {
                SlayerGroup group = m_Groups[i];
                Type[] foundOn = group.FoundOn;

                bool inGroup = false;

                for (int j = 0; foundOn != null && !inGroup && j < foundOn.Length; ++j)
                    inGroup = foundOn[j] == type;

                if (inGroup)
                {
                    int index = Utility.Random(1 + group.Entries.Length);

                    if (index == 0)
                        return group.m_Super.Name;

                    return group.Entries[index - 1].Name;
                }
            }

            return SlayerName.Silver;
        }

        public bool OppositionSuperSlays(Mobile m)
        {
            for (int i = 0; i < Opposition.Length; i++)
            {
                if (Opposition[i].Super.Slays(m))
                    return true;
            }

            if (m_Super.Name == SlayerName.Eodon && !m_Super.Slays(m))
                return true;

            return false;
        }

        private static SlayerEntry[] CompileEntries(IReadOnlyList<SlayerGroup> groups)
        {
            SlayerEntry[] entries = new SlayerEntry[32];

            for (int i = 0; i < groups.Count; ++i)
            {
                SlayerGroup g = groups[i];

                g.Super.Group = g;

                entries[(int)g.Super.Name] = g.Super;

                for (int j = 0; j < g.Entries.Length; ++j)
                {
                    g.Entries[j].Group = g;
                    entries[(int)g.Entries[j].Name] = g.Entries[j];
                }
            }

            return entries;
        }

        public static SlayerName RandomSuperSlayerAOS(bool excludeFey = true)
        {
            int maxIndex = excludeFey ? 5 : 6;

            return Groups[Utility.Random(maxIndex)].Super.Name;
        }

        public static SlayerName RandomSuperSlayerTOL()
        {
            return Groups[Utility.Random(Groups.Length)].Super.Name;
        }
    }
}
