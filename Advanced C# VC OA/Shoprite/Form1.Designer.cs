
namespace Shoprite
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.radioFood = new System.Windows.Forms.RadioButton();
            this.capture = new System.Windows.Forms.Button();
            this.radioCosmetics = new System.Windows.Forms.RadioButton();
            this.radioElectronic = new System.Windows.Forms.RadioButton();
            this.prodNameLabel = new System.Windows.Forms.Label();
            this.prodTypeLabel = new System.Windows.Forms.Label();
            this.prodQuantLabel = new System.Windows.Forms.Label();
            this.prodPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(210, 32);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(392, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome To Shoprite Stock App";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(161, 102);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(395, 22);
            this.textName.TabIndex = 1;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(165, 225);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(175, 22);
            this.textQuantity.TabIndex = 2;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(166, 287);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(175, 22);
            this.textPrice.TabIndex = 3;
            // 
            // radioFood
            // 
            this.radioFood.AutoSize = true;
            this.radioFood.Location = new System.Drawing.Point(166, 165);
            this.radioFood.Name = "radioFood";
            this.radioFood.Size = new System.Drawing.Size(57, 21);
            this.radioFood.TabIndex = 4;
            this.radioFood.TabStop = true;
            this.radioFood.Text = "food";
            this.radioFood.UseVisualStyleBackColor = true;
            this.radioFood.CheckedChanged += new System.EventHandler(this.radioFood_CheckedChanged);
            // 
            // capture
            // 
            this.capture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capture.Location = new System.Drawing.Point(316, 341);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(167, 49);
            this.capture.TabIndex = 5;
            this.capture.Text = "Capture";
            this.capture.UseVisualStyleBackColor = true;
            this.capture.Click += new System.EventHandler(this.capture_Click);
            // 
            // radioCosmetics
            // 
            this.radioCosmetics.AutoSize = true;
            this.radioCosmetics.Location = new System.Drawing.Point(244, 165);
            this.radioCosmetics.Name = "radioCosmetics";
            this.radioCosmetics.Size = new System.Drawing.Size(93, 21);
            this.radioCosmetics.TabIndex = 6;
            this.radioCosmetics.TabStop = true;
            this.radioCosmetics.Text = "Cosmetics";
            this.radioCosmetics.UseVisualStyleBackColor = true;
            this.radioCosmetics.CheckedChanged += new System.EventHandler(this.radioCosmetics_CheckedChanged);
            // 
            // radioElectronic
            // 
            this.radioElectronic.AutoSize = true;
            this.radioElectronic.Location = new System.Drawing.Point(352, 165);
            this.radioElectronic.Name = "radioElectronic";
            this.radioElectronic.Size = new System.Drawing.Size(98, 21);
            this.radioElectronic.TabIndex = 7;
            this.radioElectronic.TabStop = true;
            this.radioElectronic.Text = "Electronics";
            this.radioElectronic.UseVisualStyleBackColor = true;
            this.radioElectronic.CheckedChanged += new System.EventHandler(this.radioElectronic_CheckedChanged);
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Location = new System.Drawing.Point(31, 107);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(102, 17);
            this.prodNameLabel.TabIndex = 8;
            this.prodNameLabel.Text = "Product Name:";
            // 
            // prodTypeLabel
            // 
            this.prodTypeLabel.AutoSize = true;
            this.prodTypeLabel.Location = new System.Drawing.Point(31, 167);
            this.prodTypeLabel.Name = "prodTypeLabel";
            this.prodTypeLabel.Size = new System.Drawing.Size(97, 17);
            this.prodTypeLabel.TabIndex = 9;
            this.prodTypeLabel.Text = "Product Type:";
            // 
            // prodQuantLabel
            // 
            this.prodQuantLabel.AutoSize = true;
            this.prodQuantLabel.Location = new System.Drawing.Point(30, 226);
            this.prodQuantLabel.Name = "prodQuantLabel";
            this.prodQuantLabel.Size = new System.Drawing.Size(118, 17);
            this.prodQuantLabel.TabIndex = 10;
            this.prodQuantLabel.Text = "Product Quantity:";
            // 
            // prodPriceLabel
            // 
            this.prodPriceLabel.AutoSize = true;
            this.prodPriceLabel.Location = new System.Drawing.Point(30, 287);
            this.prodPriceLabel.Name = "prodPriceLabel";
            this.prodPriceLabel.Size = new System.Drawing.Size(97, 17);
            this.prodPriceLabel.TabIndex = 11;
            this.prodPriceLabel.Text = "Product Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 457);
            this.Controls.Add(this.prodPriceLabel);
            this.Controls.Add(this.prodQuantLabel);
            this.Controls.Add(this.prodTypeLabel);
            this.Controls.Add(this.prodNameLabel);
            this.Controls.Add(this.radioElectronic);
            this.Controls.Add(this.radioCosmetics);
            this.Controls.Add(this.capture);
            this.Controls.Add(this.radioFood);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.RadioButton radioFood;
        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.RadioButton radioCosmetics;
        private System.Windows.Forms.RadioButton radioElectronic;
        private System.Windows.Forms.Label prodNameLabel;
        private System.Windows.Forms.Label prodTypeLabel;
        private System.Windows.Forms.Label prodQuantLabel;
        private System.Windows.Forms.Label prodPriceLabel;
    }
}

