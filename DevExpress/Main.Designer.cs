namespace DevExpress
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlHome,
            this.accordionControlSeparator1,
            this.accordionControlSettings});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(260, 487);
            this.accordionControl1.TabIndex = 0;
            // 
            // accordionControlHome
            // 
            this.accordionControlHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlHome.ImageOptions.SvgImage")));
            this.accordionControlHome.Name = "accordionControlHome";
            this.accordionControlHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlHome.Text = "Home";
            this.accordionControlHome.Click += new System.EventHandler(this.accordionControlHome_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlSettings
            // 
            this.accordionControlSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlSettings.ImageOptions.SvgImage")));
            this.accordionControlSettings.Name = "accordionControlSettings";
            this.accordionControlSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSettings.Text = "Settings";
            this.accordionControlSettings.Click += new System.EventHandler(this.accordionControlSettings_Click);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Controls.Add(this.navigationPage2);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(260, 0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame.SelectedPage = this.navigationPage1;
            this.navigationFrame.Size = new System.Drawing.Size(567, 487);
            this.navigationFrame.TabIndex = 1;
            this.navigationFrame.Text = "navigationFrame1";
            this.navigationFrame.TransitionAnimationProperties.FrameCount = 0;
            this.navigationFrame.TransitionAnimationProperties.FrameInterval = 0;
            this.navigationFrame.TransitionType = DevExpress.Utils.Animation.Transitions.Cover;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.gridControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(567, 487);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(155, 275);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.radioButton2);
            this.navigationPage2.Controls.Add(this.radioButton1);
            this.navigationPage2.Controls.Add(this.radioGroup1);
            this.navigationPage2.Controls.Add(this.trackBarControl1);
            this.navigationPage2.Controls.Add(this.checkEdit1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(567, 487);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(42, 284);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 261);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(18, 243);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(263, 118);
            this.radioGroup1.TabIndex = 3;
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = null;
            this.trackBarControl1.Location = new System.Drawing.Point(166, 177);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarControl1.Size = new System.Drawing.Size(104, 45);
            this.trackBarControl1.TabIndex = 2;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(54, 68);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(75, 20);
            this.checkEdit1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 487);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "Main";
            this.Text = "ReList";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.AccordionControl accordionControl1;
        private XtraBars.Navigation.NavigationFrame navigationFrame;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraBars.Navigation.NavigationPage navigationPage2;
        private XtraBars.Navigation.AccordionControlElement accordionControlHome;
        private XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private XtraBars.Navigation.AccordionControlElement accordionControlSettings;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Grid.GridView gridView1;
        private XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private XtraEditors.RadioGroup radioGroup1;
        private XtraEditors.TrackBarControl trackBarControl1;
    }
}