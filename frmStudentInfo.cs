using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtStudentid.Text.Trim()))
            {
                errorProvider1.SetError(txtStudentid, "Student ID is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtStudentid, string.Empty);
            }

            if (String.IsNullOrEmpty(txtLastname.Text.Trim()))
            {
                errorProvider1.SetError(txtLastname, "Lastname is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtLastname, string.Empty);
            }

            if (String.IsNullOrEmpty(txtFirstname.Text.Trim()))
            {
                errorProvider1.SetError(txtFirstname, "Firstname is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFirstname, string.Empty);
            }

            Student studentObject = new Student();
            studentObject.StudentID = Convert.ToInt32(txtStudentid.Text);
            studentObject.Lastname = txtLastname.Text;
            studentObject.Firstname = txtFirstname.Text;

            listBoxid.Items.Add(studentObject.StudentID);
            listBoxLastname.Items.Add(studentObject.Lastname);
            listBoxfirstname.Items.Add(studentObject.Firstname);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtstudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
