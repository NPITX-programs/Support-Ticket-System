using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingApp
{
    public partial class Form1 : Form
    {
        List<NewTicket> users = new List<NewTicket>();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignedPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void txtProblem_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbWK_CheckedChanged(object sender, EventArgs e)
        {
            rdbWK.Checked = true;
        }

        private void rdbLK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtWorkstationNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedText = comboBox.SelectedItem.ToString();

            switch (selectedText)
            {
                case "Low":
                    cmbPriority.ForeColor = Color.Green;
                    break;
                case "Medium":
                    cmbPriority.ForeColor = Color.Yellow;
                    break;
                case "High":
                    cmbPriority.ForeColor = Color.Orange;
                    break;
                case "Critical/Urgent":
                    cmbPriority.ForeColor = Color.Red;
                    break;
                case "SLA exclusion":
                    cmbPriority.ForeColor = Color.Blue;
                    break;
                default:
                    cmbPriority.ForeColor = Color.Black;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a Name!", //displays error message
                    "No Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtName.SelectAll(); //highlights all text in textbox
                txtName.Focus(); //moves cursor into textbox
            }
            else if (txtAssignedPerson.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter an Assigned Person!", //displays error message
                    "Assigned Person Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAssignedPerson.SelectAll(); //highlights all text in textbox
                txtAssignedPerson.Focus(); //moves cursor into textbox
            }
            else if (cmbPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Priority must be selected!",
                 "Priority Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //displays error message

                cmbPriority.Focus(); //moves cursor onto combobox
            }
            else if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status must be selected!",
                 "Status Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //displays error message

                cmbStatus.Focus(); //moves cursor onto combobox
            }
            else if (txtProblem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please put in the computer problem!", //displays error message
                    "Problem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtProblem.SelectAll(); //highlights all text in textbox
                txtProblem.Focus(); //moves cursor into textbox
            }
            else if (txtWorkstationNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a Workstation Number!", //displays error message
                    "Workstation Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtWorkstationNumber.SelectAll(); //highlights all text in textbox
                txtWorkstationNumber.Focus(); //moves cursor into textbox
            }
            else //data validated
            {
                //saves New Ticket
                NewTicket newTicket = new NewTicket();
                newTicket.Name = txtName.Text;
                newTicket.AssignedPerson = txtAssignedPerson.Text;
                newTicket.Status = cmbStatus.SelectedItem.ToString();
                newTicket.Priority = cmbPriority.SelectedItem.ToString();
                newTicket.Problem = txtProblem.Text.Trim();
                if (rdbWK.Checked)
                    newTicket.Workstation = rdbWK.Text + txtWorkstationNumber.Text;
                else 
                    newTicket.Workstation = rdbLK.Text + txtWorkstationNumber.Text;


                if (lstDisplay.SelectedIndex == -1)
                {
                    users.Add(newTicket);

                    lstDisplay.Items.Add(newTicket.Priority + " " + newTicket.Status + " " + newTicket.Workstation + " " + DateTime.Now.ToString("f")); //displays ticket
                }
                else
                {
                    users[lstDisplay.SelectedIndex] = newTicket; //updates the user in the list

                    lstDisplay.Items[lstDisplay.SelectedIndex] = newTicket.Priority + " " + newTicket.Status + " " + newTicket.Workstation + " " + DateTime.Now.ToString("f");

                    lstDisplay.SelectedIndex = -1; //deselects user
                }
                ClearFields();

            }






        }

        private void lstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDisplay.SelectedIndex != -1)
            {
                NewTicket newTicket = users[lstDisplay.SelectedIndex];

                txtName.Text = newTicket.Name;
                txtAssignedPerson.Text = newTicket.AssignedPerson;
                cmbPriority.Text = newTicket.Priority;
                cmbStatus.Text = newTicket.Status;
                txtProblem.Text = newTicket.Problem;
                rdbWK.Text = newTicket.Workstation;
            }
        }


        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtAssignedPerson.Text = string.Empty;
            cmbPriority.Text = string.Empty;
            cmbStatus.Text = string.Empty;
            txtProblem.Text = string.Empty;
            rdbWK.Checked = false;
            txtWorkstationNumber.Text = string.Empty;  
        }

            private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
