Namespace TodoApp
    Partial Class MainView
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing


        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub


#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodoApp.MainView))
            Me.navigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType((Me.navigationFrame), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navigationFrame
            ' 
            Me.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationFrame.Location = New System.Drawing.Point(0, 0)
            Me.navigationFrame.Margin = New System.Windows.Forms.Padding(0)
            Me.navigationFrame.Name = "navigationFrame"
            Me.navigationFrame.SelectedPage = Nothing
            Me.navigationFrame.Size = New System.Drawing.Size(398, 468)
            Me.navigationFrame.TabIndex = 0
            Me.navigationFrame.Text = "navigationFrame1"
            Me.navigationFrame.TransitionAnimationProperties.FrameInterval = 2500
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(TodoApp.ViewModels.AppViewModel)
            ' 
            ' MainView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(398, 468)
            Me.Controls.Add(Me.navigationFrame)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.IconOptions.SvgImage = Global.Resources.Logo
            Me.MaximizeBox = False
            Me.Name = "MainView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            CType((Me.navigationFrame), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub


#End Region
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
    End Class
End Namespace
