using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ATM_Simulator
{
    class Account
    {
        //Semaphore used to only allow one thread into the decrement balance at a time
        public static Semaphore sem = new Semaphore(1, 1);

        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;
        private bool isLocked = false;


        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
            *   This funciton allows us to decrement the balance of an account
            *   it perfomes a simple check to ensure the balance is greater tha
            *   the amount being debeted
            *   
            *   returns:
            *   true if the transactions if possible
            *   false if there are insufficent funds in the account
            */
        public Boolean decrementBalance(int amount)
        {
            int balanceRC; //extra balance variable to demonstrate race condition

            Program.threadCount++; //increment the number of threads

            Console.WriteLine("atm count: " + Startup.getCount());

            if (Startup.getCount() > 1) //More than one ATM running
            {
                while (Program.threadCount < 2) //Wait for additional ATM
                {
                    Thread.Sleep(1);
                }
            }

            if (!Startup.isRaceCondition()) //If race condition box has not been selected
                sem.WaitOne(); //Entry point of semaphore


            Console.WriteLine("enter semaphore");



            /**
             * The following lines are the 'critical code' and either demonstrate the race condition, or use the 
             * semaphores to prevent it. 
             * balanceRC is an additional balance variable and is used to cause the second thread to access balance before
             * it has been update by the first.  
             */
            Thread.Sleep(100);

            balanceRC = balance;

            if (this.balance >= amount)
            {
                balanceRC -= amount;
                Thread.Sleep(100);
                balance = balanceRC;

                if (!Startup.isRaceCondition())
                    sem.Release();  //end of semaphore

                Program.threadCount = 0; //reset number of threads

                return true;
            }
            else
            {
                if (!Startup.isRaceCondition())
                    sem.Release();

                Program.threadCount = 0;
                return false;
            }

        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //getter for account number
        public int getAccountNum()
        {
            return accountNum;
        }

        //getter for is the account locked
        //returns true if it is locked
        //false if not
        public bool getLocked()
        {
            if (isLocked)
                return true;
            else
                return false;
        }

        //setter for isLocked
        public void lockAccount()
        {
            isLocked = true;
        }


    }
}