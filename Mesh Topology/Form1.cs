using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesh_Topology
{
    public partial class Form1 : Form
    {
        String btn1ServerStatus = "ON";
        String btn2ServerStatus = "ON";
        String btn3ServerStatus = "ON";
        String btn4ServerStatus = "ON";
        String btn5ServerStatus = "ON";

        string[] btnStatus = new string[5+1];
        string[] btnServerStatus = new string[5 + 1];

        public Form1()
        {
            InitializeComponent();
            btnServer1.Enabled = false;
            btnServer2.Enabled = false; 
            btnServer3.Enabled = false;
            btnServer4.Enabled = false;
            btnServer5.Enabled = false;

        }

        private void MeshTopology(int PCNum, PictureBox PC, Guna2GradientCircleButton btnPCPower, Guna2ToggleSwitch btnServer)
        {
            if (btnStatus[PCNum] == "OFF")
            {
                PC.Image = Properties.Resources.Turned_Off;
                btnPCPower.FillColor = Color.FromArgb(252, 101, 90);
                btnPCPower.FillColor2 = Color.FromArgb(240, 85, 67);
                //PC1ind1.FillColor = Color.FromArgb(224, 224, 224);
                btnServer.Enabled = false;
                btnStatus[PCNum] = "ON";
            }
            else if (btnStatus[PCNum] == "ON" && btnServer.Checked)
            {
                PC.Image = Properties.Resources.Connected;
                btnPCPower.FillColor = Color.FromArgb(117, 208, 86);
                btnPCPower.FillColor2 = Color.FromArgb(101, 163, 80);
              //  PC1ind1.FillColor = Color.FromArgb(117, 208, 86);
                btnServer.Enabled = true;
                btnStatus[PCNum] = "OFF";


            }
            else
            {
                PC.Image = Properties.Resources.Powered;
                btnPCPower.FillColor = Color.FromArgb(117, 208, 86);
                btnPCPower.FillColor2 = Color.FromArgb(101, 163, 80);
                btnServer.Enabled = true;
                btnStatus[PCNum] = "OFF";
            }

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            MeshTopology(1, PC1, btnPC1Power, btnServer1);
        }

        private void btnPC2Power_Click(object sender, EventArgs e)
        {
            MeshTopology(2, PC2, btnPC2Power, btnServer2);
        }

        private void btnPC3Power_Click(object sender, EventArgs e)
        {
            MeshTopology(3, PC3, btnPC3Power, btnServer3);
        }

        private void btnPC4Power_Click(object sender, EventArgs e)
        {
            MeshTopology(4, PC4, btnPC4Power, btnServer4);
        }

        private void btnPC5Power_Click(object sender, EventArgs e)
        {
            MeshTopology(5, PC5, btnPC5Power, btnServer5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnServer1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStatus[1] == "OFF" && btnServer1.Checked)
            {
                PC1.Image = Properties.Resources.Connected;
                PC1ind1.FillColor = Color.FromArgb(117, 208, 86);

                if (btnStatus[2] == "OFF" && btnServer2.Checked)
                {
                    PC2ind1.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[3] == "OFF" && btnServer3.Checked)
                {
                    PC3ind1.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[4] == "OFF" && btnServer4.Checked)
                {
                    PC4ind1.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[5] == "OFF" && btnServer5.Checked)
                {
                    PC5ind1.FillColor = Color.FromArgb(117, 208, 86);
                }

            }
            else
            {
                PC1.Image = Properties.Resources.Powered;
                PC1ind1.FillColor = Color.FromArgb(224, 224, 224);
                PC2ind1.FillColor = Color.FromArgb(224, 224, 224);
                PC3ind1.FillColor = Color.FromArgb(224, 224, 224);
                PC4ind1.FillColor = Color.FromArgb(224, 224, 224);
                PC5ind1.FillColor = Color.FromArgb(224, 224, 224);
            }

            if (btnServer1.Checked)
            {
                PC1ind1.FillColor = Color.FromArgb(117, 208, 86);
            }
            else
            {
                PC1ind1.FillColor = Color.FromArgb(224, 224, 224);
            }




        }

        private void btnServer2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStatus[2] == "OFF" && btnServer2.Checked)
            {
                PC2.Image = Properties.Resources.Connected;
                PC2ind2.FillColor = Color.FromArgb(117, 208, 86);

                if (btnStatus[1] == "OFF" && btnServer1.Checked)
                {
                    PC2ind1.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[3] == "OFF" && btnServer3.Checked)
                {
                    PC2ind3.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[4] == "OFF" && btnServer4.Checked)
                {
                    PC2ind4.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[5] == "OFF" && btnServer5.Checked)
                {
                    PC2ind5.FillColor = Color.FromArgb(117, 208, 86);
                }

            }
            else
            {
                PC2.Image = Properties.Resources.Powered;
                PC1ind2.FillColor = Color.FromArgb(224, 224, 224);
                PC2ind2.FillColor = Color.FromArgb(224, 224, 224);
                PC3ind2.FillColor = Color.FromArgb(224, 224, 224);
                PC4ind2.FillColor = Color.FromArgb(224, 224, 224);
                PC5ind2.FillColor = Color.FromArgb(224, 224, 224);
            }


            if (btnServer2.Checked)
            {
                PC2ind2.FillColor = Color.FromArgb(117, 208, 86);
            }
            else
            {
                PC2ind2.FillColor = Color.FromArgb(224,224,224);
            }
        }

        private void btnServer3_CheckedChanged(object sender, EventArgs e)
        {

            if (btnStatus[3] == "OFF" && btnServer3.Checked)
            {
                PC3.Image = Properties.Resources.Connected;
                PC3ind3.FillColor = Color.FromArgb(117, 208, 86);

                if (btnStatus[2] == "OFF" && btnServer2.Checked)
                {
                    PC2ind2.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[1] == "OFF" && btnServer3.Checked)
                {
                    PC1ind1.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[4] == "OFF" && btnServer4.Checked)
                {
                    PC4ind3.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[5] == "OFF" && btnServer5.Checked)
                {
                    PC5ind3.FillColor = Color.FromArgb(117, 208, 86);
                }

            }
            else
            {
                PC3.Image = Properties.Resources.Powered; 
                PC1ind3.FillColor = Color.FromArgb(224, 224, 224);
                PC2ind3.FillColor = Color.FromArgb(224, 224, 224);
                PC3ind3.FillColor = Color.FromArgb(224, 224, 224);
                PC4ind3.FillColor = Color.FromArgb(224, 224, 224);
                PC5ind3.FillColor = Color.FromArgb(224, 224, 224);
            }

            if (btnServer3.Checked)
            {
                PC3ind3.FillColor = Color.FromArgb(117, 208, 86);
            }
            else
            {
                PC3ind3.FillColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void btnServer4_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStatus[4] == "OFF" && btnServer4.Checked)
            {
                PC4.Image = Properties.Resources.Connected;
                PC4ind4.FillColor = Color.FromArgb(117, 208, 86);

                if (btnStatus[2] == "OFF" && btnServer2.Checked)
                {
                    PC2ind4.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[3] == "OFF" && btnServer3.Checked)
                {
                    PC3ind4.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[1] == "OFF" && btnServer4.Checked)
                {
                    PC4ind1.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[5] == "OFF" && btnServer5.Checked)
                {
                    PC5ind4.FillColor = Color.FromArgb(117, 208, 86);
                }

            }
            else
            {
                PC4.Image = Properties.Resources.Powered;
                PC1ind4.FillColor = Color.FromArgb(224, 224, 224);
                PC2ind4.FillColor = Color.FromArgb(224, 224, 224);
                PC3ind4.FillColor = Color.FromArgb(224, 224, 224);
                PC4ind4.FillColor = Color.FromArgb(224, 224, 224);
                PC5ind4.FillColor = Color.FromArgb(224, 224, 224);
            }

            if (btnServer4.Checked)
            {
                PC4ind4.FillColor = Color.FromArgb(117, 208, 86);
            }
            else
            {
                PC4ind4.FillColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void btnServer5_CheckedChanged(object sender, EventArgs e)
        {

            if (btnStatus[5] == "OFF" && btnServer5.Checked)
            {
                PC5.Image = Properties.Resources.Connected;
                PC5ind5.FillColor = Color.FromArgb(117, 208, 86);

                if (btnStatus[2] == "OFF" && btnServer2.Checked)
                {
                    PC2ind5.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[3] == "OFF" && btnServer3.Checked)
                {
                    PC3ind5.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[4] == "OFF" && btnServer4.Checked)
                {
                    PC4ind5.FillColor = Color.FromArgb(117, 208, 86);
                }
                if (btnStatus[1] == "OFF" && btnServer5.Checked)
                {
                    PC1ind5.FillColor = Color.FromArgb(117, 208, 86);
                }

            }
            else
            {
                PC5.Image = Properties.Resources.Powered;
                PC1ind5.FillColor = Color.FromArgb(224, 224, 224);
                PC2ind5.FillColor = Color.FromArgb(224, 224, 224);
                PC3ind5.FillColor = Color.FromArgb(224, 224, 224);
                PC4ind5.FillColor = Color.FromArgb(224, 224, 224);
                PC5ind5.FillColor = Color.FromArgb(224, 224, 224);
            }

            if (btnServer5.Checked)
            {
                PC5ind5.FillColor = Color.FromArgb(117, 208, 86);
            }
            else
            {
                PC5ind5.FillColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void PC3ind3_Click(object sender, EventArgs e)
        {

        }
    }
}
