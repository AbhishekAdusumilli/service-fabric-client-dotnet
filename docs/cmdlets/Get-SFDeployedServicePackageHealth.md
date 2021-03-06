# Get-SFDeployedServicePackageHealth
Gets the information about health of a service package for a specific application deployed for a Service Fabric node and application.
## Description

Gets the information about health of a service package for a specific application deployed on a Service Fabric node. 
Use EventsHealthStateFilter to optionally filter for the collection of HealthEvent objects reported on the deployed 
service package based on health state.



## Required Parameters
#### -NodeName

The name of the node.



#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -ServicePackageName

The name of the service package.



## Optional Parameters
#### -EventsHealthStateFilter

Allows filtering the collection of HealthEvent objects returned based on health state.
                    The possible values for this parameter include integer value of one of the following health states.
                    Only events that match the filter are returned. All events are used to evaluate the aggregated 
health state.
                    If not specified, all entries are returned. The state values are flag-based enumeration, so the 
value could be a combination of these values, obtained using the bitwise 'OR' operator. For example, If the provided 
value is 6 then all of the events with HealthState value of OK (2) and Warning (4) are returned.
                    
                    - Default - Default value. Matches any HealthState. The value is zero.
                    - None - Filter that doesn't match any HealthState value. Used in order to return no results on a 
given collection of states. The value is 1.
                    - Ok - Filter that matches input with HealthState value Ok. The value is 2.
                    - Warning - Filter that matches input with HealthState value Warning. The value is 4.
                    - Error - Filter that matches input with HealthState value Error. The value is 8.
                    - All - Filter that matches input with any HealthState value. The value is 65535.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



