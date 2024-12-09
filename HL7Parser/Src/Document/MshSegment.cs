using System;
using System.Collections.Generic;
using Linkworks.Document.Factory;

namespace Linkworks.Document
{	
	[Factory(typeof(MshFactory))]
	public class MshSegment
	{
		string _encodingchars;		
		string _sendingapplication;
		HD _sendingfacility = new HD();
		string _receivingapplication;
		string _receivingfacility;
		string _datetimeofmessage;
		string _security;
		CM1 _messagetype = new CM1();
		string _messagecontrolid;
		string _processingid;
		string _versionid;
		string _sequencenumber;
		string _continuationpointer;
		string _acceptacknowledgmenttype;
		string _applicationacknowledgmenttype;
		string _countrycode;
		
		List<NteSegment> comments = new List<NteSegment>();
		
		public string EncodingChars 
		{
			get { return _encodingchars; }
			set { _encodingchars = value; }
		}
		
		public string SendingApplication
		{
			get { return _sendingapplication; }
			set { _sendingapplication = value; }
		}
		
		public HD SendingFacility
		{
			get { return _sendingfacility; }
			set { _sendingfacility = value; }
		}
		
		public string ReceivingApplication
		{
			get { return _receivingapplication; }
			set { _receivingapplication = value; }
		}
		
		public string ReceivingFacility
		{
			get { return _receivingfacility; }
			set { _receivingfacility = value; }
		}
		
		public string DateTimeOfMessage
		{
			get { return _datetimeofmessage; }
			set { _datetimeofmessage = value; }
		}
		
		public string Security
		{
			get { return _security; }
			set { _security = value; }
		}
		
		public CM1 MessageType
		{
			get { return _messagetype; }
			set { _messagetype = value; }
		}
		
		public string MessageControlId
		{
			get { return _messagecontrolid; }
			set { _messagecontrolid = value; }
		}
		
		public string ProcessingId
		{
			get { return _processingid; }
			set { _processingid = value; }
		}
		
		public string VersionId
		{
			get { return _versionid; }
			set { _versionid = value; }
		}
		
		public string SequenceNumber
		{
			get { return _sequencenumber; }
			set { _sequencenumber = value; }
		}
		
		
		public string ContinuationPointer
		{
			get { return _continuationpointer; }
			set { _continuationpointer = value; }
		}
		
		public string AcceptAcknowledgmentType
		{
			get { return _acceptacknowledgmenttype; }
			set { _acceptacknowledgmenttype = value; }
		}
		
		
		public string ApplicationAcknowledgmentType
		{
			get { return _applicationacknowledgmenttype; }
			set { _applicationacknowledgmenttype = value; }
		}
		
		public string CountryCode
		{
			get { return _countrycode; }
			set { _countrycode = value; }
		}
		
		public void Add(NteSegment nte)
		{
			comments.Add(nte);
		}
	}
}

