using CafeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class AdminForm : Form
    {
        CafeContext context;
        public AdminForm()
        {
            InitializeComponent();
            var optionBuilder = new DbContextOptionsBuilder<CafeContext>();
            var options = optionBuilder.UseSqlite("Data source = cafe.db").Options;
            context = new CafeContext(options);
            context.Workers.Load();
            context.Staff.Load();
            context.Dishes.Load();
            TablesWorkers.DataSource = context.Workers.Local.ToBindingList();
            TableStaff.DataSource = context.Staff.Local.ToBindingList();
            TablesDish.DataSource = context.Dishes.Local.ToBindingList();
        }

        private void SaveButtonWorker_Click(object sender, EventArgs e)
        {
            try 
            { 
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("вы ввели некорректные данные");
            }            
            TablesWorkers.Invalidate();
        }

        private void SaveButtonStaff_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("вы ввели некорректные данные");
            }
            TableStaff.Invalidate();
        }

        private void SaveDish_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("вы ввели некорректные данные");
            }
            TablesDish.Invalidate();
        }
    }
}
