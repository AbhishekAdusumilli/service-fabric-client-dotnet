// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Powershell.Http
{
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;
    using Microsoft.ServiceFabric.Common;

    /// <summary>
    /// Disables periodic backup of Service Fabric service which was previously enabled.
    /// </summary>
    [Cmdlet(VerbsLifecycle.Disable, "SFServiceBackup")]
    public partial class DisableServiceBackupCmdlet : CommonCmdletBase
    {
        /// <summary>
        /// Gets or sets ServiceId. The identity of the service. This ID is typically the full name of the service without the
        /// 'fabric:' URI scheme.
        /// Starting from version 6.0, hierarchical names are delimited with the "~" character.
        /// For example, if the service name is "fabric:/myapp/app1/svc1", the service identity would be "myapp~app1~svc1" in
        /// 6.0+ and "myapp/app1/svc1" in previous versions.
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, Position = 0)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Gets or sets CleanBackup. Boolean flag to delete backups. It can be set to true for deleting all the backups which
        /// were created for the backup entity that is getting disabled for backup.
        /// </summary>
        [Parameter(Mandatory = true, Position = 1)]
        public bool? CleanBackup { get; set; }

        /// <summary>
        /// Gets or sets ServerTimeout. The server timeout for performing the operation in seconds. This timeout specifies the
        /// time duration that the client is willing to wait for the requested operation to complete. The default value for
        /// this parameter is 60 seconds.
        /// </summary>
        [Parameter(Mandatory = false, Position = 2)]
        public long? ServerTimeout { get; set; }

        /// <summary>
        /// Gets or sets the force flag. If provided, then the destructive action will be performed without asking for
        /// confirmation prompt.
        /// </summary>
        [Parameter(Mandatory = false, Position = 3)]
        public SwitchParameter Force { get; set; }

        /// <inheritdoc/>
        protected override void ProcessRecordInternal()
        {
            var disableBackupDescription = new DisableBackupDescription(
            cleanBackup: this.CleanBackup);

            if (((this.Force != null) && this.Force) || this.ShouldContinue(string.Empty, string.Empty))
            {
                this.ServiceFabricClient.BackupRestore.DisableServiceBackupAsync(
                    serviceId: this.ServiceId,
                    disableBackupDescription: disableBackupDescription,
                    serverTimeout: this.ServerTimeout,
                    cancellationToken: this.CancellationToken).GetAwaiter().GetResult();

                Console.WriteLine("Success!");
            }
        }
    }
}
