# Get-SFDeployedServiceType
Gets the list containing the information about service types from the applications deployed on a node in a Service Fabric cluster.
## Description

Gets the list containing the information about service types from the applications deployed on a node in a Service 
Fabric cluster. The response includes the name of the service type, its registration status, the code package that 
registered it and activation ID of the service package.



## Required Parameters
#### -NodeName

The name of the node.



#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -ServiceTypeName

Specifies the name of a Service Fabric service type.



## Optional Parameters
#### -ServiceManifestName

The name of the service manifest to filter the list of deployed service type information. If specified, the response 
will only contain the information about service types that are defined in this service manifest.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



