# Enable-SFApplicationBackup
Enables periodic backup of stateful partitions under this Service Fabric application.
## Description

Enables periodic backup of stateful partitions which are part of this Service Fabric application. Each partition is 
backed up individually as per the specified backup policy description. 
                Note only C# based Reliable Actor and Reliable Stateful services are currently supported for periodic 
backup.



## Required Parameters
#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -BackupPolicyName

Name of the backup policy to be used for enabling periodic backups.



