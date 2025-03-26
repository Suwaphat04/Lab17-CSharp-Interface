using System;

interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void ChannelUp();
    void ChannelDown();
}

abstract class PowerAppliance
{
    public bool PowerStatus { get; set; }
    public int Wattage { get; set; }
}

class Television : PowerAppliance
{
    public int Channel { get; set; }
}

class Lamp : PowerAppliance
{
    // No need for Channel properties or methods here, as it doesn't have channels.
}

class SonyTV : Television, IRemoteControl
{
    public void TurnOn() 
    {
        Console.WriteLine("TV Turn on");
        PowerStatus = true;
    }
    public void TurnOff() 
    {
        Console.WriteLine("TV Turn off");
        PowerStatus = false;
    }
    public void ChannelUp() 
    {
        Console.WriteLine("TV Channel up");
        Channel++;
    }
    public void ChannelDown() 
    {
        Console.WriteLine("TV Channel down");
        Channel--;
    }
}

class DesktopLamp : Lamp, IRemoteControl
{
    public void TurnOn() 
    {
        Console.WriteLine("Lamp Turn on");
        PowerStatus = true;
    }
    public void TurnOff() 
    {
        Console.WriteLine("Lamp Turn off");
        PowerStatus = false;
    }
    public void ChannelUp() 
    {
        Console.WriteLine("Lamp cannot change channel");
    }
    public void ChannelDown() 
    {
        Console.WriteLine("Lamp cannot change channel");
    }
}

class Program
{
    static void Main()
    {
        var myTV = new SonyTV();
        myTV.Wattage = 100;
        myTV.TurnOn();
        myTV.ChannelUp();
        myTV.ChannelDown();
        myTV.TurnOff();

        var myLamp = new DesktopLamp();
        myLamp.Wattage = 50;
        myLamp.TurnOn();
        myLamp.ChannelUp();
        myLamp.ChannelDown();
        myLamp.TurnOff();
    }
}
