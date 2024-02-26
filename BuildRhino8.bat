call "CommonVariables.bat"
call "%VsDevTools%"

set Configuration=ReleaseR8

REM prepare build Yak package 
set Stage=PrepareBuildYakPackage
msbuild /t:%Stage% /p:Configuration=%Configuration% %Name%.sln || GOTO error

REM build 
set Stage=restore
msbuild /t:%Stage% /p:Configuration=%Configuration% %Name%.sln || GOTO error
set Stage=build
msbuild /t:%Stage% /p:Configuration=%Configuration% /p:TreatWarningsAsErrors=true %Name%.sln || GOTO error

REM build Yak package 
set Stage=BuildYakPackage
msbuild /t:%Stage% /p:Configuration=%Configuration% PluginGrasshopper\PluginGrasshopper.csproj || GOTO error

:done
if "%~1"=="" (
    set /p=Done. Hit ENTER to close...
    %SystemRoot%\explorer.exe %YakTargetDir%
)
exit /b 0

:error
if "%~1"=="" (
    if "%Stage%"=="" (
        set /p=An error happened. Hit ENTER to close...
    ) else (
        set /p=An error happened in stage %Stage%. Hit ENTER to close...
    )
)
exit /b 1
