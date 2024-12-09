using System;
using Linkworks.Parsing.Model;

namespace Linkworks.Document.Factory
{
	class MshFactory : FactoryBase<MshSegment>
	{
		public override MshSegment Create(Properties properties)
		{
			Field field;
			MshSegment msh = new MshSegment();
			// EncodingCharacters
			msh.EncodingChars = properties[1].Value;
			// SendingApplication
			msh.SendingApplication = properties[2].Value;
			// SendingFacility
			field = GetComplexField(properties[3].Value)[0];
			msh.SendingFacility.Name = field[0];
			Optional( delegate(){msh.SendingFacility.Id = field[1];} );
			// ReceivingApplication
			msh.ReceivingApplication = properties[4].Value;
			// ReceivingFacility
			msh.ReceivingFacility = properties[5].Value;
			// DateTimeOfMessage
			msh.DateTimeOfMessage = properties[6].Value;
			// Security
			msh.Security = properties[7].Value;
			// MessageType
			field = GetComplexField(properties[8].Value)[0];
			msh.MessageType.Type = field[0];
			msh.MessageType.Trigger = field[1];
			// Message Control ID
			msh.MessageControlId = properties[9].Value;
			// Processing ID
			msh.ProcessingId = properties[10].Value;
			// Version ID
			Optional( delegate(){msh.VersionId = properties[11].Value;} );
			// Sequence Number
			Optional( delegate(){msh.SequenceNumber = properties[12].Value;} );
			// Continuation Pointer
			Optional( delegate(){msh.ContinuationPointer = properties[13].Value;} );
			// Accept Acknowledgment Type
			Optional( delegate(){msh.AcceptAcknowledgmentType = properties[14].Value;} );
			// Application Acknowledgment Type
			Optional( delegate(){msh.ApplicationAcknowledgmentType = properties[15].Value;} );
			// Country Code
			Optional( delegate(){msh.CountryCode = properties[16].Value;} );
			return msh;
		}
	}

}

