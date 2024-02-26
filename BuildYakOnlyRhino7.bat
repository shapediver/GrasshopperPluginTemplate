call "CommonVariables.bat"
call "%VsDevTools%"

set Configuration=ReleaseR7

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
