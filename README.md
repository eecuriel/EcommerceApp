# Ecommerce application API

This is a base version of an API to manage the business rules and master data for a Ecommerce application.  The actual state of it is  "in developing" project and the progress will be updated frecuently.

This project will contain the following functionalities:
- Multiple Store creation and adminitration
- Product Catalog
- Shopping cart
- Shipping fees administration
- Rentals
- Inventory management
- Quotation and Order fulfillment
- Stock procurement based in availabilty. Just for orders into the scope of "Make to Order"
- Administration of attention times and schedule of services
- Delivery scope administration

This first version can manage:

- Data base interaction. You can use Entity Framerwork migration to create all the entities needs into a MS SQL database
- Email Service.
- Image files upload service
- JWT bearer token
- Authorization and Authentication model
- Swagger
- UserIdentity schema

End points for:
- Store creation
- User registration
- User profile update

## Getting Started

You can fork the repositroy or download it for your use.  If you want to collaborate with the project, write me :), I will be so happy to receip help.

### Prerequisites

- .NET 5.0.104
- MS SQL express or superior
- Entity Framework Core .NET --version 5.0.5
- AutoMapper --version 10.1.1
- NetTopologySuite --version 2.2.0
- MailKit --version 2.11.1


### Installing

Impotant: Thoses steps just apply to Internet Information Service (IIS) in Windows and using a developer access. 

1- Install the .NET Core Hosting Bundle [Download here](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/iis/hosting-bundle?view=aspnetcore-5.0)

2- Publish into C:\inetpub\wwwroot\
 You can use the publish option in VS Communty or in NET CLI
```
dotnet publish -o C:\inetpub\wwwroot\YOURFOLDER
```
3- Create a new site in IIS

Important : 
- The application pool must be "NetCore" that can appear once you install .Net Core Hosting Bundle
- Is not mandatory use a SSL certificate for testing propose.  If you want to test it, if is the case, you can use the developer certificate provided by your IIS installation.

![image](https://user-images.githubusercontent.com/67849830/116789284-24808080-aa7c-11eb-9e09-0c5394fec5e2.png)

5- Running the API
- You can browse your local site and explore all the endpoint that the API contain using Swagger

![image](https://user-images.githubusercontent.com/67849830/116789596-97d6c200-aa7d-11eb-949e-7df4c358702e.png)

6- Testing the End Points
- You can use Postman v8.3.0 [Download](https://www.postman.com/downloads/)

![image](https://user-images.githubusercontent.com/67849830/116789772-8e018e80-aa7e-11eb-9166-b226b5439716.png)


## Authors

* **Eduardo Curiel** - *Initial work* - [eecuriel](https://github.com/eecuriel)

You want to be a contributor?.  Write me :).

## License

This project is licensed under the GNU License - see the [gnu.md](https://github.com/eecuriel/Project-API/files/6410171/gnu.md) file for details 

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* All constructive comments are welcomeAll constructed comment are welcome
