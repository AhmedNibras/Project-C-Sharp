
namespace Flight_App
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.passNameLabel = new System.Windows.Forms.Label();
            this.passIDLabel = new System.Windows.Forms.Label();
            this.passCellLabel = new System.Windows.Forms.Label();
            this.comboDeparture = new System.Windows.Forms.ComboBox();
            this.comboArrival = new System.Windows.Forms.ComboBox();
            this.textDptDate = new System.Windows.Forms.DateTimePicker();
            this.textName = new System.Windows.Forms.TextBox();
            this.textIDNumber = new System.Windows.Forms.TextBox();
            this.textCell = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(179, 38);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(298, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome To Flight App";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(47, 96);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(216, 17);
            this.detailLabel.TabIndex = 1;
            this.detailLabel.Text = "To book, fill in the following detail";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Location = new System.Drawing.Point(47, 152);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(118, 17);
            this.deptLabel.TabIndex = 2;
            this.deptLabel.Text = "Departure Airport";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Location = new System.Drawing.Point(47, 198);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(94, 17);
            this.arrivalLabel.TabIndex = 3;
            this.arrivalLabel.Text = "Arrival Airport";
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(47, 251);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(106, 17);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Departure Date";
            // 
            // passNameLabel
            // 
            this.passNameLabel.AutoSize = true;
            this.passNameLabel.Location = new System.Drawing.Point(47, 299);
            this.passNameLabel.Name = "passNameLabel";
            this.passNameLabel.Size = new System.Drawing.Size(143, 17);
            this.passNameLabel.TabIndex = 5;
            this.passNameLabel.Text = "Passenger Full Name";
            // 
            // passIDLabel
            // 
            this.passIDLabel.AutoSize = true;
            this.passIDLabel.Location = new System.Drawing.Point(47, 349);
            this.passIDLabel.Name = "passIDLabel";
            this.passIDLabel.Size = new System.Drawing.Size(147, 17);
            this.passIDLabel.TabIndex = 6;
            this.passIDLabel.Text = "Passanger ID Number";
            // 
            // passCellLabel
            // 
            this.passCellLabel.AutoSize = true;
            this.passCellLabel.Location = new System.Drawing.Point(47, 408);
            this.passCellLabel.Name = "passCellLabel";
            this.passCellLabel.Size = new System.Drawing.Size(161, 17);
            this.passCellLabel.TabIndex = 7;
            this.passCellLabel.Text = "Passanger Cell Number:";
            // 
            // comboDeparture
            // 
            this.comboDeparture.FormattingEnabled = true;
            this.comboDeparture.Items.AddRange(new object[] {
            "Dallas Fort Worth International Airport",
            "Guangzhou Baiyun International Airport",
            "Indira Gandhi International Airport",
            "Braam Fischer International",
            "Dubai International Airport"});
            this.comboDeparture.Location = new System.Drawing.Point(248, 145);
            this.comboDeparture.Name = "comboDeparture";
            this.comboDeparture.Size = new System.Drawing.Size(286, 24);
            this.comboDeparture.TabIndex = 8;
            // 
            // comboArrival
            // 
            this.comboArrival.FormattingEnabled = true;
            this.comboArrival.Items.AddRange(new object[] {
            "Dallas Fort Worth International Airport",
            "Guangzhou Baiyun International Airport",
            "Indira Gandhi International Airport",
            "Braam Fischer International",
            "Dubai International Airport"});
            this.comboArrival.Location = new System.Drawing.Point(248, 191);
            this.comboArrival.Name = "comboArrival";
            this.comboArrival.Size = new System.Drawing.Size(286, 24);
            this.comboArrival.TabIndex = 9;
            // 
            // textDptDate
            // 
            this.textDptDate.Location = new System.Drawing.Point(248, 246);
            this.textDptDate.Name = "textDptDate";
            this.textDptDate.Size = new System.Drawing.Size(286, 22);
            this.textDptDate.TabIndex = 10;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(248, 294);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(286, 22);
            this.textName.TabIndex = 11;
            // 
            // textIDNumber
            // 
            this.textIDNumber.Location = new System.Drawing.Point(248, 344);
            this.textIDNumber.Name = "textIDNumber";
            this.textIDNumber.Size = new System.Drawing.Size(286, 22);
            this.textIDNumber.TabIndex = 12;
            // 
            // textCell
            // 
            this.textCell.Location = new System.Drawing.Point(248, 403);
            this.textCell.Name = "textCell";
            this.textCell.Size = new System.Drawing.Size(286, 22);
            this.textCell.TabIndex = 13;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(248, 460);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(123, 40);
            this.btnBook.TabIndex = 14;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 543);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.textCell);
            this.Controls.Add(this.textIDNumber);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textDptDate);
            this.Controls.Add(this.comboArrival);
            this.Controls.Add(this.comboDeparture);
            this.Controls.Add(this.passCellLabel);
            this.Controls.Add(this.passIDLabel);
            this.Controls.Add(this.passNameLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.deptLabel);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label arrivalLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label passNameLabel;
        private System.Windows.Forms.Label passIDLabel;
        private System.Windows.Forms.Label passCellLabel;
        private System.Windows.Forms.ComboBox comboDeparture;
        private System.Windows.Forms.ComboBox comboArrival;
        private System.Windows.Forms.DateTimePicker textDptDate;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textIDNumber;
        private System.Windows.Forms.TextBox textCell;
        private System.Windows.Forms.Button btnBook;
    }
}

