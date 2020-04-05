namespace TodoApp.Views {
    partial class ItemsView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SimpleContextButton simpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsView));
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement3 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            this.listBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.toggleShowAll = new DevExpress.XtraEditors.ToggleSwitch();
            this.footerPane = new DevExpress.Utils.Layout.TablePanel();
            this.headerPane = new DevExpress.Utils.Layout.TablePanel();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.todoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleShowAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerPane)).BeginInit();
            this.footerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPane)).BeginInit();
            this.headerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl
            // 
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Near;
            simpleContextButton1.Id = new System.Guid("07615a42-60b8-4284-bc4c-d14067d2e65e");
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = Properties.Resources.Unchecked;
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(32, 32);
            simpleContextButton1.Name = "btnCheck";
            simpleContextButton1.Padding = new System.Windows.Forms.Padding(16);
            this.listBoxControl.ContextButtons.Add(simpleContextButton1);
            this.listBoxControl.DataSource = this.todoItemBindingSource;
            this.listBoxControl.DisplayMember = "Title";
            this.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl.ItemHeight = 48;
            this.listBoxControl.Location = new System.Drawing.Point(24, 74);
            this.listBoxControl.Name = "listBoxControl";
            this.listBoxControl.ShowFocusRect = false;
            this.listBoxControl.Size = new System.Drawing.Size(350, 344);
            this.listBoxControl.TabIndex = 0;
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition1.Length.Value = 48D;
            tableColumnDefinition1.PaddingLeft = 16;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            templatedItemElement1.ColumnIndex = 1;
            templatedItemElement1.FieldName = "Title";
            templatedItemElement1.Text = "Title";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            templatedItemElement2.Appearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            templatedItemElement2.Appearance.Normal.Options.UseForeColor = true;
            templatedItemElement2.ColumnIndex = 1;
            templatedItemElement2.FieldName = "Description";
            templatedItemElement2.RowIndex = 1;
            templatedItemElement2.Text = "Description";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            templatedItemElement3.FieldName = "IsCompleted";
            templatedItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            templatedItemElement3.ImageOptions.SvgImage = Properties.Resources.Checked;
            templatedItemElement3.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            templatedItemElement3.Text = "IsCompleted";
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement3.TextVisible = false;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Elements.Add(templatedItemElement3);
            itemTemplateBase1.Name = "ToDoItem";
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            itemTemplateBase1.Rows.Add(tableRowDefinition2);
            tableSpan1.RowSpan = 2;
            itemTemplateBase1.Spans.Add(tableSpan1);
            this.listBoxControl.Templates.Add(itemTemplateBase1);
            this.listBoxControl.CustomizeContextItem += new DevExpress.XtraEditors.ViewInfo.ListBoxControlContextButtonCustomizeEventHandler(this.ListBoxControl1_CustomizeContextItem);
            this.listBoxControl.CustomizeItem += new DevExpress.XtraEditors.CustomizeTemplatedItemEventHandler(this.listBoxControl1_CustomizeItem);
            // 
            // searchControl
            // 
            this.searchControl.Client = this.listBoxControl;
            this.searchControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchControl.Location = new System.Drawing.Point(24, 50);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Properties.Client = this.listBoxControl;
            this.searchControl.Properties.NullValuePrompt = "Start typing here to search...";
            this.searchControl.Size = new System.Drawing.Size(350, 24);
            this.searchControl.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.FontSizeDelta = 4;
            this.titleLabel.Appearance.Options.UseFont = true;
            this.titleLabel.Appearance.Options.UseTextOptions = true;
            this.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.headerPane.SetColumn(this.titleLabel, 0);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.headerPane.SetRow(this.titleLabel, 0);
            this.titleLabel.Size = new System.Drawing.Size(312, 38);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "{Title}";
            // 
            // toggleShowAll
            // 
            this.footerPane.SetColumn(this.toggleShowAll, 1);
            this.toggleShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleShowAll.EditValue = true;
            this.toggleShowAll.Location = new System.Drawing.Point(194, 8);
            this.toggleShowAll.Margin = new System.Windows.Forms.Padding(0);
            this.toggleShowAll.Name = "toggleShowAll";
            this.toggleShowAll.Properties.AllowFocused = false;
            this.toggleShowAll.Properties.AutoWidth = true;
            this.toggleShowAll.Properties.OffText = " Show All Tasks";
            this.toggleShowAll.Properties.OnText = " Show All Tasks";
            this.footerPane.SetRow(this.toggleShowAll, 0);
            this.toggleShowAll.Size = new System.Drawing.Size(156, 30);
            this.toggleShowAll.TabIndex = 3;
            // 
            // footerPane
            // 
            this.footerPane.AutoSize = true;
            this.footerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.footerPane.Controls.Add(this.toggleShowAll);
            this.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPane.Location = new System.Drawing.Point(24, 418);
            this.footerPane.Margin = new System.Windows.Forms.Padding(0);
            this.footerPane.Name = "footerPane";
            this.footerPane.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.footerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.footerPane.Size = new System.Drawing.Size(350, 38);
            this.footerPane.TabIndex = 4;
            // 
            // headerPane
            // 
            this.headerPane.AutoSize = true;
            this.headerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.headerPane.Controls.Add(this.btnNew);
            this.headerPane.Controls.Add(this.titleLabel);
            this.headerPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPane.Location = new System.Drawing.Point(24, 12);
            this.headerPane.Margin = new System.Windows.Forms.Padding(0);
            this.headerPane.Name = "headerPane";
            this.headerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.headerPane.Size = new System.Drawing.Size(350, 38);
            this.headerPane.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.AllowFocus = false;
            this.btnNew.AutoSize = true;
            this.headerPane.SetColumn(this.btnNew, 1);
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.ImageOptions.SvgImage = Properties.Resources.New;
            this.btnNew.Location = new System.Drawing.Point(312, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.headerPane.SetRow(this.btnNew, 0);
            this.btnNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnNew.Size = new System.Drawing.Size(38, 38);
            this.btnNew.TabIndex = 3;
            // 
            // todoItemBindingSource
            // 
            this.todoItemBindingSource.DataSource = typeof(TodoApp.Model.TodoItem);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(TodoApp.ViewModels.ItemsViewModel);
            // 
            // ItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.listBoxControl);
            this.Controls.Add(this.searchControl);
            this.Controls.Add(this.headerPane);
            this.Controls.Add(this.footerPane);
            this.Name = "ItemsView";
            this.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.Size = new System.Drawing.Size(398, 468);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleShowAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerPane)).EndInit();
            this.footerPane.ResumeLayout(false);
            this.footerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPane)).EndInit();
            this.headerPane.ResumeLayout(false);
            this.headerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl;
        private DevExpress.XtraEditors.SearchControl searchControl;
        private System.Windows.Forms.BindingSource todoItemBindingSource;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraEditors.ToggleSwitch toggleShowAll;
        private DevExpress.Utils.Layout.TablePanel footerPane;
        private DevExpress.Utils.Layout.TablePanel headerPane;
        private DevExpress.XtraEditors.SimpleButton btnNew;
    }
}
