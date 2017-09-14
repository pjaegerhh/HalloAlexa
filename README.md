# HalloAlexa
How to build an Alexa Skill using C# and Azure

This Repo shows how to build an Alex Skill in C# hosted as a Web API Service on Azure.
In /SpeechAssets you can find the Intents (Actions) and Utterances (synonyms) to invoke Alexa on an Echo Device
In /Controllers you can find AlexaController.cs which is actually the service for the intents (or functions)
Instead of default AWS Lambda we make use of Azure Web API Services.
To start a new project select the ASP.NET WebApp template in VS2017 and in the following dialog you should use Azure-API-App. You could also use "Web API"
but usually after 15min of inactivity of the App Azure deletes it from memory and the next user invoking your service might get an APP Timeout. 
This is actually not nice if you are in the middle of certification for your new Alexa Skill

First thing you should do after creating the Web API Service is to update your NuGet packages and make sure that "Swashbuckle" is installed (this should be the default).
Usually you find many outdated packages - update them all. If you're asked to Update SwaggerConfig.cs push Yes.

Next step should be a publish of the empty App to Azure. 
Use a good name for your Web App, make sure that the type is "API APP", select a ressource group (or create a new) and create a new App Service-Plan. The free tier is good enough for an average Alexa Skill.
After you hit publish you will get your empty App published on Azure and if done without errors your default browser will open and show the App.
Swagger should be installed by default (just type after your web service URL /swagger and see if it's working.) Its quite a handy tool to check if your AlexaController is working well

Now you might want to switch to the Alexa Dev console.
https://developer.amazon.com/edw/home.html#/ Please make sure to logg in with your Amazon credentials. Best would be to use your normal credentials which you are also using for your Echo's

Go to "Alexa Skill Kit" and "Add a new Skill"
