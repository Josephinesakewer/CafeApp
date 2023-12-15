using CafeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeApp
{
    public partial class AuthForm : Form
    {
        CafeContext context;
        public AuthForm()
        {
            InitializeComponent();
            var optionBuilder = new DbContextOptionsBuilder<CafeContext>();
            var options = optionBuilder.UseSqlite("Data source = cafe.db").Options;
            context = new CafeContext(options);
            var adminstaf = context.Staff.FirstOrDefault(s => s.Name == "admin");
            if (adminstaf == null)
            {
                adminstaf = new Staff { Name = "admin" };
                var worker = new Worker { Login="admin",Password ="admin", Staff = adminstaf };
                context.Workers.Add(worker);
                context.SaveChanges();
            }
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            context.Clients.Load();
            context.Workers.Load();
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var c = context.Clients.FirstOrDefault(c => c.Password == password && c.Login == login);
            if(c != null)
            {
                this.Hide();
                new ClientForm(c).ShowDialog();
                this.Show();
            }
            else
            {
                var w = context.Workers.Include( w => w.Staff).FirstOrDefault(w => w.Password == password && w.Login == login);
                if(w != null)
                {
                    var stuffName = w.Staff?.Name;
                    if(stuffName != null)
                    {
                        switch (stuffName)
                        {
                            case "admin":
                                {
                                    new AdminForm().ShowDialog();
                                    break;
                                }
                            case "cooker":
                                {
                                    new CookerForm().ShowDialog();  
                                    break;
                                }
                            case "manager":
                                {
                                    new ManagerForm().ShowDialog();
                                    break;
                                }
                            case "deliver":
                                {
                                    new DeliverForm().ShowDialog(); 
                                    break;
                                }
                            default:
                                break;
                        }
                        this.Show();
                    }
                }
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegForm().ShowDialog();
            this.Show();
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientForm(new Models.Client()).ShowDialog();
            this.Show();
        }
    }
}
