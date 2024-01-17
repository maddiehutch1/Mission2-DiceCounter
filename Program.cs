using Mission2_DiceCounter;

internal class Program
{
    private static void Main(string[] args)
    {
        int numOfRolls = 0;

        string introLine1 = "Welcome to the dice throwing simulator!";
        string introLine2 = "How many dice rolls would you like to simulate?";

        string introLine3 = "DICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.";
        string diceRollLine = "Total number of rolls = ";

        string outroLine = "Thank you for using the dice throwing simulator. Goodbye!";

        System.Console.WriteLine(introLine1 + "\n\n" + introLine2);
        numOfRolls = int.Parse(System.Console.ReadLine());

        Rolls d = new Rolls();

        System.Console.WriteLine("\n" + introLine3 + "\n" + diceRollLine + numOfRolls);

        // place method here that is connected to the dice and rolls
        int[,] retrievedArray = d.RollTracker(numOfRolls);

        for (int i = 0; i < retrievedArray.GetLength(0); i++) 
        {
            string countMeter = "";

            int percentage = (int)Math.Round(((float)retrievedArray[i, 1] / numOfRolls) * 100);

            for (int j = 0; j < percentage; j++) 
            {
                countMeter += "*";
            }

            Console.WriteLine(retrievedArray[i, 0] + ": " + countMeter);
        }

        System.Console.WriteLine("\n" + outroLine);
    }
}