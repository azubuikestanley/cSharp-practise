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

        //Protected access modifier
        class Person2
        {
            protected int Age { get; set; }
            protected string Name { get; set; }
        }
        class Student2 : Person2
        {
            public Student2(string nm)
            {
                Name = nm;
            }
            public void Speak()
            {
                Console.WriteLine("Name: " + Name);
            }
        }

        //Derived Class Constructor and Destructor
        class Animal2
        {
            public Animal2()
            {
                Console.WriteLine("Animal Created");
            }
            ~Animal2()
            {
                Console.WriteLine("Animal Deleted");
            }
        }
        class Cow: Animal2
        {
            public Cow()
            {
                Console.WriteLine("Cow Created");
            }
            ~Cow()
            {
                Console.WriteLine("Cow deleted");
            }
        }


        //Polymorphism
        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Base Draw");
            }
        }
        //if we change override to new, it will not override the base class
        class Circle : Shape
        {
            public override void Draw()
            {
                //draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape
        {
            public override void Draw()
            {
                //draw a rectangle ...
                Console.WriteLine("Rectangle Draw");
            }
        }


        //Abstract method
        abstract class Shape2
        {
            public abstract void Draw();
        }
        class Circle2 : Shape2
        {
            public override void Draw()
            {
                Console.WriteLine("Circle2 Draw");
            }
        }
        class Rectangle2 : Shape2
        {
            public override void Draw()
            {
                Console.WriteLine("Rectangle2 Draw");
            }
        }


        //Interface
        public interface IShape
        {
             void Draw();
        }
        class CircleA : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Circle Draw");
            }
        }


        //Nested class
        class Car
        {
             string name;
             public Car(string nm)
             {
                 name = nm;
                 Motor m = new Motor();
             }
             public class Motor
             {
                 // some code
             }
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



            /*
             * Protected - 
             * This access modifier is very similar to private access modifier with one difference.
             * A Protected access modifier can be accessed in the derived classes. So a protected member is accessible only from derived classes
             * example line(43)
             */
            Student2 s2 = new Student2("Iykeman");
            s2.Speak();

            /*Sealed - 
             * A class can prevent other classes from inheritig it, or any of its members by using the sealed modifier. example
             * sealed class Animal {
             *   //some code
             * }
             * class Dog : Animal {  }   // Error
             * The sealed keyword provides a level of protection to your class so that other classes cannot inherit from it
             */


            /*Derived Class Constructor and Destructor
             * Contructors are called when objects of a class are created. With inheritance, the base class constructor and destructor are not inherited, so we should 
             * define constructors for the derived classes.
             * However, he base class constructor and destructor are being invoked automatically when an object of the derived class is created or derleted
             * consider example line(61)
             * Note that the base class constructor is called first and the derived class constructor is called next. When the object is destroyed, the derived class
             * destructor is invoked and then the base class destructor is invoked.
             * we can think of this as the following: the derived class needs its base class in order to work which is why the base class constructor is called first
             */
            Cow c = new Cow();


            /* Polymorphism - 
             * this word means having many forms, it occurs when there is a hierarchy of classes and they are related through inheritance from a common base class.
             * Polymorphism means that a call to a member method will cause a different implementation to be executed depending on the type of object that invokes the method.
             * This simplt means that a single method can have a number of different implementations.
             * -Consider having a program that alllows users to draw different shapes.Each shape is drawn differently and you do not know which shape the user will choose,
             * Here, polymorphism can be leveraged to invoke the appropriate Draw method of any derived class. Such methods must be declared using the virtual keyword in the base class
             * example below and line(85)
             * class shape {
             *      public virtual void Draw() {
             *          Console.WriteLine("Base Draw");
             *      }
             * }
             * The virtual keyword allows methods to be overridden in derived classes.
             * Virtual methods enable us to work with groups of related objects in a uniform way.
             * 
             * we can derive different shape classes that define their own Draw methods using the override keyword. example line (93).
             * The virtual Draw method in the Shape base class can be overridden in the derived classes. In this case, Circle and Rectangle have their own Draw methods.
             * we can create separate Shape objects for each derived type and then call their Draw methods
             */
             Shape cc = new Circle();
             cc.Draw();  // output "Circle Draw"
             Shape rt = new Rectangle();
             rt.Draw(); //output "Rectangle Draw"
            /*Polymorphism is useful in many cases, For example, we could create a game where we would have different player types with each player
            *having a separate behaviour for the Attack method.
            * In this case, Attack would be a virtual method of the base class Player and each derived class would override it.
            */


            /*Abstract Classes -
             * In situation where it is not meaningful for the virtual method(polymorphism) to have a separate definition in base class, 
             * we defined this method with the abstract keyword and specify that the derived classes must define their method on their own.
             * we cannot create objects of a class containing an abstract method, which is why the class itself should be abstract
             * lets use abstract method in the shape class as in polymorphism case, example line (113)
             * The draw method on line 133 is abstract and thus has no body, we do not even need a curly brackets, just end the statement with a semicolon.
             * The Shape class itself must be declared abstract because it contains an abstract method. Abstract method declarations are only permitted in abstract classess
             * Members marked as abstract or included in an abstract class must be implemented by classes that derive from the abstract class.
             * An abstract class can have multiple abstract members
             * Ab abstract class is intended to be a base class of other classess. It acts like a template for its derived classes.
             * we can now define other classes and define their own Draw() method. example line(117)
             */
            Shape2 cc2 = new Circle2();
            cc.Draw();  // output "Circle Draw"
            Shape2 rt2 = new Rectangle2();
            rt.Draw(); //output "Rectangle Draw"
            /*Abstract class have the following features
             * An abstract class cannot be instantiated
             * An abstract class may contain abstract methods and accessors
             * A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors
             * Note that it is not possible to modify an abstract class with the sealed modifier because the two modifiers have opposite meanings. 
             * The sealed modifier prevents a class from being inherited and the abstract modifier requires a class to be inherited
             */



            /* Interfaces - 
             * An interface is a completely abstract class, which contains only abstract members. It is declared using the interface keyword,
             * Example -
             * public interface IShape
             * {
             *     void Draw();
             * }
             * All members of the interface are by default abstract, so no need to use the abstract keyword.
             * Also all members of an interface are always public, an no access modifiers can be applied to them.
             * It is common to use the capital letter I as the starting letter for an interface name.
             * Interfaces can contain properties, methods, etc but cannot contain fields (variables).
             * 
             * When a class implements an interface, it must also implement, or define, all of its methods.
             * The term implementing an interface is used(opposed to the term "inheriting from") to describe the process of creating a class based on an
             * interface. The interface simply describes what a class should do. The class implementing the interface must define how to accomplish the behaviours.
             * The syntax to implement an interface is the same as that to derive a class.
             * example line (134)
             */
            IShape ca = new CircleA();
            ca.Draw();  //Output "Circle Draw"
            /*Note that the override keyword is not needed when you implement an interface
             * Why use interfaces rather than abstract classes?
             * A class can inherit from just one base class, but it can implement multiple interfaces!
             * Therefore, by using interfaces we can include behaviour from multiple sources in a class.
             * To implement multiple interfaces, use a comma separated list of interfaces when creating the class: Class A : IShape, IAnimal, etc
             */



            /*
             * Nested Classes
             * C# supports nested classes, a nested class is a class that is a member of another class. example below & line (148)
             * class Car {
             *      string name;
             *      public Car(string nm) {
             *          name = nm;
             *          Motor m = new Motor();
             *      }
             *      public class Motor {
             *          // some code
             *      }
             * }
             * 
             * The Motor class is nested in the Car class and can be used similar to other members of the class.
             * A nested class acts as a member of the class, so it can have the same access modifiers as other members(public, private, protected).
             * 
             * Just as in real life, objects can contain other objects. For example, a car, which has its own attributes(color, brand, etc) contains
             * a motor, which as a separate object, has its own attributes(volume, horsepower, etc).
             * Here, the Car class can have a nested Motor class as one of its members
             */




            /*Namespaces
             * when we create a blank project, it has the following structure:
             * 
             * using System;
             * using System.Collections.Generic;
             * using System.Linq;
             * using.System.Text;
             * using System.Threading.Tasks;
             * 
             * namespace SoloLearn {
             *    class Program {
             *        static void Main(string[] args) {
             *        }
             *    }
             * }
             * 
             * Note that our whole program is inside a namespace. So, what are namespaces?
             * Namespaces declare a scope that contains a set of related objects. You can use a namespace to organize code elements. 
             * You can define your own namespaces and use them in your program. The using keyword states that the rpogram is using a given namespace.
             * for example, we are using the System namespace in our programs, which is where the class Console is defined. Without the using
             * statement, we would have to specify the namespace whereever it is used like below
             * System.Console.WriteLine("Hello world");
             * 
             * The .NET framework uses namespaces to organize its many classes. System is one example of a .NET framework namespaces. Declaring your
             * own namespaces can help you group your class and method names in larger programming projects
             * 
             */




        }


    }
}
