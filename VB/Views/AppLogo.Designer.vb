Namespace TodoApp.Views
    Partial Class AppLogo
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


#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodoApp.Views.AppLogo))
            Me.greetLabel = New DevExpress.XtraEditors.LabelControl()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' greetLabel
            ' 
            Me.greetLabel.AllowHtmlString = True
            Me.greetLabel.Appearance.Options.UseTextOptions = True
            Me.greetLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.greetLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.greetLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.greetLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.greetLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
            Me.greetLabel.ImageOptions.SvgImage = Global.Resources.Logo
            Me.greetLabel.ImageOptions.SvgImageSize = New System.Drawing.Size(128, 128)
            Me.greetLabel.IndentBetweenImageAndText = 64
            Me.greetLabel.Location = New System.Drawing.Point(0, 0)
            Me.greetLabel.Name = "greetLabel"
            Me.greetLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 200)
            Me.greetLabel.Size = New System.Drawing.Size(398, 468)
            Me.greetLabel.TabIndex = 0
            Me.greetLabel.Text = "{Greeting}"
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(TodoApp.ViewModels.AppLogoViewModel)
            ' 
            ' AppLogo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.greetLabel)
            Me.Name = "AppLogo"
            Me.Size = New System.Drawing.Size(398, 468)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub


#End Region

        Private greetLabel As DevExpress.XtraEditors.LabelControl
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    End Class
End Namespace
