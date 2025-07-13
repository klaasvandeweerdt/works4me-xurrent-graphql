using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Works4me.Xurrent.GraphQL
{
    public partial class XurrentClient
    {
        /// <summary>
        /// Executes the specified <see cref="AccountQuery"/> and returns a single <see cref="Account"/> or <c>null</c>.
        /// </summary>
        /// <param name="query">The <see cref="AccountQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{Account}"/> representing the asynchronous operation, containing the single <see cref="Account"/> or <c>null</c>.</returns>
        public Task<Account?> GetAsync(AccountQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Account>(GetAccountId(), query, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="AffectedSlaQuery"/> and returns a <see cref="ReadOnlyDataCollection{AffectedSla}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="AffectedSlaQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{AffectedSla}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<AffectedSla>> GetAsync(AffectedSlaQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<AffectedSla>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="AffectedSlaQuery"/>, yielding each <see cref="ReadOnlyDataCollection{AffectedSla}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="AffectedSlaQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{AffectedSla}"/> page of results.</returns>
        public IAsyncEnumerable<AffectedSla> StreamAsync(AffectedSlaQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<AffectedSla>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="AgileBoardQuery"/> and returns a <see cref="ReadOnlyDataCollection{AgileBoard}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="AgileBoardQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{AgileBoard}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<AgileBoard>> GetAsync(AgileBoardQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<AgileBoard>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="AgileBoardQuery"/>, yielding each <see cref="ReadOnlyDataCollection{AgileBoard}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="AgileBoardQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{AgileBoard}"/> page of results.</returns>
        public IAsyncEnumerable<AgileBoard> StreamAsync(AgileBoardQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<AgileBoard>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="AppInstanceQuery"/> and returns a <see cref="ReadOnlyDataCollection{AppInstance}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="AppInstanceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{AppInstance}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<AppInstance>> GetAsync(AppInstanceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<AppInstance>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="AppInstanceQuery"/>, yielding each <see cref="ReadOnlyDataCollection{AppInstance}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="AppInstanceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{AppInstance}"/> page of results.</returns>
        public IAsyncEnumerable<AppInstance> StreamAsync(AppInstanceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<AppInstance>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="AppOfferingQuery"/> and returns a <see cref="ReadOnlyDataCollection{AppOffering}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="AppOfferingQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{AppOffering}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<AppOffering>> GetAsync(AppOfferingQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<AppOffering>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="AppOfferingQuery"/>, yielding each <see cref="ReadOnlyDataCollection{AppOffering}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="AppOfferingQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{AppOffering}"/> page of results.</returns>
        public IAsyncEnumerable<AppOffering> StreamAsync(AppOfferingQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<AppOffering>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ArchiveQuery"/> and returns a <see cref="ReadOnlyDataCollection{Archive}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ArchiveQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Archive}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Archive>> GetAsync(ArchiveQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Archive>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ArchiveQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Archive}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ArchiveQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Archive}"/> page of results.</returns>
        public IAsyncEnumerable<Archive> StreamAsync(ArchiveQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Archive>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="AttachmentStorageQuery"/> and returns a single <see cref="AttachmentStorage"/> or <c>null</c>.
        /// </summary>
        /// <param name="query">The <see cref="AttachmentStorageQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{AttachmentStorage}"/> representing the asynchronous operation, containing the single <see cref="AttachmentStorage"/> or <c>null</c>.</returns>
        public Task<AttachmentStorage?> GetAsync(AttachmentStorageQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<AttachmentStorage>(GetAccountId(), query, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="AutomationRuleQuery"/> and returns a <see cref="ReadOnlyDataCollection{AutomationRule}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="AutomationRuleQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{AutomationRule}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<AutomationRule>> GetAsync(AutomationRuleQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<AutomationRule>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="AutomationRuleQuery"/>, yielding each <see cref="ReadOnlyDataCollection{AutomationRule}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="AutomationRuleQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{AutomationRule}"/> page of results.</returns>
        public IAsyncEnumerable<AutomationRule> StreamAsync(AutomationRuleQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<AutomationRule>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="BroadcastQuery"/> and returns a <see cref="ReadOnlyDataCollection{Broadcast}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="BroadcastQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Broadcast}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Broadcast>> GetAsync(BroadcastQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Broadcast>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="BroadcastQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Broadcast}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="BroadcastQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Broadcast}"/> page of results.</returns>
        public IAsyncEnumerable<Broadcast> StreamAsync(BroadcastQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Broadcast>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="CalendarQuery"/> and returns a <see cref="ReadOnlyDataCollection{Calendar}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="CalendarQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Calendar}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Calendar>> GetAsync(CalendarQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Calendar>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="CalendarQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Calendar}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="CalendarQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Calendar}"/> page of results.</returns>
        public IAsyncEnumerable<Calendar> StreamAsync(CalendarQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Calendar>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ClosureCodeQuery"/> and returns a <see cref="ReadOnlyDataCollection{ClosureCode}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ClosureCodeQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ClosureCode}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ClosureCode>> GetAsync(ClosureCodeQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ClosureCode>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ClosureCodeQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ClosureCode}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ClosureCodeQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ClosureCode}"/> page of results.</returns>
        public IAsyncEnumerable<ClosureCode> StreamAsync(ClosureCodeQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ClosureCode>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ConfigurationItemQuery"/> and returns a <see cref="ReadOnlyDataCollection{ConfigurationItem}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ConfigurationItemQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ConfigurationItem}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ConfigurationItem>> GetAsync(ConfigurationItemQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ConfigurationItem>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ConfigurationItemQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ConfigurationItem}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ConfigurationItemQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ConfigurationItem}"/> page of results.</returns>
        public IAsyncEnumerable<ConfigurationItem> StreamAsync(ConfigurationItemQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ConfigurationItem>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ContractQuery"/> and returns a <see cref="ReadOnlyDataCollection{Contract}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ContractQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Contract}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Contract>> GetAsync(ContractQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Contract>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ContractQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Contract}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ContractQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Contract}"/> page of results.</returns>
        public IAsyncEnumerable<Contract> StreamAsync(ContractQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Contract>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="CustomCollectionElementQuery"/> and returns a <see cref="ReadOnlyDataCollection{CustomCollectionElement}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="CustomCollectionElementQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{CustomCollectionElement}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<CustomCollectionElement>> GetAsync(CustomCollectionElementQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<CustomCollectionElement>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="CustomCollectionElementQuery"/>, yielding each <see cref="ReadOnlyDataCollection{CustomCollectionElement}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="CustomCollectionElementQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{CustomCollectionElement}"/> page of results.</returns>
        public IAsyncEnumerable<CustomCollectionElement> StreamAsync(CustomCollectionElementQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<CustomCollectionElement>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="CustomCollectionQuery"/> and returns a <see cref="ReadOnlyDataCollection{CustomCollection}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="CustomCollectionQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{CustomCollection}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<CustomCollection>> GetAsync(CustomCollectionQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<CustomCollection>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="CustomCollectionQuery"/>, yielding each <see cref="ReadOnlyDataCollection{CustomCollection}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="CustomCollectionQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{CustomCollection}"/> page of results.</returns>
        public IAsyncEnumerable<CustomCollection> StreamAsync(CustomCollectionQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<CustomCollection>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="EffortClassQuery"/> and returns a <see cref="ReadOnlyDataCollection{EffortClass}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="EffortClassQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{EffortClass}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<EffortClass>> GetAsync(EffortClassQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<EffortClass>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="EffortClassQuery"/>, yielding each <see cref="ReadOnlyDataCollection{EffortClass}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="EffortClassQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{EffortClass}"/> page of results.</returns>
        public IAsyncEnumerable<EffortClass> StreamAsync(EffortClassQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<EffortClass>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="FirstLineSupportAgreementQuery"/> and returns a <see cref="ReadOnlyDataCollection{FirstLineSupportAgreement}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="FirstLineSupportAgreementQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{FirstLineSupportAgreement}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<FirstLineSupportAgreement>> GetAsync(FirstLineSupportAgreementQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<FirstLineSupportAgreement>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="FirstLineSupportAgreementQuery"/>, yielding each <see cref="ReadOnlyDataCollection{FirstLineSupportAgreement}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="FirstLineSupportAgreementQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{FirstLineSupportAgreement}"/> page of results.</returns>
        public IAsyncEnumerable<FirstLineSupportAgreement> StreamAsync(FirstLineSupportAgreementQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<FirstLineSupportAgreement>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="HolidayQuery"/> and returns a <see cref="ReadOnlyDataCollection{Holiday}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="HolidayQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Holiday}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Holiday>> GetAsync(HolidayQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Holiday>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="HolidayQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Holiday}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="HolidayQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Holiday}"/> page of results.</returns>
        public IAsyncEnumerable<Holiday> StreamAsync(HolidayQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Holiday>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="InvoiceQuery"/> and returns a <see cref="ReadOnlyDataCollection{Invoice}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="InvoiceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Invoice}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Invoice>> GetAsync(InvoiceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Invoice>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="InvoiceQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Invoice}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="InvoiceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Invoice}"/> page of results.</returns>
        public IAsyncEnumerable<Invoice> StreamAsync(InvoiceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Invoice>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="KnowledgeArticleTemplateQuery"/> and returns a <see cref="ReadOnlyDataCollection{KnowledgeArticleTemplate}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="KnowledgeArticleTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{KnowledgeArticleTemplate}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<KnowledgeArticleTemplate>> GetAsync(KnowledgeArticleTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<KnowledgeArticleTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="KnowledgeArticleTemplateQuery"/>, yielding each <see cref="ReadOnlyDataCollection{KnowledgeArticleTemplate}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="KnowledgeArticleTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{KnowledgeArticleTemplate}"/> page of results.</returns>
        public IAsyncEnumerable<KnowledgeArticleTemplate> StreamAsync(KnowledgeArticleTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<KnowledgeArticleTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="KnowledgeArticleQuery"/> and returns a <see cref="ReadOnlyDataCollection{KnowledgeArticle}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="KnowledgeArticleQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{KnowledgeArticle}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<KnowledgeArticle>> GetAsync(KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<KnowledgeArticle>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="KnowledgeArticleQuery"/>, yielding each <see cref="ReadOnlyDataCollection{KnowledgeArticle}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="KnowledgeArticleQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{KnowledgeArticle}"/> page of results.</returns>
        public IAsyncEnumerable<KnowledgeArticle> StreamAsync(KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<KnowledgeArticle>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="MeQuery"/> and returns a single <see cref="Person"/> or <c>null</c>.
        /// </summary>
        /// <param name="query">The <see cref="MeQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{Person}"/> representing the asynchronous operation, containing the single <see cref="Person"/> or <c>null</c>.</returns>
        public Task<Person?> GetAsync(MeQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Person>(GetAccountId(), query, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="OrganizationQuery"/> and returns a <see cref="ReadOnlyDataCollection{Organization}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="OrganizationQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Organization}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Organization>> GetAsync(OrganizationQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Organization>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="OrganizationQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Organization}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="OrganizationQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Organization}"/> page of results.</returns>
        public IAsyncEnumerable<Organization> StreamAsync(OrganizationQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Organization>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="OutOfOfficePeriodQuery"/> and returns a <see cref="ReadOnlyDataCollection{OutOfOfficePeriod}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="OutOfOfficePeriodQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{OutOfOfficePeriod}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<OutOfOfficePeriod>> GetAsync(OutOfOfficePeriodQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<OutOfOfficePeriod>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="OutOfOfficePeriodQuery"/>, yielding each <see cref="ReadOnlyDataCollection{OutOfOfficePeriod}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="OutOfOfficePeriodQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{OutOfOfficePeriod}"/> page of results.</returns>
        public IAsyncEnumerable<OutOfOfficePeriod> StreamAsync(OutOfOfficePeriodQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<OutOfOfficePeriod>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="PdfDesignQuery"/> and returns a <see cref="ReadOnlyDataCollection{PdfDesign}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="PdfDesignQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{PdfDesign}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<PdfDesign>> GetAsync(PdfDesignQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<PdfDesign>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="PdfDesignQuery"/>, yielding each <see cref="ReadOnlyDataCollection{PdfDesign}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="PdfDesignQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{PdfDesign}"/> page of results.</returns>
        public IAsyncEnumerable<PdfDesign> StreamAsync(PdfDesignQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<PdfDesign>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="PersonQuery"/> and returns a <see cref="ReadOnlyDataCollection{Person}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="PersonQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Person}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Person>> GetAsync(PersonQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Person>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="PersonQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Person}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="PersonQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Person}"/> page of results.</returns>
        public IAsyncEnumerable<Person> StreamAsync(PersonQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Person>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProblemQuery"/> and returns a <see cref="ReadOnlyDataCollection{Problem}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProblemQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Problem}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Problem>> GetAsync(ProblemQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Problem>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProblemQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Problem}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProblemQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Problem}"/> page of results.</returns>
        public IAsyncEnumerable<Problem> StreamAsync(ProblemQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Problem>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProductBacklogQuery"/> and returns a <see cref="ReadOnlyDataCollection{ProductBacklog}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProductBacklogQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ProductBacklog}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ProductBacklog>> GetAsync(ProductBacklogQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ProductBacklog>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProductBacklogQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ProductBacklog}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProductBacklogQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ProductBacklog}"/> page of results.</returns>
        public IAsyncEnumerable<ProductBacklog> StreamAsync(ProductBacklogQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ProductBacklog>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProductCategoryQuery"/> and returns a <see cref="ReadOnlyDataCollection{ProductCategory}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProductCategoryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ProductCategory}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ProductCategory>> GetAsync(ProductCategoryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ProductCategory>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProductCategoryQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ProductCategory}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProductCategoryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ProductCategory}"/> page of results.</returns>
        public IAsyncEnumerable<ProductCategory> StreamAsync(ProductCategoryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ProductCategory>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProductQuery"/> and returns a <see cref="ReadOnlyDataCollection{Product}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProductQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Product}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Product>> GetAsync(ProductQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Product>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProductQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Product}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProductQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Product}"/> page of results.</returns>
        public IAsyncEnumerable<Product> StreamAsync(ProductQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Product>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProjectCategoryQuery"/> and returns a <see cref="ReadOnlyDataCollection{ProjectCategory}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProjectCategoryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ProjectCategory}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ProjectCategory>> GetAsync(ProjectCategoryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ProjectCategory>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProjectCategoryQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ProjectCategory}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProjectCategoryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ProjectCategory}"/> page of results.</returns>
        public IAsyncEnumerable<ProjectCategory> StreamAsync(ProjectCategoryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ProjectCategory>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProjectRiskLevelQuery"/> and returns a <see cref="ReadOnlyDataCollection{ProjectRiskLevel}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProjectRiskLevelQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ProjectRiskLevel}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ProjectRiskLevel>> GetAsync(ProjectRiskLevelQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ProjectRiskLevel>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProjectRiskLevelQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ProjectRiskLevel}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProjectRiskLevelQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ProjectRiskLevel}"/> page of results.</returns>
        public IAsyncEnumerable<ProjectRiskLevel> StreamAsync(ProjectRiskLevelQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ProjectRiskLevel>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProjectTaskTemplateQuery"/> and returns a <see cref="ReadOnlyDataCollection{ProjectTaskTemplate}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProjectTaskTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ProjectTaskTemplate}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ProjectTaskTemplate>> GetAsync(ProjectTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ProjectTaskTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProjectTaskTemplateQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ProjectTaskTemplate}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProjectTaskTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ProjectTaskTemplate}"/> page of results.</returns>
        public IAsyncEnumerable<ProjectTaskTemplate> StreamAsync(ProjectTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ProjectTaskTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProjectTaskQuery"/> and returns a <see cref="ReadOnlyDataCollection{ProjectTask}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProjectTaskQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ProjectTask}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ProjectTask>> GetAsync(ProjectTaskQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ProjectTask>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProjectTaskQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ProjectTask}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProjectTaskQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ProjectTask}"/> page of results.</returns>
        public IAsyncEnumerable<ProjectTask> StreamAsync(ProjectTaskQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ProjectTask>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProjectTemplateQuery"/> and returns a <see cref="ReadOnlyDataCollection{ProjectTemplate}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProjectTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ProjectTemplate}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ProjectTemplate>> GetAsync(ProjectTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ProjectTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProjectTemplateQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ProjectTemplate}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProjectTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ProjectTemplate}"/> page of results.</returns>
        public IAsyncEnumerable<ProjectTemplate> StreamAsync(ProjectTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ProjectTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ProjectQuery"/> and returns a <see cref="ReadOnlyDataCollection{Project}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ProjectQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Project}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Project>> GetAsync(ProjectQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Project>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ProjectQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Project}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ProjectQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Project}"/> page of results.</returns>
        public IAsyncEnumerable<Project> StreamAsync(ProjectQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Project>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="RateLimitQuery"/> and returns a single <see cref="RateLimit"/> or <c>null</c>.
        /// </summary>
        /// <param name="query">The <see cref="RateLimitQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{RateLimit}"/> representing the asynchronous operation, containing the single <see cref="RateLimit"/> or <c>null</c>.</returns>
        public Task<RateLimit?> GetAsync(RateLimitQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<RateLimit>(GetAccountId(), query, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ReleaseQuery"/> and returns a <see cref="ReadOnlyDataCollection{Release}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ReleaseQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Release}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Release>> GetAsync(ReleaseQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Release>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ReleaseQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Release}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ReleaseQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Release}"/> page of results.</returns>
        public IAsyncEnumerable<Release> StreamAsync(ReleaseQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Release>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="RequestTemplateQuery"/> and returns a <see cref="ReadOnlyDataCollection{RequestTemplate}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="RequestTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{RequestTemplate}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<RequestTemplate>> GetAsync(RequestTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<RequestTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="RequestTemplateQuery"/>, yielding each <see cref="ReadOnlyDataCollection{RequestTemplate}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="RequestTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{RequestTemplate}"/> page of results.</returns>
        public IAsyncEnumerable<RequestTemplate> StreamAsync(RequestTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<RequestTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="RequestQuery"/> and returns a <see cref="ReadOnlyDataCollection{Request}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="RequestQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Request}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Request>> GetAsync(RequestQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Request>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="RequestQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Request}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="RequestQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Request}"/> page of results.</returns>
        public IAsyncEnumerable<Request> StreamAsync(RequestQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Request>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ReservationOfferingQuery"/> and returns a <see cref="ReadOnlyDataCollection{ReservationOffering}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ReservationOfferingQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ReservationOffering}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ReservationOffering>> GetAsync(ReservationOfferingQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ReservationOffering>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ReservationOfferingQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ReservationOffering}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ReservationOfferingQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ReservationOffering}"/> page of results.</returns>
        public IAsyncEnumerable<ReservationOffering> StreamAsync(ReservationOfferingQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ReservationOffering>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ReservationQuery"/> and returns a <see cref="ReadOnlyDataCollection{Reservation}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ReservationQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Reservation}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Reservation>> GetAsync(ReservationQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Reservation>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ReservationQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Reservation}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ReservationQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Reservation}"/> page of results.</returns>
        public IAsyncEnumerable<Reservation> StreamAsync(ReservationQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Reservation>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="RiskSeverityQuery"/> and returns a <see cref="ReadOnlyDataCollection{RiskSeverity}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="RiskSeverityQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{RiskSeverity}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<RiskSeverity>> GetAsync(RiskSeverityQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<RiskSeverity>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="RiskSeverityQuery"/>, yielding each <see cref="ReadOnlyDataCollection{RiskSeverity}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="RiskSeverityQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{RiskSeverity}"/> page of results.</returns>
        public IAsyncEnumerable<RiskSeverity> StreamAsync(RiskSeverityQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<RiskSeverity>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="RiskQuery"/> and returns a <see cref="ReadOnlyDataCollection{Risk}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="RiskQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Risk}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Risk>> GetAsync(RiskQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Risk>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="RiskQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Risk}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="RiskQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Risk}"/> page of results.</returns>
        public IAsyncEnumerable<Risk> StreamAsync(RiskQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Risk>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ScrumWorkspaceQuery"/> and returns a <see cref="ReadOnlyDataCollection{ScrumWorkspace}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ScrumWorkspaceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ScrumWorkspace}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ScrumWorkspace>> GetAsync(ScrumWorkspaceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ScrumWorkspace>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ScrumWorkspaceQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ScrumWorkspace}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ScrumWorkspaceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ScrumWorkspace}"/> page of results.</returns>
        public IAsyncEnumerable<ScrumWorkspace> StreamAsync(ScrumWorkspaceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ScrumWorkspace>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ServiceCategoryQuery"/> and returns a <see cref="ReadOnlyDataCollection{ServiceCategory}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ServiceCategoryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ServiceCategory}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ServiceCategory>> GetAsync(ServiceCategoryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ServiceCategory>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ServiceCategoryQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ServiceCategory}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ServiceCategoryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ServiceCategory}"/> page of results.</returns>
        public IAsyncEnumerable<ServiceCategory> StreamAsync(ServiceCategoryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ServiceCategory>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ServiceInstanceQuery"/> and returns a <see cref="ReadOnlyDataCollection{ServiceInstance}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ServiceInstanceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ServiceInstance}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ServiceInstance>> GetAsync(ServiceInstanceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ServiceInstance>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ServiceInstanceQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ServiceInstance}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ServiceInstanceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ServiceInstance}"/> page of results.</returns>
        public IAsyncEnumerable<ServiceInstance> StreamAsync(ServiceInstanceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ServiceInstance>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ServiceLevelAgreementQuery"/> and returns a <see cref="ReadOnlyDataCollection{ServiceLevelAgreement}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ServiceLevelAgreementQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ServiceLevelAgreement}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ServiceLevelAgreement>> GetAsync(ServiceLevelAgreementQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ServiceLevelAgreement>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ServiceLevelAgreementQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ServiceLevelAgreement}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ServiceLevelAgreementQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ServiceLevelAgreement}"/> page of results.</returns>
        public IAsyncEnumerable<ServiceLevelAgreement> StreamAsync(ServiceLevelAgreementQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ServiceLevelAgreement>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ServiceOfferingQuery"/> and returns a <see cref="ReadOnlyDataCollection{ServiceOffering}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ServiceOfferingQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ServiceOffering}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ServiceOffering>> GetAsync(ServiceOfferingQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ServiceOffering>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ServiceOfferingQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ServiceOffering}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ServiceOfferingQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ServiceOffering}"/> page of results.</returns>
        public IAsyncEnumerable<ServiceOffering> StreamAsync(ServiceOfferingQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ServiceOffering>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ServiceQuery"/> and returns a <see cref="ReadOnlyDataCollection{Service}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ServiceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Service}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Service>> GetAsync(ServiceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Service>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ServiceQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Service}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ServiceQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Service}"/> page of results.</returns>
        public IAsyncEnumerable<Service> StreamAsync(ServiceQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Service>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ShopArticleCategoryQuery"/> and returns a <see cref="ReadOnlyDataCollection{ShopArticleCategory}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ShopArticleCategoryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ShopArticleCategory}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ShopArticleCategory>> GetAsync(ShopArticleCategoryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ShopArticleCategory>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ShopArticleCategoryQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ShopArticleCategory}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ShopArticleCategoryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ShopArticleCategory}"/> page of results.</returns>
        public IAsyncEnumerable<ShopArticleCategory> StreamAsync(ShopArticleCategoryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ShopArticleCategory>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ShopArticleQuery"/> and returns a <see cref="ReadOnlyDataCollection{ShopArticle}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ShopArticleQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ShopArticle}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ShopArticle>> GetAsync(ShopArticleQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ShopArticle>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ShopArticleQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ShopArticle}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ShopArticleQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ShopArticle}"/> page of results.</returns>
        public IAsyncEnumerable<ShopArticle> StreamAsync(ShopArticleQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ShopArticle>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ShopOrderLineQuery"/> and returns a <see cref="ReadOnlyDataCollection{ShopOrderLine}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ShopOrderLineQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ShopOrderLine}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ShopOrderLine>> GetAsync(ShopOrderLineQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ShopOrderLine>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ShopOrderLineQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ShopOrderLine}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ShopOrderLineQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ShopOrderLine}"/> page of results.</returns>
        public IAsyncEnumerable<ShopOrderLine> StreamAsync(ShopOrderLineQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ShopOrderLine>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="ShortUrlQuery"/> and returns a <see cref="ReadOnlyDataCollection{ShortUrl}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="ShortUrlQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{ShortUrl}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<ShortUrl>> GetAsync(ShortUrlQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<ShortUrl>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="ShortUrlQuery"/>, yielding each <see cref="ReadOnlyDataCollection{ShortUrl}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="ShortUrlQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{ShortUrl}"/> page of results.</returns>
        public IAsyncEnumerable<ShortUrl> StreamAsync(ShortUrlQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<ShortUrl>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="SiteQuery"/> and returns a <see cref="ReadOnlyDataCollection{Site}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="SiteQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Site}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Site>> GetAsync(SiteQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Site>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="SiteQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Site}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="SiteQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Site}"/> page of results.</returns>
        public IAsyncEnumerable<Site> StreamAsync(SiteQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Site>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="SkillPoolQuery"/> and returns a <see cref="ReadOnlyDataCollection{SkillPool}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="SkillPoolQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{SkillPool}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<SkillPool>> GetAsync(SkillPoolQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<SkillPool>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="SkillPoolQuery"/>, yielding each <see cref="ReadOnlyDataCollection{SkillPool}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="SkillPoolQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{SkillPool}"/> page of results.</returns>
        public IAsyncEnumerable<SkillPool> StreamAsync(SkillPoolQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<SkillPool>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="SlaNotificationSchemeQuery"/> and returns a <see cref="ReadOnlyDataCollection{SlaNotificationScheme}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="SlaNotificationSchemeQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{SlaNotificationScheme}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<SlaNotificationScheme>> GetAsync(SlaNotificationSchemeQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<SlaNotificationScheme>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="SlaNotificationSchemeQuery"/>, yielding each <see cref="ReadOnlyDataCollection{SlaNotificationScheme}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="SlaNotificationSchemeQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{SlaNotificationScheme}"/> page of results.</returns>
        public IAsyncEnumerable<SlaNotificationScheme> StreamAsync(SlaNotificationSchemeQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<SlaNotificationScheme>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="SprintQuery"/> and returns a <see cref="ReadOnlyDataCollection{Sprint}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="SprintQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Sprint}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Sprint>> GetAsync(SprintQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Sprint>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="SprintQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Sprint}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="SprintQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Sprint}"/> page of results.</returns>
        public IAsyncEnumerable<Sprint> StreamAsync(SprintQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Sprint>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="SurveyResponseQuery"/> and returns a <see cref="ReadOnlyDataCollection{SurveyResponse}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="SurveyResponseQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{SurveyResponse}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<SurveyResponse>> GetAsync(SurveyResponseQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<SurveyResponse>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="SurveyResponseQuery"/>, yielding each <see cref="ReadOnlyDataCollection{SurveyResponse}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="SurveyResponseQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{SurveyResponse}"/> page of results.</returns>
        public IAsyncEnumerable<SurveyResponse> StreamAsync(SurveyResponseQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<SurveyResponse>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="SurveyQuery"/> and returns a <see cref="ReadOnlyDataCollection{Survey}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="SurveyQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Survey}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Survey>> GetAsync(SurveyQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Survey>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="SurveyQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Survey}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="SurveyQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Survey}"/> page of results.</returns>
        public IAsyncEnumerable<Survey> StreamAsync(SurveyQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Survey>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="SyncSetQuery"/> and returns a <see cref="ReadOnlyDataCollection{SyncSet}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="SyncSetQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{SyncSet}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<SyncSet>> GetAsync(SyncSetQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<SyncSet>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="SyncSetQuery"/>, yielding each <see cref="ReadOnlyDataCollection{SyncSet}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="SyncSetQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{SyncSet}"/> page of results.</returns>
        public IAsyncEnumerable<SyncSet> StreamAsync(SyncSetQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<SyncSet>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="WorkflowTaskTemplateQuery"/> and returns a <see cref="ReadOnlyDataCollection{WorkflowTaskTemplate}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowTaskTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{WorkflowTaskTemplate}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<WorkflowTaskTemplate>> GetAsync(WorkflowTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<WorkflowTaskTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="WorkflowTaskTemplateQuery"/>, yielding each <see cref="ReadOnlyDataCollection{WorkflowTaskTemplate}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowTaskTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{WorkflowTaskTemplate}"/> page of results.</returns>
        public IAsyncEnumerable<WorkflowTaskTemplate> StreamAsync(WorkflowTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<WorkflowTaskTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="WorkflowTaskQuery"/> and returns a <see cref="ReadOnlyDataCollection{WorkflowTask}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowTaskQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{WorkflowTask}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<WorkflowTask>> GetAsync(WorkflowTaskQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<WorkflowTask>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="WorkflowTaskQuery"/>, yielding each <see cref="ReadOnlyDataCollection{WorkflowTask}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowTaskQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{WorkflowTask}"/> page of results.</returns>
        public IAsyncEnumerable<WorkflowTask> StreamAsync(WorkflowTaskQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<WorkflowTask>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="TeamQuery"/> and returns a <see cref="ReadOnlyDataCollection{Team}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="TeamQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Team}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Team>> GetAsync(TeamQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Team>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="TeamQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Team}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="TeamQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Team}"/> page of results.</returns>
        public IAsyncEnumerable<Team> StreamAsync(TeamQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Team>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="TimeAllocationQuery"/> and returns a <see cref="ReadOnlyDataCollection{TimeAllocation}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="TimeAllocationQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{TimeAllocation}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<TimeAllocation>> GetAsync(TimeAllocationQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<TimeAllocation>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="TimeAllocationQuery"/>, yielding each <see cref="ReadOnlyDataCollection{TimeAllocation}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="TimeAllocationQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{TimeAllocation}"/> page of results.</returns>
        public IAsyncEnumerable<TimeAllocation> StreamAsync(TimeAllocationQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<TimeAllocation>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="TimeEntryQuery"/> and returns a <see cref="ReadOnlyDataCollection{TimeEntry}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="TimeEntryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{TimeEntry}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<TimeEntry>> GetAsync(TimeEntryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<TimeEntry>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="TimeEntryQuery"/>, yielding each <see cref="ReadOnlyDataCollection{TimeEntry}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="TimeEntryQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{TimeEntry}"/> page of results.</returns>
        public IAsyncEnumerable<TimeEntry> StreamAsync(TimeEntryQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<TimeEntry>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="TimesheetSettingQuery"/> and returns a <see cref="ReadOnlyDataCollection{TimesheetSetting}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="TimesheetSettingQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{TimesheetSetting}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<TimesheetSetting>> GetAsync(TimesheetSettingQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<TimesheetSetting>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="TimesheetSettingQuery"/>, yielding each <see cref="ReadOnlyDataCollection{TimesheetSetting}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="TimesheetSettingQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{TimesheetSetting}"/> page of results.</returns>
        public IAsyncEnumerable<TimesheetSetting> StreamAsync(TimesheetSettingQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<TimesheetSetting>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="TranslationQuery"/> and returns a <see cref="ReadOnlyDataCollection{Translation}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="TranslationQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Translation}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Translation>> GetAsync(TranslationQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Translation>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="TranslationQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Translation}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="TranslationQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Translation}"/> page of results.</returns>
        public IAsyncEnumerable<Translation> StreamAsync(TranslationQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Translation>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="TrashQuery"/> and returns a <see cref="ReadOnlyDataCollection{Trash}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="TrashQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Trash}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Trash>> GetAsync(TrashQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Trash>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="TrashQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Trash}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="TrashQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Trash}"/> page of results.</returns>
        public IAsyncEnumerable<Trash> StreamAsync(TrashQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Trash>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="UiExtensionQuery"/> and returns a <see cref="ReadOnlyDataCollection{UiExtension}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="UiExtensionQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{UiExtension}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<UiExtension>> GetAsync(UiExtensionQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<UiExtension>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="UiExtensionQuery"/>, yielding each <see cref="ReadOnlyDataCollection{UiExtension}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="UiExtensionQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{UiExtension}"/> page of results.</returns>
        public IAsyncEnumerable<UiExtension> StreamAsync(UiExtensionQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<UiExtension>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="WaitingForCustomerFollowUpQuery"/> and returns a <see cref="ReadOnlyDataCollection{WaitingForCustomerFollowUp}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="WaitingForCustomerFollowUpQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{WaitingForCustomerFollowUp}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<WaitingForCustomerFollowUp>> GetAsync(WaitingForCustomerFollowUpQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<WaitingForCustomerFollowUp>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="WaitingForCustomerFollowUpQuery"/>, yielding each <see cref="ReadOnlyDataCollection{WaitingForCustomerFollowUp}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="WaitingForCustomerFollowUpQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{WaitingForCustomerFollowUp}"/> page of results.</returns>
        public IAsyncEnumerable<WaitingForCustomerFollowUp> StreamAsync(WaitingForCustomerFollowUpQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<WaitingForCustomerFollowUp>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="WebhookPolicyQuery"/> and returns a <see cref="ReadOnlyDataCollection{WebhookPolicy}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="WebhookPolicyQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{WebhookPolicy}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<WebhookPolicy>> GetAsync(WebhookPolicyQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<WebhookPolicy>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="WebhookPolicyQuery"/>, yielding each <see cref="ReadOnlyDataCollection{WebhookPolicy}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="WebhookPolicyQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{WebhookPolicy}"/> page of results.</returns>
        public IAsyncEnumerable<WebhookPolicy> StreamAsync(WebhookPolicyQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<WebhookPolicy>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="WebhookQuery"/> and returns a <see cref="ReadOnlyDataCollection{Webhook}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="WebhookQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Webhook}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Webhook>> GetAsync(WebhookQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Webhook>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="WebhookQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Webhook}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="WebhookQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Webhook}"/> page of results.</returns>
        public IAsyncEnumerable<Webhook> StreamAsync(WebhookQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Webhook>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="WorkflowTemplateQuery"/> and returns a <see cref="ReadOnlyDataCollection{WorkflowTemplate}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{WorkflowTemplate}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<WorkflowTemplate>> GetAsync(WorkflowTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<WorkflowTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="WorkflowTemplateQuery"/>, yielding each <see cref="ReadOnlyDataCollection{WorkflowTemplate}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowTemplateQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{WorkflowTemplate}"/> page of results.</returns>
        public IAsyncEnumerable<WorkflowTemplate> StreamAsync(WorkflowTemplateQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<WorkflowTemplate>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="WorkflowTypeQuery"/> and returns a <see cref="ReadOnlyDataCollection{WorkflowType}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowTypeQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{WorkflowType}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<WorkflowType>> GetAsync(WorkflowTypeQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<WorkflowType>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="WorkflowTypeQuery"/>, yielding each <see cref="ReadOnlyDataCollection{WorkflowType}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowTypeQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{WorkflowType}"/> page of results.</returns>
        public IAsyncEnumerable<WorkflowType> StreamAsync(WorkflowTypeQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<WorkflowType>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Executes the specified <see cref="WorkflowQuery"/> and returns a <see cref="ReadOnlyDataCollection{Workflow}"/> of results, performing pagination as needed.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{ReadOnlyDataCollection}"/> representing the asynchronous operation, containing a <see cref="ReadOnlyDataCollection{Workflow}"/> of results.</returns>
        public Task<ReadOnlyDataCollection<Workflow>> GetAsync(WorkflowQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return GetAsync<Workflow>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }

        /// <summary>
        /// Streams paged results for the specified <see cref="WorkflowQuery"/>, yielding each <see cref="ReadOnlyDataCollection{Workflow}"/> page as it arrives.
        /// </summary>
        /// <param name="query">The <see cref="WorkflowQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{ReadOnlyDataCollection}"/> yielding each <see cref="ReadOnlyDataCollection{Workflow}"/> page of results.</returns>
        public IAsyncEnumerable<Workflow> StreamAsync(WorkflowQuery query, CancellationToken ct = default)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return StreamAsync<Workflow>(GetAccountId(), query, _defaultItemsPerRequest, _maxRequestsPerQuery, ct);
        }
    }
}
