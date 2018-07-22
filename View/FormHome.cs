using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEmp addEmpForm = new FormAddEmp();
            addEmpForm.ShowDialog();
        }

        private void btnAddEmpHrs_Click(object sender, EventArgs e)
        {
            FormAddEmpHrs addEmpHrsForm = new FormAddEmpHrs();
            addEmpHrsForm.ShowDialog();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            FormUpdateEmp updateEmpForm = new FormUpdateEmp();
            updateEmpForm.ShowDialog();
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            FormSearchEmp searchEmpForm = new FormSearchEmp();
            searchEmpForm.ShowDialog();
        }

        private void btnDisplayEmp_Click(object sender, EventArgs e)
        {
            FormDisplayAllEmp displayEmpDetails = new FormDisplayAllEmp();
            displayEmpDetails.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearchEmpHours_Click(object sender, EventArgs e)
        {
            FormSearchEmpIDHoursWorked searchEmpHours = new FormSearchEmpIDHoursWorked();
            searchEmpHours.ShowDialog();
        }
    }
}
