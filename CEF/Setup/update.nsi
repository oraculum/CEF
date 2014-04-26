
; Main constants - define following constants as you want them displayed in your installation wizard
!define COMPANYNAME "Oraculum"
!define PRODUCT_NAME "CEF"
!define PRODUCT_VERSION "1.0.1"
!define PRODUCT_PUBLISHER "Oraculum Ltda."
 
; Following constants you should never change
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"
 
!include "MUI.nsh"
!define MUI_ABORTWARNING
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\orange-install.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\orange-uninstall.ico"
 
; Wizard pages
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_LANGUAGE "English"
 
; Replace the constants bellow to hit suite your project
Name "${PRODUCT_NAME}"
OutFile "Atu_${PRODUCT_VERSION}.exe"
InstallDir "C:\CEF"
ShowInstDetails show
ShowUnInstDetails show
 
; Following lists the files you want to include, go through this list carefully!
Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite on  
  File "..\bin\Debug\BLL.dll"
  File "..\bin\Debug\Boleto.Net.dll"
  File "..\bin\Debug\Entity.dll"
  File "..\bin\Debug\DAL.dll"
  File "..\..\LigaBase\bin\Debug\LigaBase.exe"
  File "..\bin\Debug\CEF.exe"  

  # Start Menu
  createDirectory "$SMPROGRAMS\${COMPANYNAME}"
  createShortCut "$SMPROGRAMS\${COMPANYNAME}\${PRODUCT_NAME}.lnk" "$INSTDIR\CEF.exe" ""

SectionEnd
 
Section -Post
  ;Following lines will make uninstaller work - do not change anything, unless you really want to.
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
  
  ; COOL STUFF: Following line will add a registry setting that will add the INSTDIR into the list of folders from where
  ; the assemblies are listed in the Add Reference in C# or Visual Studio.
  ; This is super-cool if your installation package contains assemblies that someone will use to build more applications - 
  ; and it doesn't hurt even if it is placed there, it will only make the VS a bit slower to find all assemblies when adding references.
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "SOFTWARE\Microsoft\.NETFramework\v4.0.30319\AssemblyFoldersEx\Oraculum\OraculumERPFiscal" "" "$INSTDIR"
SectionEnd
 
; Replace the following strings to suite your needs
Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "Aplicativo foi completamente removido do seu computador."
FunctionEnd
 
Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Tem certeza que deseja remover Oraculum ERP Fiscal e todos os seus componentes?" IDYES +2
  Abort
FunctionEnd
 
; Remove any file that you have added above - removing uninstallation and folders last.
Section Uninstall
  Delete "$INSTDIR\ArqID.txt"
  Delete "$INSTDIR\BLL.dll"
  Delete "$INSTDIR\Boleto.Net.dll"
  Delete "$INSTDIR\Entity.dll"
  Delete "$INSTDIR\DAL.dll"
  Delete "$INSTDIR\CEF.exe"
  Delete "$INSTDIR\LigaBase.exe"
  Delete "$INSTDIR\uninst.exe"
  Delete "$DESKTOP\${PRODUCT_NAME}.lnk"
  
  # Remove Start Menu launcher
  Delete "$SMPROGRAMS\${COMPANYNAME}\${PRODUCT_NAME}.lnk"
  rmDir "$SMPROGRAMS\${COMPANYNAME}"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  ; Change following to be exactly as above
  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "SOFTWARE\Microsoft\.NETFramework\v4.0.30319\AssemblyFoldersEx\Oraculum\OraculumERPFiscal" 
 
  SetAutoClose true
SectionEnd