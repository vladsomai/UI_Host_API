
namespace UI_Host_API
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.IncrementCounterButton = new System.Windows.Forms.Button();
            this.setTemperatureButton = new System.Windows.Forms.Button();
            this.updateContactsButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.adapterCode_TextBox1 = new System.Windows.Forms.TextBox();
            this.adapterType_TextBox1 = new System.Windows.Forms.TextBox();
            this.adapterCode_TextBox2 = new System.Windows.Forms.TextBox();
            this.adapterCode_TextBox3 = new System.Windows.Forms.TextBox();
            this.adapterType_TextBox2 = new System.Windows.Forms.TextBox();
            this.adapterType_TextBox3 = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.contactsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IP_Textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DB_UserTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DB_PasswordTextboxx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 254);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(776, 171);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "";
            // 
            // IncrementCounterButton
            // 
            this.IncrementCounterButton.BackColor = System.Drawing.SystemColors.Control;
            this.IncrementCounterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncrementCounterButton.Location = new System.Drawing.Point(635, 105);
            this.IncrementCounterButton.Name = "IncrementCounterButton";
            this.IncrementCounterButton.Size = new System.Drawing.Size(131, 23);
            this.IncrementCounterButton.TabIndex = 1;
            this.IncrementCounterButton.Text = "Increment counter";
            this.IncrementCounterButton.UseVisualStyleBackColor = false;
            this.IncrementCounterButton.Click += new System.EventHandler(this.IncrementCounterButton_Click);
            // 
            // setTemperatureButton
            // 
            this.setTemperatureButton.BackColor = System.Drawing.SystemColors.Control;
            this.setTemperatureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setTemperatureButton.Location = new System.Drawing.Point(635, 162);
            this.setTemperatureButton.Name = "setTemperatureButton";
            this.setTemperatureButton.Size = new System.Drawing.Size(131, 23);
            this.setTemperatureButton.TabIndex = 2;
            this.setTemperatureButton.Text = "Set temperature";
            this.setTemperatureButton.UseVisualStyleBackColor = false;
            this.setTemperatureButton.Click += new System.EventHandler(this.setTemperatureButton_Click);
            // 
            // updateContactsButton
            // 
            this.updateContactsButton.BackColor = System.Drawing.SystemColors.Control;
            this.updateContactsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateContactsButton.Location = new System.Drawing.Point(635, 219);
            this.updateContactsButton.Name = "updateContactsButton";
            this.updateContactsButton.Size = new System.Drawing.Size(131, 23);
            this.updateContactsButton.TabIndex = 3;
            this.updateContactsButton.Text = "Update contacts";
            this.updateContactsButton.UseVisualStyleBackColor = false;
            this.updateContactsButton.Click += new System.EventHandler(this.updateContactsButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.LimeGreen;
            this.ConnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectButton.Location = new System.Drawing.Point(560, 38);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(82, 23);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.BackColor = System.Drawing.Color.Coral;
            this.DisconnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectButton.Location = new System.Drawing.Point(684, 39);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(82, 23);
            this.DisconnectButton.TabIndex = 6;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // adapterCode_TextBox1
            // 
            this.adapterCode_TextBox1.Location = new System.Drawing.Point(26, 105);
            this.adapterCode_TextBox1.Name = "adapterCode_TextBox1";
            this.adapterCode_TextBox1.Size = new System.Drawing.Size(131, 20);
            this.adapterCode_TextBox1.TabIndex = 7;
            this.adapterCode_TextBox1.Text = "104";
            // 
            // adapterType_TextBox1
            // 
            this.adapterType_TextBox1.Location = new System.Drawing.Point(203, 105);
            this.adapterType_TextBox1.Name = "adapterType_TextBox1";
            this.adapterType_TextBox1.Size = new System.Drawing.Size(131, 20);
            this.adapterType_TextBox1.TabIndex = 8;
            this.adapterType_TextBox1.Text = "FCT";
            // 
            // adapterCode_TextBox2
            // 
            this.adapterCode_TextBox2.Location = new System.Drawing.Point(26, 165);
            this.adapterCode_TextBox2.Name = "adapterCode_TextBox2";
            this.adapterCode_TextBox2.Size = new System.Drawing.Size(131, 20);
            this.adapterCode_TextBox2.TabIndex = 9;
            this.adapterCode_TextBox2.Text = "104";
            // 
            // adapterCode_TextBox3
            // 
            this.adapterCode_TextBox3.Location = new System.Drawing.Point(26, 222);
            this.adapterCode_TextBox3.Name = "adapterCode_TextBox3";
            this.adapterCode_TextBox3.Size = new System.Drawing.Size(131, 20);
            this.adapterCode_TextBox3.TabIndex = 10;
            this.adapterCode_TextBox3.Text = "104";
            // 
            // adapterType_TextBox2
            // 
            this.adapterType_TextBox2.Location = new System.Drawing.Point(203, 165);
            this.adapterType_TextBox2.Name = "adapterType_TextBox2";
            this.adapterType_TextBox2.Size = new System.Drawing.Size(131, 20);
            this.adapterType_TextBox2.TabIndex = 12;
            this.adapterType_TextBox2.Text = "FCT";
            // 
            // adapterType_TextBox3
            // 
            this.adapterType_TextBox3.Location = new System.Drawing.Point(203, 222);
            this.adapterType_TextBox3.Name = "adapterType_TextBox3";
            this.adapterType_TextBox3.Size = new System.Drawing.Size(131, 20);
            this.adapterType_TextBox3.TabIndex = 13;
            this.adapterType_TextBox3.Text = "FCT";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(398, 165);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(52, 20);
            this.temperatureTextBox.TabIndex = 14;
            this.temperatureTextBox.Text = "25";
            // 
            // contactsTextBox
            // 
            this.contactsTextBox.Location = new System.Drawing.Point(499, 219);
            this.contactsTextBox.Name = "contactsTextBox";
            this.contactsTextBox.Size = new System.Drawing.Size(87, 20);
            this.contactsTextBox.TabIndex = 15;
            this.contactsTextBox.Text = "80000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adapter code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Adapter code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adapter code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adapter type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Adapter type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Adapter type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Contacts";
            // 
            // IP_Textbox
            // 
            this.IP_Textbox.Location = new System.Drawing.Point(26, 41);
            this.IP_Textbox.Name = "IP_Textbox";
            this.IP_Textbox.Size = new System.Drawing.Size(131, 20);
            this.IP_Textbox.TabIndex = 24;
            this.IP_Textbox.Text = "127.0.0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Database IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 25);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Database user";
            // 
            // DB_UserTextbox
            // 
            this.DB_UserTextbox.Location = new System.Drawing.Point(203, 41);
            this.DB_UserTextbox.Name = "DB_UserTextbox";
            this.DB_UserTextbox.Size = new System.Drawing.Size(131, 20);
            this.DB_UserTextbox.TabIndex = 26;
            this.DB_UserTextbox.Text = "root";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 25);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Database password";
            // 
            // DB_PasswordTextboxx
            // 
            this.DB_PasswordTextboxx.Location = new System.Drawing.Point(398, 41);
            this.DB_PasswordTextboxx.Name = "DB_PasswordTextboxx";
            this.DB_PasswordTextboxx.Size = new System.Drawing.Size(131, 20);
            this.DB_PasswordTextboxx.TabIndex = 28;
            this.DB_PasswordTextboxx.Text = "root";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DB_PasswordTextboxx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DB_UserTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IP_Textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.contactsTextBox);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.adapterType_TextBox3);
            this.Controls.Add(this.adapterType_TextBox2);
            this.Controls.Add(this.adapterCode_TextBox3);
            this.Controls.Add(this.adapterCode_TextBox2);
            this.Controls.Add(this.adapterType_TextBox1);
            this.Controls.Add(this.adapterCode_TextBox1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.updateContactsButton);
            this.Controls.Add(this.setTemperatureButton);
            this.Controls.Add(this.IncrementCounterButton);
            this.Controls.Add(this.ResultTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "UI_Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.Button IncrementCounterButton;
        private System.Windows.Forms.Button setTemperatureButton;
        private System.Windows.Forms.Button updateContactsButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox adapterCode_TextBox1;
        private System.Windows.Forms.TextBox adapterType_TextBox1;
        private System.Windows.Forms.TextBox adapterCode_TextBox2;
        private System.Windows.Forms.TextBox adapterCode_TextBox3;
        private System.Windows.Forms.TextBox adapterType_TextBox2;
        private System.Windows.Forms.TextBox adapterType_TextBox3;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox contactsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IP_Textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DB_UserTextbox;
        private System.Windows.Forms.TextBox DB_PasswordTextboxx;
        private System.Windows.Forms.Label label11;
    }
}

