using System;
using System.Diagnostics;
using Linkworks.Parsing.Factory;
using Linkworks.Parsing.Model;

namespace Linkworks.Document.Factory
{
	abstract class FactoryBase<T> : IFactory<T>
	{
		public virtual T Create(Properties properties)
		{
			throw new NotImplementedException();
		}
		
		protected Group GetComplexField(string source)
		{
			Debug.WriteLine(source);
			FieldFactory factory = new FieldFactory();
			return factory.Create(source);
		}
		
		protected void Optional(Do action)
		{
			try
			{
				action.Invoke();
			}
			catch {}
		}
	}
		
}

