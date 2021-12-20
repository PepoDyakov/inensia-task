using Newtonsoft.Json;

namespace ReadJSONTask { 
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Nationality { get; set; }
            public string Sex { get; set; }
            public DateTime DateofBirth { get; set; }
        }

        static void Main(string[] args)
        {
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("input.txt"));
            foreach(var person in people)
            {
                var dob = person.DateofBirth.Year;
                var currentYear = DateTime.Now.Year;
                var age = currentYear - dob;
                Console.WriteLine("{0} {1} \n{2} \n{3} \n{4} years old \n", person.Name, person.Surname, person.Sex, person.Nationality, age);
            }
        }
    }
}