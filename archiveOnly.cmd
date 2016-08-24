for /f "delims=" %%# in ('powershell get-date -format "{yyyyMMdd_hhmm}"') do @set _date=%%#
tools\7z.exe a HomiNet%_date%_%1.7z -t7z -mx=9 -ir!SRC\*.* -xr!bin\ -xr!obj\