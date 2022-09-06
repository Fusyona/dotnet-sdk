// See https://aka.ms/new-console-template for more information
using Fusyona.Dotnet.Sdk.Apis;
using Fusyona.Dotnet.Sdk.Models;

string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2FjY291bnRzLmZ1c3lvbmEuY29tL2Y5MTQxNjJkLWMwYzMtNDkwYi05M2Q1LTFkOGNmZTFhNDc5OS92Mi4wLyIsImV4cCI6MTY2MjQ5Mzg0OCwibmJmIjoxNjYyNDkwMjQ4LCJhdWQiOiI4N2FiZWQ5NC0yNWY0LTRmMmMtOWNmMi1kMjk4ODMyODlkM2EiLCJvaWQiOiIxNThkOTE3Mi1kMWM1LTQwN2ItODU4ZS1lM2Q1MzhmNjFjZjciLCJzdWIiOiIxNThkOTE3Mi1kMWM1LTQwN2ItODU4ZS1lM2Q1MzhmNjFjZjciLCJnaXZlbl9uYW1lIjoiUm9sYW5kbyIsImZhbWlseV9uYW1lIjoiU2FuY2hleiBSYW1vcyIsImVtYWlscyI6WyJyb2xzYW5jaGV6QHlhbmRleC5jb20iXSwidGZwIjoiQjJDXzFfU2lnblVwSW4iLCJub25jZSI6IjMzYjgxNTFjLTEzODEtNDczMi04MGE1LTZiYzdjNGViZWY2MSIsInNjcCI6IldyaXRlVXNlclByb2ZpbGVBUEkgUmVhZFVzZXJQcm9maWxlQVBJIiwiYXpwIjoiZWI5MzY3MDctNTkzZS00OWQzLTgwMjgtMTA3NjBkNWI5YjI5IiwidmVyIjoiMS4wIiwiaWF0IjoxNjYyNDkwMjQ4fQ.RN2S3hwsJuLCqDp8pH_0DQgxBxUWb27brI4YNml0Cyx--Pt_8ynLJUZrHQ47V7vSEHLkjzr2jb8a3nosQGq2d4iSykyl0FuVTAc40hT_xHs2RWjFBVKu3i2sJ0kxNsHH87kF4HFd5VHj017oX0GvTNTVh7gy_cH2SYESci6_I1k5C8ma0DhdL-ksa8-M4fAmrXVMiedPSCewe3tVijR3ybLrodrvsJ_6FoVtPhuNzj92KBa0sqpAwVvEyYPsYZAIUfPhii4l3V-aeexma2lc-338UA1-0jVBr3oi_OdNgXKaTvGImQOO8sSzYXEUWX_OzEJzaTP59BQa0ne4aWQMYw";
string collectionId = "8237b947-18b0-470e-8358-4f79737feb55";
string nftId = "d5224c66-dfad-4840-8404-6459a0cfdb77";
NftApi api = new NftApi();

string blockchainNetwork = "Polygon";
string name = "CollectDotnet";
string description = "Dotnet";
decimal royalties = 5;
string externalLink = "www.fusyona.com";
string path = "/home/roly/Pictures/Screenshots/a.png";    

string result = await api.CreateCollection(bearerToken, blockchainNetwork: blockchainNetwork, name: name, description: description, royalties: royalties, externalLink: externalLink, coverImagePath: path, featuredImagePath: path, logoImagePath: path);
Console.WriteLine(result);