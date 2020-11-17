namespace NASR_Parser
{
    public class Aff1Record
    {
        [Field(04)]
        public string ArtccIdent;
        
        [Field(40)]
        public string ArtccName;
        
        [Field(30)]
        public string SiteLocation;
        
        [Field(50)]
        public string AltName;

        [Field(05)]
        public string FacilityType;
        
        [Field(10)]
        public string EffectiveDate;
        
        [Field(30)]
        public string SiteStateName;
        
        [Field(02)]
        public string SiteStateCode;
        
        [Field(14)]
        public string SiteLatitude;
        
        [Field(11)]
        public string SiteLatitudeSeconds;
        
        [Field(14)]
        public string SiteLongitude;
        
        [Field(11)]
        public string SiteLongitudeSeconds;

        [Field(04)]
        public string ArtccIcao;

        public Aff1Record(string artccIdent, string artccName, string siteLocation, string altName, string facilityType, string effectiveDate, string siteStateName, string siteStateCode, string siteLatitude, string siteLatitudeSeconds, string siteLongitude, string siteLongitudeSeconds, string artccIcao)
        {
            ArtccIdent = artccIdent;
            ArtccName = artccName;
            SiteLocation = siteLocation;
            AltName = altName;
            FacilityType = facilityType;
            EffectiveDate = effectiveDate;
            SiteStateName = siteStateName;
            SiteStateCode = siteStateCode;
            SiteLatitude = siteLatitude;
            SiteLatitudeSeconds = siteLatitudeSeconds;
            SiteLongitude = siteLongitude;
            SiteLongitudeSeconds = siteLongitudeSeconds;
            ArtccIcao = artccIcao;
        }
    }
}