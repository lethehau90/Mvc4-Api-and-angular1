//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeduShop.Data
{
    using System;
    using System.Collections.Generic;

    public partial class PostModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }
        public Nullable<bool> HomeFlag { get; set; }
        public Nullable<bool> HotFlag { get; set; }
        public Nullable<int> ViewCount { get; set; }
    
    }
}
