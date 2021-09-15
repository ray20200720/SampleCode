# dotnet指令
- 檢查dotnet是否已經安裝
    dotnet -h

- 新建專案
    dotnet new console
    dotnet new console -o 指定路徑
- 執行
    dotnet run

# CSC.exe
- 路徑
    C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe
- 編譯指令    
    C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe test.cs
- 編譯成dll
    C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /out:Duck.dll /t:library DataObject\Duck.cs
- 編譯並使用dll
    C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /out:ConsoleHost.exe /R:Duck.dll ConsoleHost.cs


# BuildWebLibrary.bat
@ECHO OFF
REM Prepare directory

set FrameworkDIR=%SystemRoot%\Microsoft.NET\Framework

REM step1 Delete output;create new output, copy to output folder
rd .\bin /s/q
rd .\output /s/q

mkdir "Output"

ECHO -----------------------------------------------          
ECHO ***********************************************
ECHO ***    build IMES.Web.Library Starting   ****
ECHO ***********************************************
ECHO -----------------------------------------------

REM step2 clear old bin; build solution
%FrameworkDIR%\v3.5\MSBuild.exe IMES.Web.Library.sln /t:Clean /p:WarningLevel=0;configuration=Release /verbosity:q /nologo
%FrameworkDIR%\v3.5\MSBuild.exe IMES.Web.Library.sln /t:Build /p:WarningLevel=0;configuration=Release /verbosity:q /nologo /l:FileLogger,Microsoft.Build.Engine;logfile=IMES.Web.Library.Build.log;Verbosity=m;Encoding=UTF-8;/p:outdir=.\output\PrecompiledWebLibrary
if %errorlevel% neq 0 goto ErrBuildService

ECHO -----------------------------------------------          
ECHO ***********************************************
ECHO ***    Build IMES.Web.Library succeed!    ***
ECHO ***********************************************
ECHO -----------------------------------------------

REM step3 copy builded bin files to Output
ECHO -------------------------------------          
ECHO *************************************
echo ***        Copy File      		   *** 
ECHO *************************************    
ECHO -------------------------------------
xcopy .\bin\*.* "Output\" /y/s

xcopy ".\Output\*.*" "..\..\lib\IMES.Web.Library\" /y/s

GOTO ClearAll


:ErrBuildService
rd Output /s/q 
ECHO -------------------------------------          
ECHO *************************************
echo ***    build IMES.Web.Library Fail!    *** 
ECHO *************************************    
ECHO -------------------------------------
GOTO ClearAll


:ClearAll
REM del bin\*.dll
REM del bin\*.pdb

GOTO END

:END
pause
@ECHO ON

    
 