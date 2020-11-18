using System.IO;
using System.Reflection;

namespace NASR_Parser
{
    public static class RecordParser
    {
        public static TRecord Parse<TRecord>(StringReader reader) where TRecord : new()
        {
            var record = new TRecord();

            var recordType = typeof(TRecord);
            var recordFields = recordType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (var field in recordFields)
            {
                var fieldAttribute = field.GetCustomAttribute<FieldAttribute>();
                if (fieldAttribute == null)
                    continue;

                var fieldLength = fieldAttribute.Length;
                var valueBuffer = new char[fieldLength];
                reader.Read(valueBuffer);
                var value = new string(valueBuffer).Trim();
                field.SetValue(record, value);
            }

            return record;
        }
    }
}