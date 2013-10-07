//ex4 Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public static class PathStorage
{
    static string dataPath = @"../../test.txt";
    public static void SaveData(Path dataForAdd)
    {
        
        FileStream fileStream = new FileStream(dataPath, FileMode.Create,FileAccess.ReadWrite);
        using (fileStream)
        {
            StreamWriter streamWrite = new StreamWriter(fileStream);// using files <- path = filename.The file must be open ones
            using (streamWrite)
            {
                foreach (var item in dataForAdd.Points)
                {
                    streamWrite.Write("[");
                    streamWrite.Write(item);
                    streamWrite.Write("]");
                    streamWrite.WriteLine();
                }
            }
        }  
    }
    public static Path LoadData()
    {
        StreamReader reader = new StreamReader(dataPath);
        Path newPath = new Path();
        using (reader)
        {
            //firsl line of the file
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] clearFormat = line.Split(new char[] {'[',']',','});//removing formats
                // list to hold point coordinats
                List<short> pointCoord = new List<short>();
                for (int i = 0; i < clearFormat.Length; i++)
                {
                    if (clearFormat[i] != "")
                    {
                        pointCoord.Add(short.Parse(clearFormat[i]));
                    }
                }
                //creating the point
                Point3D pointForAdd = new Point3D(pointCoord[0],pointCoord[1],pointCoord[2]);
                //adding point in the path
                newPath.AddInPath(pointForAdd);
                //taking the next line in the file
                line = reader.ReadLine();
            }
            return newPath;
        }
    }
}

