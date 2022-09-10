// See https://aka.ms/new-console-template for more information
using Fusyona.Dotnet.Sdk.Apis.User;

string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2FjY291bnRzLmZ1c3lvbmEuY29tL2Y5MTQxNjJkLWMwYzMtNDkwYi05M2Q1LTFkOGNmZTFhNDc5OS92Mi4wLyIsImV4cCI6MTY2MjgzOTk5MCwibmJmIjoxNjYyODM2MzkwLCJhdWQiOiI4N2FiZWQ5NC0yNWY0LTRmMmMtOWNmMi1kMjk4ODMyODlkM2EiLCJvaWQiOiI1YzZiM2I0Ni01MmMyLTRhMmUtYjg5Ni1hNGI0YTZiOGNmZWMiLCJzdWIiOiI1YzZiM2I0Ni01MmMyLTRhMmUtYjg5Ni1hNGI0YTZiOGNmZWMiLCJnaXZlbl9uYW1lIjoiQWRyaWFuIiwiZmFtaWx5X25hbWUiOiJDLiBMZW9uIiwiZW1haWxzIjpbImluZm9AZnVzeW9uYS5jb20iXSwidGZwIjoiQjJDXzFfU2lnblVwSW4iLCJub25jZSI6IjFiZWM3OWY1LWRlMGMtNDgxOS1hMjMxLTE4M2ZiODFkYzdiNiIsInNjcCI6IldyaXRlVXNlclByb2ZpbGVBUEkgUmVhZFVzZXJQcm9maWxlQVBJIiwiYXpwIjoiZWI5MzY3MDctNTkzZS00OWQzLTgwMjgtMTA3NjBkNWI5YjI5IiwidmVyIjoiMS4wIiwiaWF0IjoxNjYyODM2MzkwfQ.kX9iYV4u55W1-9bAak8k9AT853siqFswOwDN_-0j9zfVVdmJAnoh8G9pT-JNZDFFF4hEd4V6Eaj2DzkM1YxwlclLNOqMXNibdeUykuma8q98TLuRPl6auZHfwZHZO8ViqqPMWovVMC8PHaF9kXsKmt96RiWNZScg9C3HKYXsq8EyKydV2IzvFUG56hbZwR80OjxBEA_jtoifBj-8hnxzrB3u3o6X98gR8DQrevUZB-KZ_0fDBvdUEq-H-6WuCyNJKuNpegUgoVbozBYgqGHMhF0yLsGGeN9r9vk60k0qmTLhUwRhJbM3OB5_g2__wP1RHaL1DPUIhjcqtJTfLavYjw";
// string subcriptionKey = "8237b947-18b0-470e-8358-4f79737feb55";
string subcriptionKey = "710e277524cc426baf6c8ef1eb930af5;product=starter";
string address_id = "5c6b3b46-52c2-4a2e-b896-a4b4a6b8cfec";

var response = User.GetUserProfile(bearerToken, subcriptionKey, address_id);

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