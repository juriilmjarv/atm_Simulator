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
    public partial class ATM : Form
    {
      
        Button[,] numpad = new Button[3, 4]; //numpad buttons


        private System.Windows.Forms.Timer timer; //timer to delay UI thread from calling displayBalance before transaction is completed
        private int countdown = 2; //number of seconds for timer

        private Account activeAccount = null; //account being accessed by ATM

        private Thread atm_t; //atm thread used when withdrawing money

        private int withdrawAmmount = 0; //used by the thread to deduct from account balance

        private int pinCount = 0; //stores how many times a pin has been entered incorrectly 



        public ATM()
        {     
            InitializeComponent();

            //Set window size and position
            this.MinimumSize = new Size(600, 600);
            this.MaximumSize = new Size(600, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            int counter = 1; //number of buttons placed

            for (int i = 0; i < 4; i++) //Creates and adds numpad buttons
            {
                for (int j = 0; j < 3; j++)
                {
                    numpad[j, i] = new Button();

                    Console.WriteLine("i: " + i);
                    Console.WriteLine("j: " + j);

                    numpad[j, i].SetBounds(110 + (90 * j), 300 + (55 * i), 75, 44);

                    if(counter == 11)
                        numpad[j, i].Text = Convert.ToString(0);
                    else if(counter == 10)
                        numpad[j, i].Text = Convert.ToString("");
                    else if (counter == 12)
                        numpad[j, i].Text = Convert.ToString("");
                    else
                        numpad[j, i].Text = Convert.ToString(counter);

                    numpad[j,i].Font = new Font(numpad[j,i].Font, FontStyle.Bold);
                    numpad[j, i].BackColor = Color.Silver;
                    numpad[j, i].ForeColor = Color.Black;
                    numpad[j, i].Click += new EventHandler(this.numpadEvent_Click);
                    Controls.Add(numpad[j, i]);

                    counter++;
                }
            }
        }

        //displays the accounts current balance
        private void displayBalance()
        {
            textLabel4.Visible = false;
            textLabel5.Visible = false;
            textLabel6.Visible = false;

            textLabel1.Text = Convert.ToString("Balance:  £" + activeAccount.getBalance());

            textLabel2.Text = "";
            textLabel3.Text = "Return";
        }


        //One method for all numpad buttons. Adds number on pad to textbox
        void numpadEvent_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >=6)
            {
                Console.WriteLine("Your account number should be 6 digits long.");
            }
            else
            {
                textBox1.Text += ((Button)sender).Text;
            }
                //textBox1.Text += ((Button)sender).Text;
            
        }

        

        //Method carried out by the thread.
        //Writes to console for debugging then passed the required withdrawal amount to account class
        private void atmThread()
        { 
            Console.WriteLine("Enter atm thread");

            activeAccount.decrementBalance(withdrawAmmount);         
        }

        //Searches for account and returns if found. Returns null if not found
        private Account findAccount()
        {
            if(textBox1.Text == "")
            {
                return null;
            }
            else
            {
                int input = Convert.ToInt32(textBox1.Text);

                for (int i = 0; i < Program.ac.Length; i++)
                {
                    if (Program.ac[i].getAccountNum() == input)
                    {
                        return Program.ac[i];
                    }
                }
                return null;
            }
            
        }

        //Takes pin number entered and converts to int
        private int promptForPin()
        {
            int pinNumEntered = Convert.ToInt32(textBox1.Text);
            return pinNumEntered;
        }


        //Called by buttonEnter_Click() when a customer ammount to withdraw has been entered
        //Checks the account has enough funds to withdraw and returns true if so
        private void enterCustomAmmount()
        {
          
            withdrawAmmount = Convert.ToInt32(textBox1.Text);
            if (activeAccount.getBalance() <= withdrawAmmount)
            {
                Console.WriteLine("Insufficient funds!");
                labelCustomerID.Text = "Insufficient funds! Available: " + activeAccount.getBalance();
                textBox1.Text = "";
            }
            else
            {
                newThread();
                newTimer();
                textBox1.Visible = false;
            }

        }

        //Checks the user has entered the correct pin
        private void checkPin()
        {

            if (activeAccount.checkPin(this.promptForPin()))
            {
                textBox1.Text = "";
                textBox1.Visible = false;
                AskForAccountNr.Visible = false;

                labelCustomerID.Visible = false;

                displayOptions();

                AskForAccountNr.Text = "";
            }
            else
            {
                pinCount++; 

                if(pinCount == 3) //if pin has been entered incorrectly 3 times
                {
                    activeAccount.lockAccount(); //locks account
                    AskForAccountNr.Text = "Please enter your account number: ";
                    textBox1.Text = "";
                }
                else
                {
                    labelCustomerID.Visible = false;
                    textLabel3.Text = "Incorrect PIN"; textLabel3.Visible = true;
                    textBox1.Text = "";
                }
            }
            
        }


        //Checks to see if account has been found
        private void checkAccount()
        {
            activeAccount = this.findAccount();

            if (activeAccount != null)
            {
                if (activeAccount.getLocked()) //account is locked
                {
                    AskForAccountNr.Text = "Incorrect PIN entered too many times.\nAccount locked.";
                    textLabel3.Text = "Exit";
                    
                    textBox1.Visible = false;
                }
                else
                {
                    AskForAccountNr.Text = "Please enter your pin: ";
                    textBox1.Text = "";
                    textBox1.PasswordChar = '*';
                    textBox1.MaxLength = 4;
                }
            }
            else //unable to find account
            {
                textLabel3.Text = "Could not find account"; textLabel3.Visible = true;
                textBox1.Text = "";
            }
        }

        //Determines state of ATM when enter is clicked and performs appropriate action
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //When customer ammount has been selected and user is entering amount
            if(textLabel1.Text == "Enter amount: ")
            {               
                enterCustomAmmount();
            }

            //When user has entered pin
            if (AskForAccountNr.Text == "Please enter your pin: ")
            {
                labelCustomerID.Visible = false;
                checkPin();
              
            }

            //When user has entered account number
            if (AskForAccountNr.Text == "Please enter your account number: ")
            {
                labelCustomerID.Visible = false;
                checkAccount();
            }
        }

        //Clear button on atm. Removes current text from the textbox
        private void button1Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //The menu displayed to the user when they log in
        private void displayOptions()
        {
            textLabel1.Text = "Withdraw money";  textLabel1.Visible = true;
            textLabel2.Text = "Check Balance";  textLabel2.Visible = true;
            textLabel3.Text = "Exit";  textLabel3.Visible = true;
            textLabel4.Visible = false;
            textLabel5.Visible = false;
            textLabel6.Visible = false;

            labelCustomerID.Visible = true;
            labelCustomerID.Text = ("Hello Customer: " + activeAccount.getAccountNum()); //greets customer with their account number


            textBox1.Visible = false;
            textBox1.Text = "";

            Console.WriteLine(activeAccount.getAccountNum());
        }

        //Checks state when button is pressed and carries out appropriate actions
        //Either exit application, return to menu, or withdraw £20
        private void screenbutton3_Click(object sender, EventArgs e)
        {
            if(textLabel3.Text == "Exit") //closes program
            this.Close();

            if (textLabel3.Text == "Return") //returns to menu
                displayOptions();

            if (textLabel3.Text == "£20") //checks user has sufficient funds then starts thread
            {
                withdrawAmmount = 20;
                if (activeAccount.getBalance() <= 19) //insufficient funds
                {
                    Console.WriteLine("Insufficient funds!");
                    labelCustomerID.Text = "Insufficient funds! Available: " + activeAccount.getBalance();
                }
                else
                {
                    newThread();
                    newTimer();
                }
            }
        }

        //withdraw cash menu
        private void withdrawCash()
        {
            Console.WriteLine("Withdraw function call");

            textLabel1.Text = "£5";
            textLabel2.Text = "£10";
            textLabel3.Text = "£20";
            textLabel4.Text = "£50"; textLabel4.Visible = true;
            textLabel5.Text = "£100"; textLabel5.Visible = true;
            textLabel6.Text = "Other"; textLabel6.Visible = true;
        }

        //Starts a new timer to prevent the UI thread from displaying the balance before the transaction is complete
        //This would not normally be required but is used as a delay is used to demonstrate the race condition
        //A timer is required as the user interface cannot be called from the ATM thread
        private void newTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = 1000;
            timer.Start();
        }

        //Checks state when button is pressed and carries out appropriate actions
        //withdraw £5
        private void screenbutton1_Click(object sender, EventArgs e)
        {
            if (textLabel1.Text == "Withdraw money")
                withdrawCash();
            else if (textLabel1.Text == "£5")
            {
                withdrawAmmount = 5;
                if (activeAccount.getBalance() <= 4) //sufficient funds are available
                {
                    Console.WriteLine("Insufficient funds!");
                    labelCustomerID.Text = "Insufficient funds! Available: " + activeAccount.getBalance();
                }
                else
                {
                    newThread();
                    newTimer();
                }
            }
        }

        //Checks state when button is pressed and carries out appropriate actions
        //Either check balance or withdraw £10
        private void screenbutton2_Click(object sender, EventArgs e)
        {
            if (textLabel2.Text == "Check Balance")
            {
                displayBalance();
            }
            else if (textLabel2.Text == "£10")
            {
                withdrawAmmount = 10;
                if (activeAccount.getBalance() <= 9) //sufficient funds are available
                {
                    Console.WriteLine("Insufficient funds!");
                    labelCustomerID.Text = "Insufficient funds! Available: " + activeAccount.getBalance();
                }
                else
                {
                    newThread();
                    newTimer();
                }
            }
        }

        

        //Closes the current ATM and opens a new one
        private void button1Cancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Visible = false;

            AskForAccountNr.Text = "";

            //''Returns card'' and reopens application
            ATM newAtm = new ATM();
            this.Dispose();
            newAtm.Show();  

            if (activeAccount != null)
                displayOptions();
        }

        //Checks state when button is pressed and carries out appropriate actions
        //Withdraw £50
        private void screenbutton4_Click(object sender, EventArgs e)
        {
            if (textLabel4.Text == "£50")
            {
                withdrawAmmount = 50;
                if (activeAccount.getBalance() <= 49) //sufficient funds available
                {
                    Console.WriteLine("Insufficient funds!");
                    labelCustomerID.Text = "Insufficient funds! Available: " + activeAccount.getBalance();
                }
                else
                {
                    newThread();
                    newTimer();
                }

            }
        }

        //Checks state when button is pressed and carries out appropriate actions
        //Withdraw £100
        private void screenbutton5_Click(object sender, EventArgs e)
        {
            if (textLabel5.Text == "£100")
            {          
                    withdrawAmmount = 100;
                if (activeAccount.getBalance() <= 99) //sufficient funds available
                {
                    Console.WriteLine("Insufficient funds!");
                    labelCustomerID.Text = "Insufficient funds! Available: " + activeAccount.getBalance();
                }
                else
                {
                    newThread();
                    newTimer();
                }
            }
        }

        //Creates an ATM thread and starts it running
        private bool newThread()
        {
            ThreadStart atm_start = new ThreadStart(atmThread);
            atm_t = new Thread(atm_start);
            atm_t.Start();

            return true;
        }

        //Checks if the timer is finished.
        //If so the balance is displayed
        private void timer_tick(object sender, EventArgs e)
        {
            countdown--;
            if (countdown == 0)
            {
                labelCustomerID.Visible = false;
                displayBalance();
                timer.Stop();
                countdown = 6;
            }   
        }

        

        //Other amount selected
        //awaits user pressing 'enter' (see enter_click function)
        private void screenbutton6_Click(object sender, EventArgs e)
        {
            if(textLabel6.Text == "Other")
            {
                textLabel1.Text = "Enter amount: ";

                textLabel2.Visible = false;
                textLabel4.Visible = false;
                textLabel5.Visible = false;
                textLabel6.Visible = false;

                textLabel3.Text = "Return";
                textLabel3.Visible = true;

                textBox1.Visible = true;

                textBox1.PasswordChar = '\0'; // Needs to be added. Otherwise shows '*' as numbers.

            }
        }

        //Menu strip
        //Help menu and exit
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "The ATM is navigated using the buttons at the side of, and below the screen. Please see the README file for more information.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        //Closes the ATM
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Lets user only enter numbers from keyboard
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { //Cannot remove
        }

        private void ATM_Load(object sender, EventArgs e)
        { //Cannot remove
        }

        private void textLabel1_Click(object sender, EventArgs e)
        { //Cannot remove
        }

        private void textLabel6_Click(object sender, EventArgs e)
        {// cannot remove
        }
    }





}
