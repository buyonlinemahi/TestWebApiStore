using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Core.Data.Model
{
    public class Constant
    {
        public struct lookupTables
        {
            public const string UserType = "UserTypes";
            public const string DiscountTypes = "DiscountTypes";
            public const string StockStatus = "StockStatuses";
            public const string UnitMeasurement = "UnitMeasurements";
        }
        public struct Schemas
        {
            public const string lookup = "lookup";
        }
    }
}
