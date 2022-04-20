using System.Linq;

public class Program
{
    public static void Main()
    {
        //StudentInfo stuInfo = new StudentInfo("Amber", "Steak", "Grand Rapids", "Red", "Bunny");
        //Console.WriteLine(stuInfo.name);

        //string[] name = { "Barbara", "Jean", "Bennett", "Noelle", "Amber" };
        //string[] food = { "Seafood", "Soup", "Fried Egg", "Pancakes", "Steak" };
        //string[] hometown = { "New York", "London", "Los Angeles", "Grand Rapids", "Toldeo" };
        List<string> name = new List<string>() { "Barbara", "Jean", "Bennett", "Noelle", "Amber" };
        List<string> food = new List<string>() { "Seafood", "Soup", "Fried Egg", "Pancakes", "Steak" };
        List<string> hometown = new List<string>() { "New York", "London", "Los Angeles", "Grand Rapids", "Toldeo" };
        List<string> color = new List<string>() { "Blue", "Green", "Orange", "Gold", "Red" };
        List<string> animal = new List<string> { "Fish", "Cat", "Wolf", "Weasel", "Bunny" };
        //Console.WriteLine("Welcome! Which student would you like to learn about? Enter a number 1-5: ");
        List<string> sorted = (List<string>)name.OrderByDescending(name => name.ToList());

        bool runAgain = true;
        while (runAgain)
        {
            int input = 0;
            while (true)
            {
                Console.WriteLine("Welcome! Which student would you like to learn about? Enter a number 1-5: ");
                for (int i = 0; i < name.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {name[i]}");
                }
                string student = Console.ReadLine();
                if (name.Contains(name[input]))
                {
                    break;
                }
                input = int.Parse(student) - 1;
                if (input >= 0 && input < name.Count)
                {
                    break;
                }
                //string Name = Console.ReadLine();
                //else if (names.Contains(Name))
                //{
                //    input = Array.IndexOf([names], Name);
                //    break;
                //}
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand.");
                }
            }
            while (true)
            {
                Console.WriteLine($"What would you like to know? Enter 'hometown' or 'favourite food': ");
                string character = Console.ReadLine();
                //if(character,ToLower() == "hometown" && "home")
                //{
                //  Console.WriteLine($"{name[input]}'s hometown is {homwtown[inpuut]}");
                //break;
                //}
                //else if(character,ToLower() == "food" && "favourite food")
                //{
                //  Console.WriteLine($"{name[input]}'s favourite food is {food[inpuut]}");
                //break;
                //}
                if (character.ToUpper() == "hometown" || character.ToUpper() == "home")
                {
                    Console.WriteLine($"Their hometown is: {hometown[input]}");
                    break;
                }
                else if (character.ToUpper() == "favorite food" || character.ToUpper() == "food")
                {
                    Console.WriteLine($"Their favourite food is: {food[input]}");
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand");
                }
            }
            while (true)
            {
                Console.WriteLine("Would you like to learn about another student? Enter (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToUpper().Trim() == "y")
                {
                    runAgain = true;
                    break;
                }
                else if (answer.ToUpper() == "n")
                {
                    Console.WriteLine("Good bye!");
                    runAgain = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand.");
                }
            }
        }
    }
}