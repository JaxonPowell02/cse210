class Program{

    public static void SetPersonFirstName(Person person, string firstName)
    {
        person.SetFirstName(firstName);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey Bob");
        Person bob = new Person("Bob", "Billy", 37);
        Person betty = new("betty", "billy", 39);

        Console.WriteLine(bob.GetPersonInfo());
        Console.WriteLine(betty.GetPersonInfo());

        Doctor doctorBob = new Doctor("Bob", "Budge", 65, "Hack Saw");
        Console.WriteLine(doctorBob.GetDoctorInformation());
        Console.WriteLine(doctorBob.GetPersonInfo());

        SetPersonFirstName(doctorBob, "Doug the second");
        Console.WriteLine(doctorBob.GetPersonInfo());
        
        SetPersonFirstName(bob, "Bobby");
        Console.WriteLine(bob.GetPersonInfo());

        List<Person> people = new List<Person>();
        people.Add(bob);
        people.Add(betty);
        people.Add(doctorBob);
        
        foreach(Person person in people)
        {
            Console.WriteLine(person.GetPersonInfo());
        }

    }

}