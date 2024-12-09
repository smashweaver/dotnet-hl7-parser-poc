using System;
using System.Diagnostics;
using System.IO;
using Linkworks.Parsing.Builder;
using Linkworks.Parsing.Model;

namespace Linkworks.Parsing
{
	class Parser
	{
		int state;
		IBuilder builder;
		Properties properties;
		
		public Parser(IBuilder builder)
		{
			this.builder = builder;
		}

		public void Parse(string document)
		{			
			StringReader reader = new StringReader(document);
			string line = reader.ReadLine();
			builder.Initialize();
			state = -1;
			while ( line != null )
			{
				ParseSegment(line);			// parse this segment
				line = reader.ReadLine();	// read the next segment
			}
			reader.Close();
		}
		
		void ParseSegment(string rawSegment)
		{
			properties = Scanner.GetProperties(rawSegment);
			string code = properties[0].Value;
			state = NextState(state, code);	// determine the state of the parser
			switch ( state )				// then process the segment
			{
				case 0:		// message header
					Debug.WriteLine("msh segment");
					builder.CreateHeader(properties);					
					break;
				case 1:		// event type
					Debug.WriteLine("evn segment");
					break;
				case 2:		// notes and comments
					Debug.WriteLine("nte segment - header");
					builder.CreateHeaderComment(properties);
					break;
				case 3:		// patient identification
					Debug.WriteLine("pid segment");
					builder.CreatePatientIdentification(properties);
					break;
				case 4:		// additional demographics
					Debug.WriteLine("pd1 segment");
					break;
				case 5:		// notes and comments
					Debug.WriteLine("nte segment - patient");
					builder.CreatePatientComment(properties);
					break;
				case 6:		// patient visit
					Debug.WriteLine("pv1 segment");
					builder.CreatePatientVisit(properties);
					break;
				case 7:		// notes and comments
					Debug.WriteLine("nte segment - patient visit");
					builder.CreatePatientVisitComment(properties);
					break;
				case 8:		// common order
					Debug.WriteLine("orc segment");
					builder.CreateCommonOrder(properties);
					break;
				case 9:		// notes and comments
					Debug.WriteLine("nte segment - common order");
					builder.CreateCommonOrderComment(properties);
					break;
				case 10:	// order request
					Debug.WriteLine("obr segment");
					builder.CreateOrderRequest(properties);
					break;
				case 11:	// notes and comments
					Debug.WriteLine("nte segment - order request");
					builder.CreateOrderRequestComment(properties);
					break;
				case 12:	// observation|result
					Debug.WriteLine("obx segment");
					builder.CreateObservationResult(properties);
					break;
				case 13:	// notes and comments
					Debug.WriteLine("nte segment - observation|result");
					builder.CreateObservationResultComment(properties);
					break;
				case 14:	// place of service facility information
					Debug.WriteLine("zps segment");
					break;
				case 15:	// display segment
					Debug.WriteLine("dsp segment");
					builder.CreateDisplay(properties);
					break;
				case 16:	// batch trailer segment
					Debug.WriteLine("bts segment");
					break;
				case 17:	// file trailer segment
					Debug.WriteLine("fts segment");
					break;
			}
		}
		
		int NextState(int oldState, string code)
		{
			int newState = -1;
			switch ( oldState )
			{
				case -1:
					if ( code == "MSH" )
					{
						newState = 0;
					}
					break;
				case 0:
					if ( code == "EVN"  )
					{
						newState = 1;
					}
					else if ( code == "NTE" )
					{
						newState = 2;
					}
					else if ( code == "PID" )
					{
						newState = 3;
					}
					break;
				case 1:
					if ( code == "EVN" )
					{
						newState = 1;
					}
					else if ( code == "NTE" )
					{
						newState = 2;
					}
					else if ( code == "PID" )
					{
						newState = 3;
					}
					break;
				case 2:
					if ( code == "NTE" )
					{
						newState = 2;
					}
					else if ( code == "PID" )
					{
						newState = 3;
					}
					break;
				case 3:
					if ( code == "PD1" )
					{
						newState = 4;
					}
					else if ( code == "NTE" )
					{
						newState = 5;
					}
					else if ( code == "PV1" )
					{
						newState = 6;
					}
					else if ( code == "ORC" )
					{
						newState = 8;
					}
					break;
				case 4:
					if ( code == "NTE" )
					{
						newState = 5;
					}
					else if ( code == "PV1" )
					{
						newState = 6;
					}
					break;
				case 5:
					if ( code == "NTE" )
					{
						newState = 5;
					}
					else if ( code == "PV1" )
					{
						newState = 6;
					}
					break;
				case 6:
					if ( code == "NTE" )
					{
						newState = 7;
					}
					else if ( code == "ORC" )
					{
						newState = 8;
					}
					break;
				case 7:
					if ( code == "NTE" )
					{
						newState = 7;
					}
					else if ( code == "ORC" )
					{
						newState = 8;
					}
					break;
				case 8:
					if ( code == "NTE" )
					{
						newState = 9;
					}
					else if ( code == "OBR" )
					{
						newState = 10;
					}
					break;
				case 9:
					if ( code == "NTE" )
					{
						newState = 9;
					}
					else if ( code == "OBR" )
					{
						newState = 10;
					}
					break;
				case 10:
					if ( code == "NTE" )
					{
						newState = 11;
					}
					else if ( code == "OBX" )
					{
						newState = 12;
					}
					break;
				case 11:
					if ( code == "NTE" )
					{
						newState = 11;
					}
					else if ( code == "OBX" )
					{
						newState = 12;
					}
					break;
				case 12:
					if ( code == "OBR" )
					{
						newState = 10;
					}
					else if ( code == "OBX" )
					{
						newState = 12;
					}
					else if ( code == "NTE" )
					{
						newState = 13;
					}
					else if ( code == "ZPS" )
					{
						newState = 14;
					}
					else if ( code == "PID" )
					{
						newState = 3;
					}
					else if ( code == "ORC" )
					{
						newState = 8;
					}
					else if ( code == "DSP" )
					{
						newState = 15;
					}
					break;
				case 13:
					if ( code == "OBR" )
					{
						newState = 10;
					}
					if ( code == "OBX" )
					{
						newState = 12;
					}
					else if ( code == "NTE" )
					{
						newState = 13;
					}
					else if ( code == "ZPS" )
					{
						newState = 14;
					}
					else if ( code == "PID" )
					{
						newState = 3;
					}
					else if ( code == "ORC" )
					{
						newState = 8;
					}
					else if ( code == "DSP" )
					{
						newState = 15;
					}
					break;
				case 14:
					if ( code == "PID" )
					{
						newState = 3;
					}
					else if ( code == "ORC" )
					{
						newState = 8;
					}
					else if ( code == "DSP" )
					{
						newState = 15;
					}
					else if ( code == "OBR" )
					{
						newState = 10;
					}
					break;
				case 15:
					if ( code == "DSP" )
					{
						newState = 15;
					}
					else if ( code == "BTS" )
					{
						newState = 16;
					}
					break;
				case 16:
					if ( code == "FTS" )
					{
						newState = 17;
					}
					break;
				case 17:
					break;
			}
			return newState;
		}
	}
}
