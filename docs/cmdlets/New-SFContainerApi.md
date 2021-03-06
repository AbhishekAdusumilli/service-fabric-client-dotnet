# New-SFContainerApi
Invoke container API on a container deployed on a Service Fabric node.
## Description

Invoke container API on a container deployed on a Service Fabric node for the given code package.



## Required Parameters
#### -NodeName

The name of the node.



#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -ServiceManifestName

The name of a service manifest registered as part of an application type in a Service Fabric cluster.



#### -CodePackageName

The name of code package specified in service manifest registered as part of an application type in a Service Fabric 
cluster.



#### -CodePackageInstanceId

ID that uniquely identifies a code package instance deployed on a service fabric node.



#### -UriPath

URI path of container REST API



## Optional Parameters
#### -HttpVerb

HTTP verb of container REST API, defaults to "GET"



#### -ContentType

Content type of container REST API request, defaults to "application/json"



#### -Body

HTTP request body of container REST API



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



