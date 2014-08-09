namespace TwitchUi
{
    partial class DownloadWindow
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
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ChannelNamesTextBox = new System.Windows.Forms.TextBox();
            this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1 = new System.Windows.Forms.Label();
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411 = new System.Windows.Forms.Label();
            this.BroadcastIdsTextBox = new System.Windows.Forms.TextBox();
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576 = new System.Windows.Forms.Label();
            this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340 = new System.Windows.Forms.Label();
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301 = new System.Windows.Forms.Label();
            this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(12, 189);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(479, 23);
            this.DestinationTextBox.TabIndex = 30;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(497, 189);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 40;
            this.BrowseButton.Text = "Br&owse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButtonHandler);
            // 
            // ChannelNamesTextBox
            // 
            this.ChannelNamesTextBox.Location = new System.Drawing.Point(12, 45);
            this.ChannelNamesTextBox.Multiline = true;
            this.ChannelNamesTextBox.Name = "ChannelNamesTextBox";
            this.ChannelNamesTextBox.Size = new System.Drawing.Size(275, 70);
            this.ChannelNamesTextBox.TabIndex = 10;
            this.ChannelNamesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDownHandler);
            // 
            // __astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1
            // 
            this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1.AutoSize = true;
            this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1.Location = new System.Drawing.Point(49, 9);
            this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1.Name = "__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1";
            this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1.Size = new System.Drawing.Size(475, 28);
            this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1.TabIndex = 3;
            this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1.Text = "Which streamers or broadcasts should we download?";
            // 
            // __astralfoxy__generated__094ef7a79649ad1db1e71880af22b411
            // 
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.Location = new System.Drawing.Point(12, 9);
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.Name = "__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411";
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.Size = new System.Drawing.Size(35, 33);
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.TabIndex = 4;
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.Text = "1";
            this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BroadcastIdsTextBox
            // 
            this.BroadcastIdsTextBox.Location = new System.Drawing.Point(297, 45);
            this.BroadcastIdsTextBox.Multiline = true;
            this.BroadcastIdsTextBox.Name = "BroadcastIdsTextBox";
            this.BroadcastIdsTextBox.Size = new System.Drawing.Size(275, 70);
            this.BroadcastIdsTextBox.TabIndex = 20;
            this.BroadcastIdsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDownHandler);
            // 
            // __astralfoxy__generated__65890ae95cf3678d8366b83539810576
            // 
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.Location = new System.Drawing.Point(12, 153);
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.Name = "__astralfoxy__generated__65890ae95cf3678d8366b83539810576";
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.Size = new System.Drawing.Size(35, 33);
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.TabIndex = 7;
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.Text = "2";
            this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // __astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340
            // 
            this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340.AutoSize = true;
            this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340.Location = new System.Drawing.Point(49, 153);
            this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340.Name = "__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340";
            this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340.Size = new System.Drawing.Size(256, 28);
            this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340.TabIndex = 6;
            this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340.Text = "Where should we put them?";
            // 
            // __astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301
            // 
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.Location = new System.Drawing.Point(12, 235);
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.Name = "__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301";
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.Size = new System.Drawing.Size(35, 33);
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.TabIndex = 9;
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.Text = "3";
            this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // __astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a
            // 
            this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a.AutoSize = true;
            this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a.Location = new System.Drawing.Point(49, 235);
            this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a.Name = "__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a";
            this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a.Size = new System.Drawing.Size(44, 28);
            this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a.TabIndex = 8;
            this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a.Text = "Go!";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 271);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(560, 30);
            this.StartButton.TabIndex = 50;
            this.StartButton.Text = "St&art Downloading";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartDownloadsHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(14, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "channel names, one on each line (eg, astralfoxy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(294, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "broadcast ids, one on each line (eg, 555803111)";
            // 
            // DownloadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.@__astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301);
            this.Controls.Add(this.@__astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a);
            this.Controls.Add(this.@__astralfoxy__generated__65890ae95cf3678d8366b83539810576);
            this.Controls.Add(this.@__astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340);
            this.Controls.Add(this.BroadcastIdsTextBox);
            this.Controls.Add(this.@__astralfoxy__generated__094ef7a79649ad1db1e71880af22b411);
            this.Controls.Add(this.@__astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1);
            this.Controls.Add(this.ChannelNamesTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.DestinationTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitch Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox ChannelNamesTextBox;
        private System.Windows.Forms.Label __astralfoxy__generated__2e5bdbe8e8561df8e65f55fdf6bcd4c1;
        private System.Windows.Forms.Label __astralfoxy__generated__094ef7a79649ad1db1e71880af22b411;
        private System.Windows.Forms.TextBox BroadcastIdsTextBox;
        private System.Windows.Forms.Label __astralfoxy__generated__65890ae95cf3678d8366b83539810576;
        private System.Windows.Forms.Label __astralfoxy__generated__4d3d2a508f47ee1607dcc2d06df6e340;
        private System.Windows.Forms.Label __astralfoxy__generated__61e60d862b4671298a89c2eb79cb0301;
        private System.Windows.Forms.Label __astralfoxy__generated__69c9fcc3c056d619c3d63f4538c1ff5a;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

