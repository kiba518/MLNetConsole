// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace MLNetConsoleML.Model
{
    public class ModelInput
    {
        [ColumnName("Month"), LoadColumn(0)]
        public string Month { get; set; }


        [ColumnName("ProductSales"), LoadColumn(1)]
        public float ProductSales { get; set; }


    }
}
