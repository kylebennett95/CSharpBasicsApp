namespace CSharpBasicsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a name: ");
                name = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is your favorite day of the week? ");
            string? dayOfWeek = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(dayOfWeek))
            {
                Console.WriteLine("Please enter a name: ");
                dayOfWeek = Console.ReadLine();
            }
            Console.Clear();
            
            Console.Write("What is your least favorite school subject? ");
            string? leastFaveSubject = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(leastFaveSubject))
            {
                Console.WriteLine("Please enter a name: ");
                leastFaveSubject = Console.ReadLine();
            }
            Console.Clear();

            string displayText = $@"
Name: {name}
Favorite Day of the Week: {dayOfWeek}
Least favorite school subject: {leastFaveSubject}";

            Console.Write(displayText);








            //string input = "";

            //while (input == "" || input.StartsWith("QQ"))
            //{
            //    Console.WriteLine("enter your name: ");
            //    Console.WriteLine("you need to type a real name.");
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Hello, {input}.");
        }
    }
}