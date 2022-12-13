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
  7. Create database with name 'productsdb' in your SQL Server instance and add Server name and database name in secrets.json
  8. Now you need to install Entity Framework Core CLI with following command
  
  ```
  dotnet tool install --global dotnet-ef
  ```
  9. Then you need to update changes for database tables to your SQL Server instance with following command
  ```
  dotnet ef database update --project ProductAPI
  ```
  10. With successfull configuration, now simply select launch type for running project an run the project with F5 key.
  <img width="226" alt="image" src="https://user-images.githubusercontent.com/61865561/207313676-db891e03-9569-4706-b3ad-95df1660687e.png">

  12. Now project will be running in browser with swagger API documentation page.
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/61865561/207316374-eb97a913-f406-4d57-8250-8b7353a42028.png">

### How to Use the Project?
  
