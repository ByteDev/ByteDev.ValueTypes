# Release Notes

## 1.5.0 - ?

Breaking changes:
- (None)

New features:
- Added `EnumTypeHelper.HasFlagsAttribute` method.
- Added `CharExtensions.IsNul` method.
- Added `DecimalExtensions.RemoveTrailingZeros` method.
- Added `BoolStringFormat.EnableDisable` value.

Bug fixes / internal changes:
- Minor improvements in `EnumTypeHelper` type.

## 1.4.0 - 07 March 2022

Breaking changes:
- (None)

New features:
- Added `EnumExtensions.ToString(EnumStringFormat)`.
- Added `BooleanExtensions.ToString(BoolStringFormat.YesNoShort)`.

Bug fixes / internal changes:
- Fixed `EnumExtensions.GetDescription` to return null if enum value not defined.
- Fixed `EnumExtensions.GetDescriptionOrName` to return non-defined enum value as string.

## 1.3.0 - 28 January 2022

Breaking changes:
- (None)

New features:
- Added `IntExtensions.IsPrime` method.
- Added `GuidExtensions.ToString(GuidStringFlags)` method.

Bug fixes / internal changes:
- (None)

## 1.2.0 - 21 May 2021

Breaking changes:
- (None)

New features:
- Added `IntExtensions.ToStringZeroPadded`.
- Added `LongExtensions.ToStringZeroPadded`.

Bug fixes / internal changes:
- (None)

## 1.1.0 - 23 March 2021

Breaking changes:
- (None)

New features:
- Added `LongExtensions.IsEven`.
- Added `LongExtensions.IsOdd`.
- Added `LongExtensions.IsMultipleOf`.
- Added `LongExtensions.MakeNegative`.
- Added `EnumTypeHelper.ToList` overload.
- Added `EnumTypeHelper.ToDisplayList` overload.

Bug fixes / internal changes:
- (None)

## 1.0.1 - 03 August 2020

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- Package build fixes

## 1.0.0 - 03 August 2020

Initial version.
