﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace EShopFashion.Entities
{
    public partial class TblCart
    {
        public int CartId { get; set; }
        public int? ProductId { get; set; }
        public int? MemberId { get; set; }
        public int? CartStatusId { get; set; }

        public virtual Tb1Product Product { get; set; }
    }
}