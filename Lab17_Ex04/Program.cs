using System;

Animal[] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Bird();
animals[2] = new Fish();

foreach (var animal in animals)
{
    animal.Move();
    animal.Speak(); // เพิ่มการเรียก Speak()
}

interface IMovable
{
    void Move(); // ไม่ต้องใส่ public เพราะ interface method เป็น public อยู่แล้ว
}

interface ISpeakable
{
    void Speak();
}

abstract class Animal : IMovable, ISpeakable
{
    public abstract void Move();
    public abstract void Speak(); // เพิ่มเมธอด Speak()
}

class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine("Dog moves by running on the ground");
    }
    
    public override void Speak()
    {
        Console.WriteLine("Dog barks: Woof woof!");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        Console.WriteLine("Fish moves by swimming in the water");
    }

    public override void Speak()
    {
        Console.WriteLine("Fish makes bubble sounds...");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        Console.WriteLine("Bird moves by flying in the air");
    }

    public override void Speak()
    {
        Console.WriteLine("Bird chirps: Tweet tweet!");
    }
}
