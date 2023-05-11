using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using license_desktop.Data.Api;
using license_desktop.Data.Models.Orders;
using license_desktop.Data.TablesModels;
using license_desktop.Utils;

namespace license_desktop.Presentation
{
    public partial class UserOrdersForm : Form
    {
        private List<OrderDto> _orders = new();
        private readonly int _accountId;
        private readonly int? _orderId;
        private OrderForm _orderForm;
        public UserOrdersForm(int accountId)
        {
            InitializeComponent();
            _accountId = accountId;
        }

        public UserOrdersForm(int accountId, int orderId)
        {
            InitializeComponent();
            _accountId = accountId;
            _orderId = orderId;
        }

        private async void UserOrdersForm_Load(object sender, EventArgs e)
        {
            if (_orderId == null)
            {
                var orders = await OrderClient.GetOrders(_accountId);
                if (orders.IsSuccess)
                {
                    _orders = orders.Result;
                    listView1.Items.AddRange(_orders.Select(x => ((OrderTM)x).GetLV()).ToArray());
                }
                else
                {
                    MessageBox.Show($"There are some errors: {orders.Error?.Detail}");
                    Close();
                    Dispose();
                }
            }
            else
            {
                var orders = await OrderClient.GetOrderUpgrades(_accountId, _orderId.Value);
                if (orders.IsSuccess)
                {
                    _orders = orders.Result;
                    listView1.Items.AddRange(_orders.Select(x => ((OrderTM)x).GetLV()).ToArray());
                }
                else
                {
                    MessageBox.Show($"There are some errors: {orders.Error?.Detail}");
                    Close();
                    Dispose();
                }
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (_orderForm != null)
                {
                    _orderForm.Dispose();
                    _orderForm = null;
                }

                _orderForm = new OrderForm(_accountId, _orders[listView1.SelectedIndices[0]].Id);
                _orderForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            UserOrdersForm_Load(sender,e);
        }
    }
}
