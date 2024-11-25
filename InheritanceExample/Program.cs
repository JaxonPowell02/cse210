class Program{
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


    }
}