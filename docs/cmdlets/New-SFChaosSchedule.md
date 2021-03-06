# New-SFChaosSchedule
Set the schedule used by Chaos.
## Description

Chaos will automatically schedule runs based on the Chaos Schedule.
                The Chaos Schedule will be updated if the provided version matches the version on the server.
                When updating the Chaos Schedule, the version on the server is incremented by 1.
                The version on the server will wrap back to 0 after reaching a large number.
                If Chaos is running when this call is made, the call will fail.



## Optional Parameters
#### -Version

The version number of the Schedule.



#### -StartDate

The date and time Chaos will start using this schedule.



#### -ExpiryDate

The date and time Chaos will continue to use this schedule until.



#### -ChaosParametersDictionary

A mapping of string names to Chaos Parameters to be referenced by Chaos Schedule Jobs.



#### -Jobs

A list of all Chaos Schedule Jobs that will be automated by the schedule.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



