## Commander API
This API stores command-line snippet along with _descriptive_ text and info of supported _platform_ (eg: .NetCore, docker, Linux).

## Technology and Tools used in this application
#### This is basically **.NET Core MVC REST API** web app
- .Net Core 3.1
- MVC
- Rest Web API (created 6 API Endpoint: GET (2), POST, PUT, PATCH, DELETE)
- Entity Framework Core
- SQL Server DB
- Automapper
- Postman (for testing API)
- Visual Studio Code

## Application Architecture:

![Screen Shot 2020-10-07 at 10 21 34](https://user-images.githubusercontent.com/18711592/95352054-74e98400-0887-11eb-8dc0-e28f4b1fe9c0.png)

## Other info
There are mainly three types of Dependency Injection provided in .Net Core (called as Service Lifetimes)
1. AddSingleton (same instance for every request)
2. AddScoped (creates one instance per client request)
3. AddTransist (created new instance every time)

In this application we used **AddScoped service**.

### Reference
Les Jackson: https://www.youtube.com/watch?v=fmvcAzHpsk8
