using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestPractise
{
    class ClassObject
    {
        //class example
        public string name;
        public int age;

        public void SayHI()
        {
            Console.WriteLine("Hi");
        }

        static void Main(string[] args)
        {
            //Classes - In object-oriented programming, a class is a data type that defines a set of variables and methods for a declared object
            //Object - an object is called an instance of a class
            /*
             * Value types - C# has two ways of storing data, 
             * by reference (stored in part of memory called the heap -reference type are used for storing object) 
             * and by value (stored in memory in a location called the stack)
             * Stack is used for static memory allocation, which includes all your value types, like x
             * Heap is used for dynamic memory allocation, which includes custom objects, that might need additional memory during the runtime of your program
             */

            /*ClassObject person1 = new ClassObject();
                person1.SayHI(); //check Method.cs file where this is called (183)
            */

            /* We can access all public members of a class using the dot operator. Beside calling amethod, you can use the dot operator
             * to make an assignment when valid.
             * For example
                 //see Method.cs file (187) for code reference to ClassObject (10)
             */


            /*Encapsulation - part of the meaning of this word is the idea of surrounding an entity, that is to protect it
             * Encapsulation means combining members together within a class; it also means restricing access to the inner working of that class.
             * This is implemented by using access modifiers, access modifier defines the scope and visibility of a class member.
             * Encapsulation is also called information hiding
             * this following access modifiers is supported in C# - public, private, protected, internal, protected internal
             * public access modifier makes the member accessible from outside of the class
             * private access modifier makes the member accessible only from within the class and hides them from the outside
             * example
                class BankAccount
                {
                    private double balance=0;
                    public void Deposit(double n)
                    {
                        balance += n;
                    }
                    public void Withdraw(double n)
                    {
                        balance -= n;
                    }
                    public double GetBalance()
                    {
                     return balance;
                    }
                }

                -encapsulation is used here to hide the balance member from outside the code. then we provided restricted access to it
                using the public methods. The class data can only be read through the GetBalance method and modified only through the
                Deposit and Withdraw methods. you cannot directly change the balance variable. You can only view its value using the public method. this helps
                maintain data integrity. In summary, benefits of encapsulation are
                -control the way data is accessed or modified
                -Code is more flexible and easy to change with new requirements.
                -Change one part of code without affecting other parts of code
             */



            /*Constructors
             * A class constructor is a special member method of a class that is executed whenever a new object of that class is created
             * A constructor has exactly the same name as its class, is public and does not have any return type
             * example
              class Person
              {
                 private int age;
                 public Person()
                 {
                    Console.WriteLine("Hi there");
                 }
              }
              when creation of an object of type Person, the constructor is automatically called
              static void main(string[] args)
              {
                Person o = new Person();
              }
              This is useful in a number of situations, for example, when creating an object of type BankAccount, you could send an email
              notification to the owner. The same functionality could be achieved using a separate public method. the advantage of the constructor
              is that it is called automatically.

              Constructor can be useful for setting initial values, for certain member variables. Default constructor has no parameters, However
              when needed, parameters can be added to a constructor. this makes it possible to assign an initial value to an object when it's created.
              example
              class Person
              {
                private int age;
                private string name;
                public Person(string nm)
                {
                  name = nm;
                }
                public string getName()
                {
                    return name;
                }
              }
              static void Main(string[] args)
              {
                 Person p = new Person("David");
                 Console.WriteLine(p.getName());
              }
              when the object is created, we can pass a parameter that will be assigned to the name variable
             * Note by constructor can be overloaded like any method by using different numbers of parameters
             */


            /*Properties
             * we see that its a good practise to encapsulate members of a class and provide access to them only through public methods
             * A property is a member thta provides a flexible mechanism to read, write or compute the value of a private field. Properties can be used as if
             * they are public data members, but they actually include special methods called accessors.
             * The accessor of a property contains the executable statements that help in getting (reading or computing) or setting (writing) a corresponding
             * field. Accessor declarations can include a get accessor, a set accessor, or both.
             *example
                class Person
                {
                    private string name;
                    public string Name
                    {
                        get {return  name; }
                        set { name = value;}
                    }
                } //value is a special keyword, which represents the value we assign to a property using the set accessor.
                //Name of a property can be nything we want but coding conventions dictate properties have the same name as the private field with a capital letter
                
            *Once the property is defined, we can use it to assign and read the private member
                static void Main(string[] args)
                {
                    Person p = new Person();
                    p.Name = "Bob";
                    Console.WriteLine(p.Name);
                }
             * property is accessed by its name, just like any other public member of the class
             *  
             *  
             *  Any access of a property can be omited. the code below creates a read only property
                class Person
                {
                    private string name;
                    public string Name
                    {
                        get { return name; }
                    }
             * A property can also be private, so it can be called only from within the class
             * why use property? why not just declear the member variable public and access it directly. With properties you have the option
             * to control the logic of accessing the variable.
             * For example, we can check if the value of age is greater than 0, before assigning it to the variable
                 class Person
                 {
                     private int age=0;
                     public int Age
                     {
                        get { return age; }
                        set {
                            if (value > 0)
                                age = value;
                             }
                       }
                  }
                  //we can have any custom logic with get and set accessors
             * 
             *  
             *  Auto-Implemented Properties
             *  public string Name { get; set; }
             *  In the syntax above, we do not need to declear the private field name separately, Name here is called the
             *  auto-implemented property, the private field is created automaticaly using this syntax. the example below for same code on line 131
                  class Person 
                  {
                      public string Name { get; set; }
                  }
                  static void Main(string[] args)
                  {
                      Person p = new Person();
                      p.Name = "Bob";
                      Console.WriteLine(p.Name);
             *  
             */

        }
    }
}
