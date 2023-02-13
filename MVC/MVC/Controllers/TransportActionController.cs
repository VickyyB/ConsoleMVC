

using MVC.Model;
using MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class TransportActionController
    {
        private Display display;
        private Transport transport;

        public TransportActionController()
        {
            display = new Display();
            transport = new Transport(display.Kilometri, display.DayOrNight);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowPrice();
        }
    }
}
