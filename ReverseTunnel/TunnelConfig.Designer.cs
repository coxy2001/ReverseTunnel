namespace ReverseTunnel
{
	partial class TunnelConfig
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
			this.buttonToggleConnection = new System.Windows.Forms.Button();
			this.textBoxSshHost = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSshUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxSshPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxLocalAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.numericSshPort = new System.Windows.Forms.NumericUpDown();
			this.numericRemotePort = new System.Windows.Forms.NumericUpDown();
			this.numericLocalPort = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericSshPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRemotePort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLocalPort)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonToggleConnection
			// 
			this.buttonToggleConnection.Location = new System.Drawing.Point(14, 194);
			this.buttonToggleConnection.Name = "buttonToggleConnection";
			this.buttonToggleConnection.Size = new System.Drawing.Size(299, 23);
			this.buttonToggleConnection.TabIndex = 9;
			this.buttonToggleConnection.Text = "Apply";
			this.buttonToggleConnection.UseVisualStyleBackColor = true;
			this.buttonToggleConnection.Click += new System.EventHandler(this.buttonToggleConnection_Click);
			// 
			// textBoxSshHost
			// 
			this.textBoxSshHost.Location = new System.Drawing.Point(110, 12);
			this.textBoxSshHost.Name = "textBoxSshHost";
			this.textBoxSshHost.Size = new System.Drawing.Size(203, 20);
			this.textBoxSshHost.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "SSH Host:";
			// 
			// textBoxSshUsername
			// 
			this.textBoxSshUsername.Location = new System.Drawing.Point(110, 64);
			this.textBoxSshUsername.Name = "textBoxSshUsername";
			this.textBoxSshUsername.Size = new System.Drawing.Size(203, 20);
			this.textBoxSshUsername.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "SSH Username:";
			// 
			// textBoxSshPassword
			// 
			this.textBoxSshPassword.Location = new System.Drawing.Point(110, 90);
			this.textBoxSshPassword.Name = "textBoxSshPassword";
			this.textBoxSshPassword.Size = new System.Drawing.Size(203, 20);
			this.textBoxSshPassword.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "SSH Password:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Remote Port:";
			// 
			// textBoxLocalAddress
			// 
			this.textBoxLocalAddress.Location = new System.Drawing.Point(110, 142);
			this.textBoxLocalAddress.Name = "textBoxLocalAddress";
			this.textBoxLocalAddress.Size = new System.Drawing.Size(203, 20);
			this.textBoxLocalAddress.TabIndex = 6;
			this.textBoxLocalAddress.Text = "127.0.0.1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Local Address:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Local Port:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 41);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "SSH Port:";
			// 
			// numericSshPort
			// 
			this.numericSshPort.Location = new System.Drawing.Point(110, 38);
			this.numericSshPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericSshPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericSshPort.Name = "numericSshPort";
			this.numericSshPort.Size = new System.Drawing.Size(203, 20);
			this.numericSshPort.TabIndex = 2;
			this.numericSshPort.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
			// 
			// numericRemotePort
			// 
			this.numericRemotePort.Location = new System.Drawing.Point(110, 116);
			this.numericRemotePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericRemotePort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericRemotePort.Name = "numericRemotePort";
			this.numericRemotePort.Size = new System.Drawing.Size(203, 20);
			this.numericRemotePort.TabIndex = 5;
			this.numericRemotePort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			// 
			// numericLocalPort
			// 
			this.numericLocalPort.Location = new System.Drawing.Point(110, 168);
			this.numericLocalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericLocalPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericLocalPort.Name = "numericLocalPort";
			this.numericLocalPort.Size = new System.Drawing.Size(203, 20);
			this.numericLocalPort.TabIndex = 7;
			this.numericLocalPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			// 
			// TunnelConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 226);
			this.Controls.Add(this.numericLocalPort);
			this.Controls.Add(this.numericRemotePort);
			this.Controls.Add(this.numericSshPort);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxLocalAddress);
			this.Controls.Add(this.textBoxSshPassword);
			this.Controls.Add(this.textBoxSshUsername);
			this.Controls.Add(this.textBoxSshHost);
			this.Controls.Add(this.buttonToggleConnection);
			this.MinimumSize = new System.Drawing.Size(344, 265);
			this.Name = "TunnelConfig";
			this.Text = "Reverse Tunnel";
			((System.ComponentModel.ISupportInitialize)(this.numericSshPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRemotePort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLocalPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonToggleConnection;
		private System.Windows.Forms.TextBox textBoxSshHost;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSshUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxSshPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxLocalAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericSshPort;
		private System.Windows.Forms.NumericUpDown numericRemotePort;
		private System.Windows.Forms.NumericUpDown numericLocalPort;
	}
}

