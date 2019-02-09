using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

//AC22005 - Coursework 3
//NAME: Matthew Foulis
//MATRIC NR: 160014275 
//NAME: Juri Ilmjarv
//MATRIC NR: 160013345

namespace ATM_Simulator
{

    
    public partial class Startup : Form
    {


        public static bool raceCondition = false; //true - race condition will be demonstrated. False - semaphores used

        private static int atmCount = 0; //number of ATMs open

        //Initialise the form
        public Startup()
        {
            InitializeComponent();
        }

        //Creates a new ATM and increments the ATM count
        private void newATM_Click(object sender, EventArgs e)
        {
            ATM atm = new ATM();
            atm.Show();
            atmCount++;
        }

        //Switches the value of race condition based on the check box
        private void checkBoxRace_CheckedChanged(object sender, EventArgs e)
        {
            raceCondition = !raceCondition;
        }

        //returns the state of raceCondition
        public static bool isRaceCondition()
        {
            if (raceCondition)
                return true;
            else
                return false;
        }

        //returns the number of ATMs running
        public static int getCount()
        {
            return atmCount;
        }

        //decrements from the number of atms
        public static void removeATM()
        {
            atmCount--;
        }

        private void Startup_Load(object sender, EventArgs e)
        { //Not used
        }

        //Displays help message in a message box.
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "The ATM is navigated using the buttons at the side of, and below the screen. Please see the README file for more information.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        //exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
