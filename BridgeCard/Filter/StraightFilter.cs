using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeCard
{
    public class StraightFilter:Filter
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
            compareData.BridgeTypeDetail = BridgeType.Straight;
            return compareData;
        }

        
        protected override bool Verify(List<BridgeData> cards)
        {
            var numberCount = cards.GroupBy(x => x.Number).Count();
            return numberCount == 5 && cards.Last().Number - cards.First().Number == 4;
        }
    }
}