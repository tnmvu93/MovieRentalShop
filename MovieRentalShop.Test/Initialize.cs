using Effort.DataLoaders;
using System;

namespace MovieRentalShop.Test
{
    public static class Initialize
    {
        public static readonly CachingDataLoader DataLoader;

        static Initialize()
        {
            if (DataLoader == null)
            {
                var wrappedDataLoader = new CsvDataLoader(AppDomain.CurrentDomain.BaseDirectory + @"Data");
                DataLoader = new CachingDataLoader(wrappedDataLoader, false);
            }
        }
    }
}
