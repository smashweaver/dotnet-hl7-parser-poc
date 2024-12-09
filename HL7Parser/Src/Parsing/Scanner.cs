using System;
using System.Collections.Generic;
using Linkworks.Parsing.Factory;
using Linkworks.Parsing.Model;

namespace Linkworks.Parsing
{
	class Scanner
	{
		string _delimeters = @"^~\\&";
		
		public List<Token> Scan(string source)
		{
			List<Token> list = new List<Token>();
			bool isEscape = false;
			string buffer = "";
			int index = 0;
			while (index < source.Length)
			{
				char ch = source[index++];
//				if ( ignoreEsc )
//				{
//					if ( _delimeters.IndexOf(ch)>-1 )
//					{
//						list.Add(TokenFactory.Create(ch));
//					}
//					else
//						buffer += ch.ToString();
//				}
//				else
				{
					if ( _delimeters.IndexOf(ch) > -1 )
					{
						if ( buffer.Length > 0 && !isEscape )
						{
							list.Add(TokenFactory.Create(buffer));
							buffer = "";
						}
						if ( ch == '\\' )
						{
							isEscape = !isEscape;
							if ( !isEscape )
							{
								list.Add(TokenFactory.Create(buffer[0]));
								buffer = "";
							}						
						}
						else if ( ch == '^' || ch == '~' || ch == '&' )
						{
							list.Add(TokenFactory.Create(ch));
						}						
					}
					else
					{
						buffer += ch.ToString();
					}
				}
			}
			if ( buffer.Length > 0 )
			{
				list.Add(TokenFactory.Create(buffer));
			}
			return list;
			
		}
		
//		public List<Token> Scan(string source)
//		{
//			return Scan(source, false);
//		}
		
		public static Properties GetProperties(string source)
		{
			Properties tokens = new Properties();
			int index = 0;
			string buffer = "";
			char ch = ' ';;
			while (index < source.Length)
			{
				ch = source[index++];
				if ( ch == '|' )
				{
					if ( buffer.Length > 0 )
					{
						tokens.Add(TokenFactory.Create(buffer));
						buffer = "";
					}
					else
					{
						tokens.Add(TokenFactory.Create(null));
					}
				}
				else
				{
					buffer += ch.ToString();
				}
			}
			if ( buffer.Length > 0 )
			{
				tokens.Add(TokenFactory.Create(buffer));
			}
			else if ( ch == '|')
			{
				tokens.Add(TokenFactory.Create(null));
			}
			
			return tokens;
		}
	}
}
