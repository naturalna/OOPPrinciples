using System;

[Version("2","11")]
class ClassVersion
{
    static void Main()
    {
        Type type = typeof(ClassVersion);
        object[] ver = type.GetCustomAttributes(false);
        foreach (VersionAttribute item in ver)
        {
            Console.WriteLine("Version : {0}.{1}",item.Major,item.Minor);
        }
    }
}

