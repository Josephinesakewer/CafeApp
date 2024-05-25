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
        Models.Client client;
        public ClientForm(Models.Client client)
        {
            InitializeComponent();
            this.client = client;
            labelClientWelcome.Text += " " + client?.Name;
            var optionBuilder = new DbContextOptionsBuilder<CafeContext>();
            var options = optionBuilder.UseSqlite("Data source = cafe.db").Options;
            context = new CafeContext(options);

            var namesDishes = context.Dishes.Select(d => d.NameM).ToList();
            foreach (var name in namesDishes)
                DishBox.Items.Add(name);
            if (DishBox.Items.Count > 0)
                DishBox.SelectedIndex = 0;
        }

        private void TotalSum_Click(object sender, EventArgs e)
        {


        }

        private void DishBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StatusOrder_Click(object sender, EventArgs e)
        {

        }

        private void AddDish_Click(object sender, EventArgs e)
        {
            var dishName = DishBox.SelectedItem as string;
            //var status = ;
            var count = (int)CountDish.Value;
            var price = context.Dishes.FirstOrDefault(d => d.NameM == dishName)!.Price;
            var totalPrice = price * count;
            var order = new string[] { dishName, price!?.ToString(), count.ToString(), totalPrice!?.ToString() };
            dataGridViewDishes.Rows.Add(order);
            var sum = 0;
            foreach (var row in dataGridViewDishes.Rows)
            {
                var s = (DataGridViewRow)row;
                sum += Convert.ToInt32(s.Cells[3].Value);
            }
            TotalSum.Text = "Общая стоимость = " + sum.ToString();
            //StatusOrder.Text = "Текущий статус заказа: ";
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var o = new Order();
            o.DateTimeStart = DateTime.Now;
            
            var startStatus = context.StatusOrders.FirstOrDefault(s => s.NameS == "started");
            if (startStatus == null)
            {
                startStatus = new StatusOrder { NameS = "started" };
                StatusOrder.Text = "Текущий статус заказа: " + startStatus;
                context.SaveChanges();
            }
            o.Status = startStatus;
            var b = new Dictionary<string, int>();
            foreach (var row in dataGridViewDishes.Rows)
            {
                var s = (DataGridViewRow)row;
                if (s.Cells[0].Value is null) continue;
                if (!b.ContainsKey(s.Cells[0].Value.ToString()))
                    b[s.Cells[0].Value.ToString()] = Convert.ToInt32(s.Cells[2].Value);
                else
                    b[s.Cells[0].Value.ToString()] += Convert.ToInt32(s.Cells[2].Value);


            }
            foreach (var row in b)
            {
                var d = context.Dishes.FirstOrDefault(d => d.NameM == row.Key);
                o.Baskets.Add(new Basket { Dish = d, Order = o, CountDishes = row.Value });
                
            }
            if (client.Id != 0)
            {
                o.ClientId = client.Id;
                client.Orders.Add(o);

            }
            context.Orders.Add(o);
            try
            {
                context.SaveChanges();
                MessageBox.Show("заказ успешно прошел");
                StatusOrder.Text = MessageBox.Show("заказ успешно прошел").ToString(); 
                dataGridViewDishes.Rows.Clear();
            }
            catch
            {
                MessageBox.Show("что-то пошло не так");
                StatusOrder.Text = "Текущий статус заказа: " + MessageBox.Show("что-то пошло не так").ToString(); 
            }
            //var status = StatusOrder.;
            //StatusOrder.Text = status.ToString();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataGridViewDishes.Rows.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
