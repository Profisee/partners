# partners
Repository to aid you in deploying a demonstration solution to an instance of the Profisee platform.  As a Profisee Partner, we hope you will use this repository to learn how to use Profisee.  You may deploy these assets to any IaaS, PaaS or SaaS environment that you have an admin account for.

A) Preparation for Solution Deployment
   1) Download, Install and Configure Profisee. All the documentation can be found here: https://support.profisee.com/
   2) Download and Install "ProfiseePlatformTools_20****.msi" from the downloads folder on https://support.profisee.com/  (this  is also known as the Profisee Command Line Utility or CLU)
   3) In the main Github page, the top right corner should have a green button saying "<> Code". Click on that icon and there you should have a few options to download the repository. Pick one and download the entire repository.
   4) Run Profisee Command Line Utility to import the assets and deploy the data. You will need the following pieces of information to complete the deployment.
      1. The folder you installed the CLU into. (this varies based on the software version you installed.)
      2. The location where you saved the repository objects to.
      3. The URL of your Profisee instance.
      4. A ClientID for your Profisee user account (must have System Administrator role).
  
B) If your target instance has no entities already created, then skip this step and proceed to the next. 
   1. In Profisee use Administration/Advanced Modeling/Open File and open the model file from your local repository.
   2. Publish the model to Profisee.  Choose the Merge Models option to keep the existing entities.  (If you choose Replace the Model then your existing entities will be deleted.)
       
C) Solution Deployment
   1. Open a command prompt as an administrator.
   2. Go the folder where the CLU is located.
   3. more to come...
   
Please send your feedback to moacyr.passador@profisee.com
