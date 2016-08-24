set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
rem set MSBUILD_SCRIPT="%~dp0\APP DriverIRF V8 SE1.vbproj"
rem set MSBUILD_SCRIPT="%~dp0\APPDriverIRF.netfx35.vbproj"
set MSBUILD_SCRIPT="%~dp0\!HomiNet.proj"
rem %MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Build  /p:Configuration=Debug330,Platform=x86,BuildNetFX35=true /fileLogger1
%MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:SourceArchive /p:VersionNumber="8.2.4.97_1",DateOfComp="20160411"  /fileLogger1
rem %MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:VersionNumber="8.2.4.97",DateOfComp="20160411"  /fileLogger1
rem %MSBUILD% /nologo /fl %MSBUILD_SCRIPT% /t:Rebuild /p:Configuration=Debug330,Platform=x86,BuildNetFX35=true,VersionNumber="8.2.4.97",DateOfComp="20160411" /fileLogger1