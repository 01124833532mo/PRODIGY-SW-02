namespace Assement_Sw_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Guessing Game!");

            Random random = new Random();
            int numberToGuess = random.Next(1, 1001);

            int userGuess = 0;
            int attempts = 0;

            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess (between 1 and 1000): ");

                while (!int.TryParse(Console.ReadLine(), out userGuess) || userGuess < 1 || userGuess > 1000)
                {
                    Console.Write("Invalid input. Please enter a number between 1 and 1000: ");
                }


                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }

            Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {attempts} attempts.");

        }
    }
}
