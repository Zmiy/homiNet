set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
rem set MSBUILD_SCRIPT="%~dp0\APP DriverIRF V8 SE1.vbproj"
rem set MSBUILD_SCRIPT="%~dp0\APPDriverIRF.netfx35.vbproj"
set MSBUILD_SCRIPT="%~dp0\!HomiNet.proj"
for /f "delims=" %%# in ('powershell get-date -format "{yyMMdd_hhmm}"') do @set _date=%%#
set _verNum=8.2.4.97

rem %MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Build  /p:Configuration=Debug330,Platform=x86,BuildNetFX35=true /fileLogger1
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:SourceArchive /p:VersionNumber=%_verNum%,DateOfComp=%_date%  /fileLogger7

%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug330,Platform=x86,BuildNetFX35=true,VersionNumber=%_verNum% /fileLogger1
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug330,Platform=x86,BuildNetFX40=true,VersionNumber=%_verNum% /fileLogger2
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug330,Platform=x86,BuildNetFX45=true,VersionNumber=%_verNum% /fileLogger3

%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug226,Platform=x86,BuildNetFX35=true,VersionNumber=%_verNum% /fileLogger4
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug226,Platform=x86,BuildNetFX40=true,VersionNumber=%_verNum% /fileLogger5
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug226,Platform=x86,BuildNetFX45=true,VersionNumber=%_verNum% /fileLogger6
