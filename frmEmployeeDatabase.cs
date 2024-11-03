using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(tbEmployeeID.Text, tbFirstName.Text, tbLastName.Text, tbPosition.Text);

            dataGridView1.Rows.Add(employee.EmployeeID, employee.FirstName, employee.LastName, employee.Position);
        }
    }
}
