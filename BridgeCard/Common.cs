using System;
using System.Collections.Generic;

namespace BridgeCard
{
    public class Common
    {
        private string BlackCards { get; }
        private string WhiteCards { get; }

        public Common(string blackCards, string whiteCards)
        {
            BlackCards = blackCards;
            WhiteCards = whiteCards;
        }
        
        public string GetResult()
        {
            Filter straightFlush = Init();
            var black  = straightFlush.GetCompareData(GenerateData(BlackCards));
            var white  = straightFlush.GetCompareData(GenerateData(WhiteCards));
            if (black.BridgeTypeDetail > white.BridgeTypeDetail)
            {
                return $"{ResultDetail.BlackWin} - {black.BridgeTypeDetail}";
            }
            if (black.BridgeTypeDetail < white.BridgeTypeDetail)
            {
                return $"{ResultDetail.WhiteWin} - {white.BridgeTypeDetail}";
            }
            return Compare(black.Data, white.Data, black.BridgeTypeDetail.ToString());
        }
        
        private List<BridgeData> GenerateData(string cards)
        {
            var data = new List<BridgeData>();
            foreach (var card in cards.Split(' '))
            {
                var bridgeType = new BridgeData();
                bridgeType.Number = (int) Enum.Parse(typeof(NumberType), card[0].ToString());
                bridgeType.Color = card[1].ToString();

                data.Add(bridgeType);
            }
            return data;
        }
        
        private string Compare(List<int>blackData, List<int> whiteData, string type)
        {
            for (int i = 0; i < blackData.Count; i++)
            {
                if (blackData[i] > whiteData[i])
                {
                    return $"{ResultDetail.BlackWin} - {type}";
                }
                if (blackData[i] < whiteData[i])
                {
                    return $"{ResultDetail.WhiteWin} - {type}";
                }
                if (i == blackData.Count - 1)
                {
                    return $"{ResultDetail.Tie}";
                }
            }

            return string.Empty;
        }
        
        private Filter Init()
        {
            Filter straightFlush = new StraightFlushFilter();
            Filter fourKindFilter = new FourKindFilter();
            Filter fullHouseFilter = new FullHouseFilter();
            Filter flushFilter = new FlushFilter();
            Filter straightFilter = new StraightFilter();
            Filter threeKindFilter = new ThreeKindFilter();
            Filter twoPairsFilter = new TwoPairsFilter();
            Filter onePairFilter = new OnePairFilter();
            Filter highCardFilter = new HighCardFilter();

            straightFlush.SetNextFilter(fourKindFilter);
            fourKindFilter.SetNextFilter(fullHouseFilter);
            fullHouseFilter.SetNextFilter(flushFilter);
            flushFilter.SetNextFilter(straightFilter);
            straightFilter.SetNextFilter(threeKindFilter);
            threeKindFilter.SetNextFilter(twoPairsFilter);
            twoPairsFilter.SetNextFilter(onePairFilter);
            onePairFilter.SetNextFilter(highCardFilter);

            return straightFlush;
        }
    }
}