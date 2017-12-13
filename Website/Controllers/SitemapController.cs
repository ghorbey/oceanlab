using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Common;
using Website.Context;

namespace Website.Controllers
{
	public class SitemapController : MasterController
	{
		private WebsiteContext DbContext;

		public SitemapController(WebsiteContext context)
		{
			DbContext = context;
		}

		//List<ISitemapItem> _items;

		public SitemapController()
		{
			
		}
	}
}
