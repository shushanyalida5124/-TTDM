; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

#define MyAppName "�����������������2�汾"
#define MyAppVersion "1.5"
#define MyAppPublisher "�ҵĹ�˾"
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "TTDM��ҳ.exe"

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (�����µ�GUID����� ����|��IDE������GUID��)
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
OutputBaseFilename=�������������2setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "E:\Git\-TTDM\TTDM��ҳ\bin\Debug\TTDM��ҳ.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM��ҳ\bin\Debug\TTDM-BLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM��ҳ\bin\Debug\TTDM-BLL.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM��ҳ\bin\Debug\TTDM-DAL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM��ҳ\bin\Debug\TTDM-DAL.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM��ҳ\bin\Debug\TTDM��ҳ.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM��ҳ\bin\Debug\TTDM��ҳ.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\-TTDM\TTDM��ҳ\bin\Debug\TTDM��ҳ.pdb"; DestDir: "{app}"; Flags: ignoreversion
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

