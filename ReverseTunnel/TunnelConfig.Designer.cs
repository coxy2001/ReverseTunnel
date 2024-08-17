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
			this.buttonApply = new System.Windows.Forms.Button();
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericSshPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRemotePort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLocalPort)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(11, 413);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(226, 23);
			this.buttonApply.TabIndex = 9;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// textBoxSshHost
			// 
			this.textBoxSshHost.Location = new System.Drawing.Point(6, 38);
			this.textBoxSshHost.Name = "textBoxSshHost";
			this.textBoxSshHost.Size = new System.Drawing.Size(133, 20);
			this.textBoxSshHost.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "SSH Host:";
			// 
			// textBoxSshUsername
			// 
			this.textBoxSshUsername.Location = new System.Drawing.Point(6, 77);
			this.textBoxSshUsername.Name = "textBoxSshUsername";
			this.textBoxSshUsername.Size = new System.Drawing.Size(214, 20);
			this.textBoxSshUsername.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "SSH Username:";
			// 
			// textBoxSshPassword
			// 
			this.textBoxSshPassword.Location = new System.Drawing.Point(6, 116);
			this.textBoxSshPassword.Name = "textBoxSshPassword";
			this.textBoxSshPassword.Size = new System.Drawing.Size(214, 20);
			this.textBoxSshPassword.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "SSH Password:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Remote Port:";
			// 
			// textBoxLocalAddress
			// 
			this.textBoxLocalAddress.Location = new System.Drawing.Point(6, 146);
			this.textBoxLocalAddress.Name = "textBoxLocalAddress";
			this.textBoxLocalAddress.Size = new System.Drawing.Size(130, 20);
			this.textBoxLocalAddress.TabIndex = 6;
			this.textBoxLocalAddress.Text = "127.0.0.1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Local Address:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(141, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Local Port:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(142, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "SSH Port:";
			// 
			// numericSshPort
			// 
			this.numericSshPort.Location = new System.Drawing.Point(145, 38);
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
			this.numericSshPort.Size = new System.Drawing.Size(75, 20);
			this.numericSshPort.TabIndex = 2;
			this.numericSshPort.Value = new decimal(new int[] {
			22,
			0,
			0,
			0});
			// 
			// numericRemotePort
			// 
			this.numericRemotePort.Location = new System.Drawing.Point(6, 185);
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
			this.numericRemotePort.Size = new System.Drawing.Size(214, 20);
			this.numericRemotePort.TabIndex = 5;
			this.numericRemotePort.Value = new decimal(new int[] {
			80,
			0,
			0,
			0});
			// 
			// numericLocalPort
			// 
			this.numericLocalPort.Location = new System.Drawing.Point(142, 146);
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
			this.numericLocalPort.Size = new System.Drawing.Size(78, 20);
			this.numericLocalPort.TabIndex = 7;
			this.numericLocalPort.Value = new decimal(new int[] {
			80,
			0,
			0,
			0});
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(6, 19);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(214, 108);
			this.listBox1.TabIndex = 11;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxSshHost);
			this.groupBox1.Controls.Add(this.textBoxSshUsername);
			this.groupBox1.Controls.Add(this.textBoxSshPassword);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.numericSshPort);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(226, 148);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Specify the server to connect to";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonSave);
			this.groupBox2.Controls.Add(this.buttonDelete);
			this.groupBox2.Controls.Add(this.buttonNew);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.listBox1);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.numericRemotePort);
			this.groupBox2.Controls.Add(this.numericLocalPort);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBoxLocalAddress);
			this.groupBox2.Location = new System.Drawing.Point(12, 166);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(226, 241);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add a port forward";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(153, 211);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(67, 23);
			this.buttonDelete.TabIndex = 15;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(80, 211);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(67, 23);
			this.buttonNew.TabIndex = 14;
			this.buttonNew.Text = "New";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(6, 211);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(67, 23);
			this.buttonSave.TabIndex = 16;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// TunnelConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 449);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonApply);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "TunnelConfig";
			this.Text = "Reverse Tunnel";
			((System.ComponentModel.ISupportInitialize)(this.numericSshPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRemotePort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLocalPort)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonApply;
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
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonSave;
	}
}

