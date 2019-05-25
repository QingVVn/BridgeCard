using System.Collections.Generic;

namespace BridgeCard
{
    public class compareData
    {
        public BridgeType BridgeTypeDetail { get; set; }
        public List<int> Data { get;}

        public compareData()
        {
            Data = new List<int>();
        }
    }
}