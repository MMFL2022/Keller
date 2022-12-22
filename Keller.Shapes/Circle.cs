using System;

namespace Keller
{
    class Circle : IShape
    {
        #region Private Fields
        float radius;
        #endregion

        #region Public Properties
        public float Radius
        {
            get { return radius; }
        }
        #endregion

        #region Constructor
        public Circle(float radius)
        {
            this.radius = radius;
        }
        #endregion

        #region Public Methods
        public float Area()
        {
            // area = Pi (radius * radius)
            return (float)Math.PI * (radius * radius);
        }

        public float Perimeter()
        {
            // circumference = 2 * Pi * radius
            return 2 * (float)Math.PI * radius;
        }

        public float Diameter()
        {
            // diameter = 2 * radius
            return 2 * radius;
        }
        #endregion
    }
}
