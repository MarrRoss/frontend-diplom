using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using license_desktop.Data.Api;
using license_desktop.Data.Models.Accounts;
using license_desktop.Data.TablesModels;
using license_desktop.Utils;

namespace license_desktop.Presentation
{
    public partial class MainForm : Form
    {
        private List<AccountDto> _accounts = new();
        private UserOrdersForm _ordersForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var acc = await AccountClient.GetAccounts();
            if (acc.IsSuccess)
            {
                _accounts = acc.Result;
                listView1.Items.AddRange(_accounts.Select(x => ((AccountTM)x).GetLV()).ToArray());
            }
            else
            {
                MessageBox.Show($"There are some errors: {acc.Error?.Detail}");
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (_ordersForm != null)
                {
                    _ordersForm.Dispose();
                    _ordersForm = null;
                }
                _ordersForm = new UserOrdersForm(_accounts[listView1.SelectedIndices[0]].Id);
                _ordersForm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MainForm_Load(sender, e);
        }
    }
}
