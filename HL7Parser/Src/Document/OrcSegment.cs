using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Linkworks.Document
{
	
	
	public class OrcSegment
	{
		string _orderControl;
		string _placerOrderNumber;
		string _fillerOrderNumber;
		string _placerGroupNumber;
		string _orderStatus;
		string _responseFlag;
		TQ _quantityTiming;
		string _parent;
		string _transactionDateTime;		
		XCN _enteredBy;
		XCN _verifiedBy;
		XCN _orderingProvider;
		PL _enteringOrderingLocation;
		string _callbackPhoneNumber;	// 2 repeats
		string _orderEffectiveDateTime;
		string _orderControlCodeReason;
		string _enteringOrganization;
		string _enteringDevice;
		XCN _actionBy;		
		
		public string OrderControl
		{
			get { return _orderControl; }
			set { _orderControl = value; }
		}
		
		public string PlacerOrderNumber
		{
			get { return _placerOrderNumber; }
			set { _placerOrderNumber = value; }
		}
		public string FillerOrderNumber
		{
			get { return _fillerOrderNumber; }
			set { _fillerOrderNumber = value; }
		}

		public string PlacerGroupNumber
		{
			get { return _placerGroupNumber; }
			set { _placerGroupNumber = value; }
		}
		
		public string OrderStatus
		{
			get { return _orderStatus; }
			set { _orderStatus = value; }
		}
		
		public string ResponseFlag
		{
			get { return _responseFlag; }
			set { _responseFlag = value; }
		}
		
		public TQ QuantityTiming
		{
			get { return _quantityTiming; }
			set { _quantityTiming = value; }
		}
		
		public string Parent
		{
			get { return _parent; }
			set { _parent = value; }
		}

		public string TransactionDateTime
		{
			get { return _transactionDateTime; }
			set { _transactionDateTime = value; }
		}

		public XCN EnteredBy
		{
			get { return _enteredBy; }
			set { _enteredBy = value; }
		}		
		
		public XCN VerifiedBy
		{
			get { return _verifiedBy; }
			set { _verifiedBy = value; }
		}
		
		
		public XCN OrderingProvider
		{
			get { return _orderingProvider; }
			set { _orderingProvider = value; }
		}		
		
		public PL EnteringOrderingLocation
		{
			get { return _enteringOrderingLocation; }
			set { _enteringOrderingLocation = value; }
		}
		
		
		public string CallbackPhoneNumber
		{
			get { return _callbackPhoneNumber; }
			set { _callbackPhoneNumber = value; }
		}		
		
		public string OrderEffectiveDateTime
		{
			get { return _orderEffectiveDateTime; }
			set { _orderEffectiveDateTime = value; }
		}		
		
		public string OrderControlCodeReason
		{
			get { return _orderControlCodeReason; }
			set { _orderControlCodeReason = value; }
		}
		
		public string EnteringOrganization
		{
			get { return _enteringOrganization; }
			set { _enteringOrganization = value; }
		}		
		
		public string EnteringDevice
		{
			get { return _enteringDevice; }
			set { _enteringDevice = value; }
		}
		
		public XCN ActionBy 
		{
			get { return _actionBy; }
			set { _actionBy = value; }
		}
		
	}

}
