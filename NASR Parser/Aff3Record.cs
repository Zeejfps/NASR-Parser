namespace NASR_Parser
{
	public class Aff3Record
	{
		[Field(04)]
		public string ArtccIdent;

		[Field(30)]
		public string SiteLocation;

		[Field(05)]
		public string FacilityType;

		[Field(08)]
		public string Frequency;

		[Field(10)]
		public string AltitudeLevel;

		[Field(16)]
		public string SpecialUsageName;

		[Field(01)]
		public string RcagFreqCharted;

		[Field(04)]
		public string AirportIdent;

		[Field(30)]
		public string StateName;

		[Field(02)]
		public string StatePostalCode;

		[Field(40)]
		public string CityName;

		[Field(50)]
		public string AirportName;

		[Field(14)]
		public string Latitude;

		[Field(11)]
		public string LatitudeSeconds;

		[Field(14)]
		public string Longitude;

		[Field(11)]
		public string LongitudeSeconds;

		public override string ToString()
		{
			return nameof(ArtccIdent) + ArtccIdent + ", " + nameof(SiteLocation) + SiteLocation + ", " + nameof(FacilityType) + FacilityType + ", " + nameof(Frequency) + Frequency + ", " +
				nameof(AltitudeLevel) + AltitudeLevel + ", " + nameof(SpecialUsageName) + SpecialUsageName + ", " + nameof(RcagFreqCharted) + RcagFreqCharted + ", " +
				nameof(AirportIdent) + AirportIdent + ", " + nameof(StateName) + StateName + ", " + nameof(StatePostalCode) + StatePostalCode + ", " + nameof(CityName) + CityName + ", " +
				nameof(AirportName) + AirportName + ", " + nameof(Latitude) + Latitude + ", " + nameof(LatitudeSeconds) + LatitudeSeconds + ", " +
				nameof(Longitude) + Longitude + ", " + nameof(LongitudeSeconds) + LongitudeSeconds;
		}

	}
}
