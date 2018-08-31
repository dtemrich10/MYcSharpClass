using System;

namespace Week1.Week2
{
    public class ValueTypesContinues
    {
        #region Enums
        private enum Position {left, right, top, Bottom};
        private enum MovieType {Action = 100, Comedy = 200, Drama = 300};
        private enum Days {Sun, Mon = 8, Tue = 9, Wed = 10, Thur, Fri, Sat};

        public void EnumSample()
        {
            Console.WriteLine("Value for days not set is {0}", Days.Thur);
            Console.WriteLine("Favorite type of movie value is {0}", MovieType.Action);
        }

        #endregion 

    }
}