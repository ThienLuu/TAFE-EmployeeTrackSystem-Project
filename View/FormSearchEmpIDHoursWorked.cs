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
    public partial class FormSearchEmpIDHoursWorked : Form
    {
        bool[] buttonEnablingArr = new bool[1];
        public FormSearchEmpIDHoursWorked()
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

            if (check)
            {
                int ID = int.Parse(txtInput.Text);
                txtInput.Clear();

                EmployeeHoursController controller = new EmployeeHoursController();
                Result<EmployeeHours> result = controller.SelectByIDHours(ID);
                switch (result.Status)
                {
                    case ResultEnumCheck.Success:
                        dataGridView1.DataSource = result.Data;
                        lblIDResult.Text = ID.ToString();

                        //Sum of total hours
                        decimal total = 0;
                        foreach (var item in result.Data)
                        {
                            total = total + item.Hours;
                        }
                        lblResult.Text = total.ToString();
                        epInput.SetError(txtInput, null);
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

        private void FormSearchEmpIDHoursWorked_Load(object sender, EventArgs e)
        {
            txtInput.Select();
            lblResult.Text = "";
            lblIDResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsNumber(txtInput.Text))
            {
                epInput.Icon = Properties.Resources.error;
                epInput.SetError(txtInput, "Invalid");
                buttonEnablingArr[0] = false;
            }
            else
            {
                epInput.Icon = Properties.Resources.check;
                epInput.SetError(txtInput, "Valid");
                buttonEnablingArr[0] = true;
            }
        }
    }
}
