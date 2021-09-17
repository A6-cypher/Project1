using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Project1
{
    class FileCRUD
    {
        public static void Append(List<string> append, string filepath)
        {
            string[] myArr = append.ToArray();
            for(int i=0; i<myArr.Length; i++)
            {
                File.AppendAllText(filepath, $"{myArr[i]}\n");
            }

        }

        public static string[] Read(string filePath)
        {
            string[] lines =  File.ReadAllLines(filePath);
            return lines;
        }

    }
}
