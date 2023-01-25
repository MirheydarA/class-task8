
//namespace test;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        var animal1 = new Animal();
//        animal1.name = "Max";
//        animal1.breed = "Golden Retrievers";
//        animal1.color = "yellow";
//        animal1.age = 2;

//        var animal2 = new Animal();
//        animal2.name = "Leo";
//        animal2.breed = "Puddle";
//        animal2.color = "white";
//        animal2.age = 1;    



//    Console.WriteLine(animal1.GetDetails());
//        Console.WriteLine(animal2.GetDetails());
//    }
//}


//task 2

using task;
namespace test;
internal class Program
{
    static void Main(string[] args)
    {
        var building1 = new Building("testname", 4, 2, "testadress");
    
        Console.WriteLine(building1.GetDetails());
    
    }
}
