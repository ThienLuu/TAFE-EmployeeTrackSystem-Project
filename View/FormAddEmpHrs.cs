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
    public partial class FormAddEmpHrs : Form
    {
        bool[] buttonEnablingArr = new bool[1];
        public FormAddEmpHrs()
        {
            InitializeComponent();
        }

        private void FormAddEmpHrs_Load(object sender, EventArgs e)
        {
            lblIDResult.Text = "##";
            lblIDResult.ForeColor = Color.Red;
            lblNameResult.Text = "None";
            lblNameResult.ForeColor = Color.Red;
            txtHours.Select();
            Reload();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Loop validation check
            bool check = true;
            for (int i = 0; i < buttonEnablingArr.Length; i++)
            {
                check = buttonEnablingArr[i] && check;
            }

            if (lblIDResult.Text == "")
            {
                MessageBox.Show("No employees");
            }
            else
            {
                if (check)
                {
                    //Read input
                    EmployeeHours newEmpHrs = new EmployeeHours();
                    newEmpHrs.EmpID = int.Parse(lblIDResult.Text);
                    newEmpHrs.WorkDate = DateTime.Parse(dateTimePicker1.Text);
                    newEmpHrs.Hours = decimal.Parse(txtHours.Text);

                    //Call controller
                    EmployeeHoursController controller = new EmployeeHoursController();
                    controller.AddHours(newEmpHrs);

                    //Clear textboxes and show output
                    MessageBox.Show("Hours successfully added to: " + lblNameResult.Text);
                    txtHours.Clear();
                    epHours.SetError(txtHours, null);
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

        private void lbxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmployee = (Employee)lbxEmp.SelectedItem;
            
            //Show 
            lblNameResult.Text = selectedEmployee.FirstName;
            lblIDResult.Text = selectedEmployee.ID.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.DecimalHours(txtHours.Text))
            {
                epHours.Icon = Properties.Resources.error;
                epHours.SetError(txtHours, "Invalid");
                buttonEnablingArr[0] = false;
            }
            else
            {
                epHours.Icon = Properties.Resources.check;
                epHours.SetError(txtHours, "Valid");
                buttonEnablingArr[0] = true;
            }
        }
    }
}
