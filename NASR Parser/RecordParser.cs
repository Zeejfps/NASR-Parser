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
                
                if (field.FieldType.IsArray)
                    ParseValueAsArray(reader, field, fieldLength, record);
                else
                    ParseValueSingle(reader, field, fieldLength, record);
            }

            return record;
        }

        static string ReadValue(StringReader reader, int fieldLength)
        {
            var valueBuffer = new char[fieldLength];
            reader.Read(valueBuffer);
            var value = new string(valueBuffer).Trim();
            return value;
        }

        static void ParseValueAsArray(StringReader reader, FieldInfo field, int fieldLength, object record)
        {
            var fieldArray = (string[])field.GetValue(record);
            for (var i = 0; i < fieldArray.Length; i++)
                fieldArray[i] = ReadValue(reader, fieldLength);
        }

        static void ParseValueSingle(StringReader reader, FieldInfo field, int fieldLength, object record)
        {
            var value = ReadValue(reader, fieldLength);
            field.SetValue(record, value);   
        }
    }
}