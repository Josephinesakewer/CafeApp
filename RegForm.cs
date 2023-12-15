using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeApp
{
    public partial class RegForm : Form
    {
        CafeContext context;
        public RegForm()
        {
            InitializeComponent();
            var optionBuilder = new DbContextOptionsBuilder<CafeContext>();
            var options = optionBuilder.UseSqlite("Data source = cafe.db").Options;
            context = new CafeContext(options);
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var name = textBoxName.Text;
            var email = textBoxEmail.Text;
            var phone = textBoxPhone.Text;
            var client= new Models.Client { Email = email, Phone = phone, Login = login, Name = name, Password = password, NameC = name};
            var c1 = context.Clients.ToList().FirstOrDefault(c => c.Login == client.Login);
            if (c1 is null)
            {
                context.Clients.Add(client);
                context.SaveChanges();
                MessageBox.Show("Вы успешно зарегистрированы");
                this.Close();
            }

        }
    }
}
