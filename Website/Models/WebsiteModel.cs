using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class WebsiteModel : MasterModel
	{
		public Double OclBtcValue { get; set; }
		public Double OclDollarValue { get; set; }

		public WebsiteModel()
		{
			OclBtcValue = 0;
			OclDollarValue = 0;
		}

		public WebsiteModel(double oclBtcValue, double oclDollarValue)
		{
			OclBtcValue = oclBtcValue;
			OclDollarValue = oclDollarValue;
		}
	}
}
