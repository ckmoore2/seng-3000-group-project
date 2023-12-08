namespace Car_Whisperer.Extensions;

public static class TestExtensions
{
    static void RandomRecommendation()
    {
            // Array of words
            string[] words = { "tires", "oil", "wipers", "brakes", "batteries", "car convinces" };

            // Select a random index
            int randomIndex = GetRandomIndex(words.Length);

            // Retrieve the random word
            string randomWord = words[randomIndex];

            // Display the selected random word
            Console.WriteLine("Are you looking for  " + randomWord + "?\n Try looking at some of our " + randomWord + " selection.");
        }

        // Function to generate a random index
        private static int GetRandomIndex(int arrayLength)
        {
            Random random = new Random();
            return random.Next(arrayLength);
        }
}
