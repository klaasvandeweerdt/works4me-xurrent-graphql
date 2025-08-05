// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;
[assembly: SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "Traditional 'using' statement for clarity.")]
[assembly: SuppressMessage("Style", "IDE0130:Namespace does not match folder structure", Justification = "Flattened namespace for a cleaner public API surface.")]
[assembly: SuppressMessage("Style", "IDE0066:Convert switch statement to expression", Justification = "Code readability.")]

[assembly: SuppressMessage("Naming", "CA1700:Do not name enum values 'Reserved'", Justification = "This is Xurrent property name.", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.CiStatus")]
[assembly: SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "This is Xurrent entity name.", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.CustomCollection")]
[assembly: SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "This is Xurrent entity name.", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.Permission")]

[assembly: SuppressMessage("Performance", "CA1812:Internal class is apparently never instantiated", Justification = "Instantiated via reflection by System.Text.Json", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.Serialization.XurrentObjectConverter`1")]
[assembly: SuppressMessage("Performance", "CA1812:Internal class is apparently never instantiated", Justification = "Instantiated via reflection by System.Text.Json", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.Serialization.XurrentEnumNullableConverter`1")]
[assembly: SuppressMessage("Performance", "CA1812:Internal class is apparently never instantiated", Justification = "Instantiated via reflection by System.Text.Json", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.Serialization.XurrentInterfaceConverter`1")]
[assembly: SuppressMessage("Performance", "CA1812:Internal class is apparently never instantiated", Justification = "Instantiated via reflection by System.Text.Json", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.Serialization.XurrentMutationContentConverter`1")]
[assembly: SuppressMessage("Performance", "CA1812:Internal class is apparently never instantiated", Justification = "Instantiated via reflection by System.Text.Json", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.AuthenticationOAuth2Response")]
[assembly: SuppressMessage("Performance", "CA1812:Internal class is apparently never instantiated", Justification = "Instantiated via reflection by System.Text.Json", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.S3UploadParameters")]
[assembly: SuppressMessage("Performance", "CA1812:Internal class is apparently never instantiated", Justification = "Instantiated via reflection by System.Text.Json", Scope = "type", Target = "~T:Works4me.Xurrent.GraphQL.Mutations.MutationPayload")]

[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposing the MultipartFormDataContent instance will cascade and dispose all added HttpContent instances (every StringContent and the StreamContent), so no objects are left undisposed.", Scope = "member", Target = "~M:Works4me.Xurrent.GraphQL.XurrentClient.UploadAttachmentAsync(System.IO.Stream,System.String,System.String,System.Threading.CancellationToken)~System.Threading.Tasks.Task{Works4me.Xurrent.GraphQL.AttachmentUploadResponse}")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposing the MultipartFormDataContent instance will cascade and dispose all added HttpContent instances (every StringContent and the StreamContent), so no objects are left undisposed.", Scope = "member", Target = "~M:Works4me.Xurrent.GraphQL.XurrentClient.StartExportAsync(System.String,System.Nullable{System.DateTime},System.String,System.Nullable{Works4me.Xurrent.GraphQL.ExportLineSeparator},System.Collections.Generic.IEnumerable{System.String},System.Boolean,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.String}")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposing the MultipartFormDataContent instance will cascade and dispose all added HttpContent instances (every StringContent and the StreamContent), so no objects are left undisposed.", Scope = "member", Target = "~M:Works4me.Xurrent.GraphQL.XurrentClient.StartImportAsync(System.String,System.IO.Stream,System.String,System.String,System.Boolean,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.String}")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The constructed HttpMessageHandler chain is passed to HttpClient with disposeHandler: true. HttpClient takes ownership and disposes all handlers automatically. Manual disposal is not required.", Scope = "member", Target = "~M:Works4me.Xurrent.GraphQL.XurrentClient.#ctor(Works4me.Xurrent.GraphQL.AuthenticationTokenCollection,System.String,System.String,Microsoft.Extensions.Logging.ILogger{Works4me.Xurrent.GraphQL.XurrentClient})")]

[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Collection properties are settable to support serialization and data binding in entity models.")]

#if NET5_0_OR_GREATER

[assembly: SuppressMessage("Maintainability", "CA1510:Use ArgumentNullException throw helper", Justification = "Suppressed due to multi-target framework compatibility. The project builds for .NET 6, .NET 4.7.2, and .NET Standard 2.0, which do not support ArgumentNullException.ThrowIfNull. Ensures compatibility across all target frameworks.")]

#endif
