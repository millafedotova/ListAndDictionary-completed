namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()

        {
            Console.WriteLine("please input person's name");
            string name = Console.ReadLine();
            bool el_exists = personList.Contains(name);

            if (el_exists)
                Console.WriteLine("sorry, this person already exists in the list");
            else
                personList.Add(name);
                
            bool key_exist = personAgeDictionary.ContainsKey(name);

            if (key_exist == false)
            {
                Console.WriteLine("please input person's age");
                int age = Console.Read();
                personAgeDictionary.Add(name, age);
                Console.WriteLine("addition is successful");
            }

            // TODO 1: Request user input for the person's name.
            // TODO 2: Validate if the person already exists in the personList.
            // TODO 3: Add the person to the personList if they don't already exist.
            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.
        }

        public static void RemovePerson()
        {
            Console.WriteLine("please input the name of the person to remove");
            string name = Console.ReadLine();
            bool el_exists = personList.Contains(name);

            if (el_exists)
            {
                personList.Remove(name);
                personAgeDictionary.Remove(name);
                Console.WriteLine("successful removal");
            }
            else
                Console.WriteLine("sorry, this person does not exist");

            // TODO 8: Request user input for the name of the person to remove.
            // TODO 9: Remove the person from personList if they exist.
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
        }

        public static void FindPerson()
        {
            Console.WriteLine("please input the name of person you want to find");
            string name = Console.ReadLine();
            bool el_exists = personList.Contains(name);
            bool key_exist = personAgeDictionary.ContainsKey(name);


            if (el_exists)
            {
                if (key_exist)
                {

                    Console.WriteLine($"this person {name} exists in list and dictionary");
                }
            }
            else
                Console.WriteLine("sorry, this person does not exist");

            // TODO 13: Request user input for the name of the person to find.
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
        }

        public static void DisplayAllPersons()
        {
            if (personList.Count > 0)
            {
                Console.WriteLine("Here are all people:");
                foreach (var person in personList)
                {
                    Console.WriteLine(person);
                }
                foreach (var person in personAgeDictionary)
                {
                    Console.WriteLine(person);
                }
            }
            else { Console.WriteLine("sorry, list and dictionary are empty"); }
            // TODO 16: Iterate over personList and display each person's name.
            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
        }
    }
}
