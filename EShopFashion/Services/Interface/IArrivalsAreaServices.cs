using EShopFashion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopFashion.Services.Interface
{
    interface IArrivalsAreaServices
    {
        public List<SingleArrivalsArea> GetArrivalsAreas();
    }
}
