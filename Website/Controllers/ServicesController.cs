using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;
using Website.Context;

namespace Website.Controllers
{
	public class ServicesController : MasterController
	{
		private WebsiteContext DbContext;

		public ServicesController(WebsiteContext context)
		{
			DbContext = context;
		}

		public override IActionResult Index()
		{
			ServicesViewModel vm = new ServicesViewModel(base.GetModel());

			ViewData["Message"] = "Your application description page.";

			return View(vm);
		}
	}
}
