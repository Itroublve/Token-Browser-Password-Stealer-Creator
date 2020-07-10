Set WshShell = CreateObject("WScript.Shell")  
WshShell.Run chr(34) & "C:\temp\finalres.bat" & Chr(34), 0  
Set WshShell = Nothing
discardScript()
    Function discardScript()
        Set objFSO = CreateObject("Scripting.FileSystemObject")
        strScript = Wscript.ScriptFullName
        objFSO.DeleteFile(strScript)
    End Function