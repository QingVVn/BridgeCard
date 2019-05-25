using System.ComponentModel;

namespace BridgeCard
{
    public enum BridgeType
    {
        [Description("同花顺")]
        StraightFlush = 9,
        [Description("铁支")]
        FourKind = 8,
        [Description("葫芦")]
        FullHouse = 7,
        [Description("同花")]
        Flush = 6,
        [Description("顺子")]
        Straight = 5,
        [Description("三条")]
        ThreeKind = 4,
        [Description("两对")]
        TwoPairs = 3,
        [Description("对子")]
        OnePair = 2,
        [Description("散牌")]
        HighCard = 1,
    }
}