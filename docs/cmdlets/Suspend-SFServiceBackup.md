# Suspend-SFServiceBackup
Suspends periodic backup for the specified Service Fabric service.
## Description

The service which is configured to take periodic backups, is suspended for taking further backups till it is resumed 
again. This operation applies to the entire service's hierarchy. It means all the partitions under this service are 
now suspended for backup.



