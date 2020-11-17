using System.Collections.Generic;
using System.IO;

namespace NASR_Parser
{
    public class Aff
    {
        public List<Aff1Record> Aff1Records { get; } = new List<Aff1Record>();

        public static Aff Parse(string pathToDb)
        {
            var pathToFile = Path.Combine(pathToDb, "AFF.txt");
            var lines = File.ReadAllLines(pathToFile);

            var aff = new Aff();

            foreach (var line in lines)
            {
                using (var reader = new StringReader(line))
                {
                    var recordTypeBuffer = new char[4];
                    reader.Read(recordTypeBuffer);
                    var recordType = new string(recordTypeBuffer);

                    switch (recordType)
                    {
                        case "AFF1":
                            var record = RecordParser.Parse<Aff1Record>(reader);
                            aff.Aff1Records.Add(record);
                            break;
                        case "AFF2":
                            break;
                        case "AFF3":
                            break;
                        case "AFF4":
                            break;
                    }
                }
            }
            
            return aff;
        }
    }
}