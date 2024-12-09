/*
 * Created by: Jason D. Jimenez
 * Created on: 5/13/2007 9:40AM
 * 
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

using NUnit.Core;
using NUnit.Framework;

using Linkworks.Parsing.Model;

namespace Linkworks.Parsing.Test
{
	[TestFixture]
	public class TestScanner
	{		
		[SetUp]
		public void Setup()
		{
			Debug.Listeners.Add(new ConsoleTraceListener());
		}
		
		[TearDown]
		public void Cleanup()
		{
			Debug.Listeners.Clear();
		}
		
		[Test]
		public void TestGetProperties()
		{
			string source = @"MSH|^~\&|f1^f2^f3|f1^^^f4|||";
			Debug.WriteLine("\nscan fields: "+source);
			List<Token> tokens = Scanner.GetProperties(source);
			foreach(Token token in tokens)
			{
				Debug.WriteLine(token);
			}
			Assert.AreEqual(7, tokens.Count);			
		}
		
		[Test]
		public void TestScan()
		{
			string source = @"f1^f2^f3";
			Scanner scanner = new Scanner();
			Debug.WriteLine("\nscan: "+source);
			List<Token> tokens = scanner.Scan(source);
			foreach(Token token in tokens)
			{
				Debug.WriteLine(token);
			}
			Assert.AreEqual(5, tokens.Count);
			
			source = @"f1\F\f2^f3";
			Debug.WriteLine("\nscan: "+source);
			tokens = scanner.Scan(source);
			foreach(Token token in tokens)
			{
				Debug.WriteLine(token);
			}
			Assert.AreEqual(5, tokens.Count);
		}
	}
}
