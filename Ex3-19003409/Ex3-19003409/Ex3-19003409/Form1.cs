using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_19003409
{
    public partial class Form1 : Form
    {
        //The temperatures are not more then 7 digits which make float usable
        float[] LongTermAvgArray = new float[12]; 
        float[] CurrAvgArray = new float[12];
        //The boolean values are used to state if the files have been read
        bool LongTermArray_Read = false;
        bool CurrAvgArray_Read = false;
        public Form1()
        {
            InitializeComponent();
            //To load the Data while the file opens
            Load_LongTermAvg();
        }

        private void Load_LongTermAvg()
        {
            try
            {
                String[] temp = new string[12];
                temp = File.ReadAllLines("MonthLongTerm.txt"); //File present in Debug Folder
                for (int i = 0; i < 12; i++) //Can assume there is only 12 elements per file read because it is for a year
                {
                    LongTermAvgArray[i] = float.Parse(temp[i]);
                    LongTermAvgListbox.Items.Add(temp[i]);
                }
                LongTermArray_Read = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetAvgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String[] temp = new string[12];
                temp = File.ReadAllLines("PerthDaily.Txt"); //File present in Debug Folder
                for (int i = 0; i < 12; i++) //Can assume there is only 12 elements per file read because it is for a year
                {
                    CurrAvgArray[i] = float.Parse(temp[i]);
                    CurDailyAvgListbox.Items.Add(temp[i]);
                }
                CurrAvgArray_Read = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void GetDiffBtn_Click(object sender, EventArgs e)
        {
            if((LongTermArray_Read == true) && (CurrAvgArray_Read == true))
            {
                for(int i = 0; i < 12 ; i++ )
                    TempVarListbox.Items.Add(Math.Round((LongTermAvgArray[i] - CurrAvgArray[i]),2));//Calculate difference and round to 2 decimal places
                    
            }
            else
            {
                MessageBox.Show("Please load current average before you continue");
            }
        }

        private void GetHiLowBtn_Click(object sender, EventArgs e)
        {
            if ((LongTermArray_Read == true) && (CurrAvgArray_Read == true))
            {
                //Calculate the High and Low Temperature and put in label
                HiTempResLabel.Text = (CurrAvgArray.Max()).ToString();
                LowTempResLabel.Text = (CurrAvgArray.Min()).ToString();
            }
            else
            {
                MessageBox.Show("Please load current average before you continue");
            }
        }
    }
}
