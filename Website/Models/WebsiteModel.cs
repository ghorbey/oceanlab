using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
	public class WebsiteModel : MasterModel
	{
		public String Title { get; set; }
		public OclExchangeRate OclRate { get; set; }

		public WebsiteModel()
		{
			OclRate = new OclExchangeRate();
		}

		public WebsiteModel(Double oclBtcValue, Double oclDollarValue)
		{
			OclRate = new OclExchangeRate(oclBtcValue, oclDollarValue);
		}
	}

	public class OclExchangeRate
	{
		public Double OclBtcValue { get; set; }
		public Double OclDollarValue { get; set; }

		public OclExchangeRate()
		{
			OclBtcValue = 0;
			OclDollarValue = 0;
		}

		public OclExchangeRate(Double oclBtcValue, Double oclDollarValue)
		{
			OclBtcValue = oclBtcValue;
			OclDollarValue = oclDollarValue;
		}
	}
}
