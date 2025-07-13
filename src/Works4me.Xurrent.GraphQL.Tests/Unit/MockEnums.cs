using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Tests.Unit
{
    public enum MockCiStatus
    {
        [XurrentEnum("in_stock")]
        InStock,

        [XurrentEnum("in_production")]
        InProduction
    }
}
