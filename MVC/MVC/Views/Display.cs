using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Views
{
    public class Display
    {
        public Display()
        {
            this.Kilometri = 0;
            this.DayOrNight = "";
            this.TotalPrice = 0;
            this.GetValues();
        }

        public int Kilometri { get; set; }
        public string DayOrNight { get; set; }
        public double TotalPrice { get; set; }
        public void GetValues()
        {
            Console.WriteLine("Enter km: ");
            this.Kilometri = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time og day: ");
            this.DayOrNight = Console.ReadLine();
        }

        public void ShowPrice()
        {
            Console.WriteLine($"The cheapest price is: {this.TotalPrice:f2}");
        }
    }
}
