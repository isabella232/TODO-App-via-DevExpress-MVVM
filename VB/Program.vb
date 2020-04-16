Imports System
Imports System.Windows.Forms

Namespace TodoApp
    Friend Module Program
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainView())
        End Sub
    End Module
End Namespace
