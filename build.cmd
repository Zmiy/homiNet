@echo off
rem Try to find the highest version of MSBuild available...
rem set MSBUILD=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe
set MSBUILD=%WINDIR%\Microsoft.NET\v4.0.30319\msbuild.exe
set MSBUILD_SCRIPT="%~dp0\src\HomiNet\HomiNet V8 SE1.vbproj" 
set POST_BUILD_COMMAND=
if not exist %MSBUILD% set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
if not exist %MSBUILD% set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v3.5\msbuild.exe
rem set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
if not exist %MSBUILD% (
	echo MSBuild not found, please update %0
	exit /b 1
) 

%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Build /p:BuildNetFX35=true,Configuration=Debug330,Platform=x86 /fileLogger
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Build /p:BuildNetFX35=true,Configuration=Debug226,Platform=x86 /fileLogger
