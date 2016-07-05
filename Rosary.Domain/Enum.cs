namespace Rosary.Domain.Enum
{
    using System.ComponentModel;


    public enum RosaryPrayType
    {
        [Description("Rosário de Nossa Senhora")]
        RosaryOfOurLadyComplete,
        [Description("Mistérios Gozosos")]
        RosaryOfOurLadyJoyful,
        [Description("Mistérios Dolorosos")]
        RosaryOfOurLadySorrowful,
        [Description("Mistérios Gloriosos")]
        RosaryOfOurLadyGlorious,
        [Description("Mistérios Luminosos")]
        RosaryOfOurLadyLight,
        [Description("Rosário da Divina Misericórdia")]
        RosaryOfDivineMercy
    }
}
