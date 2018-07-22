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
    public partial class FormDisplayAllEmp : Form
    {
        public FormDisplayAllEmp()
        {
            InitializeComponent();
        }

        private void FormDisplayEmpDetails_Load(object sender, EventArgs e)
        {
            EmployeeController controller = new EmployeeController();
            Result<Employee> result = controller.SelectAll();
            if (result.Status == ResultEnumCheck.Success)
            {
                //Counts total number of employees
                lblTotal.Text = result.Data.Count.ToString();

                dataGridView1.DataSource = result.Data;
            }
            else
            {
                ErrorMessage.CannotRetrieve();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
