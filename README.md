# ProductAPI
CRUD WebAPI App with .NET 5.0 and Swagger API documentation.

## Description
  - This web API app is demonstration of CRUD operations with Swagger API documentation for testing APIs.
  - Technology used - C#, .NET 6 and Swashbuckle nuget package.

### How to Install and Run the Project on your environment?
  
  1. Clone the project on local directory.
<img width="322" alt="image" src="https://user-images.githubusercontent.com/61865561/207283610-f2e7d28c-5ac9-455b-b039-442f109e0dbe.png">
  
  2. Go to Solution view from Solution Explorer
<img width="255" alt="image" src="https://user-images.githubusercontent.com/61865561/207284279-99e6dcf4-7d8b-4fd8-b021-864eb2b70c1f.png">
  
  3. Go to appsettings.json file and copy the ConnectionStrings object
 
 ```appsettings.json
 
    "ConnectionStrings": {
      "SqlServerConnection": "server=user\\LocalDB;database=productsdb;"
    }
    
 ```
 4.  Go to ProductAPI Web API Project and right click on it

 5. Select Manage User Secrets 
 <img width="221" alt="image" src="https://user-images.githubusercontent.com/61865561/207277306-2f78ce81-5c97-402a-9bd8-4e5e6980d68b.png">
 
 6. paste the ConnectionStrings object in Secrets json file.
 
 ```secrets.json
 
    "ConnectionStrings": {
      "SqlServerConnection": "server=user\\LocalDB;database=productsdb;"
    }
    
 ```
  7. Change the server and database name with your SQL Server instance.

### How to Use the Project?
  
