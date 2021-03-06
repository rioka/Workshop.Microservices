﻿using System.Data.Entity.Migrations;
using Divergent.Finance.Data.Context;
using System.Data.Entity;

namespace Divergent.Finance.Data.Migrations
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<FinanceContext>
    {
        protected override void Seed(FinanceContext context)
        {
            context.Prices.AddOrUpdate(k => k.Id, SeedData.Prices().ToArray());
            context.OrderItemPrices.AddOrUpdate(k => k.Id, SeedData.OrderItemPrices().ToArray());
        }
    }
}
