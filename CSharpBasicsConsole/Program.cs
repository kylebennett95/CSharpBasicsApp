namespace CSharpBasicsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UserInput taco = new UserInput();

            Console.Write("Enter your name: ");
            taco.Name = Console.ReadLine();
            
            while (string.IsNullOrWhiteSpace(taco.Name))
            {
                Console.WriteLine("Please enter a name: ");
                taco.Name = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is your favorite day of the week? ");
            taco.FavoriteDayOfWeek = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(taco.FavoriteDayOfWeek))
            {
                Console.WriteLine("Please enter a name: ");
                taco.FavoriteDayOfWeek = Console.ReadLine();
            }
            Console.Clear();
            
            Console.Write("What is your least favorite school subject? ");
            taco.LeastFavoriteSubject = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(taco.LeastFavoriteSubject))
            {
                Console.WriteLine("Please enter a name: ");
                taco.LeastFavoriteSubject = Console.ReadLine();
            }
            Console.Clear();

            string displayText = $@"
Name: {taco.Name}
Favorite Day of the Week: {taco.FavoriteDayOfWeek}
Least favorite school subject: {taco.LeastFavoriteSubject}";

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