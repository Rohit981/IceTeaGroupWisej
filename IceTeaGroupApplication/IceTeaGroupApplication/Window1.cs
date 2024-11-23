
using System;
using Wisej.Web;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace IceTeaGroupApplication
{
    public partial class Window1 : Form
    {
        private List<Address> addressList;
       

        public Window1()
        {
            InitializeComponent();

            addressList = new List<Address>();
        }

        // Address class to represent an address
        public class Address
        {
            public string Name { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
        }

        // Method to update the DataGrid with the list of addresses
        private void UpdateGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = addressList;
        }

        // Method to clear input fields after adding an address
        private void ClearInputs()
        {
            txtName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtZip.Clear();
            txtCountry.Clear();
        }


        // Button click event to add a new address
        private void button4_Click(object sender, EventArgs e)
        {
            var address = new Address
            {
                Name = txtName.Text,
                Street = txtStreet.Text,
                City = txtCity.Text,
                PostalCode = txtZip.Text,
                Country = txtCountry.Text,
            };

            addressList.Add(address);
            UpdateGrid();
            ClearInputs();
        }

        // Button click event to edit a selected address
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                var selectedAddress = addressList[selectedIndex];

                selectedAddress.Name = txtName.Text;
                selectedAddress.Street = txtStreet.Text;
                selectedAddress.City = txtCity.Text;
                selectedAddress.PostalCode = txtZip.Text;
                selectedAddress.Country = txtCountry.Text;

                UpdateGrid();
            }
        }

        // Button click event to delete a selected address
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                addressList.RemoveAt(selectedIndex);
                UpdateGrid();
            }
        }


    }
}
