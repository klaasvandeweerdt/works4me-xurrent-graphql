using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AgileBoard"/> query class.
    /// </summary>
    public class AgileBoardQuery : Query<AgileBoard, AgileBoardQuery, AgileBoardView, AgileBoardField, AgileBoardFilterField, AgileBoardOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AgileBoardQuery"/> instance.
        /// </summary>
        public AgileBoardQuery() : base("agileBoards", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="AgileBoardQuery"/>, updated to include the "Account" sub-query.</returns>
        public AgileBoardQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Columns of this agile board.
        /// </summary>
        /// <param name="query">The columns query.</param>
        /// <returns>The same <see cref="AgileBoardQuery"/>, updated to include the "Columns" sub-query.</returns>
        public AgileBoardQuery SelectColumns(AgileBoardColumnQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("columns", query, true);
        }

        /// <summary>
        /// Scrum sprint the agile board is currently linked to.
        /// </summary>
        /// <param name="query">The current sprint query.</param>
        /// <returns>The same <see cref="AgileBoardQuery"/>, updated to include the "CurrentSprint" sub-query.</returns>
        public AgileBoardQuery SelectCurrentSprint(SprintQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("currentSprint", query, false);
        }

        /// <summary>
        /// Customer representatives of these service level agreements can view this board in Self Service.
        /// </summary>
        /// <param name="query">The customer representative slas query.</param>
        /// <returns>The same <see cref="AgileBoardQuery"/>, updated to include the "CustomerRepresentativeSlas" sub-query.</returns>
        public AgileBoardQuery SelectCustomerRepresentativeSlas(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customerRepresentativeSlas", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="AgileBoardQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public AgileBoardQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Manager of the agile board.
        /// </summary>
        /// <param name="query">The manager query.</param>
        /// <returns>The same <see cref="AgileBoardQuery"/>, updated to include the "Manager" sub-query.</returns>
        public AgileBoardQuery SelectManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("manager", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="AgileBoardQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="AgileBoardQuery">AgileBoardQuery</see>, updated to include the "Search" sub-query.</returns>
        public AgileBoardQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
