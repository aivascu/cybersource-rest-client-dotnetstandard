# CyberSource.Model.Ptsv1pushfundstransferSenderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of sender.  Funds Disbursement  This value is the name of the originator sending the funds disbursement.  Government entities should use this field  | [optional] 
**Email** | **string** | Customer&#39;s email address, including the full domain name.  | [optional] 
**FirstName** | **string** | This field contains the first name of the entity funding the transaction Mandatory for card payments  | [optional] 
**LastName** | **string** | This field contains the last name of the entity funding the transaction Mandatory for card payments  | [optional] 
**MiddleName** | **string** | This field contains the  middle name of the entity funding the transaction  | [optional] 
**PostalCode** | **string** | Sender&#39;s postal code.  For USA, this must be a valid value of 5 digits or 5 digits hyphen 4 digits, for example &#39;63368&#39;, &#39;63368-5555&#39;. For other regions, this can be alphanumeric, length 1-10.  Required for FDCCompass.  | [optional] 
**BuildingNumber** | **string** | Building number in the street address.  For example, if the street address is: Rua da Quitanda 187 then the building number is 187.  Applicable to domestic Colombia transactions only.  | [optional] 
**StreetName** | **string** | This field contains the street name of the recipient&#39;s address.  Applicable to domestic Colombia transactions only.  | [optional] 
**Address1** | **string** | Street address of sender.  Funds Disbursement  This value is the address of the originator sending the funds disbursement.  Required for card transactions  | [optional] 
**Address2** | **string** | Used for additional address information. For example: Attention: Accounts Payable  Optional field.  | [optional] 
**Locality** | **string** | The sender&#39;s city Mandatory for card payments  | [optional] 
**AdministrativeArea** | **string** | Sender&#39;s state. Use the State, Province, and Territory Codes for the United States and Canada.The sender&#39;s province, state or territory. Conditional, required if sender&#39;s country is USA or CAN. Must be uppercase alpha 2 or 3 character country subdivision code.  See https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf  Mandatory for card payments  | [optional] 
**Country** | **string** | Sender&#39;s country code. Use ISO Standard Alpha Country Codes.  https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf  | [optional] 
**DateOfBirth** | **string** | Sender&#39;s date of birth in YYYYMMDD format.  | [optional] 
**PhoneNumber** | **string** | Customer&#39;s phone number.  It is recommended that you include the country code when the order is from outside the U.S.  | [optional] 
**PaymentInformation** | [**Ptsv1pushfundstransferSenderInformationPaymentInformation**](Ptsv1pushfundstransferSenderInformationPaymentInformation.md) |  | [optional] 
**ReferenceNumber** | **string** | Reference number generated by you that uniquely identifies the sender.  | [optional] 
**Account** | [**Ptsv1pushfundstransferSenderInformationAccount**](Ptsv1pushfundstransferSenderInformationAccount.md) |  | [optional] 
**PersonalIdentification** | [**Ptsv1pushfundstransferSenderInformationPersonalIdentification**](Ptsv1pushfundstransferSenderInformationPersonalIdentification.md) |  | [optional] 
**Type** | **string** | &#x60;B&#x60; for Business or &#x60;I&#x60; for individual.  | [optional] 
**VatRegistrationNumber** | **string** | Customer&#39;s government-assigned tax identification number.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

