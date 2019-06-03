# AGL Developer Coding Test#

## Requirements ##

A json web service has been set up at the url: http://agl-developer-test.azurewebsites.net/people.json 
You need to write some code to consume the json and output a list of all the cats in alphabetical order under a heading of the gender of their owner.
You can write it in any language you like. You can use any libraries/frameworks/SDKs you choose.
Example:

Male
* Angel
* Molly
* Tigger

Female
* Gizmo
* Jasper

Notes
 Submissions will only be accepted via github or bitbucket
 Use industry best practices 
 Use the code to showcase your skill.


## Prerequisites ##

* [Visual Studio 2017]

## Implementation ##

I have built the solution using Asp .Net Web Api to achieve this requirement. 
I have created an Asp .Net Web Api project with default MVC Home Controller view to display the output.  
It has various layers, and the given Data Service is consumed from the Service Layer of the application.

The Pet details are exposed as Restful Web Api service so that it can be accessed by many client applications. It can be accessed using the below URL.
* http://localhost:3808/api/pet/GetPetsByOwnerGender?PetType=cat

This Service URL is called from the MVC Home controller to display the output in a view.

note:
Since Pet details are exposed as Restful service, It is called using Http Client from the MVC Home controller. Otherwise, Can directly call PetManager.cs class from Home controller to fetch the details.

## Execution Steps ##

The application can be run on Windows using Visual Studio 2017 editors. In order to run this application, Please follow the below instructions.

* Download\Clone the project to your local machine.
* Open `CatCatalogue.sln` using VS.
* Build and run the solution.
* It will open a browser and display the output.

Other Valid Api requests are:

* http://localhost:3808/api/pet/GetPetsByOwnerGender?PetType=cat
* http://localhost:3808/api/pet/GetPetsByOwnerGender?PetType=dog
* http://localhost:3808/api/pet/GetPetsByOwnerGender?PetType=fish
