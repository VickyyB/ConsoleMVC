using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVS.Model
{
    public class Tip
    {
        private double amount;
        private double percent;
        public Tip(double amount,double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }
        public double Amount
        {
            get { return Amount; }
            set { this.Amount = value; }
        }

        public double Percent
        {
            get { return Percent; }
            set
            {
                if (value > 1)
                {
                    this.Percent = value / 100.0;
                }
                else
                {
                    this.percent = value;
                }
            }
        }

            public double CalcilateTip()
        {
            return Amount * Percent;
        }
        public double CalculateTotal()
        {
            return CalcilateTip() + Amount;
        }

    }
}