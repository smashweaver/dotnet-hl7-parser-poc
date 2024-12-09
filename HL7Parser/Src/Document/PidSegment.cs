using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Linkworks.Document
{
	public struct CX
	{
		public string Id;
		public string CheckDigit;
		public string CodeIdentifyingCheckDigit;
		public string AssigningAuthority;
		public string IdentifierTypeCode;
	}
	
	public struct XPN
	{
		public string FamilyName;
		public string GivenName;
		public string MiddleName;
		public string Suffix;
		public string Prefix;
	}
	
	public struct XPND
	{
		public string FamilyName;
		public string GivenName;
		public string MiddleName;
		public string Suffix;
		public string Prefix;
		public string Degree;
	}
	
	public struct XAD
	{
		public string Street;
		public string Other;
		public string City;
		public string State;
		public string PostalCode;
		public string Country;
	}
	
	public class PidSegment
	{
		string _Id;
		CX _externalId;
		CX _internalId;
		CX _alternateId;
		XPN _name;
		XPND _mother;
		string _birthday;
		string _sex;
		XPN _alias;
		string _race;
		XAD _address;
		string _countryCode;
		string _homePhone;
		string _businessPhone;
		string _primaryLanguage;
		string _maritalStataus;
		string _religion;
		string _clientAccountNumber;
		string _socialSecurityNumber;
		string _driversLicenseNumber;
		string _mothersIdentifier;
		string _ethnicGroup;
		string _birthPlace;
		string _mulitpleBirthIndicator;
		string _birthOrder;
		string _citizenship;
		string _verternasMilitaryStatus;
		string _nationality;
		string _deathDateTime;
		string _deathIndicator;
		string _altPid1;
		string _altPid2;
		string _altPid3;
		string _altPid4;
		string _altPid5;
		
		public string Id
		{
			get { return _Id; }
			set { _Id = value; }
		}
		
		public CX ExternalId
		{
			get { return _externalId; }
			set { _externalId = value; }
		}
		
		public CX InternalId
		{
			get { return _internalId; }
			set { _internalId = value; }
		}
		
		public CX AlternateId
		{
			get { return _alternateId; }
			set { _alternateId = value; }
		}
		
		public XPN Name
		{
			get { return _name; }
			set { _name = value; }
		}
		
		public XPND Mother
		{
			get { return _mother; }
			set { _mother = value; }
		}
		
		public string Birthday
		{
			get { return _birthday; }
			set { _birthday = value; }
		}
		
		public string Sex
		{
			get { return _sex; }
			set { _sex = value; }
		}
		
		public XPN Alias
		{
			get { return _alias; }
			set { _alias = value; }
		}
		
		public string Race
		{
			get { return _race; }
			set { _race = value; }
		}
		
		public XAD Address
		{
			get { return _address; }
			set { _address = value; }
		}
		
		public string CountryCode
		{
			get { return _countryCode; }
			set { _countryCode = value; }
		}
		
		
		public string HomePhone
		{
			get { return _homePhone; }
			set { _homePhone = value; }
		}
		
		public string BusinessPhone
		{
			get { return _businessPhone; }
			set { _businessPhone = value; }
		}
		
		public string PrimaryLanguage
		{
			get { return _primaryLanguage; }
			set { _primaryLanguage = value; }
		}

		
		public string MaritalStataus
		{
			get { return _maritalStataus; }
			set { _maritalStataus = value; }
		}
		
		public string Religion
		{
			get { return _religion; }
			set { _religion = value; }
		}
		
		public string ClientAccountNumber
		{
			get { return _clientAccountNumber; }
			set { _clientAccountNumber = value; }
		}
		
		public string SocialSecurityNumber
		{
			get { return _socialSecurityNumber; }
			set { _socialSecurityNumber = value; }
		}
		
		public string DriversLicenseNumber
		{
			get { return _driversLicenseNumber; }
			set { _driversLicenseNumber = value; }
		}
		
		public string MothersIdentifier
		{
			get { return _mothersIdentifier; }
			set { _mothersIdentifier = value; }
		}
		
		
		public string EthnicGroup
		{
			get { return _ethnicGroup; }
			set { _ethnicGroup = value; }
		}
		
		public string BirthPlace
		{
			get { return _birthPlace; }
			set { _birthPlace = value; }
		}
		
		public string MulitpleBirthIndicator
		{
			get { return _mulitpleBirthIndicator; }
			set { _mulitpleBirthIndicator = value; }
		}
		
		public string BirthOrder
		{
			get { return _birthOrder; }
			set { _birthOrder = value; }
		}

		
		public string Citizenship
		{
			get { return _citizenship; }
			set { _citizenship = value; }
		}

		public string VerternasMilitaryStatus
		{
			get { return _verternasMilitaryStatus; }
			set { _verternasMilitaryStatus = value; }
		}

		
		public string Nationality
		{
			get { return _nationality; }
			set { _nationality = value; }
		}

		public string DeathDateTime
		{
			get { return _deathDateTime; }
			set { _deathDateTime = value; }
		}
		
		public string DeathIndicator
		{
			get { return _deathIndicator; }
			set { _deathIndicator = value; }
		}
		
		public string AltPid1 {
			get { return _altPid1; }
			set { _altPid1 = value; }
		}
		
		public string AltPid2
		{
			get { return _altPid2; }
			set { _altPid2 = value; }
		}
		public string AltPid3
		{
			get { return _altPid3; }
			set { _altPid3 = value; }
		}

		public string AltPid4
		{
			get { return _altPid4; }
			set { _altPid4 = value; }
		}

		public string AltPid5
		{
			get { return _altPid5; }
			set { _altPid5 = value; }
		}
	}

}
