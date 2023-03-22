SET MyCLUPath=C:\Program Files\Profisee\Master Data Maestro Utilities\22.2.0
SET MyCLU=Profisee.MasterDataMaestro.Utilities.exe
SET myAppURL=/URL:https://YOUR_URL.com/contoso/
::SET myAppURL=/URL:https://profiseecloud.com/contoso/ -- EXAMPLE
SET myClientID=/CLIENTID:101ae9463c3c4b9f91fc17a3bdf719da
SET MyPath=/FILE:"C:\Temp\contoso\

cd %MyCLUPath%

::SET MyType=MODEL
::SET MyFolder=%MyPath%01-%MyType%
::%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%"

SET MyType=PRESENTATIONVIEW
SET MyFolder=%MyPath%02-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%

SET MyType=SYNONYM
SET MyFolder=%MyPath%03-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%

SET MyType=DEPLOYDATA
%MyCLU% %myAppURL% %myClientID% /DEPLOYDATA /FILE:"C:\Temp\contoso\AllData.archive"

SET MyType=RULES
SET MyFolder=%MyPath%05-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%



SET MyType=FORMS
SET MyFolder=%MyPath%06-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%"

SET MyType=MATCHING
SET MyFolder=%MyPath%07-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%"

SET MyType=FORMS
SET MyFolder=%MyPath%06-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%"

SET MyType=MATCHING
SET MyFolder=%MyPath%07-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%"



SET MyType=HIERARCHY
SET MyFolder=%MyPath%08-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%"

SET MyType=APPLICATION
SET MyFolder=%MyPath%09-%MyType%
%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%"

::SET MyType=USERS
::SET MyFolder=%MyPath%10-%MyType%
::%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%"

::SET MyType=TEAMS
::SET MyFolder=%MyPath%11-%MyType%
::%MyCLU% %myAppURL% %MyClientID% /IMPORT /TYPE:%MyType% %MyFolder%" /INCLUDEMEMBERSHIPS
