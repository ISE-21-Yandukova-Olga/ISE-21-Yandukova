using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() :
         base("В террариуме уже есть такой паук")
        { }
    }
}
