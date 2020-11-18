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

		public override string ToString()
		{
			return nameof(ArtccIdent) + ArtccIdent + ", " + nameof(ArtccName) + ArtccName + ", " + nameof(SiteLocation) + SiteLocation + ", " + nameof(AltName) + AltName + ", " + 
                nameof(FacilityType) + FacilityType + ", " + nameof(EffectiveDate) + EffectiveDate + ", " + nameof(SiteStateName) + SiteStateName + ", " +
                nameof(SiteStateCode) + SiteStateCode + ", " + nameof(SiteLatitude) + SiteLatitude + ", " + nameof(SiteLatitudeSeconds) + SiteLatitudeSeconds + ", " +
                nameof(SiteLongitude) + SiteLongitude + ", " + nameof(SiteLongitudeSeconds) + SiteLongitudeSeconds + ", " + nameof(ArtccIcao) + ArtccIcao;
		}
	}
}