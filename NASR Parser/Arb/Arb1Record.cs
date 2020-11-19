namespace NASR_Parser
{
    public class Arb1Record
    {
        [Field(04)]
        public string ArtccIdent;
        
        [Field(03)]
        public string AltStructCode;

        [Field(05)]
        public string PointDesignator;

        [Field(40)]
        public string ArtccName;
        
        [Field(10)]
        public string AltStructName;

        [Field(14)]
        public string Latitude;
        
        [Field(14)]
        public string Longitude;

        [Field(300)]
        public string Description;
        
        [Field(06)]
        public string SequenceNumber;
        
        [Field(01)]
        public string NasDescriptionFlag;
    }
}