# CyberSource.Model.Ptsv2payoutsProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessApplicationId** | **string** | Payouts transaction type.  Applicable Processors: FDC Compass, Paymentech, CtV  Possible values:  **Credit Card Bill Payment**   - **CP**: credit card bill payment  **Funds Disbursement**   - **FD**: funds disbursement  - **GD**: government disbursement  - **MD**: merchant disbursement  **Money Transfer**   - **AA**: account to account. Sender and receiver are same person.  - **PP**: person to person. Sender and receiver are different.  **Prepaid Load**   - **TU**: top up  | [optional] 
**NetworkRoutingOrder** | **string** | This field is optionally used by Push Payments Gateway participants (merchants and acquirers) to get the attributes for specified networks only. The networks specified in this field must be a subset of the information provided during program enrollment. Refer to Sharing Group Code/Network Routing Order. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service.  VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the network routing order. If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer&#39;s preference.  If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists, VisaNet makes a selection based on the acquirer&#39;s routing priorities.   | [optional] 
**CommerceIndicator** | **string** | Type of transaction.  Value for an OCT transaction: - &#x60;internet&#x60;  | [optional] 
**ReconciliationId** | **string** | Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22).  | [optional] 
**PayoutsOptions** | [**Ptsv2payoutsProcessingInformationPayoutsOptions**](Ptsv2payoutsProcessingInformationPayoutsOptions.md) |  | [optional] 
**TransactionReason** | **string** | Transaction reason code.  | [optional] 
**PurposeOfPayment** | **string** | This field is applicable for AFT and OCT transactions. For list of supported values, please refer to Developer Guide.  | [optional] 
**FundingOptions** | [**Ptsv2payoutsProcessingInformationFundingOptions**](Ptsv2payoutsProcessingInformationFundingOptions.md) |  | [optional] 
**LanguageCode** | **string** | Contains the ISO 639-2 defined language Code  | [optional] 
**PurchaseOptions** | [**Ptsv2payoutsProcessingInformationPurchaseOptions**](Ptsv2payoutsProcessingInformationPurchaseOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

