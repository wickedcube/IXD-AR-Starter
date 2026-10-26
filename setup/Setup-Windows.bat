@echo off
rem Double-click to run the Windows setup (works even when PowerShell scripts are normally blocked).
rem Works on its own: if Setup-Windows.ps1 isn't next to this file, it is downloaded from GitHub.
if exist "%~dp0Setup-Windows.ps1" (
  powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0Setup-Windows.ps1"
) else (
  powershell -NoProfile -ExecutionPolicy Bypass -Command "iex (irm 'https://raw.githubusercontent.com/wickedcube/IXD-AR-Starter/main/setup/Setup-Windows.ps1')"
)
