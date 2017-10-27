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
			this.OclBtcValue = vm.OclBtcValue;
			this.OclDollarValue = vm.OclDollarValue;
			Init();
		}

		public void Init()
		{
			Title = "Medium";
		}
	}
}
