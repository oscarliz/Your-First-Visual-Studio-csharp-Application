1.  Create a new Visual C# Console App using .NET Framework project and name it "MyFirstConsoleApplication."
2.	Create a new class file called "Person.cs" and create the Person class with two public string member fields (aka instance variables). The two member fields should be called "name" and "location".
3.	In the Program.cs class file, create a new private method called "GetUserNameAndLocation". Inside of this method do the following:
1.	Create a new instance of the Person class and give the instance a variable name of "person".
2.	Prompt the user with a question "What is your name? " and assign their response to the name variable.
3.	Using String Interpolation, reply and prompt the user with "Hi ___! Where are you from? "
4.	Assign their response to the location attribute of person. 
5.	Using String Interpolation, reply and prompt the user with "I have never been to ___. I bet it is nice. Press any key to continue..."
6.	Prompt the user to "Press any key to continue." And wait to proceed until a key is pressed.
7.	Add this method into the Main method at the top.
4.	In the Program.cs class file, create a new private method called "ChristmasCountdown"
1.	The method must allow you to pass in a DateTime value when called.
2.	All DateTime formatting and calculations should be within this method.
3.	Using String Interpolation, output the current date, but not the current time with the following message. "Today's date is: ___"
4.	Create your own variable name to store the calculated value of the number of days until Christmas this year as a whole number.
5.	Using String Interpolation, output your variable like so ""There are _ days until Christmas!"
6.	Prompt the user to "Press any key to continue." And wait to proceed until a key is pressed.
7.	Add this method into the Main method under the GetUserNameAndLocation method call. Don't forget to pass in the current date.
5.	Create a new class file called "GlazerApp.cs" and set the class to static.
1.	Create a new method called "RunExample". Remember that this method must be set to public so that it can be accessed outside of the GlazerApp class. Make sure to also add the static void keywords.
2.	Inside of the RunExample method, add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
3.	Improve the code so that the user is prompted for a width, and assign the width input value to a variable. 
4.	Improve the code so that the user is prompted for a height, and assign the height input value to a variable. 
5.	Output the results in two different lines indicating what the calculated wood length in feet and glass area in square meters.  
6.	Call the RunExample method from the Program Class under Main and place it beneath the  ChristmasCountdown call.
6.	In the Program class under the Main method, at the end of the method, ensure the application does not automatically terminate and prompt the user to press any key before exiting. Hint: Consider Console.ReadKey()
7.	Do a Software Quality Assurance (SQA) check on your application. Make sure the user interaction with your application is clean and that there are no errors. You do not have to do any type of input validation for this assignment. For example, you do not need to validate that a person's name does not start with a number.
