// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Used for getting PHP error logging flag. </summary>
    public partial class SitePhpErrorLogFlag : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SitePhpErrorLogFlag. </summary>
        public SitePhpErrorLogFlag()
        {
        }

        /// <summary> Initializes a new instance of SitePhpErrorLogFlag. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="localLogErrors"> Local log_errors setting. </param>
        /// <param name="masterLogErrors"> Master log_errors setting. </param>
        /// <param name="localLogErrorsMaxLength"> Local log_errors_max_len setting. </param>
        /// <param name="masterLogErrorsMaxLength"> Master log_errors_max_len setting. </param>
        internal SitePhpErrorLogFlag(ResourceIdentifier id, string name, ResourceType type, string kind, string localLogErrors, string masterLogErrors, string localLogErrorsMaxLength, string masterLogErrorsMaxLength) : base(id, name, type, kind)
        {
            LocalLogErrors = localLogErrors;
            MasterLogErrors = masterLogErrors;
            LocalLogErrorsMaxLength = localLogErrorsMaxLength;
            MasterLogErrorsMaxLength = masterLogErrorsMaxLength;
        }

        /// <summary> Local log_errors setting. </summary>
        public string LocalLogErrors { get; set; }
        /// <summary> Master log_errors setting. </summary>
        public string MasterLogErrors { get; set; }
        /// <summary> Local log_errors_max_len setting. </summary>
        public string LocalLogErrorsMaxLength { get; set; }
        /// <summary> Master log_errors_max_len setting. </summary>
        public string MasterLogErrorsMaxLength { get; set; }
    }
}
