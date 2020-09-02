using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestPractise
{
    class InheritancePolymorphism
    {
         //Inherited base clas
         class Animal
         {
            public int Legs { get; set; }
            public int Age { get; set; }
         }
         //derive class
         class Dog : Animal
         {
            public Dog()
            {
                Legs = 4;
            }
            public void Bark()
            {
                Console.Write("Woof");
            }
         } 

         class Person
         {
            public void Speak()
            {
                Console.WriteLine("Hi there");
            }
         }
         class Student : Person
         {
            int number;
         }
         

         static void main(string[] args)
         {

             /*
              * Inheritance - 
              * allows us to define a class based on another class. This makes creating and maintaining an application easy.
              * The class whose properties are inherited by another class is called the Base class. The class which inherits the properties is called the Derived class.
              * for example, Base class Animal can be used to derive Cat and Dog classes.
              * The derived class inherits all the features from the base class and can have its own additional features
              * example line(12)
              */
                    Dog d = new Dog();
                    Console.WriteLine(d.Legs); //output is 4
                    d.Bark(); //output Woof
                        //A base clase can have multiple derived classes.
                        //for example, a Cat class can inherit from Animal
                        //Inheritance allows the derived class to reuse the code in the base class without having to rewrite it. Also the derive class can be customized by 
                        //adding more members. In this manner, the derived class extends the functionality of the base class.
                    /*A derived class inherits all the members of the base class, including its methods
                     * example line(30)
                     * 
                     */
                     Student s = new Student();
                     s.Speak(); // output Hi there
            //C# does not support multiple inheritance, so we cannot inherit from multiple classes, however, we can use interfaces to implement multiple inheritance


        }


    }
}
