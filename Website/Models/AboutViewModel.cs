using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class AboutViewModel
	{
		public List<News> NewsList { get; set; }

		public AboutViewModel()
		{
			NewsList = new List<News>();
		}

		public AboutViewModel(List<News> newsList)
		{
			NewsList.AddRange(newsList);
		}
	}

	public class News
	{
		public Int32 ID { get; set; }
		public DateTime Date { get; set; }
		public String Title { get; set; }
		public String Content { get; set; }
		public String Link { get; set; }
		public Boolean IsInternalLink { get; set; }

		public News()
		{
			Date = DateTime.Now;
			Title = String.Empty;
			Content = String.Empty;
			Link = "#";
			IsInternalLink = true;
		}

		public News(DateTime date, String title, String content, String link, Boolean isInternalLink)
		{
			Date = date;
			Title = title;
			Content = content;
			Link = link;
			IsInternalLink = isInternalLink;
		}
	}
}
