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
    public partial class executionForm : Form
    {
        public executionForm()
        {
            InitializeComponent();
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            projectsPanel.Visible = true;
            portfolioPanel.Visible = false;
            createProjectPanel.Visible = false;
        }

        private void reportsButtons_Click(object sender, EventArgs e)
        {
            createProjectPanel.Visible = false;
            portfolioPanel.Visible = true;
        }

        private void createProjectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            portfolioPanel.Visible = true;
            createProjectPanel.Visible = true;
        }

        private void projectNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TOCLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(this.nccButton.Visible == false)
            {
                this.entryCurButton.Visible = true;
                this.diCatButton.Visible = true;
                this.nccButton.Visible = true;
                this.projectOwnerButton.Visible = true;
                this.orgUnitButton.Visible = true;
                this.wtgTypeButton.Visible = true;
                this.ownerButton.Visible = true;
                this.usersButton.Visible = true;
                this.transfSalesProjButton.Visible = true;
            }
            else
            {
                this.transfSalesProjButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.usersButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.ownerButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.wtgTypeButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.orgUnitButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.projectOwnerButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.nccButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.diCatButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.entryCurButton.Visible = false;
            }

        }
    }
}
