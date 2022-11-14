using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract8_Eliseev
{
    interface IHuman
    {
        string Name { get;}
        string LastName { get; }
        int Age { get; }


        string Greetings(IHuman human);
    }
}
