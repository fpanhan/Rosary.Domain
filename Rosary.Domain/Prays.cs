namespace Rosary.Domain.Prays
{
    using AbstractClasses;
    using System.Globalization;
    using System.Resources;

    public class SignOfTheCross : Pray
    {
        public SignOfTheCross(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);

            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);

        public override void SetPrayName(string name)
        {
            SetName(name);
        }
    }

    public class HailMary : Pray
    {
        public HailMary(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class OurFather : Pray
    {
        public OurFather(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class ApostlesCreed : Pray
    {
        public ApostlesCreed(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class GloryBe : Pray
    {
        public GloryBe(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class HailHolyQueen : Pray
    {
        public HailHolyQueen(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class FatimaPrayer : Pray
    {
        public FatimaPrayer(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class ShortPrayer : Pray
    {
        public ShortPrayer(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class Gratitude : Pray
    {
        public Gratitude(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class EternalFather : Pray
    {
        public EternalFather(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);

            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class DivineMercy : Pray
    {
        public DivineMercy(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    public class HolyGod : Pray
    {
        public HolyGod(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetPrayId(GetType().Name);
            var resourceManager = new ResourceManager("Rosary.Domain.Resources.PrayResource", typeof(Pray).Assembly);


            SetPrayName(resourceManager.GetString(Id + "PrayName", cultureInfo));
            SetPrayDescription(resourceManager.GetString(Id + "PrayDescription", cultureInfo));
        }

        public override void SetPrayId(string id)
        {
            SetId(GetType().Name);
        }

        public override void SetPrayName(string name)
        {
            SetName(name);
        }

        public override void SetPrayDescription(string description)
        {
            SetDescription(description);
        }

        public override Pray SetPrayLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }
}
