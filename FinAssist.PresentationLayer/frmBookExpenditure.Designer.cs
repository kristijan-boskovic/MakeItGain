namespace FinAssist.PresentationLayer
{
    partial class frmBookExpenditure
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdAddNewPlace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbExpPlace = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmdAddNewCategory = new System.Windows.Forms.Button();
            this.cmbExpCategory = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labCurrency = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbPayedWith = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button3.Location = new System.Drawing.Point(171, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "One more";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(261, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmdAddNewPlace
            // 
            this.cmdAddNewPlace.Location = new System.Drawing.Point(261, 106);
            this.cmdAddNewPlace.Name = "cmdAddNewPlace";
            this.cmdAddNewPlace.Size = new System.Drawing.Size(108, 23);
            this.cmdAddNewPlace.TabIndex = 54;
            this.cmdAddNewPlace.Text = "Add new place";
            this.cmdAddNewPlace.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(82, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbExpPlace
            // 
            this.cmbExpPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbExpPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbExpPlace.FormattingEnabled = true;
            this.cmbExpPlace.Location = new System.Drawing.Point(82, 106);
            this.cmbExpPlace.Name = "cmbExpPlace";
            this.cmbExpPlace.Size = new System.Drawing.Size(164, 21);
            this.cmbExpPlace.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Place:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // cmdAddNewCategory
            // 
            this.cmdAddNewCategory.Location = new System.Drawing.Point(261, 39);
            this.cmdAddNewCategory.Name = "cmdAddNewCategory";
            this.cmdAddNewCategory.Size = new System.Drawing.Size(108, 23);
            this.cmdAddNewCategory.TabIndex = 53;
            this.cmdAddNewCategory.Text = "Add new category";
            this.cmdAddNewCategory.UseVisualStyleBackColor = true;
            // 
            // cmbExpCategory
            // 
            this.cmbExpCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbExpCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbExpCategory.FormattingEnabled = true;
            this.cmbExpCategory.Location = new System.Drawing.Point(82, 41);
            this.cmbExpCategory.Name = "cmbExpCategory";
            this.cmbExpCategory.Size = new System.Drawing.Size(164, 21);
            this.cmbExpCategory.TabIndex = 36;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(82, 178);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(287, 55);
            this.txtDesc.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Category:";
            // 
            // labCurrency
            // 
            this.labCurrency.AutoSize = true;
            this.labCurrency.Location = new System.Drawing.Point(163, 143);
            this.labCurrency.Name = "labCurrency";
            this.labCurrency.Size = new System.Drawing.Size(19, 13);
            this.labCurrency.TabIndex = 44;
            this.labCurrency.Text = "kn";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(82, 140);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(75, 20);
            this.txtAmount.TabIndex = 41;
            // 
            // cmbPayedWith
            // 
            this.cmbPayedWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPayedWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPayedWith.FormattingEnabled = true;
            this.cmbPayedWith.Location = new System.Drawing.Point(82, 75);
            this.cmbPayedWith.Name = "cmbPayedWith";
            this.cmbPayedWith.Size = new System.Drawing.Size(164, 21);
            this.cmbPayedWith.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Payed with:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Date:";
            // 
            // frmBookExpenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 297);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdAddNewPlace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbExpPlace);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmdAddNewCategory);
            this.Controls.Add(this.cmbExpCategory);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labCurrency);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbPayedWith);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBookExpenditure";
            this.Text = "Book expenditure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdAddNewPlace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbExpPlace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cmdAddNewCategory;
        private System.Windows.Forms.ComboBox cmbExpCategory;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labCurrency;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbPayedWith;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}