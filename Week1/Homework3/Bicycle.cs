using System;

namespace Week1.Homework3
{
   public class runme
   {
   //     static void Main(string[] args)
   public void main4()
        {

            Bicycle bi = new Bicycle(50);
          //  bi._iSize = 29;
            int size = bi._iSize;
            string s = bi._sColor;
            bi._sColor ="brown";
            bi.setTheCustomPropertyFeature("Color of Wheels", "Blue");
            bi.setTheCustomPropertyValue("Size of seat", 8);
            bi.getTheBicycle();
        }
   } 

    public class Bicycle
    {
        private CustomOptions<int> _coValues = new CustomOptions<int>();
        private CustomOptions<string> _cofeatures = new CustomOptions<string>();

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
            getTheCustomPropertyValue();
            getTheCustomPropertyFeature();
        }

        public void setTheCustomPropertyValue(string sDesc, int iValue)
        {
            _coValues._desc = sDesc;
            _coValues._option = iValue;
        }

        public void setTheCustomPropertyFeature(string sDesc, string sFeature)
        {
            _cofeatures._desc = sDesc;
            _cofeatures._option = sFeature;
        }

        public void getTheCustomPropertyValue()
        {
            System.Console.WriteLine("This bike has a custome property called " + _coValues._desc + " that is " + _coValues._option);
        }
        public void getTheCustomPropertyFeature()
        {
            System.Console.WriteLine("This bike has a custome property called " + _cofeatures._desc + " that's value is " + _cofeatures._option);
        }
    }
    //this is an example of of generics
    public class CustomOptions<T>
    {
        public string _desc{set;get;}
        public T _option{set; get;}
        
        public CustomOptions()
        {
        }

        CustomOptions (string desc, T option)
        {
            _desc = desc;
            _option = option;
        }

    }
}
