using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
	public class OclTokenController : MasterController
	{
		public override IActionResult Index()
		{
			OclTokenViewModel vm = new OclTokenViewModel(base.GetModel());

			ViewData["Message"] = "Your application description page.";

			return View(vm);
		}
	}
}
