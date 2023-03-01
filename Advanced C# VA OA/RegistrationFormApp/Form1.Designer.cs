
namespace RegistrationForm
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
            System.Windows.Forms.Label degreeLabel;
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.cellLabel = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textCellNumber = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(70, 92);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new System.Drawing.Size(102, 17);
            degreeLabel.TabIndex = 2;
            degreeLabel.Text = "Select Degree:";
            // 
            // cmbDegree
            // 
            this.cmbDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Items.AddRange(new object[] {
            "Bachelor of Art",
            "Bachelor of Commerce",
            "BSc Biomedicine",
            "BSc Computer Science",
            "BSc IT",
            "Higher Certificate in IT"});
            this.cmbDegree.Location = new System.Drawing.Point(269, 81);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(264, 28);
            this.cmbDegree.TabIndex = 6;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(70, 146);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(140, 17);
            this.studentLabel.TabIndex = 7;
            this.studentLabel.Text = "Enter Student Name:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(70, 198);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(107, 17);
            this.surnameLabel.TabIndex = 8;
            this.surnameLabel.Text = "Enter Surname:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(70, 256);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(75, 17);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Enter Age:";
            // 
            // cellLabel
            // 
            this.cellLabel.AutoSize = true;
            this.cellLabel.Location = new System.Drawing.Point(70, 313);
            this.cellLabel.Name = "cellLabel";
            this.cellLabel.Size = new System.Drawing.Size(127, 17);
            this.cellLabel.TabIndex = 10;
            this.cellLabel.Text = "Enter Cell Number:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(269, 136);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(264, 27);
            this.textName.TabIndex = 11;
            // 
            // textSurname
            // 
            this.textSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSurname.Location = new System.Drawing.Point(269, 192);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(264, 27);
            this.textSurname.TabIndex = 12;
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(269, 250);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(188, 27);
            this.textAge.TabIndex = 13;
            // 
            // textCellNumber
            // 
            this.textCellNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCellNumber.Location = new System.Drawing.Point(269, 303);
            this.textCellNumber.Name = "textCellNumber";
            this.textCellNumber.Size = new System.Drawing.Size(264, 27);
            this.textCellNumber.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(269, 360);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(188, 49);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(230, 25);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.welcomeLabel.Size = new System.Drawing.Size(303, 24);
            this.welcomeLabel.TabIndex = 16;
            this.welcomeLabel.Text = "Welcome to Registration Page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textCellNumber);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.cellLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.cmbDegree);
            this.Controls.Add(degreeLabel);
            this.Name = "Form1";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label cellLabel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textCellNumber;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

