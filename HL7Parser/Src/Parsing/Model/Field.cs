using System;
using System.Collections.Generic;

namespace Linkworks.Parsing.Model
{
	class Field
	{
		List<string> properties = new List<string>();

		public int Count
		{
			get { return properties.Count; }
		}
		
		public void AddProperty(string value)
		{
			properties.Add(value);
		}
		
		public string this[int index]
		{
			get { return properties[index]; }
		}
		
		public override string ToString()
		{
			string s = "";
			int i=0;
			foreach(string p in properties)
			{
				s += string.Format("\n  {0}. {1}", ++i, p??"null");
			}
			return s;
		}
	}

}
