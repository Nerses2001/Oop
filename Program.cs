using System;
using Oop.ClassExamples;
using Oop.ClassExamples.Constructores;
using Oop.ClassExamples.Statices;
using Oop.ClassExamples.Statics;
using Oop.PrinciplesOop.Encapsulation;
using Oop.PrinciplesOop.Encapsulation.Constants;
using Oop.PrinciplesOop.Encapsulation.PartialClass;
using Oop.PrinciplesOop.Inheritance;
using Oop.PrinciplesOop.Polymorphism;
using Oop.PrinciplesOop.Polymorphism.Abstract;

namespace Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarAuto myCar = new CarAuto();
            myCar.petName = "petName";
            myCar.currSpeed = 10;

            CarUsingConstructor car1 = new CarUsingConstructor();
            CarUsingConstructor car2 = new CarUsingConstructor(10);
            CarUsingConstructor car3 = new CarUsingConstructor("petName2");
            CarUsingConstructor car4 = new CarUsingConstructor("asas",45);
            CarUsingConstructor car5 = new CarUsingConstructor("asas", 45, "RED");

            Motorcycle m1 = new Motorcycle();
            Console.WriteLine("Name= {0}, Intensity= {1}", m1.driverName, m1.driverIntensity);
            
            Motorcycle m2 = new Motorcycle(name: "Tiny");
            Console.WriteLine("Name= {0}, Intensity= {1}",m2.driverName, m2.driverIntensity);
            
            Motorcycle m3 = new Motorcycle(7);
            Console.WriteLine("Name= {0}, Intensity= {1}",m3.driverName, m3.driverIntensity);


            Console.WriteLine("***** Fun with Static Data *****\n");
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);

            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetlnterestRate());

            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetlnterestRate());
            
            Console.WriteLine();   
            
            StaticConstructors static1 = new StaticConstructors(50);

            Console.WriteLine("Interest Rate is: {0}", StaticConstructors.GetlnterestRate());

            StaticConstructors.SetlnterestRate(0.08);
            StaticConstructors static2 = new StaticConstructors(100);

            Console.WriteLine("Interest Rate is: {0}", StaticConstructors.GetlnterestRate());

            Console.WriteLine();

            ChangeStatic changeStatic1 = new ChangeStatic(50);

            Console.WriteLine("Interest Rate is: {0}", ChangeStatic.GetlnterestRate());

            ChangeStatic.SetlnterestRate(0.08);
            ChangeStatic chnageStatic2 = new ChangeStatic(100);

            Console.WriteLine("Interest Rate is: {0}", ChangeStatic.GetlnterestRate());

            Console.WriteLine("***** Fun with Static Classes *****\n");

            StaticClass.PrintDate();
            StaticClass.PrintTime();
            
            Employee emp = new Employee("John Doe", 30, 123, 5000);

            Console.WriteLine("Employee Information:");
            Console.WriteLine("Name: " + emp.Name);
            Console.WriteLine("ID: " + emp.Id);
            Console.WriteLine("Pay: " + emp.Pay);
            Console.WriteLine("Age: " + emp.Age);

            emp.Name = "Jane Smith";
            emp.Id = 456;
            emp.Pay = 6000;
            emp.Age = 25;

            Console.WriteLine("\nUpdated Employee Information:");
            Console.WriteLine("Name: " + emp.GetName());
            Console.WriteLine("ID: " + emp.Id);
            Console.WriteLine("Pay: " + emp.Pay);
            Console.WriteLine("Age: " + emp.Age);

            emp.GiveBonus(1000);

            Console.WriteLine("Updated Pay: " + emp.Pay);

            Console.WriteLine("***** Fun with Object Init Syntax *****\n");
            
            Point firstPoint = new Point();
            
            firstPoint.X = 10;
            firstPoint.Y = 10;
            
            firstPoint.DisplayStats();

            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();
            
//            Point finalPoint = new Point { X = 30, Y = 30 };
            Point finalPoint = new Point() { X = 30, Y = 30 };
            Point pt = new Point(10, 16) { X = 100, Y = 100 };

            finalPoint.DisplayStats();

            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();

            Rectangle myRectangle = new Rectangle 
            {
                TopLeft = new Point {X = 10, Y = 10},
                BottomRight = new Point { X = 200, Y = 200 }

            };
            Rectangle r = new Rectangle();
            Point p1 = new Point();
            
            p1.X = 10;
            p1.Y = 10;
            
            r.TopLeft = p1;
            
            Point p2 = new Point();
            
            p2.X = 200;
            p2.Y = 200;
            
            r.BottomRight = p2;


            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            // Error! Can't change a constant!
            // MyMathClass.PI = 3.1444;
            Console.WriteLine("***** Fun with Const *****");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI3);

            EmployeePartialClassFirst empPartial = new EmployeePartialClassFirst()
            {
                FirstName = "John",
                LastName = "Doe",
                HireDate = DateTime.Now
            };

            empPartial.PrintDetails();

            Console.WriteLine("***** Basic Inheritance *****\n");
            ElectroCar carInh = new ElectroCar(80);
            carInh.Speed = 50;
            Console.WriteLine("My carInh is going {0} MPH", carInh.Speed);

            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);

            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            double cost = chucky.GetBenefitCost();

            ManagerPoly chuckyPoly = new ManagerPoly();
            chuckyPoly.PrintGivBonus(20);
            SalespersonPoly  salespersonPoly = new SalespersonPoly();
            salespersonPoly.PrintGivBonus(200);
            Hexagon hex = new Hexagon("Beth");
            hex.Draw();
            Circle cir = new Circle("Cindy");
      
            cir.Draw();

            Console.WriteLine("***** Fun with Polymorphism *****\n");
      
            ShapeAbstractMethod[] myShapes = {new HexagonAbstractMethod(), new CircleAbstractMethod(), new HexagonAbstractMethod("Mick" ) ,
            new CircleAbstractMethod("Beth"), new CircleAbstractMethod("Linda" )};
            
            foreach (ShapeAbstractMethod s in myShapes)
            {
                s.Draw();
            }

            Console.ReadLine();
        }
    }
}
