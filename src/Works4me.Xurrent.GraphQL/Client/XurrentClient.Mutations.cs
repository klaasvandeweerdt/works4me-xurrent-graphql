using System;
using System.Threading;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Mutations;

namespace Works4me.Xurrent.GraphQL
{
    public partial class XurrentClient
    {
        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AgileBoardCreatePayload> MutationAsync(AgileBoardCreateInput data, AgileBoardQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AgileBoardCreatePayload, AgileBoardCreateInput>(GetAccountId(), new AgileBoardCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AgileBoardUpdatePayload> MutationAsync(AgileBoardUpdateInput data, AgileBoardQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AgileBoardUpdatePayload, AgileBoardUpdateInput>(GetAccountId(), new AgileBoardUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AppInstanceCreatePayload> MutationAsync(AppInstanceCreateInput data, AppInstanceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppInstanceCreatePayload, AppInstanceCreateInput>(GetAccountId(), new AppInstanceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AppInstanceUpdatePayload> MutationAsync(AppInstanceUpdateInput data, AppInstanceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppInstanceUpdatePayload, AppInstanceUpdateInput>(GetAccountId(), new AppInstanceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AppOfferingAutomationRuleCreatePayload> MutationAsync(AppOfferingAutomationRuleCreateInput data, AppOfferingAutomationRuleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingAutomationRuleCreatePayload, AppOfferingAutomationRuleCreateInput>(GetAccountId(), new AppOfferingAutomationRuleCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the success mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AppOfferingAutomationRuleDeleteMutationPayload> MutationAsync(AppOfferingAutomationRuleDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppOfferingAutomationRuleDeleteMutationPayload, AppOfferingAutomationRuleDeleteMutationInput>(GetAccountId(), new AppOfferingAutomationRuleDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AppOfferingAutomationRuleUpdatePayload> MutationAsync(AppOfferingAutomationRuleUpdateInput data, AppOfferingAutomationRuleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingAutomationRuleUpdatePayload, AppOfferingAutomationRuleUpdateInput>(GetAccountId(), new AppOfferingAutomationRuleUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AppOfferingCreatePayload> MutationAsync(AppOfferingCreateInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingCreatePayload, AppOfferingCreateInput>(GetAccountId(), new AppOfferingCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AppOfferingPublishMutationPayload> MutationAsync(AppOfferingPublishMutationInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingPublishMutationPayload, AppOfferingPublishMutationInput>(GetAccountId(), new AppOfferingPublishMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AppOfferingUpdatePayload> MutationAsync(AppOfferingUpdateInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingUpdatePayload, AppOfferingUpdateInput>(GetAccountId(), new AppOfferingUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AutomationRuleCreatePayload> MutationAsync(AutomationRuleCreateInput data, AutomationRuleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AutomationRuleCreatePayload, AutomationRuleCreateInput>(GetAccountId(), new AutomationRuleCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<AutomationRuleUpdatePayload> MutationAsync(AutomationRuleUpdateInput data, AutomationRuleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AutomationRuleUpdatePayload, AutomationRuleUpdateInput>(GetAccountId(), new AutomationRuleUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<BroadcastCreatePayload> MutationAsync(BroadcastCreateInput data, BroadcastQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<BroadcastCreatePayload, BroadcastCreateInput>(GetAccountId(), new BroadcastCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<BroadcastUpdatePayload> MutationAsync(BroadcastUpdateInput data, BroadcastQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<BroadcastUpdatePayload, BroadcastUpdateInput>(GetAccountId(), new BroadcastUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<CalendarCreatePayload> MutationAsync(CalendarCreateInput data, CalendarQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CalendarCreatePayload, CalendarCreateInput>(GetAccountId(), new CalendarCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<CalendarUpdatePayload> MutationAsync(CalendarUpdateInput data, CalendarQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CalendarUpdatePayload, CalendarUpdateInput>(GetAccountId(), new CalendarUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ClosureCodeCreatePayload> MutationAsync(ClosureCodeCreateInput data, ClosureCodeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ClosureCodeCreatePayload, ClosureCodeCreateInput>(GetAccountId(), new ClosureCodeCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ClosureCodeUpdatePayload> MutationAsync(ClosureCodeUpdateInput data, ClosureCodeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ClosureCodeUpdatePayload, ClosureCodeUpdateInput>(GetAccountId(), new ClosureCodeUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ConfigurationItemCreatePayload> MutationAsync(ConfigurationItemCreateInput data, ConfigurationItemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ConfigurationItemCreatePayload, ConfigurationItemCreateInput>(GetAccountId(), new ConfigurationItemCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ConfigurationItemUpdatePayload> MutationAsync(ConfigurationItemUpdateInput data, ConfigurationItemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ConfigurationItemUpdatePayload, ConfigurationItemUpdateInput>(GetAccountId(), new ConfigurationItemUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ContractCreatePayload> MutationAsync(ContractCreateInput data, ContractQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ContractCreatePayload, ContractCreateInput>(GetAccountId(), new ContractCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ContractUpdatePayload> MutationAsync(ContractUpdateInput data, ContractQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ContractUpdatePayload, ContractUpdateInput>(GetAccountId(), new ContractUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<CustomCollectionCreatePayload> MutationAsync(CustomCollectionCreateInput data, CustomCollectionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CustomCollectionCreatePayload, CustomCollectionCreateInput>(GetAccountId(), new CustomCollectionCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<CustomCollectionElementCreatePayload> MutationAsync(CustomCollectionElementCreateInput data, CustomCollectionElementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CustomCollectionElementCreatePayload, CustomCollectionElementCreateInput>(GetAccountId(), new CustomCollectionElementCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<CustomCollectionElementUpdatePayload> MutationAsync(CustomCollectionElementUpdateInput data, CustomCollectionElementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CustomCollectionElementUpdatePayload, CustomCollectionElementUpdateInput>(GetAccountId(), new CustomCollectionElementUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<CustomCollectionUpdatePayload> MutationAsync(CustomCollectionUpdateInput data, CustomCollectionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CustomCollectionUpdatePayload, CustomCollectionUpdateInput>(GetAccountId(), new CustomCollectionUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the async query mutation.</param>
        /// <param name="query1">The query specifying which fields to return in the response.</param>
        /// <param name="query2">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<DiscoveredConfigurationItemsPayload> MutationAsync(DiscoveredConfigurationItemsInput data, AsyncQueryQuery query1, ConfigurationItemQuery query2, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query1 is null)
                throw new ArgumentNullException(nameof(query1));

            if (query2 is null)
                throw new ArgumentNullException(nameof(query2));

            return MutationAsync<DiscoveredConfigurationItemsPayload, DiscoveredConfigurationItemsInput>(GetAccountId(), new DiscoveredConfigurationItemsMutation(data, query1, query2), ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<EffortClassCreatePayload> MutationAsync(EffortClassCreateInput data, EffortClassQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<EffortClassCreatePayload, EffortClassCreateInput>(GetAccountId(), new EffortClassCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<EffortClassUpdatePayload> MutationAsync(EffortClassUpdateInput data, EffortClassQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<EffortClassUpdatePayload, EffortClassUpdateInput>(GetAccountId(), new EffortClassUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<FirstLineSupportAgreementCreatePayload> MutationAsync(FirstLineSupportAgreementCreateInput data, FirstLineSupportAgreementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<FirstLineSupportAgreementCreatePayload, FirstLineSupportAgreementCreateInput>(GetAccountId(), new FirstLineSupportAgreementCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<FirstLineSupportAgreementUpdatePayload> MutationAsync(FirstLineSupportAgreementUpdateInput data, FirstLineSupportAgreementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<FirstLineSupportAgreementUpdatePayload, FirstLineSupportAgreementUpdateInput>(GetAccountId(), new FirstLineSupportAgreementUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<HolidayCreatePayload> MutationAsync(HolidayCreateInput data, HolidayQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<HolidayCreatePayload, HolidayCreateInput>(GetAccountId(), new HolidayCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<HolidayUpdatePayload> MutationAsync(HolidayUpdateInput data, HolidayQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<HolidayUpdatePayload, HolidayUpdateInput>(GetAccountId(), new HolidayUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<InvoiceCreatePayload> MutationAsync(InvoiceCreateInput data, InvoiceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<InvoiceCreatePayload, InvoiceCreateInput>(GetAccountId(), new InvoiceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<InvoiceUpdatePayload> MutationAsync(InvoiceUpdateInput data, InvoiceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<InvoiceUpdatePayload, InvoiceUpdateInput>(GetAccountId(), new InvoiceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<KnowledgeArticleCreatePayload> MutationAsync(KnowledgeArticleCreateInput data, KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<KnowledgeArticleCreatePayload, KnowledgeArticleCreateInput>(GetAccountId(), new KnowledgeArticleCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<KnowledgeArticleUpdatePayload> MutationAsync(KnowledgeArticleUpdateInput data, KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<KnowledgeArticleUpdatePayload, KnowledgeArticleUpdateInput>(GetAccountId(), new KnowledgeArticleUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the note mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<NoteCreatePayload> MutationAsync(NoteCreateInput data, NoteQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<NoteCreatePayload, NoteCreateInput>(GetAccountId(), new NoteCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the note reaction mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<NoteReactionCreatePayload> MutationAsync(NoteReactionCreateInput data, NoteReactionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<NoteReactionCreatePayload, NoteReactionCreateInput>(GetAccountId(), new NoteReactionCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the success mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<NoteReactionDeleteMutationPayload> MutationAsync(NoteReactionDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<NoteReactionDeleteMutationPayload, NoteReactionDeleteMutationInput>(GetAccountId(), new NoteReactionDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<OrganizationCreatePayload> MutationAsync(OrganizationCreateInput data, OrganizationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<OrganizationCreatePayload, OrganizationCreateInput>(GetAccountId(), new OrganizationCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<OrganizationUpdatePayload> MutationAsync(OrganizationUpdateInput data, OrganizationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<OrganizationUpdatePayload, OrganizationUpdateInput>(GetAccountId(), new OrganizationUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<OutOfOfficePeriodCreatePayload> MutationAsync(OutOfOfficePeriodCreateInput data, OutOfOfficePeriodQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<OutOfOfficePeriodCreatePayload, OutOfOfficePeriodCreateInput>(GetAccountId(), new OutOfOfficePeriodCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the success mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<OutOfOfficePeriodDeleteMutationPayload> MutationAsync(OutOfOfficePeriodDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<OutOfOfficePeriodDeleteMutationPayload, OutOfOfficePeriodDeleteMutationInput>(GetAccountId(), new OutOfOfficePeriodDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<OutOfOfficePeriodUpdatePayload> MutationAsync(OutOfOfficePeriodUpdateInput data, OutOfOfficePeriodQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<OutOfOfficePeriodUpdatePayload, OutOfOfficePeriodUpdateInput>(GetAccountId(), new OutOfOfficePeriodUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<PdfDesignCreatePayload> MutationAsync(PdfDesignCreateInput data, PdfDesignQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<PdfDesignCreatePayload, PdfDesignCreateInput>(GetAccountId(), new PdfDesignCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<PdfDesignUpdatePayload> MutationAsync(PdfDesignUpdateInput data, PdfDesignQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<PdfDesignUpdatePayload, PdfDesignUpdateInput>(GetAccountId(), new PdfDesignUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<PersonCreatePayload> MutationAsync(PersonCreateInput data, PersonQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<PersonCreatePayload, PersonCreateInput>(GetAccountId(), new PersonCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<PersonUpdatePayload> MutationAsync(PersonUpdateInput data, PersonQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<PersonUpdatePayload, PersonUpdateInput>(GetAccountId(), new PersonUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProblemCreatePayload> MutationAsync(ProblemCreateInput data, ProblemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProblemCreatePayload, ProblemCreateInput>(GetAccountId(), new ProblemCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProblemUpdatePayload> MutationAsync(ProblemUpdateInput data, ProblemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProblemUpdatePayload, ProblemUpdateInput>(GetAccountId(), new ProblemUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProductBacklogCreatePayload> MutationAsync(ProductBacklogCreateInput data, ProductBacklogQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductBacklogCreatePayload, ProductBacklogCreateInput>(GetAccountId(), new ProductBacklogCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProductBacklogUpdatePayload> MutationAsync(ProductBacklogUpdateInput data, ProductBacklogQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductBacklogUpdatePayload, ProductBacklogUpdateInput>(GetAccountId(), new ProductBacklogUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProductCategoryCreatePayload> MutationAsync(ProductCategoryCreateInput data, ProductCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductCategoryCreatePayload, ProductCategoryCreateInput>(GetAccountId(), new ProductCategoryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProductCategoryUpdatePayload> MutationAsync(ProductCategoryUpdateInput data, ProductCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductCategoryUpdatePayload, ProductCategoryUpdateInput>(GetAccountId(), new ProductCategoryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProductCreatePayload> MutationAsync(ProductCreateInput data, ProductQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductCreatePayload, ProductCreateInput>(GetAccountId(), new ProductCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProductUpdatePayload> MutationAsync(ProductUpdateInput data, ProductQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductUpdatePayload, ProductUpdateInput>(GetAccountId(), new ProductUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectCategoryCreatePayload> MutationAsync(ProjectCategoryCreateInput data, ProjectCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectCategoryCreatePayload, ProjectCategoryCreateInput>(GetAccountId(), new ProjectCategoryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectCategoryUpdatePayload> MutationAsync(ProjectCategoryUpdateInput data, ProjectCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectCategoryUpdatePayload, ProjectCategoryUpdateInput>(GetAccountId(), new ProjectCategoryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectCreatePayload> MutationAsync(ProjectCreateInput data, ProjectQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectCreatePayload, ProjectCreateInput>(GetAccountId(), new ProjectCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectRiskLevelCreatePayload> MutationAsync(ProjectRiskLevelCreateInput data, ProjectRiskLevelQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectRiskLevelCreatePayload, ProjectRiskLevelCreateInput>(GetAccountId(), new ProjectRiskLevelCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectRiskLevelUpdatePayload> MutationAsync(ProjectRiskLevelUpdateInput data, ProjectRiskLevelQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectRiskLevelUpdatePayload, ProjectRiskLevelUpdateInput>(GetAccountId(), new ProjectRiskLevelUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectTaskCreatePayload> MutationAsync(ProjectTaskCreateInput data, ProjectTaskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTaskCreatePayload, ProjectTaskCreateInput>(GetAccountId(), new ProjectTaskCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectTaskTemplateCreatePayload> MutationAsync(ProjectTaskTemplateCreateInput data, ProjectTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTaskTemplateCreatePayload, ProjectTaskTemplateCreateInput>(GetAccountId(), new ProjectTaskTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectTaskTemplateUpdatePayload> MutationAsync(ProjectTaskTemplateUpdateInput data, ProjectTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTaskTemplateUpdatePayload, ProjectTaskTemplateUpdateInput>(GetAccountId(), new ProjectTaskTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectTaskUpdatePayload> MutationAsync(ProjectTaskUpdateInput data, ProjectTaskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTaskUpdatePayload, ProjectTaskUpdateInput>(GetAccountId(), new ProjectTaskUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectTemplateCreatePayload> MutationAsync(ProjectTemplateCreateInput data, ProjectTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTemplateCreatePayload, ProjectTemplateCreateInput>(GetAccountId(), new ProjectTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectTemplateUpdatePayload> MutationAsync(ProjectTemplateUpdateInput data, ProjectTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTemplateUpdatePayload, ProjectTemplateUpdateInput>(GetAccountId(), new ProjectTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ProjectUpdatePayload> MutationAsync(ProjectUpdateInput data, ProjectQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectUpdatePayload, ProjectUpdateInput>(GetAccountId(), new ProjectUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ReleaseCreatePayload> MutationAsync(ReleaseCreateInput data, ReleaseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReleaseCreatePayload, ReleaseCreateInput>(GetAccountId(), new ReleaseCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ReleaseUpdatePayload> MutationAsync(ReleaseUpdateInput data, ReleaseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReleaseUpdatePayload, ReleaseUpdateInput>(GetAccountId(), new ReleaseUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<RequestCreatePayload> MutationAsync(RequestCreateInput data, RequestQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RequestCreatePayload, RequestCreateInput>(GetAccountId(), new RequestCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<RequestTemplateCreatePayload> MutationAsync(RequestTemplateCreateInput data, RequestTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RequestTemplateCreatePayload, RequestTemplateCreateInput>(GetAccountId(), new RequestTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<RequestTemplateUpdatePayload> MutationAsync(RequestTemplateUpdateInput data, RequestTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RequestTemplateUpdatePayload, RequestTemplateUpdateInput>(GetAccountId(), new RequestTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<RequestUpdatePayload> MutationAsync(RequestUpdateInput data, RequestQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RequestUpdatePayload, RequestUpdateInput>(GetAccountId(), new RequestUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ReservationCreatePayload> MutationAsync(ReservationCreateInput data, ReservationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReservationCreatePayload, ReservationCreateInput>(GetAccountId(), new ReservationCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ReservationOfferingCreatePayload> MutationAsync(ReservationOfferingCreateInput data, ReservationOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReservationOfferingCreatePayload, ReservationOfferingCreateInput>(GetAccountId(), new ReservationOfferingCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ReservationOfferingUpdatePayload> MutationAsync(ReservationOfferingUpdateInput data, ReservationOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReservationOfferingUpdatePayload, ReservationOfferingUpdateInput>(GetAccountId(), new ReservationOfferingUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ReservationUpdatePayload> MutationAsync(ReservationUpdateInput data, ReservationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReservationUpdatePayload, ReservationUpdateInput>(GetAccountId(), new ReservationUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<RiskCreatePayload> MutationAsync(RiskCreateInput data, RiskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RiskCreatePayload, RiskCreateInput>(GetAccountId(), new RiskCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<RiskSeverityCreatePayload> MutationAsync(RiskSeverityCreateInput data, RiskSeverityQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RiskSeverityCreatePayload, RiskSeverityCreateInput>(GetAccountId(), new RiskSeverityCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<RiskSeverityUpdatePayload> MutationAsync(RiskSeverityUpdateInput data, RiskSeverityQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RiskSeverityUpdatePayload, RiskSeverityUpdateInput>(GetAccountId(), new RiskSeverityUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<RiskUpdatePayload> MutationAsync(RiskUpdateInput data, RiskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RiskUpdatePayload, RiskUpdateInput>(GetAccountId(), new RiskUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ScrumWorkspaceCreatePayload> MutationAsync(ScrumWorkspaceCreateInput data, ScrumWorkspaceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ScrumWorkspaceCreatePayload, ScrumWorkspaceCreateInput>(GetAccountId(), new ScrumWorkspaceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ScrumWorkspaceUpdatePayload> MutationAsync(ScrumWorkspaceUpdateInput data, ScrumWorkspaceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ScrumWorkspaceUpdatePayload, ScrumWorkspaceUpdateInput>(GetAccountId(), new ScrumWorkspaceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceCategoryCreatePayload> MutationAsync(ServiceCategoryCreateInput data, ServiceCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceCategoryCreatePayload, ServiceCategoryCreateInput>(GetAccountId(), new ServiceCategoryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceCategoryUpdatePayload> MutationAsync(ServiceCategoryUpdateInput data, ServiceCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceCategoryUpdatePayload, ServiceCategoryUpdateInput>(GetAccountId(), new ServiceCategoryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceCreatePayload> MutationAsync(ServiceCreateInput data, ServiceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceCreatePayload, ServiceCreateInput>(GetAccountId(), new ServiceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceInstanceCreatePayload> MutationAsync(ServiceInstanceCreateInput data, ServiceInstanceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceInstanceCreatePayload, ServiceInstanceCreateInput>(GetAccountId(), new ServiceInstanceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceInstanceUpdatePayload> MutationAsync(ServiceInstanceUpdateInput data, ServiceInstanceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceInstanceUpdatePayload, ServiceInstanceUpdateInput>(GetAccountId(), new ServiceInstanceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceLevelAgreementCreatePayload> MutationAsync(ServiceLevelAgreementCreateInput data, ServiceLevelAgreementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceLevelAgreementCreatePayload, ServiceLevelAgreementCreateInput>(GetAccountId(), new ServiceLevelAgreementCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceLevelAgreementUpdatePayload> MutationAsync(ServiceLevelAgreementUpdateInput data, ServiceLevelAgreementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceLevelAgreementUpdatePayload, ServiceLevelAgreementUpdateInput>(GetAccountId(), new ServiceLevelAgreementUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceOfferingCreatePayload> MutationAsync(ServiceOfferingCreateInput data, ServiceOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceOfferingCreatePayload, ServiceOfferingCreateInput>(GetAccountId(), new ServiceOfferingCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceOfferingUpdatePayload> MutationAsync(ServiceOfferingUpdateInput data, ServiceOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceOfferingUpdatePayload, ServiceOfferingUpdateInput>(GetAccountId(), new ServiceOfferingUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ServiceUpdatePayload> MutationAsync(ServiceUpdateInput data, ServiceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceUpdatePayload, ServiceUpdateInput>(GetAccountId(), new ServiceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ShopArticleCategoryCreatePayload> MutationAsync(ShopArticleCategoryCreateInput data, ShopArticleCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopArticleCategoryCreatePayload, ShopArticleCategoryCreateInput>(GetAccountId(), new ShopArticleCategoryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ShopArticleCategoryUpdatePayload> MutationAsync(ShopArticleCategoryUpdateInput data, ShopArticleCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopArticleCategoryUpdatePayload, ShopArticleCategoryUpdateInput>(GetAccountId(), new ShopArticleCategoryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ShopArticleCreatePayload> MutationAsync(ShopArticleCreateInput data, ShopArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopArticleCreatePayload, ShopArticleCreateInput>(GetAccountId(), new ShopArticleCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ShopArticleUpdatePayload> MutationAsync(ShopArticleUpdateInput data, ShopArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopArticleUpdatePayload, ShopArticleUpdateInput>(GetAccountId(), new ShopArticleUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ShopOrderLineCreatePayload> MutationAsync(ShopOrderLineCreateInput data, ShopOrderLineQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopOrderLineCreatePayload, ShopOrderLineCreateInput>(GetAccountId(), new ShopOrderLineCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ShopOrderLineUpdatePayload> MutationAsync(ShopOrderLineUpdateInput data, ShopOrderLineQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopOrderLineUpdatePayload, ShopOrderLineUpdateInput>(GetAccountId(), new ShopOrderLineUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ShortUrlCreatePayload> MutationAsync(ShortUrlCreateInput data, ShortUrlQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShortUrlCreatePayload, ShortUrlCreateInput>(GetAccountId(), new ShortUrlCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<ShortUrlUpdatePayload> MutationAsync(ShortUrlUpdateInput data, ShortUrlQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShortUrlUpdatePayload, ShortUrlUpdateInput>(GetAccountId(), new ShortUrlUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SiteCreatePayload> MutationAsync(SiteCreateInput data, SiteQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SiteCreatePayload, SiteCreateInput>(GetAccountId(), new SiteCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SiteUpdatePayload> MutationAsync(SiteUpdateInput data, SiteQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SiteUpdatePayload, SiteUpdateInput>(GetAccountId(), new SiteUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SkillPoolCreatePayload> MutationAsync(SkillPoolCreateInput data, SkillPoolQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SkillPoolCreatePayload, SkillPoolCreateInput>(GetAccountId(), new SkillPoolCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SkillPoolUpdatePayload> MutationAsync(SkillPoolUpdateInput data, SkillPoolQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SkillPoolUpdatePayload, SkillPoolUpdateInput>(GetAccountId(), new SkillPoolUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SlaCoverageGroupCreatePayload> MutationAsync(SlaCoverageGroupCreateInput data, SlaCoverageGroupQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SlaCoverageGroupCreatePayload, SlaCoverageGroupCreateInput>(GetAccountId(), new SlaCoverageGroupCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SlaCoverageGroupUpdatePayload> MutationAsync(SlaCoverageGroupUpdateInput data, SlaCoverageGroupQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SlaCoverageGroupUpdatePayload, SlaCoverageGroupUpdateInput>(GetAccountId(), new SlaCoverageGroupUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SlaNotificationSchemeCreatePayload> MutationAsync(SlaNotificationSchemeCreateInput data, SlaNotificationSchemeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SlaNotificationSchemeCreatePayload, SlaNotificationSchemeCreateInput>(GetAccountId(), new SlaNotificationSchemeCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SlaNotificationSchemeUpdatePayload> MutationAsync(SlaNotificationSchemeUpdateInput data, SlaNotificationSchemeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SlaNotificationSchemeUpdatePayload, SlaNotificationSchemeUpdateInput>(GetAccountId(), new SlaNotificationSchemeUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SprintCreatePayload> MutationAsync(SprintCreateInput data, SprintQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SprintCreatePayload, SprintCreateInput>(GetAccountId(), new SprintCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SprintUpdatePayload> MutationAsync(SprintUpdateInput data, SprintQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SprintUpdatePayload, SprintUpdateInput>(GetAccountId(), new SprintUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SurveyCreatePayload> MutationAsync(SurveyCreateInput data, SurveyQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SurveyCreatePayload, SurveyCreateInput>(GetAccountId(), new SurveyCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SurveyResponseCreatePayload> MutationAsync(SurveyResponseCreateInput data, SurveyResponseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SurveyResponseCreatePayload, SurveyResponseCreateInput>(GetAccountId(), new SurveyResponseCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SurveyResponseUpdatePayload> MutationAsync(SurveyResponseUpdateInput data, SurveyResponseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SurveyResponseUpdatePayload, SurveyResponseUpdateInput>(GetAccountId(), new SurveyResponseUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<SurveyUpdatePayload> MutationAsync(SurveyUpdateInput data, SurveyQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SurveyUpdatePayload, SurveyUpdateInput>(GetAccountId(), new SurveyUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TeamCreatePayload> MutationAsync(TeamCreateInput data, TeamQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TeamCreatePayload, TeamCreateInput>(GetAccountId(), new TeamCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TeamUpdatePayload> MutationAsync(TeamUpdateInput data, TeamQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TeamUpdatePayload, TeamUpdateInput>(GetAccountId(), new TeamUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TimeAllocationCreatePayload> MutationAsync(TimeAllocationCreateInput data, TimeAllocationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimeAllocationCreatePayload, TimeAllocationCreateInput>(GetAccountId(), new TimeAllocationCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TimeAllocationUpdatePayload> MutationAsync(TimeAllocationUpdateInput data, TimeAllocationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimeAllocationUpdatePayload, TimeAllocationUpdateInput>(GetAccountId(), new TimeAllocationUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TimeEntryCreatePayload> MutationAsync(TimeEntryCreateInput data, TimeEntryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimeEntryCreatePayload, TimeEntryCreateInput>(GetAccountId(), new TimeEntryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TimeEntryUpdatePayload> MutationAsync(TimeEntryUpdateInput data, TimeEntryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimeEntryUpdatePayload, TimeEntryUpdateInput>(GetAccountId(), new TimeEntryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TimesheetSettingCreatePayload> MutationAsync(TimesheetSettingCreateInput data, TimesheetSettingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimesheetSettingCreatePayload, TimesheetSettingCreateInput>(GetAccountId(), new TimesheetSettingCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TimesheetSettingUpdatePayload> MutationAsync(TimesheetSettingUpdateInput data, TimesheetSettingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimesheetSettingUpdatePayload, TimesheetSettingUpdateInput>(GetAccountId(), new TimesheetSettingUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TranslationCreatePayload> MutationAsync(TranslationCreateInput data, TranslationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TranslationCreatePayload, TranslationCreateInput>(GetAccountId(), new TranslationCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<TranslationUpdatePayload> MutationAsync(TranslationUpdateInput data, TranslationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TranslationUpdatePayload, TranslationUpdateInput>(GetAccountId(), new TranslationUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<UiExtensionCreatePayload> MutationAsync(UiExtensionCreateInput data, UiExtensionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<UiExtensionCreatePayload, UiExtensionCreateInput>(GetAccountId(), new UiExtensionCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<UiExtensionUpdatePayload> MutationAsync(UiExtensionUpdateInput data, UiExtensionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<UiExtensionUpdatePayload, UiExtensionUpdateInput>(GetAccountId(), new UiExtensionUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WaitingForCustomerFollowUpCreatePayload> MutationAsync(WaitingForCustomerFollowUpCreateInput data, WaitingForCustomerFollowUpQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WaitingForCustomerFollowUpCreatePayload, WaitingForCustomerFollowUpCreateInput>(GetAccountId(), new WaitingForCustomerFollowUpCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WaitingForCustomerFollowUpUpdatePayload> MutationAsync(WaitingForCustomerFollowUpUpdateInput data, WaitingForCustomerFollowUpQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WaitingForCustomerFollowUpUpdatePayload, WaitingForCustomerFollowUpUpdateInput>(GetAccountId(), new WaitingForCustomerFollowUpUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WebhookCreatePayload> MutationAsync(WebhookCreateInput data, WebhookQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WebhookCreatePayload, WebhookCreateInput>(GetAccountId(), new WebhookCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the success mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WebhookDeleteMutationPayload> MutationAsync(WebhookDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WebhookDeleteMutationPayload, WebhookDeleteMutationInput>(GetAccountId(), new WebhookDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WebhookPolicyCreatePayload> MutationAsync(WebhookPolicyCreateInput data, WebhookPolicyCreateResponseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WebhookPolicyCreatePayload, WebhookPolicyCreateInput>(GetAccountId(), new WebhookPolicyCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the success mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WebhookPolicyDeleteMutationPayload> MutationAsync(WebhookPolicyDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WebhookPolicyDeleteMutationPayload, WebhookPolicyDeleteMutationInput>(GetAccountId(), new WebhookPolicyDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WebhookPolicyUpdatePayload> MutationAsync(WebhookPolicyUpdateInput data, WebhookPolicyQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WebhookPolicyUpdatePayload, WebhookPolicyUpdateInput>(GetAccountId(), new WebhookPolicyUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WebhookUpdatePayload> MutationAsync(WebhookUpdateInput data, WebhookQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WebhookUpdatePayload, WebhookUpdateInput>(GetAccountId(), new WebhookUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowCreatePayload> MutationAsync(WorkflowCreateInput data, WorkflowQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowCreatePayload, WorkflowCreateInput>(GetAccountId(), new WorkflowCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowTaskCreatePayload> MutationAsync(WorkflowTaskCreateInput data, WorkflowTaskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTaskCreatePayload, WorkflowTaskCreateInput>(GetAccountId(), new TaskCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowTaskTemplateCreatePayload> MutationAsync(WorkflowTaskTemplateCreateInput data, WorkflowTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTaskTemplateCreatePayload, WorkflowTaskTemplateCreateInput>(GetAccountId(), new TaskTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowTaskTemplateUpdatePayload> MutationAsync(WorkflowTaskTemplateUpdateInput data, WorkflowTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTaskTemplateUpdatePayload, WorkflowTaskTemplateUpdateInput>(GetAccountId(), new TaskTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowTaskUpdatePayload> MutationAsync(WorkflowTaskUpdateInput data, WorkflowTaskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTaskUpdatePayload, WorkflowTaskUpdateInput>(GetAccountId(), new TaskUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowTemplateCreatePayload> MutationAsync(WorkflowTemplateCreateInput data, WorkflowTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTemplateCreatePayload, WorkflowTemplateCreateInput>(GetAccountId(), new WorkflowTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowTemplateUpdatePayload> MutationAsync(WorkflowTemplateUpdateInput data, WorkflowTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTemplateUpdatePayload, WorkflowTemplateUpdateInput>(GetAccountId(), new WorkflowTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowTypeCreatePayload> MutationAsync(WorkflowTypeCreateInput data, WorkflowTypeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTypeCreatePayload, WorkflowTypeCreateInput>(GetAccountId(), new WorkflowTypeCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowTypeUpdatePayload> MutationAsync(WorkflowTypeUpdateInput data, WorkflowTypeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTypeUpdatePayload, WorkflowTypeUpdateInput>(GetAccountId(), new WorkflowTypeUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        public Task<WorkflowUpdatePayload> MutationAsync(WorkflowUpdateInput data, WorkflowQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowUpdatePayload, WorkflowUpdateInput>(GetAccountId(), new WorkflowUpdateMutation(data, query), ct);
        }
    }
}
