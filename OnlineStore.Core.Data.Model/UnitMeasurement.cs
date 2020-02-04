using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStore.Core.Data.Model
{
    [Table(Constant.lookupTables.UnitMeasurement, Schema = Constant.Schemas.lookup)]
    public class UnitMeasurement
    {
        [Key]
        public int MeasurementUnitID { get; set; }
        public string MeasurementUnitName { get; set; }
    }
}

