using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() :
           base("В террариуме нет свободных мест")
        { }
    }
}
