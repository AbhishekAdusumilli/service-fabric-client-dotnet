# Copy-SFImageStoreContent
Copies image store content internally
## Description

Copies the image store content from the source image store relative path to the destination image store relative path.



## Required Parameters
#### -RemoteSource

The relative path of source image store content to be copied from.



#### -RemoteDestination

The relative path of destination image store content to be copied to.



## Optional Parameters
#### -SkipFiles

The list of the file names to be skipped for copying.



#### -CheckMarkFile

Indicates whether to check mark file during copying. The property is true if checking mark file is required, false 
otherwise. The mark file is used to check whether the folder is well constructed. If the property is true and mark 
file does not exist, the copy is skipped.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



