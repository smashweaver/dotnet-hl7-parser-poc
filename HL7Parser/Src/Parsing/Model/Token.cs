using System;

namespace Linkworks.Parsing.Model
{
	public class Token
	{
		string _value;
		TokenEnum _kind;
		
		public string Value
		{
			get { return _value; }
		}
		
		public TokenEnum Kind
		{
			get { return _kind; }
		}
		
		public Token(string value, TokenEnum kind)
		{
			_value = value;
			_kind = kind;
		}
		
		public Token(char value, TokenEnum kind)
		{
			_value = Convert.ToString(value);
			_kind = kind;
		}
		
		public override string ToString()
		{
			if ( _value == null )
				return string.Format("{0}(null)",_kind);
			return string.Format("{0}({1})", _kind, _value);
		}
		
		public bool IsNull
		{
			get { return _value == null; }
		}
		
		public  bool IsBar
		{
			get { return Kind == TokenEnum.DELIMETER ? Value == "|" : false; }
		}
		
		public  bool IsHat
		{
			get { return Kind == TokenEnum.DELIMETER ? Value == "^" : false; }
		}
		
		public  bool IsTilde
		{
			get { return Kind == TokenEnum.DELIMETER ? Value == "~" : false; }
		}
		
		public  bool IsBackslash
		{
			get { return Kind == TokenEnum.DELIMETER ? Value == "\\" : false; }
		}
		
		public  bool IsAmpersand
		{
			get { return Kind == TokenEnum.DELIMETER ? Value == "&" : false; }
		}
		
		public  bool IsValue
		{
			get { return Kind == TokenEnum.VALUE; }
		}
		
		public bool IsDelimeter
		{
			get { return Kind == TokenEnum.DELIMETER; }
		}
	}
	
	public enum TokenEnum
	{
		VALUE,
		DELIMETER
	}
}
