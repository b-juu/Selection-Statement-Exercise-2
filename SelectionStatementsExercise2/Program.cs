namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "history":
                    Console.WriteLine("history is interesting");
                    break;
                case "chemistry":
                    Console.WriteLine("i love chemistry");
                    break;
                case "english":
                    Console.WriteLine("i rarely use propper grammar");
                    break;
                case "physics":
                    Console.WriteLine("very cool");
                    break;
                case "biology":
                    Console.WriteLine("nice");
                    break;
                default:
                    Console.WriteLine("i dont know that one");
                    break;
            }
        }
    }
}
