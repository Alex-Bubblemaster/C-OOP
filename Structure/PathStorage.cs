namespace Structure
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class PathStorage
    {
        public static Path LoadPath(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            Path result = new Path();
            using (reader)
            {
                string line = "default";
               
                while (line != null)
                {
                   line = reader.ReadLine();
                   var pointsAsString = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                   for (int i = 0; i < pointsAsString.Length; i++)
                   {
                       var pointValues = pointsAsString[i].Split("|".ToCharArray()).Select(float.Parse).ToList();
                       var currentPoint = new Point3D(pointValues[0], pointValues[1], pointValues[2]);
                       result.AddPoint(currentPoint);
                   }
                }
            }
            return result;
        }
        public static void StorePath(Path points, string filename)
        {
            StreamWriter writer = new StreamWriter(filename, true, Encoding.ASCII);

            using (writer)
            {
                writer.WriteLine(points.ToString());
            }
        }
    }
}
