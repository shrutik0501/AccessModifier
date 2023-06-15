using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class ProtectedModifier
    {
        protected void Intro()
        {
            Console.WriteLine("Intro method is declared here protected which can be accessed within the same class or from the child class of ProtectedModifier");
        }
    }
}
