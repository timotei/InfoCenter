@echo off
cd InfoCenter
IF EXIST obj rmdir /s/q obj
IF EXIST bin rmdir /s/q bin
cd ..
cd "InfoCenter Continut/InfoCenter Continut/"
IF EXIST obj rmdir /s/q obj
IF EXIST bin rmdir /s/q bin
cd ..
cd ..
cd InfoCenterTools/
IF EXIST obj rmdir /s/q obj
IF EXIST bin rmdir /s/q bin
@pause