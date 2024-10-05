namespace Connecting_VM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Add_User = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdateUser = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.First_Name = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddNewADGroup = new System.Windows.Forms.TextBox();
            this.DisplayNameUpdate = new System.Windows.Forms.Label();
            this.LastNameUpdate = new System.Windows.Forms.Label();
            this.FirstNameUpdate = new System.Windows.Forms.Label();
            this.textBoxDN_Update = new System.Windows.Forms.TextBox();
            this.textBoxLN_Update = new System.Windows.Forms.TextBox();
            this.textBoxFN_Update = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 284);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(89, 308);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "DeleteUser";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_User
            // 
            this.Add_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.Add_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_User.Location = new System.Drawing.Point(151, 90);
            this.Add_User.Name = "Add_User";
            this.Add_User.Size = new System.Drawing.Size(75, 23);
            this.Add_User.TabIndex = 3;
            this.Add_User.Text = "Add User";
            this.Add_User.UseVisualStyleBackColor = false;
            this.Add_User.Click += new System.EventHandler(this.Add_User_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(146, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add AD Group";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateUser
            // 
            this.UpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.UpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateUser.Location = new System.Drawing.Point(120, 195);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(98, 23);
            this.UpdateUser.TabIndex = 5;
            this.UpdateUser.Text = "UpdateUser";
            this.UpdateUser.UseVisualStyleBackColor = false;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 44);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 6;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(135, 44);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 7;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(19, 145);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(279, 20);
            this.textBoxMail.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(188, 94);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(110, 20);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 93);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(120, 20);
            this.textBoxPassword.TabIndex = 10;
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name.Location = new System.Drawing.Point(9, 28);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(70, 13);
            this.First_Name.TabIndex = 11;
            this.First_Name.Text = "First_Name";
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Name.Location = new System.Drawing.Point(132, 28);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(70, 13);
            this.Last_Name.TabIndex = 12;
            this.Last_Name.Text = "Last_Name";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.Location = new System.Drawing.Point(17, 129);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(30, 13);
            this.Mail.TabIndex = 13;
            this.Mail.Text = "Mail";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(185, 78);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(43, 13);
            this.Phone.TabIndex = 14;
            this.Phone.Text = "Phone";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(9, 77);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(61, 13);
            this.Password.TabIndex = 15;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add new AD Group";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAddNewADGroup
            // 
            this.textBoxAddNewADGroup.Location = new System.Drawing.Point(10, 53);
            this.textBoxAddNewADGroup.Name = "textBoxAddNewADGroup";
            this.textBoxAddNewADGroup.Size = new System.Drawing.Size(112, 20);
            this.textBoxAddNewADGroup.TabIndex = 16;
            this.textBoxAddNewADGroup.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // DisplayNameUpdate
            // 
            this.DisplayNameUpdate.AutoSize = true;
            this.DisplayNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNameUpdate.Location = new System.Drawing.Point(15, 76);
            this.DisplayNameUpdate.Name = "DisplayNameUpdate";
            this.DisplayNameUpdate.Size = new System.Drawing.Size(121, 13);
            this.DisplayNameUpdate.TabIndex = 23;
            this.DisplayNameUpdate.Text = "DisplayNameUpdate";
            this.DisplayNameUpdate.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastNameUpdate
            // 
            this.LastNameUpdate.AutoSize = true;
            this.LastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameUpdate.Location = new System.Drawing.Point(185, 28);
            this.LastNameUpdate.Name = "LastNameUpdate";
            this.LastNameUpdate.Size = new System.Drawing.Size(104, 13);
            this.LastNameUpdate.TabIndex = 22;
            this.LastNameUpdate.Text = "LastNameUpdate";
            // 
            // FirstNameUpdate
            // 
            this.FirstNameUpdate.AutoSize = true;
            this.FirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameUpdate.Location = new System.Drawing.Point(16, 27);
            this.FirstNameUpdate.Name = "FirstNameUpdate";
            this.FirstNameUpdate.Size = new System.Drawing.Size(104, 13);
            this.FirstNameUpdate.TabIndex = 21;
            this.FirstNameUpdate.Text = "FirstNameUpdate";
            // 
            // textBoxDN_Update
            // 
            this.textBoxDN_Update.Location = new System.Drawing.Point(19, 92);
            this.textBoxDN_Update.Name = "textBoxDN_Update";
            this.textBoxDN_Update.Size = new System.Drawing.Size(127, 20);
            this.textBoxDN_Update.TabIndex = 20;
            // 
            // textBoxLN_Update
            // 
            this.textBoxLN_Update.Location = new System.Drawing.Point(188, 44);
            this.textBoxLN_Update.Name = "textBoxLN_Update";
            this.textBoxLN_Update.Size = new System.Drawing.Size(110, 20);
            this.textBoxLN_Update.TabIndex = 19;
            // 
            // textBoxFN_Update
            // 
            this.textBoxFN_Update.Location = new System.Drawing.Point(19, 43);
            this.textBoxFN_Update.Name = "textBoxFN_Update";
            this.textBoxFN_Update.Size = new System.Drawing.Size(127, 20);
            this.textBoxFN_Update.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.Add_User);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.First_Name);
            this.groupBox1.Controls.Add(this.Last_Name);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Location = new System.Drawing.Point(279, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 139);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAddNewADGroup);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(281, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 113);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FirstNameUpdate);
            this.groupBox3.Controls.Add(this.UpdateUser);
            this.groupBox3.Controls.Add(this.textBoxMail);
            this.groupBox3.Controls.Add(this.DisplayNameUpdate);
            this.groupBox3.Controls.Add(this.textBoxPhone);
            this.groupBox3.Controls.Add(this.LastNameUpdate);
            this.groupBox3.Controls.Add(this.Mail);
            this.groupBox3.Controls.Add(this.Phone);
            this.groupBox3.Controls.Add(this.textBoxDN_Update);
            this.groupBox3.Controls.Add(this.textBoxFN_Update);
            this.groupBox3.Controls.Add(this.textBoxLN_Update);
            this.groupBox3.Location = new System.Drawing.Point(557, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 258);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Add_User;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button UpdateUser;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddNewADGroup;
        private System.Windows.Forms.Label DisplayNameUpdate;
        private System.Windows.Forms.Label LastNameUpdate;
        private System.Windows.Forms.Label FirstNameUpdate;
        private System.Windows.Forms.TextBox textBoxDN_Update;
        private System.Windows.Forms.TextBox textBoxLN_Update;
        private System.Windows.Forms.TextBox textBoxFN_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

