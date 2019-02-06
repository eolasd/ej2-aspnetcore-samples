using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EJ2CoreSampleBrowser.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        public IActionResult RowSpanning()
        {
            var DataSource = Merge.GetRowSpanData();
            ViewBag.dataSource = DataSource;
            return View();
        }

       
        
    }
}