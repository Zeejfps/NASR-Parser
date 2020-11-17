using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace NASR_Parser
{
    internal class NasrParser
    {
        public static void Main(string[] args)
        {
            var pathToDb = args[0];
            Console.WriteLine($"Path to DB: {pathToDb}");

            var aff = Aff.Parse(pathToDb);
            var savePath = Path.Combine(pathToDb, "AFF.csv");
            SaveToCSV(aff.Aff1Records, savePath);
        }

        public static void SaveToCSV<TRecord>(List<TRecord> records, string savePath)
        {
            var type = typeof(TRecord);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var sb = new StringBuilder();
            for (var i = 0; i < fields.Length - 1; i++)
            {
                sb.Append(fields[i].Name).Append("\t");
            }
            sb.Append(fields[fields.Length - 1].Name);
            sb.AppendLine();
            
            foreach (var record in records)
            {
                for (var i = 0; i < fields.Length - 1; i++)
                {
                    sb.Append(fields[i].GetValue(record)).Append("\t");
                }
                sb.Append(fields[fields.Length - 1].GetValue(record));
                sb.AppendLine();
            }

            File.WriteAllText(savePath, sb.ToString());
        }
    }
}