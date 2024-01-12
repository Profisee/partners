@echo off
REM You will need to download and install GitBash, Profisee Command Line Utility.
REM Create a folder structure just like the variable env_maindemo or update the script.
REM Make sure all variables are updated. This script should pull the latest from Github Profisee Partners folder and update your environment. This script won't delete anything on your environment.
REM Created by Moacyr Passador
set cid_main=0AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAc
set env_maindemo=https://profiseecloud.com/YOUR_ENVIRONMENT/ 
set maindemo=C:\demoreset\Presales\MainDemo
set "clu=C:\Program Files\Profisee\Master Data Maestro Utilities\"
set version=23.2.0\
set git_location=C:\demoreset\Presales
echo.
echo ------
echo.
echo Script to reset sharable pre-sales demo environments from GitHub 
echo.
echo ------
cd %git_location%
if exist %maindemo% (
	git pull
	) else (
	cd ..
	git clone https://github.com/Profisee/partners.git
)
echo.
echo.
echo Command Line Utility location:  %clu%%version%
echo.
echo.
echo Environment to be exported: %env_maindemo%
echo.
echo.
echo Starting importing assets.
echo.
echo.
cd %clu%%version%
Profisee.MasterDataMaestro.Utilities.exe /URL:%env_maindemo% /CLIENTID:%cid_main% /IMPORT /TYPE:ALL /FILE:"%maindemo%" 
echo.
echo.
echo Import completed!
if "%errorlevel%"=="1" (
	Echo Success.
	) else (
	echo Import had errors.
	)
echo.
echo ------
echo.
echo Starting deploying data.
echo.
echo.
cd %clu%%version%
Profisee.MasterDataMaestro.Utilities.exe /URL:%env_maindemo% /CLIENTID:%cid_main% /DEPLOYDATA /FILE:"%maindemo%\AllData.archive" 
echo.
echo.
echo Deploy completed!
echo.
echo.
echo Done
cd %git_location%
