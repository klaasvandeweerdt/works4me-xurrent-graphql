using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    internal sealed class S3UploadParameters
    {
        [XurrentField("acl")]
        public string Acl { get; set; } = default!;

        [XurrentField("key")]
        public string Key { get; set; } = default!;

        [XurrentField("policy")]
        public string Policy { get; set; } = default!;

        [XurrentField("success_action_status")]
        public int SuccessActionStatus { get; set; }

        [XurrentField("x-amz-algorithm")]
        public string XAmzAlgorithm { get; set; } = default!;

        [XurrentField("x-amz-credential")]
        public string XAmzCredential { get; set; } = default!;

        [XurrentField("x-amz-date")]
        public string XAmzDate { get; set; } = default!;

        [XurrentField("x-amz-server-side-encryption")]
        public string XAmzServerSideEncryption { get; set; } = default!;

        [XurrentField("x-amz-signature")]
        public string XAmzSignature { get; set; } = default!;
    }
}
