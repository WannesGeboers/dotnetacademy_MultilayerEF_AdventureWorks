using AdventureWorks.BLL;
using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL;
using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdventureWorksWinForms.UI
{
    public partial class Form1 : Form
    {
        //string connectionString = @"Data Source=DESKTOP-IE9DG97;Initial Catalog = AdventureWorks2017; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private ICustomerService _customerService;
        private IEnumerable<CustomerWithTotalDueDTO> _data;

        public Form1()
        {
            InitializeComponent();
            InitialLoadApplication();
            LoadStartData();
            LoadComboBox();
        }

        private void InitialLoadApplication()
        {
            var context = new AWContext();
            ICustomerRepository customerRepository = new CustomerRepository(context);
            _customerService = new CustomerService(customerRepository);
        }

        private void LoadStartData()
        {
            _data = _customerService.GetAllCustomersWithTotalDue();
            DisplayData(_data);
        }

        private void LoadComboBox()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = dataGridView1.Columns;
            comboBox1.DisplayMember = "HeaderText";
        }


        private void DisplayData(IEnumerable<CustomerWithTotalDueDTO> data)
        {
            //1.clear items
            //2. add source
            //3. add rowNumbers
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
            GiveRowNumber(dataGridView1);
            lblRows.Text = "Number of rows:" + dataGridView1.RowCount.ToString();

        }


        //autofac


        private void GiveRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
                row.HeaderCell.Value = (row.Index + 1).ToString();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            DisplayData(_data);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            IEnumerable<CustomerWithTotalDueDTO> data = null;

            if (string.IsNullOrEmpty(text) == true)
            {
                data = _customerService.GetAllCustomersWithTotalDue();
            }
            else
            {
                //selected in combobox
                var selectedComboValue = comboBox1.Text;
                //switch (selectedComboValue)
                //{
                //    case "SumOfTotalDue":
                //        char first = text[0];
                //        if (first.Equals('=') || first.Equals('<') || first.Equals('>') == true)
                //        {
                //            var numbTest = text.Replace(first.ToString(), "").Trim();
                //            if (decimal.TryParse(numbTest, out decimal result) == true)
                //            {
                //                data = _customerService.FilterByTotalDue(first, result);
                //            }
                //        }
                //        break;
                //    case "FirstName":
                //        data = _customerService.FilterByFirstName(text);
                //        break;

                //    case "LastName":
                //        data = _customerService.FilterByLastName(text);
                //        break;
                //    case "AccountNumber":
                //        data = _customerService.FilterByAccountNumber(text);
                //        break;
                //    default:
                //        break;
                //}


                if (selectedComboValue=="SumOfTotalDue")
                {
                    char first = text[0];
                    if (first.Equals('=') || first.Equals('<') || first.Equals('>') == true)
                    {
                        var numbTest = text.Replace(first.ToString(), "").Trim();
                        if (decimal.TryParse(numbTest, out decimal result) == true)
                        {
                            data = _customerService.FilterByTotalDue(first, result);
                        }
                    }                   
                }
                else
                {
                    data = _customerService.FilterByStringAndAttribute(text, selectedComboValue);
                }
            }

            DisplayData(data);




        }


        private void BtnHigher_Click(object sender, EventArgs e)
        {
            var data = _customerService.GetAllCustomersAverage('>');
            DisplayData(data);
        }

        private void BtnLower_Click(object sender, EventArgs e)
        {
            var data = _customerService.GetAllCustomersAverage('<');
            DisplayData(data);
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = (ComboBox)sender;
            if (res.Text.Equals("SumOfTotalDue"))
            {
                lblTotalDueEx.Visible = true;
            }
            else
            {
                lblTotalDueEx.Visible = false;
            }
        }



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

