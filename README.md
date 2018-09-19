# Code challenge

Sample API in .NET Core 2.1 using **Visual Studio 2017 V15.8.4**

# dotnet --info

```
.NET Core SDK (reflecting any global.json):
 Version:   2.1.402
 Commit:    3599f217f4

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.16299
 OS Platform: Windows
 RID:         win10-x64
 Base Path:   C:\Program Files\dotnet\sdk\2.1.402\

Host (useful for support):
  Version: 2.1.4
  Commit:  85255dde3e
```

## Run

Using net core cli, just run `dotnet run` under `ChallengeMpetrini.Api` directory

## Test

Using net core cli, just run `dotnet test` under `ChallengeMpetrini.Test` directory

## Published on azure

App url: https://challenge-mpetrini.azurewebsites.net/api
Endpoints:

| Verb  | Endpoint | Description |
| ------------- | ------------- | ------------- |
| GET  | /contacts  | Get all contacts  |
| GET  | /contacts/id  | Get contact by id  |
| POST  | /contacts  | Create new contact  |
| PUT  | /contacts  | Update a contact  |
| DELETE  | /contacts/id  | Delete a contact  |
| GET  | /contacts/search/q  | Search a contact by email or phone number  |
| GET  | /contacts/getfrom/stateOrCity  | Search contacts from the same city or state   |

## Test examples in Postman

