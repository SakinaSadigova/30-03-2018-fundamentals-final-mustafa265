# 30-03-2018-fundamentals-final

## Yazılması tələb olunan proqramlar 

- Snake Game (Tələblər və şərtlər əlavədəki Snake.jpg faylında mövcuddur)
- Cinema Reservation (Tələblər və şərtlər əlavədəki Cinema.jpg faylında mövcuddur)
- Checkers Game ( Bu tapşırıq məcburi deyil)

## Öyrənmədə çətinlik çəkən və geri qalan tələbələr üçün tələb olunanlar

- Cinema Reservation (Tələblər və şərtlər əlavədəki Cinema.jpg faylında mövcuddur)

### Aşağıdakı kiçik tapşırıqları həlletmək

**1. Let's get started**

Let's display some messages on the console and request the user to enter his name. Output a friendly welcome message with the user's name.

Run this application with the debugger and without the debugger. Can you see any differences? Try setting a breakpoint and play around with the debugger.

**2. The first countdown**

Use a for loop to create a countdown from 10 to 1. Each number should be displayed after a waiting time of 1 second. Realize that waiting period by using Thread.Sleep(1000) of the System.Threading namespace.

**3. Currency converter**

Write a little currency converter as a console application. The user should be asked to enter a value. Once a value has been entered the user is requested to enter a valid currency exchange rate. Afterwards the converted value should be displayed. Finally, if no error occurred, ask the user if another value should be converted. If yes, then start again by asking the user to enter a value. Otherwise exit the program.

**4. A simple calculator**

Request the user to enter two numbers and an operation (+, - or *). Use a switch statement to perform the right computation. Display the result.

**5. Computing prime numbers**

The user has to enter some number, which should be evaluated by your program. If the program detects a non-positive, or invalid number, the program should exit. Otherwise the evaluation should display if the entered number has been a prime number or not. In case of not being a prime number, the program has to display all the prime factors of the given number.

**6. Write a swap method**

Write a simple method called Swap() to exchange to given integers. The method should work in such a way, that the following program works:

int a = 0;
int b = 1;
//Calling Swap with a and b
if(a != 1 || b!= 0)
    throw new Exception("Swap does not work yet!");
Console.WriteLine("Swap seems to work for this case!");

**7. Guess a number**

Write a guess-a-number game. The .NET random generator is available by generating a new instance of the Random class. The game should give the user the opportunity to enter the range of numbers. Based on this range the number of tries should be determined (you can decide how hard the game should be). For each try the user has the ability to guess a number. If the guessed number is the generated number, then the user won the game. If the number of tries has been exceeded, the user lost the game.

**8. Digit sum**

Create a method, which has an int argument (called number) and an out of int argument (called digits). The return type should be an int as well.

This method would then compute the digit sum of all digits in the given number argument. The digits argument should be set to the number of given digits in number, while the result of the computation would be returned.

**9. A useful class**

Create a class, which simplifies receiving user input in the console. The class should have a default constructor and another constructor, which requires a string to be passed. The given string should be used as the message for the user the prompt. In case of the default constructor a default message should be displayed.

The class should have a method called ParseInt() and another method called ParseDouble(). The ParseInt() method will try to get a valid integer value. If no valid integer value is passed in, it will display an error message and prompt the user to enter a valid integer value. Once a valid integer value is passed in, this loop is broken and the value is returned. The ParseDouble() method does the same with a floating point value instead of an integer.

**10. Extending existing classes**

Create a class called MyRandom, which derives from the .NET class Random, but returns different values. Implement a new method called Next() and a possibility to access the protected method Sample() from outside.


**11. Vehicle, Car**


Start by creating an abstract class called Vehicle. Create two abstract methods called Accelerate() and Brake(). Additionally you should place an (protected) integer variable called tires. Add a property called Tire, which defines a get block for the variable.

Derive a class called Car from Vehicle. Implement the two functions in such a way, that they display the state change like "The car is is driving" or "The car is braking" on the console. Additionally extend the class with an integer property called Gears (with get and set) and set the value of tires to 4.

Finally derive from Car and call the new class Porsche. Override the method Drive() with some string that might represent your attitude towards driving a Porsche.

**12. Let's create a copy**

Extend the class Car of assignment 13 with a copy-constructor, i.e. a constructor which takes an instance of the own class as input parameter, and uses this instance to create a (usually deep) copy of all fields.

Also override the method Equals() in a way that it is possible to compare one instance of the class Car with another for equality.

Finally try to cast an instance of your Car class to the Porsche class. Why is this not possible?

**13. (MP) Write a class for (2D) plotting**

Write a project that makes storing plot-data in C# objects possible. The project has to fulfill the following requirements:

An arbitrary amount of data series should be storable.
Each series consists of an arbitrary amount of data points.
Each data point consists of an X and a Y value.
Each series contains information about the min x and y, as well as max x and y values.
Each series has a label and a color (just a string) assigned.
The project aims to be very generic, such that the created plotting class construct could be used with various renderes. A renderer is a special class, which takes some input, analyzes it and starts streaming some output in a certain form. In this case you could input an instance of your plotting class into some renderer, which would transform it to e.g. HTML output, displaying something on the console or a bitmap image.

**14. Communication between Forms**

Write a small Windows Forms application that consists of two windows (forms). The first (main) window should have a ComboBox with two values, "blocking" and "non-blocking", a Button and an empty Label.

The second window should have a TextBox and two Button controls, one with the text being "OK" and another one with the text being "Cancel".

Pressing the button in the main window should open the second window. If the value "blocking" has been selected from the ComboBox control, then the ShowDialog() method should be picked, otherwise the Show() method is the way to go.

The second window should be closed on pressing one of the buttons. The difference between the two buttons is, however, that the OK button does also "transmit" the value in textbox to the label of the main window.

**15. Getting to know the .NET-Framework**

Place a variety of controls on a Form and display some of the information you can read out using the Environment class like the current username and the current directory.

**16. Reaction speed**

Write a Windows Forms application that measures the reaction speed using the classes Random, Timer and Stopwatch. The Timer can be placed per drag and drop on the Form as a control.

First you use a random number to determine the value for the timer (when to display a label, that the button can now be pressed). Then, when the timer is firing it's elapsed event, start a new stopwatch measurement. Once the user presses the button the stopwatch should be stopped and the reaction time should be displayed.


**17. A custom user control**
Create a custom user control that contains a Timer control and a Label control as well as a Button. The user control should do the following:

Show the button with the text "Start" and the interval time of the timer.
When the button is pressed the time string on the label should be updated.
The button should be named "Stop" now until the timer finishes (tick event).
The button should now display "Reset". If that is being pressed then the initial state should be shown again.

**18. Threads and communication**

Implement a multithreaded program. One thread, the worker thread, is doing some time consuming "work" (i.e. counts to infinity) and reports periodically its progress to another thread, the UI thread.

A sample code for the worker thread (without reporting the progress) would be the following:

//Ping is available in System.Net.NetworkInformation
Ping ping = new Ping();
//Replace true with a statement if the loop should continue
while (true)
{
    var reply = ping.Send("132.199.99.246");
    //Use information from reply when reporting progress
    //Just wait a bit before making sending again
    Thread.Sleep(1000);
}
One last thing: Avoid cross-threading exceptions!

