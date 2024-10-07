using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you added the client?"
                , "confirmation"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Information
                , MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                string filePath = "C:\\Users\\Osama-Pc\\OneDrive\\Desktop\\data.txt";
                bool idExists = false;

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {

                            string[] values = line.Split(',');

                            if (values[0] == txtID.Text)
                            {
                                idExists = true;
                                break;
                            }

                        }
                    }
                    if (idExists)
                    {
                        MessageBox.Show("This ID is already Exist..try Another ID"
                            , "confirmation"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                    }
                    else
                    {

                        ListViewItem item = new ListViewItem(txtID.Text);
                        item.SubItems.Add(txtFirstName.Text + " " + txtLastName.Text);
                        item.SubItems.Add(txtPhone.Text);
                        item.SubItems.Add(txtPincode.Text);
                        item.SubItems.Add(txtEmail.Text);
                        item.SubItems.Add(txtSalary.Text);
                        Form1.instance.listV.Items.Add(item);

                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine($"{txtID.Text},{txtFirstName.Text} {txtLastName.Text},{txtPhone.Text},{txtPincode.Text},{txtEmail.Text},{txtSalary.Text}");
                        }

                        txtID.Clear();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtEmail.Clear();
                        txtPhone.Clear();
                        txtPincode.Clear();
                        txtSalary.Clear();
                        txtID.Focus();
                    }
                }
            }
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                e.Cancel = true;
                txtID.Focus();
                errorProvider1.SetError(txtID, "You Must Enter ID");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtID, "");
            }

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "You Must Enter FirstName");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "You Must Enter LastName");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtPincode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPincode.Text))
            {
                e.Cancel = true;
                txtPincode.Focus();
                errorProvider1.SetError(txtPincode, "You Must Enter PinCode");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPincode, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "You Must Enter Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "You Must Enter Phone Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                e.Cancel = true;
                txtSalary.Focus();
                errorProvider1.SetError(txtSalary, "You Must Enter Salary");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSalary, "");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckFields()
        {
            bool allFieldsFilled = !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                                   !string.IsNullOrWhiteSpace(txtID.Text) &&
                                   !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                                   !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                                   !string.IsNullOrWhiteSpace(txtPhone.Text) &&
                                   !string.IsNullOrWhiteSpace(txtPincode.Text) &&
                                   !string.IsNullOrWhiteSpace(txtSalary.Text);

            btnAdd.Enabled = allFieldsFilled;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtPincode_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

    }
}

