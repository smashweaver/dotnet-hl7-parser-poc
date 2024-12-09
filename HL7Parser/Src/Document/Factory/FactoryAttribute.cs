using System;

namespace Linkworks.Document.Factory
{
	class FactoryAttribute : Attribute
	{
		Type type;
		
		public FactoryAttribute(Type type)
		{
			this.type = type;
		}
		
		public Type Type
		{
			get { return type; }
			set { type = value; }
		}
	}
	

}

