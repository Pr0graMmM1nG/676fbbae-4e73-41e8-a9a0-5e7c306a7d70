using StageCalculator.Adapter;
using StageCalculator.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StageCalculator.Validation;

namespace StageCalculator.Repositories
{
    
    public partial class AddPersonForm : Form
    {
        private ComboDictionary _dictionar = new ComboDictionary();
        private MainForm mainForm;
        public AddPersonForm()
        {
            InitializeComponent();
        }

       
        private void RefreshForm()
        {
            _dictionar.FillDictionar<Person>();
            //trebuie de revizuit ce scoatem din baza de date >> alegem totul apoi sortuim sau deja sortuit scoatem
            var People = _dictionar.Dictionar.Select(c =>(Person)c.Value).OrderByDescending(x => x.PersonId);
            if (People.Any())
            {
                // Vrode treb sa mearga rindu ista
                dataGridViewOnAddPersonForm.DataSource = People.Select(x=>new { id= x.GetID(),name= x.GetName(),idno= x.Buletin.BuletinPersonalCode}).ToList();
                dataGridViewOnAddPersonForm.Columns[0].HeaderText = "ID";
                dataGridViewOnAddPersonForm.Columns[1].HeaderText = "Nume Prenume";
                dataGridViewOnAddPersonForm.Columns[2].HeaderText = "IDNO";
                foreach (DataGridViewColumn col in dataGridViewOnAddPersonForm.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                dataGridViewOnAddPersonForm.Columns[0].Width = 60;
                dataGridViewOnAddPersonForm.Columns[1].Width = 200;
                // dataGridViewOnAddPersonForm.Columns[0].Width = 60;
                ClearPersonFields();
            }
            else
            {
                dataGridViewOnAddPersonForm.DataSource = null;
            }
            
        }
       
        private void AddPersonForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private Person GetNewPerson()
        {
            var nume = txtBxPersonName.Text.GetString(out string Name);
            var prenume = txtBxPersonFamily.Text.GetString(out string secondName);
            var patronimic = txtBxPersonLastName.Text.GetString(out string LastName);
            var idno = txtBxBuletinIDNO.Text.GetString(out string IDNO);
            //trebuie de scos verificarea idno la null sau empty pentru o mai buna treaba
         if(nume&&prenume&&patronimic&&idno)
            {
                var buletin = new Buletin
                {
                    BuletinBirthDate = dateTimePickerBirthDate.Value,
                    BuletinBirthPlace = txtBxBirthPlace.Text,
                    BuletinBloodGroup = cmBxBloodGroup.Text,
                    BuletinHeight = txtBxHeight.Text,
                    BuletinEyesColor = txtBxEyesColor.Text,
                    BuletinSex = cmBxSex.Text,
                    BuletinSeria = txtBxBuletinSeria.Text,
                    BuletinPersonalCode = IDNO,
                    BuletinCreateDate = dateTimePickerCreationDateBuletin.Value,
                    BuletinExpireDate = dateTimePickerExpireBuletin.Value

                };
                
                var person = new Person
                {
                    PersonName=Name,
                    PersonFamily=secondName,
                    PersonLastName=LastName,
                    Buletin=buletin,
                    BuletinId=buletin.BuletinId
                  
                    
                };

                return person;
                
            }
            else
            {
                var buletin = new Buletin
                {
                    BuletinBirthDate = dateTimePickerBirthDate.Value,
                    BuletinBirthPlace = txtBxBirthPlace.Text,
                    BuletinBloodGroup = cmBxBloodGroup.Text,
                    BuletinHeight = txtBxHeight.Text,
                    BuletinEyesColor = txtBxEyesColor.Text,
                    BuletinSex = cmBxSex.Text,
                    BuletinSeria = txtBxBuletinSeria.Text,
                    BuletinPersonalCode = "0000 0000 0000 0000 0000",
                    BuletinCreateDate = dateTimePickerCreationDateBuletin.Value,
                    BuletinExpireDate = dateTimePickerExpireBuletin.Value

                };

                var person = new Person
                {
                    PersonName = "NoName",
                    PersonFamily = "NoSecondName",
                    PersonLastName = "NoLastName",
                    Buletin = buletin,
                    BuletinId = buletin.BuletinId


                };
                return person;
            }
           
            
        }

        private void ClearPersonFields()
        {
            dateTimePickerBirthDate.Value= DateTime.Today;
            txtBxBirthPlace.Text = string.Empty;
            cmBxBloodGroup.SelectedIndex = -1;
            txtBxHeight.Text = string.Empty;
            txtBxEyesColor.Text = string.Empty;
            cmBxSex.SelectedIndex = -1;
            txtBxBuletinSeria.Text = string.Empty;
            txtBxBuletinIDNO.Text = string.Empty;
            dateTimePickerCreationDateBuletin.Value = DateTime.Today;
            dateTimePickerExpireBuletin.Value = DateTime.Today;
            txtBxPersonName.Text = string.Empty;
            txtBxPersonFamily.Text = string.Empty;
            txtBxPersonLastName.Text = string.Empty;
        }
       
        private void SetPersonToForm(Person personToSetParam)
        {
            dateTimePickerBirthDate.Value = personToSetParam.Buletin.BuletinBirthDate;
            txtBxBirthPlace.Text = personToSetParam.Buletin.BuletinBirthPlace;
            cmBxBloodGroup.SelectedItem = personToSetParam.Buletin.BuletinBloodGroup;
            txtBxHeight.Text = personToSetParam.Buletin.BuletinHeight;
            txtBxEyesColor.Text = personToSetParam.Buletin.BuletinEyesColor;
            cmBxSex.SelectedItem = personToSetParam.Buletin.BuletinSex;
            txtBxBuletinSeria.Text = personToSetParam.Buletin.BuletinSeria;
            txtBxBuletinIDNO.Text = personToSetParam.Buletin.BuletinPersonalCode;
            dateTimePickerCreationDateBuletin.Value = personToSetParam.Buletin.BuletinCreateDate;
            dateTimePickerExpireBuletin.Value = personToSetParam.Buletin.BuletinExpireDate;
            txtBxPersonName.Text = personToSetParam.PersonName;
            txtBxPersonFamily.Text = personToSetParam.PersonFamily;
            txtBxPersonLastName.Text = personToSetParam.PersonLastName;

        }
        private Person GetPersonFromForm(Person objectParam)
        {

            objectParam.Buletin.BuletinBirthDate= dateTimePickerBirthDate.Value;
            objectParam.Buletin.BuletinBirthPlace= txtBxBirthPlace.Text;
            objectParam.Buletin.BuletinBloodGroup= cmBxBloodGroup.Text;
            objectParam.Buletin.BuletinHeight= txtBxHeight.Text;
            objectParam.Buletin.BuletinEyesColor= txtBxEyesColor.Text;
            objectParam.Buletin.BuletinSex= cmBxSex.Text;
            objectParam.Buletin.BuletinSeria= txtBxBuletinSeria.Text;
            objectParam.Buletin.BuletinPersonalCode= txtBxBuletinIDNO.Text;
            objectParam.Buletin.BuletinCreateDate= dateTimePickerCreationDateBuletin.Value;
            objectParam.Buletin.BuletinExpireDate= dateTimePickerExpireBuletin.Value;
            objectParam.PersonName= txtBxPersonName.Text;
            objectParam.PersonFamily= txtBxPersonFamily.Text;
            objectParam.PersonLastName= txtBxPersonLastName.Text;
            return objectParam;

        }

        private void btnSaveONAddPersonForm_click(object sender, EventArgs e)
        {

            if (btnSaveOnAddPersonForm.Text=="Save")
            {
                _dictionar.Add(GetNewPerson().GetName(), GetNewPerson());
                
                RefreshForm();
            }
            else
            {
                var NamePersonToUpdate = dataGridViewOnAddPersonForm.CurrentRow.Cells[1].Value.ToString();
                Person PersonToUpdate = _dictionar.GetObjectByName<Person>(NamePersonToUpdate);
                if (!string.IsNullOrEmpty(NamePersonToUpdate))
                {
                    
                    var nume = txtBxPersonName.Text.GetString(out string Name);
                    var prenume = txtBxPersonFamily.Text.GetString(out string secondName);
                    var patronimic = txtBxPersonLastName.Text.GetString(out string LastName);
                    var idno = txtBxBuletinIDNO.Text.GetString(out string IDNO);
                    if (nume && prenume && patronimic && idno)
                    {
                        GetPersonFromForm(PersonToUpdate);
                        btnSaveOnAddPersonForm.Text = "Save";
                        _dictionar.Update(PersonToUpdate);
                    }
                    else
                    {
                        MessageBox.Show($"Person no updated: Oceni importantnie fields nu sunt pline");
                    }
                }
                else
                {
                    MessageBox.Show($"Person no updated");
                }

                RefreshForm();
            }
        }
        private void BtnSelectOnAddPersonForm_click(object sender, EventArgs e)
        {
            mainForm = Owner as MainForm;
            var person = _dictionar.GetObjectByName<Person>(dataGridViewOnAddPersonForm.SelectedRows[0].Cells[1].Value.ToString());

            if (person != null)
            {
                mainForm.cmBxPerson.Text = string.Empty;
                mainForm.cmBxPerson.SelectedText = person.GetName();
                this.Close();
            }
        }
        private void BtnRemoveOnAddPersonForm_click(object sender, EventArgs e)
        {
            var NamePersonToRemove = dataGridViewOnAddPersonForm.CurrentRow.Cells[1].Value.ToString();
            Person PersonToRemove = _dictionar.GetObjectByName<Person>(NamePersonToRemove);
            _dictionar.Delete(PersonToRemove);

            RefreshForm();
        }

        private void BtnUpdateOnAddPersonForm_click(object sender, EventArgs e)
        {
            var NamePersonToUpdate = dataGridViewOnAddPersonForm.CurrentRow.Cells[1].Value.ToString();
            Person PersonToUpdate = _dictionar.GetObjectByName<Person>(NamePersonToUpdate);
            SetPersonToForm(PersonToUpdate);
            btnSaveOnAddPersonForm.Text = "Update";
        }

        private void AddPersonForm_cClosing(object sender, FormClosingEventArgs e)
        {
            mainForm = Owner as MainForm;
            try
            {
                var PersonName = dataGridViewOnAddPersonForm.SelectedCells[1].Value.ToString();
                mainForm.cmBxPerson.Text = string.Empty;
                mainForm.cmBxPerson.SelectedText = PersonName;
                mainForm.RefreshMainForm();
            }
            catch (Exception)
            {
                return;
            }
            
            
                
            
            
        }
    }
}
