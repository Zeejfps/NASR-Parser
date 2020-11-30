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
            var savePath = Path.Combine(pathToDb, "ArtccFacility.csv");
            SaveToCSV(aff.Aff1Records, savePath);

            savePath = Path.Combine(pathToDb, "ArtccRemarks.csv");
            SaveToCSV(aff.Aff2Records, savePath);

            savePath = Path.Combine(pathToDb, "ArtccFreq.csv");
            SaveToCSV(aff.Aff3Records, savePath);

            savePath = Path.Combine(pathToDb, "ArtccFreqRemarks.csv");
            SaveToCSV(aff.Aff4Records, savePath);

            var arb = Arb.Parse(pathToDb);
            savePath = Path.Combine(pathToDb, "ArtccBoundarySegment.csv");
            SaveToCSV(arb.Arb1Record, savePath);

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