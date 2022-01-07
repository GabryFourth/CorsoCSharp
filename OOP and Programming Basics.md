## Define OOP Basics
[OOP basics](https://www.indeed.com/career-advice/career-development/what-is-object-oriented-programming), [[java-oops.png]]

---

## Inheritance
_Ereditarietà_ Possibilità di creare nuove astrazioni basate su astrazioni esistenti
```csharp
class Vehicle  
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle 
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car();
    myCar.honk();
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}
```

---

## Encapsulation
_Incapsulamento_ Nascondere lo stato interno e le funzionalità di un oggetto e consentire l'accesso solo tramite un set pubblico di funzioni
```csharp
class Person
{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
```

---

## Abstraction
_Astrazione_ Modellazione degli attributi e delle interazioni pertinenti delle entità come classi per definire una rappresentazione astratta di un sistema
```csharp
// Abstract class
abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}
```

---

## Polymorphism
_Polimorfismo_ Possibilità di implementare proprietà o metodi ereditati in modi diversi tra più astrazioni
```csharp
class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}
```

---
