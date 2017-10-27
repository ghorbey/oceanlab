using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class ServicesViewModel : WebsiteModel
	{
		public ServicesViewModel()
		{
			Init();
		}

		public ServicesViewModel(WebsiteModel vm)
		{
			this.OclRate = vm.OclRate;
			Init();
		}

		public void Init()
		{
			Title = "Services";
		}
	}
}
