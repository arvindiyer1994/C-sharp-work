using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //Clear result value
            ServCostResLabel.Text = "";

            //Clear checkboxes
            MowingCheckBox.Checked = false;
            EdgingCheckBox.Checked = false;
            PruningCheckBox.Checked = false;
            GardenWasteCheckBox.Checked = false;
            TreePruningCheckBox.Checked = false;
            
            //Clear Listbox selected item
            GardenListBox.SelectedIndex = -1;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Close the interface 
            this.Close();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //Declaring variables
            string gardenSize;
            double TotalCost = 0.0;
            
            //A try catch if any error occurs 
            try
            {
                //Check if a garden size is selected in the listbox
                if (GardenListBox.SelectedIndex != -1)
                {
                    //A garden size is selected
                    gardenSize = GardenListBox.SelectedItem.ToString();
                    if (gardenSize == "Small")
                    {
                        //Check if the checkboxes are selected
                        if (MowingCheckBox.Checked) { TotalCost = TotalCost + 20; }
                        if (EdgingCheckBox.Checked) { TotalCost = TotalCost + 10; }
                        if (PruningCheckBox.Checked) { TotalCost = TotalCost + 60; }
                        if (GardenWasteCheckBox.Checked) { TotalCost = TotalCost + 60; }
                        if (TreePruningCheckBox.Checked)
                        {
                            MessageBox.Show("You cannot select Tree pruning. Cost excluding this service will be displayed.");
                        }
                    }
                    else if (gardenSize == "Medium")
                    {
                        //Check if the checkboxes are selected
                        if (MowingCheckBox.Checked) { TotalCost = TotalCost + 60; }
                        if (EdgingCheckBox.Checked) { TotalCost = TotalCost + 20; }
                        if (PruningCheckBox.Checked) { TotalCost = TotalCost + 60; }
                        if (GardenWasteCheckBox.Checked) { TotalCost = TotalCost + 60; }
                        if (TreePruningCheckBox.Checked)
                        {
                            MessageBox.Show("You cannot select Tree pruning. Cost excluding this service will be displayed.");
                        }
                    }
                    else if (gardenSize == "Large")
                    {
                        //Check if the checkboxes are selected
                        if (MowingCheckBox.Checked) { TotalCost = TotalCost + 80; }
                        if (EdgingCheckBox.Checked) { TotalCost = TotalCost + 40; }
                        if (PruningCheckBox.Checked) { TotalCost = TotalCost + 60; }
                        if (GardenWasteCheckBox.Checked) { TotalCost = TotalCost + 60; }
                        if (TreePruningCheckBox.Checked)
                        {
                            TotalCost = TotalCost + 150;
                        }
                    }
                    else
                    {
                        //if an list item that is not in the list is selected
                        MessageBox.Show("Invalid input");
                    }
                    //If the user has not selected any input
                    if (TotalCost == 0)
                    {
                        MessageBox.Show("No services selected");
                    }
                    else
                    {
                        //Display the cost
                        ServCostResLabel.Text = TotalCost.ToString("c");
                    }
                }
                else
                {
                    //Ask user to select an item from listbox
                    MessageBox.Show("Select an input from Listbox");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
