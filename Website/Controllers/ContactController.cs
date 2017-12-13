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
	public class ContactController : MasterController
	{
		private WebsiteContext DbContext;

		public ContactController(WebsiteContext context)
		{
			DbContext = context;
		}

		public override IActionResult Index()
		{
			ContactViewModel vm = new ContactViewModel(base.GetModel());

			ViewData["Message"] = "Your application description page.";

			return View(vm);
		}
	}
}
