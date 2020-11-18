namespace NASR_Parser
{
    public class Aff2Record
    {
        [Field(04)]
        public string ArtccIdent;

        [Field(30)]
        public string SiteLocation;

        [Field(05)]
        public string FacilityType;

        [Field(04)]
        public string SiteRemarksNumber;

        [Field(200)]
        public string SiteRemarks;

        public override string ToString()
        {
            return nameof(ArtccIdent) + ArtccIdent + ", " + nameof(SiteLocation) + SiteLocation + ", " + nameof(FacilityType) + FacilityType + ", "
                + nameof(SiteRemarksNumber) + SiteRemarksNumber + ", " + nameof(SiteRemarks) + SiteRemarks;
        }
    }
}
