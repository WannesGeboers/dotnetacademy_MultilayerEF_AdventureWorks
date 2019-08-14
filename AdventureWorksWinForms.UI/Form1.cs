using AdventureWorks.BLL.Services;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL;
using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksWinForms.UI
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-IE9DG97;Initial Catalog = AdventureWorks2017; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly IPersonService _personService;

        public Form1()
        {
            InitializeComponent();
            var context = new AWContext();
            IPersonRepository personRepository = new PersonRepository(context);
            _personService = new PersonService(personRepository);
        }
        
                //autofac


        private void Button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _personService.GetAll();


            //using (SqlConnection sqlCon = new SqlConnection(connectionString))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter sqlda = new SqlDataAdapter("" +
            //        "SELECT FIRSTNAME,LASTNAME, ACCOUNTNUMBER FROM PERSON.PERSON " +
            //        "JOIN SALES.CUSTOMER ON PERSON.BUSINESSENTITYID = CUSTOMER.PERSONID ", sqlCon);
            //    DataTable dtbl = new DataTable();
            //    sqlda.Fill(dtbl);
            //    dataGridView1.DataSource = dtbl;
            //}
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnHigher_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
         
                    SqlDataAdapter sqlda = new SqlDataAdapter("" +
                        "SELECT FIRSTNAME,LASTNAME, ACCOUNTNUMBER,TOTALDUE FROM PERSON.PERSON " +
                        "JOIN SALES.CUSTOMER ON PERSON.BUSINESSENTITYID = CUSTOMER.PERSONID" +
                        "JOIN SALES.SALESORDERHEADER ON CUSTOMER.PERSONID=SALESORDERHEADER.CUSTOMERID ", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlda.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
            }
        }
    }
}
