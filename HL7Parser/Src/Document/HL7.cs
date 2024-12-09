using System;

namespace Linkworks.Document
{
	public class HL7
	{
		MshSegment _msh;
		
		public MshSegment Msh 
		{
			get { return _msh; }
			set { _msh = value; }
		}
	}	
}

