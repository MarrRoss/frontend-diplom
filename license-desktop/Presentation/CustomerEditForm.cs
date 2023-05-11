using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using license_desktop.Data.Api;
using license_desktop.Data.Models.Cities;
using license_desktop.Data.Models.Companies;
using license_desktop.Data.Models.Countries;
using license_desktop.Data.Models.Customers;
using license_desktop.Data.Models.Phones;
using license_desktop.Data.Models.States;
using license_desktop.Data.Models.Streets;
using license_desktop.Data.Models.ZipCodes;

namespace license_desktop.Presentation
{
    public partial class CustomerEditForm : Form
    {
        private List<CompanyDto> _companies;
        private List<PhoneDto> _phones;
        private List<CountryDto> _countries;
        private List<CityDto> _cities;
        private List<StreetDto> _streets;
        private List<ZipCodeDto> _zipCodes;
        private List<StateDto> _states;
        private CustomerDto _customer;
        public CustomerEditForm(CustomerDto customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var customer = new UpdateCustomerDto()
            {
                FirstName = FName.Text,
                LastName = LName.Text,
                Description = _customer.Description,
                RegisterName = RName.Text,
                CityId = ((CityDto)City.SelectedItem).Id,
                CompanyId = ((CompanyDto)Company.SelectedItem).Id,
                CountryId = ((CountryDto)Country.SelectedItem).Id,
                StateId = ((StateDto)State.SelectedItem).Id,
                PhoneId = ((PhoneDto)Phone.SelectedItem).Id,
                StreetId = ((StreetDto)Street.SelectedItem).Id,
                ZipId = ((ZipCodeDto)PostCode.SelectedItem).Id
            };
            await CustomerClient.UpdateCustomer(_customer.Id, customer);
            Close();
            Dispose();
        }

        private async void CustomerEditForm_Load(object sender, EventArgs e)
        {
            var comp = await IdNameClient.Get<CompanyDto>("companies");
            var country = await IdNameClient.Get<CountryDto>("countries");
            var phone = await IdNameClient.Get<PhoneDto>("phones");
            var city = await IdNameClient.Get<CityDto>("cities");
            var street = await IdNameClient.Get<StreetDto>("streets");
            var zipcode = await IdNameClient.Get<ZipCodeDto>("zip_codes");
            var state = await IdNameClient.Get<StateDto>("states");
            if (comp.IsSuccess && country.IsSuccess && phone.IsSuccess && city.IsSuccess && street.IsSuccess &&
                zipcode.IsSuccess && state.IsSuccess)
            {
                _companies = comp.Result;
                _countries = country.Result;
                _phones = phone.Result;
                _cities = city.Result;
                _streets = street.Result;
                _zipCodes = zipcode.Result;
                _states = state.Result;
                Company.Items.AddRange(_companies.ToArray());
                Phone.Items.AddRange(_phones.ToArray());
                Country.Items.AddRange(_countries.ToArray());
                State.Items.AddRange(_states.ToArray());
                City.Items.AddRange(_cities.ToArray());
                Street.Items.AddRange(_streets.ToArray());
                PostCode.Items.AddRange(_zipCodes.ToArray());
                FName.Text = _customer.FirstName;
                LName.Text = _customer.LastName;
                RName.Text = _customer.RegisterName;
                Company.SelectedIndex = _companies.FindIndex(x => x.Id == _customer.Company.Id);
                Phone.SelectedIndex = _phones.FindIndex(x => x.Id == _customer.Phone.Id);
                State.SelectedIndex = _states.FindIndex(x => x.Id == _customer.State.Id);
                City.SelectedIndex = _cities.FindIndex(x => x.Id == _customer.City.Id);
                Street.SelectedIndex = _streets.FindIndex(x => x.Id == _customer.Street.Id);
                PostCode.SelectedIndex = _zipCodes.FindIndex(x => x.Id == _customer.Zip.Id);
                Country.SelectedIndex = _countries.FindIndex(x => x.Id == _customer.Country.Id);
            }
            else
            {
                MessageBox.Show($"There are some errors: " +
                                $"\n {comp.Error?.Detail} " +
                                $"\n {country.Error?.Detail} " +
                                $"\n {phone.Error?.Detail} " +
                                $"\n {city.Error?.Detail} " +
                                $"\n {street.Error?.Detail} " +
                                $"\n {zipcode.Error?.Detail}" +
                                $"\n {state.Error?.Detail}");
                Close();
                Dispose();
            }
        }
    }
}
