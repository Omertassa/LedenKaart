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

        int NumberOfSkipped;
        int NumberOfImported;

        public FormMain()
        {
            InitializeComponent();

            LabelUpdater("Importeer een excel bestand");
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormCredentials formCreds = new FormCredentials();
            formCreds.ShowDialog();
            this.Show();
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
              import = new Importer();
   
              if (import.SetFileToDataGrid()) { 
                
                buttonImport.Enabled = false;
                buttonSend.Enabled = true;

                var values = import.DataGridToArray();
                LabelUpdater(values.Item2 + " leden ingelezen. \n" + values.Item1 + " leden zijn hoofdbewoner");

                if (values.Item2 == 0)
                {
                    buttonImport.Enabled = true;
                    buttonSend.Enabled = false;


                }
                else {

                    if (Importer.adresSkippedList.Count != 0)
                    {
                        splitContainer1.Panel2.Enabled = true;

                        label3.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;

                        ListLabelUpdater(0, "Skipped");

                    }
                    else
                    {
                        NextSkipped.Enabled = false;
                        PreviousSkipped.Enabled = false;

                    }

                    if (Importer.adresList.Count != 0)
                    {
                        splitContainer1.Panel2.Enabled = true;

                        label13.Visible = true;
                        label20.Visible = true;
                        label18.Visible = true;

                        ListLabelUpdater(0, "Imported");
                    }

                    else
                    {
                        NextImported.Enabled = false;
                        PreviousImported.Enabled = false;
                    }


                    CounterUpdater();
                }

            }
            
        }

        public void LabelUpdater(string labelText) {

            statusLabel.Text = labelText;

        }

        private void NextSkipped_Click(object sender, EventArgs e)
        
        {
            NumberOfSkipped = import.ShowSkippedMembers(true);
            ListLabelUpdater(NumberOfSkipped, "Skipped");
        }

        private void PreviousSkipped_Click(object sender, EventArgs e)
        {
            NumberOfSkipped = import.ShowSkippedMembers(false);
            ListLabelUpdater(NumberOfSkipped, "Skipped");
         }

        private void NextImported_Click(object sender, EventArgs e)
        {
            NumberOfImported = import.ShowImportedMembers(true);
            ListLabelUpdater(NumberOfImported, "Imported");
        }

        private void PreviousImported_Click(object sender, EventArgs e)
        {
            NumberOfImported = import.ShowImportedMembers(false);
            ListLabelUpdater(NumberOfImported, "Imported");
      
        }

        private void CounterUpdater() {

            labelCounterSkipped.Text = ((NumberOfSkipped+1) + "/" + Importer.adresSkippedList.Count);
            labelCounterImported.Text = ((NumberOfImported+1) + "/" + Importer.adresList.Count);

        }

        private void ListLabelUpdater(int i ,string initiator) {

            if (initiator == "Skipped") {

                labelFullNameSkipped.Text = (Importer.adresSkippedList[i].Initials + " " + Importer.adresSkippedList[i].Infix + " " + Importer.adresSkippedList[i].SurName);
                labelAdresSkipped.Text = Importer.adresSkippedList[i].Adres;
                labelPostcodeSkipped.Text = Importer.adresSkippedList[i].Postcode;
                labelLocationSkipped.Text = Importer.adresSkippedList[i].Location;
                labelEmailSkipped.Text = Importer.adresSkippedList[i].EmailAdres;
                labelPhoneSkipped.Text = Importer.adresSkippedList[i].PhoneNumber;
                labelMobileSkipped.Text = Importer.adresSkippedList[i].MobileNumber;

                //Gezins leden laden ( er is altijd 1 )

                dataGridView2.DataSource = (Importer.ConvertToDatatable(Importer.memberSkippedList, Importer.adresSkippedList[i].MainMemberNr));

            }

            else {

                labelFullName.Text = (Importer.adresList[i].Initials + " " + Importer.adresList[i].Infix + " " + Importer.adresList[i].SurName);
                labelAdres.Text = Importer.adresList[i].Adres;
                labelPostcode.Text = Importer.adresList[i].Postcode;
                labelLocation.Text = Importer.adresList[i].Location;
                labelEmail.Text = Importer.adresList[i].EmailAdres;
                labelPhone.Text = Importer.adresList[i].PhoneNumber;
                labelMobile.Text = Importer.adresList[i].MobileNumber;

                //Gezins leden laden ( er is altijd 1 )
                dataGridView1.DataSource=Importer.ConvertToDatatable(Importer.memberList, Importer.adresList[i].MainMemberNr);

            }

            CounterUpdater();
        }
    }
}
