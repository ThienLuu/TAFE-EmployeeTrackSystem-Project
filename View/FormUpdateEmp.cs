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
    public partial class FormUpdateEmp : Form
    {
        bool[] buttonEnablingArr = new bool[5];
        public FormUpdateEmp()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Loop validation check
            bool check = true;
            for (int i = 0; i < buttonEnablingArr.Length; i++)
            {
                check = buttonEnablingArr[i] && check;
            }

            if (lblIDResult.Text == "")
            {
                MessageBox.Show("Please select employee");
            }
            else
            {
                if (check)
                {
                    //Read employee
                    Employee updateEmp = new Employee();
                    updateEmp.ID = int.Parse(lblIDResult.Text);
                    updateEmp.FirstName = txtFN.Text;
                    updateEmp.LastName = txtLN.Text;
                    updateEmp.Email = txtEmail.Text;
                    updateEmp.DOB = DateTime.Parse(txtDOB.Text);
                    updateEmp.Phone = txtPh.Text;

                    //Save to db
                    EmployeeController controller = new EmployeeController();
                    ResultEnumCheck results = controller.Update(updateEmp);
                    if (results == ResultEnumCheck.Success)
                    {
                        //Reload the list
                        Reload();
                        MessageBox.Show("Employee Updated");
                    }
                    else
                    {
                        MessageBox.Show("Cannot update employee");
                    }
                }
                else
                {
                    ErrorMessage.InputMessage();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        //List reload - Updates list with employees
        private void Reload()
        {
            EmployeeController controller = new EmployeeController();
            Result<Employee> result = controller.SelectAll();
            if (result.Status == ResultEnumCheck.Success)
            {
                lbxEmp.DataSource = result.Data;
                lbxEmp.DisplayMember = "FirstName";
            }
            else
            {
                ErrorMessage.CannotRetrieve();
                Close();
            }
        }

        private void FormUpdateEmp_Load(object sender, EventArgs e)
        {
            lblIDResult.Text = "####";
            lblIDResult.ForeColor = Color.Red;
            Reload();
        }

        private void lbxEmp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Employee selectedEmployee = (Employee)lbxEmp.SelectedItem;
            //show
            lblIDResult.ForeColor = Color.Red;
            lblIDResult.Text = selectedEmployee.ID.ToString();
            txtFN.Text = selectedEmployee.FirstName;
            txtLN.Text = selectedEmployee.LastName;
            txtEmail.Text = selectedEmployee.Email;
            txtDOB.Text = selectedEmployee.DOB.ToString("yyyy/MM/dd");
            txtPh.Text = selectedEmployee.Phone;
            epFN.SetError(txtFN, null);
            epLN.SetError(txtLN, null);
            epEmail.SetError(txtEmail, null);
            epPhone.SetError(txtPh, null);
            epDate.SetError(txtDOB, null);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Reload();
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

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsDate(txtDOB.Text))
            {
                epDate.Icon = Properties.Resources.error;
                epDate.SetError(txtDOB, "Invalid");
                buttonEnablingArr[4] = false;
            }
            else
            {
                epDate.Icon = Properties.Resources.check;
                epDate.SetError(txtDOB, "Valid");
                buttonEnablingArr[4] = true;
            }
        }
    }
}
