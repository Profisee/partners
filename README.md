# partners
Repository to aid you in deploying a demonstration solution to an instance of the Profisee platform.  As a Profisee Partner, we hope you will use this repository to learn how to use and demonstrate Profisee.  You may deploy these assets to any IaaS, PaaS or SaaS environment that you have an admin account for.  Additional information for partners on demonstrating Profisee can be found in Academy.  The solution contains approximately 18k records - please keep that in mind for any Profisee license limits that apply.

A) Preparation for Solution Deployment
   1) Download, Install and Configure Profisee. All the documentation can be found here: https://support.profisee.com/
   2) Download and Install "ProfiseePlatformTools_20****.msi" from the downloads folder on https://support.profisee.com/  (this  is also known as the Profisee Command Line Utility or CLU)
   3) In this Github page, the top right corner should have a green button saying "<> Code". Click on that icon and there you should have a few options to download the repository. Pick one and download the entire repository.
   4) Run Profisee Command Line Utility to import the assets and deploy the data. You will need the following pieces of information to complete the deployment.
      1. The folder you installed the CLU into. (this varies based on the software version you installed.)
      2. The location where you saved the repository objects to.
      3. The URL of your Profisee instance.
      4. A ClientID for your Profisee user account (must have System Administrator role).
  
B) If your target instance has no entities already created, then skip this step and proceed to the next. 
   1. In Profisee use Administration/Advanced Modeling/Open File and open the model file from your local repository.
   2. Publish the model to Profisee manually.  Choose the Merge Models option to keep the existing entities.  (If you choose Replace the Model then your existing entities will be deleted.)
       
C) Solution Deployment
   1. Open a Windows command prompt as an administrator.
   2. Update the commands below below with your details and execute them in the CLU.
   3. There are circular dependencies between some object types and you may see warnings when first importing Forms and Matching Strategies.  To overcome this the script imports those objects a second time.

      SET MyCLUPath=C:\Program Files\Profisee\Master Data Maestro Utilities\**23.2.0**
      
      SET MyCLU=Profisee.MasterDataMaestro.Utilities.exe
      
      SET myAppURL=/URL:https://**server**/**instance**/
      
      SET myClientID=/CLIENTID:**clientid**
      
      SET MyPath=/FILE:"**PATHTOTHELOCALREPOSITORY**\
      
      cd %MyCLUPath%
      
      SET MyType=ALL
      
      %MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:ALL %MyPath%"
      
      %MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:FORMS %MyPath%"
      
      %MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:MATCHING %MyPath%"


Please share your feedback with lee.gregory@profisee.com and moacyr.passador@profisee.com 
