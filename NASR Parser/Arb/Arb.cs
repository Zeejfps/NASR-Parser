using System.Collections.Generic;
using System.IO;

namespace NASR_Parser
{
    public class Arb
    {
        public List<Arb1Record> Arb1Record { get; } = new List<Arb1Record>();

        public static Arb Parse(string pathToDb)
        {
            var pathToFile = Path.Combine(pathToDb, "ARB.txt");
            var lines = File.ReadAllLines(pathToFile);

            var arb = new Arb();

            foreach (var line in lines)
            {
                using (var reader = new StringReader(line))
                {
                    var arb1 = RecordParser.Parse<Arb1Record>(reader);
                    arb.Arb1Record.Add(arb1);
                }
            }

            return arb;
        }
    }
}