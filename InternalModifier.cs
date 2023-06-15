using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class InternalModifier
    {
        internal void Intro()
        {
            Console.WriteLine("InternalModifier class is declared here internal which can be accessed within the same project");
        }
    }
}
