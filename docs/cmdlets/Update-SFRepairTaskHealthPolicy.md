# Update-SFRepairTaskHealthPolicy
Updates the health policy of the given repair task.
## Description

This API supports the Service Fabric platform; it is not meant to be used directly from your code.



## Optional Parameters
#### -Version

The current version number of the repair task. If non-zero, then the request will only succeed if this value matches 
the actual current value of the repair task. If zero, then no version check is performed.



#### -PerformPreparingHealthCheck

A boolean indicating if health check is to be performed in the Preparing stage of the repair task. If not specified 
the existing value should not be altered. Otherwise, specify the desired new value.



#### -PerformRestoringHealthCheck

A boolean indicating if health check is to be performed in the Restoring stage of the repair task. If not specified 
the existing value should not be altered. Otherwise, specify the desired new value.



