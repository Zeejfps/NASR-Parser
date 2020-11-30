using System.Collections.Generic;
using System.IO;

namespace NASR_Parser
{
    public class Nav
    {
        public List<Nav1Record> Nav1Records { get; } = new List<Nav1Record>();

        public static Nav Parse(string pathToDb)
        {
            var pathToFile = Path.Combine(pathToDb, "NAV.txt");
            var lines = File.ReadAllLines(pathToFile);

            var nav = new Nav();

            foreach (var line in lines)
            {
                using (var reader = new StringReader(line))
                {
                    var recordTypeBuffer = new char[4];
                    reader.Read(recordTypeBuffer);
                    var recordType = new string(recordTypeBuffer);

                    switch (recordType)
                    {
                        case "NAV1":
                            var nav1Record = RecordParser.Parse<Nav1Record>(reader);
                            nav.Nav1Records.Add(nav1Record);
                            break;
                    }
                }
            }

            return nav;
        }
    }
}