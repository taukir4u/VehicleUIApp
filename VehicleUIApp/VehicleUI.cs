using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VehicleUIApp
{
    public partial class VehicleUI : Form
    {
        public VehicleUI()
        {
            InitializeComponent();
        }

        private Vehicle aVehicle;

        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle = new Vehicle(vehicleNameTextBox.Text, regNoTextBox.Text);
            MessageBox.Show("Vehicle Created");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicle.EnterSpeed(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Text = "";
            MessageBox.Show("Speed Entered");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicle.GetMinSpeed().ToString();
            maxSpeedTextBox.Text = aVehicle.GetMaxSpeed().ToString();
            averageSpeedTextBox.Text = aVehicle.GetAverage().ToString();
        }
    }
}
