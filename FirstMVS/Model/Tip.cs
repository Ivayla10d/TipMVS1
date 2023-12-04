using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVS.Model
{
    class Tip
	{
		private double amount;// сума на сметката

		public double Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		private double percen;// процент за сервитиора

		public double Percent
		{
			get { return percen; }
			set
			{
				if (value > 100 || value < 0)
				{
					throw new ArgumentOutOfRangeException("Invalide number");
				}
				if (value > 1)
				{
					percen = value / 100.0;
				}
				else
				{
					percen = value;
				}
			}
		}


	    public Tip(double amont, double percent)
		{
			this.Amount = amont;
			this.Percent = percent;
		}
		public Tip() : this(0, 0) { }

		public double CalculateTip()
		{
			return Amount * Percent;
		}
		public double CalcolateTotal()
		{
			return CalculateTip() + Amount;
		}

    }


}
	

