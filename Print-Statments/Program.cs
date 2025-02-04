namespace Print_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
