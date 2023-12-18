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
    public partial class CookerForm : Form
    {
        CafeContext context;
        Worker worker;
        public CookerForm(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            var optionBuilder = new DbContextOptionsBuilder<CafeContext>();
            var options = optionBuilder.UseSqlite("Data source = cafe.db").Options;
            context = new CafeContext(options);
            context.Staff.Load();
            context.StatusOrders.Load();
            context.Workers.Load();
            context.Orders.Load();
            OrderUpdate();
        }
        private void OrderUpdate() 
        {
            OrdersList.Items.Clear();
            var orderIds = context.Orders.
                Include(o => o.Cooker).
                Include(o => o.Status).
                Where(o => o.Status!.NameS == "cooked"
                && o.CookerId == worker.Id)
                .Select(d => d.Id).ToList();
            foreach (var name in orderIds)
                OrdersList.Items.Add(name);
            if(OrdersList.Items.Count> 0)
                OrdersList.SelectedIndex = 0;
        }
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (OrdersList.Items.Count == 0) return;
                var oId = (int)OrdersList.SelectedItem;
            var o = context.Orders.FirstOrDefault(o => o.Id == oId);
            var startStatus = context.StatusOrders.FirstOrDefault(s => s.NameS == "cook_ready");
            if (startStatus == null)
            {
                startStatus = new StatusOrder { NameS = "cook_ready" };
                context.SaveChanges();
            }
            o.Status = startStatus;
            context.SaveChanges();
            OrderUpdate();
            MessageBox.Show("заказ приготовлен");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (OrdersList.Items.Count == 0) return;
                var oId = (int)OrdersList.SelectedItem;
            var o = context.Orders.FirstOrDefault(o => o.Id == oId);
            var startStatus = context.StatusOrders.FirstOrDefault(s => s.NameS == "cook_cancel");
            if (startStatus == null)
            {
                startStatus = new StatusOrder { NameS = "cook_cancel" };
                context.SaveChanges();
            }
            o.Status = startStatus;
            context.SaveChanges();
            OrderUpdate();
            MessageBox.Show("заказ отменен");
        }
    }
}
