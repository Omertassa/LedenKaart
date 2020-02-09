using ExcelDataReader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ledenkaart_Verzender
{
    
    public partial class FormMain : Form
    {
        Importer import;
        FormCredentials formCreds;

        int NumberOfSkipped;
        int NumberOfImported;

        public FormMain()
        {
            Initialize();
        }

        internal void Initialize()
        {

            InitializeComponent();

            import = new Importer();
            formCreds = new FormCredentials();
            LabelUpdater("Importeer een excel bestand");

        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
              if (import.SetFileToDataGrid()) { 
                
                btnImport.Enabled = false;
                btnSend.Enabled = true;

                var values = import.DataGridToArray();
                LabelUpdater(values.Item2 + " leden ingelezen. \n" + values.Item1 + " leden zijn hoofdbewoner");

                if (values.Item2 == 0)
                {
                    btnImport.Enabled = true;
                    btnSend.Enabled = false;

                    LabelUpdater("Importeer een excel bestand");

                }
                else {

                    if (Importer.adresSkippedList.Count != 0)
                    {
                        splitContainer1.Panel2.Enabled = true;

                        lblEmailAdresSkipped.Visible = true;
                        lblPhoneNumberSkipped.Visible = true;
                        lblMobileNumberSkipped.Visible = true;

                        UpdateLabelSkipped(0);

                    }
                    else
                    {
                        btnNextSkipped.Enabled = false;
                        btnPreviousSkipped.Enabled = false;

                    }

                    if (Importer.adresList.Count != 0)
                    {
                        splitContainer1.Panel2.Enabled = true;

                        lblEmailAdresImported.Visible = true;
                        label20.Visible = true;
                        lblMobileImported.Visible = true;

                        UpdateLabelImported(0);
                    }

                    else
                    {
                        btnNextImported.Enabled = false;
                        btnPreviousImported.Enabled = false;
                    }


                    UpdateCounter();
                }

            }
            
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCreds.ShowDialog();
            this.Show();
        }

        public void LabelUpdater(string labelText) {

            lblStatus.Text = labelText;

        }

        private void NextSkipped_Click(object sender, EventArgs e)
        
        {
            NumberOfSkipped = import.ShowSkippedMembers(true);
            UpdateLabelSkipped(NumberOfSkipped);
        }

        private void PreviousSkipped_Click(object sender, EventArgs e)
        {
            NumberOfSkipped = import.ShowSkippedMembers(false);
            UpdateLabelSkipped(NumberOfSkipped);
         }

        private void NextImported_Click(object sender, EventArgs e)
        {
            NumberOfImported = import.ShowImportedMembers(true);
            UpdateLabelImported(NumberOfImported);
        }

        private void PreviousImported_Click(object sender, EventArgs e)
        {
            NumberOfImported = import.ShowImportedMembers(false);
            UpdateLabelImported(NumberOfImported);
      
        }

        private void UpdateCounter() {

            lblCounterSkipped.Text = ((NumberOfSkipped+1) + "/" + Importer.adresSkippedList.Count);
            lblCounterImported.Text = ((NumberOfImported+1) + "/" + Importer.adresList.Count);

        }

        private void UpdateLabelImported(int i) {

                lblFullNameImported.Text = (Importer.adresList[i].Initials + " " + Importer.adresList[i].Infix + " " + Importer.adresList[i].SurName);
                lblAdresImported.Text = Importer.adresList[i].Adres;
                lblPostodeImported.Text = Importer.adresList[i].Postcode;
                lblLocationImported.Text = Importer.adresList[i].Location;
                labelEmail.Text = Importer.adresList[i].EmailAdres;
                labelPhone.Text = Importer.adresList[i].PhoneNumber;
                labelMobile.Text = Importer.adresList[i].MobileNumber;

                //Gezins leden laden ( er is altijd 1 )
                dataGridView1.DataSource=Importer.ConvertToDatatable(Importer.memberList, Importer.adresList[i].MainMemberNr);
                 UpdateCounter();

        }

        private void UpdateLabelSkipped(int i) {

                lblFullNameSkipped.Text = (Importer.adresSkippedList[i].Initials + " " + Importer.adresSkippedList[i].Infix + " " + Importer.adresSkippedList[i].SurName);
                lblAdresSkipped.Text = Importer.adresSkippedList[i].Adres;
                lblPostcodeSkipped.Text = Importer.adresSkippedList[i].Postcode;
                lblLocationSkipped.Text = Importer.adresSkippedList[i].Location;
                labelEmailSkipped.Text = Importer.adresSkippedList[i].EmailAdres;
                labelPhoneSkipped.Text = Importer.adresSkippedList[i].PhoneNumber;
                labelMobileSkipped.Text = Importer.adresSkippedList[i].MobileNumber;

                //Gezins leden laden ( er is altijd 1 )

                dataGridView2.DataSource = (Importer.ConvertToDatatable(Importer.memberSkippedList, Importer.adresSkippedList[i].MainMemberNr));
                  UpdateCounter();
        }

        }
    
    }

