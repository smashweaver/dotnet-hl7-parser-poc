using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Linkworks.Document
{
	public class NteSegment
	{
		string _sequencenumber;
		string _sourceofcomment;		
		string _comment;		
		
		public string SequenceNumber
		{
			get { return _sequencenumber; }
			set { _sequencenumber = value; }
		}
		
		public string SourceOfComment
		{
			get { return _sourceofcomment; }
			set { _sourceofcomment = value; }
		}
		
		public string Comment 
		{
			get { return _comment; }
			set { _comment = value; }
		}
	}

}

