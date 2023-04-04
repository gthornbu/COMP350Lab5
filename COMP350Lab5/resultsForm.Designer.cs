namespace COMP350Lab5
{
    partial class resultsForm
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
            txtResults = new TextBox();
            lblExit = new Label();
            SuspendLayout();
            // 
            // txtResults
            // 
            txtResults.BorderStyle = BorderStyle.FixedSingle;
            txtResults.Location = new Point(21, 24);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(758, 369);
            txtResults.TabIndex = 0;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BorderStyle = BorderStyle.Fixed3D;
            lblExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExit.Location = new Point(301, 405);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(208, 23);
            lblExit.TabIndex = 1;
            lblExit.Text = " Press the escape key to exit ";
            // 
            // resultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblExit);
            Controls.Add(txtResults);
            Name = "resultsForm";
            Text = "resultsForm";
            Load += resultsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResults;
        private Label lblExit;
    }
}