using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//AC22005 - Coursework 3
//NAME: Matthew Foulis
//MATRIC NR: 160014275 
//NAME: Juri Ilmjarv
//MATRIC NR: 160013345

namespace ATM_Simulator
{
    static class Program
    {
        public static Account[] ac = new Account[3]; //Stores the account objects

        public static int threadCount = 0; //stores the number of threads

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            setupAccounts();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startup());
        }

        //Creates instances of the account class with the account details
        public static void setupAccounts()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }
    }
}
