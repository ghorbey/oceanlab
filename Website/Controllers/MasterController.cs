using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;
using Website.Common;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Website.Controllers
{
	public class MasterController : Controller
	{
		public virtual IActionResult Index()
		{
			WebsiteModel wm = new WebsiteModel();

			wm.OclRate.OclBtcValue = 0.0005;
			wm.OclRate.OclDollarValue = 0.03;

			//Breadcrumb bc = new Breadcrumb();
			//bc.GetCurrentBreadcrumb();
			//Request.Path.Value;

			return View(wm);
		}

		public virtual WebsiteModel GetModel()
		{
			WebsiteModel wm = new WebsiteModel();

			wm.OclRate.OclBtcValue = 0.0005;
			wm.OclRate.OclDollarValue = 0.03;

			return wm;
		}
	}
}