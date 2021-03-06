# Get-SFApplication
Gets the list of applications created in the Service Fabric cluster that match the specified filters.
## Description

Gets the information about the applications that were created or in the process of being created in the Service Fabric 
cluster and match the specified filters. The response includes the name, type, status, parameters, and other details 
about the application. If the applications do not fit in a page, one page of results is returned as well as a 
continuation token, which can be used to get the next page. Filters ApplicationTypeName and 
ApplicationDefinitionKindFilter cannot be specified at the same time.



## Optional Parameters
#### -ApplicationDefinitionKindFilter

Used to filter on ApplicationDefinitionKind, which is the mechanism used to define a Service Fabric application.
                    - Default - Default value, which performs the same function as selecting "All". The value is 0.
                    - All - Filter that matches input with any ApplicationDefinitionKind value. The value is 65535.
                    - ServiceFabricApplicationDescription - Filter that matches input with ApplicationDefinitionKind 
value ServiceFabricApplicationDescription. The value is 1.
                    - Compose - Filter that matches input with ApplicationDefinitionKind value Compose. The value is 2.



#### -ApplicationTypeName

The application type name used to filter the applications to query for. This value should not contain the application 
type version.



#### -ExcludeApplicationParameters

The flag that specifies whether application parameters will be excluded from the result.



#### -MaxResults

The maximum number of results to be returned as part of the paged queries. This parameter defines the upper bound on 
the number of results returned. The results returned can be less than the specified maximum results if they do not fit 
in the message as per the max message size restrictions defined in the configuration. If this parameter is zero or not 
specified, the paged query includes as many results as possible that fit in the return message.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



