namespace Assignment_3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = "This is a test string";
            Console.WriteLine(stringInput);
            char spaceChar = ' ';
            int spaceCount = 0;
            foreach(char c in stringInput)
            {
                if (c == spaceChar)
                {
                    spaceCount++;
                }
            }
            Console.WriteLine(stringInput + " contains " + spaceCount + " spaces.");
        }
        
    }
}
