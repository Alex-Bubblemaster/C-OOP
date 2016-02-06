namespace Structure
{
    using System;
    using System.Linq;
    //Problem 1 Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    //Implement the ToString() to enable printing a 3D point.
    //Problem 2 - Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D o;

        static Point3D()                        //Problem 2 - add a static property to return the value of Point O
        {
            o = new Point3D();
        }
        public static Point3D O
        {
            get { return o; }
        }
        public Point3D(double xCoordinate, double yCoordinate, double zCoordinate) : this()  //in the structs you have to always use :this() otherwise it doesn't work
        {
            this.X = xCoordinate;
            this.Y = yCoordinate;
            this.Z = zCoordinate;
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", X, Y, Z);
        }

    }
}
