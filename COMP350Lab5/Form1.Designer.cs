namespace COMP350Lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDob = new TextBox();
            txtHomeAddr = new TextBox();
            txtPayRate = new TextBox();
            txtHours = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblDob = new Label();
            lblHomeAddress = new Label();
            lblPayRate = new Label();
            lblHours = new Label();
            btnSubmit = new Button();
            btnView = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(240, 132);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(145, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(240, 177);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(145, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(240, 222);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(145, 23);
            txtDob.TabIndex = 2;
            // 
            // txtHomeAddr
            // 
            txtHomeAddr.Location = new Point(536, 132);
            txtHomeAddr.Name = "txtHomeAddr";
            txtHomeAddr.Size = new Size(145, 23);
            txtHomeAddr.TabIndex = 3;
            // 
            // txtPayRate
            // 
            txtPayRate.Location = new Point(536, 177);
            txtPayRate.Name = "txtPayRate";
            txtPayRate.Size = new Size(145, 23);
            txtPayRate.TabIndex = 4;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(536, 222);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(145, 23);
            txtHours.TabIndex = 5;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(123, 135);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(124, 180);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Location = new Point(119, 225);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(73, 15);
            lblDob.TabIndex = 8;
            lblDob.Text = "Date of Birth";
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Location = new Point(413, 135);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(85, 15);
            lblHomeAddress.TabIndex = 9;
            lblHomeAddress.Text = "Home Address";
            // 
            // lblPayRate
            // 
            lblPayRate.AutoSize = true;
            lblPayRate.Location = new Point(432, 180);
            lblPayRate.Name = "lblPayRate";
            lblPayRate.Size = new Size(52, 15);
            lblPayRate.TabIndex = 10;
            lblPayRate.Text = "Pay Rate";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(414, 225);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(83, 15);
            lblHours.TabIndex = 11;
            lblHours.Text = "Hours Worked";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(288, 315);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(437, 315);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 23);
            btnView.TabIndex = 7;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(363, 344);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnView);
            Controls.Add(btnSubmit);
            Controls.Add(lblHours);
            Controls.Add(lblPayRate);
            Controls.Add(lblHomeAddress);
            Controls.Add(lblDob);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtHours);
            Controls.Add(txtPayRate);
            Controls.Add(txtHomeAddr);
            Controls.Add(txtDob);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDob;
        private TextBox txtHomeAddr;
        private TextBox txtPayRate;
        private TextBox txtHours;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDob;
        private Label lblHomeAddress;
        private Label lblPayRate;
        private Label lblHours;
        private Button btnSubmit;
        private Button btnView;
        private Button btnReset;
    }
}