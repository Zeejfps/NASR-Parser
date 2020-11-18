namespace NASR_Parser
{
    public class Aff4Record
    {
        [Field(04)]
        public string ArtccIdent;

        [Field(30)]
        public string SiteLocation;

        [Field(05)]
        public string FacilityType;

        [Field(08)]
        public string Frequency;

        [Field(02)]
        public string FrequencySequenceNumber;

        [Field(200)]
        public string FrequencyRemarks;

        public override string ToString()
        {
            return nameof(ArtccIdent) + ArtccIdent + ", " + nameof(SiteLocation) + SiteLocation + ", " + nameof(FacilityType) + FacilityType + ", " + nameof(Frequency) + Frequency + ", "
                + nameof(FrequencySequenceNumber) + FrequencySequenceNumber + ", " + nameof(FrequencyRemarks) + FrequencyRemarks;
        }
    }
}
