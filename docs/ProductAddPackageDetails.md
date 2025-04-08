# Org.OpenAPITools.Model.ProductAddPackageDetails
If the seller is subscribed to \"Business Policies\", use the seller_profiles instead of the shipping_details, payment_methods and return_accepted params.<hr><div style=\"font-style:normal\">Param structure:<div style=\"margin-left: 2%;\"><code style=\"padding:0; background-color:#ffffff;font-size:85%;font-family:monospace;\">package_details[<b>measure_unit</b>] = string</br> Allowed measure_unit values: [English or Metric] </br> Default: Metric</br>package_details[<b>weigh_unit</b>] = string</br> Allowed weigh_unit values: [kg, g, lbs, oz]</br>package_details[<b>package_depth</b>] = decimal</br>package_details[<b>package_length</b>] = decimal</br>package_details[<b>package_width</b>] = decimal</br>package_details[<b>weight_major</b>] = decimal</br>package_details[<b>weight_minor</b>] = decimal</br>package_details[<b>shipping_package</b>] = string</br> See cart.info method, param `eBay_shipping_package_details`</code></div></div>

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MeasureUnit** | **string** |  | [optional] 
**WeighUnit** | **string** |  | [optional] 
**PackageDepth** | **decimal** |  | [optional] 
**PackageLength** | **decimal** |  | [optional] 
**PackageWidth** | **decimal** |  | [optional] 
**WeightMajor** | **decimal** |  | [optional] 
**WeightMinor** | **decimal** |  | [optional] 
**ShippingPackage** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

