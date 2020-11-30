namespace NASR_Parser
{
    public class Aff4Record
    {
        [Field(04)]
        public string ARTCC_IDENT;

        [Field(30)]
        public string LOCATION;

        [Field(05)]
        public string FACILITY_TYPE;

        [Field(08)]
        public string FREQUENCY;

        [Field(02)]
        public string FREQUENCY_SEQUENCE_NUM;

        [Field(200)]
        public string FREQUENCY_REMARKS;

        public override string ToString()
        {
            return nameof(ARTCC_IDENT) + ARTCC_IDENT + ", " + nameof(LOCATION) + LOCATION + ", " + nameof(FACILITY_TYPE) + FACILITY_TYPE + ", " + nameof(FREQUENCY) + FREQUENCY + ", "
                + nameof(FREQUENCY_SEQUENCE_NUM) + FREQUENCY_SEQUENCE_NUM + ", " + nameof(FREQUENCY_REMARKS) + FREQUENCY_REMARKS;
        }
    }
}
