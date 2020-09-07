# C# LINE-Blockchain-SDK_Example
Example of LINE.Blockchain.SDK 

Alpha version for LINE Blockchain Developer. I implement the API with LINE Blockchain Developer doc (https://docs-blockchain.line.biz/api-guide/)

# How to use?  For example:
## ListAllServiceTokens example
```csharp
using LINEBlockchainSDK.API.V1;

public string service_api_key = "xxx";
public string service_api_secret = "ooo";

APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
var result = api.ListAllServiceTokens();
```

## RetrieveServiceInformation example
```csharp
using LINEBlockchainSDK.API.V1;

public string service_api_key = "xxx";
public string service_api_secret = "ooo";
public string serviceId = "ooo";

APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
var result = api.RetrieveServiceInformation(serviceId);
```

# Now support functions for APIManager :
## Category: Services
```csharp
RetrieveServiceInformation
```
## Category: Service-tokens
```csharp
ListAllServiceTokens
RetrieveServiceTokenInformation
```


