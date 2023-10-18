namespace MySQLSPGenerator
{
    partial class Form1
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
            navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)navigationPane1).BeginInit();
            navigationPane1.SuspendLayout();
            SuspendLayout();
            // 
            // navigationPane1
            // 
            navigationPane1.Controls.Add(navigationPage1);
            navigationPane1.Controls.Add(navigationPage2);
            navigationPane1.Controls.Add(navigationPage3);
            navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            navigationPane1.Location = new System.Drawing.Point(0, 0);
            navigationPane1.Name = "navigationPane1";
            navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { navigationPage3, navigationPage1, navigationPage2 });
            navigationPane1.RegularSize = new System.Drawing.Size(2013, 1100);
            navigationPane1.SelectedPage = navigationPage1;
            navigationPane1.Size = new System.Drawing.Size(2013, 1100);
            navigationPane1.TabIndex = 0;
            navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            navigationPage1.Caption = "Variable Fragen";
            navigationPage1.Name = "navigationPage1";
            navigationPage1.Size = new System.Drawing.Size(1789, 991);
            // 
            // navigationPage2
            // 
            navigationPage2.Caption = "Besuchsmeldung";
            navigationPage2.Name = "navigationPage2";
            navigationPage2.Size = new System.Drawing.Size(1789, 991);
            // 
            // navigationPage3
            // 
            navigationPage3.Caption = "Projekteinstellungen";
            navigationPage3.Name = "navigationPage3";
            navigationPage3.Size = new System.Drawing.Size(1789, 991);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2013, 1100);
            Controls.Add(navigationPane1);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "MySQL SP Generator";
            ((System.ComponentModel.ISupportInitialize)navigationPane1).EndInit();
            navigationPane1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
    }
}

