using System;
using System.Collections.Generic;

namespace Linkworks.Parsing
{
	public class Enumerator<T> : IEnumerator<T>
	{
		int index = -1;
		List<T> list;
		
		public Enumerator(List<T> original)
		{
			list = original;
		}
				
		public T Current 
		{
			get { return list[index]; }
		}
		
		object System.Collections.IEnumerator.Current 
		{
			get { return Current; }
		}
		
		public void Dispose()
		{
			list = null;
		}
		
		public bool MoveNext()
		{
			if ( index < list.Count-1 )
			{
				index++;
				return true;
			}
			return false;
		}
		
		public bool MoveBack()
		{
			if ( index > -1 )
			{
				index--;
				return true;
			}
			return false;
		}
		
		public void Reset()
		{
			index = -1;
		}
	}
}
