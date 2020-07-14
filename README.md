[![Build status](https://ci.appveyor.com/api/projects/status/github/bytedev/ByteDev.ValueTypes?branch=master&svg=true)](https://ci.appveyor.com/project/bytedev/ByteDev-ValueTypes/branch/master)
[![NuGet Package](https://img.shields.io/nuget/v/ByteDev.ValueTypes.svg)](https://www.nuget.org/packages/ByteDev.ValueTypes)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/ByteDev/ByteDev.ValueTypes/blob/master/LICENSE)

# ByteDev.ValueTypes

.NET Standard library of value type related functionality.

## Installation

ByteDev.ValueTypes has been written as a .NET Standard 2.0 library, so you can consume it from a .NET Core or .NET Framework 4.6.1 (or greater) application.

ByteDev.ValueTypes is hosted as a package on nuget.org.  To install from the Package Manager Console in Visual Studio run:

`Install-Package ByteDev.ValueTypes`

Further details can be found on the [nuget page](https://www.nuget.org/packages/ByteDev.ValueTypes/).

## Release Notes

Releases follow semantic versioning.

Full details of the release notes can be viewed on [GitHub](https://github.com/ByteDev/ByteDev.ValueTypes/blob/master/docs/RELEASE-NOTES.md).

## Usage

To use any extension methods simply reference the `ByteDev.ValueTypes` namespace.

Assembly contains extension methods:

- Char
    - Repeat
- Decimal
  - AnyDecimalPlaces
  - GetNumberDecimalPlaces
- Enum
  - GetDescription
  - GetDescriptionOrName
- Guid
  - IsEmpty
  - Comb
- Int
  - IsEven
  - IsOdd
  - IsMultipleOf
  - MakeNegative

