using System;
using Linkworks.Parsing.Model;

namespace Linkworks.Document.Factory
{
	interface IFactory<T>
	{
		T Create(Properties properties);
	}
}

