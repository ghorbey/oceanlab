using System;
using System.Web;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;

namespace Website.Common
{
	public enum ChangeFrequency
	{
		Always,
		Hourly,
		Daily,
		Weekly,
		Monthly,
		Yearly,
		Never
	}

	public interface ISitemapItem
	{
		string Url { get; }
		DateTime? LastModified { get; }
		ChangeFrequency? ChangeFrequency { get; }
		float? Priority { get; }
	}

	public class SitemapItem : ISitemapItem
	{
		public SitemapItem(string url)
		{
			Url = url;
		}

		public String Name { get; set; }
		public string Url { get; set; }
		public DateTime? LastModified { get; set; }
		public ChangeFrequency? ChangeFrequency { get; set; }
		public float? Priority { get; set; }
	}

	public class Breadcumb
	{
		public Breadcumb()
		{

		}

		public String GetCurrentBreadcrumb(String route)
		{
			String Path = String.Empty;



			return Path;
		}
	}

	public class XmlSitemapResult : ActionResult
	{
		private IEnumerable<ISitemapItem> _items;

		public XmlSitemapResult(IEnumerable<ISitemapItem> items)
		{
			_items = items;
		}

		public XDocument GetSitemap(ActionContext context)
		{
			String encoding = context.HttpContext.Response.ContentType;
			XDocument sitemap = new XDocument(new XDeclaration("1.0", encoding, "yes"),
				 new XElement("urlset", XNamespace.Get("http://www.sitemaps.org/schemas/sitemap/0.9"),
					  from item in _items
					  select CreateItemElement(item)
					  )
				 );
			return sitemap;
		}

		public override void ExecuteResult(ActionContext context)
		{
			base.ExecuteResult(context);

			XDocument sitemap = this.GetSitemap(context);

			context.HttpContext.Response.ContentType = "application/rss+xml";
			context.HttpContext.Response.Body.Flush();
			String ToWrite = sitemap.Declaration + sitemap.ToString();
			context.HttpContext.Response.Body.Write(Encoding.ASCII.GetBytes(ToWrite), 0, ToWrite.Length);
		}

		private XElement CreateItemElement(ISitemapItem item)
		{
			XElement itemElement = new XElement("name", new XElement("name", item.Url.ToLower()));

			if (item.LastModified.HasValue)
				itemElement.Add(new XElement("url", new XElement("loc", item.Url.ToLower())));

			if (item.LastModified.HasValue)
				itemElement.Add(new XElement("lastmod", item.LastModified.Value.ToString("yyyy-MM-dd")));

			if (item.ChangeFrequency.HasValue)
				itemElement.Add(new XElement("changefreq", item.ChangeFrequency.Value.ToString().ToLower()));

			if (item.Priority.HasValue)
				itemElement.Add(new XElement("priority", item.Priority.Value.ToString(CultureInfo.InvariantCulture)));

			return itemElement;
		}
	}
}
