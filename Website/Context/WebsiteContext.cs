using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Context
{
	public class WebsiteContext : DbContext
	{
		public WebsiteContext(DbContextOptions<WebsiteContext> options) : base(options)
		{ }
	}
}
