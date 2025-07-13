// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Compiler", "CS8625:Cannot convert null literal to non-nullable reference type", Justification = "Null is intentionally passed to validate ArgumentNullException behavior.")]
