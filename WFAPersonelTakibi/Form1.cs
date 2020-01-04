using MetroFramework.Forms;
using System;

namespace WFAPersonelTakibi
{
    public partial class Form1 : MetroForm
    {
        private IService<Employee> _employeeService;
        public Form1()
        {
            InitializeComponent(); 
            _employeeService = new EmployeeService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = txtFirstName.Text;

            _employeeService.Add(employee);
             
        }
    }
}
