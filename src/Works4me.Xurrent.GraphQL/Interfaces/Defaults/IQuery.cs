using System;
using System.Collections.Generic;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Defines the contract for a GraphQL query, including metadata, selected fields, filters, and related sub-queries.
    /// </summary>
    internal interface IQuery
    {
        /// <summary>
        /// Gets or sets the name of the query.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the .NET data type for the query results.
        /// </summary>
        Type DataType { get; }

        /// <summary>
        /// Gets the GraphQL data type name for the query.
        /// </summary>
        string DataTypeName { get; }

        /// <summary>
        /// Gets the filter enum type for the query.
        /// </summary>
        Type FilterType { get; }

        /// <summary>
        /// Gets or sets a value indicating whether this query is a connection (paged collection).
        /// </summary>
        bool IsConnection { get; set; }

        /// <summary>
        /// Gets the unique identifier for the root entity of the query, if specified.
        /// </summary>
        string? Id { get; }

        /// <summary>
        /// Gets the selected view for the query, if specified.
        /// </summary>
        string? SelectedView { get; }

        /// <summary>
        /// Gets the maximum number of items returned per request, if specified.
        /// </summary>
        int? ItemsPerRequest { get; }

        /// <summary>
        /// Gets the field name used for ordering, if specified.
        /// </summary>
        string? OrderBy { get; }

        /// <summary>
        /// Gets the sort order ("asc" or "desc"), if specified.
        /// </summary>
        string? SortOrder { get; }

        /// <summary>
        /// Gets a value indicating whether all fields should be selected in the query.
        /// </summary>
        bool SelectAll { get; }

        /// <summary>
        /// Gets the list of field names selected in the query.
        /// </summary>
        IReadOnlyList<string> Fields { get; }

        /// <summary>
        /// Gets the list of filters applied to the query.
        /// </summary>
        IReadOnlyList<QueryFilter> Filters { get; }

        /// <summary>
        /// Gets the list of nested or related sub-queries.
        /// </summary>
        IReadOnlyList<IQuery> Queries { get; }

        /// <summary>
        /// Gets the list of "on-type" sub-queries for interface handling.
        /// </summary>
        IReadOnlyList<IQuery> OnTypeQueries { get; }

        /// <summary>
        /// Creates a deep clone of this query instance.
        /// </summary>
        /// <returns>A new <see cref="IQuery"/> instance with the same configuration.</returns>
        IQuery Clone();
    }
}
