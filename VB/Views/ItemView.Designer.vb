Namespace TodoApp.Views
    Partial Class ItemView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodoApp.Views.ItemView))
            Me.headerPane = New DevExpress.Utils.Layout.TablePanel()
            Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
            Me.titleLabel = New DevExpress.XtraEditors.LabelControl()
            Me.footerPane = New DevExpress.Utils.Layout.TablePanel()
            Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
            Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
            Me.dataPane = New DevExpress.Utils.Layout.TablePanel()
            Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
            Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
            Me.teTitle = New DevExpress.XtraEditors.TextEdit()
            Me.teDescription = New DevExpress.XtraEditors.MemoEdit()
            Me.tglCompleted = New DevExpress.XtraEditors.ToggleSwitch()
            Me.todoItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType((Me.headerPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.headerPane.SuspendLayout()
            CType((Me.footerPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.footerPane.SuspendLayout()
            CType((Me.dataPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataPane.SuspendLayout()
            CType((Me.teTitle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teDescription.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tglCompleted.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.todoItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' headerPane
            ' 
            Me.headerPane.AutoSize = True
            Me.headerPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)})
            Me.headerPane.Controls.Add(Me.btnBack)
            Me.headerPane.Controls.Add(Me.titleLabel)
            Me.headerPane.Controls.Add(Me.btnDelete)
            Me.headerPane.Controls.Add(Me.btnSave)
            Me.headerPane.Dock = System.Windows.Forms.DockStyle.Top
            Me.headerPane.Location = New System.Drawing.Point(24, 12)
            Me.headerPane.Margin = New System.Windows.Forms.Padding(0)
            Me.headerPane.Name = "headerPane"
            Me.headerPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.headerPane.Size = New System.Drawing.Size(350, 38)
            Me.headerPane.TabIndex = 6
            ' 
            ' btnBack
            ' 
            Me.btnBack.AllowFocus = False
            Me.btnBack.AutoSize = True
            Me.headerPane.SetColumn(Me.btnBack, 0)
            Me.btnBack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnBack.ImageOptions.SvgImage = Global.Resources.Back
            Me.btnBack.Location = New System.Drawing.Point(0, 0)
            Me.btnBack.Margin = New System.Windows.Forms.Padding(0)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.headerPane.SetRow(Me.btnBack, 0)
            Me.btnBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnBack.Size = New System.Drawing.Size(38, 38)
            Me.btnBack.TabIndex = 3
            ' 
            ' titleLabel
            ' 
            Me.titleLabel.Appearance.FontSizeDelta = 4
            Me.titleLabel.Appearance.Options.UseFont = True
            Me.titleLabel.Appearance.Options.UseTextOptions = True
            Me.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.headerPane.SetColumn(Me.titleLabel, 1)
            Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.titleLabel.Location = New System.Drawing.Point(38, 0)
            Me.titleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            Me.headerPane.SetRow(Me.titleLabel, 0)
            Me.titleLabel.Size = New System.Drawing.Size(236, 38)
            Me.titleLabel.TabIndex = 2
            Me.titleLabel.Text = "Title"
            ' 
            ' footerPane
            ' 
            Me.footerPane.AutoSize = True
            Me.footerPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.footerPane.Controls.Add(Me.tglCompleted)
            Me.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.footerPane.Location = New System.Drawing.Point(24, 418)
            Me.footerPane.Margin = New System.Windows.Forms.Padding(0)
            Me.footerPane.Name = "footerPane"
            Me.footerPane.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
            Me.footerPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.footerPane.Size = New System.Drawing.Size(350, 38)
            Me.footerPane.TabIndex = 7
            ' 
            ' btnDelete
            ' 
            Me.btnDelete.AllowFocus = False
            Me.btnDelete.AutoSize = True
            Me.headerPane.SetColumn(Me.btnDelete, 2)
            Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnDelete.ImageOptions.SvgImage = Global.Resources.Delete
            Me.btnDelete.Location = New System.Drawing.Point(274, 0)
            Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.headerPane.SetRow(Me.btnDelete, 0)
            Me.btnDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnDelete.Size = New System.Drawing.Size(38, 38)
            Me.btnDelete.TabIndex = 4
            ' 
            ' btnSave
            ' 
            Me.btnSave.AllowFocus = False
            Me.btnSave.AutoSize = True
            Me.headerPane.SetColumn(Me.btnSave, 3)
            Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnSave.ImageOptions.SvgImage = Global.Resources.Save
            Me.btnSave.Location = New System.Drawing.Point(312, 0)
            Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.headerPane.SetRow(Me.btnSave, 0)
            Me.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnSave.Size = New System.Drawing.Size(38, 38)
            Me.btnSave.TabIndex = 3
            ' 
            ' dataPane
            ' 
            Me.dataPane.AutoSize = True
            Me.dataPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.dataPane.Controls.Add(Me.lblDescription)
            Me.dataPane.Controls.Add(Me.lblTitle)
            Me.dataPane.Controls.Add(Me.teTitle)
            Me.dataPane.Controls.Add(Me.teDescription)
            Me.dataPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataPane.Location = New System.Drawing.Point(24, 50)
            Me.dataPane.Margin = New System.Windows.Forms.Padding(0)
            Me.dataPane.Name = "dataPane"
            Me.dataPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.dataPane.Size = New System.Drawing.Size(350, 368)
            Me.dataPane.TabIndex = 8
            ' 
            ' lblDescription
            ' 
            Me.lblDescription.Appearance.FontSizeDelta = 2
            Me.lblDescription.Appearance.Options.UseFont = True
            Me.lblDescription.Appearance.Options.UseTextOptions = True
            Me.lblDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.dataPane.SetColumn(Me.lblDescription, 0)
            Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblDescription.Location = New System.Drawing.Point(0, 67)
            Me.lblDescription.Margin = New System.Windows.Forms.Padding(0)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.dataPane.SetRow(Me.lblDescription, 2)
            Me.lblDescription.Size = New System.Drawing.Size(350, 25)
            Me.lblDescription.TabIndex = 5
            Me.lblDescription.Text = "Description"
            ' 
            ' lblTitle
            ' 
            Me.lblTitle.Appearance.FontSizeDelta = 2
            Me.lblTitle.Appearance.Options.UseFont = True
            Me.lblTitle.Appearance.Options.UseTextOptions = True
            Me.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.dataPane.SetColumn(Me.lblTitle, 0)
            Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 4)
            Me.dataPane.SetRow(Me.lblTitle, 0)
            Me.lblTitle.Size = New System.Drawing.Size(350, 37)
            Me.lblTitle.TabIndex = 4
            Me.lblTitle.Text = "Title"
            ' 
            ' teTitle
            ' 
            Me.dataPane.SetColumn(Me.teTitle, 0)
            Me.teTitle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.todoItemBindingSource, "Title", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.teTitle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.teTitle.Location = New System.Drawing.Point(3, 40)
            Me.teTitle.Name = "teTitle"
            Me.teTitle.Properties.NullValuePrompt = "Enter task title here..."
            Me.teTitle.Properties.ValidateOnEnterKey = True
            Me.dataPane.SetRow(Me.teTitle, 1)
            Me.teTitle.Size = New System.Drawing.Size(344, 24)
            Me.teTitle.TabIndex = 2
            ' 
            ' teDescription
            ' 
            Me.dataPane.SetColumn(Me.teDescription, 0)
            Me.teDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.todoItemBindingSource, "Description", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.teDescription.Dock = System.Windows.Forms.DockStyle.Fill
            Me.teDescription.Location = New System.Drawing.Point(0, 92)
            Me.teDescription.Margin = New System.Windows.Forms.Padding(0)
            Me.teDescription.Name = "teDescription"
            Me.teDescription.Properties.NullValuePrompt = "Enter task description here..."
            Me.teDescription.Properties.ValidateOnEnterKey = True
            Me.dataPane.SetRow(Me.teDescription, 3)
            Me.teDescription.Size = New System.Drawing.Size(350, 276)
            Me.teDescription.TabIndex = 3
            ' 
            ' tglCompleted
            ' 
            Me.footerPane.SetColumn(Me.tglCompleted, 1)
            Me.tglCompleted.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.todoItemBindingSource, "IsCompleted", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.tglCompleted.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tglCompleted.EditValue = True
            Me.tglCompleted.Location = New System.Drawing.Point(202, 8)
            Me.tglCompleted.Margin = New System.Windows.Forms.Padding(0)
            Me.tglCompleted.Name = "tglCompleted"
            Me.tglCompleted.Properties.AllowFocused = False
            Me.tglCompleted.Properties.AutoWidth = True
            Me.tglCompleted.Properties.OffText = " Is Completed"
            Me.tglCompleted.Properties.OnText = " Is Completed"
            Me.footerPane.SetRow(Me.tglCompleted, 0)
            Me.tglCompleted.Size = New System.Drawing.Size(148, 30)
            Me.tglCompleted.TabIndex = 5
            ' 
            ' todoItemBindingSource
            ' 
            Me.todoItemBindingSource.DataSource = GetType(TodoApp.Model.TodoItem)
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(TodoApp.ViewModels.ItemViewModel)
            ' 
            ' ItemView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 17F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dataPane)
            Me.Controls.Add(Me.footerPane)
            Me.Controls.Add(Me.headerPane)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "ItemView"
            Me.Padding = New System.Windows.Forms.Padding(24, 12, 24, 12)
            Me.Size = New System.Drawing.Size(398, 468)
            CType((Me.headerPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.headerPane.ResumeLayout(False)
            Me.headerPane.PerformLayout()
            CType((Me.footerPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.footerPane.ResumeLayout(False)
            Me.footerPane.PerformLayout()
            CType((Me.dataPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataPane.ResumeLayout(False)
            CType((Me.teTitle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teDescription.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tglCompleted.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.todoItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub


#End Region

        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private headerPane As DevExpress.Utils.Layout.TablePanel
        Private btnBack As DevExpress.XtraEditors.SimpleButton
        Private titleLabel As DevExpress.XtraEditors.LabelControl
        Private footerPane As DevExpress.Utils.Layout.TablePanel
        Private btnSave As DevExpress.XtraEditors.SimpleButton
        Private btnDelete As DevExpress.XtraEditors.SimpleButton
        Private dataPane As DevExpress.Utils.Layout.TablePanel
        Private lblDescription As DevExpress.XtraEditors.LabelControl
        Private lblTitle As DevExpress.XtraEditors.LabelControl
        Private teTitle As DevExpress.XtraEditors.TextEdit
        Private teDescription As DevExpress.XtraEditors.MemoEdit
        Private todoItemBindingSource As System.Windows.Forms.BindingSource
        Private tglCompleted As DevExpress.XtraEditors.ToggleSwitch
    End Class
End Namespace
