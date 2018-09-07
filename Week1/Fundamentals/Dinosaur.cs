using System;

namespace Week1.Fundamentals
{
    public class Dinosaur
    {
        private string _teeth;
        private string _something;

        protected string Color {set; get;}

        public int Size{set; get;}

        public bool Skin {set; get;}

        public string teeth
        {
            set
            {
                this._teeth = value;
            }

            get
            {
                return this._teeth;
            }
        } 

        public virtual void Eat()
        {
            Console.WriteLine("Eat");
        }

        public class Raptor : Dinosaur
        {
            public void Group()
            {
                Color = "Brown";
            }
        }
    }

    public class TRex : Dinosaur
    {
        public void Stomp()
        {
            Color = "Blue";
        }
        public override void Eat()
        {
            Console.WriteLine("Rip");
        }
    }
}