namespace WindowsFormsApp2
{
    partial class Form2
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
            this.LB_FirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.LB_LastName = new System.Windows.Forms.Label();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.LB_PinCode = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.LB_ID = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.LB_Salary = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.LB_PhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_FirstName
            // 
            this.LB_FirstName.AutoSize = true;
            this.LB_FirstName.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FirstName.ForeColor = System.Drawing.Color.White;
            this.LB_FirstName.Location = new System.Drawing.Point(15, 163);
            this.LB_FirstName.Name = "LB_FirstName";
            this.LB_FirstName.Size = new System.Drawing.Size(185, 33);
            this.LB_FirstName.TabIndex = 0;
            this.LB_FirstName.Text = "First Name ";
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
            this.label2.Size = new System.Drawing.Size(306, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add New Client";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(21, 203);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(327, 33);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(21, 297);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(327, 33);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // LB_LastName
            // 
            this.LB_LastName.AutoSize = true;
            this.LB_LastName.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LastName.ForeColor = System.Drawing.Color.White;
            this.LB_LastName.Location = new System.Drawing.Point(15, 257);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(179, 33);
            this.LB_LastName.TabIndex = 3;
            this.LB_LastName.Text = "Last Name ";
            // 
            // txtPincode
            // 
            this.txtPincode.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPincode.Location = new System.Drawing.Point(21, 387);
            this.txtPincode.MaxLength = 20;
            this.txtPincode.Multiline = true;
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(327, 33);
            this.txtPincode.TabIndex = 3;
            this.txtPincode.TextChanged += new System.EventHandler(this.txtPincode_TextChanged);
            this.txtPincode.Validating += new System.ComponentModel.CancelEventHandler(this.txtPincode_Validating);
            // 
            // LB_PinCode
            // 
            this.LB_PinCode.AutoSize = true;
            this.LB_PinCode.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PinCode.ForeColor = System.Drawing.Color.White;
            this.LB_PinCode.Location = new System.Drawing.Point(15, 349);
            this.LB_PinCode.Name = "LB_PinCode";
            this.LB_PinCode.Size = new System.Drawing.Size(134, 33);
            this.LB_PinCode.TabIndex = 5;
            this.LB_PinCode.Text = "PinCode";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(21, 116);
            this.txtID.MaxLength = 10;
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(327, 33);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.txtID_Validating);
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.ForeColor = System.Drawing.Color.White;
            this.LB_ID.Location = new System.Drawing.Point(15, 76);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(47, 33);
            this.LB_ID.TabIndex = 7;
            this.LB_ID.Text = "ID";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSalary.Location = new System.Drawing.Point(427, 387);
            this.txtSalary.MaxLength = 20;
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(327, 33);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // LB_Salary
            // 
            this.LB_Salary.AutoSize = true;
            this.LB_Salary.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Salary.ForeColor = System.Drawing.Color.White;
            this.LB_Salary.Location = new System.Drawing.Point(421, 349);
            this.LB_Salary.Name = "LB_Salary";
            this.LB_Salary.Size = new System.Drawing.Size(107, 33);
            this.LB_Salary.TabIndex = 13;
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
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // LB_PhoneNumber
            // 
            this.LB_PhoneNumber.AutoSize = true;
            this.LB_PhoneNumber.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.LB_PhoneNumber.Location = new System.Drawing.Point(421, 257);
            this.LB_PhoneNumber.Name = "LB_PhoneNumber";
            this.LB_PhoneNumber.Size = new System.Drawing.Size(228, 33);
            this.LB_PhoneNumber.TabIndex = 11;
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
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email.ForeColor = System.Drawing.Color.White;
            this.LB_Email.Location = new System.Drawing.Point(421, 163);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(96, 33);
            this.LB_Email.TabIndex = 9;
            this.LB_Email.Text = "Email";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(400, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 51);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Russo One", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(248, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 51);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.btnAdd);
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
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label LB_LastName;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.Label LB_PinCode;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label LB_Salary;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label LB_PhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}