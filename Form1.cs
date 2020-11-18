using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// I, Abhay Panchal, 000813104 certify that this material is my original work.
/// No other person's work has been used without acknoledgement
/// Date: 29 Oct 2020
/// 
/// </summary>

namespace AssignmentLab3B
{
    public partial class Form1 : Form
    {
        int total = 0;//int variable total for calculating total price
        int a = 0; // int variable a for run the switch statement only one time in a cycle.

        public Form1()
        {
            InitializeComponent();
                     
            HairdresserComboBox.SelectedIndex = 0; 
            PriceButton.Enabled = false; //disable calculate prize button
            ServiceButton.Enabled = false;//disable add service button

            //Add items of Services in list box
            ServiceListBox.Items.Add("Cut");
            ServiceListBox.Items.Add("Wash, blow-dry, and style");
            ServiceListBox.Items.Add("Colour");
            ServiceListBox.Items.Add("Highlights");
            ServiceListBox.Items.Add("Extensions");
            ServiceListBox.Items.Add("Up-do");
        }

        /// <summary>
        /// Exit button 
        /// for close the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// For enabling the add service button 
        /// when user select any services 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ServiceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceButton.Enabled = true;
        }

        /// <summary>
        /// Reset button to reset the application as it was before
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ServiceButton.Enabled = false;//disabling the add service button

            //clearing all text boxes and List boxes
            PriceTextbox2.Clear(); 
            ItemsListBox.Items.Clear();
            PriceListBox.Items.Clear();
            ServiceListBox.ClearSelected();

            HairdresserComboBox.SelectedIndex = 0;

            PriceButton.Enabled = false;//disabling the calculate price button
            HairdresserComboBox.Enabled = true;//enabling the hairdresser combobox
            
            a = 0; //making a 0 to add the dresser again
        }

        /// <summary>
        /// Add Service button 
        /// it use to add all service and display them in the respective listbox with hairdresser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceButton_Click(object sender, EventArgs e)
        {
            PriceButton.Enabled = true; //enabling calculate prize button
            HairdresserComboBox.Enabled = false; //disabling the combo box

            //if statement to add the hairdresser in the list box with the prize 
            if (a == 0)
            {   
                switch (HairdresserComboBox.SelectedIndex.ToString())
                {
                   
                    case "0":
                        ItemsListBox.Items.Add("Jane Samley");
                        PriceListBox.Items.Add("$30.00");
                        total = total + 30;
                        break;
                    case "1":
                        ItemsListBox.Items.Add("Pat Johnson");
                        PriceListBox.Items.Add("$45.00");
                        total = total + 45;
                        break;
                    case "2":
                        ItemsListBox.Items.Add("Ron Chambers");
                        PriceListBox.Items.Add("$40.00");
                        total = total + 40;
                        break;
                    case "3":
                        ItemsListBox.Items.Add("Sue Pallon");
                        PriceListBox.Items.Add("$50.00");
                        total = total + 50;
                        break;
                    case "4":
                        ItemsListBox.Items.Add("Laura Renkins");
                        PriceListBox.Items.Add("$55.00");
                        total = total + 55;
                        break;
                }

                a = 1;
            }

            //switch statement to add all the services which user add in the list box with prize

            switch (ServiceListBox.SelectedItem.ToString())
            {
                case "Cut":
                    ItemsListBox.Items.Add("Cut");
                    PriceListBox.Items.Add("$30.00");
                    total = total + 30;
                    break;

                case "Wash, blow-dry, and style":
                    ItemsListBox.Items.Add("Wash, blow-dry, and style");
                    PriceListBox.Items.Add("$20.00");
                    total = total + 20;
                    break;

                case "Colour":
                    ItemsListBox.Items.Add("Colour");
                    PriceListBox.Items.Add("$40.00");
                    total = total + 40;
                    break;

                case "Highlights":
                    ItemsListBox.Items.Add("Highlights");
                    PriceListBox.Items.Add("$50.00");
                    total = total + 50;
                    break;

                case "Extensions":
                    ItemsListBox.Items.Add("Extensions");
                    PriceListBox.Items.Add("$200.00");
                    total = total + 200;
                    break;

                case "Up-do":
                    ItemsListBox.Items.Add("Up-do");
                    PriceListBox.Items.Add("$60.00");
                    total = total + 60;
                    break;
            }
        }

        /// <summary>
        /// Calculate Prize button to display the total prize in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PriceButton_Click(object sender, EventArgs e)
        {
            PriceTextbox2.Text = total.ToString("C");
        }
    }
}
