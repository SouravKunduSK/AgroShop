//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BdShop.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seller
    {
        public int SellerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Picture { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<int> RoleType { get; set; }
    
        public virtual Role Role { get; set; }
    }
}