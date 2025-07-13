using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Extensions;
using Works4me.Xurrent.GraphQL.Utilities;

namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Base class for building GraphQL queries for Xurrent.
    /// Provides fluent methods for selecting fields, adding filters, specifying sort order, and configuring paging.
    /// </summary>
    /// <typeparam name="TEntity">The entity type being queried.</typeparam>
    /// <typeparam name="TQueryEntity">The concrete query type deriving from this base.</typeparam>
    /// <typeparam name="TView">An enumeration of predefined views for selecting a default set of fields.</typeparam>
    /// <typeparam name="TField">An enumeration of selectable fields for the entity.</typeparam>
    /// <typeparam name="TFilterField">An enumeration of filterable fields for the entity.</typeparam>
    /// <typeparam name="TOrderByField">An enumeration of sortable fields for the entity.</typeparam>

    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class Query<TEntity, TQueryEntity, TView, TField, TFilterField, TOrderByField> : IQuery
        where TEntity : class
        where TQueryEntity : Query<TEntity, TQueryEntity, TView, TField, TFilterField, TOrderByField>
        where TView : Enum
        where TField : Enum
        where TFilterField : Enum
        where TOrderByField : Enum
    {
        /// <summary>
        /// Gets the current instance cast to the concrete query type.
        /// </summary>
        protected TQueryEntity Self => (TQueryEntity)this;

        private string _name;
        private readonly Type _dataType;
        private readonly string _dataTypeName;
        private readonly Type _filterType;
        private bool _isConnection;
        private string? _id;
        private string? _view;
        private string? _orderByField;
        private string? _orderBySortOrder;
        private int? _itemPerRequest;
        private bool _selectAll;
        private List<string> _fields = new();
        private List<QueryFilter> _filters = new();
        private List<IQuery> _queries = new();
        private List<IQuery> _onTypeQueries = new();

        /// <inheritdoc/>
        string IQuery.Name
        {
            get => _name;
            set => _name = value;
        }

        /// <inheritdoc/>
        Type IQuery.DataType
        {
            get => _dataType;
        }

        /// <inheritdoc/>
        string IQuery.DataTypeName
        {
            get => _dataTypeName;
        }

        /// <inheritdoc/>
        Type IQuery.FilterType
        {
            get => _filterType;
        }

        /// <inheritdoc/>
        bool IQuery.IsConnection
        {
            get => _isConnection;
            set => _isConnection = value;
        }

        /// <inheritdoc/>
        string? IQuery.Id
        {
            get => _id;
        }

        /// <inheritdoc/>
        string? IQuery.SelectedView 
        {
            get => _view; 
        }

        /// <inheritdoc/>
        string? IQuery.OrderBy
        {
            get => _orderByField;
        }

        /// <inheritdoc/>
        string? IQuery.SortOrder
        {
            get => _orderBySortOrder;
        }

        /// <inheritdoc/>
        int? IQuery.ItemsPerRequest
        {
            get => _itemPerRequest;
        }

        /// <inheritdoc/>
        bool IQuery.SelectAll
        {
            get => _selectAll;
        }

        /// <inheritdoc/>
        IReadOnlyList<string> IQuery.Fields 
        {
            get => _fields; 
        }

        /// <inheritdoc/>
        IReadOnlyList<QueryFilter> IQuery.Filters
        {
            get => _filters; 
        }

        /// <inheritdoc/>
        IReadOnlyList<IQuery> IQuery.Queries 
        {
            get => _queries; 
        }

        /// <inheritdoc/>
        IReadOnlyList<IQuery> IQuery.OnTypeQueries
        {
            get => _onTypeQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query{TEntity, TQueryEntity, TView, TField, TFilterField, TOrderByField}"/> base class.
        /// </summary>
        /// <param name="name">The GraphQL field name corresponding to this query (for example, "account" or "configurationItem").</param>
        /// <param name="isConnection"><c>true</c> if this query represents a connection (paged list) type; <c>false</c> if it represents a single node.</param>
        private protected Query(string name, bool isConnection)
        {
            _dataType = typeof(TEntity);
            _dataTypeName = _dataType.GetCustomAttribute<XurrentEntityAttribute>()?.DataTypeName ?? string.Empty;
            _filterType = typeof(TFilterField);
            _name = name;
            _isConnection = isConnection;
        }

        /// <summary>
        /// Selects a predefined view (set of fields) for the query.
        /// </summary>
        /// <param name="value">The <typeparamref name="TView"/> enum value representing the desired view.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the selected view.</returns>
        public TQueryEntity View(TView value) 
        {
            _view = value.GetXurrentEnumValue();
            return Self;
        }

        /// <summary>
        /// Adds one or more fields to the GraphQL selection set for this query.
        /// </summary>
        /// <param name="fields">An array of <typeparamref name="TField"/> enum values indicating which fields to select.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated to include the specified fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="fields"/> is <c>null</c>.</exception>
        public TQueryEntity Select(params TField[] fields)
        {
            if (fields is null)
                throw new ArgumentNullException(nameof(fields));

            foreach (TField field in fields)
            {
                string? fieldName = field.GetXurrentEnumValue();
                if (fieldName is not null && !_fields.Contains(fieldName))
                    _fields.Add(fieldName);
            }
            return Self;
        }

        /// <summary>
        /// Selects all fields for the entity. Equivalent to fetching every available field.
        /// </summary>
        /// <remarks>
        /// <b>Warning:</b> This method will significantly impact performance.<br />
        /// It is intended for debugging or testing purposes. Using this method in production may fail if certain fields do not yet exist in the production schema.<br />
        /// </remarks>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance with the <c>SelectAll</c> flag set.</returns>
        public TQueryEntity SelectAll()
        {
            _selectAll = true;
            return Self;
        }

        /// <summary>
        /// Restricts the query to a single entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity to retrieve.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the <c>id</c> filter.</returns>
        public TQueryEntity WithId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException($"'{nameof(id)}' cannot be null or whitespace.", nameof(id));

            _id = id;
            return Self;
        }

        /// <summary>
        /// Specifies an ordering for the query results.
        /// </summary>
        /// <param name="field">The <typeparamref name="TOrderByField"/> enum value representing the field to sort by.</param>
        /// <param name="sortOrder">The <see cref="SortOrder"/> (ascending or descending) to apply.</param>
        /// <returns>he same <typeparamref name="TQueryEntity"/> instance, updated with the specified ordering.</returns>
        public TQueryEntity OrderBy(TOrderByField field, SortOrder sortOrder)
        {
            _orderByField = field.GetXurrentEnumValue();
            _orderBySortOrder = sortOrder.GetXurrentEnumValue();
            return Self;
        }

        /// <summary>
        /// Sets the maximum number of items to return per request for a connection query.
        /// </summary>
        /// <param name="count">The desired number of items per request. Must be between 1 and 100, inclusive.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the specified item count.</returns>
        /// <exception cref="XurrentQueryException">Thrown if <paramref name="count"/> is less than 1 or greater than 100.</exception>
        public TQueryEntity ItemsPerRequest(int count)
        {
            if (count < 1 || count > 100)
                throw new XurrentQueryException($"Invalid item count: {count}. ItemsPerRequest must be between 1 and 100 inclusive.");

            _itemPerRequest = count;
            return Self;
        }

        /// <summary>
        /// Selects a nested query for a child field or collection.
        /// </summary>
        /// <typeparam name="TNestedGraphQuery">The type of the nested query.</typeparam>
        /// <param name="name">The GraphQL field name for the nested query.</param>
        /// <param name="nestedQuery">The nested query instance to add.</param>
        /// <param name="isConnection">True if the nested query represents a connection (paged list); otherwise, false.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, with the nested query added.</returns>
        internal TQueryEntity Select<TNestedGraphQuery>(string name, TNestedGraphQuery nestedQuery, bool isConnection)
            where TNestedGraphQuery : IQuery
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));

            nestedQuery.Name = name;
            nestedQuery.IsConnection = isConnection;

            IQuery? existingQuery = _queries.FirstOrDefault(x => x.Name == name);
            if (existingQuery is not null)
                _queries.Remove(existingQuery);

            _queries.Add(nestedQuery);
            return Self;
        }

        /// <summary>
        /// Selects an "on-type" nested query for an interface or union field.
        /// </summary>
        /// <typeparam name="TNestedGraphQuery">The type of the nested query.</typeparam>
        /// <param name="name">The GraphQL type condition name.</param>
        /// <param name="onTypeQuery">The nested query for the specific type.</param>
        /// <param name="isConnection">True if the nested query represents a connection (paged list); otherwise, false.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, with the on-type query added.</returns>
        internal TQueryEntity SelectOnType<TNestedGraphQuery>(string name, TNestedGraphQuery onTypeQuery, bool isConnection)
            where TNestedGraphQuery : IQuery
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));

            IQuery newOnTypeQuery = onTypeQuery.Clone();
            newOnTypeQuery.Name = name;
            newOnTypeQuery.IsConnection = isConnection;

            IQuery? existingOnTypeQuery = _onTypeQueries.FirstOrDefault(x => x.Name == name && x.DataTypeName == newOnTypeQuery.DataTypeName);
            if (existingOnTypeQuery is not null)
                _onTypeQueries.Remove(existingOnTypeQuery);

            _onTypeQueries.Add(newOnTypeQuery);
            return Self;
        }

        /// <summary>
        /// Adds a filter condition where the specified field must match one of no values.
        /// </summary>
        /// <param name="field">The <typeparamref name="TFilterField"/> enum value representing the field to filter.</param>
        /// <param name="op">The <see cref="FilterOperator"/> specifying how to compare the field.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the filter condition.</returns>
        public TQueryEntity Where(TFilterField field, FilterOperator op)
        {
            return AddFilter(field, op, Array.Empty<string>(), FilterValueType.String);
        }

        /// <summary>
        /// Adds a filter condition where the specified boolean field must match the given value.
        /// </summary>
        /// <param name="field">The <typeparamref name="TFilterField"/> enum value representing the field to filter.</param>
        /// <param name="op">The <see cref="FilterOperator"/> specifying how to compare the field.</param>
        /// <param name="value">The boolean value to compare against.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the filter condition.</returns>
        public TQueryEntity Where(TFilterField field, FilterOperator op, bool value)
        {
            return AddFilter(field, op, value ? "true" : "false", FilterValueType.Boolean);
        }

        /// <summary>
        /// Adds a filter condition where the specified numeric field must match one of the given integer values.
        /// </summary>
        /// <param name="field">The <typeparamref name="TFilterField"/> enum value representing the field to filter.</param>
        /// <param name="op">The <see cref="FilterOperator"/> specifying how to compare the field.</param>
        /// <param name="values">A collection of integer values to compare against.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the filter condition.</returns>
        public TQueryEntity Where(TFilterField field, FilterOperator op, params int?[] values)
        {
            return AddFilter(field, op, values.Select(x => x?.ToString(CultureInfo.InvariantCulture)).ToArray(), FilterValueType.Integer);
        }

        /// <summary>
        /// Adds a filter condition where the specified date/time field must match one of the given <see cref="DateTime"/> values.
        /// </summary>
        /// <param name="field">The <typeparamref name="TFilterField"/> enum value representing the field to filter.</param>
        /// <param name="op">The <see cref="FilterOperator"/> specifying how to compare the field.</param>
        /// <param name="values">A collection of <see cref="DateTime"/> values to compare against.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the filter condition.</returns>
        public TQueryEntity Where(TFilterField field, FilterOperator op, params DateTime?[] values)
        {
            return AddFilter(field, op, values.Select(x => x?.ToString(Constants.DateTimeFormat, CultureInfo.InvariantCulture)).ToArray(), FilterValueType.DateTime);
        }

        /// <summary>
        /// Adds a filter condition where the specified enum field must match one of the given enum values.
        /// </summary>
        /// <param name="field">The <typeparamref name="TFilterField"/> enum value representing the field to filter.</param>
        /// <param name="op">The <see cref="FilterOperator"/> specifying how to compare the field</param>
        /// <param name="values">A collection of <see cref="Enum"/> values to compare against.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the filter condition.</returns>
        public TQueryEntity Where(TFilterField field, FilterOperator op, params Enum[] values)
        {
            return AddFilter(field, op, values.Select(x => x.GetXurrentEnumValue()).Where(x => x is not null).Distinct().ToArray(), FilterValueType.String);
        }

        /// <summary>
        /// Adds a filter condition where the specified string field must match one of the given string values.
        /// </summary>
        /// <param name="field">The <typeparamref name="TFilterField"/> enum value representing the field to filter.</param>
        /// <param name="op">The <see cref="FilterOperator"/> specifying how to compare the field.</param>
        /// <param name="values">A collection of string values to compare against.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the filter condition.</returns>
        public TQueryEntity Where(TFilterField field, FilterOperator op, params string?[] values)
        {
            return AddFilter(field, op, values, FilterValueType.String);
        }

        /// <summary>
        /// Adds a filter to the query using a single value.
        /// </summary>
        /// <param name="field">The filter field enum value.</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="value">The value to filter by.</param>
        /// <param name="valueType">The value type for the filter.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the filter condition.</returns>
        private TQueryEntity AddFilter(TFilterField field, FilterOperator op, string? value, FilterValueType valueType)
        {
            return AddFilter(field, op, new[] { value }, valueType);
        }

        /// <summary>
        /// Adds a filter to the query using one or more values.
        /// </summary>
        /// <param name="field">The filter field enum value.</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="values">The values to filter by.</param>
        /// <param name="valueType">The value type for the filter.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance with the filter added.</returns>
        private TQueryEntity AddFilter(TFilterField field, FilterOperator op, string?[] values, FilterValueType valueType)
        {
            string? name = field.GetXurrentEnumValue();
            if (name is not null)
                _filters.Add(new QueryFilter(name, op, values, valueType));
            return Self;
        }

        /// <summary>
        /// Adds a custom filter condition by name, operator, and values.
        /// </summary>
        /// <param name="name">The string name of the filter.</param>
        /// <param name="op">The <see cref="FilterOperator"/> specifying how to compare the field.</param>
        /// <param name="values">A collection of string values to compare against</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the filter condition.</returns>
        internal protected TQueryEntity AddCustomFilter(string name, FilterOperator op, params string?[] values)
        {
            if (!string.IsNullOrWhiteSpace(name))
                _filters.Add(new QueryFilter(name, op, values, FilterValueType.Custom));
            return Self;
        }

        /// <summary>
        /// Adds a query-text filter condition (search query) to the request.
        /// </summary>
        /// <param name="value">The query string to match.</param>
        /// <returns>The same <typeparamref name="TQueryEntity"/> instance, updated with the text filter.</returns>
        internal protected TQueryEntity AddQueryFilter(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
                _filters.Add(new QueryFilter("query", FilterOperator.Equals, new[] { value }, FilterValueType.Query));
            return Self;
        }

        /// <summary>
        /// Creates a deep clone of this query, including any selected fields, filters, nested queries, and pagination settings.
        /// </summary>
        /// <returns>A new <see cref="IQuery"/> instance that is a copy of the current query, suitable for creating branched sub-queries.</returns>
        IQuery IQuery.Clone()
        {
            Query<TEntity, TQueryEntity, TView, TField, TFilterField, TOrderByField> retval = (Query<TEntity, TQueryEntity, TView, TField, TFilterField, TOrderByField>)MemberwiseClone();
            retval._fields = new(_fields);
            retval._filters = new(_filters);
            retval._queries = new(_queries);
            retval._onTypeQueries = new(_onTypeQueries);
            return retval;
        }
    }
}
