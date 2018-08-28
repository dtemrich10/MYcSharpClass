using System;
public class Vehicle
{
     private string _color;
    public string Color
    {
          get {
              return _color;
          }
          set {
              Console.WriteLine( value );
              this._color = value;
          }
    }

    public string wheeltype {get; set;}
    public void OpenDoor()
    {
        Console.WriteLine("Door is opened");
    }

    public virtual void closeWindow()
    {
        Console.WriteLine("Window is closed");
    }
}