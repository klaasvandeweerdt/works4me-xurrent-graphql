using System;
using System.ComponentModel;
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
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AgileBoardCreatePayload> MutationAsync(AgileBoardCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AgileBoardCreatePayload, AgileBoardCreateInput>(GetAccountId(), new AgileBoardCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested agile board fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AgileBoardCreatePayload> MutationAsync(AgileBoardCreateInput data, AgileBoardQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AgileBoardCreatePayload, AgileBoardCreateInput>(GetAccountId(), new AgileBoardCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested agile board fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AgileBoardUpdatePayload> MutationAsync(AgileBoardUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AgileBoardUpdatePayload, AgileBoardUpdateInput>(GetAccountId(), new AgileBoardUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested agile board fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AgileBoardUpdatePayload> MutationAsync(AgileBoardUpdateInput data, AgileBoardQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AgileBoardUpdatePayload, AgileBoardUpdateInput>(GetAccountId(), new AgileBoardUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app instance fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppInstanceCreatePayload> MutationAsync(AppInstanceCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppInstanceCreatePayload, AppInstanceCreateInput>(GetAccountId(), new AppInstanceCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app instance fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppInstanceCreatePayload> MutationAsync(AppInstanceCreateInput data, AppInstanceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppInstanceCreatePayload, AppInstanceCreateInput>(GetAccountId(), new AppInstanceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app instance fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppInstanceUpdatePayload> MutationAsync(AppInstanceUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppInstanceUpdatePayload, AppInstanceUpdateInput>(GetAccountId(), new AppInstanceUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app instance fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppInstanceUpdatePayload> MutationAsync(AppInstanceUpdateInput data, AppInstanceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppInstanceUpdatePayload, AppInstanceUpdateInput>(GetAccountId(), new AppInstanceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering automation rule fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingAutomationRuleCreatePayload> MutationAsync(AppOfferingAutomationRuleCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppOfferingAutomationRuleCreatePayload, AppOfferingAutomationRuleCreateInput>(GetAccountId(), new AppOfferingAutomationRuleCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering automation rule fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingAutomationRuleCreatePayload> MutationAsync(AppOfferingAutomationRuleCreateInput data, AppOfferingAutomationRuleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingAutomationRuleCreatePayload, AppOfferingAutomationRuleCreateInput>(GetAccountId(), new AppOfferingAutomationRuleCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingAutomationRuleDeleteMutationPayload> MutationAsync(AppOfferingAutomationRuleDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppOfferingAutomationRuleDeleteMutationPayload, AppOfferingAutomationRuleDeleteMutationInput>(GetAccountId(), new AppOfferingAutomationRuleDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering automation rule fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingAutomationRuleUpdatePayload> MutationAsync(AppOfferingAutomationRuleUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppOfferingAutomationRuleUpdatePayload, AppOfferingAutomationRuleUpdateInput>(GetAccountId(), new AppOfferingAutomationRuleUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering automation rule fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingAutomationRuleUpdatePayload> MutationAsync(AppOfferingAutomationRuleUpdateInput data, AppOfferingAutomationRuleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingAutomationRuleUpdatePayload, AppOfferingAutomationRuleUpdateInput>(GetAccountId(), new AppOfferingAutomationRuleUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingCreatePayload> MutationAsync(AppOfferingCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppOfferingCreatePayload, AppOfferingCreateInput>(GetAccountId(), new AppOfferingCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingCreatePayload> MutationAsync(AppOfferingCreateInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingCreatePayload, AppOfferingCreateInput>(GetAccountId(), new AppOfferingCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingPublishMutationPayload> MutationAsync(AppOfferingPublishMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppOfferingPublishMutationPayload, AppOfferingPublishMutationInput>(GetAccountId(), new AppOfferingPublishMutation(data, null), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingPublishMutationPayload> MutationAsync(AppOfferingPublishMutationInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingPublishMutationPayload, AppOfferingPublishMutationInput>(GetAccountId(), new AppOfferingPublishMutation(data, query), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested app offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingUpdatePayload> MutationAsync(AppOfferingUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AppOfferingUpdatePayload, AppOfferingUpdateInput>(GetAccountId(), new AppOfferingUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested app offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AppOfferingUpdatePayload> MutationAsync(AppOfferingUpdateInput data, AppOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AppOfferingUpdatePayload, AppOfferingUpdateInput>(GetAccountId(), new AppOfferingUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested automation rule fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AutomationRuleCreatePayload> MutationAsync(AutomationRuleCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AutomationRuleCreatePayload, AutomationRuleCreateInput>(GetAccountId(), new AutomationRuleCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested automation rule fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AutomationRuleCreatePayload> MutationAsync(AutomationRuleCreateInput data, AutomationRuleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AutomationRuleCreatePayload, AutomationRuleCreateInput>(GetAccountId(), new AutomationRuleCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested automation rule fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AutomationRuleUpdatePayload> MutationAsync(AutomationRuleUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<AutomationRuleUpdatePayload, AutomationRuleUpdateInput>(GetAccountId(), new AutomationRuleUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested automation rule fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<AutomationRuleUpdatePayload> MutationAsync(AutomationRuleUpdateInput data, AutomationRuleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<AutomationRuleUpdatePayload, AutomationRuleUpdateInput>(GetAccountId(), new AutomationRuleUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested broadcast fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<BroadcastCreatePayload> MutationAsync(BroadcastCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<BroadcastCreatePayload, BroadcastCreateInput>(GetAccountId(), new BroadcastCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested broadcast fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<BroadcastCreatePayload> MutationAsync(BroadcastCreateInput data, BroadcastQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<BroadcastCreatePayload, BroadcastCreateInput>(GetAccountId(), new BroadcastCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested broadcast fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<BroadcastUpdatePayload> MutationAsync(BroadcastUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<BroadcastUpdatePayload, BroadcastUpdateInput>(GetAccountId(), new BroadcastUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested broadcast fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<BroadcastUpdatePayload> MutationAsync(BroadcastUpdateInput data, BroadcastQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<BroadcastUpdatePayload, BroadcastUpdateInput>(GetAccountId(), new BroadcastUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested calendar fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CalendarCreatePayload> MutationAsync(CalendarCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<CalendarCreatePayload, CalendarCreateInput>(GetAccountId(), new CalendarCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested calendar fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CalendarCreatePayload> MutationAsync(CalendarCreateInput data, CalendarQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CalendarCreatePayload, CalendarCreateInput>(GetAccountId(), new CalendarCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested calendar fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CalendarUpdatePayload> MutationAsync(CalendarUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<CalendarUpdatePayload, CalendarUpdateInput>(GetAccountId(), new CalendarUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested calendar fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CalendarUpdatePayload> MutationAsync(CalendarUpdateInput data, CalendarQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CalendarUpdatePayload, CalendarUpdateInput>(GetAccountId(), new CalendarUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested closure code fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ClosureCodeCreatePayload> MutationAsync(ClosureCodeCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ClosureCodeCreatePayload, ClosureCodeCreateInput>(GetAccountId(), new ClosureCodeCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested closure code fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ClosureCodeCreatePayload> MutationAsync(ClosureCodeCreateInput data, ClosureCodeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ClosureCodeCreatePayload, ClosureCodeCreateInput>(GetAccountId(), new ClosureCodeCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested closure code fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ClosureCodeUpdatePayload> MutationAsync(ClosureCodeUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ClosureCodeUpdatePayload, ClosureCodeUpdateInput>(GetAccountId(), new ClosureCodeUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested closure code fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ClosureCodeUpdatePayload> MutationAsync(ClosureCodeUpdateInput data, ClosureCodeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ClosureCodeUpdatePayload, ClosureCodeUpdateInput>(GetAccountId(), new ClosureCodeUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested configuration item fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ConfigurationItemCreatePayload> MutationAsync(ConfigurationItemCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ConfigurationItemCreatePayload, ConfigurationItemCreateInput>(GetAccountId(), new ConfigurationItemCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested configuration item fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ConfigurationItemCreatePayload> MutationAsync(ConfigurationItemCreateInput data, ConfigurationItemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ConfigurationItemCreatePayload, ConfigurationItemCreateInput>(GetAccountId(), new ConfigurationItemCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested configuration item fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ConfigurationItemUpdatePayload> MutationAsync(ConfigurationItemUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ConfigurationItemUpdatePayload, ConfigurationItemUpdateInput>(GetAccountId(), new ConfigurationItemUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested configuration item fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ConfigurationItemUpdatePayload> MutationAsync(ConfigurationItemUpdateInput data, ConfigurationItemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ConfigurationItemUpdatePayload, ConfigurationItemUpdateInput>(GetAccountId(), new ConfigurationItemUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested contract fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ContractCreatePayload> MutationAsync(ContractCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ContractCreatePayload, ContractCreateInput>(GetAccountId(), new ContractCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested contract fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ContractCreatePayload> MutationAsync(ContractCreateInput data, ContractQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ContractCreatePayload, ContractCreateInput>(GetAccountId(), new ContractCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested contract fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ContractUpdatePayload> MutationAsync(ContractUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ContractUpdatePayload, ContractUpdateInput>(GetAccountId(), new ContractUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested contract fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ContractUpdatePayload> MutationAsync(ContractUpdateInput data, ContractQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ContractUpdatePayload, ContractUpdateInput>(GetAccountId(), new ContractUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested custom collection fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CustomCollectionCreatePayload> MutationAsync(CustomCollectionCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<CustomCollectionCreatePayload, CustomCollectionCreateInput>(GetAccountId(), new CustomCollectionCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested custom collection fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CustomCollectionCreatePayload> MutationAsync(CustomCollectionCreateInput data, CustomCollectionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CustomCollectionCreatePayload, CustomCollectionCreateInput>(GetAccountId(), new CustomCollectionCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested custom collection element fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CustomCollectionElementCreatePayload> MutationAsync(CustomCollectionElementCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<CustomCollectionElementCreatePayload, CustomCollectionElementCreateInput>(GetAccountId(), new CustomCollectionElementCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested custom collection element fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CustomCollectionElementCreatePayload> MutationAsync(CustomCollectionElementCreateInput data, CustomCollectionElementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CustomCollectionElementCreatePayload, CustomCollectionElementCreateInput>(GetAccountId(), new CustomCollectionElementCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested custom collection element fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CustomCollectionElementUpdatePayload> MutationAsync(CustomCollectionElementUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<CustomCollectionElementUpdatePayload, CustomCollectionElementUpdateInput>(GetAccountId(), new CustomCollectionElementUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested custom collection element fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CustomCollectionElementUpdatePayload> MutationAsync(CustomCollectionElementUpdateInput data, CustomCollectionElementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<CustomCollectionElementUpdatePayload, CustomCollectionElementUpdateInput>(GetAccountId(), new CustomCollectionElementUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested custom collection fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<CustomCollectionUpdatePayload> MutationAsync(CustomCollectionUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<CustomCollectionUpdatePayload, CustomCollectionUpdateInput>(GetAccountId(), new CustomCollectionUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested custom collection fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
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
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested mutation response fields.</returns>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
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
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested effort class fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<EffortClassCreatePayload> MutationAsync(EffortClassCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<EffortClassCreatePayload, EffortClassCreateInput>(GetAccountId(), new EffortClassCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested effort class fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<EffortClassCreatePayload> MutationAsync(EffortClassCreateInput data, EffortClassQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<EffortClassCreatePayload, EffortClassCreateInput>(GetAccountId(), new EffortClassCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested effort class fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<EffortClassUpdatePayload> MutationAsync(EffortClassUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<EffortClassUpdatePayload, EffortClassUpdateInput>(GetAccountId(), new EffortClassUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested effort class fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<EffortClassUpdatePayload> MutationAsync(EffortClassUpdateInput data, EffortClassQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<EffortClassUpdatePayload, EffortClassUpdateInput>(GetAccountId(), new EffortClassUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested first line support agreement fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<FirstLineSupportAgreementCreatePayload> MutationAsync(FirstLineSupportAgreementCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<FirstLineSupportAgreementCreatePayload, FirstLineSupportAgreementCreateInput>(GetAccountId(), new FirstLineSupportAgreementCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested first line support agreement fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<FirstLineSupportAgreementCreatePayload> MutationAsync(FirstLineSupportAgreementCreateInput data, FirstLineSupportAgreementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<FirstLineSupportAgreementCreatePayload, FirstLineSupportAgreementCreateInput>(GetAccountId(), new FirstLineSupportAgreementCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested first line support agreement fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<FirstLineSupportAgreementUpdatePayload> MutationAsync(FirstLineSupportAgreementUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<FirstLineSupportAgreementUpdatePayload, FirstLineSupportAgreementUpdateInput>(GetAccountId(), new FirstLineSupportAgreementUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested first line support agreement fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<FirstLineSupportAgreementUpdatePayload> MutationAsync(FirstLineSupportAgreementUpdateInput data, FirstLineSupportAgreementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<FirstLineSupportAgreementUpdatePayload, FirstLineSupportAgreementUpdateInput>(GetAccountId(), new FirstLineSupportAgreementUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested golden set item fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<GoldenSetItemCreatePayload> MutationAsync(GoldenSetItemCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<GoldenSetItemCreatePayload, GoldenSetItemCreateInput>(GetAccountId(), new GoldenSetItemCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested golden set item fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<GoldenSetItemCreatePayload> MutationAsync(GoldenSetItemCreateInput data, GoldenSetItemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<GoldenSetItemCreatePayload, GoldenSetItemCreateInput>(GetAccountId(), new GoldenSetItemCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<GoldenSetItemDeleteMutationPayload> MutationAsync(GoldenSetItemDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<GoldenSetItemDeleteMutationPayload, GoldenSetItemDeleteMutationInput>(GetAccountId(), new GoldenSetItemDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested golden set item fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<GoldenSetItemUpdatePayload> MutationAsync(GoldenSetItemUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<GoldenSetItemUpdatePayload, GoldenSetItemUpdateInput>(GetAccountId(), new GoldenSetItemUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested golden set item fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<GoldenSetItemUpdatePayload> MutationAsync(GoldenSetItemUpdateInput data, GoldenSetItemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<GoldenSetItemUpdatePayload, GoldenSetItemUpdateInput>(GetAccountId(), new GoldenSetItemUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested holiday fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<HolidayCreatePayload> MutationAsync(HolidayCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<HolidayCreatePayload, HolidayCreateInput>(GetAccountId(), new HolidayCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested holiday fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<HolidayCreatePayload> MutationAsync(HolidayCreateInput data, HolidayQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<HolidayCreatePayload, HolidayCreateInput>(GetAccountId(), new HolidayCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested holiday fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<HolidayUpdatePayload> MutationAsync(HolidayUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<HolidayUpdatePayload, HolidayUpdateInput>(GetAccountId(), new HolidayUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested holiday fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<HolidayUpdatePayload> MutationAsync(HolidayUpdateInput data, HolidayQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<HolidayUpdatePayload, HolidayUpdateInput>(GetAccountId(), new HolidayUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested invoice fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<InvoiceCreatePayload> MutationAsync(InvoiceCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<InvoiceCreatePayload, InvoiceCreateInput>(GetAccountId(), new InvoiceCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested invoice fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<InvoiceCreatePayload> MutationAsync(InvoiceCreateInput data, InvoiceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<InvoiceCreatePayload, InvoiceCreateInput>(GetAccountId(), new InvoiceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested invoice fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<InvoiceUpdatePayload> MutationAsync(InvoiceUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<InvoiceUpdatePayload, InvoiceUpdateInput>(GetAccountId(), new InvoiceUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested invoice fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<InvoiceUpdatePayload> MutationAsync(InvoiceUpdateInput data, InvoiceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<InvoiceUpdatePayload, InvoiceUpdateInput>(GetAccountId(), new InvoiceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested knowledge article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<KnowledgeArticleCreatePayload> MutationAsync(KnowledgeArticleCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<KnowledgeArticleCreatePayload, KnowledgeArticleCreateInput>(GetAccountId(), new KnowledgeArticleCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested knowledge article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<KnowledgeArticleCreatePayload> MutationAsync(KnowledgeArticleCreateInput data, KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<KnowledgeArticleCreatePayload, KnowledgeArticleCreateInput>(GetAccountId(), new KnowledgeArticleCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested knowledge article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<KnowledgeArticleMarkAsReviewedPayload> MutationAsync(KnowledgeArticleMarkAsReviewedInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<KnowledgeArticleMarkAsReviewedPayload, KnowledgeArticleMarkAsReviewedInput>(GetAccountId(), new KnowledgeArticleMarkAsReviewedMutation(data, null), ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested knowledge article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<KnowledgeArticleMarkAsReviewedPayload> MutationAsync(KnowledgeArticleMarkAsReviewedInput data, KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<KnowledgeArticleMarkAsReviewedPayload, KnowledgeArticleMarkAsReviewedInput>(GetAccountId(), new KnowledgeArticleMarkAsReviewedMutation(data, query), ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested knowledge article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<KnowledgeArticleUpdatePayload> MutationAsync(KnowledgeArticleUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<KnowledgeArticleUpdatePayload, KnowledgeArticleUpdateInput>(GetAccountId(), new KnowledgeArticleUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested knowledge article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<KnowledgeArticleUpdatePayload> MutationAsync(KnowledgeArticleUpdateInput data, KnowledgeArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<KnowledgeArticleUpdatePayload, KnowledgeArticleUpdateInput>(GetAccountId(), new KnowledgeArticleUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the note mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested note fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<NoteCreatePayload> MutationAsync(NoteCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<NoteCreatePayload, NoteCreateInput>(GetAccountId(), new NoteCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the note mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested note fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<NoteCreatePayload> MutationAsync(NoteCreateInput data, NoteQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<NoteCreatePayload, NoteCreateInput>(GetAccountId(), new NoteCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the note reaction mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested note reaction fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<NoteReactionCreatePayload> MutationAsync(NoteReactionCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<NoteReactionCreatePayload, NoteReactionCreateInput>(GetAccountId(), new NoteReactionCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the note reaction mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested note reaction fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<NoteReactionCreatePayload> MutationAsync(NoteReactionCreateInput data, NoteReactionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<NoteReactionCreatePayload, NoteReactionCreateInput>(GetAccountId(), new NoteReactionCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<NoteReactionDeleteMutationPayload> MutationAsync(NoteReactionDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<NoteReactionDeleteMutationPayload, NoteReactionDeleteMutationInput>(GetAccountId(), new NoteReactionDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested organization fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OrganizationCreatePayload> MutationAsync(OrganizationCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<OrganizationCreatePayload, OrganizationCreateInput>(GetAccountId(), new OrganizationCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested organization fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OrganizationCreatePayload> MutationAsync(OrganizationCreateInput data, OrganizationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<OrganizationCreatePayload, OrganizationCreateInput>(GetAccountId(), new OrganizationCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested organization fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OrganizationUpdatePayload> MutationAsync(OrganizationUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<OrganizationUpdatePayload, OrganizationUpdateInput>(GetAccountId(), new OrganizationUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested organization fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OrganizationUpdatePayload> MutationAsync(OrganizationUpdateInput data, OrganizationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<OrganizationUpdatePayload, OrganizationUpdateInput>(GetAccountId(), new OrganizationUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested out of office period fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OutOfOfficePeriodCreatePayload> MutationAsync(OutOfOfficePeriodCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<OutOfOfficePeriodCreatePayload, OutOfOfficePeriodCreateInput>(GetAccountId(), new OutOfOfficePeriodCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested out of office period fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OutOfOfficePeriodCreatePayload> MutationAsync(OutOfOfficePeriodCreateInput data, OutOfOfficePeriodQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<OutOfOfficePeriodCreatePayload, OutOfOfficePeriodCreateInput>(GetAccountId(), new OutOfOfficePeriodCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OutOfOfficePeriodDeleteMutationPayload> MutationAsync(OutOfOfficePeriodDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<OutOfOfficePeriodDeleteMutationPayload, OutOfOfficePeriodDeleteMutationInput>(GetAccountId(), new OutOfOfficePeriodDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested out of office period fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OutOfOfficePeriodUpdatePayload> MutationAsync(OutOfOfficePeriodUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<OutOfOfficePeriodUpdatePayload, OutOfOfficePeriodUpdateInput>(GetAccountId(), new OutOfOfficePeriodUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested out of office period fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<OutOfOfficePeriodUpdatePayload> MutationAsync(OutOfOfficePeriodUpdateInput data, OutOfOfficePeriodQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<OutOfOfficePeriodUpdatePayload, OutOfOfficePeriodUpdateInput>(GetAccountId(), new OutOfOfficePeriodUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested pdf design fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<PdfDesignCreatePayload> MutationAsync(PdfDesignCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<PdfDesignCreatePayload, PdfDesignCreateInput>(GetAccountId(), new PdfDesignCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested pdf design fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<PdfDesignCreatePayload> MutationAsync(PdfDesignCreateInput data, PdfDesignQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<PdfDesignCreatePayload, PdfDesignCreateInput>(GetAccountId(), new PdfDesignCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested pdf design fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<PdfDesignUpdatePayload> MutationAsync(PdfDesignUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<PdfDesignUpdatePayload, PdfDesignUpdateInput>(GetAccountId(), new PdfDesignUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested pdf design fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<PdfDesignUpdatePayload> MutationAsync(PdfDesignUpdateInput data, PdfDesignQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<PdfDesignUpdatePayload, PdfDesignUpdateInput>(GetAccountId(), new PdfDesignUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested person fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<PersonCreatePayload> MutationAsync(PersonCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<PersonCreatePayload, PersonCreateInput>(GetAccountId(), new PersonCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested person fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<PersonCreatePayload> MutationAsync(PersonCreateInput data, PersonQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<PersonCreatePayload, PersonCreateInput>(GetAccountId(), new PersonCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested person fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<PersonUpdatePayload> MutationAsync(PersonUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<PersonUpdatePayload, PersonUpdateInput>(GetAccountId(), new PersonUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested person fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<PersonUpdatePayload> MutationAsync(PersonUpdateInput data, PersonQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<PersonUpdatePayload, PersonUpdateInput>(GetAccountId(), new PersonUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested problem fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProblemCreatePayload> MutationAsync(ProblemCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProblemCreatePayload, ProblemCreateInput>(GetAccountId(), new ProblemCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested problem fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProblemCreatePayload> MutationAsync(ProblemCreateInput data, ProblemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProblemCreatePayload, ProblemCreateInput>(GetAccountId(), new ProblemCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested problem fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProblemUpdatePayload> MutationAsync(ProblemUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProblemUpdatePayload, ProblemUpdateInput>(GetAccountId(), new ProblemUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested problem fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProblemUpdatePayload> MutationAsync(ProblemUpdateInput data, ProblemQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProblemUpdatePayload, ProblemUpdateInput>(GetAccountId(), new ProblemUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product backlog fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductBacklogCreatePayload> MutationAsync(ProductBacklogCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProductBacklogCreatePayload, ProductBacklogCreateInput>(GetAccountId(), new ProductBacklogCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product backlog fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductBacklogCreatePayload> MutationAsync(ProductBacklogCreateInput data, ProductBacklogQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductBacklogCreatePayload, ProductBacklogCreateInput>(GetAccountId(), new ProductBacklogCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product backlog fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductBacklogUpdatePayload> MutationAsync(ProductBacklogUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProductBacklogUpdatePayload, ProductBacklogUpdateInput>(GetAccountId(), new ProductBacklogUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product backlog fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductBacklogUpdatePayload> MutationAsync(ProductBacklogUpdateInput data, ProductBacklogQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductBacklogUpdatePayload, ProductBacklogUpdateInput>(GetAccountId(), new ProductBacklogUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductCategoryCreatePayload> MutationAsync(ProductCategoryCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProductCategoryCreatePayload, ProductCategoryCreateInput>(GetAccountId(), new ProductCategoryCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductCategoryCreatePayload> MutationAsync(ProductCategoryCreateInput data, ProductCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductCategoryCreatePayload, ProductCategoryCreateInput>(GetAccountId(), new ProductCategoryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductCategoryUpdatePayload> MutationAsync(ProductCategoryUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProductCategoryUpdatePayload, ProductCategoryUpdateInput>(GetAccountId(), new ProductCategoryUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductCategoryUpdatePayload> MutationAsync(ProductCategoryUpdateInput data, ProductCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductCategoryUpdatePayload, ProductCategoryUpdateInput>(GetAccountId(), new ProductCategoryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductCreatePayload> MutationAsync(ProductCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProductCreatePayload, ProductCreateInput>(GetAccountId(), new ProductCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductCreatePayload> MutationAsync(ProductCreateInput data, ProductQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductCreatePayload, ProductCreateInput>(GetAccountId(), new ProductCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested product fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductUpdatePayload> MutationAsync(ProductUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProductUpdatePayload, ProductUpdateInput>(GetAccountId(), new ProductUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested product fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProductUpdatePayload> MutationAsync(ProductUpdateInput data, ProductQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProductUpdatePayload, ProductUpdateInput>(GetAccountId(), new ProductUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectCategoryCreatePayload> MutationAsync(ProjectCategoryCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectCategoryCreatePayload, ProjectCategoryCreateInput>(GetAccountId(), new ProjectCategoryCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectCategoryCreatePayload> MutationAsync(ProjectCategoryCreateInput data, ProjectCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectCategoryCreatePayload, ProjectCategoryCreateInput>(GetAccountId(), new ProjectCategoryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectCategoryUpdatePayload> MutationAsync(ProjectCategoryUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectCategoryUpdatePayload, ProjectCategoryUpdateInput>(GetAccountId(), new ProjectCategoryUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectCategoryUpdatePayload> MutationAsync(ProjectCategoryUpdateInput data, ProjectCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectCategoryUpdatePayload, ProjectCategoryUpdateInput>(GetAccountId(), new ProjectCategoryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectCreatePayload> MutationAsync(ProjectCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectCreatePayload, ProjectCreateInput>(GetAccountId(), new ProjectCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectCreatePayload> MutationAsync(ProjectCreateInput data, ProjectQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectCreatePayload, ProjectCreateInput>(GetAccountId(), new ProjectCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project risk level fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectRiskLevelCreatePayload> MutationAsync(ProjectRiskLevelCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectRiskLevelCreatePayload, ProjectRiskLevelCreateInput>(GetAccountId(), new ProjectRiskLevelCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project risk level fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectRiskLevelCreatePayload> MutationAsync(ProjectRiskLevelCreateInput data, ProjectRiskLevelQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectRiskLevelCreatePayload, ProjectRiskLevelCreateInput>(GetAccountId(), new ProjectRiskLevelCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project risk level fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectRiskLevelUpdatePayload> MutationAsync(ProjectRiskLevelUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectRiskLevelUpdatePayload, ProjectRiskLevelUpdateInput>(GetAccountId(), new ProjectRiskLevelUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project risk level fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectRiskLevelUpdatePayload> MutationAsync(ProjectRiskLevelUpdateInput data, ProjectRiskLevelQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectRiskLevelUpdatePayload, ProjectRiskLevelUpdateInput>(GetAccountId(), new ProjectRiskLevelUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project task fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTaskCreatePayload> MutationAsync(ProjectTaskCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectTaskCreatePayload, ProjectTaskCreateInput>(GetAccountId(), new ProjectTaskCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project task fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTaskCreatePayload> MutationAsync(ProjectTaskCreateInput data, ProjectTaskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTaskCreatePayload, ProjectTaskCreateInput>(GetAccountId(), new ProjectTaskCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project task template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTaskTemplateCreatePayload> MutationAsync(ProjectTaskTemplateCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectTaskTemplateCreatePayload, ProjectTaskTemplateCreateInput>(GetAccountId(), new ProjectTaskTemplateCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project task template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTaskTemplateCreatePayload> MutationAsync(ProjectTaskTemplateCreateInput data, ProjectTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTaskTemplateCreatePayload, ProjectTaskTemplateCreateInput>(GetAccountId(), new ProjectTaskTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project task template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTaskTemplateUpdatePayload> MutationAsync(ProjectTaskTemplateUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectTaskTemplateUpdatePayload, ProjectTaskTemplateUpdateInput>(GetAccountId(), new ProjectTaskTemplateUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project task template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTaskTemplateUpdatePayload> MutationAsync(ProjectTaskTemplateUpdateInput data, ProjectTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTaskTemplateUpdatePayload, ProjectTaskTemplateUpdateInput>(GetAccountId(), new ProjectTaskTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project task fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTaskUpdatePayload> MutationAsync(ProjectTaskUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectTaskUpdatePayload, ProjectTaskUpdateInput>(GetAccountId(), new ProjectTaskUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project task fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTaskUpdatePayload> MutationAsync(ProjectTaskUpdateInput data, ProjectTaskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTaskUpdatePayload, ProjectTaskUpdateInput>(GetAccountId(), new ProjectTaskUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTemplateCreatePayload> MutationAsync(ProjectTemplateCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectTemplateCreatePayload, ProjectTemplateCreateInput>(GetAccountId(), new ProjectTemplateCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTemplateCreatePayload> MutationAsync(ProjectTemplateCreateInput data, ProjectTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTemplateCreatePayload, ProjectTemplateCreateInput>(GetAccountId(), new ProjectTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTemplateUpdatePayload> MutationAsync(ProjectTemplateUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectTemplateUpdatePayload, ProjectTemplateUpdateInput>(GetAccountId(), new ProjectTemplateUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectTemplateUpdatePayload> MutationAsync(ProjectTemplateUpdateInput data, ProjectTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectTemplateUpdatePayload, ProjectTemplateUpdateInput>(GetAccountId(), new ProjectTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested project fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectUpdatePayload> MutationAsync(ProjectUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ProjectUpdatePayload, ProjectUpdateInput>(GetAccountId(), new ProjectUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested project fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ProjectUpdatePayload> MutationAsync(ProjectUpdateInput data, ProjectQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ProjectUpdatePayload, ProjectUpdateInput>(GetAccountId(), new ProjectUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested release fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReleaseCreatePayload> MutationAsync(ReleaseCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ReleaseCreatePayload, ReleaseCreateInput>(GetAccountId(), new ReleaseCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested release fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReleaseCreatePayload> MutationAsync(ReleaseCreateInput data, ReleaseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReleaseCreatePayload, ReleaseCreateInput>(GetAccountId(), new ReleaseCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested release fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReleaseUpdatePayload> MutationAsync(ReleaseUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ReleaseUpdatePayload, ReleaseUpdateInput>(GetAccountId(), new ReleaseUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested release fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReleaseUpdatePayload> MutationAsync(ReleaseUpdateInput data, ReleaseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReleaseUpdatePayload, ReleaseUpdateInput>(GetAccountId(), new ReleaseUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested request fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestCreatePayload> MutationAsync(RequestCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RequestCreatePayload, RequestCreateInput>(GetAccountId(), new RequestCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested request fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestCreatePayload> MutationAsync(RequestCreateInput data, RequestQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RequestCreatePayload, RequestCreateInput>(GetAccountId(), new RequestCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested request template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestTemplateCreatePayload> MutationAsync(RequestTemplateCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RequestTemplateCreatePayload, RequestTemplateCreateInput>(GetAccountId(), new RequestTemplateCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested request template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestTemplateCreatePayload> MutationAsync(RequestTemplateCreateInput data, RequestTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RequestTemplateCreatePayload, RequestTemplateCreateInput>(GetAccountId(), new RequestTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested request template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestTemplateUpdatePayload> MutationAsync(RequestTemplateUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RequestTemplateUpdatePayload, RequestTemplateUpdateInput>(GetAccountId(), new RequestTemplateUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested request template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestTemplateUpdatePayload> MutationAsync(RequestTemplateUpdateInput data, RequestTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RequestTemplateUpdatePayload, RequestTemplateUpdateInput>(GetAccountId(), new RequestTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested request fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestUpdatePayload> MutationAsync(RequestUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RequestUpdatePayload, RequestUpdateInput>(GetAccountId(), new RequestUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested request fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestUpdatePayload> MutationAsync(RequestUpdateInput data, RequestQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RequestUpdatePayload, RequestUpdateInput>(GetAccountId(), new RequestUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RequestUpdateVisibilityPayload> MutationAsync(RequestUpdateVisibilityInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RequestUpdateVisibilityPayload, RequestUpdateVisibilityInput>(GetAccountId(), new RequestUpdateVisibilityMutation(data), ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested reservation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReservationCreatePayload> MutationAsync(ReservationCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ReservationCreatePayload, ReservationCreateInput>(GetAccountId(), new ReservationCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested reservation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReservationCreatePayload> MutationAsync(ReservationCreateInput data, ReservationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReservationCreatePayload, ReservationCreateInput>(GetAccountId(), new ReservationCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested reservation offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReservationOfferingCreatePayload> MutationAsync(ReservationOfferingCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ReservationOfferingCreatePayload, ReservationOfferingCreateInput>(GetAccountId(), new ReservationOfferingCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested reservation offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReservationOfferingCreatePayload> MutationAsync(ReservationOfferingCreateInput data, ReservationOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReservationOfferingCreatePayload, ReservationOfferingCreateInput>(GetAccountId(), new ReservationOfferingCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested reservation offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReservationOfferingUpdatePayload> MutationAsync(ReservationOfferingUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ReservationOfferingUpdatePayload, ReservationOfferingUpdateInput>(GetAccountId(), new ReservationOfferingUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested reservation offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReservationOfferingUpdatePayload> MutationAsync(ReservationOfferingUpdateInput data, ReservationOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReservationOfferingUpdatePayload, ReservationOfferingUpdateInput>(GetAccountId(), new ReservationOfferingUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested reservation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReservationUpdatePayload> MutationAsync(ReservationUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ReservationUpdatePayload, ReservationUpdateInput>(GetAccountId(), new ReservationUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested reservation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ReservationUpdatePayload> MutationAsync(ReservationUpdateInput data, ReservationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ReservationUpdatePayload, ReservationUpdateInput>(GetAccountId(), new ReservationUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested risk fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RiskCreatePayload> MutationAsync(RiskCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RiskCreatePayload, RiskCreateInput>(GetAccountId(), new RiskCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested risk fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RiskCreatePayload> MutationAsync(RiskCreateInput data, RiskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RiskCreatePayload, RiskCreateInput>(GetAccountId(), new RiskCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested risk severity fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RiskSeverityCreatePayload> MutationAsync(RiskSeverityCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RiskSeverityCreatePayload, RiskSeverityCreateInput>(GetAccountId(), new RiskSeverityCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested risk severity fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RiskSeverityCreatePayload> MutationAsync(RiskSeverityCreateInput data, RiskSeverityQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RiskSeverityCreatePayload, RiskSeverityCreateInput>(GetAccountId(), new RiskSeverityCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested risk severity fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RiskSeverityUpdatePayload> MutationAsync(RiskSeverityUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RiskSeverityUpdatePayload, RiskSeverityUpdateInput>(GetAccountId(), new RiskSeverityUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested risk severity fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RiskSeverityUpdatePayload> MutationAsync(RiskSeverityUpdateInput data, RiskSeverityQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RiskSeverityUpdatePayload, RiskSeverityUpdateInput>(GetAccountId(), new RiskSeverityUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested risk fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RiskUpdatePayload> MutationAsync(RiskUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<RiskUpdatePayload, RiskUpdateInput>(GetAccountId(), new RiskUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested risk fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<RiskUpdatePayload> MutationAsync(RiskUpdateInput data, RiskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<RiskUpdatePayload, RiskUpdateInput>(GetAccountId(), new RiskUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested scrum workspace fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ScrumWorkspaceCreatePayload> MutationAsync(ScrumWorkspaceCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ScrumWorkspaceCreatePayload, ScrumWorkspaceCreateInput>(GetAccountId(), new ScrumWorkspaceCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested scrum workspace fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ScrumWorkspaceCreatePayload> MutationAsync(ScrumWorkspaceCreateInput data, ScrumWorkspaceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ScrumWorkspaceCreatePayload, ScrumWorkspaceCreateInput>(GetAccountId(), new ScrumWorkspaceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested scrum workspace fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ScrumWorkspaceUpdatePayload> MutationAsync(ScrumWorkspaceUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ScrumWorkspaceUpdatePayload, ScrumWorkspaceUpdateInput>(GetAccountId(), new ScrumWorkspaceUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested scrum workspace fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ScrumWorkspaceUpdatePayload> MutationAsync(ScrumWorkspaceUpdateInput data, ScrumWorkspaceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ScrumWorkspaceUpdatePayload, ScrumWorkspaceUpdateInput>(GetAccountId(), new ScrumWorkspaceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sera ai studio mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sera ai studio fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SeraAiStudioUpdatePayload> MutationAsync(SeraAiStudioUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SeraAiStudioUpdatePayload, SeraAiStudioUpdateInput>(GetAccountId(), new SeraAiStudioUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the sera ai studio mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sera ai studio fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SeraAiStudioUpdatePayload> MutationAsync(SeraAiStudioUpdateInput data, SeraAiStudioQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SeraAiStudioUpdatePayload, SeraAiStudioUpdateInput>(GetAccountId(), new SeraAiStudioUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceCategoryCreatePayload> MutationAsync(ServiceCategoryCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceCategoryCreatePayload, ServiceCategoryCreateInput>(GetAccountId(), new ServiceCategoryCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceCategoryCreatePayload> MutationAsync(ServiceCategoryCreateInput data, ServiceCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceCategoryCreatePayload, ServiceCategoryCreateInput>(GetAccountId(), new ServiceCategoryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceCategoryUpdatePayload> MutationAsync(ServiceCategoryUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceCategoryUpdatePayload, ServiceCategoryUpdateInput>(GetAccountId(), new ServiceCategoryUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceCategoryUpdatePayload> MutationAsync(ServiceCategoryUpdateInput data, ServiceCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceCategoryUpdatePayload, ServiceCategoryUpdateInput>(GetAccountId(), new ServiceCategoryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceCreatePayload> MutationAsync(ServiceCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceCreatePayload, ServiceCreateInput>(GetAccountId(), new ServiceCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceCreatePayload> MutationAsync(ServiceCreateInput data, ServiceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceCreatePayload, ServiceCreateInput>(GetAccountId(), new ServiceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service instance fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceInstanceCreatePayload> MutationAsync(ServiceInstanceCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceInstanceCreatePayload, ServiceInstanceCreateInput>(GetAccountId(), new ServiceInstanceCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service instance fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceInstanceCreatePayload> MutationAsync(ServiceInstanceCreateInput data, ServiceInstanceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceInstanceCreatePayload, ServiceInstanceCreateInput>(GetAccountId(), new ServiceInstanceCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service instance fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceInstanceUpdatePayload> MutationAsync(ServiceInstanceUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceInstanceUpdatePayload, ServiceInstanceUpdateInput>(GetAccountId(), new ServiceInstanceUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service instance fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceInstanceUpdatePayload> MutationAsync(ServiceInstanceUpdateInput data, ServiceInstanceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceInstanceUpdatePayload, ServiceInstanceUpdateInput>(GetAccountId(), new ServiceInstanceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service level agreement fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceLevelAgreementCreatePayload> MutationAsync(ServiceLevelAgreementCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceLevelAgreementCreatePayload, ServiceLevelAgreementCreateInput>(GetAccountId(), new ServiceLevelAgreementCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service level agreement fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceLevelAgreementCreatePayload> MutationAsync(ServiceLevelAgreementCreateInput data, ServiceLevelAgreementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceLevelAgreementCreatePayload, ServiceLevelAgreementCreateInput>(GetAccountId(), new ServiceLevelAgreementCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service level agreement fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceLevelAgreementUpdatePayload> MutationAsync(ServiceLevelAgreementUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceLevelAgreementUpdatePayload, ServiceLevelAgreementUpdateInput>(GetAccountId(), new ServiceLevelAgreementUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service level agreement fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceLevelAgreementUpdatePayload> MutationAsync(ServiceLevelAgreementUpdateInput data, ServiceLevelAgreementQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceLevelAgreementUpdatePayload, ServiceLevelAgreementUpdateInput>(GetAccountId(), new ServiceLevelAgreementUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceOfferingCreatePayload> MutationAsync(ServiceOfferingCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceOfferingCreatePayload, ServiceOfferingCreateInput>(GetAccountId(), new ServiceOfferingCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceOfferingCreatePayload> MutationAsync(ServiceOfferingCreateInput data, ServiceOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceOfferingCreatePayload, ServiceOfferingCreateInput>(GetAccountId(), new ServiceOfferingCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service offering fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceOfferingUpdatePayload> MutationAsync(ServiceOfferingUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceOfferingUpdatePayload, ServiceOfferingUpdateInput>(GetAccountId(), new ServiceOfferingUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service offering fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceOfferingUpdatePayload> MutationAsync(ServiceOfferingUpdateInput data, ServiceOfferingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceOfferingUpdatePayload, ServiceOfferingUpdateInput>(GetAccountId(), new ServiceOfferingUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested service fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceUpdatePayload> MutationAsync(ServiceUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ServiceUpdatePayload, ServiceUpdateInput>(GetAccountId(), new ServiceUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested service fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ServiceUpdatePayload> MutationAsync(ServiceUpdateInput data, ServiceQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ServiceUpdatePayload, ServiceUpdateInput>(GetAccountId(), new ServiceUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop article category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopArticleCategoryCreatePayload> MutationAsync(ShopArticleCategoryCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ShopArticleCategoryCreatePayload, ShopArticleCategoryCreateInput>(GetAccountId(), new ShopArticleCategoryCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop article category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopArticleCategoryCreatePayload> MutationAsync(ShopArticleCategoryCreateInput data, ShopArticleCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopArticleCategoryCreatePayload, ShopArticleCategoryCreateInput>(GetAccountId(), new ShopArticleCategoryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop article category fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopArticleCategoryUpdatePayload> MutationAsync(ShopArticleCategoryUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ShopArticleCategoryUpdatePayload, ShopArticleCategoryUpdateInput>(GetAccountId(), new ShopArticleCategoryUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop article category fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopArticleCategoryUpdatePayload> MutationAsync(ShopArticleCategoryUpdateInput data, ShopArticleCategoryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopArticleCategoryUpdatePayload, ShopArticleCategoryUpdateInput>(GetAccountId(), new ShopArticleCategoryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopArticleCreatePayload> MutationAsync(ShopArticleCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ShopArticleCreatePayload, ShopArticleCreateInput>(GetAccountId(), new ShopArticleCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopArticleCreatePayload> MutationAsync(ShopArticleCreateInput data, ShopArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopArticleCreatePayload, ShopArticleCreateInput>(GetAccountId(), new ShopArticleCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop article fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopArticleUpdatePayload> MutationAsync(ShopArticleUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ShopArticleUpdatePayload, ShopArticleUpdateInput>(GetAccountId(), new ShopArticleUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop article fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopArticleUpdatePayload> MutationAsync(ShopArticleUpdateInput data, ShopArticleQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopArticleUpdatePayload, ShopArticleUpdateInput>(GetAccountId(), new ShopArticleUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop order line fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopOrderLineCreatePayload> MutationAsync(ShopOrderLineCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ShopOrderLineCreatePayload, ShopOrderLineCreateInput>(GetAccountId(), new ShopOrderLineCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop order line fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopOrderLineCreatePayload> MutationAsync(ShopOrderLineCreateInput data, ShopOrderLineQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopOrderLineCreatePayload, ShopOrderLineCreateInput>(GetAccountId(), new ShopOrderLineCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested shop order line fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopOrderLineUpdatePayload> MutationAsync(ShopOrderLineUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ShopOrderLineUpdatePayload, ShopOrderLineUpdateInput>(GetAccountId(), new ShopOrderLineUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested shop order line fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShopOrderLineUpdatePayload> MutationAsync(ShopOrderLineUpdateInput data, ShopOrderLineQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShopOrderLineUpdatePayload, ShopOrderLineUpdateInput>(GetAccountId(), new ShopOrderLineUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested short url fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShortUrlCreatePayload> MutationAsync(ShortUrlCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ShortUrlCreatePayload, ShortUrlCreateInput>(GetAccountId(), new ShortUrlCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested short url fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShortUrlCreatePayload> MutationAsync(ShortUrlCreateInput data, ShortUrlQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShortUrlCreatePayload, ShortUrlCreateInput>(GetAccountId(), new ShortUrlCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested short url fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShortUrlUpdatePayload> MutationAsync(ShortUrlUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<ShortUrlUpdatePayload, ShortUrlUpdateInput>(GetAccountId(), new ShortUrlUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested short url fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<ShortUrlUpdatePayload> MutationAsync(ShortUrlUpdateInput data, ShortUrlQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<ShortUrlUpdatePayload, ShortUrlUpdateInput>(GetAccountId(), new ShortUrlUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested site fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SiteCreatePayload> MutationAsync(SiteCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SiteCreatePayload, SiteCreateInput>(GetAccountId(), new SiteCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested site fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SiteCreatePayload> MutationAsync(SiteCreateInput data, SiteQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SiteCreatePayload, SiteCreateInput>(GetAccountId(), new SiteCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested site fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SiteUpdatePayload> MutationAsync(SiteUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SiteUpdatePayload, SiteUpdateInput>(GetAccountId(), new SiteUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested site fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SiteUpdatePayload> MutationAsync(SiteUpdateInput data, SiteQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SiteUpdatePayload, SiteUpdateInput>(GetAccountId(), new SiteUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested skill pool fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SkillPoolCreatePayload> MutationAsync(SkillPoolCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SkillPoolCreatePayload, SkillPoolCreateInput>(GetAccountId(), new SkillPoolCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested skill pool fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SkillPoolCreatePayload> MutationAsync(SkillPoolCreateInput data, SkillPoolQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SkillPoolCreatePayload, SkillPoolCreateInput>(GetAccountId(), new SkillPoolCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested skill pool fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SkillPoolUpdatePayload> MutationAsync(SkillPoolUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SkillPoolUpdatePayload, SkillPoolUpdateInput>(GetAccountId(), new SkillPoolUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested skill pool fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SkillPoolUpdatePayload> MutationAsync(SkillPoolUpdateInput data, SkillPoolQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SkillPoolUpdatePayload, SkillPoolUpdateInput>(GetAccountId(), new SkillPoolUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sla coverage group fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SlaCoverageGroupCreatePayload> MutationAsync(SlaCoverageGroupCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SlaCoverageGroupCreatePayload, SlaCoverageGroupCreateInput>(GetAccountId(), new SlaCoverageGroupCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sla coverage group fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SlaCoverageGroupCreatePayload> MutationAsync(SlaCoverageGroupCreateInput data, SlaCoverageGroupQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SlaCoverageGroupCreatePayload, SlaCoverageGroupCreateInput>(GetAccountId(), new SlaCoverageGroupCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sla coverage group fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SlaCoverageGroupUpdatePayload> MutationAsync(SlaCoverageGroupUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SlaCoverageGroupUpdatePayload, SlaCoverageGroupUpdateInput>(GetAccountId(), new SlaCoverageGroupUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sla coverage group fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SlaCoverageGroupUpdatePayload> MutationAsync(SlaCoverageGroupUpdateInput data, SlaCoverageGroupQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SlaCoverageGroupUpdatePayload, SlaCoverageGroupUpdateInput>(GetAccountId(), new SlaCoverageGroupUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sla notification scheme fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SlaNotificationSchemeCreatePayload> MutationAsync(SlaNotificationSchemeCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SlaNotificationSchemeCreatePayload, SlaNotificationSchemeCreateInput>(GetAccountId(), new SlaNotificationSchemeCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sla notification scheme fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SlaNotificationSchemeCreatePayload> MutationAsync(SlaNotificationSchemeCreateInput data, SlaNotificationSchemeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SlaNotificationSchemeCreatePayload, SlaNotificationSchemeCreateInput>(GetAccountId(), new SlaNotificationSchemeCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sla notification scheme fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SlaNotificationSchemeUpdatePayload> MutationAsync(SlaNotificationSchemeUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SlaNotificationSchemeUpdatePayload, SlaNotificationSchemeUpdateInput>(GetAccountId(), new SlaNotificationSchemeUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sla notification scheme fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SlaNotificationSchemeUpdatePayload> MutationAsync(SlaNotificationSchemeUpdateInput data, SlaNotificationSchemeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SlaNotificationSchemeUpdatePayload, SlaNotificationSchemeUpdateInput>(GetAccountId(), new SlaNotificationSchemeUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sprint fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SprintCreatePayload> MutationAsync(SprintCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SprintCreatePayload, SprintCreateInput>(GetAccountId(), new SprintCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sprint fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SprintCreatePayload> MutationAsync(SprintCreateInput data, SprintQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SprintCreatePayload, SprintCreateInput>(GetAccountId(), new SprintCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested sprint fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SprintUpdatePayload> MutationAsync(SprintUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SprintUpdatePayload, SprintUpdateInput>(GetAccountId(), new SprintUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested sprint fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SprintUpdatePayload> MutationAsync(SprintUpdateInput data, SprintQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SprintUpdatePayload, SprintUpdateInput>(GetAccountId(), new SprintUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested survey fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SurveyCreatePayload> MutationAsync(SurveyCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SurveyCreatePayload, SurveyCreateInput>(GetAccountId(), new SurveyCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested survey fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SurveyCreatePayload> MutationAsync(SurveyCreateInput data, SurveyQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SurveyCreatePayload, SurveyCreateInput>(GetAccountId(), new SurveyCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested survey response fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SurveyResponseCreatePayload> MutationAsync(SurveyResponseCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SurveyResponseCreatePayload, SurveyResponseCreateInput>(GetAccountId(), new SurveyResponseCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested survey response fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SurveyResponseCreatePayload> MutationAsync(SurveyResponseCreateInput data, SurveyResponseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SurveyResponseCreatePayload, SurveyResponseCreateInput>(GetAccountId(), new SurveyResponseCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested survey response fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SurveyResponseUpdatePayload> MutationAsync(SurveyResponseUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SurveyResponseUpdatePayload, SurveyResponseUpdateInput>(GetAccountId(), new SurveyResponseUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested survey response fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SurveyResponseUpdatePayload> MutationAsync(SurveyResponseUpdateInput data, SurveyResponseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SurveyResponseUpdatePayload, SurveyResponseUpdateInput>(GetAccountId(), new SurveyResponseUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested survey fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SurveyUpdatePayload> MutationAsync(SurveyUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<SurveyUpdatePayload, SurveyUpdateInput>(GetAccountId(), new SurveyUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested survey fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<SurveyUpdatePayload> MutationAsync(SurveyUpdateInput data, SurveyQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<SurveyUpdatePayload, SurveyUpdateInput>(GetAccountId(), new SurveyUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested team fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TeamCreatePayload> MutationAsync(TeamCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TeamCreatePayload, TeamCreateInput>(GetAccountId(), new TeamCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested team fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TeamCreatePayload> MutationAsync(TeamCreateInput data, TeamQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TeamCreatePayload, TeamCreateInput>(GetAccountId(), new TeamCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested team fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TeamUpdatePayload> MutationAsync(TeamUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TeamUpdatePayload, TeamUpdateInput>(GetAccountId(), new TeamUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested team fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TeamUpdatePayload> MutationAsync(TeamUpdateInput data, TeamQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TeamUpdatePayload, TeamUpdateInput>(GetAccountId(), new TeamUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested time allocation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimeAllocationCreatePayload> MutationAsync(TimeAllocationCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TimeAllocationCreatePayload, TimeAllocationCreateInput>(GetAccountId(), new TimeAllocationCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested time allocation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimeAllocationCreatePayload> MutationAsync(TimeAllocationCreateInput data, TimeAllocationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimeAllocationCreatePayload, TimeAllocationCreateInput>(GetAccountId(), new TimeAllocationCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested time allocation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimeAllocationUpdatePayload> MutationAsync(TimeAllocationUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TimeAllocationUpdatePayload, TimeAllocationUpdateInput>(GetAccountId(), new TimeAllocationUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested time allocation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimeAllocationUpdatePayload> MutationAsync(TimeAllocationUpdateInput data, TimeAllocationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimeAllocationUpdatePayload, TimeAllocationUpdateInput>(GetAccountId(), new TimeAllocationUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested time entry fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimeEntryCreatePayload> MutationAsync(TimeEntryCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TimeEntryCreatePayload, TimeEntryCreateInput>(GetAccountId(), new TimeEntryCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested time entry fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimeEntryCreatePayload> MutationAsync(TimeEntryCreateInput data, TimeEntryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimeEntryCreatePayload, TimeEntryCreateInput>(GetAccountId(), new TimeEntryCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested time entry fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimeEntryUpdatePayload> MutationAsync(TimeEntryUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TimeEntryUpdatePayload, TimeEntryUpdateInput>(GetAccountId(), new TimeEntryUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested time entry fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimeEntryUpdatePayload> MutationAsync(TimeEntryUpdateInput data, TimeEntryQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimeEntryUpdatePayload, TimeEntryUpdateInput>(GetAccountId(), new TimeEntryUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested timesheet setting fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimesheetSettingCreatePayload> MutationAsync(TimesheetSettingCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TimesheetSettingCreatePayload, TimesheetSettingCreateInput>(GetAccountId(), new TimesheetSettingCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested timesheet setting fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimesheetSettingCreatePayload> MutationAsync(TimesheetSettingCreateInput data, TimesheetSettingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimesheetSettingCreatePayload, TimesheetSettingCreateInput>(GetAccountId(), new TimesheetSettingCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested timesheet setting fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimesheetSettingUpdatePayload> MutationAsync(TimesheetSettingUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TimesheetSettingUpdatePayload, TimesheetSettingUpdateInput>(GetAccountId(), new TimesheetSettingUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested timesheet setting fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TimesheetSettingUpdatePayload> MutationAsync(TimesheetSettingUpdateInput data, TimesheetSettingQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TimesheetSettingUpdatePayload, TimesheetSettingUpdateInput>(GetAccountId(), new TimesheetSettingUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested translation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TranslationCreatePayload> MutationAsync(TranslationCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TranslationCreatePayload, TranslationCreateInput>(GetAccountId(), new TranslationCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested translation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TranslationCreatePayload> MutationAsync(TranslationCreateInput data, TranslationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TranslationCreatePayload, TranslationCreateInput>(GetAccountId(), new TranslationCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested translation fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TranslationUpdatePayload> MutationAsync(TranslationUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<TranslationUpdatePayload, TranslationUpdateInput>(GetAccountId(), new TranslationUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested translation fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<TranslationUpdatePayload> MutationAsync(TranslationUpdateInput data, TranslationQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<TranslationUpdatePayload, TranslationUpdateInput>(GetAccountId(), new TranslationUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested ui extension fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<UiExtensionCreatePayload> MutationAsync(UiExtensionCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<UiExtensionCreatePayload, UiExtensionCreateInput>(GetAccountId(), new UiExtensionCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested ui extension fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<UiExtensionCreatePayload> MutationAsync(UiExtensionCreateInput data, UiExtensionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<UiExtensionCreatePayload, UiExtensionCreateInput>(GetAccountId(), new UiExtensionCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested ui extension fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<UiExtensionUpdatePayload> MutationAsync(UiExtensionUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<UiExtensionUpdatePayload, UiExtensionUpdateInput>(GetAccountId(), new UiExtensionUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested ui extension fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<UiExtensionUpdatePayload> MutationAsync(UiExtensionUpdateInput data, UiExtensionQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<UiExtensionUpdatePayload, UiExtensionUpdateInput>(GetAccountId(), new UiExtensionUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested waiting for customer follow up fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WaitingForCustomerFollowUpCreatePayload> MutationAsync(WaitingForCustomerFollowUpCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WaitingForCustomerFollowUpCreatePayload, WaitingForCustomerFollowUpCreateInput>(GetAccountId(), new WaitingForCustomerFollowUpCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested waiting for customer follow up fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WaitingForCustomerFollowUpCreatePayload> MutationAsync(WaitingForCustomerFollowUpCreateInput data, WaitingForCustomerFollowUpQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WaitingForCustomerFollowUpCreatePayload, WaitingForCustomerFollowUpCreateInput>(GetAccountId(), new WaitingForCustomerFollowUpCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested waiting for customer follow up fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WaitingForCustomerFollowUpUpdatePayload> MutationAsync(WaitingForCustomerFollowUpUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WaitingForCustomerFollowUpUpdatePayload, WaitingForCustomerFollowUpUpdateInput>(GetAccountId(), new WaitingForCustomerFollowUpUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested waiting for customer follow up fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WaitingForCustomerFollowUpUpdatePayload> MutationAsync(WaitingForCustomerFollowUpUpdateInput data, WaitingForCustomerFollowUpQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WaitingForCustomerFollowUpUpdatePayload, WaitingForCustomerFollowUpUpdateInput>(GetAccountId(), new WaitingForCustomerFollowUpUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested webhook fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookCreatePayload> MutationAsync(WebhookCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WebhookCreatePayload, WebhookCreateInput>(GetAccountId(), new WebhookCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested webhook fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookCreatePayload> MutationAsync(WebhookCreateInput data, WebhookQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WebhookCreatePayload, WebhookCreateInput>(GetAccountId(), new WebhookCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookDeleteMutationPayload> MutationAsync(WebhookDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WebhookDeleteMutationPayload, WebhookDeleteMutationInput>(GetAccountId(), new WebhookDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested webhook policy fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookPolicyCreatePayload> MutationAsync(WebhookPolicyCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WebhookPolicyCreatePayload, WebhookPolicyCreateInput>(GetAccountId(), new WebhookPolicyCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested webhook policy fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookPolicyCreatePayload> MutationAsync(WebhookPolicyCreateInput data, WebhookPolicyCreateResponseQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WebhookPolicyCreatePayload, WebhookPolicyCreateInput>(GetAccountId(), new WebhookPolicyCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload where only the client mutation ID is populated when provided as input.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookPolicyDeleteMutationPayload> MutationAsync(WebhookPolicyDeleteMutationInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WebhookPolicyDeleteMutationPayload, WebhookPolicyDeleteMutationInput>(GetAccountId(), new WebhookPolicyDeleteMutation(data), ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested webhook policy fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookPolicyUpdatePayload> MutationAsync(WebhookPolicyUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WebhookPolicyUpdatePayload, WebhookPolicyUpdateInput>(GetAccountId(), new WebhookPolicyUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested webhook policy fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookPolicyUpdatePayload> MutationAsync(WebhookPolicyUpdateInput data, WebhookPolicyQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WebhookPolicyUpdatePayload, WebhookPolicyUpdateInput>(GetAccountId(), new WebhookPolicyUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested webhook fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookUpdatePayload> MutationAsync(WebhookUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WebhookUpdatePayload, WebhookUpdateInput>(GetAccountId(), new WebhookUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested webhook fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WebhookUpdatePayload> MutationAsync(WebhookUpdateInput data, WebhookQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WebhookUpdatePayload, WebhookUpdateInput>(GetAccountId(), new WebhookUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowCreatePayload> MutationAsync(WorkflowCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowCreatePayload, WorkflowCreateInput>(GetAccountId(), new WorkflowCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowCreatePayload> MutationAsync(WorkflowCreateInput data, WorkflowQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowCreatePayload, WorkflowCreateInput>(GetAccountId(), new WorkflowCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested task fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTaskCreatePayload> MutationAsync(WorkflowTaskCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowTaskCreatePayload, WorkflowTaskCreateInput>(GetAccountId(), new WorkflowTaskCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested task fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTaskCreatePayload> MutationAsync(WorkflowTaskCreateInput data, WorkflowTaskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTaskCreatePayload, WorkflowTaskCreateInput>(GetAccountId(), new WorkflowTaskCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested task template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTaskTemplateCreatePayload> MutationAsync(WorkflowTaskTemplateCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowTaskTemplateCreatePayload, WorkflowTaskTemplateCreateInput>(GetAccountId(), new WorkflowTaskTemplateCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested task template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTaskTemplateCreatePayload> MutationAsync(WorkflowTaskTemplateCreateInput data, WorkflowTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTaskTemplateCreatePayload, WorkflowTaskTemplateCreateInput>(GetAccountId(), new WorkflowTaskTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested task template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTaskTemplateUpdatePayload> MutationAsync(WorkflowTaskTemplateUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowTaskTemplateUpdatePayload, WorkflowTaskTemplateUpdateInput>(GetAccountId(), new WorkflowTaskTemplateUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested task template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTaskTemplateUpdatePayload> MutationAsync(WorkflowTaskTemplateUpdateInput data, WorkflowTaskTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTaskTemplateUpdatePayload, WorkflowTaskTemplateUpdateInput>(GetAccountId(), new WorkflowTaskTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested task fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTaskUpdatePayload> MutationAsync(WorkflowTaskUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowTaskUpdatePayload, WorkflowTaskUpdateInput>(GetAccountId(), new WorkflowTaskUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested task fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTaskUpdatePayload> MutationAsync(WorkflowTaskUpdateInput data, WorkflowTaskQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTaskUpdatePayload, WorkflowTaskUpdateInput>(GetAccountId(), new WorkflowTaskUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTemplateCreatePayload> MutationAsync(WorkflowTemplateCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowTemplateCreatePayload, WorkflowTemplateCreateInput>(GetAccountId(), new WorkflowTemplateCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTemplateCreatePayload> MutationAsync(WorkflowTemplateCreateInput data, WorkflowTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTemplateCreatePayload, WorkflowTemplateCreateInput>(GetAccountId(), new WorkflowTemplateCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow template fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTemplateUpdatePayload> MutationAsync(WorkflowTemplateUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowTemplateUpdatePayload, WorkflowTemplateUpdateInput>(GetAccountId(), new WorkflowTemplateUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow template fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTemplateUpdatePayload> MutationAsync(WorkflowTemplateUpdateInput data, WorkflowTemplateQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTemplateUpdatePayload, WorkflowTemplateUpdateInput>(GetAccountId(), new WorkflowTemplateUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow type fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTypeCreatePayload> MutationAsync(WorkflowTypeCreateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowTypeCreatePayload, WorkflowTypeCreateInput>(GetAccountId(), new WorkflowTypeCreateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow type fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTypeCreatePayload> MutationAsync(WorkflowTypeCreateInput data, WorkflowTypeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTypeCreatePayload, WorkflowTypeCreateInput>(GetAccountId(), new WorkflowTypeCreateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow type fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTypeUpdatePayload> MutationAsync(WorkflowTypeUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowTypeUpdatePayload, WorkflowTypeUpdateInput>(GetAccountId(), new WorkflowTypeUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow type fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowTypeUpdatePayload> MutationAsync(WorkflowTypeUpdateInput data, WorkflowTypeQuery query, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return MutationAsync<WorkflowTypeUpdatePayload, WorkflowTypeUpdateInput>(GetAccountId(), new WorkflowTypeUpdateMutation(data, query), ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result contains a payload with the requested workflow fields and, when provided as input, the client mutation ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Task<WorkflowUpdatePayload> MutationAsync(WorkflowUpdateInput data, CancellationToken ct = default)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            return MutationAsync<WorkflowUpdatePayload, WorkflowUpdateInput>(GetAccountId(), new WorkflowUpdateMutation(data, null), ct);
        }

        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A task that represents the asynchronous mutation operation. The task result includes the client mutation ID and the requested workflow fields.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="data"/> or <paramref name="query"/> is null.</exception>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
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
