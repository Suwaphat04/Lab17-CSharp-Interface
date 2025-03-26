using System;

IMovable[] animals = new IMovable[3]; //  แก้ไขเป็น IMovable[]
animals[0] = new Dog();
animals[1] = new Dog();
animals[2] = new Dog();

foreach (var animal in animals)
{
    animal.Move();
}

interface IMovable
{
    void Move(); // ไม่ต้องมี public เพราะเป็นค่า default ใน interface
}

abstract class Animal : IMovable
{
    public abstract void Move(); // ต้องการ public เพราะ abstract class ต้องกำหนดการเข้าถึง
}

class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine("Dog moves by running on the ground");
    }
}
