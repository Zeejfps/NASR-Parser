namespace NASR_Parser
{
    public class Nav1Record
    {
        [Field(04)]
        public string IDENT;

        [Field(20)]
        public string FACILITY_TYPE;
        

        [Field(04)]
        public string OFFICIAL_FACILITY_IDENT;

        [Field(10)]
        public string DATE;
        
        [Field(30)]
        public string NAME;

        [Field(40)]
        public string NAVAID_CITY;

        [Field(30)]
        public string CITY_STATE;

        [Field(02)]
        public string CITY_STATE_CODE;

        [Field(03)]
        public string FAA_REGION;

        [Field(30)]
        public string COUNTRY;

        [Field(02)]
        public string COUNTRY_POST_CODE;

        [Field(50)]
        public string OWNER;

        [Field(50)]
        public string OPERATOR;

        [Field(01)]
        public string COMMON_SYSTEM_USAGE;
        
        [Field(01)]
        public string PUBLIC_USE;
        
        [Field(11)]
        public string CLASS;
        
        [Field(79)]
        public string __IGNORE1__;
        
        [Field(14)]
        public string LATITUDE;
        
        [Field(11)]
        public string LATITUDE_SECONDS;
        
        [Field(14)]
        public string LONGITUDE;
        
        [Field(11)]
        public string LONGITUDE_SECONDS;

        [Field(112)]
        public string __IGNORE2__;
        
        [Field(6)]
        public string FREQ;

        [Field(73)]
        public string __IGNORE3__;
        
        [Field(04)]
        public string FSS_IDENT;
        
        [Field(30)]
        public string FSS_NAME;
    }
}