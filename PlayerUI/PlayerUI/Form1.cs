using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            costumizeDesign();
        }

        private void costumizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button21_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
