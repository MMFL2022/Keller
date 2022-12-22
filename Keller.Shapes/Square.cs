namespace Keller
{
    class Square : IShape
    {
        #region Private Fields
        float length;
        float width;
        #endregion

        #region Public Properties
        public float Length
        {
            get { return length; }
        }
        public float Width
        {
            get { return width; }
        }
        #endregion

        #region Constructor
        public Square(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        #endregion

        #region Public Methods
        public float Area()
        {
            // area = Length * Width
            return length * width;
        }

        public float Perimeter()
        {
            // perimeter = (Length * 2) + (Width * 2)
            return (length * 2) + (width * 2);
        }
        #endregion
    }
}
