using System.Collections.Generic;
using System.Linq;

namespace BridgeCard
{
    public class StraightFlushFilter: Filter
    {
        protected override compareData Results(List<BridgeData> cards)
        {
            var compareData = new compareData();
            cards.ForEach(x =>
            {
                if (!compareData.Data.Contains(x.Number))
                {
                    compareData.Data.Add(x.Number);
                }
            });

            compareData.Data.Sort((x, y) => -x.CompareTo(y));
            compareData.BridgeTypeDetail = BridgeType.StraightFlush;
            return compareData;
        }

        
        protected override bool Verify(List<BridgeData> cards)
        {
            var colorCount = cards.GroupBy(x => x.Color).Count();
            var numberCount = cards.GroupBy(x => x.Number).Count();
            return colorCount == 1 && numberCount == 5 && cards.Last().Number - cards.First().Number == 4;
        }
    }
}