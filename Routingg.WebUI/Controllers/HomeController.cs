using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routingg.WebUI.Models;
using Routingg.WebUI.Models.entity;
using Routingg.WebUI.Models.ViewModel;

namespace Routingg.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int catId)
        {
            NorthwndContext ctx = new NorthwndContext();
            IndexVm vm = new IndexVm();
            vm.Categories = ctx.Categories.ToList();
            if (catId!=0)
            {
                vm.Products = ctx.Products.Where(prd=>prd.CategoryID==catId).ToList();

            }

            return View(vm);
        }
    }
}
