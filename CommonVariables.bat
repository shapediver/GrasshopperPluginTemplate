@echo off

REM VsDevTools might need to be adapted according your installation of Visual Studio 
set "VsDevTools=C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"

REM where to find yak
set "YakExecutable=C:\Program Files\Rhino 8\System\yak.exe"

REM name of the solution to build
set "Name=PluginTemplate"

REM where to copy resulting yak packages
set "YakTargetDir=bin\packages"

