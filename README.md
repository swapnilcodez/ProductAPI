# ProductAPI
CRUD WebAPI App with .NET 6 and Swagger API documentation.

## Description
  - This Web API app is demonstration of CRUD operations with Swagger API documentation for testing APIs.
  - Technology used - C#, .NET 6 and Swashbuckle nuget package.

## How to Install and Run the Project on your environment?
  
  1. Clone the project on local directory.
<img width="322" alt="image" src="https://user-images.githubusercontent.com/61865561/207283610-f2e7d28c-5ac9-455b-b039-442f109e0dbe.png">
  
  2. Go to Solution view from Solution Explorer
<img width="255" alt="image" src="https://user-images.githubusercontent.com/61865561/207284279-99e6dcf4-7d8b-4fd8-b021-864eb2b70c1f.png">
  
  3. Go to appsettings.json file and copy the ConnectionStrings object

 ```
    "ConnectionStrings": {
      "SqlServerConnection": "server=\\LocalDBServer;database=productsdb;TrustServerCertificate=True;Integrated Security=SSPI"
    } 
 ```
 4.  Go to ProductAPI Project and right click on it and select Manage User Secrets
<img width="332" alt="image" src="https://user-images.githubusercontent.com/61865561/207341780-d0017ee3-6306-4bbe-a703-8e3bdad774e5.png">

 5. paste the ConnectionStrings object in Secrets json file.
 
 ```
    "ConnectionStrings": {
      "SqlServerConnection": "server=\\LocalDBServer;database=productsdb;TrustServerCertificate=True;Integrated Security=SSPI"
    }  
 ```
  6. Create database with name 'productsdb' in your SQL Server instance and add Server name and database name in secrets.json
  <img width="272" alt="image" src="https://user-images.githubusercontent.com/61865561/207346221-cb85b0ad-c640-4776-8fdd-6d6ec3b60603.png">

  7. Now Open Package Manager Console 
  <img width="470" alt="image" src="https://user-images.githubusercontent.com/61865561/207540884-38af8c0d-a83a-477b-8c39-a535e7ef95a7.png">

  8. Then you need to install Entity Framework Core CLI, so perform below command in Package Manager Console.
  ```
  dotnet tool install --global dotnet-ef
  ```
  9. Then you need to update changes for database tables to your SQL Server instance, so perform below command in Package Manager Console.
  ```
  dotnet ef database update --project ProductAPI
  ```
  10. With successfull configuration, now simply select launch type for running project an run the project with F5 key.
  <img width="226" alt="image" src="https://user-images.githubusercontent.com/61865561/207313676-db891e03-9569-4706-b3ad-95df1660687e.png">

  11. Now project will be running in browser with swagger API documentation page.
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/61865561/207316374-eb97a913-f406-4d57-8250-8b7353a42028.png">
