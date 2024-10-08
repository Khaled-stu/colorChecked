using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorChecked
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRed.Checked == true)
            {
                chkRed.ForeColor = Color.FromName("red");
            }
            else
            {
                chkRed.ForeColor = Color.FromName("black");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //with else statment reset color
            chkYellow.ForeColor = Color.Black;
            chkBlue.ForeColor = Color.Black;
            chkGreen.ForeColor = Color.Black;
            chkRed.ForeColor = Color.Black;
            
            rdoBlue.ForeColor = Color.Black;
            rdoGreen.ForeColor = Color.Black;
            rdoRed.ForeColor = Color.Black;
            rdoYellow.ForeColor = Color.Black;

            // with else statment reset answer
            chkYellow.Checked = false;
            chkBlue.Checked = false;
            chkGreen.Checked = false;
            chkRed.Checked = false;

            rdoBlue.Checked = false;
            rdoGreen.Checked = false;
            rdoRed.Checked = false;
            rdoYellow.Checked = false;

            //without else statment reset color
            radioGreen.ForeColor = Color.FromName("black");
            radioRed.ForeColor = Color.FromArgb(0,0,0);
            radioYellow.ForeColor = Color.Black;

            // without else statment reset answer
            radioGreen.Checked = false;
            radioYellow.Checked = false;
            radioRed.Checked = false;



        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked == true)
            {
                rdoRed.ForeColor = Color.FromName("red");
            }
            else
            {
                rdoRed.ForeColor = Color.FromName("black");
            }
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked == true)
            {
                rdoBlue.ForeColor = Color.FromName("blue");
            }
            else
            {
                rdoBlue.ForeColor = Color.FromName("black");
            }
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
            {
                rdoGreen.ForeColor = Color.FromName("green");
            }
            else
            {
                rdoGreen.ForeColor = Color.FromName("black");
            }
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked == true)
            {
                rdoYellow.ForeColor = Color.FromName("yellow");
            }
            else
            {
                rdoYellow.ForeColor = Color.FromName("black");
            }
        }

        private void chkBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYellow.Checked == true)
            {
                chkYellow.ForeColor = Color.FromName("yellow");
            }
            else 
            {
                chkYellow.ForeColor = Color.FromName("black");   
            }
        }

        private void chkBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlue.Checked == true)
            {
                chkBlue.ForeColor = Color.FromName("blue");
            }
            else
            {
                chkBlue.ForeColor = Color.FromName("black");
            }
        }

        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreen.Checked == true)
            {
                chkGreen.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                chkGreen.ForeColor = Color.FromName("black");
            }
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRed.Checked == true)
            {
                radioRed.ForeColor = Color.FromName("red");
            }
            
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGreen.Checked == true)
            {
                radioGreen.ForeColor = Color.FromName("green");
            }
        }

        private void radioYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYellow.Checked == true)
            {
                radioYellow.ForeColor = Color.FromName("yellow");
            }
        }
    }
    }

