using CafeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class ManagerForm : Form
    {
        CafeContext context;
        public ManagerForm()
        {
            InitializeComponent();
            var optionBuilder = new DbContextOptionsBuilder<CafeContext>();
            var options = optionBuilder.UseSqlite("Data source = cafe.db").Options;
            context = new CafeContext(options);
            context.Staff.Load();
            context.StatusOrders.Load();    
            context.Workers.Load(); 
            context.Orders.Load();
            var orderIds = context.Orders.
                Include(o => o.Status).
                Where(o => o.Status!.NameS != "finished")
                .Select(d => d.Id).ToList();
            foreach (var name in orderIds)
                OrdersList.Items.Add(name);
            var deliverNames = context.Workers.
                Include(w => w.Staff)
                .Where(w => w.Staff!.Name == "deliver")
                .Select(d => d.NameW)
                .ToList();
            foreach (var name in deliverNames)
                deliverList.Items.Add(name);

            var cookerNames = context.Workers.
                Include(w => w.Staff)
                .Where(w => w.Staff!.Name == "cooker")
                .Select(d => d.NameW)
                .ToList();
            foreach (var name in cookerNames)
                CookerList.Items.Add(name);
            OrdersList.SelectedIndex = 0;
            deliverList.SelectedIndex = 0;
            CookerList.SelectedIndex = 0;
        }

        private void СancelDeliveryButton_Click(object sender, EventArgs e)
        {
            var oId = (int)OrdersList.SelectedItem;
            var o = context.Orders.FirstOrDefault(o => o.Id == oId);
            var startStatus = context.StatusOrders.FirstOrDefault(s => s.NameS == "started");
            if (startStatus == null)
            {
                startStatus = new StatusOrder { NameS = "started" };
                context.SaveChanges();
            }
            o.Status = startStatus;
            o.Deliever = null;
            o.DelieverId = null;
            textBoxDeliver.Text = "";
            context.SaveChanges();
            UpdateOrderList();
        }

        private void ChooseCookerButton_Click(object sender, EventArgs e)
        {
            var startStatus = context.StatusOrders.FirstOrDefault(s => s.NameS == "cooked");
            if (startStatus == null)
            {
                startStatus = new StatusOrder { NameS = "cooked" };
                context.SaveChanges();
            }
            var oId = (int)OrdersList.SelectedItem;
            var o = context.Orders.FirstOrDefault(o => o.Id == oId);
            var cookerName = CookerList.SelectedItem.ToString();
            var d = context.Workers.FirstOrDefault(d => d.NameW == cookerName);
            o.Cooker = d;
            o.Status = startStatus;
            textBoxCooker.Text = cookerName;

            context.SaveChanges();
            UpdateOrderList();
        }

        private void CancelCookerButton_Click(object sender, EventArgs e)
        {
            var startStatus = context.StatusOrders.FirstOrDefault(s => s.NameS == "started");
            if (startStatus == null)
            {
                startStatus = new StatusOrder { NameS = "started" };
                context.SaveChanges();
            }
            var oId = (int)OrdersList.SelectedItem;
            var o = context.Orders.FirstOrDefault(o => o.Id == oId);
            o.Cooker = null;
            o.CookerId = null;
            o.Status = startStatus;
            textBoxCooker.Text = "";
            context.SaveChanges();
            UpdateOrderList();
        }

        private void ChooseDeliveryButton_Click(object sender, EventArgs e)
        {
            var startStatus = context.StatusOrders.FirstOrDefault(s => s.NameS == "on_the_way");
            if (startStatus == null)
            {
                startStatus = new StatusOrder { NameS = "on_the_way" };
                context.SaveChanges();
            }
            var oId = (int)OrdersList.SelectedItem;
            var o = context.Orders.FirstOrDefault(o => o.Id == oId);
            var deliverName = deliverList.SelectedItem.ToString();
            var d = context.Workers.FirstOrDefault(d => d.NameW == deliverName);
            o.Deliever = d;
            o.Status = startStatus;
            textBoxDeliver.Text = deliverName;
            
            context.SaveChanges();
            UpdateOrderList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var startStatus = context.StatusOrders.FirstOrDefault(s => s.NameS == "finished");
            if (startStatus == null)
            {
                startStatus = new StatusOrder { NameS = "finished" };
                context.SaveChanges();
            }
            var oId = (int)OrdersList.SelectedItem;
            var o = context.Orders.FirstOrDefault(o => o.Id == oId);
            o.Status = startStatus;
            o.DateTimeFinish = DateTime.Now;
            context.SaveChanges();
            OrdersList.Items.Clear();
            var orderIds = context.Orders.
                Include(o => o.Status).
                Where(o => o.Status!.NameS != "finished")
                .Select(d => d.Id).ToList();
            foreach (var name in orderIds)
                OrdersList.Items.Add(name);
            OrdersList.SelectedIndex = 0;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            context.Staff.Load();
            context.StatusOrders.Load();
            context.Workers.Load();
            context.Orders.Load();
            var orderIds = context.Orders.
                Include(o => o.Status).
                Where(o => o.Status!.NameS != "finished")
                .Select(d => d.Id).ToList();
            foreach (var name in orderIds)
                OrdersList.Items.Add(name);
            var deliverNames = context.Workers.
                Include(w => w.Staff)
                .Where(w => w.Staff!.Name == "deliver")
                .Select(d => d.NameW)
                .ToList();
            foreach (var name in deliverNames)
                deliverList.Items.Add(name);

            var cookerNames = context.Workers.
                Include(w => w.Staff)
                .Where(w => w.Staff!.Name == "cooker")
                .Select(d => d.NameW)
                .ToList();
            foreach (var name in cookerNames)
                CookerList.Items.Add(name);
            OrdersList.SelectedIndex = 0;
            deliverList.SelectedIndex = 0;
            CookerList.SelectedIndex = 0;
        }

        private void OrdersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOrderList();
        }
        private void UpdateOrderList()
        {
            textBoxCooker.Text = "";
            textBoxDeliver.Text = "";
            var s = context.Orders.FirstOrDefault(o => o.Id == (int)OrdersList.SelectedItem).Status.NameS;
            if (s != null)
            {
                textBoxStatus.Text = s;
            }
           var oId = (int)OrdersList.SelectedItem;
            var o = context.Orders.FirstOrDefault(o => o.Id == oId);
            var c = context.Workers.FirstOrDefault(d => d.Id == o.CookerId);
            var d = context.Workers.FirstOrDefault(d => d.Id == o.DelieverId);
            if (c != null)
                textBoxCooker.Text = c.NameW;
            if (d != null)
                textBoxDeliver.Text = d.NameW;
        }
        private void deliveryman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cooker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
