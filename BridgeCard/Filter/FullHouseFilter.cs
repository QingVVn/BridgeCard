using System.Collections.Generic;
using System.Linq;

namespace BridgeCard
{
    public class FullHouseFilter:Filter
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
            if (cards.Count(x=>x.Number==compareData.Data.First())==2)
            {
                compareData.Data.Reverse();
            }
            compareData.BridgeTypeDetail = BridgeType.FullHouse;
            return compareData;
        }

        
        protected override bool Verify(List<BridgeData> cards)
        {
            var group =  cards.GroupBy(x => x.Number).ToList();
            return group.Any(x => x.Count() == 3) && group.Any(x => x.Count() == 2);
        }
    }
}