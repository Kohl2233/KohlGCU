using System.Linq;

namespace TextFileDataAccessDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\demos\test.txt";

            List<Person> people = new List<Person>();
            List<String> lines = File.ReadAllLines(filePath).ToList();

            bool isValid = true;
            for (int i = 0; i < lines.Count; i++)
            {
                String[] elements = lines[i].Split(',');
                if (elements.Length != 3) { isValid = false; }
            }
               
            if (isValid)
            {
                foreach (string line in lines)
                {
                    string[] entries = line.Split(',');
                    Person p = new Person();
                    p.FirstName = entries[0].Trim();
                    p.LastName = entries[1].Trim();
                    p.Url = entries[2].Trim();
                    people.Add(p);
                }

                // Print People
                List<String> outputLines = new List<String>();
                Console.WriteLine("Here is the list of People..");
                foreach (Person person in people)
                {
                    string personString = String.Format("First Name: {0} Last Name: {1} URL: {2}", person.FirstName, person.LastName, person.Url);
                    Console.WriteLine(personString);

                    // Output File
                    outputLines.Add(personString);

                }

                // Write to Output File
                string outpath = @"E:\demos\peopleOut.txt";
                File.WriteAllLines(outpath, outputLines);
            } else { Console.WriteLine("Errors found in file structure. Please fix and try again."); }
            


            Console.ReadLine();

        }
    }
}