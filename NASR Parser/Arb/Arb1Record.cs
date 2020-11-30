namespace NASR_Parser
{
    public class Arb1Record
    {
        [Field(04)]
        public string ARTCC_IDENT;
        
        [Field(03)]
        public string ALT_STRUCT_CODE;

        [Field(05)]
        public string POINT_DESIGNATOR;

        [Field(40)]
        public string ARTCC_NAME;
        
        [Field(10)]
        public string ALT_STRUCT_NAME;

        [Field(14)]
        public string LATITUDE;
        
        [Field(14)]
        public string LONGITUDE;

        [Field(300)]
        public string DESCRIPTION;
        
        [Field(06)]
        public string SEQUENCE_NUMBER;
        
        [Field(01)]
        public string NAS_DESCRIPTION_FLAG;
    }
}