using System;
namespace staticInstances
{
    class Circle
    {
        static float _PI;
        int _Radius;
        static Circle()
        {
            Console.WriteLine("Static Constructor Caleed");
            Circle._PI = 3.141F;

        }
        public Circle(int Radius)
        {
            _Radius = Radius;
        }
        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
        class program
        {
            public static void Main()
            {
                Circle C1 = new Circle(5);
                float Area1 = C1.CalculateArea();
                Console.WriteLine("Area = {0}", Area1);
                Circle C2 = new Circle(15);
                float Area2 = C2.CalculateArea();
                Console.WriteLine("Area = {0}", Area2);
            }
        }
    }
}