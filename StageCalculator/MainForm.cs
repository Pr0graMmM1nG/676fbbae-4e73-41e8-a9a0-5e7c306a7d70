using StageCalculator.Models;
using StageCalculator.Repositories;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StageCalculator.MyForm;
using StageCalculator.Validation;
using StageCalculator.Calculator;

namespace StageCalculator
{
    public partial class MainForm : Form
    {
        BaseOperation OperationCRUD = new BaseOperation();
        Adapter.ComboDictionary CompanyDB = new Adapter.ComboDictionary();
        Adapter.ComboDictionary PersonDB = new Adapter.ComboDictionary();
        //private DateTimeCalculator _calc = new DateTimeCalculator();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddCompany_btnClick(object sender, EventArgs e)
        {
            AddCompanyForm addCompanyFRM = new AddCompanyForm();
            addCompanyFRM.ShowDialog(this);
            RefreshMainForm();

        }
        private void btnAddPersonForm_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonFRM = new AddPersonForm();
            addPersonFRM.ShowDialog(this);
            RefreshMainForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            RefreshMainForm();
        }

        private void FillCompanyToCombobox()
        {
            cmBxCompany.Items.Clear();
            CompanyDB.FillDictionar<Company>();
            foreach (var item in CompanyDB.Dictionar)
            {
                cmBxCompany.Items.Add(item.Key);
            }
        }
        private void FillPersonToCombobox()
        {
            cmBxPerson.Items.Clear();
            PersonDB.FillDictionar<Person>();
            foreach (var item in PersonDB.Dictionar)
            {
                cmBxPerson.Items.Add(item.Key);
            }
        }
        public void RefreshMainForm()
        {
            FillPersonToCombobox();
            FillCompanyToCombobox();
            ShowStage();
        }

        private void btnSaveOnMainForm_click(object sender, EventArgs e)
        {
            SaveStage();
            ShowStage();
        }
        private void SaveStage()
        {
            bool name = cmBxPerson.Text.GetString(out string NamePerson);
            bool company = cmBxCompany.Text.GetString(out string NameCompany);
            if (name && company)
            {
                Person prs = PersonDB.GetObjectByName<Person>(NamePerson);
                Company cmp = CompanyDB.GetObjectByName<Company>(NameCompany);
                if (prs != null && cmp != null)
                {
                    var bgn = dateTimePickerBegin.Value;
                    var end = dateTimePickerEnd.Value;
                    Stage stg = new Stage
                    {
                        PersonId = prs.PersonId,
                        CompanyId = cmp.CompanyId,
                        StageBeginDate = bgn,
                        StageEndDate = end

                    };

                    OperationCRUD.Add(stg);
                    OperationCRUD.Save();
                }
                else
                {
                    MessageBox.Show($"No item in dataBase: si mai rau");
                }


            }
            else
            {
                MessageBox.Show($"No item in dataBase: Person={name} Company={company}");
            }

        }

        private void ShowStage()
        {

            
            var _context = new StageCalculator.Context.StageEntity();
            var stage = _context.Stages.Include("Person").Include("Company").ToList();
            if (stage.Count>=1)
            {
                // Vrode treb sa mearga rindu ista
                dateGridViewMain.DataSource = stage.Select(x => new {
                    idStage = x.StageId,
                    namePerson = x.Person.GetName(),
                    BeginDate = x.StageBeginDate.ToShortDateString(),
                    EndDate = x.StageEndDate.ToShortDateString(),
                    nameCompany = x.Company.GetName()
                   // stagiu = calc.DeltaTime(x.StageBeginDate, x.StageEndDate)
                }).ToList();
                dateGridViewMain.Columns[0].HeaderText = "ID";
                dateGridViewMain.Columns[1].HeaderText = "Nume Prenume";
                dateGridViewMain.Columns[2].HeaderText = "Begin";
                dateGridViewMain.Columns[3].HeaderText = "End";
                dateGridViewMain.Columns[4].HeaderText = "Company";
                //dateGridViewMain.Columns[5].HeaderText = "Stagiu";
                foreach (DataGridViewColumn col in dateGridViewMain.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                dateGridViewMain.Columns[0].Width = 45;
                dateGridViewMain.Columns[1].Width = 150;
                dateGridViewMain.Columns[4].Width = 150;


            }
            else
            {
                dateGridViewMain.DataSource = null;
            }
        }

        private void btnDeleteOnMainForm(object sender, EventArgs e)
        {
            var _context = new StageCalculator.Context.StageEntity();
            var stage = _context.Stages.ToList();
            if (stage.Count >= 1)
            {
                var IdStageToRemove = Convert.ToInt32(dateGridViewMain.CurrentRow.Cells[0].Value);
                foreach (var item in stage)
                {
                    if(item.StageId == IdStageToRemove)
                    {
                        _context.Stages.Remove(item);
                        _context.SaveChanges();
                        break;
                    }
                    

                   
                }
                
            }
            ShowStage();
        }

        private void raportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportForm RaportFRM = new RaportForm();
            RaportFRM.ShowDialog(this);
            

        }
    }
}
