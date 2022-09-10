// See https://aka.ms/new-console-template for more information
using Fusyona.Dotnet.Sdk.Apis.Wallet;

string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE2NjI4MzY5NDUsIm5iZiI6MTY2MjgzMzM0NSwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9hY2NvdW50cy5mdXN5b25hLmNvbS9mOTE0MTYyZC1jMGMzLTQ5MGItOTNkNS0xZDhjZmUxYTQ3OTkvdjIuMC8iLCJzdWIiOiJmYWVmMjIzZi0zZjM4LTRkYTAtYTc3Zi1iODZjOTA2MjUyZTAiLCJhdWQiOiI4N2FiZWQ5NC0yNWY0LTRmMmMtOWNmMi1kMjk4ODMyODlkM2EiLCJub25jZSI6ImNmZjcwYmEzLWY0NmUtNDU3NS1lOWExLTQ5ODg3OGVjYzkyZCIsImlhdCI6MTY2MjgzMzM0NSwiYXV0aF90aW1lIjoxNjYyODMzMzQ1LCJvaWQiOiJmYWVmMjIzZi0zZjM4LTRkYTAtYTc3Zi1iODZjOTA2MjUyZTAiLCJnaXZlbl9uYW1lIjoiTGVhbmRybyIsImZhbWlseV9uYW1lIjoibGxscmRneiIsImVtYWlscyI6WyJsZWFuZHJvX19yb2RyaWd1ZXpAb3V0bG9vay5jb20iXSwidGZwIjoiQjJDXzFfU2lnblVwSW4ifQ.jTUuGvTykJ0y_muTj01UPkPc_ZW62T1X6LoIjDQmUelh7VrFKRae8b1_RlDpUOLP5MAJTfIzhAa8iQA_spNVdbVsDyuUupMopr1gFNAEaCFD7g7budX25pRrzxM-VjeIMQbo3240Gj0bicROM5tsg5dbunHdC_ert3Q-ohFJdz4yXTY-K9TqZyPHhC4EK2vP8vvftbWTSV2NJBuNmeLM-1PAJ66aEX8X5jyAC7MQttB_WPrh3J7ZkD_ZP6cn_aZX37t3rB15wdXOHp_uwYILpcstmxD3PwC7V6TIdABpOa-2cVrMRWYV5cbmGngmteIfsrBH8md30kQRcUq87nRBew";
// string subcriptionKey = "8237b947-18b0-470e-8358-4f79737feb55";
string subcriptionKey = "710e277524cc426baf6c8ef1eb930af5;product=starter";
string address_id = "4fc3baf2-8284-4979-b0f0-7d01cbef1dee";

var response = Wallet.GetCryptocurrenciesAsync(bearerToken, subcriptionKey);

System.Console.WriteLine(response.Result);

// //Testing collection creation
// string blockchainNetwork = "Polygon";
// string name = "CollectDotnet";
// string description = "Dotnet";
// decimal royalties = 5;
// string externalLink = "www.fusyona.com";
// string path = "/home/roly/Pictures/Screenshots/a.png";    

// string result = await api.CreateCollection(bearerToken, blockchainNetwork: blockchainNetwork, name: name, description: description, royalties: royalties, externalLink: externalLink, coverImagePath: path, featuredImagePath: path, logoImagePath: path);
// Console.WriteLine(result);

// //Testing nft creation
// string title = "TokenSport";
// description = "DescriptTokenSport";
// string category = "sports";
// int supply = 5;
// string tags = "tags";
// path = "/home/roly/Pictures/Screenshots/a.png";    
// string attributes = "attributes";
// string privacy = "privacy";
// externalLink = "www.fusyona.net";
// string codes = "codes";

// result = await api.MintNft(bearerToken, collectionId, title: title, description: description, category: category, supply: supply, tags: tags, attachmentPath: path, attributes: attributes, privacy: privacy, externalLink: externalLink, codes: codes);
// Console.WriteLine(result);