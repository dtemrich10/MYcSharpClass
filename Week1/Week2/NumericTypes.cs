using System;

namespace MYCSHARPCLASS.Week2
{
    public class NumbericTypes
    {
        #region Integral - Signed
        private sbyte _mySbyteValue = 2;
        private short _myShortValue = 4;
        private int _myIntValue = 2500;
        private long _myLongValue = 1_234_567;
        private long _myLongValue2 = 0x5f;
        #endregion

        #region Integral - UnSigned
        private byte _myByteValue = 3;
        private ushort _myUshortValue = 35;
        private uint _myUintValue = 2345U;
        private ulong _myUlongValue = 1234U;
        #endregion

        #region real
        private float _myFloatValue = 123.6589F;
        private double _myDoubleValue = 12.34D;
        private double _myDoubleValue2 = 1E06;
        private double _myDoubleValue3 = 12.34;
        private decimal _myDecimalValue = 12.234M;
        #endregion

        public void ConvertFloatToInt()
        {
            int converted = (int)_myFloatValue;
        }

        public void LongFromInt()
        {
            long somevalue = _myIntValue;
        }
        public void IncrementDecrement()
        {
            int myVal = 1, myOtherVal = 10;
            Console.WriteLine(myVal++);
            Console.WriteLine(myOtherVal - 1);
            Console.WriteLine(--myVal);
            Console.WriteLine(++myOtherVal);
        }

        public void GetSomeTypes()
        {
            Console.WriteLine(3.0.GetTypeCode());
            Console.WriteLine(_myFloatValue.GetTypeCode());
        }

        public void BasicMath()
        {
            int myVal = 5, myOther = 10;
            int addVal = myVal + myOther;
            int subtracVal = myOther - myVal;
            int multilyVal = myOther * myVal;
            int divisionVal = myVal / myOther;

            int total = (addVal * multilyVal) - divisionVal;

            Console.WriteLine(addVal);
        }

        public void CheckOperatorTyp()
        {
            int val = 100, val2 = 100;
            int testValue = checked(val * val2);
        }

        public void SpecialValues()
        {
            Console.WriteLine(2.0/0.0);
            Console.WriteLine(-2.0/0.0);
            Console.WriteLine(2.0 / -0.0);
            Console.WriteLine(-2.0 / -0.0);
            Console.WriteLine(0.0/0.0);
            Console.WriteLine((2.0 / -0.0) - (2.0 / 0.0));
            Console.WriteLine(0.0 / -0.0 == double.NaN);
            Console.WriteLine(double.IsNaN(0.0/0.0));
            Console.WriteLine(object.Equals(0.0/0.0, double.NaN));
        }
        
    }

}