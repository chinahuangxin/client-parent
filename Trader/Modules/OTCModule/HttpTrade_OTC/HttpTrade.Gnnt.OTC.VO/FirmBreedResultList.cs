using System;
using System.Collections.Generic;
namespace HttpTrade.Gnnt.OTC.VO
{
	public class FirmBreedResultList
	{
		private List<F_FirmBreedInfo> REC;
		public List<F_FirmBreedInfo> FirmBreedInfoList
		{
			get
			{
				return this.REC;
			}
		}
	}
}