using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALKULATOR_Challenge
{
    public partial class FormKallkulator : Form
    {
        decimal MemoryStore = 0;
        String operate = "";
        Double nilai = 0;
        bool isoperate = false;
        public FormKallkulator()
        {
            InitializeComponent();
        }

        private void labelOverview_Click(object sender, EventArgs e)
        {

        }

        private void tombol_angka(object sender, EventArgs e)
        {
            
            if((textBoxResult.Text == "0") || (isoperate))          
                textBoxResult.Clear();
            

            isoperate = false;
            Button button = (Button)sender;         

            if(button.Text == ",")
            {
                if(!textBoxResult.Text.Contains(","))              
                    textBoxResult.Text = textBoxResult.Text + button.Text;
                
            }
            else           
            textBoxResult.Text = textBoxResult.Text + button.Text;
          
        }

        private void tombol_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (nilai != 0)
            {
                buttonSAMADENGAN.PerformClick();
                operate = button.Text;
                nilai = Double.Parse(textBoxResult.Text);

                labelOverview.Text = nilai + " " + operate;

                isoperate = true;
            }
            else
            {
                operate = button.Text;
                nilai = Double.Parse(textBoxResult.Text);

                labelOverview.Text = nilai + " " + operate;

                isoperate = true;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text  = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            nilai = 0;
        }

        private void buttonSAMADENGAN_Click(object sender, EventArgs e)
        {
            switch(operate)
            {
                case "-":
                    textBoxResult.Text = (nilai - Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "+":
                    textBoxResult.Text = (nilai + Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "/":
                    textBoxResult.Text = (nilai / Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "*":
                    textBoxResult.Text = (nilai * Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "%":
                    textBoxResult.Text = (nilai % Double.Parse(textBoxResult.Text)).ToString();
                    break;

                default:
                    break;


              
            }
            nilai = Double.Parse(textBoxResult.Text);
            labelOverview.Text = "";
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            if(textBoxResult.Text.Length >0)
            {
                textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1, 1);
            }
            if(textBoxResult.Text =="")
            {
                textBoxResult.Text = "0";
            }
        }

        private void buttonMMIN_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            //Memory Recall
            textBoxResult.Text  = MemoryStore.ToString();
            return;
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            // Memory subtract
          //  MemoryStore -= textBoxResult.Text;
            return;
        }

        private void buttonMPLUS_Click(object sender, EventArgs e)
        {
            // Memory add 
           // MemoryStore += textBoxResult.Text ;
            return;
        }
    }
}
