using Engine.Renderer;

namespace Less2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Алексей", "Усанов", "Сергеевич");
            Console.WriteLine(human.FIO());

            Cat cat = new Cat("Творожок", 6.6, true);
            cat.Meow();
            Console.WriteLine(cat.GetInfo());

            int a = 1;
            ClassA classA = new ClassA();
            classA.Add(ref a);
            Console.WriteLine(a);

            cat.Color = "зелёный";
            Console.WriteLine(cat.Color);

            Engine.Physics.Vector3D vector3D = new Engine.Physics.Vector3D();
            Vector3D vector33D = new Vector3D();

            Laptop laptop = new Laptop("Макбук", 2999, 16, 512, 5.8);
            Console.WriteLine(laptop.Info);


            Car car = new Car("12HHH25", "Шевроле", 2018, "белый");
            Console.WriteLine(car.Info);
            Console.WriteLine(car.Compare("12HHH25"));
            Console.WriteLine(car.Compare("29HPH25"));
        }
    }
    //[модификатор доступа] struct [название] {} структура

}



