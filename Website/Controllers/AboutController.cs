using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
	public class AboutController : MasterController
	{
		public override IActionResult Index()
		{
			AboutViewModel vm = new AboutViewModel(base.GetModel());

			vm.NewsList.Add(new News(DateTime.Now, "Title 1", "Content 1", "#", true));
			vm.NewsList.Add(new News(DateTime.Now, "Title 2", "Content 2", "#", true));
			vm.NewsList.Add(new News(DateTime.Now, "Title 3", "Content 3", "#", true));
			vm.NewsList.Add(new News(DateTime.Now, "Title 4", "Content 4", "#", true));

			return View(vm);
		}
	}
}
