using System;
using System.IO;

namespace NASR_Parser
{
    public static class Extensions
    {
        public static void Read(this StringReader reader, char[] buffer)
        {
            var numCharsRead = reader.Read(buffer, 0, buffer.Length);
            if (numCharsRead != buffer.Length)
                throw new Exception("Failed to read the specified amount of characters!");
        }
    }
}