using System;
using System.Linq;

namespace Works4me.Xurrent.GraphQL.Tests.Extensions
{
    internal static class ReadOnlyDataCollectionExtensions
    {
        private static readonly Random _random = new();

        public static T GetRandomItem<T>(this ReadOnlyDataCollection<T> collection)
            where T : IDataItem
        {
            int randomIndex = _random.Next(collection.Count);
            return collection.Skip(randomIndex).First();
        }
    }
}
