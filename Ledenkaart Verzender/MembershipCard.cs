using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Collections;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf.Extgstate;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Hyphenation;
using iText.Layout.Layout;
using iText.Layout.Properties;
using iText.Layout.Renderer;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using System.Net.Mail;
using MessageBox = System.Windows.Forms.MessageBox;
using Ledenkaart_Verzender.Properties;


namespace Ledenkaart_Verzender
{
    class MembershipCard

    {

        readonly Logger log = new Logger();

        readonly string CurrentYear = DateTime.Now.Year.ToString();
        int numberOfMailsSend;

        public int CreateMembershipCard(String email, string password, string smtpServer, int smtpPort, bool SSl)
        {

            int mainMember;

            string pathShort = System.Windows.Forms.Application.StartupPath + "\\Images";
            string pathLong = System.Windows.Forms.Application.StartupPath + "\\Ledenkaarten";
            if (!Directory.Exists(pathShort))
            {
                Directory.CreateDirectory(pathShort);
                            {
                Directory.CreateDirectory(pathShort);
            }
            }

            if (!Directory.Exists(pathLong))
            {
                Directory.CreateDirectory(pathLong);
                {
                    Directory.CreateDirectory(pathLong);
                }
            }

            var exportFolder = pathLong;

            String footerVereniging = "Uitvaart vereniging De Laatste Eer";
            String footerAdres = "p / a Krússtrjitte 2";
            String footerSplitter = " | ";
            String footerPostcode = "9041 BV";
            String footerLocation = "Berltsum";
            String footerPhoneNumber = "T 0653 64 03 98";
            String footerEmailAdres = "E dle.berlikum @gmail.com";
            String footerWebsite = "www.dleberlikum.nl";


            Text GeefWijzigingenDoorHeader = new Text("GEEF WIJZIGINGEN ALTIJD DOOR\n").SetBold().SetFontSize(12);
            Text GeefWijzigingenDoorText = new Text("Controleer alsjeblieft de vermelde gegevens op deze ledenkaart en geef de gegevens die ontbreken door. Dat geldt ook voor gegevens die niet meer kloppen.").SetFontSize(10);

            Text MeldpuntHeader = new Text("MELDPUNT BIJ OVERLIJDEN\n").SetBold().SetFontSize(12);
            Text Meldpunt = new Text("Neem bij een overlijden contact op met onze bode, Sybren Klaas Visser van Oosterbierum. \n Hij is 24/7 bereikbaar op ").SetFontSize(10);
            Text BodeNummer = new Text("0653 84 23 74 of 0518 48 14 42.").SetBold().SetFontSize(10);
            Text MeldpuntTip = new Text("\nOm praktische redenen is het soms beter dat wij een uitvaart niet verzorgen. \n").SetFontSize(10);
            Text MeldpuntVoorbeeld = new Text("Bijvoorbeeld als je ver weg woont.\n").SetFontSize(10);
            Text Waarschuwing = new Text("Handel alleen nooit buiten de vereniging om, want daarmee vervalt het recht op ledenkorting.").SetBold().SetFontSize(10);

            // Kinderen zijn gratis lid

            Text KinderenGratisLidHeader = new Text("KINDEREN GRATIS LID\n").SetBold().SetFontSize(12);
            Text KinderenGratisLidText1 = new Text("Kinderen tot 18 jaar zijn ").SetFontSize(10);
            Text KinderenGratisLidText2 = new Text("gratis lid").SetBold().SetFontSize(10);
            Text KinderenGratisLidText3 = new Text(" van de vereniging en hebben recht op ledenkorting in geval van overlijden (100% als beide ouders lid zijn, 50% als één van de ouder lid is). ").SetFontSize(10);
            Text KinderenGratisLidText4 = new Text("De enige voorwaarde die wij stellen is dat ouders hun kinderen hebben laten inschrijven als lid.").SetBold().SetFontSize(10);
            Text KinderenGratisLidText5 = new Text("Nog niet gedaan? Schrijf je kind dan nu in als lid.").SetFontSize(10);

            //footer

            Text FooterRegel1 = new Text(footerSplitter + footerVereniging + footerSplitter + footerAdres + footerSplitter + footerPostcode + " " + footerLocation + footerSplitter + "\n").SetFontSize(8);
            Text FooterRegel2 = new Text(footerSplitter + footerPhoneNumber + footerSplitter + footerEmailAdres + footerSplitter + footerWebsite + footerSplitter).SetFontSize(8);

            Paragraph geefWijzigingenDoor = new Paragraph();
            geefWijzigingenDoor.Add(GeefWijzigingenDoorHeader);
            geefWijzigingenDoor.Add(GeefWijzigingenDoorText);
            geefWijzigingenDoor.SetFixedPosition(10, 230, 538);

            Paragraph meldPuntBijOverlijden = new Paragraph();
            meldPuntBijOverlijden.Add(MeldpuntHeader);
            meldPuntBijOverlijden.Add(Meldpunt);
            meldPuntBijOverlijden.Add(BodeNummer);
            meldPuntBijOverlijden.Add(MeldpuntTip);
            meldPuntBijOverlijden.Add(MeldpuntVoorbeeld);
            meldPuntBijOverlijden.Add(Waarschuwing);
            meldPuntBijOverlijden.SetFixedPosition(10, 125, 538);

            Paragraph kinderenGratisLid = new Paragraph();
            kinderenGratisLid.Add(KinderenGratisLidHeader);
            kinderenGratisLid.Add(KinderenGratisLidText1);
            kinderenGratisLid.Add(KinderenGratisLidText2);
            kinderenGratisLid.Add(KinderenGratisLidText3);
            kinderenGratisLid.Add(KinderenGratisLidText4);
            kinderenGratisLid.Add(KinderenGratisLidText5);
            kinderenGratisLid.SetFixedPosition(10, 55, 538);

            Paragraph footer = new Paragraph();
            footer.Add(FooterRegel1);
            footer.Add(FooterRegel2);
            footer.SetFixedPosition(10, 10, 538);
            footer.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            foreach (var adresCard in Importer.adresList)
            {

                var exportFile = System.IO.Path.Combine(exportFolder, "Ledenkaart " + CurrentYear + " " + adresCard.Initials + adresCard.SurName + ".pdf");

                try
                {

                    String imageFile = pathShort + "\\Logo.png";
                    ImageData data = ImageDataFactory.Create(imageFile);
                    Image img = new Image(data);

                    img.SetHeight(140);
                    img.SetWidth(200);
                    img.SetFixedPosition(375, 660);

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(email)
                    };

                    System.Net.Mail.SmtpClient SmtpServer = new SmtpClient(smtpServer)
                    {
                        Port = smtpPort,
                        Credentials = new System.Net.NetworkCredential(mail.From.ToString(), password),
                        EnableSsl = SSl
                    };

                    mainMember = adresCard.MainMemberNr;

                    string aanhef = "Mevr.";
                    if (adresCard.Gender == "m")
                    {
                        aanhef = "Dhr.";
                    }

                    String AanhefLid = aanhef;
                    String VoorlettersLid = adresCard.Initials;
                    String Tussenvoegsel = adresCard.Infix;
                    String AchternaamLid = adresCard.SurName;
                    String AdresLid = adresCard.Adres;
                    String PostcodeLid = adresCard.Postcode;
                    String WoonplaatsLid = adresCard.Location;
                    String TelefoonNummerLid = adresCard.PhoneNumber;
                    String MobielNummerLid = adresCard.MobileNumber;
                    String EmailAdresLid = adresCard.EmailAdres;
                    
                    using (var writer = new PdfWriter(exportFile))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {
                           var doc = new Document(pdf);

                            doc.Add(new Paragraph("Ledenkaart " + CurrentYear).SetBold().SetFontSize(16));
                            doc.Add(img);


                            doc.Add(new Paragraph("\n\n\n\n"));

                            doc.Add(new Paragraph("Bij onbestelbaar >> Krússtrjitte 2, 9041 BV Berltsum\n").SetFontSize(8));
                            doc.Add(new Paragraph(AanhefLid + " " + VoorlettersLid + " "+ Tussenvoegsel + " " + AchternaamLid));
                            doc.Add(new Paragraph(AdresLid));
                            doc.Add(new Paragraph(PostcodeLid + " " + WoonplaatsLid + "\n\n\n"));

                            float[] columnWidths = { 5, 15, 6, 2, 10, 2, 5 };
                            Table table = new Table(UnitValue.CreatePercentArray(columnWidths));

                            Cell cell = new Cell().Add(new Paragraph("Lidnr."));
                            cell.SetBold();
                            cell.SetPaddingRight(4);
                            cell.SetWidth(40);
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            cell.SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1));
                            table.AddCell(cell);

                            cell = new Cell().Add(new Paragraph("Naam"));
                            cell.SetBold();
                            cell.SetPaddingRight(4);
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            cell.SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1));
                            table.AddCell(cell);

