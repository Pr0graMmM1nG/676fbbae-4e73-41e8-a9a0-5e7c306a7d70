using StageCalculator.Calculator;
using StageCalculator.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StageCalculator.Validation;

namespace StageCalculator
{
    public partial class RaportForm : Form
    {
        StageCalculator.Context.StageEntity _context = new Context.StageEntity();
        private DateTimeCalculator calc = new DateTimeCalculator();
        //public string TotalResult;
        private IEnumerable<Stage> StageList;
        public RaportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectByPerson();
        }    

        private void RaportForm_Load(object sender, EventArgs e)
        {
            var PersonList = _context.Persons.ToList();
            var CompanyList = _context.Companys.ToList();
            foreach (var item in PersonList)
            {
                comboBox1.Items.Add(item.GetName());
            }
            comboBox2.Items.Add("");
            foreach (var item in CompanyList)
            {
                
                comboBox2.Items.Add(item.GetName());
            }
            RefreshRaportForm();

        }

        private void PersonChanged_Selectionchanged(object sender, EventArgs e)
        {
            
        }

        private void RefreshRaportForm()
            {
                var StageList = _context.Stages.Include("Person").Include("Company").ToList();
                if (StageList.Any())
                {
                    // Vrode treb sa mearga rindu ista
                    dataGridViewRaport.DataSource = StageList.Select(x => new
                    {
                        idStage = x.StageId,
                        namePerson = x.Person.GetName(),
                        BeginDate = x.StageBeginDate.Year,
                        EndDate = x.StageEndDate.Year,
                        nameCompany = x.Company.GetName(),
                        stagiu = calc.DeltaTime(x.StageBeginDate, x.StageEndDate)
                    }).ToList();
                    dataGridViewRaport.Columns[0].HeaderText = "ID";
                    dataGridViewRaport.Columns[1].HeaderText = "Nume Prenume";
                    dataGridViewRaport.Columns[2].HeaderText = "Begin";
                    dataGridViewRaport.Columns[3].HeaderText = "End";
                    dataGridViewRaport.Columns[4].HeaderText = "Company";
                    dataGridViewRaport.Columns[5].HeaderText = "Stagiu";
                    foreach (DataGridViewColumn col in dataGridViewRaport.Columns)
                    {
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                    }

                    dataGridViewRaport.Columns[0].Width = 45;
                    dataGridViewRaport.Columns[1].Width = 150;
                    dataGridViewRaport.Columns[4].Width = 150;


                }
                else
                {
                    dataGridViewRaport.DataSource = null;
                }
        }

        private void SelectByPerson()
        {
            lblStage.Text = string.Empty;
            var _person = comboBox1.Text.GetString(out string PersonParam);
            var _company = comboBox2.Text.GetString(out string CompanyParam);
            if (_person)
            {
                if(_company)
                {
                    StageList = _context.Stages.Include("Person").Include("Company").ToList().Where(c => c.Person.GetName() == PersonParam).Where(c => c.Company.GetName() == CompanyParam);
                }
                else
                {
                    StageList = _context.Stages.Include("Person").Include("Company").ToList().Where(c => c.Person.GetName() == PersonParam);
                }
                 
                if (StageList.Any())
                {
                    // Vrode treb sa mearga rindu ista

                    
                    var extract= StageList.Select(x => new
                    {
                        idStage = x.StageId,
                        namePerson = x.Person.GetName(),
                        BeginDate = x.StageBeginDate.Year,
                        EndDate = x.StageEndDate.Year,
                        nameCompany = x.Company.GetName(),
                        stagiu = calc.DeltaTime(x.StageBeginDate, x.StageEndDate)
                    }).ToList();
                     int years = 0, months = 0, days = 0;
                        foreach (var item in extract)
                        {
                            string[] separate = item.stagiu.Split('.');
                            years = years + Convert.ToInt32(separate[0]);
                            months = months + Convert.ToInt32(separate[1]);
                            days = days + Convert.ToInt32(separate[2]);
                        }
                    lblStage.Text = calc.YMD(years, months, days);
                    
                    dataGridViewRaport.DataSource = extract;
                    dataGridViewRaport.Columns[0].HeaderText = "ID";
                    dataGridViewRaport.Columns[1].HeaderText = "Nume Prenume";
                    dataGridViewRaport.Columns[2].HeaderText = "Begin";
                    dataGridViewRaport.Columns[3].HeaderText = "End";
                    dataGridViewRaport.Columns[4].HeaderText = "Company";
                    dataGridViewRaport.Columns[5].HeaderText = "Stagiu";
                    foreach (DataGridViewColumn col in dataGridViewRaport.Columns)
                    {
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                    }

                    dataGridViewRaport.Columns[0].Width = 45;
                    dataGridViewRaport.Columns[1].Width = 150;
                    dataGridViewRaport.Columns[4].Width = 150;
                    


                }
                else
                {
                    dataGridViewRaport.DataSource = null;
                }
            }
        }
    }//end class
}//end Namespace
