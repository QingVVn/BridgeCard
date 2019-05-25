using System.Collections.Generic;
using System.Linq;

namespace BridgeCard
{
    public class HighCardFilter:Filter
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
            compareData.BridgeTypeDetail = BridgeType.HighCard;
            return compareData;
        }

        
        protected override bool Verify(List<BridgeData> cards)
        {
            return true;
        }
    }
}