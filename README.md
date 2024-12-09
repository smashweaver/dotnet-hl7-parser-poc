# .NET HL7 Parser (Proof of Concept)

A proof of concept HL7 (Health Level 7) message parser implemented in C# .NET. This project was created as a technical demonstration for a prospective employer to showcase object-oriented design patterns and parsing capabilities.

## Overview

This parser was designed to handle HL7 v2.x messages, with specific focus on:

- Message segment parsing (MSH, PID, OBR, etc.)
- Field component splitting
- Support for repeated fields
- Component sub-element parsing
- Escape sequence handling

## Key Features

- Modular design using Factory pattern for segment creation
- Builder pattern for constructing HL7 message objects
- Support for basic HL7 data types (ST, NM, etc.)
- Segment hierarchy preservation
- Unit tests using NUnit framework
- Sample HL7 messages included for testing

## Project Structure

```
HL7Parser/
├── Src/
│   ├── Document/           # HL7 segment definitions
│   ├── Parsing/           # Core parsing logic
│   │   ├── Builder/       # Message construction
│   │   ├── Factory/       # Segment factories
│   │   └── Model/         # Parser models
│   └── Properties/        # Assembly info
└── Test/
    └── Sample/            # Sample HL7 messages
```

## Technical Details

- Language: C# (.NET Framework 2.0)
- IDE: SharpDevelop 2.1
- Testing Framework: NUnit
- Build System: MSBuild

## Historical Context

This project was created around 2007 as a technical demonstration. It showcases:

- Object-oriented design principles
- Parser implementation techniques
- Test-driven development practices
- Understanding of HL7 message structure

## Limitations

As a proof of concept, this implementation:
- Supports only a subset of HL7 v2.x functionality
- May not handle all edge cases
- Was not intended for production use
- Uses older .NET Framework features

## License

This code is provided as-is for reference purposes.
