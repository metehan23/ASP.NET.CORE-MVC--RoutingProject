using Routingg.WebUI.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routingg.WebUI.Models.ViewModel
{
    public class IndexVm
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
