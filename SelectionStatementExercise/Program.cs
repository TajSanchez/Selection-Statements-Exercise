namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game! Give me a number between 1 and 1,000!");

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 709)
            {
                Console.WriteLine("Too low..");
            }
            else if (userInput > 709)
            {
                Console.WriteLine("Too High");
            }
            else if(userInput == 709)
            {
                Console.WriteLine("You guessed it!");
            }            
        }
    }

}
