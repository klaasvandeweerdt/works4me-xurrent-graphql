using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The ui extension category values.
    /// </summary>
    public enum UiExtensionCategory
    {
        /// <summary>
        /// App offering.
        /// </summary>
        [XurrentEnum("app_offering")]
        AppOffering,

        /// <summary>
        /// Contract.
        /// </summary>
        [XurrentEnum("contract")]
        Contract,

        /// <summary>
        /// Custom collection.
        /// </summary>
        [XurrentEnum("custom_collection")]
        CustomCollection,

        /// <summary>
        /// Knowledge article template.
        /// </summary>
        [XurrentEnum("knowledge_article_template")]
        KnowledgeArticleTemplate,

        /// <summary>
        /// Organization.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// Person.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// Problem.
        /// </summary>
        [XurrentEnum("problem")]
        Problem,

        /// <summary>
        /// Product.
        /// </summary>
        [XurrentEnum("product")]
        Product,

        /// <summary>
        /// Product category.
        /// </summary>
        [XurrentEnum("product_category")]
        ProductCategory,

        /// <summary>
        /// Project.
        /// </summary>
        [XurrentEnum("project")]
        Project,

        /// <summary>
        /// Project task template.
        /// </summary>
        [XurrentEnum("project_task_template")]
        ProjectTaskTemplate,

        /// <summary>
        /// Release.
        /// </summary>
        [XurrentEnum("release")]
        Release,

        /// <summary>
        /// Request template.
        /// </summary>
        [XurrentEnum("request_template")]
        RequestTemplate,

        /// <summary>
        /// Risk.
        /// </summary>
        [XurrentEnum("risk")]
        Risk,

        /// <summary>
        /// Scim user.
        /// </summary>
        [XurrentEnum("scim_user")]
        ScimUser,

        /// <summary>
        /// Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Service instance.
        /// </summary>
        [XurrentEnum("service_instance")]
        ServiceInstance,

        /// <summary>
        /// Shop article.
        /// </summary>
        [XurrentEnum("shop_article")]
        ShopArticle,

        /// <summary>
        /// Site.
        /// </summary>
        [XurrentEnum("site")]
        Site,

        /// <summary>
        /// Task template.
        /// </summary>
        [XurrentEnum("task_template")]
        TaskTemplate,

        /// <summary>
        /// Team.
        /// </summary>
        [XurrentEnum("team")]
        Team,

        /// <summary>
        /// Workflow template.
        /// </summary>
        [XurrentEnum("workflow_template")]
        WorkflowTemplate
    }
}
