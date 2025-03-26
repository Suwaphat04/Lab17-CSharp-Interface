using System;

var animal_1 = new Dog();
animal_1.Move();

IMovable animal_2 = new Dog();
animal_2.Move();

interface IMovable
{
    void Move();
}

abstract class Animal : IMovable
{
    public abstract void Move();  // กำหนดให้ Move() เป็น abstract และไม่ต้อง public ซ้ำ
}

class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine("Dog moves by running on the ground");
    }
}
