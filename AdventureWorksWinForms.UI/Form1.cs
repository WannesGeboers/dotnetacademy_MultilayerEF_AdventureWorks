using AdventureWorks.BLL.Services;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL;
using AdventureWorks.DAL.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdventureWorksWinForms.UI
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-IE9DG97;Initial Catalog = AdventureWorks2017; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly IService _service;

        public Form1()
        {
            InitializeComponent();
            var context = new AWContext();
            IPersonRepository personRepository = new PersonRepository(context);
            _service = new PersonService(personRepository);
        }
        
                //autofac


        private void Button1_Click(object sender, EventArgs e)
        {
            var customer = _service.GetAll().First();
            dataGridView1.DataSource = _service.GetAll().ToList();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnHigher_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.GetAll()
                .OrderBy(x=>x.FirstName)
                .ToList();
        }

        private void BtnLower_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.GetAll()
    .OrderBy(x => x.LastName)
    .ToList();
        }
    }
}
