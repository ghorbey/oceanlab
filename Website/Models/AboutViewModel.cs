using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class AboutViewModel : WebsiteModel
	{
		public List<News> NewsList { get; set; }

		public AboutViewModel()
		{
			Init();
		}

		public AboutViewModel(List<News> newsList)
		{
			Init(newsList);
		}

		public AboutViewModel(WebsiteModel vm)
		{
			this.OclBtcValue = vm.OclBtcValue;
			this.OclDollarValue = vm.OclDollarValue;
			Init();
		}

		public void Init(List<News> newsList = null)
		{
			if (newsList == null) NewsList = new List<News>();
			else NewsList.AddRange(newsList);
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
