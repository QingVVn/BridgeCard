using System.Collections.Generic;

namespace BridgeCard
{
    public abstract class Filter
    {
        private Filter _nextFilter;

        public compareData GetCompareData(List<BridgeData> cards) {
            return Verify(cards) ? Results(cards) : _nextFilter.GetCompareData(cards);
        }
        
        protected abstract compareData Results(List<BridgeData> cards);

        protected abstract bool Verify(List<BridgeData> cards);

        public void SetNextFilter(Filter nextFilter)
        {
            this._nextFilter = nextFilter;
        }
    }
}