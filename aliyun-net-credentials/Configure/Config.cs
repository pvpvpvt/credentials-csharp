namespace Aliyun.Credentials.Configure
{
    public static class Constants
    {
        public const string DefaultProfileName = "default";
        public const string StsDefaultEndpoint = "{{sts_default_endpoint}}";
        public const string DomainSuffix = "{{endpoint_suffix}}";
        public const string UserAgentPrefix = "{{user_agent_prefix}}";
        public const string DefaultRegion = "cn-hangzhou";
        public const string ConfigStorePath = "{{config_path}}";
        public const string EnvPrefix = "{{env_prefix}}";

        public const string ECSIMDSSecurityCredURL =
            "http://{{metadata_host}}/latest/meta-data/ram/security-credentials/";

        public const string ECSIMDSSecurityCredTokenURL = "http://{{metadata_host}}/latest/api/token";
        public const string ECSIMDSHeaderPrefix = "{{imds_header_prefix}}";
        public const string PATHCredentialFile = "{{credential_file_path}}";
        public const string SignPrefix = "{{sign_prefix}}";
        public const string SignatureTypePrefix = "{{signature_type_prefix}}";
    }
}