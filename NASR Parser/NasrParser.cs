using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            // var sb = new StringBuilder();
            //
            // var nav = Nav.Parse(pathToDb);
            // sb.Append("IDENT").Append("\tNAME").Append("\tFREQ").Append("\tLATITUDE").Append("\tLONGITUDE").Append("\tFSS_IDENT").Append("\tFSS_NAME").AppendLine();
            // foreach (var record in nav.Nav1Records)
            // {
            //     // Console.WriteLine($"IDENT: {record.IDENT}, NAME: {record.NAME}, FREQ: {record.FREQ}, FSS_IDENT: {record.FSS_IDENT}, FSS_NAME: {record.FSS_NAME}, " +
            //     //                   $"LAT: {record.LATITUDE} LONG: {record.LONGITUDE}");
            //     sb.Append(record.IDENT);
            //     sb.Append('\t').Append(record.NAME);
            //     sb.Append('\t').Append(record.FREQ);
            //     sb.Append('\t').Append(ConvertDmsToDecimal(record.LATITUDE));
            //     sb.Append('\t').Append(ConvertDmsToDecimal(record.LONGITUDE));
            //     sb.Append('\t').Append(record.FSS_IDENT);
            //     sb.Append('\t').Append(record.FSS_NAME);
            //     sb.AppendLine();
            // }
            //
            // File.WriteAllText("NAVAIDS.csv", sb.ToString());
            //
            // sb.Clear();
            // sb.Append("IDENT").Append("\tFSS_IDENT").Append("\tFSS_NAME").Append("\tLATITUDE").Append("\tLONGITUDE")
            //     .Append("\tFREQ1").Append("\tFREQ2").Append("\tFREQ3").Append("\tFREQ4");
            // sb.AppendLine();
            //
            // var com = Com.Parse(pathToDb);
            // foreach (var record in com.ComRecords)
            // {
            //     if (string.IsNullOrEmpty(record.LATITUDE) || string.IsNullOrEmpty(record.LONGITUDE))
            //         continue;
            //     
            //     Console.WriteLine($"IDENT: {record.IDENT}, LAT: {record.LATITUDE}, LONG: {record.LONGITUDE}");
            //
            //     sb.Append(record.IDENT);
            //     sb.Append('\t').Append(record.FSS_IDENT);
            //     sb.Append('\t').Append(record.FSS_NAME);
            //     sb.Append('\t').Append(ConvertDmsToDecimal(record.LATITUDE));
            //     sb.Append('\t').Append(ConvertDmsToDecimal(record.LONGITUDE));
            //     sb.Append('\t').Append(record.FREQUENCIES[0]);
            //     sb.Append('\t').Append(record.FREQUENCIES[1]);
            //     sb.Append('\t').Append(record.FREQUENCIES[2]);
            //     sb.Append('\t').Append(record.FREQUENCIES[3]);
            //     sb.AppendLine();
            //
            //     Console.Write("FREQ: ");
            //     foreach (var freq in record.FREQUENCIES)
            //     {
            //         if (string.IsNullOrWhiteSpace(freq))
            //             continue;
            //         Console.Write($"{freq}, ");
            //     }
            //     Console.WriteLine();
            // }
            //
            // File.WriteAllText("FSS_COMS.csv", sb.ToString());


            var ffs = Fss.Parse(pathToDb);
            foreach (var record in ffs.FssRecords)
            {
                Console.WriteLine(record);
                
                // Console.Write("FSS_COM_FACILITIES: ");
                // foreach (var comFacilities in record.FSS_COM_FACILITIES)
                // {
                //     if (string.IsNullOrWhiteSpace(comFacilities))
                //         continue;
                //     Console.Write($"{comFacilities}, ");
                // }
                // Console.WriteLine();
                
                Console.Write("PRIMARY_FREQUENCIES: ");
                foreach (var freq in record.PRIMARY_FREQUENCIES)
                {
                    if (string.IsNullOrWhiteSpace(freq))
                        continue;
                    Console.Write($"{freq}, ");
                }
                Console.WriteLine();
                
                Console.Write($"COM_FREQUENCIES({record.COM_FREQUENCIES.Count(s => !string.IsNullOrWhiteSpace(s))}): ");
                foreach (var freq in record.COM_FREQUENCIES)
                {
                    if (string.IsNullOrWhiteSpace(freq))
                        continue;
                    Console.Write($"{freq}, ");
                }
                Console.WriteLine();
                
                Console.Write($"COM_OUTLETS_IDENT({record.COM_OUTLETS_IDENT.Count(s => !string.IsNullOrWhiteSpace(s))}): ");
                foreach (var outlet in record.COM_OUTLETS_IDENT)
                {
                    if (string.IsNullOrWhiteSpace(outlet))
                        continue;
                    Console.Write($"{outlet}, ");
                }
                Console.WriteLine();
                
                Console.Write($"NAVAIDS_IDENT({record.NAVAIDS_IDENT.Count(s => !string.IsNullOrWhiteSpace(s))}): ");
                foreach (var navaid in record.NAVAIDS_IDENT)
                {
                    if (string.IsNullOrWhiteSpace(navaid))
                        continue;
                    Console.Write($"{navaid}, ");
                }
                Console.WriteLine();
            
                Console.WriteLine("-------------------------------------------------");
            }

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

        public static double ConvertDmsToDecimal(string dmsString)
        {
            var cardinal = dmsString[dmsString.Length - 1];
            var dmsStringWithoutCardinal = dmsString.Substring(0, dmsString.Length - 1);

            var tokens = dmsStringWithoutCardinal.Split('-');
            if (tokens.Length != 3)
                throw new ArgumentException("Not proper dms format");

            var degreesStr = tokens[0];
            var minutesStr = tokens[1];
            var secondsStr = tokens[2];
            
            var degrees = double.Parse(degreesStr);
            var minutes = double.Parse(minutesStr);
            var seconds = double.Parse(secondsStr);
            var decimalDegrees = degrees + (minutes / 60.0) + (seconds / 3600.0);
            
            if (cardinal == 'S' || cardinal == 'W')
                decimalDegrees *= -1;
            
            return decimalDegrees;
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