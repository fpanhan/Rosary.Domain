namespace Rosary.Domain.AbstractClasses
{
    using Enum;
    using System.Collections.Generic;
    using System.Globalization;

    public abstract class Pray
    {
        protected Pray(CultureInfo cultureInfo) { Language = cultureInfo; }
        public string Description { get; private set; }
        public string Id { get; private set; }
        public CultureInfo Language { get; private set; }
        public string Name { get; private set; }
        public abstract void SetPrayId(string id);
        public abstract void SetPrayName(string name);
        public abstract void SetPrayDescription(string description);
        public abstract Pray SetPrayLanguage(CultureInfo cultureInfo);

        internal void SetId(string id)
        {
            Id = id;
        }

        internal void SetName(string name)
        {
            Name = name;
        }

        internal void SetDescription(string description)
        {
            Description = description;
        }

        internal Pray SetLanguage(CultureInfo cultureInfo)
        {
            Language = cultureInfo;
            return this;
        }
    }

    public abstract class Decade
    {
        protected Decade(CultureInfo cultureInfo)
        {
            Prays = new List<Pray>();
            Language = cultureInfo;
            CreatePrays();
        }
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; set; }
        public CultureInfo Language { get; private set; }
        public List<Pray> Prays { get; private set; }
        public abstract void CreatePrays();
        public abstract void SetDecadeId(string id);
        public abstract void SetDecadeName(string name);
        public abstract void SetDecadeDescription(string description);
        public abstract Decade SetDecadeLanguage(CultureInfo cultureInfo);

        internal void SetId(string id)
        {
            Id = id;
        }

        internal void SetName(string name)
        {
            Name = name;
        }

        internal void SetDescription(string description)
        {
            Description = description;
        }

        internal Decade SetLanguage(CultureInfo cultureInfo)
        {
            Language = cultureInfo;
            return this;
        }
    }

    public abstract class Chaplet
    {
        protected Chaplet(RosaryPrayType rosaryType, CultureInfo cultureInfo)
        {
            Decades = new List<Decade>();
            RosaryPrayType = rosaryType;
            Language = cultureInfo;
            CreateDecades();
        }

        public List<Decade> Decades { get; private set; }
        public CultureInfo Language { get; private set; }
        public RosaryPrayType RosaryPrayType { get; private set; }

        public abstract void CreateDecades();
        public abstract Chaplet SetChapletLanguage(CultureInfo cultureInfo);

        internal Chaplet SetLanguage(CultureInfo cultureInfo)
        {
            Language = cultureInfo;
            return this;
        }
    }
}
