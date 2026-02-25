namespace okfks4_voroshilov
{
    public class Triangle : Shape
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA; 
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                throw new Exception();

            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
                throw new Exception();

            double p = (SideA + SideB + SideC) / 2;
            double S = Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
            return S;
        }

        public override double Perimeter()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                throw new Exception();

            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
                throw new Exception();

            return SideA + SideB + SideC;
        }

        public override string ToString()
        {
            return $"{SideA}x{SideB}x{SideC}";
        }
    }
}
