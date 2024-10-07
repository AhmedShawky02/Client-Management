using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public static Form3 Current;

        public string _CurrentId {  get;private set; }
        public string _FullName { get; private set; }
        public string _phone { get; private set; }
        public string _pincode { get; private set; }
        public string _email { get; private set; }
        public string _Salary { get; private set; }

        public Form3(string currentId, string fullName, string phone, string pincode, string email, string salary)
        {
            string[] Name = fullName.Split(' ');

            InitializeComponent();
            txtID.Text = currentId;
            txtFirstName.Text = Name[0];
            txtLastName.Text = Name[1];
            txtPhone.Text = phone;
            txtPincode.Text = pincode;
            txtEmail.Text = email;
            txtSalary.Text = salary;

            Current= this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _CurrentId = txtID.Text;
            _FullName = txtFirstName.Text + " " + txtLastName.Text;
            _phone = txtPhone.Text;
            _pincode = txtPincode.Text;
            _email = txtEmail.Text;
            _Salary = txtSalary.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
