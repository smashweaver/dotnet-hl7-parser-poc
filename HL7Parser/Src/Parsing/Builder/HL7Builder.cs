using System;
using Linkworks.Document;
using Linkworks.Parsing.Model;

namespace Linkworks.Parsing.Builder
{
	class HL7Builder : IBuilder
	{
		HL7 doc;
		
		public object GetResult()
		{
			return doc;
		}
		
		public void Initialize()
		{
			doc = new HL7();
		}
		
		public void CreateHeader(Properties properties)
		{
			doc.Msh = SegmentBuilder.Create<MshSegment>(properties);
		}
		
		public void CreateHeaderComment(Properties properties)
		{
		}
		
		public void CreatePatientIdentification(Properties properties)
		{
		}
		
		public void CreatePatientComment(Properties properties)
		{
		}
		
		public void CreatePatientVisit(Properties properties)
		{
		}
		
		public void CreatePatientVisitComment(Properties properties)
		{
		}
		
		public void CreateCommonOrder(Properties properties)
		{
		}
		
		public void CreateCommonOrderComment(Properties properties)
		{
		}
		
		public void CreateOrderRequest(Properties properties)
		{
		}
		
		public void CreateOrderRequestComment(Properties properties)
		{
		}
		
		public void CreateObservationResult(Properties properties)
		{
		}
		
		public void CreateObservationResultComment(Properties properties)
		{
		}
		
		public void CreateDisplay(Properties properties)
		{
		}
	}
}
