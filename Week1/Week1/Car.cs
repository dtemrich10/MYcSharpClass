using System;

public class Car : Vehicle
{
    public override void closeWindow()
    {
        Console.WriteLine("My Window is open");
    }
}