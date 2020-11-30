namespace NASR_Parser
{
    public class FssRecord
    {
        [Field(04)]
        public string FSS_IDENT;
        
        [Field(26)]
        public string FSS_NAME;

        [Field(11)]
        public string DATE;

        [Field(11)]
        public string SITE_AIRPORT_NUMBER;
        
        [Field(50)]
        public string AIRPORT_NAME;

        [Field(26)]
        public string AIRPORT_CITY;
        
        [Field(20)]
        public string AIRPORT_STATE;

        [Field(14)]
        public string AIRPORT_LATITUDE;
        
        [Field(14)]
        public string AIRPORT_LONGITUDE;
        
        [Field(08)]
        public string FACILITY_TYPE;
        
        [Field(26)]
        public string FACILITY_IDENT;
        
        [Field(01)]
        public string FSS_OWNER_CODE;
        
        [Field(69)]
        public string FSS_OWNER_NAME;

        [Field(01)]
        public string FSS_OPERATOR_CODE;
        
        [Field(69)]
        public string FSS_OPERATOR_NAME;
        
        [Field(40)]
        public string[] PRIMARY_FREQUENCIES = new string[60];
        
        [Field(100)]
        public string HOURS_OF_OPERATION;
        
        [Field(20)]
        public string STATUS_OF_FACILITY;
        
        [Field(03)]
        public string CAPABILITIES;
        
        [Field(14)]
        public string[] COM_OUTLETS_IDENT = new string[40];

        [Field(07)]
        public string[] NAVAIDS_IDENT = new string[75];
        
        [Field(20)]
        public string __RESERVED_F23__;
        
        [Field(01)]
        public string HAS_WEATHER_RADAR;
        
        [Field(10)]
        public string EFAS_AVAILABLE;
        
        [Field(9800)]
        public string __IGNORE__;
        
        [Field(9)]
        public string[] COM_FREQUENCIES = new string[60];

        public override string ToString()
        {
            return $"{nameof(FSS_IDENT)}: {FSS_IDENT}, {nameof(FSS_NAME)}: {FSS_NAME}, {nameof(FACILITY_TYPE)}: {FACILITY_TYPE}, {nameof(FACILITY_IDENT)}: {FACILITY_IDENT}, {nameof(FSS_OWNER_CODE)}: {FSS_OWNER_CODE}, {nameof(FSS_OWNER_NAME)}: {FSS_OWNER_NAME}, {nameof(FSS_OPERATOR_CODE)}: {FSS_OPERATOR_CODE}, {nameof(FSS_OPERATOR_NAME)}: {FSS_OPERATOR_NAME}, {nameof(HOURS_OF_OPERATION)}: {HOURS_OF_OPERATION}, {nameof(STATUS_OF_FACILITY)}: {STATUS_OF_FACILITY}";
        }
    }
}