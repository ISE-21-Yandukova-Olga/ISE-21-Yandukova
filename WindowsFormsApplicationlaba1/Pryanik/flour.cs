using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pryanik
{
    class flour
    {
        //количество муки

        public int count { set; get; }

        public int count_flour { set { count = value; } get { return count; } }
    }
}
