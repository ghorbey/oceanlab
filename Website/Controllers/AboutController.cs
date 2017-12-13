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
	public class AboutController : MasterController
	{
		private WebsiteContext DbContext;

		public AboutController(WebsiteContext context)
		{
			DbContext = context;
		}

		public override IActionResult Index()
		{
			AboutViewModel vm = new AboutViewModel(base.GetModel());

			return View(vm);
		}
	}
}
