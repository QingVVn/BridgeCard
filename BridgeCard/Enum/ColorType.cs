using System.ComponentModel;

namespace BridgeCard
{
    public enum ColorType
    {
        [Description("方片")]
        D = 0, 
        [Description("黑桃")]
        S = 1,
        [Description("红桃")]
        H = 2,
        [Description("梅花")]
        C = 3
    }
}