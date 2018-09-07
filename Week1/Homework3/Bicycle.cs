using System;

namespace Week1.Homework3
{

    public class Bicycle
    {
        //These are properties
        public int _iSize{ get; private set;}
        public string _sColor{ get; set;}
        public int _iSprocketCount{ get; set;} = 14;

        // this is the default constructor
        //it calls the overloaded constructor to set the defaut size
        public Bicycle() : this(27)
        { 
            this._sColor = "Green";  //default value is green
        }
 
        // this constructor is used to set the size since its private
        public Bicycle(int iSize)
        {
            this._iSize = iSize;
        }

        public void getTheBicycle()
        {
            System.Console.WriteLine("The size of this bike is " + _iSize);
            System.Console.WriteLine("The color of this bike is " + _sColor);
            System.Console.WriteLine("The sprocket count of this bike is " + _iSprocketCount);
        }
    }
}