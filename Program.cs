// Madison Hutchings
// Mission 2 - Dice Counter that shows percentage of times a total num rolled is resulted from two dice
// being rolled

// the main project is called in order to access all the classes 
using Mission2_DiceCounter;

internal class Program
{
    // MAIN method that holds all the key stuff that is retrieved from and displayed to the client
    private static void Main(string[] args)
    {
        // initialize a bunch of variables to be organized and/or get ready to be used in loops or called
        int numOfRolls = 0;

        string introLine1 = "Welcome to the dice throwing simulator!";
        string introLine2 = "How many dice rolls would you like to simulate?";

        string introLine3 = "DICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.";
        string diceRollLine = "Total number of rolls = ";

        string outroLine = "Thank you for using the dice throwing simulator. Goodbye!";

        System.Console.WriteLine(introLine1 + "\n\n" + introLine2);
        
        // value retrieved from user's input
        numOfRolls = int.Parse(System.Console.ReadLine());

        // create new roll instance when user's input is retrieved
        Rolls d = new Rolls();

        // dynamically displays amount of rolls inputed by user
        System.Console.WriteLine("\n" + introLine3 + "\n" + diceRollLine + numOfRolls);

        // place method here that is connected to the dice and rolls... calls the RollTracker method
        // retrieves an array of arrays
        int[,] retrievedArray = d.RollTracker(numOfRolls);

        // use for loop to run through the array taken from what the method returned
        for (int i = 0; i < retrievedArray.GetLength(0); i++) 
        {
            string countMeter = "";

            // do math... but initializes the result to an integer in order to be used in loop below
            int percentage = (int)Math.Round(((float)retrievedArray[i, 1] / numOfRolls) * 100);

            // using the percentage to know how many astrisks should be added
            for (int j = 0; j < percentage; j++) 
            {
                countMeter += "*";
            }

            // display the histogram!
            Console.WriteLine(retrievedArray[i, 0] + ": " + countMeter);
        }

        System.Console.WriteLine("\n" + outroLine);
    }
}