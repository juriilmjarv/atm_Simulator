ATM C# PROGRAM
Group 6: Matthew Foulis, Jüri Ilmjärv

How to use:
When the program is started, you will be presented with a window containing a button and a check box. The button is used to create a new ATM and can be pressed multiple times. The check box switches between using the semaphores to prevent a data race condition, and not using them to display what happens without.

The ATM is navigated with the buttons on the window, similar to a normal ATM. You can also use your computer keyboard for number input. 

To test the race condition, first open two ATM’s, navigate to the ‘withdraw money’ section on both, and then select the amount you wish to withdraw on each separate ATM. There will be a delay between pressing the button and the balance being displayed. This is to prevent the balance being displayed before the transaction has taken place. The transaction is slower than would be normal in order to demonstrate the race condition. 

Example: Two ATM’s have open the same account with a balance of £300. £100 is selected for withdrawal on both. If the race condition box is checked the balance will now be £200 as they have tried to carry out a transaction at the same time. If the check box is not clicked, the semaphore will be used and the new balance will be £100 as expected. 
