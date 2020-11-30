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

            var nav = Nav.Parse(pathToDb);
            foreach (var record in nav.Nav1Records)
            {
                Console.WriteLine($"IDENT: {record.FACILITY_IDENT}, NAME: {record.NAVAID_NAME}, FREQ: {record.FREQ}, FSS_DENT: {record.FSS_IDENT}, FSS_NAME: {record.FSS_NAME}, " +
                                  $"LAT: {record.LATITUDE} LONG: {record.LONGITUDE}");
            }

            // var ffs = Fss.Parse(pathToDb);
            // foreach (var record in ffs.FssRecords)
            // {
            //     Console.WriteLine(record);
            //     Console.Write("PRIMARY_FREQUENCIES: ");
            //     foreach (var freq in record.PRIMARY_FREQUENCIES)
            //     {
            //         if (string.IsNullOrWhiteSpace(freq))
            //             continue;
            //         Console.Write($"{freq}, ");
            //     }
            //     Console.WriteLine();
            //     
            //     Console.Write("COM_FREQUENCIES: ");
            //     foreach (var freq in record.COM_FREQUENCIES)
            //     {
            //         if (string.IsNullOrWhiteSpace(freq))
            //             continue;
            //         Console.Write($"{freq}, ");
            //     }
            //     Console.WriteLine();
            //     
            //     Console.Write("COM_OUTLETS_IDENT: ");
            //     foreach (var outlet in record.COM_OUTLETS_IDENT)
            //     {
            //         if (string.IsNullOrWhiteSpace(outlet))
            //             continue;
            //         Console.Write($"{outlet}, ");
            //     }
            //     Console.WriteLine();
            //     
            //     Console.Write("NAVAIDS_IDENT: ");
            //     foreach (var navaid in record.NAVAIDS_IDENT)
            //     {
            //         if (string.IsNullOrWhiteSpace(navaid))
            //             continue;
            //         Console.Write($"{navaid}, ");
            //     }
            //     Console.WriteLine();
            //
            //     Console.WriteLine("-------------------------------------------------");
            // }

            // var aff = Aff.Parse(pathToDb);
            // var savePath = Path.Combine(pathToDb, "ArtccFacility.csv");
            // SaveToCSV(aff.Aff1Records, savePath);
            //
            // savePath = Path.Combine(pathToDb, "ArtccRemarks.csv");
            // SaveToCSV(aff.Aff2Records, savePath);
            //
            // savePath = Path.Combine(pathToDb, "ArtccFreq.csv");
            // SaveToCSV(aff.Aff3Records, savePath);
            //
            // savePath = Path.Combine(pathToDb, "ArtccFreqRemarks.csv");
            // SaveToCSV(aff.Aff4Records, savePath);

            //var arb = Arb.Parse(pathToDb);
            //savePath = Path.Combine(pathToDb, "ArtccBoundarySegment.csv");
            //SaveToCSV(arb.Arb1Record, savePath);

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