# Code challenge

Sample API in .NET Core 2.1 using **Visual Studio 2017 V15.8.4**. The data has been persisted using EF Core 2.1.

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
## Restore
Before beginning, run `dotnet restore` under `ChallengeMpetrini.Api` directory

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

Import [Postman xml config file](https://github.com/mpetrinidev/code-challenge-solstice/blob/master/ChallengeMpetrini.Api/challenge-mpetrini-azure.postman_collection.json). Collection is in version 2.1

## Thanks!

If you have any doubt, feel free to contact me at dev.mpetrini@gmail.com
