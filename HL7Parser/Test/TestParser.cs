/*
 * Created by: Jason D. Jimenez
 * Created on: 5/13/2007 11:30AM
 * 
 */

using System;
using System.Diagnostics;
using Linkworks.Document;
using Linkworks.Parsing.Builder;
using Linkworks.Parsing.Factory;
using Linkworks.Parsing.Model;
using NUnit.Core;
using NUnit.Framework;

namespace Linkworks.Parsing.Test
{
	[TestFixture]
	public class TestSegments
	{
		[SetUp]
		public void Setup()
		{
			Debug.Listeners.Add(new ConsoleTraceListener());
			Debug.WriteLine("[ Segment parsing ]");
		}
		
		[TearDown]
		public void Cleanup()
		{
			Debug.WriteLine("");
			Debug.Listeners.Clear();
		}
		
		[Test]
		public void TestMsh()
		{
			string source = @"MSH|^~\&|LAB|QTE||22365|20040103035850||ORU^R01|20040103323307950000|P|2.3|||||||";
			Debug.WriteLine("source: "+source);
			SegmentBuilder.Create<MshSegment>(Scanner.GetProperties(source));
		}				
	}
	
	[TestFixture]
	public class TestFieldParsing
	{
		[SetUp]
		public void Setup()
		{
			Debug.Listeners.Add(new ConsoleTraceListener());
			Debug.WriteLine("[ Field parsing ]");
		}
		
		[TearDown]
		public void Cleanup()
		{
			Debug.WriteLine("");
			Debug.Listeners.Clear();
		}
		
		[Test]
		public void TestSimple()
		{
			FieldFactory factory = new FieldFactory();
			string source = @"p1^p2^p3";
			Group field = factory.Create(source);
			Debug.WriteLine("source: "+source);
			Debug.WriteLine(field);
			Assert.AreEqual(3, field[0].Count);
		}
		
		[Test]
		public void TestWithNull()
		{
			FieldFactory factory = new FieldFactory();
			string source = @"p1^^p3";
			Group field = factory.Create(source);
			Debug.WriteLine("source: "+source);
			Debug.WriteLine(field);
			Assert.AreEqual(3, field[0].Count);
		}
		
		[Test]
		public void TestWithTrailingNull()
		{
			FieldFactory factory = new FieldFactory();
			string source = @"p1^";
			Group field = factory.Create(source);
			Debug.WriteLine("source: "+source);
			Debug.WriteLine(field);
			Assert.AreEqual(2, field[0].Count);
		}

		[Test]
		public void TestWithLeadingNull()
		{
			FieldFactory factory = new FieldFactory();
			string source = @"^p2";
			Group field = factory.Create(source);
			Debug.WriteLine("source: "+source);
			Debug.WriteLine(field);
			Assert.AreEqual(2, field[0].Count);
		}

		
		[Test]
		public void TestRepeatSimple()
		{
			FieldFactory factory = new FieldFactory();
			string source = @"p1~p1~p1";
			Group field = factory.Create(source);
			Debug.WriteLine("source: "+source);
			Debug.WriteLine(field);
			Assert.AreEqual(3, field.Count);
			Assert.AreEqual(1, field[0].Count);
			Assert.AreEqual(1, field[1].Count);
			Assert.AreEqual(1, field[2].Count);
		}
		
		[Test]
		public void TestRepeatGroup()
		{
			FieldFactory factory = new FieldFactory();
			string source = @"p1^p2~p1^p2^p3";
			Group field = factory.Create(source);
			Debug.WriteLine("\nsource: "+source);
			Debug.WriteLine(field);
			Assert.AreEqual(2, field.Count);
			Assert.AreEqual(2, field[0].Count);
			Assert.AreEqual(3, field[1].Count);
		}
	}


}
