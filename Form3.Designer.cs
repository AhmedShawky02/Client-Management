namespace WindowsFormsApp2
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.LB_Salary = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.LB_PhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.LB_ID = new System.Windows.Forms.Label();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.LB_PinCode = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.LB_LastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_FirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(248, 449);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 51);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(400, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 51);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSalary.Location = new System.Drawing.Point(427, 387);
            this.txtSalary.MaxLength = 20;
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(327, 33);
            this.txtSalary.TabIndex = 28;
            // 
            // LB_Salary
            // 
            this.LB_Salary.AutoSize = true;
            this.LB_Salary.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Salary.ForeColor = System.Drawing.Color.White;
            this.LB_Salary.Location = new System.Drawing.Point(421, 349);
            this.LB_Salary.Name = "LB_Salary";
            this.LB_Salary.Size = new System.Drawing.Size(107, 33);
            this.LB_Salary.TabIndex = 32;
            this.LB_Salary.Text = "Salary";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(427, 297);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(327, 33);
            this.txtPhone.TabIndex = 26;
            // 
            // LB_PhoneNumber
            // 
            this.LB_PhoneNumber.AutoSize = true;
            this.LB_PhoneNumber.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.LB_PhoneNumber.Location = new System.Drawing.Point(421, 257);
            this.LB_PhoneNumber.Name = "LB_PhoneNumber";
            this.LB_PhoneNumber.Size = new System.Drawing.Size(228, 33);
            this.LB_PhoneNumber.TabIndex = 31;
            this.LB_PhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(427, 203);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(327, 33);
            this.txtEmail.TabIndex = 25;
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email.ForeColor = System.Drawing.Color.White;
            this.LB_Email.Location = new System.Drawing.Point(421, 163);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(96, 33);
            this.LB_Email.TabIndex = 30;
            this.LB_Email.Text = "Email";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(21, 116);
            this.txtID.MaxLength = 10;
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(327, 33);
            this.txtID.TabIndex = 18;
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.ForeColor = System.Drawing.Color.White;
            this.LB_ID.Location = new System.Drawing.Point(15, 76);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(47, 33);
            this.LB_ID.TabIndex = 29;
            this.LB_ID.Text = "ID";
            // 
            // txtPincode
            // 
            this.txtPincode.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPincode.Location = new System.Drawing.Point(21, 387);
            this.txtPincode.MaxLength = 20;
            this.txtPincode.Multiline = true;
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(327, 33);
            this.txtPincode.TabIndex = 23;
            // 
            // LB_PinCode
            // 
            this.LB_PinCode.AutoSize = true;
            this.LB_PinCode.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PinCode.ForeColor = System.Drawing.Color.White;
            this.LB_PinCode.Location = new System.Drawing.Point(15, 349);
            this.LB_PinCode.Name = "LB_PinCode";
            this.LB_PinCode.Size = new System.Drawing.Size(134, 33);
            this.LB_PinCode.TabIndex = 27;
            this.LB_PinCode.Text = "PinCode";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(21, 297);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(327, 33);
            this.txtLastName.TabIndex = 22;
            // 
            // LB_LastName
            // 
            this.LB_LastName.AutoSize = true;
            this.LB_LastName.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LastName.ForeColor = System.Drawing.Color.White;
            this.LB_LastName.Location = new System.Drawing.Point(15, 257);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(179, 33);
            this.LB_LastName.TabIndex = 24;
            this.LB_LastName.Text = "Last Name ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(21, 203);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(327, 33);
            this.txtFirstName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Russo One", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(248, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 44);
            this.label2.TabIndex = 20;
            this.label2.Text = "Update Client";
            // 
            // LB_FirstName
            // 
            this.LB_FirstName.AutoSize = true;
            this.LB_FirstName.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FirstName.ForeColor = System.Drawing.Color.White;
            this.LB_FirstName.Location = new System.Drawing.Point(15, 163);
            this.LB_FirstName.Name = "LB_FirstName";
            this.LB_FirstName.Size = new System.Drawing.Size(185, 33);
            this.LB_FirstName.TabIndex = 19;
            this.LB_FirstName.Text = "First Name ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.LB_Salary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.LB_PhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.LB_Email);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.txtPincode);
            this.Controls.Add(this.LB_PinCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.LB_LastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_FirstName);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label LB_Salary;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label LB_PhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.Label LB_PinCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label LB_LastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_FirstName;
    }
}