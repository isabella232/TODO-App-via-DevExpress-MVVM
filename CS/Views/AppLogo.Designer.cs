namespace TodoApp.Views {
    partial class AppLogo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLogo));
            this.greetLabel = new DevExpress.XtraEditors.LabelControl();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // greetLabel
            // 
            this.greetLabel.AllowHtmlString = true;
            this.greetLabel.Appearance.Options.UseTextOptions = true;
            this.greetLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.greetLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.greetLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.greetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greetLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.greetLabel.ImageOptions.SvgImage = Properties.Resources.Logo;
            this.greetLabel.ImageOptions.SvgImageSize = new System.Drawing.Size(128, 128);
            this.greetLabel.IndentBetweenImageAndText = 64;
            this.greetLabel.Location = new System.Drawing.Point(0, 0);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 200);
            this.greetLabel.Size = new System.Drawing.Size(398, 468);
            this.greetLabel.TabIndex = 0;
            this.greetLabel.Text = "{Greeting}";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(TodoApp.ViewModels.AppLogoViewModel);
            // 
            // AppLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.greetLabel);
            this.Name = "AppLogo";
            this.Size = new System.Drawing.Size(398, 468);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl greetLabel;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
    }
}
