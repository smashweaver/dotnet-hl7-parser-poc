/*
 * Created by: Jason D. Jimenez
 * Created on: 5/13/2007 9:40AM
 * 
 */

using System;
using System.IO;

namespace Linkworks.Parsing.Test
{
	public class Utility
	{
		public static string GetDocument(Stream stream)
		{
			StreamReader reader = new StreamReader(stream);
			string input = reader.ReadToEnd();
			reader.Close();
			return input;
		}
		
	}
}
