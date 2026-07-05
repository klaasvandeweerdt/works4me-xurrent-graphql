using System;
using System.Threading;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Mutations;

namespace Works4me.Xurrent.GraphQL
{
    public partial class XurrentClient
    {
        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested agile board fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AgileBoardCreatePayload> AgileBoardCreateAsync(AgileBoardCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested agile board fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AgileBoardCreatePayload> AgileBoardCreateAsync(AgileBoardCreateInput data, AgileBoardQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested agile board fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AgileBoardUpdatePayload> AgileBoardUpdateAsync(AgileBoardUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested agile board fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AgileBoardUpdatePayload> AgileBoardUpdateAsync(AgileBoardUpdateInput data, AgileBoardQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app instance fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AppInstanceCreatePayload> AppInstanceCreateAsync(AppInstanceCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app instance fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AppInstanceCreatePayload> AppInstanceCreateAsync(AppInstanceCreateInput data, AppInstanceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app instance fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AppInstanceUpdatePayload> AppInstanceUpdateAsync(AppInstanceUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app instance fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AppInstanceUpdatePayload> AppInstanceUpdateAsync(AppInstanceUpdateInput data, AppInstanceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering automation rule fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AppOfferingAutomationRuleCreatePayload> AppOfferingAutomationRuleCreateAsync(AppOfferingAutomationRuleCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering automation rule fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AppOfferingAutomationRuleCreatePayload> AppOfferingAutomationRuleCreateAsync(AppOfferingAutomationRuleCreateInput data, AppOfferingAutomationRuleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AppOfferingAutomationRuleDeleteMutationPayload> AppOfferingAutomationRuleDeleteAsync(AppOfferingAutomationRuleDeleteMutationInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering automation rule fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AppOfferingAutomationRuleUpdatePayload> AppOfferingAutomationRuleUpdateAsync(AppOfferingAutomationRuleUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering automation rule fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AppOfferingAutomationRuleUpdatePayload> AppOfferingAutomationRuleUpdateAsync(AppOfferingAutomationRuleUpdateInput data, AppOfferingAutomationRuleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AppOfferingCreatePayload> AppOfferingCreateAsync(AppOfferingCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AppOfferingCreatePayload> AppOfferingCreateAsync(AppOfferingCreateInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AppOfferingPublishMutationPayload> AppOfferingPublishAsync(AppOfferingPublishMutationInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AppOfferingPublishMutationPayload> AppOfferingPublishAsync(AppOfferingPublishMutationInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AppOfferingUpdatePayload> AppOfferingUpdateAsync(AppOfferingUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AppOfferingUpdatePayload> AppOfferingUpdateAsync(AppOfferingUpdateInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested automation rule fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AutomationRuleCreatePayload> AutomationRuleCreateAsync(AutomationRuleCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested automation rule fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AutomationRuleCreatePayload> AutomationRuleCreateAsync(AutomationRuleCreateInput data, AutomationRuleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested automation rule fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<AutomationRuleUpdatePayload> AutomationRuleUpdateAsync(AutomationRuleUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested automation rule fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<AutomationRuleUpdatePayload> AutomationRuleUpdateAsync(AutomationRuleUpdateInput data, AutomationRuleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested broadcast fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<BroadcastCreatePayload> BroadcastCreateAsync(BroadcastCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested broadcast fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<BroadcastCreatePayload> BroadcastCreateAsync(BroadcastCreateInput data, BroadcastQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested broadcast fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<BroadcastUpdatePayload> BroadcastUpdateAsync(BroadcastUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested broadcast fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<BroadcastUpdatePayload> BroadcastUpdateAsync(BroadcastUpdateInput data, BroadcastQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested calendar fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<CalendarCreatePayload> CalendarCreateAsync(CalendarCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested calendar fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<CalendarCreatePayload> CalendarCreateAsync(CalendarCreateInput data, CalendarQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested calendar fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<CalendarUpdatePayload> CalendarUpdateAsync(CalendarUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested calendar fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<CalendarUpdatePayload> CalendarUpdateAsync(CalendarUpdateInput data, CalendarQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested closure code fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ClosureCodeCreatePayload> ClosureCodeCreateAsync(ClosureCodeCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested closure code fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ClosureCodeCreatePayload> ClosureCodeCreateAsync(ClosureCodeCreateInput data, ClosureCodeQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested closure code fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ClosureCodeUpdatePayload> ClosureCodeUpdateAsync(ClosureCodeUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested closure code fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ClosureCodeUpdatePayload> ClosureCodeUpdateAsync(ClosureCodeUpdateInput data, ClosureCodeQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested configuration item fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ConfigurationItemCreatePayload> ConfigurationItemCreateAsync(ConfigurationItemCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested configuration item fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ConfigurationItemCreatePayload> ConfigurationItemCreateAsync(ConfigurationItemCreateInput data, ConfigurationItemQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested configuration item fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ConfigurationItemUpdatePayload> ConfigurationItemUpdateAsync(ConfigurationItemUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested configuration item fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ConfigurationItemUpdatePayload> ConfigurationItemUpdateAsync(ConfigurationItemUpdateInput data, ConfigurationItemQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested contract fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ContractCreatePayload> ContractCreateAsync(ContractCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested contract fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ContractCreatePayload> ContractCreateAsync(ContractCreateInput data, ContractQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested contract fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ContractUpdatePayload> ContractUpdateAsync(ContractUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested contract fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ContractUpdatePayload> ContractUpdateAsync(ContractUpdateInput data, ContractQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested custom collection fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<CustomCollectionCreatePayload> CustomCollectionCreateAsync(CustomCollectionCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested custom collection fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<CustomCollectionCreatePayload> CustomCollectionCreateAsync(CustomCollectionCreateInput data, CustomCollectionQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested custom collection element fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<CustomCollectionElementCreatePayload> CustomCollectionElementCreateAsync(CustomCollectionElementCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested custom collection element fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<CustomCollectionElementCreatePayload> CustomCollectionElementCreateAsync(CustomCollectionElementCreateInput data, CustomCollectionElementQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested custom collection element fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<CustomCollectionElementUpdatePayload> CustomCollectionElementUpdateAsync(CustomCollectionElementUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested custom collection element fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<CustomCollectionElementUpdatePayload> CustomCollectionElementUpdateAsync(CustomCollectionElementUpdateInput data, CustomCollectionElementQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested custom collection fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<CustomCollectionUpdatePayload> CustomCollectionUpdateAsync(CustomCollectionUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested custom collection fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<CustomCollectionUpdatePayload> CustomCollectionUpdateAsync(CustomCollectionUpdateInput data, CustomCollectionQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the async query mutation.</param>
        /// <param name="query1">The query specifying which fields to return in the response.</param>
        /// <param name="query2">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested mutation response fields.</returns>
        public Task<DiscoveredConfigurationItemsPayload> DiscoveredConfigurationItemsAsync(DiscoveredConfigurationItemsInput data, AsyncQueryQuery query1, ConfigurationItemQuery query2, CancellationToken ct = default)
        {
            return MutationAsync(data, query1, query2, ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested effort class fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<EffortClassCreatePayload> EffortClassCreateAsync(EffortClassCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested effort class fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<EffortClassCreatePayload> EffortClassCreateAsync(EffortClassCreateInput data, EffortClassQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested effort class fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<EffortClassUpdatePayload> EffortClassUpdateAsync(EffortClassUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested effort class fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<EffortClassUpdatePayload> EffortClassUpdateAsync(EffortClassUpdateInput data, EffortClassQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested first line support agreement fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<FirstLineSupportAgreementCreatePayload> FirstLineSupportAgreementCreateAsync(FirstLineSupportAgreementCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested first line support agreement fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<FirstLineSupportAgreementCreatePayload> FirstLineSupportAgreementCreateAsync(FirstLineSupportAgreementCreateInput data, FirstLineSupportAgreementQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested first line support agreement fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<FirstLineSupportAgreementUpdatePayload> FirstLineSupportAgreementUpdateAsync(FirstLineSupportAgreementUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested first line support agreement fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<FirstLineSupportAgreementUpdatePayload> FirstLineSupportAgreementUpdateAsync(FirstLineSupportAgreementUpdateInput data, FirstLineSupportAgreementQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested golden set item fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<GoldenSetItemCreatePayload> GoldenSetItemCreateAsync(GoldenSetItemCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested golden set item fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<GoldenSetItemCreatePayload> GoldenSetItemCreateAsync(GoldenSetItemCreateInput data, GoldenSetItemQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<GoldenSetItemDeleteMutationPayload> GoldenSetItemDeleteAsync(GoldenSetItemDeleteMutationInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested golden set item fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<GoldenSetItemUpdatePayload> GoldenSetItemUpdateAsync(GoldenSetItemUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested golden set item fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<GoldenSetItemUpdatePayload> GoldenSetItemUpdateAsync(GoldenSetItemUpdateInput data, GoldenSetItemQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested holiday fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<HolidayCreatePayload> HolidayCreateAsync(HolidayCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested holiday fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<HolidayCreatePayload> HolidayCreateAsync(HolidayCreateInput data, HolidayQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested holiday fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<HolidayUpdatePayload> HolidayUpdateAsync(HolidayUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested holiday fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<HolidayUpdatePayload> HolidayUpdateAsync(HolidayUpdateInput data, HolidayQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested invoice fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<InvoiceCreatePayload> InvoiceCreateAsync(InvoiceCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested invoice fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<InvoiceCreatePayload> InvoiceCreateAsync(InvoiceCreateInput data, InvoiceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested invoice fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<InvoiceUpdatePayload> InvoiceUpdateAsync(InvoiceUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested invoice fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<InvoiceUpdatePayload> InvoiceUpdateAsync(InvoiceUpdateInput data, InvoiceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested knowledge article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<KnowledgeArticleCreatePayload> KnowledgeArticleCreateAsync(KnowledgeArticleCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested knowledge article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<KnowledgeArticleCreatePayload> KnowledgeArticleCreateAsync(KnowledgeArticleCreateInput data, KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested knowledge article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<KnowledgeArticleMarkAsReviewedPayload> KnowledgeArticleMarkAsReviewedAsync(KnowledgeArticleMarkAsReviewedInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested knowledge article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<KnowledgeArticleMarkAsReviewedPayload> KnowledgeArticleMarkAsReviewedAsync(KnowledgeArticleMarkAsReviewedInput data, KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested knowledge article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<KnowledgeArticleUpdatePayload> KnowledgeArticleUpdateAsync(KnowledgeArticleUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested knowledge article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<KnowledgeArticleUpdatePayload> KnowledgeArticleUpdateAsync(KnowledgeArticleUpdateInput data, KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the note mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested note fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<NoteCreatePayload> NoteCreateAsync(NoteCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the note mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested note fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<NoteCreatePayload> NoteCreateAsync(NoteCreateInput data, NoteQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the note reaction mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested note reaction fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<NoteReactionCreatePayload> NoteReactionCreateAsync(NoteReactionCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the note reaction mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested note reaction fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<NoteReactionCreatePayload> NoteReactionCreateAsync(NoteReactionCreateInput data, NoteReactionQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<NoteReactionDeleteMutationPayload> NoteReactionDeleteAsync(NoteReactionDeleteMutationInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested organization fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<OrganizationCreatePayload> OrganizationCreateAsync(OrganizationCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested organization fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<OrganizationCreatePayload> OrganizationCreateAsync(OrganizationCreateInput data, OrganizationQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested organization fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<OrganizationUpdatePayload> OrganizationUpdateAsync(OrganizationUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested organization fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<OrganizationUpdatePayload> OrganizationUpdateAsync(OrganizationUpdateInput data, OrganizationQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested out of office period fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<OutOfOfficePeriodCreatePayload> OutOfOfficePeriodCreateAsync(OutOfOfficePeriodCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested out of office period fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<OutOfOfficePeriodCreatePayload> OutOfOfficePeriodCreateAsync(OutOfOfficePeriodCreateInput data, OutOfOfficePeriodQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<OutOfOfficePeriodDeleteMutationPayload> OutOfOfficePeriodDeleteAsync(OutOfOfficePeriodDeleteMutationInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested out of office period fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<OutOfOfficePeriodUpdatePayload> OutOfOfficePeriodUpdateAsync(OutOfOfficePeriodUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested out of office period fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<OutOfOfficePeriodUpdatePayload> OutOfOfficePeriodUpdateAsync(OutOfOfficePeriodUpdateInput data, OutOfOfficePeriodQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested pdf design fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<PdfDesignCreatePayload> PdfDesignCreateAsync(PdfDesignCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested pdf design fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<PdfDesignCreatePayload> PdfDesignCreateAsync(PdfDesignCreateInput data, PdfDesignQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested pdf design fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<PdfDesignUpdatePayload> PdfDesignUpdateAsync(PdfDesignUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested pdf design fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<PdfDesignUpdatePayload> PdfDesignUpdateAsync(PdfDesignUpdateInput data, PdfDesignQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested person fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<PersonCreatePayload> PersonCreateAsync(PersonCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested person fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<PersonCreatePayload> PersonCreateAsync(PersonCreateInput data, PersonQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested person fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<PersonUpdatePayload> PersonUpdateAsync(PersonUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested person fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<PersonUpdatePayload> PersonUpdateAsync(PersonUpdateInput data, PersonQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested problem fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProblemCreatePayload> ProblemCreateAsync(ProblemCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested problem fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProblemCreatePayload> ProblemCreateAsync(ProblemCreateInput data, ProblemQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested problem fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProblemUpdatePayload> ProblemUpdateAsync(ProblemUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested problem fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProblemUpdatePayload> ProblemUpdateAsync(ProblemUpdateInput data, ProblemQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product backlog fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProductBacklogCreatePayload> ProductBacklogCreateAsync(ProductBacklogCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product backlog fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProductBacklogCreatePayload> ProductBacklogCreateAsync(ProductBacklogCreateInput data, ProductBacklogQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product backlog fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProductBacklogUpdatePayload> ProductBacklogUpdateAsync(ProductBacklogUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product backlog fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProductBacklogUpdatePayload> ProductBacklogUpdateAsync(ProductBacklogUpdateInput data, ProductBacklogQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProductCategoryCreatePayload> ProductCategoryCreateAsync(ProductCategoryCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProductCategoryCreatePayload> ProductCategoryCreateAsync(ProductCategoryCreateInput data, ProductCategoryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProductCategoryUpdatePayload> ProductCategoryUpdateAsync(ProductCategoryUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProductCategoryUpdatePayload> ProductCategoryUpdateAsync(ProductCategoryUpdateInput data, ProductCategoryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProductCreatePayload> ProductCreateAsync(ProductCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProductCreatePayload> ProductCreateAsync(ProductCreateInput data, ProductQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProductUpdatePayload> ProductUpdateAsync(ProductUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProductUpdatePayload> ProductUpdateAsync(ProductUpdateInput data, ProductQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectCategoryCreatePayload> ProjectCategoryCreateAsync(ProjectCategoryCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectCategoryCreatePayload> ProjectCategoryCreateAsync(ProjectCategoryCreateInput data, ProjectCategoryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectCategoryUpdatePayload> ProjectCategoryUpdateAsync(ProjectCategoryUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectCategoryUpdatePayload> ProjectCategoryUpdateAsync(ProjectCategoryUpdateInput data, ProjectCategoryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectCreatePayload> ProjectCreateAsync(ProjectCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectCreatePayload> ProjectCreateAsync(ProjectCreateInput data, ProjectQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project risk level fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectRiskLevelCreatePayload> ProjectRiskLevelCreateAsync(ProjectRiskLevelCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project risk level fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectRiskLevelCreatePayload> ProjectRiskLevelCreateAsync(ProjectRiskLevelCreateInput data, ProjectRiskLevelQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project risk level fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectRiskLevelUpdatePayload> ProjectRiskLevelUpdateAsync(ProjectRiskLevelUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project risk level fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectRiskLevelUpdatePayload> ProjectRiskLevelUpdateAsync(ProjectRiskLevelUpdateInput data, ProjectRiskLevelQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project task fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectTaskCreatePayload> ProjectTaskCreateAsync(ProjectTaskCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project task fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectTaskCreatePayload> ProjectTaskCreateAsync(ProjectTaskCreateInput data, ProjectTaskQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project task template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectTaskTemplateCreatePayload> ProjectTaskTemplateCreateAsync(ProjectTaskTemplateCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project task template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectTaskTemplateCreatePayload> ProjectTaskTemplateCreateAsync(ProjectTaskTemplateCreateInput data, ProjectTaskTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project task template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectTaskTemplateUpdatePayload> ProjectTaskTemplateUpdateAsync(ProjectTaskTemplateUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project task template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectTaskTemplateUpdatePayload> ProjectTaskTemplateUpdateAsync(ProjectTaskTemplateUpdateInput data, ProjectTaskTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project task fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectTaskUpdatePayload> ProjectTaskUpdateAsync(ProjectTaskUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project task fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectTaskUpdatePayload> ProjectTaskUpdateAsync(ProjectTaskUpdateInput data, ProjectTaskQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectTemplateCreatePayload> ProjectTemplateCreateAsync(ProjectTemplateCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectTemplateCreatePayload> ProjectTemplateCreateAsync(ProjectTemplateCreateInput data, ProjectTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectTemplateUpdatePayload> ProjectTemplateUpdateAsync(ProjectTemplateUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectTemplateUpdatePayload> ProjectTemplateUpdateAsync(ProjectTemplateUpdateInput data, ProjectTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ProjectUpdatePayload> ProjectUpdateAsync(ProjectUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ProjectUpdatePayload> ProjectUpdateAsync(ProjectUpdateInput data, ProjectQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested release fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ReleaseCreatePayload> ReleaseCreateAsync(ReleaseCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested release fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ReleaseCreatePayload> ReleaseCreateAsync(ReleaseCreateInput data, ReleaseQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested release fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ReleaseUpdatePayload> ReleaseUpdateAsync(ReleaseUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested release fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ReleaseUpdatePayload> ReleaseUpdateAsync(ReleaseUpdateInput data, ReleaseQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested request fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RequestCreatePayload> RequestCreateAsync(RequestCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested request fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<RequestCreatePayload> RequestCreateAsync(RequestCreateInput data, RequestQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested request template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RequestTemplateCreatePayload> RequestTemplateCreateAsync(RequestTemplateCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested request template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<RequestTemplateCreatePayload> RequestTemplateCreateAsync(RequestTemplateCreateInput data, RequestTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested request template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RequestTemplateUpdatePayload> RequestTemplateUpdateAsync(RequestTemplateUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested request template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<RequestTemplateUpdatePayload> RequestTemplateUpdateAsync(RequestTemplateUpdateInput data, RequestTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested request fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RequestUpdatePayload> RequestUpdateAsync(RequestUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested request fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<RequestUpdatePayload> RequestUpdateAsync(RequestUpdateInput data, RequestQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RequestUpdateVisibilityPayload> RequestUpdateVisibilityAsync(RequestUpdateVisibilityInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested reservation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ReservationCreatePayload> ReservationCreateAsync(ReservationCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested reservation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ReservationCreatePayload> ReservationCreateAsync(ReservationCreateInput data, ReservationQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested reservation offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ReservationOfferingCreatePayload> ReservationOfferingCreateAsync(ReservationOfferingCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested reservation offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ReservationOfferingCreatePayload> ReservationOfferingCreateAsync(ReservationOfferingCreateInput data, ReservationOfferingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested reservation offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ReservationOfferingUpdatePayload> ReservationOfferingUpdateAsync(ReservationOfferingUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested reservation offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ReservationOfferingUpdatePayload> ReservationOfferingUpdateAsync(ReservationOfferingUpdateInput data, ReservationOfferingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested reservation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ReservationUpdatePayload> ReservationUpdateAsync(ReservationUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested reservation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ReservationUpdatePayload> ReservationUpdateAsync(ReservationUpdateInput data, ReservationQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested risk fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RiskCreatePayload> RiskCreateAsync(RiskCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested risk fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<RiskCreatePayload> RiskCreateAsync(RiskCreateInput data, RiskQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested risk severity fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RiskSeverityCreatePayload> RiskSeverityCreateAsync(RiskSeverityCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested risk severity fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<RiskSeverityCreatePayload> RiskSeverityCreateAsync(RiskSeverityCreateInput data, RiskSeverityQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested risk severity fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RiskSeverityUpdatePayload> RiskSeverityUpdateAsync(RiskSeverityUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested risk severity fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<RiskSeverityUpdatePayload> RiskSeverityUpdateAsync(RiskSeverityUpdateInput data, RiskSeverityQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested risk fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<RiskUpdatePayload> RiskUpdateAsync(RiskUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested risk fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<RiskUpdatePayload> RiskUpdateAsync(RiskUpdateInput data, RiskQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested scrum workspace fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ScrumWorkspaceCreatePayload> ScrumWorkspaceCreateAsync(ScrumWorkspaceCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested scrum workspace fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ScrumWorkspaceCreatePayload> ScrumWorkspaceCreateAsync(ScrumWorkspaceCreateInput data, ScrumWorkspaceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested scrum workspace fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ScrumWorkspaceUpdatePayload> ScrumWorkspaceUpdateAsync(ScrumWorkspaceUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested scrum workspace fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ScrumWorkspaceUpdatePayload> ScrumWorkspaceUpdateAsync(ScrumWorkspaceUpdateInput data, ScrumWorkspaceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the sera ai studio mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sera ai studio fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SeraAiStudioUpdatePayload> SeraAiStudioUpdateAsync(SeraAiStudioUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the sera ai studio mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sera ai studio fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SeraAiStudioUpdatePayload> SeraAiStudioUpdateAsync(SeraAiStudioUpdateInput data, SeraAiStudioQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceCategoryCreatePayload> ServiceCategoryCreateAsync(ServiceCategoryCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceCategoryCreatePayload> ServiceCategoryCreateAsync(ServiceCategoryCreateInput data, ServiceCategoryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceCategoryUpdatePayload> ServiceCategoryUpdateAsync(ServiceCategoryUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceCategoryUpdatePayload> ServiceCategoryUpdateAsync(ServiceCategoryUpdateInput data, ServiceCategoryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceCreatePayload> ServiceCreateAsync(ServiceCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceCreatePayload> ServiceCreateAsync(ServiceCreateInput data, ServiceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service instance fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceInstanceCreatePayload> ServiceInstanceCreateAsync(ServiceInstanceCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service instance fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceInstanceCreatePayload> ServiceInstanceCreateAsync(ServiceInstanceCreateInput data, ServiceInstanceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service instance fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceInstanceUpdatePayload> ServiceInstanceUpdateAsync(ServiceInstanceUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service instance fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceInstanceUpdatePayload> ServiceInstanceUpdateAsync(ServiceInstanceUpdateInput data, ServiceInstanceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service level agreement fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceLevelAgreementCreatePayload> ServiceLevelAgreementCreateAsync(ServiceLevelAgreementCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service level agreement fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceLevelAgreementCreatePayload> ServiceLevelAgreementCreateAsync(ServiceLevelAgreementCreateInput data, ServiceLevelAgreementQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service level agreement fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceLevelAgreementUpdatePayload> ServiceLevelAgreementUpdateAsync(ServiceLevelAgreementUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service level agreement fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceLevelAgreementUpdatePayload> ServiceLevelAgreementUpdateAsync(ServiceLevelAgreementUpdateInput data, ServiceLevelAgreementQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceOfferingCreatePayload> ServiceOfferingCreateAsync(ServiceOfferingCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceOfferingCreatePayload> ServiceOfferingCreateAsync(ServiceOfferingCreateInput data, ServiceOfferingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceOfferingUpdatePayload> ServiceOfferingUpdateAsync(ServiceOfferingUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceOfferingUpdatePayload> ServiceOfferingUpdateAsync(ServiceOfferingUpdateInput data, ServiceOfferingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ServiceUpdatePayload> ServiceUpdateAsync(ServiceUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ServiceUpdatePayload> ServiceUpdateAsync(ServiceUpdateInput data, ServiceQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop article category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ShopArticleCategoryCreatePayload> ShopArticleCategoryCreateAsync(ShopArticleCategoryCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop article category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ShopArticleCategoryCreatePayload> ShopArticleCategoryCreateAsync(ShopArticleCategoryCreateInput data, ShopArticleCategoryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop article category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ShopArticleCategoryUpdatePayload> ShopArticleCategoryUpdateAsync(ShopArticleCategoryUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop article category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ShopArticleCategoryUpdatePayload> ShopArticleCategoryUpdateAsync(ShopArticleCategoryUpdateInput data, ShopArticleCategoryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ShopArticleCreatePayload> ShopArticleCreateAsync(ShopArticleCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ShopArticleCreatePayload> ShopArticleCreateAsync(ShopArticleCreateInput data, ShopArticleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ShopArticleUpdatePayload> ShopArticleUpdateAsync(ShopArticleUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ShopArticleUpdatePayload> ShopArticleUpdateAsync(ShopArticleUpdateInput data, ShopArticleQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop order line fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ShopOrderLineCreatePayload> ShopOrderLineCreateAsync(ShopOrderLineCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop order line fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ShopOrderLineCreatePayload> ShopOrderLineCreateAsync(ShopOrderLineCreateInput data, ShopOrderLineQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop order line fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ShopOrderLineUpdatePayload> ShopOrderLineUpdateAsync(ShopOrderLineUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop order line fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ShopOrderLineUpdatePayload> ShopOrderLineUpdateAsync(ShopOrderLineUpdateInput data, ShopOrderLineQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested short url fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ShortUrlCreatePayload> ShortUrlCreateAsync(ShortUrlCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested short url fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ShortUrlCreatePayload> ShortUrlCreateAsync(ShortUrlCreateInput data, ShortUrlQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested short url fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<ShortUrlUpdatePayload> ShortUrlUpdateAsync(ShortUrlUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested short url fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<ShortUrlUpdatePayload> ShortUrlUpdateAsync(ShortUrlUpdateInput data, ShortUrlQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested site fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SiteCreatePayload> SiteCreateAsync(SiteCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested site fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SiteCreatePayload> SiteCreateAsync(SiteCreateInput data, SiteQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested site fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SiteUpdatePayload> SiteUpdateAsync(SiteUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested site fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SiteUpdatePayload> SiteUpdateAsync(SiteUpdateInput data, SiteQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested skill pool fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SkillPoolCreatePayload> SkillPoolCreateAsync(SkillPoolCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested skill pool fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SkillPoolCreatePayload> SkillPoolCreateAsync(SkillPoolCreateInput data, SkillPoolQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested skill pool fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SkillPoolUpdatePayload> SkillPoolUpdateAsync(SkillPoolUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested skill pool fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SkillPoolUpdatePayload> SkillPoolUpdateAsync(SkillPoolUpdateInput data, SkillPoolQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sla coverage group fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SlaCoverageGroupCreatePayload> SlaCoverageGroupCreateAsync(SlaCoverageGroupCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sla coverage group fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SlaCoverageGroupCreatePayload> SlaCoverageGroupCreateAsync(SlaCoverageGroupCreateInput data, SlaCoverageGroupQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sla coverage group fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SlaCoverageGroupUpdatePayload> SlaCoverageGroupUpdateAsync(SlaCoverageGroupUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sla coverage group fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SlaCoverageGroupUpdatePayload> SlaCoverageGroupUpdateAsync(SlaCoverageGroupUpdateInput data, SlaCoverageGroupQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sla notification scheme fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SlaNotificationSchemeCreatePayload> SlaNotificationSchemeCreateAsync(SlaNotificationSchemeCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sla notification scheme fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SlaNotificationSchemeCreatePayload> SlaNotificationSchemeCreateAsync(SlaNotificationSchemeCreateInput data, SlaNotificationSchemeQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sla notification scheme fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SlaNotificationSchemeUpdatePayload> SlaNotificationSchemeUpdateAsync(SlaNotificationSchemeUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sla notification scheme fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SlaNotificationSchemeUpdatePayload> SlaNotificationSchemeUpdateAsync(SlaNotificationSchemeUpdateInput data, SlaNotificationSchemeQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sprint fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SprintCreatePayload> SprintCreateAsync(SprintCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sprint fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SprintCreatePayload> SprintCreateAsync(SprintCreateInput data, SprintQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sprint fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SprintUpdatePayload> SprintUpdateAsync(SprintUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sprint fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SprintUpdatePayload> SprintUpdateAsync(SprintUpdateInput data, SprintQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested survey fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SurveyCreatePayload> SurveyCreateAsync(SurveyCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested survey fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SurveyCreatePayload> SurveyCreateAsync(SurveyCreateInput data, SurveyQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested survey response fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SurveyResponseCreatePayload> SurveyResponseCreateAsync(SurveyResponseCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested survey response fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SurveyResponseCreatePayload> SurveyResponseCreateAsync(SurveyResponseCreateInput data, SurveyResponseQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested survey response fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SurveyResponseUpdatePayload> SurveyResponseUpdateAsync(SurveyResponseUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested survey response fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SurveyResponseUpdatePayload> SurveyResponseUpdateAsync(SurveyResponseUpdateInput data, SurveyResponseQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested survey fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<SurveyUpdatePayload> SurveyUpdateAsync(SurveyUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested survey fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<SurveyUpdatePayload> SurveyUpdateAsync(SurveyUpdateInput data, SurveyQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested team fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TeamCreatePayload> TeamCreateAsync(TeamCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested team fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TeamCreatePayload> TeamCreateAsync(TeamCreateInput data, TeamQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested team fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TeamUpdatePayload> TeamUpdateAsync(TeamUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested team fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TeamUpdatePayload> TeamUpdateAsync(TeamUpdateInput data, TeamQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested time allocation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TimeAllocationCreatePayload> TimeAllocationCreateAsync(TimeAllocationCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested time allocation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TimeAllocationCreatePayload> TimeAllocationCreateAsync(TimeAllocationCreateInput data, TimeAllocationQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested time allocation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TimeAllocationUpdatePayload> TimeAllocationUpdateAsync(TimeAllocationUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested time allocation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TimeAllocationUpdatePayload> TimeAllocationUpdateAsync(TimeAllocationUpdateInput data, TimeAllocationQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested time entry fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TimeEntryCreatePayload> TimeEntryCreateAsync(TimeEntryCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested time entry fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TimeEntryCreatePayload> TimeEntryCreateAsync(TimeEntryCreateInput data, TimeEntryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested time entry fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TimeEntryUpdatePayload> TimeEntryUpdateAsync(TimeEntryUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested time entry fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TimeEntryUpdatePayload> TimeEntryUpdateAsync(TimeEntryUpdateInput data, TimeEntryQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested timesheet setting fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TimesheetSettingCreatePayload> TimesheetSettingCreateAsync(TimesheetSettingCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested timesheet setting fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TimesheetSettingCreatePayload> TimesheetSettingCreateAsync(TimesheetSettingCreateInput data, TimesheetSettingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested timesheet setting fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TimesheetSettingUpdatePayload> TimesheetSettingUpdateAsync(TimesheetSettingUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested timesheet setting fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TimesheetSettingUpdatePayload> TimesheetSettingUpdateAsync(TimesheetSettingUpdateInput data, TimesheetSettingQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested translation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TranslationCreatePayload> TranslationCreateAsync(TranslationCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested translation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TranslationCreatePayload> TranslationCreateAsync(TranslationCreateInput data, TranslationQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested translation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<TranslationUpdatePayload> TranslationUpdateAsync(TranslationUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested translation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<TranslationUpdatePayload> TranslationUpdateAsync(TranslationUpdateInput data, TranslationQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested ui extension fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<UiExtensionCreatePayload> UiExtensionCreateAsync(UiExtensionCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested ui extension fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<UiExtensionCreatePayload> UiExtensionCreateAsync(UiExtensionCreateInput data, UiExtensionQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested ui extension fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<UiExtensionUpdatePayload> UiExtensionUpdateAsync(UiExtensionUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested ui extension fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<UiExtensionUpdatePayload> UiExtensionUpdateAsync(UiExtensionUpdateInput data, UiExtensionQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested waiting for customer follow up fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WaitingForCustomerFollowUpCreatePayload> WaitingForCustomerFollowUpCreateAsync(WaitingForCustomerFollowUpCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested waiting for customer follow up fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WaitingForCustomerFollowUpCreatePayload> WaitingForCustomerFollowUpCreateAsync(WaitingForCustomerFollowUpCreateInput data, WaitingForCustomerFollowUpQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested waiting for customer follow up fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WaitingForCustomerFollowUpUpdatePayload> WaitingForCustomerFollowUpUpdateAsync(WaitingForCustomerFollowUpUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested waiting for customer follow up fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WaitingForCustomerFollowUpUpdatePayload> WaitingForCustomerFollowUpUpdateAsync(WaitingForCustomerFollowUpUpdateInput data, WaitingForCustomerFollowUpQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested webhook fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WebhookCreatePayload> WebhookCreateAsync(WebhookCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested webhook fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WebhookCreatePayload> WebhookCreateAsync(WebhookCreateInput data, WebhookQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WebhookDeleteMutationPayload> WebhookDeleteAsync(WebhookDeleteMutationInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested webhook policy fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WebhookPolicyCreatePayload> WebhookPolicyCreateAsync(WebhookPolicyCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested webhook policy fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WebhookPolicyCreatePayload> WebhookPolicyCreateAsync(WebhookPolicyCreateInput data, WebhookPolicyCreateResponseQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WebhookPolicyDeleteMutationPayload> WebhookPolicyDeleteAsync(WebhookPolicyDeleteMutationInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested webhook policy fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WebhookPolicyUpdatePayload> WebhookPolicyUpdateAsync(WebhookPolicyUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested webhook policy fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WebhookPolicyUpdatePayload> WebhookPolicyUpdateAsync(WebhookPolicyUpdateInput data, WebhookPolicyQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested webhook fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WebhookUpdatePayload> WebhookUpdateAsync(WebhookUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested webhook fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WebhookUpdatePayload> WebhookUpdateAsync(WebhookUpdateInput data, WebhookQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowCreatePayload> WorkflowCreateAsync(WorkflowCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowCreatePayload> WorkflowCreateAsync(WorkflowCreateInput data, WorkflowQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested task fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowTaskCreatePayload> WorkflowTaskCreateAsync(WorkflowTaskCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested task fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowTaskCreatePayload> WorkflowTaskCreateAsync(WorkflowTaskCreateInput data, WorkflowTaskQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested task template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowTaskTemplateCreatePayload> WorkflowTaskTemplateCreateAsync(WorkflowTaskTemplateCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested task template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowTaskTemplateCreatePayload> WorkflowTaskTemplateCreateAsync(WorkflowTaskTemplateCreateInput data, WorkflowTaskTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested task template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowTaskTemplateUpdatePayload> WorkflowTaskTemplateUpdateAsync(WorkflowTaskTemplateUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested task template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowTaskTemplateUpdatePayload> WorkflowTaskTemplateUpdateAsync(WorkflowTaskTemplateUpdateInput data, WorkflowTaskTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested task fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowTaskUpdatePayload> WorkflowTaskUpdateAsync(WorkflowTaskUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested task fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowTaskUpdatePayload> WorkflowTaskUpdateAsync(WorkflowTaskUpdateInput data, WorkflowTaskQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowTemplateCreatePayload> WorkflowTemplateCreateAsync(WorkflowTemplateCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowTemplateCreatePayload> WorkflowTemplateCreateAsync(WorkflowTemplateCreateInput data, WorkflowTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowTemplateUpdatePayload> WorkflowTemplateUpdateAsync(WorkflowTemplateUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowTemplateUpdatePayload> WorkflowTemplateUpdateAsync(WorkflowTemplateUpdateInput data, WorkflowTemplateQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow type fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowTypeCreatePayload> WorkflowTypeCreateAsync(WorkflowTypeCreateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow type fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowTypeCreatePayload> WorkflowTypeCreateAsync(WorkflowTypeCreateInput data, WorkflowTypeQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow type fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowTypeUpdatePayload> WorkflowTypeUpdateAsync(WorkflowTypeUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow type fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowTypeUpdatePayload> WorkflowTypeUpdateAsync(WorkflowTypeUpdateInput data, WorkflowTypeQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        public Task<WorkflowUpdatePayload> WorkflowUpdateAsync(WorkflowUpdateInput data, CancellationToken ct = default)
        {
            return MutationAsync(data, ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        public Task<WorkflowUpdatePayload> WorkflowUpdateAsync(WorkflowUpdateInput data, WorkflowQuery query, CancellationToken ct = default)
        {
            return MutationAsync(data, query, ct);
        }
    }
}
