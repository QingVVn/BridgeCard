using System.Collections.Generic;
using System.Linq;

namespace BridgeCard
{
    public class ThreeKindFilter:Filter
    {
        protected override compareData Results(List<BridgeData> cards)
        {
            var compareData = new compareData();
            var group =  cards.GroupBy(x => x.Number).OrderByDescending(x=>x.Key);
            compareData.Data.Add(group.First(x=>x.Count()==3).Key);
            cards.ForEach(x =>
            {
                if (cards.Count(y=>y.Number==x.Number)!=3)
                {
                    compareData.Data.Add(x.Number);
                }
            });
            compareData.BridgeTypeDetail = BridgeType.ThreeKind;
            return compareData;
        }

        
        protected override bool Verify(List<BridgeData> cards)
        {
            var group =  cards.GroupBy(x => x.Number).ToList();
            return group.Any(x => x.Count() == 3);
        }
    }
}