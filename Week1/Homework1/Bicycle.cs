using System;

public class Bicycle
{
    protected string size {get; set;}

    private string color;

    public virtual void getMyBicycle()
    {
        Console.WriteLine("This is a cool Bicycle and the size is " + size);
    }

    //this is an example of encapulation
    protected void setColor( string sColor )
    {
        if (sColor == "green" || sColor == "blue" )
        {
            this.color = sColor;
        }
        else
        {
            this.color = null;
            Console.WriteLine( "sorry, We don't have that color");
        }
    }

    protected string getColor()
    {
        Console.WriteLine("the color is " + color );
        return color;
    }
}