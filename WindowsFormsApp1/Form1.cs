using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class variablesHomepage : Form
    {
        public variablesHomepage()
        {
            InitializeComponent();
        }

        private void wayneGretzky_Click(object sender, EventArgs e)
        {
            
            carpetLabel.Visible = false;
            billLabel.Visible = false;
            areaLabel.Visible = false;
            hockeyLabel.Visible = true;
            string name = "Wayne Gretzky";
            int playernumber = 99;
            hockeyLabel.Text = $"\n{name} is number {playernumber}";
            
            
           
           
        }

        private void carpet_Click(object sender, EventArgs e)
        {
            hockeyLabel.Visible = false;
            billLabel.Visible = false;
            areaLabel.Visible = false;
            carpetLabel.Visible = true;
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double Area = length * width;
            double totalCost = costPerMeter * Area;
           
            carpetLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {Area}m^2 \nThe cost to carpet this area at {costPerMeter} per square metre is {totalCost}.";
        }

        private void area_Click(object sender, EventArgs e)
        {
            hockeyLabel.Visible = false;
            billLabel.Visible = false;
            carpetLabel.Visible = false;
            areaLabel.Visible = true;
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;
            areaLabel.Text = $"The area of a circle with a {radius}cm radius is: {area}cm^2";
        }

        private void bill_Click(object sender, EventArgs e)
        {
            hockeyLabel.Visible = false;
            areaLabel.Visible = false;
            carpetLabel.Visible = false;
            billLabel.Visible = true;
            string name = "Bill of Sale";
            double shirt = 12.5;
            double tax = 1.6;
            double total = shirt + tax;
            double tendered = 20.0;
            double change = tendered - total;
            billLabel.Text = $"{name}";
         
            billLabel.Text = $"{name}\nShirt:     {shirt} \nTax:      {1.6}\nTotal:     {total}\nTendered: { tendered}\nChange:    {change}";

        }

        // private void carpet_Click(object sender, EventArgs e)


    }
    }
 
