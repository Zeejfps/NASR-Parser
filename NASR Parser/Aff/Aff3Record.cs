namespace NASR_Parser
{
    public class Aff3Record
    {
        [Field(04)]
        public string ARTCC_IDENT;

        [Field(30)]
        public string LOCATION;

        [Field(05)]
        public string FACILITY_TYPE;

        [Field(08)]
        public string FREQUENCY;

        [Field(10)]
        public string ALTITUDE_LEVEL;

        [Field(16)]
        public string SPECIAL_USAGE_NAME;

        [Field(01)]
        public string RCAG_FREQ_CHARTED;

        [Field(04)]
        public string AIRPORT_IDENT;

        [Field(30)]
        public string STATE_NAME;

        [Field(02)]
        public string STATE_CODE;

        [Field(40)]
        public string CITY_NAME;

        [Field(50)]
        public string AIRPORT_NAME;

        [Field(14)]
        public string LATITUDE;

        [Field(11)]
        public string LATITUDE_SECONDS;

        [Field(14)]
        public string LONGITUDE;

        [Field(11)]
        public string LONGITUDE_SECONDS;

        public override string ToString()
        {
            return nameof(ARTCC_IDENT) + ARTCC_IDENT + ", " + nameof(LOCATION) + LOCATION + ", " + nameof(FACILITY_TYPE) + FACILITY_TYPE + ", " + nameof(FREQUENCY) + FREQUENCY + ", " +
                nameof(ALTITUDE_LEVEL) + ALTITUDE_LEVEL + ", " + nameof(SPECIAL_USAGE_NAME) + SPECIAL_USAGE_NAME + ", " + nameof(RCAG_FREQ_CHARTED) + RCAG_FREQ_CHARTED + ", " +
                nameof(AIRPORT_IDENT) + AIRPORT_IDENT + ", " + nameof(STATE_NAME) + STATE_NAME + ", " + nameof(STATE_CODE) + STATE_CODE + ", " + nameof(CITY_NAME) + CITY_NAME + ", " +
                nameof(AIRPORT_NAME) + AIRPORT_NAME + ", " + nameof(LATITUDE) + LATITUDE + ", " + nameof(LATITUDE_SECONDS) + LATITUDE_SECONDS + ", " +
                nameof(LONGITUDE) + LONGITUDE + ", " + nameof(LONGITUDE_SECONDS) + LONGITUDE_SECONDS;
        }

    }
}
