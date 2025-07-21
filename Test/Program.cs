namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //تعداد افراد
            Console.WriteLine("Enter the number of people:");
            int number = Convert.ToInt32(Console.ReadLine());
            //تعریف آرایه بر اساس تعداد افراد
            Person[] People = new Person[number];
            for(int i = 0; i < number; i++)
            {
                //گرفتن اسم
                Console.WriteLine($"Enter person [{i + 1}] name: ");
                string name = Console.ReadLine();
                //گرفتن فامیلی
                Console.WriteLine($"Enter person [{i + 1}] family: ");
                string family = Console.ReadLine();
                //گرفتن سن
                Console.WriteLine($"Enter person [{i + 1}] age: ");
                int age =  Convert.ToInt32(Console.ReadLine());
                //نمونه سازی
                Person p = new Person(name, family, age);
                //نگهداری در آرایه
                People[i] = p;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (Person person in People)
            {
                Console.WriteLine($"Name: {person.name}, Family: {person.family}, Age: {person.age}");
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
