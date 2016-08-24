echo off
set vd=%date% %y%%m%%d%
echo %vd%
for /f "delims=" %%# in ('powershell get-date -format "{yyMMdd_hhmm}"') do @set _date=%%#
echo %_date%