                            cell = new Cell().Add(new Paragraph("Geb. datum"));
                            cell.SetBold();
                            cell.SetFontSize(10);
                            cell.SetPaddingRight(4);
                            cell.SetBorder(Border.NO_BORDER);
                            cell.SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1));
                            table.AddCell(cell);

                            cell = new Cell().Add(new Paragraph("M/V"));
                            cell.SetBold();
                            cell.SetFontSize(10);
                            cell.SetPaddingRight(4);
                            cell.SetBorder(Border.NO_BORDER);
                            cell.SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1));
                            table.AddCell(cell);

                            cell = new Cell().Add(new Paragraph("IBAN"));
                            cell.SetBold();
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            cell.SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1));
                            table.AddCell(cell);

                            cell = new Cell().Add(new Paragraph("Ledenkorting"));
                            cell.SetBold();
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            cell.SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1));
                            table.AddCell(cell);

                            cell = new Cell().Add(new Paragraph("Soort Lid"));
                            cell.SetBold();
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            cell.SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1));
                            table.AddCell(cell);

                            int count = adresCard.TotalMembersOnAdres;

                            foreach (var member in Importer.memberList)
                            {

                                if (mainMember == member.MainMemberNr)
                                {


                                    //do some code
                                    String lastName = member.Infix + " " + member.SurName;

                                    if (member.IBAN == null) { member.IBAN = " "; }
                                    if (member.Infix == null) { lastName = member.SurName; }

                                    //cell lidnummer
                                    cell = new Cell().Add(new Paragraph(member.MemberNr.ToString()));
                                    cell.SetFontSize(8);
                                    cell.SetBorder(Border.NO_BORDER);
                                    table.AddCell(cell);

                                    //cell naam
                                    cell = new Cell().Add(new Paragraph(member.Initials + " (" + member.FirstName + ") " + lastName));
                                    cell.SetFontSize(8);
                                    cell.SetBorder(Border.NO_BORDER);
                                    table.AddCell(cell);

                                    //cell Geboortedatum
                                    cell = new Cell().Add(new Paragraph(member.BirthDay.ToString("dd-MM-yyyy")));
                                    cell.SetFontSize(8);
                                    cell.SetBorder(Border.NO_BORDER);
                                    table.AddCell(cell);

                                    //cell geslacht
                                    cell = new Cell().Add(new Paragraph(member.Gender));
                                    cell.SetFontSize(8);
                                    cell.SetBorder(Border.NO_BORDER);
                                    table.AddCell(cell);

                                    //cell IBAN
                                    cell = new Cell().Add(new Paragraph(member.IBAN));
                                    cell.SetFontSize(8);
                                    cell.SetBorder(Border.NO_BORDER);
                                    table.AddCell(cell);

                                    //cell Ledenkorting
                                    cell = new Cell().Add(new Paragraph(member.DiscountPercentage.ToString() + "%"));
                                    cell.SetFontSize(8);
                                    cell.SetBorder(Border.NO_BORDER);
                                    table.AddCell(cell);

                                    //cell Soort Lid
                                    cell = new Cell().Add(new Paragraph(member.TypeOfMember));
                                    cell.SetFontSize(8);
                                    cell.SetBorder(Border.NO_BORDER);
                                    table.AddCell(cell);

                                    count--;

                                    if (count == 0) { break; }

                                }
                            }

                            doc.Add(table);

                            doc.Add(new Paragraph("\n\n"));

                            Table table2 = new Table(UnitValue.CreatePercentArray(2));

                            cell = new Cell().Add(new Paragraph("Telefoon"));
                            cell.SetBold();
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            table2.AddCell(cell);

                            cell = new Cell().Add(new Paragraph(TelefoonNummerLid));
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            table2.AddCell(cell);

                            cell = new Cell().Add(new Paragraph("Mobiel"));
                            cell.SetBold();
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            table2.AddCell(cell);

                            cell = new Cell().Add(new Paragraph(MobielNummerLid));
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            table2.AddCell(cell);

                            cell = new Cell().Add(new Paragraph("Email"));
                            cell.SetBold();
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            table2.AddCell(cell);

                            cell = new Cell().Add(new Paragraph(EmailAdresLid));
                            cell.SetFontSize(10);
                            cell.SetBorder(Border.NO_BORDER);
                            table2.AddCell(cell);

                            doc.Add(table2);

                            doc.Add(new Paragraph("\n"));
                            doc.Add(geefWijzigingenDoor);
                            doc.Add(meldPuntBijOverlijden);
                            doc.Add(kinderenGratisLid);
                            doc.Add(new Paragraph("\n\n"));
                            doc.Add(footer);
                            doc.Close();

                            // mail versturen

                            mail.To.Add(adresCard.EmailAdres);
                            mail.Subject = "Ledenkaart " + CurrentYear + " de Laatste Eer Berlikum";
                            mail.Body = "Geachte " + AanhefLid + " " + Tussenvoegsel + " " + AchternaamLid + "\n\n" + "In de bijlage vindt u de ledenkaart voor het jaar " + CurrentYear +
                                        ".\nWilt u zo vriendelijk zijn ledenkaart te controleren en wijzigingen aan ons door te geven?\n\n" +
                                        "Met vriendelijke groet \n\nRia Algra \nPenningmeester De Laatste Eer Berlikum";

                            System.Net.Mail.Attachment attachment;
                            attachment = new System.Net.Mail.Attachment(exportFile);
                            mail.Attachments.Add(attachment);

                                SmtpServer.Send(mail);
                                log.LogMessageToFile("Mail verzonden aan: " + adresCard.EmailAdres);

                        }
                    
                    }

                 
                    numberOfMailsSend++;


                }
                catch(IOException err)
                {

                    MessageBox.Show("Oeps, iets ging niet goed.", "Error!!");
                    log.LogMessageToFile("Foutmelding: " + err);
                }
          
            }

            log.LogMessageToFile("Alles is verzonden.");

            if (numberOfMailsSend == 1)
            {
                MessageBox.Show("Het versturen is voltooid.\nIn totaal is er " + numberOfMailsSend + " mail verzonden.\n\nZie " + pathLong + "\nom de verzonden pdf te bekijken.", "Eind verslag");
            }
            else
            {
                MessageBox.Show("Het versturen is voltooid.\nIn totaal zijn er " + numberOfMailsSend + " mails verzonden.\n\nZie " + pathLong + "\nom de verzonden pdfs te bekijken.", "Eind verslag");
            }
                MessageBox.Show("Het programma wordt nu afgesloten.", "Afsluiten");

            System.Windows.Forms.Application.Exit();
            return numberOfMailsSend;

        }

    }

}


