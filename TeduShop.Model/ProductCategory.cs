﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;

    public partial class ProductCategoryModel
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="Yêu cầu nhập tên")]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập alias")]
        [MaxLength(256)]
        public string Alias { get; set; }
        //[Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public Nullable<int> parentID { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        [MaxLength(256)]
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }
        public bool HomeFlag { get; set; }
    
    }
}
