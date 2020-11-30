using System.Collections.Generic;
using System.IO;

namespace NASR_Parser
{
    public class Fss
    {
        public List<FssRecord> FssRecords { get; } = new List<FssRecord>();

        public static Fss Parse(string pathToDb)
        {
            var pathToFile = Path.Combine(pathToDb, "FSS.txt");
            var lines = File.ReadAllLines(pathToFile);

            var fss = new Fss();

            foreach (var line in lines)
            {
                using (var reader = new StringReader(line))
                {
                    var fssRecord = RecordParser.Parse<FssRecord>(reader);
                    fss.FssRecords.Add(fssRecord);
                }
            }

            return fss;
        }
    }
}