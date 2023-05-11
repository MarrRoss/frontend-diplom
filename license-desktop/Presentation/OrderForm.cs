using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using license_desktop.Data.Api;
using license_desktop.Data.Api.APIClient;
using license_desktop.Data.Models.Orders;

namespace license_desktop.Presentation
{
    public partial class OrderForm : Form
    {
        private OrderDto order;

        private OrderDto Order
        {
            get => order;
            set
            {
                order = value;
                Id.Text = order.Id.ToString();
                PrevId.Text = order.PreviousOrderId.ToString();
                LicCount.Text = order.NumLicense.ToString();
                CreateDate.Text = order.CreatingDate.ToString();
                Date.Text = order.Date.ToString();
                PaymentType.Text = order.PaymentType?.Name;
                FName.Text = order.Customer?.FirstName;
                LName.Text = order.Customer?.LastName;
                RName.Text = order.Customer?.RegisterName;
                Company.Text = order.Customer?.Company.Name;
                Phone.Text = order.Customer?.Phone.Name;
                Country.Text = order.Customer?.Country.Name;
                Street.Text = order.Customer?.Street.Name;
                PostCode.Text = order.Customer?.Zip.Name;
                ProductName.Text = order.Product?.Name;
                ProductType.Text = order.Product?.ProductType.Name;
                Version.Text = order.Product?.Version.ToString();
                PrevVersion.Text = order.Product?.PreviousVersion.ToString();
                Platform.Text = order.Product?.PlatformId.ToString();
                ProductGroup.Text = order.Product?.ProductGroup?.Name;
                Edition.Text = order.Product?.Edition?.Name;
                Vendor.Text = order.Product?.Vendor?.Name;
                Key.Text = order.Key?.Key;
                KeyCreatingDate.Text = order.Key?.CreatingDate.ToString();
                ExpirationDate.Text = order.Key?.ExpirationDate?.ToString();
                IsActive.Text = order.Key?.IsActive ?? false ? "Да" : "Нет";
            }
        }
        private int _orderId;
        private int _accountId;
        private UserOrdersForm _ordersForm;
        private CustomerEditForm _customerEditForm;
        public OrderForm(int accountId, int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            _accountId = accountId;

        }

        private async void _customerEditForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var order = await OrderClient.GetOrder(_accountId, _orderId);
            if (order.IsSuccess)
            {
                Order = order.Result;
                if (Order.PreviousOrderId != null)
                {
                    button2.Visible = false;
                    button1.Margin = new Padding(3, 3, 3, 35);
                }
            }
            else
            {
                MessageBox.Show($"There are some errors: {order.Error.Detail}");
                Close();
                Dispose();
            }
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            var order = await OrderClient.GetOrder(_accountId, _orderId);
            if (order.IsSuccess)
            {
                Order = order.Result;
                if (Order?.PreviousOrderId != null)
                {
                    button2.Visible = false;
                    button1.Margin = new Padding(3, 3, 3, 35);
                }
            }
            else
            {
                MessageBox.Show($"There are some errors: {order.Error?.Detail}");
                Close();
                Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_customerEditForm != null)
            {
                _customerEditForm.Dispose();
                _customerEditForm = null;
            }

            _customerEditForm = new CustomerEditForm(order.Customer);
            _customerEditForm.FormClosed += _customerEditForm_FormClosed;
            var res = _customerEditForm.ShowDialog();
            if (res != null)
            {
                _customerEditForm.FormClosed -= _customerEditForm_FormClosed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ordersForm != null)
            {
                _ordersForm.Dispose();
                _ordersForm = null;
            }

            _ordersForm = new UserOrdersForm(_accountId, _orderId);
            _ordersForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Word Document | *.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile($"https://license.mrn.shitposting.team/accounts/{_accountId}/orders/{_orderId}/export", sfd.FileName);
                }
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var order = await OrderClient.GetOrder(_accountId, _orderId);
            if (order.IsSuccess)
            {
                Order = order.Result;
            }
            else
            {
                MessageBox.Show($"There are some errors: {order.Error?.Detail}");
                Close();
                Dispose();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
