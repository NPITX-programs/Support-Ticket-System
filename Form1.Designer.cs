namespace TicketingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAssignedPerson = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdbWK = new System.Windows.Forms.RadioButton();
            this.rdbLK = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkstationNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(772, 12);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(344, 706);
            this.lstDisplay.TabIndex = 0;
            this.lstDisplay.SelectedIndexChanged += new System.EventHandler(this.lstDisplay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Problem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Assigned Person:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Workstation:";
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(154, 241);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(487, 284);
            this.txtProblem.TabIndex = 7;
            this.txtProblem.TextChanged += new System.EventHandler(this.txtProblem_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(486, 20);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAssignedPerson
            // 
            this.txtAssignedPerson.Location = new System.Drawing.Point(155, 117);
            this.txtAssignedPerson.Name = "txtAssignedPerson";
            this.txtAssignedPerson.Size = new System.Drawing.Size(487, 20);
            this.txtAssignedPerson.TabIndex = 9;
            this.txtAssignedPerson.TextChanged += new System.EventHandler(this.txtAssignedPerson_TextChanged);
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical/Urgent",
            "SLA exclusion"});
            this.cmbPriority.Location = new System.Drawing.Point(154, 158);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(486, 21);
            this.cmbPriority.TabIndex = 10;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "New",
            "Assigned",
            "In Progress",
            "Waiting on Customer",
            "Waiting on 3rd Party",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(154, 201);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(486, 21);
            this.cmbStatus.TabIndex = 11;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 656);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(270, 656);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdbWK
            // 
            this.rdbWK.AutoSize = true;
            this.rdbWK.Location = new System.Drawing.Point(172, 546);
            this.rdbWK.Name = "rdbWK";
            this.rdbWK.Size = new System.Drawing.Size(70, 17);
            this.rdbWK.TabIndex = 14;
            this.rdbWK.TabStop = true;
            this.rdbWK.Text = "HOU-WK";
            this.rdbWK.UseVisualStyleBackColor = true;
            this.rdbWK.CheckedChanged += new System.EventHandler(this.rdbWK_CheckedChanged);
            // 
            // rdbLK
            // 
            this.rdbLK.AutoSize = true;
            this.rdbLK.Location = new System.Drawing.Point(172, 570);
            this.rdbLK.Name = "rdbLK";
            this.rdbLK.Size = new System.Drawing.Size(65, 17);
            this.rdbLK.TabIndex = 15;
            this.rdbLK.TabStop = true;
            this.rdbLK.Text = "HOU-LK";
            this.rdbLK.UseVisualStyleBackColor = true;
            this.rdbLK.CheckedChanged += new System.EventHandler(this.rdbLK_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Workstation Number:";
            // 
            // txtWorkstationNumber
            // 
            this.txtWorkstationNumber.Location = new System.Drawing.Point(155, 602);
            this.txtWorkstationNumber.Name = "txtWorkstationNumber";
            this.txtWorkstationNumber.Size = new System.Drawing.Size(100, 20);
            this.txtWorkstationNumber.TabIndex = 17;
            this.txtWorkstationNumber.TextChanged += new System.EventHandler(this.txtWorkstationNumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 726);
            this.Controls.Add(this.txtWorkstationNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbLK);
            this.Controls.Add(this.rdbWK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtAssignedPerson);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDisplay);
            this.Name = "Form1";
            this.Text = "Ticket App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAssignedPerson;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdbWK;
        private System.Windows.Forms.RadioButton rdbLK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWorkstationNumber;
    }
}

