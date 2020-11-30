namespace NASR_Parser
{
    public class Aff1Record
    {
        [Field(04)]
        public string ARTCC_IDENT;

        [Field(40)]
        public string ARTCC_NAME;

        [Field(30)]
        public string LOCATION;

        [Field(50)]
        public string ALT_NAME;

        [Field(05)]
        public string FACILITY_TYPE;

        [Field(10)]
        public string EFFECTIVE_DATE;

        [Field(30)]
        public string STATE_NAME;

        [Field(02)]
        public string STATE_CODE;

        [Field(14)]
        public string LATITUDE;

        [Field(11)]
        public string LATITUDE_SECONDS;

        [Field(14)]
        public string LONGITUDE;

        [Field(11)]
        public string LONGITUDE_SECONDS;

        [Field(04)]
        public string ARTCC_ICAO;

        public override string ToString()
        {
            return nameof(ARTCC_IDENT) + ARTCC_IDENT + ", " + nameof(ARTCC_NAME) + ARTCC_NAME + ", " + nameof(LOCATION) + LOCATION + ", " + nameof(ALT_NAME) + ALT_NAME + ", " +
                nameof(FACILITY_TYPE) + FACILITY_TYPE + ", " + nameof(EFFECTIVE_DATE) + EFFECTIVE_DATE + ", " + nameof(STATE_NAME) + STATE_NAME + ", " +
                nameof(STATE_CODE) + STATE_CODE + ", " + nameof(LATITUDE) + LATITUDE + ", " + nameof(LATITUDE_SECONDS) + LATITUDE_SECONDS + ", " +
                nameof(LONGITUDE) + LONGITUDE + ", " + nameof(LONGITUDE_SECONDS) + LONGITUDE_SECONDS + ", " + nameof(ARTCC_ICAO) + ARTCC_ICAO;
        }
    }
}