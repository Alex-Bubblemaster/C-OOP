namespace Structure
{
    using System;
    using System.Linq;
 
    //Write a static class with a static method to calculate the distance between two points in the 3D space.
    public static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
           double xDistance = firstPoint.X - secondPoint.X;
           double yDistance = firstPoint.Y - secondPoint.Y;
           double zDistance = firstPoint.Z - secondPoint.Z;
           double distance = Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance) + (zDistance * zDistance));

           return distance; 
        }
    }
}
