# CyberSource.Model.InlineResponse4005
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services.  | [optional] 
**Status** | **string** | The status of the submitted transaction.  Possible values:  - INVALID_REQUEST  | [optional] 
**Reason** | **string** | The reason of the status.  Possible values:  - MISSING_FIELD  - INVALID_DATA  - DUPLICATE_REQUEST  - INVALID_MERCHANT_CONFIGURATION  - PROCESSOR_UNAVAILABLE  - INVALID_FOLLOW_ON_TRANSACTION_STATUS  | [optional] 
**Message** | **string** | The detail message related to the status and reason listed above. | [optional] 
**Details** | [**List&lt;PtsV2PaymentsPost201ResponseErrorInformationDetails&gt;**](PtsV2PaymentsPost201ResponseErrorInformationDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

