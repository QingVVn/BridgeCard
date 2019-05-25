using System.Collections.Generic;
using System.Linq;

namespace BridgeCard
{
    public class TwoPairsFilter:Filter
    {
        protected override compareData Results(List<BridgeData> cards)
        {
            var compareData = new compareData();
            var group =  cards.GroupBy(x => x.Number).OrderByDescending(x=>x.Key).ToList();
            compareData.Data.Add(group.First(x=>x.Count()==2).Key);
            compareData.Data.Add(group.Last(x=>x.Count()==2).Key);
            compareData.Data.Add(group.First(x=>x.Count()==1).Key);
            compareData.BridgeTypeDetail = BridgeType.TwoPairs;
            return compareData;
        }

        
        protected override bool Verify(List<BridgeData> cards)
        {
            var group =  cards.GroupBy(x => x.Number).ToList();
            return group.Select(x => x.Count() == 2).Count() == 2;
        }
    }
}