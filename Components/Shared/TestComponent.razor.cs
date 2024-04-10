using System.Formats.Tar;

abstract class Animal
{
    public abstract void sound();
}

class Dog : Animal
{
    public override void sound()
    {
        Console.WriteLine("meow");
    }

}

class Cat : Dog
{
    public override void sound()
    {
        Console.WriteLine("woof");
    }

}

class FDSLKFD
{
    void main(Animal b)
    {
        Animal c = new Cat();
        b.sound();
    }

}