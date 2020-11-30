namespace NASR_Parser
{
    public class ComRecord
    {
        [Field(4)] 
        public string IDENT;
        
        [Field(7)] 
        public string TYPE;
        
        [Field(4)] 
        public string NAVAID_IDENT;
        
        [Field(2)] 
        public string NAVAID_TYPE;
        
        [Field(26)] 
        public string NAVAID_CITY;
        
        [Field(20)] 
        public string NAVAID_STATE;
        
        [Field(26)]
        public string NAVAID_NAME;
        
        [Field(14)] 
        public string NAVAID_LATITUDE;
        
        [Field(14)] 
        public string NAVAID_LONGITUDE;
        
        [Field(26)] 
        public string CITY;
        
        [Field(20)] 
        public string STATE;
        
        [Field(20)]
        public string REGION_NAME;
        
        [Field(03)] 
        public string REGION_CODE;
        
        [Field(14)] 
        public string LATITUDE;
        
        [Field(14)] 
        public string LONGITUDE;
        
        [Field(26)] 
        public string CALL;
        
        [Field(9)] 
        public string[] FREQUENCIES = new string[16];
    }
}