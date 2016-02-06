namespace Version
{
    using System;
    using System.Linq;

    class TestMain
    {
        [Version(0, 234)]
        class TestAttribute
        {
            static void Main()
            {
                var type = typeof(TestAttribute);

                var attributes = type.GetCustomAttributes(false);

                foreach (VersionAttribute item in attributes)
                {
                    Console.WriteLine("Version {0}", item.Version);
                }
            }
        }
    }
}
