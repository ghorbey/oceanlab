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
	public class HomeController : MasterController
	{
		private WebsiteContext DbContext;

		public HomeController(WebsiteContext context)
		{
			DbContext = context;
		}

		public override IActionResult Index()
		{
			HomeViewModel vm = new HomeViewModel(base.GetModel());

			vm.NewsList.Add(new News(DateTime.Now, "Title 1", "Content 1", "#", true));
			vm.NewsList.Add(new News(DateTime.Now, "Title 2", "Content 2", "#", true));
			vm.NewsList.Add(new News(DateTime.Now, "Title 3", "Content 3", "#", true));
			vm.NewsList.Add(new News(DateTime.Now, "Title 4", "Content 4", "#", true));

			return View(vm);
		}
	}
	
}
