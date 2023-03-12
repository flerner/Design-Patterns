using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_Method
{
    public partial class Form1 : Form
    {
        List<Client> _clients;
        List<String> _credits;
        public Form1()
        {
            InitializeComponent();

            _clients = new List<Client>();
            _clients.Add(new Client() { Name = "Felix Lerner" });
            _clients.Add(new Client() { Name = "Lionel Messi" });
            this.cboClients.DataSource = _clients;

            _credits = new List<String>();
            _credits.Add("Education");
            _credits.Add("Personal");
            this.cboCredits.DataSource = _credits;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            var credit = this.cboCredits.SelectedItem.ToString();
            var client = (Client)this.cboClients.SelectedItem;
           

            try
            {
                if(credit == null)
                {
                    throw new Exception("You must select a credit");
                }
                Credit c = null;
                switch (credit)
                {
                    case "Education":
                        {
                            c = new EducationCredit(client);
                            break;
                        }
                    case "Personal":
                        {
                            c = new PersonalCredit(client); break;
                        }
                    default:
                        {
                            Console.WriteLine("You must select a credit");
                            break;
                        }
                }
                this.result.Clear();
                this.result.Lines = c.Verify();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }



    }
}
