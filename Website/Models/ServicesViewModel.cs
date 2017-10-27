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
			this.OclBtcValue = vm.OclBtcValue;
			this.OclDollarValue = vm.OclDollarValue;
			Init();
		}

		public void Init()
		{

		}
	}
}
