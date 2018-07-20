# propellerhead

Thanks for the opportunity to present this to the Propellerhead team.

Propellerhead developer technical test using ASP.NET MVC with Entity Framework 6.

###Requirements:

Visual Studio 2017 Community Edition

###To run the app locally from Visual Studio:

Build the solution.
Open the Package Manager Console (Tools > NuGet Package Manager > Package Manager Console)
In the Package Manager Console window, enter the following command: update-database
Press F5 to run and debug.

###Data Layer

This application uses Entity Framework Code First. The Customer and Note data models can be found in the Models folder.

###UI

Controllers and views are scaffolded from the EF models. Bootstrap is very lightly used within the app. For the customer table the library Datatables [https://datatables.net/] is used. It is a simple way of building in elements such as search, sort etc. Very useful for prototyping.
