namespace NASR_Parser
{
    public class Aff2Record
    {
        [Field(04)]
        public string ARTCC_IDENT;

        [Field(30)]
        public string LOCATION;

        [Field(05)]
        public string FACILITY_TYPE;

        [Field(04)]
        public string REMARKS_NUMBER;

        [Field(200)]
        public string REMARKS;

        public override string ToString()
        {
            return nameof(ARTCC_IDENT) + ARTCC_IDENT + ", " + nameof(LOCATION) + LOCATION + ", " + nameof(FACILITY_TYPE) + FACILITY_TYPE + ", "
                + nameof(REMARKS_NUMBER) + REMARKS_NUMBER + ", " + nameof(REMARKS) + REMARKS;
        }
    }
}
