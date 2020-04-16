Namespace TodoApp.Views
    Partial Class ItemsView
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
            Dim simpleContextButton1 As DevExpress.Utils.SimpleContextButton = New DevExpress.Utils.SimpleContextButton()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodoApp.Views.ItemsView))
            Dim itemTemplateBase1 As DevExpress.XtraEditors.TableLayout.ItemTemplateBase = New DevExpress.XtraEditors.TableLayout.ItemTemplateBase()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim templatedItemElement1 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement2 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement3 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Me.listBoxControl = New DevExpress.XtraEditors.ListBoxControl()
            Me.searchControl = New DevExpress.XtraEditors.SearchControl()
            Me.titleLabel = New DevExpress.XtraEditors.LabelControl()
            Me.toggleShowAll = New DevExpress.XtraEditors.ToggleSwitch()
            Me.footerPane = New DevExpress.Utils.Layout.TablePanel()
            Me.headerPane = New DevExpress.Utils.Layout.TablePanel()
            Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
            Me.todoItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType((Me.listBoxControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toggleShowAll.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.footerPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.footerPane.SuspendLayout()
            CType((Me.headerPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.headerPane.SuspendLayout()
            CType((Me.todoItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' listBoxControl
            ' 
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Near
            simpleContextButton1.Id = New System.Guid("07615a42-60b8-4284-bc4c-d14067d2e65e")
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = Global.Resources.Unchecked
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = New System.Drawing.Size(32, 32)
            simpleContextButton1.Name = "btnCheck"
            simpleContextButton1.Padding = New System.Windows.Forms.Padding(16)
            Me.listBoxControl.ContextButtons.Add(simpleContextButton1)
            Me.listBoxControl.DataSource = Me.todoItemBindingSource
            Me.listBoxControl.DisplayMember = "Title"
            Me.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl.ItemHeight = 48
            Me.listBoxControl.Location = New System.Drawing.Point(24, 74)
            Me.listBoxControl.Name = "listBoxControl"
            Me.listBoxControl.ShowFocusRect = False
            Me.listBoxControl.Size = New System.Drawing.Size(350, 344)
            Me.listBoxControl.TabIndex = 0
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition1.Length.Value = 48R
            tableColumnDefinition1.PaddingLeft = 16
            itemTemplateBase1.Columns.Add(tableColumnDefinition1)
            itemTemplateBase1.Columns.Add(tableColumnDefinition2)
            templatedItemElement1.ColumnIndex = 1
            templatedItemElement1.FieldName = "Title"
            templatedItemElement1.Text = "Title"
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
            templatedItemElement2.Appearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText
            templatedItemElement2.Appearance.Normal.Options.UseForeColor = True
            templatedItemElement2.ColumnIndex = 1
            templatedItemElement2.FieldName = "Description"
            templatedItemElement2.RowIndex = 1
            templatedItemElement2.Text = "Description"
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            templatedItemElement3.FieldName = "IsCompleted"
            templatedItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale
            templatedItemElement3.ImageOptions.SvgImage = Global.Resources.Checked
            templatedItemElement3.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
            templatedItemElement3.Text = "IsCompleted"
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement3.TextVisible = False
            itemTemplateBase1.Elements.Add(templatedItemElement1)
            itemTemplateBase1.Elements.Add(templatedItemElement2)
            itemTemplateBase1.Elements.Add(templatedItemElement3)
            itemTemplateBase1.Name = "ToDoItem"
            itemTemplateBase1.Rows.Add(tableRowDefinition1)
            itemTemplateBase1.Rows.Add(tableRowDefinition2)
            tableSpan1.RowSpan = 2
            itemTemplateBase1.Spans.Add(tableSpan1)
            Me.listBoxControl.Templates.Add(itemTemplateBase1)
            AddHandler Me.listBoxControl.CustomizeContextItem, New DevExpress.XtraEditors.ViewInfo.ListBoxControlContextButtonCustomizeEventHandler(AddressOf Me.ListBoxControl1_CustomizeContextItem)
            AddHandler Me.listBoxControl.CustomizeItem, New DevExpress.XtraEditors.CustomizeTemplatedItemEventHandler(AddressOf Me.listBoxControl1_CustomizeItem)
            ' 
            ' searchControl
            ' 
            Me.searchControl.Client = Me.listBoxControl
            Me.searchControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.searchControl.Location = New System.Drawing.Point(24, 50)
            Me.searchControl.Name = "searchControl"
            Me.searchControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.searchControl.Properties.Client = Me.listBoxControl
            Me.searchControl.Properties.NullValuePrompt = "Start typing here to search..."
            Me.searchControl.Size = New System.Drawing.Size(350, 24)
            Me.searchControl.TabIndex = 1
            ' 
            ' titleLabel
            ' 
            Me.titleLabel.Appearance.FontSizeDelta = 4
            Me.titleLabel.Appearance.Options.UseFont = True
            Me.titleLabel.Appearance.Options.UseTextOptions = True
            Me.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.headerPane.SetColumn(Me.titleLabel, 0)
            Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.titleLabel.Location = New System.Drawing.Point(0, 0)
            Me.titleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.titleLabel.Name = "titleLabel"
            Me.headerPane.SetRow(Me.titleLabel, 0)
            Me.titleLabel.Size = New System.Drawing.Size(312, 38)
            Me.titleLabel.TabIndex = 2
            Me.titleLabel.Text = "{Title}"
            ' 
            ' toggleShowAll
            ' 
            Me.footerPane.SetColumn(Me.toggleShowAll, 1)
            Me.toggleShowAll.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toggleShowAll.EditValue = True
            Me.toggleShowAll.Location = New System.Drawing.Point(194, 8)
            Me.toggleShowAll.Margin = New System.Windows.Forms.Padding(0)
            Me.toggleShowAll.Name = "toggleShowAll"
            Me.toggleShowAll.Properties.AllowFocused = False
            Me.toggleShowAll.Properties.AutoWidth = True
            Me.toggleShowAll.Properties.OffText = " Show All Tasks"
            Me.toggleShowAll.Properties.OnText = " Show All Tasks"
            Me.footerPane.SetRow(Me.toggleShowAll, 0)
            Me.toggleShowAll.Size = New System.Drawing.Size(156, 30)
            Me.toggleShowAll.TabIndex = 3
            ' 
            ' footerPane
            ' 
            Me.footerPane.AutoSize = True
            Me.footerPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.footerPane.Controls.Add(Me.toggleShowAll)
            Me.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.footerPane.Location = New System.Drawing.Point(24, 418)
            Me.footerPane.Margin = New System.Windows.Forms.Padding(0)
            Me.footerPane.Name = "footerPane"
            Me.footerPane.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
            Me.footerPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.footerPane.Size = New System.Drawing.Size(350, 38)
            Me.footerPane.TabIndex = 4
            ' 
            ' headerPane
            ' 
            Me.headerPane.AutoSize = True
            Me.headerPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.headerPane.Controls.Add(Me.btnNew)
            Me.headerPane.Controls.Add(Me.titleLabel)
            Me.headerPane.Dock = System.Windows.Forms.DockStyle.Top
            Me.headerPane.Location = New System.Drawing.Point(24, 12)
            Me.headerPane.Margin = New System.Windows.Forms.Padding(0)
            Me.headerPane.Name = "headerPane"
            Me.headerPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.headerPane.Size = New System.Drawing.Size(350, 38)
            Me.headerPane.TabIndex = 5
            ' 
            ' btnNew
            ' 
            Me.btnNew.AllowFocus = False
            Me.btnNew.AutoSize = True
            Me.headerPane.SetColumn(Me.btnNew, 1)
            Me.btnNew.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnNew.ImageOptions.SvgImage = Global.Resources._New
            Me.btnNew.Location = New System.Drawing.Point(312, 0)
            Me.btnNew.Margin = New System.Windows.Forms.Padding(0)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.headerPane.SetRow(Me.btnNew, 0)
            Me.btnNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnNew.Size = New System.Drawing.Size(38, 38)
            Me.btnNew.TabIndex = 3
            ' 
            ' todoItemBindingSource
            ' 
            Me.todoItemBindingSource.DataSource = GetType(TodoApp.Model.TodoItem)
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(TodoApp.ViewModels.ItemsViewModel)
            ' 
            ' ItemsView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.listBoxControl)
            Me.Controls.Add(Me.searchControl)
            Me.Controls.Add(Me.headerPane)
            Me.Controls.Add(Me.footerPane)
            Me.Name = "ItemsView"
            Me.Padding = New System.Windows.Forms.Padding(24, 12, 24, 12)
            Me.Size = New System.Drawing.Size(398, 468)
            CType((Me.listBoxControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toggleShowAll.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.footerPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.footerPane.ResumeLayout(False)
            Me.footerPane.PerformLayout()
            CType((Me.headerPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.headerPane.ResumeLayout(False)
            Me.headerPane.PerformLayout()
            CType((Me.todoItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region

        Private listBoxControl As DevExpress.XtraEditors.ListBoxControl
        Private searchControl As DevExpress.XtraEditors.SearchControl
        Private todoItemBindingSource As System.Windows.Forms.BindingSource
        Private titleLabel As DevExpress.XtraEditors.LabelControl
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private toggleShowAll As DevExpress.XtraEditors.ToggleSwitch
        Private footerPane As DevExpress.Utils.Layout.TablePanel
        Private headerPane As DevExpress.Utils.Layout.TablePanel
        Private btnNew As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
