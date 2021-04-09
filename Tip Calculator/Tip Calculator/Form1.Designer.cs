
namespace Tip_Calculator
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
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.peopleTextBox = new System.Windows.Forms.TextBox();
            this.billInput = new System.Windows.Forms.TextBox();
            this.tipInput = new System.Windows.Forms.TextBox();
            this.tipMinus = new System.Windows.Forms.Button();
            this.tipPlus = new System.Windows.Forms.Button();
            this.peoplePlus = new System.Windows.Forms.Button();
            this.peopleMinus = new System.Windows.Forms.Button();
            this.peopleInput = new System.Windows.Forms.TextBox();
            this.TipOutputHeader = new System.Windows.Forms.TextBox();
            this.tipOutputFooter = new System.Windows.Forms.TextBox();
            this.totalOutputFooter = new System.Windows.Forms.TextBox();
            this.totalOutputHeader = new System.Windows.Forms.TextBox();
            this.tipOutput = new System.Windows.Forms.TextBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // billTextBox
            // 
            this.billTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billTextBox.Enabled = false;
            this.billTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.billTextBox.Location = new System.Drawing.Point(78, 59);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(100, 16);
            this.billTextBox.TabIndex = 0;
            this.billTextBox.Text = "Bill";
            // 
            // tipTextBox
            // 
            this.tipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipTextBox.Enabled = false;
            this.tipTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tipTextBox.Location = new System.Drawing.Point(78, 128);
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(100, 16);
            this.tipTextBox.TabIndex = 1;
            this.tipTextBox.Text = "Tip %";
            // 
            // peopleTextBox
            // 
            this.peopleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.peopleTextBox.Enabled = false;
            this.peopleTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.peopleTextBox.Location = new System.Drawing.Point(78, 205);
            this.peopleTextBox.Name = "peopleTextBox";
            this.peopleTextBox.Size = new System.Drawing.Size(100, 16);
            this.peopleTextBox.TabIndex = 2;
            this.peopleTextBox.Text = "No. of People";
            // 
            // billInput
            // 
            this.billInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billInput.Location = new System.Drawing.Point(78, 88);
            this.billInput.MaxLength = 15;
            this.billInput.Name = "billInput";
            this.billInput.PlaceholderText = "500.00";
            this.billInput.Size = new System.Drawing.Size(221, 27);
            this.billInput.TabIndex = 3;
            this.billInput.Text = "500";
            this.billInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billInput.TextChanged += new System.EventHandler(this.billInput_TextChanged);
            this.billInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billInput_KeyPress);
            this.billInput.Leave += new System.EventHandler(this.billInput_Leave);
            // 
            // tipInput
            // 
            this.tipInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipInput.Location = new System.Drawing.Point(112, 157);
            this.tipInput.MaxLength = 5;
            this.tipInput.Name = "tipInput";
            this.tipInput.PlaceholderText = "0";
            this.tipInput.Size = new System.Drawing.Size(155, 27);
            this.tipInput.TabIndex = 4;
            this.tipInput.Text = "10%";
            this.tipInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipInput.TextChanged += new System.EventHandler(this.tipInput_TextChanged);
            this.tipInput.Enter += new System.EventHandler(this.tipInput_Enter);
            this.tipInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipInput_KeyPress);
            this.tipInput.Leave += new System.EventHandler(this.tipInput_Leave);
            // 
            // tipMinus
            // 
            this.tipMinus.FlatAppearance.BorderSize = 0;
            this.tipMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipMinus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tipMinus.Location = new System.Drawing.Point(78, 157);
            this.tipMinus.Name = "tipMinus";
            this.tipMinus.Size = new System.Drawing.Size(28, 34);
            this.tipMinus.TabIndex = 5;
            this.tipMinus.Text = "-";
            this.tipMinus.UseVisualStyleBackColor = true;
            this.tipMinus.Click += new System.EventHandler(this.tipMinus_Click);
            // 
            // tipPlus
            // 
            this.tipPlus.FlatAppearance.BorderSize = 0;
            this.tipPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipPlus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tipPlus.Location = new System.Drawing.Point(271, 157);
            this.tipPlus.Name = "tipPlus";
            this.tipPlus.Size = new System.Drawing.Size(28, 34);
            this.tipPlus.TabIndex = 6;
            this.tipPlus.Text = "+";
            this.tipPlus.UseVisualStyleBackColor = true;
            this.tipPlus.Click += new System.EventHandler(this.tipPlus_Click);
            // 
            // peoplePlus
            // 
            this.peoplePlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.peoplePlus.FlatAppearance.BorderSize = 0;
            this.peoplePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peoplePlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.peoplePlus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.peoplePlus.Location = new System.Drawing.Point(271, 234);
            this.peoplePlus.Name = "peoplePlus";
            this.peoplePlus.Size = new System.Drawing.Size(28, 34);
            this.peoplePlus.TabIndex = 9;
            this.peoplePlus.Text = "+";
            this.peoplePlus.UseVisualStyleBackColor = true;
            this.peoplePlus.Click += new System.EventHandler(this.peoplePlus_Click);
            // 
            // peopleMinus
            // 
            this.peopleMinus.FlatAppearance.BorderSize = 0;
            this.peopleMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peopleMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.peopleMinus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.peopleMinus.Location = new System.Drawing.Point(78, 234);
            this.peopleMinus.Name = "peopleMinus";
            this.peopleMinus.Size = new System.Drawing.Size(28, 34);
            this.peopleMinus.TabIndex = 8;
            this.peopleMinus.Text = "-";
            this.peopleMinus.UseVisualStyleBackColor = true;
            this.peopleMinus.Click += new System.EventHandler(this.peopleMinus_Click);
            // 
            // peopleInput
            // 
            this.peopleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.peopleInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.peopleInput.Location = new System.Drawing.Point(112, 234);
            this.peopleInput.MaxLength = 5;
            this.peopleInput.Name = "peopleInput";
            this.peopleInput.PlaceholderText = "1";
            this.peopleInput.Size = new System.Drawing.Size(155, 27);
            this.peopleInput.TabIndex = 7;
            this.peopleInput.Text = "2";
            this.peopleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.peopleInput.TextChanged += new System.EventHandler(this.peopleInput_TextChanged);
            this.peopleInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.peopleInput_KeyPress);
            // 
            // TipOutputHeader
            // 
            this.TipOutputHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TipOutputHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TipOutputHeader.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TipOutputHeader.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TipOutputHeader.Location = new System.Drawing.Point(355, 102);
            this.TipOutputHeader.Name = "TipOutputHeader";
            this.TipOutputHeader.ReadOnly = true;
            this.TipOutputHeader.Size = new System.Drawing.Size(100, 27);
            this.TipOutputHeader.TabIndex = 10;
            this.TipOutputHeader.Text = "Tip";
            // 
            // tipOutputFooter
            // 
            this.tipOutputFooter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipOutputFooter.Enabled = false;
            this.tipOutputFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipOutputFooter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tipOutputFooter.Location = new System.Drawing.Point(355, 130);
            this.tipOutputFooter.Name = "tipOutputFooter";
            this.tipOutputFooter.Size = new System.Drawing.Size(100, 16);
            this.tipOutputFooter.TabIndex = 11;
            this.tipOutputFooter.Text = "per person";
            // 
            // totalOutputFooter
            // 
            this.totalOutputFooter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalOutputFooter.Enabled = false;
            this.totalOutputFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalOutputFooter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.totalOutputFooter.Location = new System.Drawing.Point(355, 207);
            this.totalOutputFooter.Name = "totalOutputFooter";
            this.totalOutputFooter.Size = new System.Drawing.Size(100, 16);
            this.totalOutputFooter.TabIndex = 13;
            this.totalOutputFooter.Text = "per person";
            // 
            // totalOutputHeader
            // 
            this.totalOutputHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalOutputHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalOutputHeader.ForeColor = System.Drawing.SystemColors.InfoText;
            this.totalOutputHeader.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.totalOutputHeader.Location = new System.Drawing.Point(355, 179);
            this.totalOutputHeader.Name = "totalOutputHeader";
            this.totalOutputHeader.ReadOnly = true;
            this.totalOutputHeader.Size = new System.Drawing.Size(100, 27);
            this.totalOutputHeader.TabIndex = 12;
            this.totalOutputHeader.Text = "Total";
            // 
            // tipOutput
            // 
            this.tipOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipOutput.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipOutput.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tipOutput.Location = new System.Drawing.Point(461, 102);
            this.tipOutput.Name = "tipOutput";
            this.tipOutput.ReadOnly = true;
            this.tipOutput.Size = new System.Drawing.Size(193, 45);
            this.tipOutput.TabIndex = 14;
            this.tipOutput.Text = "$25.00";
            this.tipOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalOutput.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalOutput.ForeColor = System.Drawing.SystemColors.MenuText;
            this.totalOutput.Location = new System.Drawing.Point(461, 178);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.ReadOnly = true;
            this.totalOutput.Size = new System.Drawing.Size(193, 45);
            this.totalOutput.TabIndex = 15;
            this.totalOutput.Text = "$275.00";
            this.totalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 318);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.tipOutput);
            this.Controls.Add(this.totalOutputFooter);
            this.Controls.Add(this.totalOutputHeader);
            this.Controls.Add(this.tipOutputFooter);
            this.Controls.Add(this.TipOutputHeader);
            this.Controls.Add(this.peoplePlus);
            this.Controls.Add(this.peopleMinus);
            this.Controls.Add(this.peopleInput);
            this.Controls.Add(this.tipPlus);
            this.Controls.Add(this.tipMinus);
            this.Controls.Add(this.tipInput);
            this.Controls.Add(this.billInput);
            this.Controls.Add(this.peopleTextBox);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.billTextBox);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.TextBox peopleTextBox;
        private System.Windows.Forms.TextBox billInput;
        private System.Windows.Forms.TextBox tipInput;
        private System.Windows.Forms.Button tipMinus;
        private System.Windows.Forms.Button tipPlus;
        private System.Windows.Forms.Button peoplePlus;
        private System.Windows.Forms.Button peopleMinus;
        private System.Windows.Forms.TextBox peopleInput;
        private System.Windows.Forms.TextBox TipOutputHeader;
        private System.Windows.Forms.TextBox tipOutputFooter;
        private System.Windows.Forms.TextBox totalOutputFooter;
        private System.Windows.Forms.TextBox totalOutputHeader;
        private System.Windows.Forms.TextBox tipOutput;
        private System.Windows.Forms.TextBox totalOutput;
    }
}

