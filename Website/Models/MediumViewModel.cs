using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class MediumViewModel : WebsiteModel
	{
		public MediumViewModel()
		{
			Init();
		}

		public MediumViewModel(WebsiteModel vm)
		{
			this.OclRate = vm.OclRate;
			Init();
		}

		public void Init()
		{
			Title = "Medium";
		}
	}
}
