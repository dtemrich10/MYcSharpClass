using System;

// MountainBike inheritace from bicycle
public class MountainBike : Bicycle1
{ 
   //This overrides a default constructor
   public MountainBike (string size)
   {
       base.size = size;
   }
   
   //This is a example of polymorphism
   public override void getMyBicycle()
   {
        Console.WriteLine("This is a cool Mountain Bicycle and the size is " + size);
   }

   public void setMountainBikeColor(string sColor)
   {
       setColor(sColor);
   }

   public string getMountainBikeColor()
   {
       return getColor();
   }
}