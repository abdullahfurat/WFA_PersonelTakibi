using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFAPersonelTakibi
{
    public partial class Form2 : MetroForm
    {
        private IService<Employee> _employeeService;
        private IService<Department> _departmentService;
        public Form2()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        void PersonelListesi()
        {
            dgvEmployees.DataSource = _employeeService.GetAll();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
