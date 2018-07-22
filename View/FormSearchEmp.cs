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
using Controller;
using Model;

namespace View
{
    public partial class FormSearchEmp : Form
    {
        bool[] buttonEnablingArr = new bool[1];
        public FormSearchEmp()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Loop validation check
            bool check = true;
            for (int i = 0; i < buttonEnablingArr.Length; i++)
            {
                check = buttonEnablingArr[i] && check;
            }

            if (txtID.Text != "")
            {
                if (check)
                {
                    int ID = int.Parse(txtID.Text);

                    EmployeeController controller = new EmployeeController();
                    Result<Employee> result = controller.SelectByID(ID);
                    switch (result.Status)
                    {
                        case ResultEnumCheck.Success:
                            dataGridView1.DataSource = result.Data;
                            break;
                        case ResultEnumCheck.Fail:
                            ErrorMessage.CannotRetrieve();
                            break;
                    }
                }
                else
                {
                    ErrorMessage.InputMessage();
                }
            }
            else if (txtEmail.Text != "")
            {
                if (check)
                {
                    string Email = txtEmail.Text;

                    EmployeeController controller = new EmployeeController();
                    Result<Employee> result = controller.SelectByEmail(Email);
                    switch (result.Status)
                    {
                        case ResultEnumCheck.Success:
                            dataGridView1.DataSource = result.Data;
                            break;
                        case ResultEnumCheck.Fail:
                            ErrorMessage.CannotRetrieve();
                            break;
                    }
                }
                else
                {
                    ErrorMessage.InputMessage();
                }
            }
            else
            {
                ErrorMessage.InputMessage();
                //MessageBox.Show("Error - Search box empty");
            }
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbID.Checked)
            {
                txtEmail.Clear();
                txtEmail.Visible = false;
                txtID.Visible = true;
                txtID.Select();
                btnSearch.Enabled = true;
            }
        }

        private void rbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmail.Checked)
            {
                txtID.Clear();
                txtID.Visible = false;
                txtEmail.Visible = true;
                txtEmail.Select();
                btnSearch.Enabled = true;
            }
        }

        private void FormSearchEmp_Load(object sender, EventArgs e)
        {
            txtEmail.Visible = false;
            txtID.Visible = false;
            btnSearch.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsNumber(txtID.Text))
            {
                epID.Icon = Properties.Resources.error;
                epID.SetError(txtID, "Invalid");
                buttonEnablingArr[0] = false;
            }
            else
            {
                epID.Icon = Properties.Resources.check;
                epID.SetError(txtID, "Valid");
                buttonEnablingArr[0] = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsEmail(txtEmail.Text))
            {
                epEmail.Icon = Properties.Resources.error;
                epEmail.SetError(txtEmail, "Invalid");
                buttonEnablingArr[0] = false;
            }
            else
            {
                epEmail.Icon = Properties.Resources.check;
                epEmail.SetError(txtEmail, "Valid");
                buttonEnablingArr[0] = true;
            }
        }
    }
}
