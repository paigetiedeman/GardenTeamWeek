<div align="center">

<img src="Garden/wwwroot/img/GreenThumb.png">

[![Language][language-shield]][language-url]
[![Language][languageH-shield]][languageH-url]
[![Language][languageC-shield]][languageC-url]
[![Language][languageS-shield]][languageS-url]
[![Language][languageJ-shield]][languageJ-url]
[![MIT License][license-shield]][license-url]

#### Garden MVC that allows users to plan out a garden using various endpoints with RESTful routing.

#### Created By: Anna Clarke, Paige Tiedeman, Connor Hansen, Brandon Eads, and Becket Harvey

</div>

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* PostMan
* SCSS
* Bootstrap
* CSS
* Live Sass Compiler Extension
* jQuery
* JavaScript
* Authentication 
* Identity

## Description

This application was created to show proficiency in ASP.Net Core MVC API creation and access using mySql, Entity, and Razor. This app allows the user full CRUD functionality for their own seeds and plots. This MVC also uses a seperate API to store and fetch data on Zipcodes and seeds. Application also includes a learning zone where gardening noivices can find helpful information to get started.

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Download and run [this](https://github.com/paigetiedeman/GardenAPI.Solution) API, following the instructions in the API README.md
  -This application REQUIRES the api to be running during use
* Clone [this](https://github.com/paigetiedeman/GardenTeamWeek) repository, or download and open the Zip on your local machine
* Open the GardenTeamWeek folder in your preferred text editor
* To install required packages, navigate to GardenTeamWeek/Garden in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0
* Add the file GardenTeamWeek/Garden/appsettings.json and insert the following:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=garden_team;uid=[YOUR-UID];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* Insert your MySQL password and User Id
* To Restore, build, and launch the project:
  - Navigate to the GardenTeamWeek/Garden folder in the command line or terminal
    - Run the command `$ dotnet restore` to restore the project dependencies
    - Run the command `$ dotnet build` to build and compile the project
    - Run the command `$ dotnet run` to build and compile the project
    - The ASP.NET Core MVC is viewable in the browser at http://localhost:5000 
    - If the styling is not appearing in the browser, open http://localhost:5000 in an incognito browser or clear your browser cache

### Steps to Use

* In your terminal navigate into GardenTeamWeek/Garden 
* If Migrations folder is not present run `$ dotnet ef migrations add Initial` to add Migrations folder
* Then run `$ dotnet ef database update` to create the schema
* Run `$ dotnet run` to start the live server at http://localhost:5000 
* Register and then log into your account to be able to navigate
* Choose any route from the buttons or header to navigate to view the full CRUD for seeds, sqfoots or plots.


## Known Bugs

* API is hosted locally
* Display of plot does not accurately reflect shape of plot
* Squarefoots in process

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Anna Clarke, Paige Tiedeman, Connor Hansen, Brandon Eads and Becket Harvey

## Support and contact details

* [Anna Clarke](https://github.com/)
* [Paige Tiedeman](github.com/paigetiedeman) 
* [Becket Harvey](https://github.com/)
* [Connor Hansen](https://github.com/)
* [Brandon Eads](https://github.com/)


[license-shield]: https://img.shields.io/badge/License-MIT-blue
[license-url]: https://opensource.org/licenses/MIT
[language-shield]: https://img.shields.io/badge/Language-C%23-green
[language-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[LanguageH-shield]: https://img.shields.io/badge/Language-HTML-red
[LanguageH-url]: https://developer.mozilla.org/en-US/docs/Web/HTML
[LanguageC-shield]: https://img.shields.io/badge/Language-CSS-blueviolet
[LanguageC-url]: https://developer.mozilla.org/en-US/docs/Web/CSS
[LanguageS-shield]: https://img.shields.io/badge/Language-SCSS-ff69b4
[LanguageS-url]: https://sass-lang.com/documentation
[LanguageJ-shield]: https://img.shields.io/badge/Language-JavaScript-yellow
[LanguageJ-url]: https://sass-lang.com/documentation