using ChreneLib.Controls.TextBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model.DB_dentist_clinicEntitiess myDB = new Model.DB_dentist_clinicEntitiess();
        private void elTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //////////////////First DataGridView
            DataGridViewP.AutoGenerateColumns = false;
            DataGridViewP.ColumnCount = 5;
            DataGridViewP.DefaultCellStyle.BackColor = Color.AliceBlue;

            DataGridViewP.Columns[0].Visible = true;
            DataGridViewP.Columns[0].HeaderText = "id";
            DataGridViewP.Columns[0].DataPropertyName = "Id";
            DataGridViewP.Columns[0].Name = "Id";

            DataGridViewP.Columns[1].Visible = true;
            DataGridViewP.Columns[1].HeaderText = "name";
            DataGridViewP.Columns[1].DataPropertyName = "name";

            DataGridViewP.Columns[2].Visible = true;
            DataGridViewP.Columns[2].HeaderText = "last name";
            DataGridViewP.Columns[2].DataPropertyName = "famliy";

            DataGridViewP.Columns[3].Visible = true;
            DataGridViewP.Columns[3].HeaderText = "tell";
            DataGridViewP.Columns[3].DataPropertyName = "tell";


            DataGridViewP.Columns[4].Visible = true;
            DataGridViewP.Columns[4].HeaderText = "Address";
            DataGridViewP.Columns[4].DataPropertyName = "address";
            DataGridViewP.DataSource = myDB.TBL_Patients.ToList();
            //////////////////////////////////
            ///Second DataGridView
            ///
            DataGridViewD.AutoGenerateColumns = false;
            DataGridViewD.ColumnCount = 4;
            DataGridViewD.DefaultCellStyle.BackColor = Color.AliceBlue;

            DataGridViewD.Columns[0].Visible = true;
            DataGridViewD.Columns[0].HeaderText = "id";
            DataGridViewD.Columns[0].DataPropertyName = "Id";
            DataGridViewD.Columns[0].Name = "Id";

            DataGridViewD.Columns[1].Visible = true;
            DataGridViewD.Columns[1].HeaderText = "name";
            DataGridViewD.Columns[1].DataPropertyName = "name";

            DataGridViewD.Columns[2].Visible = true;
            DataGridViewD.Columns[2].HeaderText = "last name";
            DataGridViewD.Columns[2].DataPropertyName = "Lname";

            DataGridViewD.Columns[3].Visible = true;
            DataGridViewD.Columns[3].HeaderText = "type id";
            DataGridViewD.Columns[3].DataPropertyName = "docTypeId";
            DataGridViewD.Columns[3].Width = 60;
            DataGridViewD.DataSource=myDB.TBL_doctors.ToList();
        }

        private void btn_AddPat_Click(object sender, EventArgs e)
        {
            Model.TBL_Patients newPatient = new Model.TBL_Patients();
            newPatient.name = txt_AddPatName.Text;
            newPatient.famliy = txt_AddPatFamily.Text;
            newPatient.tell = txt_AddPatTell.Text;
            newPatient.address = txt_EdtPatAdrs.Text;
            myDB.TBL_Patients.Add(newPatient);
            int savechange = myDB.SaveChanges();

            if (savechange != 0)
            {
                MessageBox.Show("اطلاعات جدید با موفثیت ثبت شد");
            }
            DataGridViewP.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
            foreach (var item in Tb_NewRecPat.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
        }
    }
}
