abstract class Animal
{
    // Property
    public abstract string Name { get; set; }
    // Methods
    public abstract string Describe();
    public string whatAmI()
    {
        return "I am an animal";
    }
}
class Program
{
    class Dog : Animal
    {
        public override string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }   

        public Dog()
        {
            Name = string.Empty;
            Breed = string.Empty;
        }
        public Dog(string name, string breed, string color)
        {
            Name = name;
            Breed = breed;
            Color = color;
        }
        
        public override string Describe()
        {
            return "I am a dog." + "\nMy name is " + Name + "." + "\nMy breed is " + Breed + "." + "\nI am the color " + Color + ".";
        }

    }
    static void Main(string[] args)
    {
        
        Dog scooby = new Dog();
        scooby.Name = "Scooby";
        scooby.Breed = "Great Dane";
        scooby.Color = "Brown";
        Console.WriteLine(scooby.whatAmI());
        Console.WriteLine(scooby.Describe());

        Dog snoopy = new Dog("Snoopy", "Beagle", "White");
        Console.WriteLine();
        Console.WriteLine(snoopy.whatAmI());
        Console.WriteLine(snoopy.Describe());
    }
}