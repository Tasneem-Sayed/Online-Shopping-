﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace EShopFashion.Entities
{
    public partial class Tb1Category
    {
        public Tb1Category()
        {
            Tb1Products = new HashSet<Tb1Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<Tb1Product> Tb1Products { get; set; }
    }
}