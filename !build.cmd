set MSBUILD=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe
rem set MSBUILD_SCRIPT="%~dp0\APP Driver IRF.vbproj"
set MSBUILD_SCRIPT="%~dp0\!HomiNet.proj"
set POST_BUILD_COMMAND=
if not exist %MSBUILD% set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
if not exist %MSBUILD% set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v3.5\msbuild.exe
rem set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
if not exist %MSBUILD% (
	echo MSBuild not found, please update %0
	exit /b 1
) 

for /f "delims=" %%# in ('powershell get-date -format "{yyMMdd_hhmm}"') do @set _date=%%#
set _verNum=file8.2.4.912_assembly8.2.4.9

%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:SourceArchive /p:VersionNumber=%_verNum%,DateOfComp=%_date%  /fileLogger7

%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug330,Platform=x86,BuildNetFX35=true,VersionNumber=%_verNum% /fileLogger1
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug330,Platform=x86,BuildNetFX40=true,VersionNumber=%_verNum% /fileLogger2
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug330,Platform=x86,BuildNetFX45=true,VersionNumber=%_verNum% /fileLogger3

%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug226,Platform=x86,BuildNetFX35=true,VersionNumber=%_verNum% /fileLogger4
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug226,Platform=x86,BuildNetFX40=true,VersionNumber=%_verNum% /fileLogger5
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug226,Platform=x86,BuildNetFX45=true,VersionNumber=%_verNum% /fileLogger6
