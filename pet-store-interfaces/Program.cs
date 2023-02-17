
using pet_store_interfaces;

IPet[] pets = new IPet[] {
    new Dog(){Name = "Fido" },
    new Cat() {Name = "Felix" },
    new Duck() {Name = "Donald" },
    new Cow() {Name = "Daisy" },
    new Pig() {Name = "Porky "}
};

foreach(var pet in pets) {
    Console.WriteLine($"{pet.Name} says {pet.Speak()}");
}