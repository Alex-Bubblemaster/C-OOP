namespace Structure
{
    using System;
    using System.Linq;

    class TestWithMain
    {
        static void Main()
        {
            //Console.WriteLine(Point3D.O);
            
            //Console.WriteLine(myPoint);
            //double distance = Distance.CalculateDistance(Point3D.O, myPoint);
            //Console.WriteLine(distance);

            var myPoint = new Point3D(3, 5, 7);
            
            Path points = new Path();
            points.AddPoint(new Point3D(2, 5, 7.56789));
            points.AddPoint(myPoint);
            points.AddPoint(Point3D.O);
            PathStorage.StorePath(points, "load.txt");
         
            
            
          
        }
    }                                       
}
