# ProductAPI
CRUD WebAPI App with .NET 5.0 and Swagger API documentation.

## Description
  - This web API app is demonstration of CRUD operations with Swagger API documentation for testing APIs.
  - Technology used - C#, .NET 6 and Swashbuckle nuget package.

### How to Install and Run the Project on your environment?
  1. Open Visual Studio and Clone the project on local directory.
  2. Go to Solutions View
  3. Go to appsettings.json file and copy the 'ConnectionStrings object
 ```appsettings.json
 
    "ConnectionStrings": {
      "SqlServerConnection": "server=user\\LocalDB;database=productsdb;"
    }
 ```
 4. Change the server and database name with your SQL Server instance.
 6.  Go to ProductAPI Web API Project and right click on it
 7. Select Manage User Secrets 
 <img width="221" alt="image" src="https://user-images.githubusercontent.com/61865561/207277306-2f78ce81-5c97-402a-9bd8-4e5e6980d68b.png">
 6. paste the ConnectionStrings object in Secrets json file.
```secrets.json
"ConnectionStrings": {
      "SqlServerConnection": "server=user\\LocalDB;database=productsdb;"
    }

```

### How to Use the Project?
  
