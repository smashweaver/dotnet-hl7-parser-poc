using System;
using Linkworks.Parsing.Model;

namespace Linkworks.Parsing.Factory
{
	public static class TokenFactory
	{
		public static Token Create(char value)
		{
			return new Token(value, TokenEnum.DELIMETER);
		}
		
		public static Token Create(string value)
		{
			return new Token(value, TokenEnum.VALUE);
		}		
	}
}
