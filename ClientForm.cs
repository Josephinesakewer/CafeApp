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
    public partial class ClientForm : Form
    {
        CafeContext context;
        public ClientForm(Models.Client client)
        {
            InitializeComponent();
            labelClientWelcome.Text += " " + client?.Name;
            var optionBuilder = new DbContextOptionsBuilder<CafeContext>();
            var options = optionBuilder.UseSqlite("Data source = cafe.db").Options;
            context = new CafeContext(options);

        }

        private void TotalSum_Click(object sender, EventArgs e)
        {
            

        }

        private void DishBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddDish_Click(object sender, EventArgs e)
        {
            var dishName = DishBox.SelectedItem as string;
            var count = (int)CountDish.Value;
           

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
