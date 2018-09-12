namespace Week1.Week3
{
    public class runme
    {
        static void Main(string[] args)
        {
           square yourSquare = new square{color = "blue"};
        }
    }

    public class square
    {
        public int length{get; set;}
        public int height{get; set;}
        public string color{get; set;}

        public square(){}
    }
}