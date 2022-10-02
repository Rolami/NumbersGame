namespace NumbersGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            bool spelaIgen = true;
            int guess;
            int target;
            int guesses;
            string jaNej = "";
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");

            while (spelaIgen)
            {
                guess = 0;
                guesses = 0;
                target = random.Next(1, 21);

                GuessChecker(ref guess, target, ref guesses);

                Console.WriteLine("Vill du spela igen? J/N: ");

                Omstartare(out spelaIgen, out jaNej);
            }
            Console.Clear();
            Console.WriteLine("Tack för att du spelade!");

        }


        private static void GuessChecker(ref int guess, int target, ref int guesses)
        {
            while (guess != target)
            {
                Console.WriteLine("Gissa ett tal mellan 1-20: ");
                string guessIn = Console.ReadLine();
                int.TryParse(guessIn, out guess);

                Console.WriteLine();


                if (guess < target)
                {
                    Console.WriteLine(guess + " är för lågt!");
                }
                else if (guess > target)
                {
                    Console.WriteLine(guess + " är för högt!");
                }
                if (guess == target)
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    break;
                }
                guesses++;

                if (guesses == 5)
                {
                    Console.WriteLine("Game over, 5 gissningar.");
                    break;
                }
            }
        }

        private static void Omstartare(out bool spelaIgen, out string jaNej)
        {
            jaNej = Console.ReadLine();
            jaNej = jaNej.ToUpper();

            if (jaNej == "J")
            {
                spelaIgen = true;
            }
            else
            {
                spelaIgen = false;
            }
        }
       
    }
    }
