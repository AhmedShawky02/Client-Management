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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public ListView listV;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            listV = listView1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Osama-Pc\\OneDrive\\Desktop\\data.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] values = line.Split(',');

                        ListViewItem item = new ListViewItem(values);
                        listView1.Items.Add(item);

                    }
                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];

            string CurrentId = selectedItem.SubItems[0].Text;
            string fullName = selectedItem.SubItems[1].Text;
            string phone = selectedItem.SubItems[2].Text;
            string pincode = selectedItem.SubItems[3].Text;
            string email = selectedItem.SubItems[4].Text;
            string Salary = selectedItem.SubItems[5].Text;

            Form form3 = new Form3(CurrentId, fullName, phone, pincode, email, Salary);
            form3.ShowDialog();

            if (form3.DialogResult == DialogResult.OK)
            {
                selectedItem.SubItems[0].Text = Form3.Current._CurrentId;
                selectedItem.SubItems[1].Text = Form3.Current._FullName;
                selectedItem.SubItems[2].Text = Form3.Current._phone;
                selectedItem.SubItems[3].Text = Form3.Current._pincode;
                selectedItem.SubItems[4].Text = Form3.Current._email;
                selectedItem.SubItems[5].Text = Form3.Current._Salary;

                string filePath = "C:\\Users\\Osama-Pc\\OneDrive\\Desktop\\data.txt";

                try
                {
                    var lines = new List<string>(File.ReadAllLines(filePath));

                    for (int i = 0; i < lines.Count; i++)
                    {

                        if (lines[i].StartsWith(Form3.Current._CurrentId + ","))
                        {

                            lines[i] = string.Join(",",
                                selectedItem.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text));
                            break; 
                        }
                    }

                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) // تحقق من وجود عنصر محدد
            {
                // تأكيد الحذف
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?",
                                                            "confirmation",
                                                            MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string filePath = "C:\\Users\\Osama-Pc\\OneDrive\\Desktop\\data.txt";

                    ListViewItem selectedItem = listView1.SelectedItems[0];

                    // تحقق من وجود عناصر فرعية
                    if (selectedItem.SubItems.Count > 0)
                    {
                        string currentId = selectedItem.SubItems[0].Text;

                        try
                        {
                            var lines = new List<string>(File.ReadAllLines(filePath));

                            // حذف السطر الذي يتطابق مع currentId
                            lines.RemoveAll(line => line.StartsWith(currentId + ","));

                            // كتابة المحتويات المعدلة إلى الملف
                            File.WriteAllLines(filePath, lines);

                            // حذف العنصر من ListView
                            listView1.Items.Remove(selectedItem);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("لا يحتوي العنصر المحدد على بيانات.");
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد عنصر لحذفه.");
            }
        }
    }
}
