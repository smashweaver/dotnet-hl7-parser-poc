using System;
using Linkworks.Parsing.Model;

namespace Linkworks.Parsing.Builder
{
	interface IBuilder
	{		
		object GetResult();
		void Initialize();
		void CreateHeader(Properties properties);
		void CreateHeaderComment(Properties properties);
		void CreatePatientIdentification(Properties properties);
		void CreatePatientComment(Properties properties);
		void CreatePatientVisit(Properties properties);
		void CreatePatientVisitComment(Properties properties);
		void CreateCommonOrder(Properties properties);
		void CreateCommonOrderComment(Properties properties);
		void CreateOrderRequest(Properties properties);
		void CreateOrderRequestComment(Properties properties);
		void CreateObservationResult(Properties properties);
		void CreateObservationResultComment(Properties properties);
		void CreateDisplay(Properties properties);
	}
}
