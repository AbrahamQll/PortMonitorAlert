namespace PortMonitorAlert
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MonitoringIsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.MonitoringConnectionsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MonitoringIsActiveCheckBox
            // 
            this.MonitoringIsActiveCheckBox.AutoSize = true;
            this.MonitoringIsActiveCheckBox.Location = new System.Drawing.Point(12, 12);
            this.MonitoringIsActiveCheckBox.Name = "MonitoringIsActiveCheckBox";
            this.MonitoringIsActiveCheckBox.Size = new System.Drawing.Size(137, 19);
            this.MonitoringIsActiveCheckBox.TabIndex = 0;
            this.MonitoringIsActiveCheckBox.Text = "Monitor Port Activity";
            this.MonitoringIsActiveCheckBox.UseVisualStyleBackColor = true;
            this.MonitoringIsActiveCheckBox.CheckedChanged += new System.EventHandler(this.MonitoringIsActiveCheckBox_CheckedChanged);
            // 
            // MonitoringConnectionsTextBox
            // 
            this.MonitoringConnectionsTextBox.Location = new System.Drawing.Point(155, 12);
            this.MonitoringConnectionsTextBox.Multiline = true;
            this.MonitoringConnectionsTextBox.Name = "MonitoringConnectionsTextBox";
            this.MonitoringConnectionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MonitoringConnectionsTextBox.Size = new System.Drawing.Size(1060, 318);
            this.MonitoringConnectionsTextBox.TabIndex = 1;
            this.MonitoringConnectionsTextBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 339);
            this.Controls.Add(this.MonitoringConnectionsTextBox);
            this.Controls.Add(this.MonitoringIsActiveCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Port Monitor Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox MonitoringIsActiveCheckBox;
        private TextBox MonitoringConnectionsTextBox;
    }
}