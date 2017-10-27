using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class OclTokenViewModel : WebsiteModel
	{
		public OclTokenViewModel()
		{
			Init();
		}

		public OclTokenViewModel(WebsiteModel vm)
		{
			this.OclBtcValue = vm.OclBtcValue;
			this.OclDollarValue = vm.OclDollarValue;
			Init();
		}

		public void Init()
		{
			Title = "OCL Token";
		}
	}
}
