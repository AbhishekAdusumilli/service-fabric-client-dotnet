# Get-SFDeployedApplication
Gets the list of applications deployed on a Service Fabric node.
## Description

Gets the list of applications deployed on a Service Fabric node. The results do not include information about deployed 
system applications unless explicitly queried for by ID. Results encompass deployed applications in active, 
activating, and downloading states. This query requires that the node name corresponds to a node on the cluster. The 
query fails if the provided node name does not point to any active Service Fabric nodes on the cluster.



## Required Parameters
#### -NodeName

The name of the node.



#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



## Optional Parameters
#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



#### -IncludeHealthState

Include the health state of an entity.
                    If this parameter is false or not specified, then the health state returned is "Unknown".
                    When set to true, the query goes in parallel to the node and the health system service before the 
results are merged.
                    As a result, the query is more expensive and may take a longer time.



#### -MaxResults

The maximum number of results to be returned as part of the paged queries. This parameter defines the upper bound on 
the number of results returned. The results returned can be less than the specified maximum results if they do not fit 
in the message as per the max message size restrictions defined in the configuration. If this parameter is zero or not 
specified, the paged query includes as many results as possible that fit in the return message.



