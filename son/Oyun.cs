using son;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Oyun
    {

        
        [STAThread]
        public static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

    }
}
