namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            Console.WriteLine("Enter the fruit you want to find: ");// Your program should:
            string UserInput = Console.ReadLine();
            bool found = LinearSearch(fruits, userInput);

            if (found)
            {
                    Console.WriteLine("found!");
                
            }
            else
            {
                Console.WriteLine("not found :(");
            }

        }

        static bool LinearSearch(string[] array, string userInput)

         {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == userInput)
            {
                return true;
            }
        }
        return false;
    }
}



            

            

            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
        }
    }
}
