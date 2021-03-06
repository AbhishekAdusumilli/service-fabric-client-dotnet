# New-SFRepairTask
Creates a new repair task.
## Description

For clusters that have the Repair Manager Service configured,
                this API provides a way to create repair tasks that run automatically or manually.
                For repair tasks that run automatically, an appropriate repair executor
                must be running for each repair action to run automatically.
                These are currently only available in specially-configured Azure Cloud Services.
                
                To create a manual repair task, provide the set of impacted node names and the
                expected impact. When the state of the created repair task changes to approved,
                you can safely perform repair actions on those nodes.
                
                This API supports the Service Fabric platform; it is not meant to be used directly from your code.



## Required Parameters
#### -TaskId

The ID of the repair task.



#### -State

The workflow state of the repair task. Valid initial states are Created, Claimed, and Preparing. Possible values 
include: 'Invalid', 'Created', 'Claimed', 'Preparing', 'Approved', 'Executing', 'Restoring', 'Completed'



#### -Action

The requested repair action. Must be specified when the repair task is created, and is immutable once set.



## Optional Parameters
#### -Version

The version of the repair task.
                    When creating a new repair task, the version must be set to zero.  When updating a repair task,
                    the version is used for optimistic concurrency checks.  If the version is
                    set to zero, the update will not check for write conflicts.  If the version is set to a non-zero 
value, then the
                    update will only succeed if the actual current version of the repair task matches this value.



#### -Description

A description of the purpose of the repair task, or other informational details.
                    May be set when the repair task is created, and is immutable once set.



#### -Flags

A bitwise-OR of the following values, which gives additional details about the status of the repair task.
                    - 1 - Cancellation of the repair has been requested
                    - 2 - Abort of the repair has been requested
                    - 4 - Approval of the repair was forced via client request



#### -NodeNames

The list of nodes targeted by a repair action.



#### -Executor

The name of the repair executor. Must be specified in Claimed and later states, and is immutable once set.



#### -ExecutorData

A data string that the repair executor can use to store its internal state.



#### -NodeImpactList

The list of nodes impacted by a repair action and their respective expected impact.



#### -ResultStatus

A value describing the overall result of the repair task execution. Must be specified in the Restoring and later 
states, and is immutable once set. Possible values include: 'Invalid', 'Succeeded', 'Cancelled', 'Interrupted', 
'Failed', 'Pending'



#### -ResultCode

A numeric value providing additional details about the result of the repair task execution.
                    May be specified in the Restoring and later states, and is immutable once set.



#### -ResultDetails

A string providing additional details about the result of the repair task execution.
                    May be specified in the Restoring and later states, and is immutable once set.



#### -CreatedUtcTimestamp

The time when the repair task entered the Created state.



#### -ClaimedUtcTimestamp

The time when the repair task entered the Claimed state.



#### -PreparingUtcTimestamp

The time when the repair task entered the Preparing state.



#### -ApprovedUtcTimestamp

The time when the repair task entered the Approved state



#### -ExecutingUtcTimestamp

The time when the repair task entered the Executing state



#### -RestoringUtcTimestamp

The time when the repair task entered the Restoring state



#### -CompletedUtcTimestamp

The time when the repair task entered the Completed state



#### -PreparingHealthCheckStartUtcTimestamp

The time when the repair task started the health check in the Preparing state.



#### -PreparingHealthCheckEndUtcTimestamp

The time when the repair task completed the health check in the Preparing state.



#### -RestoringHealthCheckStartUtcTimestamp

The time when the repair task started the health check in the Restoring state.



#### -RestoringHealthCheckEndUtcTimestamp

The time when the repair task completed the health check in the Restoring state.



#### -PreparingHealthCheckState

The workflow state of the health check when the repair task is in the Preparing state. Possible values include: 
'NotStarted', 'InProgress', 'Succeeded', 'Skipped', 'TimedOut'
                    
                    Specifies the workflow state of a repair task's health check. This type supports the Service 
Fabric platform; it is not meant to be used directly from your code.



#### -RestoringHealthCheckState

The workflow state of the health check when the repair task is in the Restoring state. Possible values include: 
'NotStarted', 'InProgress', 'Succeeded', 'Skipped', 'TimedOut'
                    
                    Specifies the workflow state of a repair task's health check. This type supports the Service 
Fabric platform; it is not meant to be used directly from your code.



#### -PerformPreparingHealthCheck

A value to determine if health checks will be performed when the repair task enters the Preparing state.



#### -PerformRestoringHealthCheck

A value to determine if health checks will be performed when the repair task enters the Restoring state.



