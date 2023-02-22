/*
 * Person Class
 * 2/22/2023
 * C#.NET I
 * 
 * Instructions:
 * 
 * Part 1
 * Read through the code in the Main() method and the Person class.
 * In addition, run the program. Be prepared to discuss the following
 * questions...
 * 1. How many instance variables does the Person class have? What are
 *    their types?
 * 2. What happens if you change the access modify for the name instance
 *    variable from public to private? Why? What do these access modifiers
 *    mean?
 * 3. Let's add a breakpoint on line 33 and run the program in dedugging mode.
 *    What values are initialial stored in the instance variables? What are 
 *    the default values for each type?
 * 
 * Modify the Person class by adding another instance variable called weight.
 * Test your modification by storing 165.2 into p1's weight instance variable
 * and printing it out to the console.
 * 
 * Part 2
 * Let's modify the Person class by adding two constructors. A no argument
 * constructor that initializes the instance variables to the following values:
 * name: John Smith; age: 18; height: 5 ft, 6 in; weight: 150
 * In addition, let's write a constructor that accepts an argument for
 * piece of information and intializes the corresponding instance variable.
 * Back in the Main() method, we will simplify our code using these constructors.
 * We will also create 2 additional Person objects, one that uses the default values
 * and the other that represents ourselves. Finally, let's discuss a few things...
 * 1. What is the benefit of constructors?
 * 2. Will the default values for every type of object be the same?
 * 3. Will each class have the same amount of constructors?
 * 4. Should constructors be before or after the instance variables?
 * 
 * Part 3
 * Did you notice that we had to use a different name than the instance variable's
 * name for the parameters in our second constructor? What happens if we try
 * to use the same name?
 * Let's fix this by using the this reference! Do you prefer this style or the
 * previous? Why?
 * 
 * Part 4
 * Finally, let's modify the Person class one more time. Let's make the no argument
 * constructor call the other constructor to initialize the instance variables. Don't
 * forget to run the code to make sure it works! Why might it be useful to run all 
 * constructors through a central or base constructor?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.name + ", " + p1.age + ", " + p1.heightInInches);
            p1.name = "Jimbo";
            p1.age = 53;
            p1.heightInInches = 65.25;
            Console.WriteLine(p1.name + ", " + p1.age + ", " + p1.heightInInches);
        }
    }
}
