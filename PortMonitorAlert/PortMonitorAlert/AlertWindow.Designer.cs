namespace PortMonitorAlert
{
    partial class AlertWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertWindow));
            this.ListeningServiceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPAddressesContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListeningSocketTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoteSocketTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcludeListeningSocketButton = new System.Windows.Forms.Button();
            this.eventDateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IPAddressesContainer)).BeginInit();
            this.IPAddressesContainer.Panel1.SuspendLayout();
            this.IPAddressesContainer.Panel2.SuspendLayout();
            this.IPAddressesContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListeningServiceLabel
            // 
            this.ListeningServiceLabel.AutoSize = true;
            this.ListeningServiceLabel.BackColor = System.Drawing.Color.MistyRose;
            this.ListeningServiceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListeningServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ListeningServiceLabel.Location = new System.Drawing.Point(88, 2);
            this.ListeningServiceLabel.Name = "ListeningServiceLabel";
            this.ListeningServiceLabel.Size = new System.Drawing.Size(219, 25);
            this.ListeningServiceLabel.TabIndex = 0;
            this.ListeningServiceLabel.Text = "Local Listening IP/Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(82, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Listening IP/Port:";
            // 
            // IPAddressesContainer
            // 
            this.IPAddressesContainer.BackColor = System.Drawing.Color.Transparent;
            this.IPAddressesContainer.Location = new System.Drawing.Point(12, 114);
            this.IPAddressesContainer.Name = "IPAddressesContainer";
            // 
            // IPAddressesContainer.Panel1
            // 
            this.IPAddressesContainer.Panel1.Controls.Add(this.panel1);
            // 
            // IPAddressesContainer.Panel2
            // 
            this.IPAddressesContainer.Panel2.Controls.Add(this.panel2);
            this.IPAddressesContainer.Size = new System.Drawing.Size(780, 314);
            this.IPAddressesContainer.SplitterDistance = 389;
            this.IPAddressesContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListeningSocketTextBox);
            this.panel1.Controls.Add(this.ListeningServiceLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 314);
            this.panel1.TabIndex = 0;
            // 
            // ListeningSocketTextBox
            // 
            this.ListeningSocketTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ListeningSocketTextBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListeningSocketTextBox.Location = new System.Drawing.Point(3, 30);
            this.ListeningSocketTextBox.MaxLength = 255;
            this.ListeningSocketTextBox.Name = "ListeningSocketTextBox";
            this.ListeningSocketTextBox.ReadOnly = true;
            this.ListeningSocketTextBox.Size = new System.Drawing.Size(383, 46);
            this.ListeningSocketTextBox.TabIndex = 1;
            this.ListeningSocketTextBox.TabStop = false;
            this.ListeningSocketTextBox.Text = "----";
            this.ListeningSocketTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListeningSocketTextBox.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoteSocketTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 314);
            this.panel2.TabIndex = 0;
            // 
            // RemoteSocketTextBox
            // 
            this.RemoteSocketTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RemoteSocketTextBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoteSocketTextBox.Location = new System.Drawing.Point(3, 30);
            this.RemoteSocketTextBox.MaxLength = 255;
            this.RemoteSocketTextBox.Name = "RemoteSocketTextBox";
            this.RemoteSocketTextBox.ReadOnly = true;
            this.RemoteSocketTextBox.Size = new System.Drawing.Size(381, 46);
            this.RemoteSocketTextBox.TabIndex = 2;
            this.RemoteSocketTextBox.TabStop = false;
            this.RemoteSocketTextBox.Text = "----";
            this.RemoteSocketTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RemoteSocketTextBox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(67, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(676, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "⚠️  INTRUSION DETECTED!  ⚠️";
            // 
            // ExcludeListeningSocketButton
            // 
            this.ExcludeListeningSocketButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExcludeListeningSocketButton.Location = new System.Drawing.Point(12, 486);
            this.ExcludeListeningSocketButton.Name = "ExcludeListeningSocketButton";
            this.ExcludeListeningSocketButton.Size = new System.Drawing.Size(193, 47);
            this.ExcludeListeningSocketButton.TabIndex = 4;
            this.ExcludeListeningSocketButton.Text = "Exclude Listening IP/Port";
            this.ExcludeListeningSocketButton.UseVisualStyleBackColor = true;
            this.ExcludeListeningSocketButton.Click += new System.EventHandler(this.ExcludeListeningSocketButton_Click);
            // 
            // eventDateTimeLabel
            // 
            this.eventDateTimeLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.eventDateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eventDateTimeLabel.ForeColor = System.Drawing.Color.White;
            this.eventDateTimeLabel.Location = new System.Drawing.Point(12, 431);
            this.eventDateTimeLabel.Name = "eventDateTimeLabel";
            this.eventDateTimeLabel.Size = new System.Drawing.Size(780, 52);
            this.eventDateTimeLabel.TabIndex = 5;
            this.eventDateTimeLabel.Text = "EventDateTime";
            this.eventDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PortMonitorAlert.Properties.Resources.AlertBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.ControlBox = false;
            this.Controls.Add(this.eventDateTimeLabel);
            this.Controls.Add(this.ExcludeListeningSocketButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPAddressesContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AlertWindow_Load);
            this.IPAddressesContainer.Panel1.ResumeLayout(false);
            this.IPAddressesContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IPAddressesContainer)).EndInit();
            this.IPAddressesContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ListeningServiceLabel;
        private Label label1;
        private SplitContainer IPAddressesContainer;
        private Panel panel1;
        private TextBox ListeningSocketTextBox;
        private Panel panel2;
        private TextBox RemoteSocketTextBox;
        private Label label2;
        private Button ExcludeListeningSocketButton;
        private Label eventDateTimeLabel;
    }
}