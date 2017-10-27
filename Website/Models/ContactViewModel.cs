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
			this.OclRate = vm.OclRate;
			Init();
		}

		public void Init()
		{
			Title = "Contact";
		}
	}
}
