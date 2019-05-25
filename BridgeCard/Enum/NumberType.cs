using System.ComponentModel;

namespace BridgeCard
{
    public enum NumberType
    { 
        [Description("2")]
        B = 2,
        [Description("3")]
        C = 3,
        [Description("4")]
        D = 4,
        [Description("5")]
        E = 5,
        [Description("6")]
        F = 6,
        [Description("7")]
        G = 7,
        [Description("8")]
        H = 8,
        [Description("9")]
        I = 9,
        [Description("T")]
        T = 10,
        [Description("J")]
        J = 11,
        [Description("Q")]
        Q = 12,
        [Description("K")]
        K = 13,
        [Description("A")]
        A = 14
    }
}