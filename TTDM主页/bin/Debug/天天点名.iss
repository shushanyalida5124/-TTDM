; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "天天点名——阿尔法2版本"
#define MyAppVersion "1.5"
#define MyAppPublisher "我的公司"
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "TTDM主页.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
AppId={{51379AF7-A79B-4DCE-AE1B-CA00B9C9AF87}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputDir=C:\Users\he\Desktop
OutputBaseFilename=天天点名阿尔法2setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "E:\Git\-TTDM\TTDM主页\bin\Debug\TTDM主页.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM主页\bin\Debug\TTDM-BLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM主页\bin\Debug\TTDM-BLL.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM主页\bin\Debug\TTDM-DAL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM主页\bin\Debug\TTDM-DAL.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM主页\bin\Debug\TTDM主页.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM主页\bin\Debug\TTDM主页.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM主页\bin\Debug\TTDM主页.pdb"; DestDir: "{app}"; Flags: ignoreversion
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

