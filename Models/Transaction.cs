//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewBankWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public System.DateTime Date { get; set; }
        public string DebitCredit { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
