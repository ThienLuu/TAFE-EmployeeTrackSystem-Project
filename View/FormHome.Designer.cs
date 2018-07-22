namespace View
{
    partial class FormHome
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
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnDisplayEmp = new System.Windows.Forms.Button();
            this.btnAddEmpHrs = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearchEmpHours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.Lime;
            this.btnAddEmp.Location = new System.Drawing.Point(48, 69);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(130, 50);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplayEmp
            // 
            this.btnDisplayEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisplayEmp.Location = new System.Drawing.Point(48, 349);
            this.btnDisplayEmp.Name = "btnDisplayEmp";
            this.btnDisplayEmp.Size = new System.Drawing.Size(130, 50);
            this.btnDisplayEmp.TabIndex = 0;
            this.btnDisplayEmp.Text = "Display All Employees";
            this.btnDisplayEmp.UseVisualStyleBackColor = false;
            this.btnDisplayEmp.Click += new System.EventHandler(this.btnDisplayEmp_Click);
            // 
            // btnAddEmpHrs
            // 
            this.btnAddEmpHrs.BackColor = System.Drawing.Color.Lime;
            this.btnAddEmpHrs.Location = new System.Drawing.Point(48, 181);
            this.btnAddEmpHrs.Name = "btnAddEmpHrs";
            this.btnAddEmpHrs.Size = new System.Drawing.Size(130, 50);
            this.btnAddEmpHrs.TabIndex = 1;
            this.btnAddEmpHrs.Text = "Add Hours to Employees";
            this.btnAddEmpHrs.UseVisualStyleBackColor = false;
            this.btnAddEmpHrs.Click += new System.EventHandler(this.btnAddEmpHrs_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateEmp.Location = new System.Drawing.Point(48, 125);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(130, 50);
            this.btnUpdateEmp.TabIndex = 2;
            this.btnUpdateEmp.Text = "Update Employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = false;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchEmp.Location = new System.Drawing.Point(48, 237);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(130, 50);
            this.btnSearchEmp.TabIndex = 3;
            this.btnSearchEmp.Text = "Search Employee";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Employee Manager";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(84, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 23;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchEmpHours
            // 
            this.btnSearchEmpHours.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchEmpHours.Location = new System.Drawing.Point(48, 293);
            this.btnSearchEmpHours.Name = "btnSearchEmpHours";
            this.btnSearchEmpHours.Size = new System.Drawing.Size(130, 50);
            this.btnSearchEmpHours.TabIndex = 24;
            this.btnSearchEmpHours.Text = "Search Employee Hours by ID";
            this.btnSearchEmpHours.UseVisualStyleBackColor = false;
            this.btnSearchEmpHours.Click += new System.EventHandler(this.btnSearchEmpHours_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(225, 495);
            this.Controls.Add(this.btnSearchEmpHours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnAddEmpHrs);
            this.Controls.Add(this.btnDisplayEmp);
            this.Controls.Add(this.btnAddEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnDisplayEmp;
        private System.Windows.Forms.Button btnAddEmpHrs;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearchEmpHours;
    }
}

