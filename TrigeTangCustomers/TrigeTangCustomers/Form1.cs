using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TrigeTangCustomers
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            //yOlo
        }

        int id;
        List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Under load af main læser kigger programmet efter om den specificeret fil eksistere eller ej, 
        /// alt efter om det er sandt eller falsk så vil den enten lave den fil og mappe eller bare fortsætte.
        /// Derefter læser den fra xml filen hvis den eksistere og indsætter det data der nu er gemt i filen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            Main_Notifyer.ShowBalloonTip(2500, "Application running", "Trige and Tang Customers by Kent application is running.", ToolTipIcon.Info);

            if (!Directory.Exists(path + @"\Customers - Kent"))
            {
                Directory.CreateDirectory(path + @"\Customers - Kent");
            }

            if (!File.Exists(path + @"\Customers - Kent\settings.xml"))
            {
                XmlTextWriter xmlTW = new XmlTextWriter(path + @"\Customers - Kent\settings.xml", Encoding.UTF8);
                xmlTW.Formatting = Formatting.Indented;
                xmlTW.WriteStartElement("Customers");
                xmlTW.WriteEndElement();
                xmlTW.Close();
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + @"\Customers - Kent\settings.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("Customers/Customer"))
            {
                Customer c = new Customer();
                c.Id = int.Parse(xNode.SelectSingleNode("Id").InnerText);
                c.Name = xNode.SelectSingleNode("Name").InnerText;
                c.Address1 = xNode.SelectSingleNode("Address1").InnerText;
                c.Address2 = xNode.SelectSingleNode("Address2").InnerText;
                c.PostalCode = int.Parse(xNode.SelectSingleNode("PostalCode").InnerText);
                c.City = xNode.SelectSingleNode("City").InnerText;
                c.Email = xNode.SelectSingleNode("Email").InnerText;
                c.PhoneNumber = int.Parse(xNode.SelectSingleNode("PhoneNumber").InnerText);
                c.CustomerSince = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("CustomerSince").InnerText));
                c.CustomerEnd = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("CustomerEnd").InnerText));

                customers.Add(c);
                lv_Customers.Items.Add(c.Name);

                id = c.Id + 1;
            }
        }

        /// <summary>
        /// Ved double klik på program ikonet under det kørende processore vil programmet pop op igen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Notifyer_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// En klasse for customers, hvor en masse egenskaber er defineret
        /// </summary>
        private class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public int PostalCode { get; set; }
            public string City { get; set; }
            public string Email { get; set; }
            public int PhoneNumber { get; set; }
            public DateTime CustomerSince { get; set; }
            public DateTime CustomerEnd { get; set; }
        }

        /// <summary>
        /// knappen Add tilføjer en customer med det specificeret indtastet data fra brugeren af programmet og dernæst nulstiller fælterne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer();

                c.Id = id++;
                c.Name = tb_Name.Text;
                #region AddressValidation
                if (!tb_Adr1.Text.Any(Char.IsLetter) && !tb_Adr1.Text.Any(Char.IsDigit))
                {
                    MessageBox.Show("Please enter both Street name and House number");
                    return;
                }
                else
                {
                    c.Address1 = tb_Adr1.Text;
                    c.Address2 = tb_Adr2.Text;
                }
                #endregion
                #region PostalCodeValidation
                if (tb_PCode.MaxLength == 10 || tb_PCode.Text.Length >=3)
                {
                    c.PostalCode = int.Parse(tb_PCode.Text);
                }
                else
                {
                    MessageBox.Show("Postal Code cannot be more than 10 letters nor less then 3 digits!");
                    return;
                }
                #endregion
                c.City = tb_City.Text;
                #region EmailValidation
                if (IsValidEmail(tb_Email.Text) == true)
                {
                    c.Email = tb_Email.Text;
                }
                else
                {
                    MessageBox.Show("Email was not entered correctly.\r\nPlease try again!");
                    return;
                }
                #endregion
                c.PhoneNumber = int.Parse(tb_PNumber.Text);
                c.CustomerSince = dtp_CustomerSince.Value;
                c.CustomerEnd = dtp_CustomerEnd.Value;


                customers.Add(c);
                lv_Customers.Items.Add(c.Name);

                tb_CustomerID.Text = "";
                tb_Name.Text = "";
                tb_Adr1.Text = "";
                tb_Adr2.Text = "";
                tb_PCode.Text = "";
                tb_City.Text = "";
                tb_Email.Text = "";
                tb_PNumber.Text = "";
                dtp_CustomerSince.Value = DateTime.Now;
                dtp_CustomerEnd.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("Make sure that postal code and phone number is typed with only number\r\n" + ex.Message);
                }
                else
                    MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Hvis der sker ændringer på det valgte element, så opdateres felterne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customers.SelectedItems.Count == 0)
            {
                return;
            }

            try
            {
                tb_CustomerID.Text = customers[lv_Customers.SelectedItems[0].Index].Id.ToString();
                tb_Name.Text = customers[lv_Customers.SelectedItems[0].Index].Name;
                tb_Adr1.Text = customers[lv_Customers.SelectedItems[0].Index].Address1;
                tb_Adr2.Text = customers[lv_Customers.SelectedItems[0].Index].Address2;
                tb_PCode.Text = customers[lv_Customers.SelectedItems[0].Index].PostalCode.ToString();
                tb_City.Text = customers[lv_Customers.SelectedItems[0].Index].City;
                tb_Email.Text = customers[lv_Customers.SelectedItems[0].Index].Email;
                tb_PNumber.Text = customers[lv_Customers.SelectedItems[0].Index].PhoneNumber.ToString();
                dtp_CustomerSince.Value = customers[lv_Customers.SelectedItems[0].Index].CustomerSince;
                dtp_CustomerEnd.Value = customers[lv_Customers.SelectedItems[0].Index].CustomerEnd;
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// Kalder på metoden RemoveCustomer og udføre det den bliver bedt om.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            RemoveCustomer();
        }

        /// <summary>
        /// Metoden RemoveCustomer sletter den valgte/markerede customer på på listen.
        /// </summary>
        private void RemoveCustomer()
        {
            try
            {
                customers.RemoveAt(lv_Customers.SelectedItems[0].Index);
                lv_Customers.Items.Remove(lv_Customers.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not remove Customer\r\n" + ex.Message);
            }
        }

        /// <summary>
        /// Denne knap sletter alle de valgte/markerede på listen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in lv_Customers.SelectedItems)
                {

                    if (lv_Customers.SelectedItems.Count <= 0)
                    {
                        return;
                    }
                    else
                    {
                        customers.RemoveAt(lv_Customers.SelectedItems[0].Index);
                        lv_Customers.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not remove Customer(s)\r\n" + ex.Message);
            }
        }

        /// <summary>
        /// Denne knap fjerner alle customers der er i listen, men spørger dig pænt om du er sikker inden.
        /// Derefter nulstilles Id'et
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult removeAlert = MessageBox.Show("Are you sure you want to remove all Customers?", "ALERT!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (removeAlert == DialogResult.Yes)
                {

                    foreach (ListViewItem item in lv_Customers.Items)
                    {
                        customers.RemoveAt(lv_Customers.Items[0].Index);
                        lv_Customers.Items.Remove(lv_Customers.Items[0]);
                    }
                }
                id = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not remove all Customers\r\n" + ex.Message);
            }
        }

        /// <summary>
        /// Denne knap gemmer ændringerne du har lavet på den markerede og allerede eksisterende customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            customers[lv_Customers.SelectedItems[0].Index].Name = tb_Name.Text;
            customers[lv_Customers.SelectedItems[0].Index].Address1 = tb_Adr1.Text;
            customers[lv_Customers.SelectedItems[0].Index].Address2 = tb_Adr2.Text;
            customers[lv_Customers.SelectedItems[0].Index].PostalCode = int.Parse(tb_PCode.Text);
            customers[lv_Customers.SelectedItems[0].Index].City = tb_City.Text;
            customers[lv_Customers.SelectedItems[0].Index].Email = tb_Email.Text;
            customers[lv_Customers.SelectedItems[0].Index].PhoneNumber = int.Parse(tb_PNumber.Text);
            customers[lv_Customers.SelectedItems[0].Index].CustomerSince = dtp_CustomerSince.Value;
            customers[lv_Customers.SelectedItems[0].Index].CustomerEnd = dtp_CustomerEnd.Value;


            lv_Customers.SelectedItems[0].Text = tb_Name.Text;
        }

        /// <summary>
        /// Gemmer alle de ændringer der er blevet lavet og overskriver den gemte xml fil, når applikationen bliver lukket ned ved klik på krydset.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
            MessageBox.Show("Information is now automatically saved to xml file\r\n" + path + @"\Customers - Kent\settings.xml");
        }

        /// <summary>
        /// Denne knap convertere til en .csv fil, ved hjælp af linq.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConCSV_Click(object sender, EventArgs e)
        {
            Save();

            StringBuilder sb = new StringBuilder();
            string delimiter = ";";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            XDocument.Load(path + @"\Customers - Kent\settings.xml").Descendants("Customer").ToList().ForEach(
                element => sb.Append(element.Element("Id").Name + delimiter +
                element.Element("Name").Name + delimiter +
                element.Element("Address1").Name + delimiter +
                element.Element("Address2").Name + delimiter +
                element.Element("PostalCode").Name + delimiter +
                element.Element("City").Name + delimiter +
                element.Element("Email").Name + delimiter +
                element.Element("PhoneNumber").Name + delimiter +
                element.Element("CustomerSince").Name + delimiter +
                element.Element("CustomerEnd").Name + delimiter +
                "\r\n" +
                element.Element("Id").Value + delimiter +
                element.Element("Name").Value + delimiter +
                element.Element("Address1").Value + delimiter +
                element.Element("Address2").Value + delimiter +
                element.Element("PostalCode").Value + delimiter +
                element.Element("City").Value + delimiter +
                element.Element("Email").Value + delimiter +
                element.Element("PhoneNumber").Value + delimiter +
                element.Element("CustomerSince").Value + delimiter +
                element.Element("CustomerEnd").Value + "\r\n"));

            StreamWriter sw = new StreamWriter(path + @"\Customers - Kent\settings.csv");
            sw.WriteLine(sb.ToString());
            sw.Close();

            MessageBox.Show("File has been converted to .csv and is now saved in\r\n" + path + @"\Customers - Kent\settings.csv");
        }

        /// <summary>
        /// Ser efter om den indtastede email også er en valid email addresse.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Denne metode gemmer alle de ændringer der er blevet lavet og overskriver den gemte xml fil.
        /// </summary>
        private void Save()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.Load(path + @"\Customers - Kent\settings.xml");

                XmlNode xNode = xDoc.SelectSingleNode("Customers");
                xNode.RemoveAll();

                foreach (Customer c in customers)
                {
                    XmlNode xTop = xDoc.CreateElement("Customer");
                    XmlNode xId = xDoc.CreateElement("Id");
                    XmlNode xName = xDoc.CreateElement("Name");
                    XmlNode xAdr1 = xDoc.CreateElement("Address1");
                    XmlNode xAdr2 = xDoc.CreateElement("Address2");
                    XmlNode xPCode = xDoc.CreateElement("PostalCode");
                    XmlNode xCity = xDoc.CreateElement("City");
                    XmlNode xEmail = xDoc.CreateElement("Email");
                    XmlNode xPNumber = xDoc.CreateElement("PhoneNumber");
                    XmlNode xCSince = xDoc.CreateElement("CustomerSince");
                    XmlNode xCEnd = xDoc.CreateElement("CustomerEnd");

                    xId.InnerText = c.Id.ToString();
                    xName.InnerText = c.Name;
                    xAdr1.InnerText = c.Address1;
                    xAdr2.InnerText = c.Address2;
                    xPCode.InnerText = c.PostalCode.ToString();
                    xCity.InnerText = c.City;
                    xEmail.InnerText = c.Email;
                    xPNumber.InnerText = c.PhoneNumber.ToString();
                    xCSince.InnerText = c.CustomerSince.ToFileTime().ToString();
                    xCEnd.InnerText = c.CustomerEnd.ToFileTime().ToString();

                    xTop.AppendChild(xId);
                    xTop.AppendChild(xName);
                    xTop.AppendChild(xAdr1);
                    xTop.AppendChild(xAdr2);
                    xTop.AppendChild(xPCode);
                    xTop.AppendChild(xCity);
                    xTop.AppendChild(xEmail);
                    xTop.AppendChild(xPNumber);
                    xTop.AppendChild(xCSince);
                    xTop.AppendChild(xCEnd);

                    xDoc.DocumentElement.AppendChild(xTop);
                }

                xDoc.Save(path + @"\Customers - Kent\settings.xml");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Could not save to xml file\r\n" + ex.Message);
            }
        }
    }
}
