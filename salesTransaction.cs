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
    
    public partial class salesTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public salesTransaction()
        {
            this.itemsSolds = new HashSet<itemsSold>();
        }
    
        public int id { get; set; }
        public string salesType { get; set; }
        public decimal transactionDate { get; set; }
        public decimal subtotal_amount { get; set; }
        public decimal taxableAmount { get; set; }
        public decimal totalPrice { get; set; }
        public decimal discount { get; set; }
        public decimal amountPaid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itemsSold> itemsSolds { get; set; }
    }
}
