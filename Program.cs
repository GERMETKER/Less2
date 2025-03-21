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
        }
    }
    //[модификатор доступа] struct [название] {} структура

}
