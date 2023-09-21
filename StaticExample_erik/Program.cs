

//Static classes - static == stuck to
using StaticExample_erik;

Calculator.Add(2, 2);  //no need to make instances you can jsut call the class and the method using dot notation

var classOne = new Classroom();

classOne.RoomNumber = 1;

var classTwo = new Classroom();

classTwo.RoomNumber = 2;

Console.WriteLine($"{classOne.RoomNumber} and {classTwo.RoomNumber} both teach {Classroom.Subject}.");

//MoreExamples of static
Cat c1 = new Cat();
Cat c2 = new Cat();
Console.WriteLine(Cat.count);
//since the field is static, it belongs to all members of the cat class, so it can be declared just by calling the constructor.  You cannot access static members using instantiated objects, only by using the class name

Console.WriteLine(SomeClass.X);
//Constructors can be listed as static in order to instantiate static members
//Example of using declaring a static field using the class name
int numOfDeps = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (count < numOfDeps)
{
    string depName = Console.ReadLine();
    Department dep = new Department(depName);
    count++;
}

Console.WriteLine("Number of departments: " + Department.depCount);
class Cat
{
    //a static field has been declared
    public static int count = 0;
    public const int COUNT2 = 2;
    //const members are static by definition

    public Cat()
    {
        count++;
    }
}

class SomeClass
{
    public static int X { get; set; }
    public static int Y { get; set; }

    static SomeClass()
    {
        X = 10;
        Y = 20;
    }
}

