using System;
using System.Collections;
using Linkworks.Document.Factory;
using Linkworks.Parsing.Model;

namespace Linkworks.Parsing.Builder
{
	class SegmentBuilder
	{
		static Hashtable cache = new Hashtable();
		
		public static T Create<T>(Properties properties)
		{
			string key = typeof(T).ToString();
			if ( !cache.ContainsKey(key) )
			{
				cache.Add(key, GetFactory<T>());
			}
			IFactory<T> factory = (IFactory<T>)cache[key];
			return factory.Create(properties);
		}
		
		public static IFactory<T> GetFactory<T>()
		{
			Type type = typeof(T);
			object[] custom = type.GetCustomAttributes(typeof(FactoryAttribute), false);
			if (custom.GetLength(0) != 0)
			{
				FactoryAttribute sfa = custom[0] as FactoryAttribute;
				return (IFactory<T>)Activator.CreateInstance(sfa.Type);
			}
			return null;
		}
	}
}

