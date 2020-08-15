Set fso = CreateObject("Scripting.FileSystemObject")
Dim fso,tempfolder
Set tempfolder = fso.GetSpecialFolder(2)
Set WshShell = CreateObject("WScript.Shell")  
WshShell.Run chr(34) & (tempfolder + ".\finalres.bat") & Chr(34), 0  
Set WshShell = Nothing
discardScript()
    Function discardScript()
        Set objFSO = CreateObject("Scripting.FileSystemObject")
        strScript = Wscript.ScriptFullName
        objFSO.DeleteFile(strScript)
    End Function