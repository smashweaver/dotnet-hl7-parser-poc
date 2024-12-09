using System;
using System.Collections.Generic;

namespace Linkworks.Parsing.Model
{
	class Group
	{
		List<Field> fields = new List<Field>();
		
		
		public int Count
		{
			get { return fields.Count; }
		}
		
		public Field this[int index]
		{
			get { return fields[index]; }
		}
		
		public Field CreateField()
		{
			Field field = new Field();
			fields.Add(field);
			return field;
		}
		
		public override string ToString()
		{			
			string s = "";
			int i=0;
			foreach(Field field in fields)
			{
				s += string.Format("\nField({0})",i++)+field.ToString();
			}
			return s;
		}
	}
}
