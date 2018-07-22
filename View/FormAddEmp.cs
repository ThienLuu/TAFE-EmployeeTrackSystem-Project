using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//...
using Model;
using Controller;

namespace View
{
    public partial class FormAddEmp : Form
    {
        bool[] buttonEnablingArr = new bool[4];
        public FormAddEmp()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Loop validation check
            bool check = true;
            for (int i = 0; i < buttonEnablingArr.Length; i++)
            {
                check = buttonEnablingArr[i] && check;
            }

            if (check)
            {
                //Read input
                Employee newEmp = new Employee();
                newEmp.FirstName = txtFN.Text;
                newEmp.LastName = txtLN.Text;
                newEmp.Email = txtEmail.Text;
                newEmp.DOB = DateTime.Parse(dateTimePicker1.Text);
                newEmp.Phone = txtPh.Text;

                //Call controller
                EmployeeController controller = new EmployeeController();
                controller.Add(newEmp);

                //Clear textboxes and show output
                MessageBox.Show("Employee successfully added");
                txtFN.Clear();
                txtLN.Clear();
                txtEmail.Clear();
                txtPh.Clear();
                epFN.SetError(txtFN, null);
                epLN.SetError(txtLN, null);
                epEmail.SetError(txtEmail, null);
                epPhone.SetError(txtPh, null);
            }
            else
            {
                ErrorMessage.InputMessage();
            }
        }

        private void FormAddEmp_Load(object sender, EventArgs e)
        {
            txtFN.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.LettersOnly(txtFN.Text))
            {
                epFN.Icon = Properties.Resources.error;
                epFN.SetError(txtFN, "Invalid");
                buttonEnablingArr[0] = false;
            }
            else if (txtFN.Text.Length > 35)
            {
                epFN.Icon = Properties.Resources.error;
                epFN.SetError(txtFN, ErrorMessage.Length());
                buttonEnablingArr[0] = false;
            }
            else
            {
                epFN.Icon = Properties.Resources.check;
                epFN.SetError(txtFN, "Valid");
                buttonEnablingArr[0] = true;
            }
        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.LettersOnly(txtLN.Text))
            {
                epLN.Icon = Properties.Resources.error;
                epLN.SetError(txtLN, "Invalid");
                buttonEnablingArr[1] = false;
            }
            else if (txtLN.Text.Length > 35)
            {
                epLN.Icon = Properties.Resources.error;
                epLN.SetError(txtLN, ErrorMessage.Length());
                buttonEnablingArr[1] = false;
            }
            else
            {
                epLN.Icon = Properties.Resources.check;
                epLN.SetError(txtLN, "Valid");
                buttonEnablingArr[1] = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsEmail(txtEmail.Text))
            {
                epEmail.Icon = Properties.Resources.error;
                epEmail.SetError(txtEmail, "Invalid");
                buttonEnablingArr[2] = false;
            }
            else if (txtEmail.Text.Length > 75)
            {
                epEmail.Icon = Properties.Resources.error;
                epEmail.SetError(txtEmail, ErrorMessage.Length());
                buttonEnablingArr[2] = false;
            }
            else
            {
                epEmail.Icon = Properties.Resources.check;
                epEmail.SetError(txtEmail, "Valid");
                buttonEnablingArr[2] = true;
            }
        }

        private void txtPh_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidPhone(txtPh.Text))
            {
                epPhone.Icon = Properties.Resources.error;
                epPhone.SetError(txtPh, "Invalid");
                buttonEnablingArr[3] = false;
            }
            else if (txtPh.Text.Length > 10 || txtPh.Text.Length < 10)
            {
                epPhone.Icon = Properties.Resources.error;
                epPhone.SetError(txtPh, ErrorMessage.InvalidPhNo());
                buttonEnablingArr[3] = false;
            }
            else
            {
                epPhone.Icon = Properties.Resources.check;
                epPhone.SetError(txtPh, "Valid");
                buttonEnablingArr[3] = true;
            }
        }
    }
}
