
namespace Address_Book
{
    partial class Form2
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
            this.name_input = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.number_input = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.address_input = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.bday_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(83, 12);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(284, 23);
            this.name_input.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(38, 15);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(42, 15);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name:";
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(92, 73);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(54, 15);
            this.number_label.TabIndex = 3;
            this.number_label.Text = "Number:";
            // 
            // number_input
            // 
            this.number_input.Location = new System.Drawing.Point(152, 70);
            this.number_input.Name = "number_input";
            this.number_input.Size = new System.Drawing.Size(215, 23);
            this.number_input.TabIndex = 2;
            this.number_input.TextChanged += new System.EventHandler(this.number_input_TextChanged);
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(28, 44);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(52, 15);
            this.address_label.TabIndex = 5;
            this.address_label.Text = "Address:";
            // 
            // address_input
            // 
            this.address_input.Location = new System.Drawing.Point(82, 41);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(284, 23);
            this.address_input.TabIndex = 4;
            this.address_input.TextChanged += new System.EventHandler(this.address_input_TextChanged);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(292, 173);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // bday_label
            // 
            this.bday_label.AutoSize = true;
            this.bday_label.Location = new System.Drawing.Point(26, 102);
            this.bday_label.Name = "bday_label";
            this.bday_label.Size = new System.Drawing.Size(123, 15);
            this.bday_label.TabIndex = 8;
            this.bday_label.Text = "Birthday (dd/mm/yy):";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(102, 131);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(44, 15);
            this.email_label.TabIndex = 10;
            this.email_label.Text = "E-Mail:";
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(152, 128);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(214, 23);
            this.email_input.TabIndex = 9;
            // 
            // day
            // 
            this.day.ForeColor = System.Drawing.Color.Black;
            this.day.Location = new System.Drawing.Point(152, 99);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(54, 23);
            this.day.TabIndex = 11;
            // 
            // month
            // 
            this.month.ForeColor = System.Drawing.Color.Black;
            this.month.Location = new System.Drawing.Point(212, 99);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(54, 23);
            this.month.TabIndex = 12;
            this.month.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // year
            // 
            this.year.ForeColor = System.Drawing.Color.Black;
            this.year.Location = new System.Drawing.Point(272, 99);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(95, 23);
            this.year.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 208);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.bday_label);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.address_input);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.number_input);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_input);
            this.Name = "Form2";
            this.Text = "Add Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.TextBox number_input;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label bday_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox year;
    }
}