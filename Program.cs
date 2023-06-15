using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PublicModifier publicModifier = new PublicModifier();
            publicModifier.Intro();
            InternalModifier internalModifier = new InternalModifier();
            internalModifier.Intro();
            Console.WriteLine((int) WeekDays.Thursday);
        }
    }
}
