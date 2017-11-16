using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class NewsViewModel : WebsiteModel
	{
		public NewsViewModel()
		{
			Init();
		}

		public NewsViewModel(WebsiteModel vm)
		{
			this.OclRate = vm.OclRate;
			Init();
		}

		public void Init()
		{
			Title = "News";
		}
	}
}
