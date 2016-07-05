namespace Rosary.Domain.Decades
{
    using AbstractClasses;
    using Prays;
    using System.Globalization;
    using System.Resources;


    public class BeginningDivineMercy : Decade
    {
        public BeginningDivineMercy(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Pray).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new SignOfTheCross(Language));
            Prays.Add(new OurFather(Language));
            Prays.Add(new HailMary(Language));
            Prays.Add(new ApostlesCreed(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class EndingDivineMercy : Decade
    {
        public EndingDivineMercy(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Pray).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new HolyGod(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class MysterysDivineMercy : Decade
    {
        public MysterysDivineMercy(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Pray).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            for (int i = 0; i < 5; i++)
            {
                Prays.Add(new EternalFather(Language));
                for (int e = 0; e < 10; e++)
                {
                    Prays.Add(new DivineMercy(Language));
                }
            }
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class Beginning : Decade
    {
        public Beginning(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            //var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Pray).Assembly);

            //SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            //SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new SignOfTheCross(Language));
            Prays.Add(new ApostlesCreed(Language));
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 3; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class Ending : Decade
    {
        public Ending(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            //var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Pray).Assembly);

            //SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            //SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new Gratitude(Language));
            Prays.Add(new HailHolyQueen(Language));
            Prays.Add(new SignOfTheCross(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FirstMysteryOfJoyful : Decade
    {
        public FirstMysteryOfJoyful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class SecondMysteryOfJoyful : Decade
    {
        public SecondMysteryOfJoyful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class ThirdMysteryOfJoyful : Decade
    {
        public ThirdMysteryOfJoyful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }
    public class FourthMysteryOfJoyful : Decade
    {
        public FourthMysteryOfJoyful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FifthMysteryOfJoyful : Decade
    {
        public FifthMysteryOfJoyful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FirstMysteryOfLuminous : Decade
    {
        public FirstMysteryOfLuminous(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class SecondMysteryOfLuminous : Decade
    {
        public SecondMysteryOfLuminous(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class ThirdMysteryOfLuminous : Decade
    {
        public ThirdMysteryOfLuminous(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }
    public class FourthMysteryOfLuminous : Decade
    {
        public FourthMysteryOfLuminous(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FifthMysteryOfLuminous : Decade
    {
        public FifthMysteryOfLuminous(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FirstMysteryOfSorrowful : Decade
    {
        public FirstMysteryOfSorrowful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class SecondMysteryOfSorrowful : Decade
    {
        public SecondMysteryOfSorrowful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class ThirdMysteryOfSorrowful : Decade
    {
        public ThirdMysteryOfSorrowful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }
    public class FourthMysteryOfSorrowful : Decade
    {
        public FourthMysteryOfSorrowful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FifthMysteryOfSorrowful : Decade
    {
        public FifthMysteryOfSorrowful(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FirstMysteryOfGlorious : Decade
    {
        public FirstMysteryOfGlorious(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class SecondMysteryOfGlorious : Decade
    {
        public SecondMysteryOfGlorious(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class ThirdMysteryOfGlorious : Decade
    {
        public ThirdMysteryOfGlorious(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }
    public class FourthMysteryOfGlorious : Decade
    {
        public FourthMysteryOfGlorious(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FifthMysteryOfGlorious : Decade
    {
        public FifthMysteryOfGlorious(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetDecadeId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.DecadesResource", typeof(Decade).Assembly);

            SetDecadeName(resourceManager.GetString(Id + "DecadeName", cultureInfo));
            SetDecadeDescription(resourceManager.GetString(Id + "DecadeDescription", cultureInfo));
        }

        public override void CreatePrays()
        {
            Prays.Add(new OurFather(Language));
            for (int i = 0; i < 10; i++)
            {
                Prays.Add(new HailMary(Language));
            }
            Prays.Add(new GloryBe(Language));
            Prays.Add(new ShortPrayer(Language));
        }

        public override void SetDecadeId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetDecadeName(string name)
        {
            SetName(name);
        }

        public override void SetDecadeDescription(string description)
        {
            SetDescription(description);
        }

        public override Decade SetDecadeLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }
}
