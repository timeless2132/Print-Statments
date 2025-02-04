namespace Print_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //part1
            var favMovie = "THE MATRIX";
            
            Console.WriteLine("Enter a name:");
            var name = Console.ReadLine();
            
            Console.WriteLine("Hello " + name + ", your fav movie is " + favMovie);
            Console.WriteLine();
            
            bool check = favMovie.Contains("THE");
            Console.WriteLine("Var Contains 'THE': '" + check);
            Console.WriteLine();

            string replace = favMovie.Replace("A", "@").Replace("E", "3");
            Console.WriteLine(replace);
            Console.WriteLine();

            //part2
            Console.WriteLine("Enter a quote from a show: "); // i made it so they can make the quote instead cuz i didnt know any
            var quote = Console.ReadLine();

            string quoteVowelless = quote.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");

            Console.WriteLine(quoteVowelless);
            Console.WriteLine();

            //Part 3


        }
    }
}
