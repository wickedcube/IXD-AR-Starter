@echo off
rem Double-click to run the Windows setup (works even when PowerShell scripts are normally blocked).
powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0Setup-Windows.ps1"
