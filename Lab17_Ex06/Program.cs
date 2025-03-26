Television myTV = new SonyTV();
myTV.Wattage = 100;
myTV.TurnOn();
myTV.ChannelUp();
myTV.ChannelDown();
myTV.TurnOff();

Lamp myLamp = new DesktopLamp();
myLamp.Wattage = 50;
myLamp.TurnOn();
myLamp.TurnOff();

interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
}

interface IChannelControl
{
    void ChannelUp();
    void ChannelDown();
}

abstract class PowerAppliance
{
    public bool PowerStatus;
    public int Wattage;
}

class Television : PowerAppliance, IRemoteControl, IChannelControl
{
    public int Channel { get; set; }

    public void TurnOn() { System.Console.WriteLine("TV Turn on"); PowerStatus = true; }
    public void TurnOff() { System.Console.WriteLine("TV Turn off"); PowerStatus = false; }
    public void ChannelUp() { System.Console.WriteLine("TV Channel up"); }
    public void ChannelDown() { System.Console.WriteLine("TV Channel down"); }
}

class Lamp : PowerAppliance, IRemoteControl
{
    public void TurnOn() { System.Console.WriteLine("Lamp Turn on"); PowerStatus = true; }
    public void TurnOff() { System.Console.WriteLine("Lamp Turn off"); PowerStatus = false; }
}

class SonyTV : Television { }

class DesktopLamp : Lamp { }
