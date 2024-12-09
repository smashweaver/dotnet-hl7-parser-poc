using System;

namespace Linkworks.Document
{
	public class CM1
	{
		public string Type;
		public string Trigger;
	}
	
	public class HD
	{
		public string Name;
		public string Id;
	}
	
	public class EI
	{
		public string NamespaceId;
		public string UniversalId;
		public string UniversalIdType;
	}
	
	public class CE
	{
		public string Identifier;
		public string Text;
		public string NameOfCodingSystem;
		public string AlternateId;
		public string AlternateText;
		public string AlternateCodingSystem;
	}
	
	public class CM
	{
		public CE Specimen;
		public string Additives;
		public string Freetext;
		public CE BodySite;
		public CE SiteModifier;
		public CE CollectionMethodModifier;
	}
	
	public class CQ
	{
		public string Quantity;
		public string Unit;
	}
	
	public class CA
	{
		public string Quantity;
		public string Denomination;
	}
	
	public class CP
	{
		public CA Amount;
		public CE ChargeCode;
	}
	
	public class CR
	{
		public CE ObservationIdOfParentResult;
		public string ParentResultSubId;
		public string ResultValue;
	}
	
	public class TQ
	{
		public string _quantity;
		public string _interval;
		public string _duration;
		public string _startDateTime;
		public string _endDateTime;
		public string _priority;
	}
	
	public class XCN
	{
		public string IdHostCode;
		public string LastName;
		public string FirstName;
		public string MiddleName;
		public string Suffix;
		public string Prefix;
		public string Degree;
		public string SourceTable;
		public string AssigningAuthority;
		public string IdentifierTypeCode;
		public string AssigningFacility;
	}
	
	public class PL
	{
		public string PointOfCare;
		public string Room;
		public string Bed;
		public string FacilityId;
		public string locationStatus;
		public string PersonLocationType;
		public string Building;
		public string Floor;
		public string LocationDescription;
	}
}
