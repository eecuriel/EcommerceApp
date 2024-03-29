# Ecommerce application

This is a base version of my own Ecommerce application.  The actual state of it is  "in developing" project and the progress will be updated frecuently. 

This project is been construing as a PWA (Progressive Web Application) in order give to the user altenatives to manage it into a mobile divices and use several functionalities that only exist those kind of enviroment, such as:

- Best perfomance
- Offline work mode.
- Full responsiveness and browser compatibility. 
- Connectivity independence. 
- App-like interface.
- Push notifications. 
- Self-updates. 
- Safety.

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

- User registration
- Store creation
- Store profile administration


## Getting Started

You can fork the repositroy or download it for your use.  If you want to collaborate with the project, write me :), I will be so happy to receip help.

### Prerequisites

- .NET 5.0.104
- .NET Core Hosting Bundle
- MS SQL express or superior
- Project API installed.  You can see the instructions here [Ecommerce API](https://github.com/eecuriel/Project-API.git)

Differents point of view:


Web :

![image](https://user-images.githubusercontent.com/67849830/117068564-7124bf80-acf9-11eb-814d-fb9abec7c8ed.png)

Desktop PWA :

![image](https://user-images.githubusercontent.com/67849830/117068775-b5b05b00-acf9-11eb-8478-4a6bf0762d8b.png)



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

![image](https://user-images.githubusercontent.com/67849830/117538138-c9e2a980-afd2-11eb-83ab-dd96a9f156bf.png)


4- Setting up  and test  the application

Once the portal is configured, you must configure the appsettings.json file with the URL corresponding to your API project. 

![image](https://user-images.githubusercontent.com/67849830/117538189-07dfcd80-afd3-11eb-8fe7-dd9cc2020a75.png)

You can use the API project to test this project too [Project API](https://github.com/eecuriel/Project-API)

## Authors

* **Eduardo Curiel** - *Initial work* - [eecuriel](https://github.com/eecuriel)

You want to be a contributor?.  Write me :).

## License

This project is licensed under the GNU License - see the [gnu.md](https://github.com/eecuriel/Project-API/files/6410171/gnu.md) file for details 

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* All constructive comments are welcomeAll constructed comment are welcome
