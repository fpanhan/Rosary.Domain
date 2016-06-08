namespace Rosary.Domain.Chaplets
{
    using AbstractClasses;
    using Decades;
    using Enum;
    using System.ComponentModel;
    using System.Globalization;

    [Description("Rosary Of Hail Mary Complete"), Category("Chaplet")]
    public class RosaryOfHailMary : Chaplet
    {
        public RosaryOfHailMary(RosaryPrayType rosaryType, CultureInfo cultureInfo) : base(rosaryType, cultureInfo)
        {
        }

        public override void CreateDecades()
        {
            Decades.Add(new Beginning(Language));
            Decades.Add(new FirstMysteryOfJoyful(Language));
            Decades.Add(new SecondMysteryOfJoyful(Language));
            Decades.Add(new ThirdMysteryOfJoyful(Language));
            Decades.Add(new FourthMysteryOfJoyful(Language));
            Decades.Add(new FifthMysteryOfJoyful(Language));
            Decades.Add(new FirstMysteryOfLuminous(Language));
            Decades.Add(new SecondMysteryOfLuminous(Language));
            Decades.Add(new ThirdMysteryOfLuminous(Language));
            Decades.Add(new FourthMysteryOfLuminous(Language));
            Decades.Add(new FifthMysteryOfLuminous(Language));
            Decades.Add(new FirstMysteryOfSorrowful(Language));
            Decades.Add(new SecondMysteryOfSorrowful(Language));
            Decades.Add(new ThirdMysteryOfSorrowful(Language));
            Decades.Add(new FourthMysteryOfSorrowful(Language));
            Decades.Add(new FifthMysteryOfSorrowful(Language));
            Decades.Add(new FirstMysteryOfGlorious(Language));
            Decades.Add(new SecondMysteryOfGlorious(Language));
            Decades.Add(new ThirdMysteryOfGlorious(Language));
            Decades.Add(new FourthMysteryOfGlorious(Language));
            Decades.Add(new FifthMysteryOfGlorious(Language));
            Decades.Add(new Ending(Language));
        }

        public override Chaplet SetChapletLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    [Description("Chaplet Of Joyful"), Category("Chaplet")]
    public class ChapletOfJoyful : Chaplet
    {
        public ChapletOfJoyful(RosaryPrayType rosaryType, CultureInfo cultureInfo) : base(rosaryType, cultureInfo)
        {
        }

        public override void CreateDecades()
        {
            Decades.Add(new Beginning(Language));
            Decades.Add(new FirstMysteryOfJoyful(Language));
            Decades.Add(new SecondMysteryOfJoyful(Language));
            Decades.Add(new ThirdMysteryOfJoyful(Language));
            Decades.Add(new FourthMysteryOfJoyful(Language));
            Decades.Add(new FifthMysteryOfJoyful(Language));
            Decades.Add(new Ending(Language));
        }

        public override Chaplet SetChapletLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    [Description("Chaplet Of Luminous"), Category("Chaplet")]
    public class ChapletOfLuminous : Chaplet
    {
        public ChapletOfLuminous(RosaryPrayType rosaryType, CultureInfo cultureInfo) : base(rosaryType, cultureInfo)
        {
        }

        public override void CreateDecades()
        {
            Decades.Add(new Beginning(Language));
            Decades.Add(new FirstMysteryOfLuminous(Language));
            Decades.Add(new SecondMysteryOfLuminous(Language));
            Decades.Add(new ThirdMysteryOfLuminous(Language));
            Decades.Add(new FourthMysteryOfLuminous(Language));
            Decades.Add(new FifthMysteryOfLuminous(Language));
            Decades.Add(new Ending(Language));
        }

        public override Chaplet SetChapletLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    [Description("Chaplet Of Sorrowful"), Category("Chaplet")]
    public class ChapletOfSorrowful : Chaplet
    {
        public ChapletOfSorrowful(RosaryPrayType rosaryType, CultureInfo cultureInfo) : base(rosaryType, cultureInfo)
        {
        }

        public override void CreateDecades()
        {
            Decades.Add(new Beginning(Language));
            Decades.Add(new FirstMysteryOfSorrowful(Language));
            Decades.Add(new SecondMysteryOfSorrowful(Language));
            Decades.Add(new ThirdMysteryOfSorrowful(Language));
            Decades.Add(new FourthMysteryOfSorrowful(Language));
            Decades.Add(new FifthMysteryOfSorrowful(Language));
            Decades.Add(new Ending(Language));
        }

        public override Chaplet SetChapletLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    [Description("Chaplet Of Glorious"), Category("Chaplet")]
    public class ChapletOfGlorious : Chaplet
    {
        public ChapletOfGlorious(RosaryPrayType rosaryType, CultureInfo cultureInfo) : base(rosaryType, cultureInfo)
        {
        }

        public override void CreateDecades()
        {
            Decades.Add(new Beginning(Language));
            Decades.Add(new FirstMysteryOfGlorious(Language));
            Decades.Add(new SecondMysteryOfGlorious(Language));
            Decades.Add(new ThirdMysteryOfGlorious(Language));
            Decades.Add(new FourthMysteryOfGlorious(Language));
            Decades.Add(new FifthMysteryOfGlorious(Language));
            Decades.Add(new Ending(Language));
        }

        public override Chaplet SetChapletLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }

    [Description("Rosary Of Divine Mercy"), Category("Chaplet")]
    public class RosaryOfDivineMercy : Chaplet
    {
        public RosaryOfDivineMercy(RosaryPrayType rosaryType, CultureInfo cultureInfo) : base(rosaryType, cultureInfo)
        {
        }

        public override void CreateDecades()
        {
            Decades.Add(new BeginningDivineMercy(Language));
            Decades.Add(new MysterysDivineMercy(Language));
            Decades.Add(new EndingDivineMercy(Language));
        }

        public override Chaplet SetChapletLanguage(CultureInfo cultureInfo) => SetLanguage(cultureInfo);
    }
}
