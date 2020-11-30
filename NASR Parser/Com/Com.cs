using System.Collections.Generic;
using System.IO;

namespace NASR_Parser
{
    public class Com
    {
        public List<ComRecord> ComRecords { get; } = new List<ComRecord>();

        public static Com Parse(string pathToDb)
        {
            var pathToFile = Path.Combine(pathToDb, "COM.txt");
            var lines = File.ReadAllLines(pathToFile);

            var com = new Com();

            foreach (var line in lines)
            {
                using (var reader = new StringReader(line))
                {
                    var fssRecord = RecordParser.Parse<ComRecord>(reader);
                    com.ComRecords.Add(fssRecord);
                }
            }

            return com;
        }
    }
}