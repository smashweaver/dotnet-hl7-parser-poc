using System;
using Linkworks.Parsing.Model;

namespace Linkworks.Parsing.Factory
{
	// field context free grammar
	// <f> := <P><D><f>
	//     := <P>
	// <P> := value
	//     := null
	// <D> := ^
	//     := ~
	//     := \
	//     := &
	class FieldFactory
	{
		Field field;
		Group group;
		Enumerator<Token> tokens;
		Scanner scanner = new Scanner();
		
		public Group Create(string source)
		{
			group = new Group();
			field = group.CreateField();
			if ( source == @"^~\&" )
			{
				field.AddProperty(@"^~\&");
			}
			else if ( source == null )
			{
				field.AddProperty(null);
			}
			else
			{
				tokens = new Enumerator<Token>(scanner.Scan(source));
				GetField();
				if ( tokens.Current.IsHat )
				{
					field.AddProperty(null);
				}
			}
			return group;
		}
		
		void GetField()
		{
			if ( tokens.MoveNext() )
			{
				GetProperty();
				if ( tokens.MoveNext() )
				{
					GetDelimeter();
					GetField();
				}
			}
		}
		
		void GetProperty()
		{
			Token token = tokens.Current;
			if ( token.IsValue)
				field.AddProperty(token.Value);
			else
			{
				field.AddProperty(null);
				tokens.MoveBack();
			}
		}
		
		void GetDelimeter()
		{
			Token token = tokens.Current;
			if ( token.IsTilde )
			{
				NewField();
			}
		}
		
		void NewField()
		{
			field = group.CreateField();
		}
	}
}
