using System.Collections.Generic;
using System.IO;

namespace NASR_Parser
{
    public class Aff
    {
        public List<Aff1Record> Aff1Records { get; } = new List<Aff1Record>();
        public List<Aff2Record> Aff2Records { get; } = new List<Aff2Record>();
        public List<Aff3Record> Aff3Records { get; } = new List<Aff3Record>();
        public List<Aff4Record> Aff4Records { get; } = new List<Aff4Record>();

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
                            var aff1 = RecordParser.Parse<Aff1Record>(reader);
                            aff.Aff1Records.Add(aff1);
                            break;
                        case "AFF2":
                            var aff2 = RecordParser.Parse<Aff2Record>(reader);
                            aff.Aff2Records.Add(aff2);
                            break;
                        case "AFF3":
                            var aff3 = RecordParser.Parse<Aff3Record>(reader);
                            aff.Aff3Records.Add(aff3);
                            break;
                        case "AFF4":
                            var aff4 = RecordParser.Parse<Aff4Record>(reader);
                            aff.Aff4Records.Add(aff4);
                            break;
                    }
                }
            }

            return aff;
        }
    }
}