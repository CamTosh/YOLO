Imports System.Diagnostics

Module Yolo
    Sub Main()
        Console.WriteLine("YOLO!")
        Console.ReadLine()
        My.Computer.FileSystem.DeleteFile(Process.GetCurrentProcess().MainModule.FileName)
    End Sub
End Module

