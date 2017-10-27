using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class ContactViewModel : WebsiteModel
	{
		public ContactViewModel()
		{
			Init();
		}

		public ContactViewModel(WebsiteModel vm)
		{
			this.OclBtcValue = vm.OclBtcValue;
			this.OclDollarValue = vm.OclDollarValue;
			Init();
		}

		public void Init()
		{
			Title = "Contact";
		}
	}
}
