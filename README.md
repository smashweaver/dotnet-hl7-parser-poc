# .NET HL7 Parser (2007 POC)

A sophisticated proof-of-concept HL7 (Health Level 7) message parser implemented in C# .NET, demonstrating advanced parsing techniques and object-oriented design patterns. Originally created in 2007 as a technical demonstration.

## Technical Implementation

### Parser Architecture
The parser uses a recursive descent approach combined with a state machine for message flow control. Key components:

```csharp
class Parser
{
    // State machine tracks message segment flow
    int NextState(int oldState, string code) { ... }

    // Recursive descent parsing
    void ParseSegment(string rawSegment) { ... }
}
```

### Design Patterns

1. **Factory Pattern**
   - Segment creation via generic factory
   - Token generation for parsing
   - Field construction

```csharp
abstract class FactoryBase<T> : IFactory<T>
{
    public virtual T Create(Properties properties) { ... }
}
```

2. **Builder Pattern**
   - Message construction
   - Segment assembly
   - Field grouping

```csharp
class HL7Builder : IBuilder
{
    public void CreateHeader(Properties properties) { ... }
    public void CreatePatientIdentification(Properties properties) { ... }
}
```

### Core Components

#### Scanner
- Tokenizes HL7 messages
- Handles delimiters and escape sequences
- Field/component separation

```csharp
class Scanner
{
    public List<Token> Scan(string source) { ... }
    public static Properties GetProperties(string source) { ... }
}
```

#### Segment Models
- Strong typing for segments
- Property encapsulation
- Complex field handling

```csharp
public class MshSegment
{
    public string EncodingChars { get; set; }
    public HD SendingFacility { get; set; }
    // ...
}
```

### Message Flow
1. Scanner tokenizes input
2. Parser determines segment type
3. Factory creates appropriate segment
4. Builder assembles message structure
5. Properties populated via reflection

## Supported HL7 Features

### Segments
- MSH (Message Header)
- PID (Patient Identification)
- OBR (Observation Request)
- ORC (Common Order)
- NTE (Notes and Comments)

### Data Types
- CM (Composite)
- CE (Coded Element)
- HD (Hierarchic Designator)
- TQ (Timing/Quantity)
- XCN (Extended Composite ID Number and Name)

### Field Processing
- Component splitting
- Sub-component handling
- Repeat field support
- Escape sequence management

## Testing

Comprehensive unit testing suite using NUnit:

```csharp
[TestFixture]
public class TestFieldParsing
{
    [Test]
    public void TestRepeatGroup()
    {
        string source = @"p1^p2~p1^p2^p3";
        Group field = factory.Create(source);
        Assert.AreEqual(2, field.Count);
    }
}
```

Sample messages included for integration testing.

## Technical Requirements

- .NET Framework 2.0
- NUnit for testing
- SharpDevelop 2.1 or Visual Studio 2005

## Historical Context

Created in 2007, this implementation showcases:
- Advanced OO design techniques
- Sophisticated parsing strategies
- Robust error handling
- Clean, maintainable code structure

While using older .NET Framework features, the architecture and patterns remain relevant and demonstrate solid software engineering principles.

## Code Examples

### Factory Implementation
```csharp
class MshFactory : FactoryBase<MshSegment>
{
    public override MshSegment Create(Properties properties)
    {
        MshSegment msh = new MshSegment();
        msh.EncodingChars = properties[1].Value;
        // ...
        return msh;
    }
}
```

### Parser State Machine
```csharp
switch (state)
{
    case 0:  // message header
        builder.CreateHeader(properties);
        break;
    case 3:  // patient identification
        builder.CreatePatientIdentification(properties);
        break;
    // ...
}
```

## License

This code is provided as-is for reference and educational purposes.
