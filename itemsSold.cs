//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointOfSalesApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class itemsSold
    {
        public int id { get; set; }
        public Nullable<int> salesID { get; set; }
        public Nullable<int> productID { get; set; }
        public int quantitySold { get; set; }
        public decimal unitPrice { get; set; }
        public decimal transactionDate { get; set; }
        public string productCategory { get; set; }
    
        public virtual product product { get; set; }
        public virtual salesTransaction salesTransaction { get; set; }
    }
}