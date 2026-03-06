namespace okfks4_voroshilov
{
    public class Triangle : Shape
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new Exception();
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new Exception();
            SideA = sideA; 
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area()
        {

            double p = (SideA + SideB + SideC) / 2;
            double S = Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
            return S;
        }

        public override double Perimeter()
        {

            return SideA + SideB + SideC;
        }

        public override string ToString()
        {
            return $"{SideA}x{SideB}x{SideC}";
        }
    }
}
