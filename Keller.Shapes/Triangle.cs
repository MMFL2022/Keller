using System;

namespace Keller
{
    class Triangle : IShape
    {
        #region Private Fields
        float sideA;
        float sideB;
        float sideC;
        #endregion

        #region Public Properties
        public float SideA
        {
            get { return sideA; }
        }
        public float SideB
        {
            get { return sideB; }
        }
        public float SideC
        {
            get { return sideC; }
        }
        #endregion

        #region Constructor
        public Triangle(float sideA, float sideB, float sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        #endregion

        #region Public Methods
        public float Area()
        {
            // Heron's Formula
            // Sqrt(s(s-a)(s-b)(s-c))
            var s = Perimeter() / 2;
            var a = s - sideA;
            var b = s - sideB;
            var c = s - sideC;
            return (float)Math.Sqrt(s*a*b*c);
        }

        public float Perimeter()
        {
            // perimeter = sideA + sideB + sideC
            return sideA + sideB + sideC;
        }

        public float Height()
        {
            // height = 2 * Area / base
            return 2f * Area() / sideB;
        }
        #endregion
    }
}
