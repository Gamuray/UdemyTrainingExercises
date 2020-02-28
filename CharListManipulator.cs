using System;
using System.Collections.Generic;

namespace UdemyTrainingExercises
{
    class CharListManipulator
    {
        static void Main(string[] args)
        {
            var pointer = 0;
            var numbers = new List<char> {'a', 'b', 'c', 'd'};

            var keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Current Index: " + pointer
                    + "\n" + @"Choose an option:
Read
Next
Previous
Insert
Delete
Stop
");
                var typedString = "";
                var userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "read":
                        Console.WriteLine("\nThe value at this index is: " + numbers[pointer] + "\n");
                        break;

                    case "next":
                        pointer++;
                        break;

                    case "previous":
                        pointer--;
                        break;

                    case "insert":
                        Console.WriteLine("\nCharacter to be inserted: ");
                        typedString = Console.ReadLine().ToLower();
                        if (!String.IsNullOrEmpty(typedString))
                        {
                            var charInsert = typedString.ToCharArray();
                            numbers.Insert(pointer, charInsert[0]);
                            Console.WriteLine("Inserted " + charInsert[0] + "\n");
                        }
                        break;

                    case "delete":
                        Console.WriteLine("\nConfirm deletion (Y/N");
                        typedString = Console.ReadLine().ToLower();
                        if (typedString.Equals("y"))
                        {
                            numbers.RemoveAt(pointer);
                            Console.WriteLine("Entry Deleted\n");
                        }
                        else
                        {
                            Console.WriteLine("Entry Retained\n");
                        }
                        break;

                    default:
                        keepGoing = false;
                        break;
                }

            }







        }
    }
}
