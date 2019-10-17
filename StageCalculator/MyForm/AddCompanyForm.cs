using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StageCalculator.Models;
using StageCalculator.Adapter;

namespace StageCalculator.MyForm
{
    public partial class AddCompanyForm : Form
    {
        
        private ComboDictionary _dictionar= new ComboDictionary();
        private MainForm mainForm;

        public AddCompanyForm()
        {
            
            InitializeComponent();
            
        }

        private void AddCompanyForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
            
        }

       
        private void RefreshForm()
        {
            _dictionar.FillDictionar<Company>();
            var Companies = _dictionar.Dictionar.Select(c => (Company)c.Value).OrderByDescending(x => x.CompanyId);
            if(Companies.Any())
            {
                dataGridViewOnAddCompanyForm.DataSource = Companies.ToList();
                dataGridViewOnAddCompanyForm.Columns[0].HeaderText = "ID";
                dataGridViewOnAddCompanyForm.Columns[1].HeaderText = "Companie";
                foreach (DataGridViewColumn col in dataGridViewOnAddCompanyForm.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                dataGridViewOnAddCompanyForm.Columns[0].Width = 60;
            }
            else
            {
                dataGridViewOnAddCompanyForm.DataSource = null;
            }
            

        }
       

        private void BtnSaveCompanyToDB_Click(object sender, EventArgs e)
        {
            if (btnSaveCompany.Text=="Save")
            {
                if (!string.IsNullOrEmpty(txtBxCompanyName.Text) && !string.IsNullOrWhiteSpace(txtBxCompanyName.Text))
                {
                    var _company = new Company { CompanyName = txtBxCompanyName.Text };
                    _dictionar.Add(_company.CompanyName, _company);
                    txtBxCompanyName.Clear();
                }
                else
                {
                    MessageBox.Show($"Company no added");
                }
                RefreshForm();
            }
            else
            {
                var NameCompanyToUpdate = dataGridViewOnAddCompanyForm.CurrentRow.Cells[1].Value.ToString();

                var CompanyToUpdate = _dictionar.GetObjectByName<Company>(NameCompanyToUpdate);
                if (!string.IsNullOrEmpty(NameCompanyToUpdate))
                {

                    CompanyToUpdate.CompanyName = txtBxCompanyName.Text;
                    txtBxCompanyName.Text = string.Empty;
                    _dictionar.Update(CompanyToUpdate);
                }
                else
                {
                    MessageBox.Show($"Company no updated");
                }
                btnSaveCompany.Text = "Save";
                RefreshForm();
            }
            
        }

        private void BtnRemoveONAddCompanyForm_Click(object sender, EventArgs e)
        {
            var NameCompanyToRemove= dataGridViewOnAddCompanyForm.CurrentRow.Cells[1].Value.ToString();
            Company CompanyToRemove = _dictionar.GetObjectByName<Company>(NameCompanyToRemove);
            _dictionar.Delete(CompanyToRemove);
            
            RefreshForm();
        }

        private void BtnUpdateONAddCompanyForm_Click(object sender, EventArgs e)
        {
            var NameCompanyToUpdate = dataGridViewOnAddCompanyForm.CurrentRow.Cells[1].Value.ToString();
            txtBxCompanyName.Text = NameCompanyToUpdate;
            btnSaveCompany.Text = "Update";

        }

        private void BtnSelectONAddCompanyForm_Click(object sender, EventArgs e)
        {
            mainForm = Owner as MainForm;
            var company = _dictionar.GetObjectByName<Company>(dataGridViewOnAddCompanyForm.SelectedRows[0].Cells[1].Value.ToString());
            
            if (company != null)
            {
                mainForm.cmBxCompany.Text = string.Empty;
                mainForm.cmBxCompany.SelectedText = company.CompanyName;
                this.Close();
            }

        }

        private void AddCompanyForm_Closing(object sender, FormClosingEventArgs e)
        {
            mainForm = Owner as MainForm;
            try
            {
                var companyName = dataGridViewOnAddCompanyForm.SelectedCells[1].Value.ToString();
                mainForm.cmBxCompany.Text = string.Empty;
                mainForm.cmBxCompany.SelectedText = companyName;
                mainForm.RefreshMainForm();
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void TxtBxEnterCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveCompany.PerformClick();

            }
        }


    }
}
