﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;
using Website.Context;

namespace Website.Controllers
{
	public class ToolsController : MasterController
	{
		private WebsiteContext DbContext;

		public ToolsController(WebsiteContext context)
		{
			DbContext = context;
		}

		public override IActionResult Index()
		{
			ToolsViewModel vm = new ToolsViewModel(base.GetModel());

			ViewData["Message"] = "Your application description page.";

			return View(vm);
		}
	}
}
