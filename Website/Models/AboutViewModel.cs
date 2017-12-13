using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class AboutViewModel : WebsiteModel
	{
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
			this.OclRate = vm.OclRate;
			Init();
		}

		public void Init(List<News> newsList = null)
		{
			Title = "Home";
		}
	}
}
