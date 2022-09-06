// See https://aka.ms/new-console-template for more information
using Fusyona.Dotnet.Sdk.Apis;
using Fusyona.Dotnet.Sdk.Models;

string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2FjY291bnRzLmZ1c3lvbmEuY29tL2Y5MTQxNjJkLWMwYzMtNDkwYi05M2Q1LTFkOGNmZTFhNDc5OS92Mi4wLyIsImV4cCI6MTY2MjUwNDUxMCwibmJmIjoxNjYyNTAwOTEwLCJhdWQiOiI4N2FiZWQ5NC0yNWY0LTRmMmMtOWNmMi1kMjk4ODMyODlkM2EiLCJvaWQiOiIxNThkOTE3Mi1kMWM1LTQwN2ItODU4ZS1lM2Q1MzhmNjFjZjciLCJzdWIiOiIxNThkOTE3Mi1kMWM1LTQwN2ItODU4ZS1lM2Q1MzhmNjFjZjciLCJnaXZlbl9uYW1lIjoiUm9sYW5kbyIsImZhbWlseV9uYW1lIjoiU2FuY2hleiBSYW1vcyIsImVtYWlscyI6WyJyb2xzYW5jaGV6QHlhbmRleC5jb20iXSwidGZwIjoiQjJDXzFfU2lnblVwSW4iLCJub25jZSI6IjMzYjgxNTFjLTEzODEtNDczMi04MGE1LTZiYzdjNGViZWY2MSIsInNjcCI6IldyaXRlVXNlclByb2ZpbGVBUEkgUmVhZFVzZXJQcm9maWxlQVBJIiwiYXpwIjoiZWI5MzY3MDctNTkzZS00OWQzLTgwMjgtMTA3NjBkNWI5YjI5IiwidmVyIjoiMS4wIiwiaWF0IjoxNjYyNTAwOTEwfQ.IM6cYtzyCIkluEM6ciC4n90-2Wdb8hM-CPVV8aQc0P7ykYGeiqTy7U9sOdNfe97LyGxoVkXvKepf6tSiMFYNPcxAYPlGgVY0dj0INKnQ0BAVmoUDNQUF8XWK_TBpQGUQ4eyiPeyn3jW-ydVs73h1OlXzttTL4gLw3aOnzn_Uluz7STT85NX4YIx285_Vq0tKWatrIKENqLL4u-lhiETADLlL_GDmJOcYQfv1iGjkTpU14ZDNrXvqJnANOw8GXSH12VY6GNIGo3flakHYC9H61mHqVNdhwC2Q2KiRO2233OiHMCPamz2T0BSd6zpA7cP4gLF4cs8Qvq3Pf2s6jTzyhw";
string collectionId = "8237b947-18b0-470e-8358-4f79737feb55";
string nftId = "d5224c66-dfad-4840-8404-6459a0cfdb77";
NftApi api = new NftApi();

//Testing collection creation
string blockchainNetwork = "Polygon";
string name = "CollectDotnet";
string description = "Dotnet";
decimal royalties = 5;
string externalLink = "www.fusyona.com";
string path = "/home/roly/Pictures/Screenshots/a.png";    

string result = await api.CreateCollection(bearerToken, blockchainNetwork: blockchainNetwork, name: name, description: description, royalties: royalties, externalLink: externalLink, coverImagePath: path, featuredImagePath: path, logoImagePath: path);
Console.WriteLine(result);

//Testing nft creation
string title = "TokenSport";
description = "DescriptTokenSport";
string category = "sports";
int supply = 5;
string tags = "tags";
path = "/home/roly/Pictures/Screenshots/a.png";    
string attributes = "attributes";
string privacy = "privacy";
externalLink = "www.fusyona.net";
string codes = "codes";

result = await api.MintNft(bearerToken, collectionId, title: title, description: description, category: category, supply: supply, tags: tags, attachmentPath: path, attributes: attributes, privacy: privacy, externalLink: externalLink, codes: codes);
Console.WriteLine(result);