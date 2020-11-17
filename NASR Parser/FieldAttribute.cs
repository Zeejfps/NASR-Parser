using System;

namespace NASR_Parser
{
    public class FieldAttribute : Attribute
    {
        public int Length { get; }

        public FieldAttribute(int length)
        {
            Length = length;
        }
    }
}