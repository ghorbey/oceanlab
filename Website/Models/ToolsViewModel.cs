using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class ToolsViewModel : WebsiteModel
	{
		public ToolsViewModel()
		{
			Init();
		}

		public ToolsViewModel(WebsiteModel vm)
		{
			this.OclRate = vm.OclRate;
			Init();
		}

		public void Init()
		{
			Title = "Tools";
		}
	}
}
