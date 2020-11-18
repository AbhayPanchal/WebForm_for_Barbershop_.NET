namespace AssignmentLab3B
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
            this.HairdresserGroupBox = new System.Windows.Forms.GroupBox();
            this.HairdresserComboBox = new System.Windows.Forms.ComboBox();
            this.ServiceGroupbox = new System.Windows.Forms.GroupBox();
            this.ServiceListBox = new System.Windows.Forms.ListBox();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceListBox = new System.Windows.Forms.ListBox();
            this.PriceTextbox2 = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PriceButton = new System.Windows.Forms.Button();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.HairdresserGroupBox.SuspendLayout();
            this.ServiceGroupbox.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HairdresserGroupBox
            // 
            this.HairdresserGroupBox.Controls.Add(this.HairdresserComboBox);
            this.HairdresserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HairdresserGroupBox.Location = new System.Drawing.Point(12, 12);
            this.HairdresserGroupBox.Name = "HairdresserGroupBox";
            this.HairdresserGroupBox.Size = new System.Drawing.Size(233, 172);
            this.HairdresserGroupBox.TabIndex = 0;
            this.HairdresserGroupBox.TabStop = false;
            this.HairdresserGroupBox.Text = "Select a Hairdresser:";
            // 
            // HairdresserComboBox
            // 
            this.HairdresserComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "c#"});
            this.HairdresserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HairdresserComboBox.FormattingEnabled = true;
            this.HairdresserComboBox.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.HairdresserComboBox.Location = new System.Drawing.Point(7, 27);
            this.HairdresserComboBox.Name = "HairdresserComboBox";
            this.HairdresserComboBox.Size = new System.Drawing.Size(204, 28);
            this.HairdresserComboBox.TabIndex = 1;
            // 
            // ServiceGroupbox
            // 
            this.ServiceGroupbox.Controls.Add(this.ServiceListBox);
            this.ServiceGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceGroupbox.Location = new System.Drawing.Point(251, 13);
            this.ServiceGroupbox.Name = "ServiceGroupbox";
            this.ServiceGroupbox.Size = new System.Drawing.Size(238, 171);
            this.ServiceGroupbox.TabIndex = 1;
            this.ServiceGroupbox.TabStop = false;
            this.ServiceGroupbox.Text = "Select a Service";
            // 
            // ServiceListBox
            // 
            this.ServiceListBox.FormattingEnabled = true;
            this.ServiceListBox.ItemHeight = 20;
            this.ServiceListBox.Location = new System.Drawing.Point(7, 21);
            this.ServiceListBox.Name = "ServiceListBox";
            this.ServiceListBox.Size = new System.Drawing.Size(225, 144);
            this.ServiceListBox.TabIndex = 0;
            this.ServiceListBox.SelectedIndexChanged += new System.EventHandler(this.ServiceListBox_SelectedIndexChanged);
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsGroupBox.Location = new System.Drawing.Point(495, 13);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(200, 171);
            this.ItemsGroupBox.TabIndex = 2;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Charged Items:";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(7, 21);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(187, 144);
            this.ItemsListBox.TabIndex = 0;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.PriceListBox);
            this.PriceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceGroupBox.Location = new System.Drawing.Point(701, 13);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(113, 171);
            this.PriceGroupBox.TabIndex = 3;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Price:";
            // 
            // PriceListBox
            // 
            this.PriceListBox.FormattingEnabled = true;
            this.PriceListBox.ItemHeight = 20;
            this.PriceListBox.Location = new System.Drawing.Point(1, 21);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.Size = new System.Drawing.Size(106, 144);
            this.PriceListBox.TabIndex = 0;
            // 
            // PriceTextbox2
            // 
            this.PriceTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextbox2.Location = new System.Drawing.Point(714, 208);
            this.PriceTextbox2.Name = "PriceTextbox2";
            this.PriceTextbox2.ReadOnly = true;
            this.PriceTextbox2.Size = new System.Drawing.Size(100, 27);
            this.PriceTextbox2.TabIndex = 4;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(598, 211);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(95, 20);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Total Price:";
           
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(636, 253);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(165, 31);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(459, 253);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(171, 31);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PriceButton
            // 
            this.PriceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceButton.Location = new System.Drawing.Point(301, 253);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(150, 31);
            this.PriceButton.TabIndex = 8;
            this.PriceButton.Text = "Calculate Price";
            this.PriceButton.UseVisualStyleBackColor = true;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // ServiceButton
            // 
            this.ServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceButton.Location = new System.Drawing.Point(141, 253);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(154, 31);
            this.ServiceButton.TabIndex = 9;
            this.ServiceButton.Text = "Add Service";
            this.ServiceButton.UseVisualStyleBackColor = true;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 296);
            this.Controls.Add(this.ServiceButton);
            this.Controls.Add(this.PriceButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceTextbox2);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.ItemsGroupBox);
            this.Controls.Add(this.ServiceGroupbox);
            this.Controls.Add(this.HairdresserGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HairdresserGroupBox.ResumeLayout(false);
            this.ServiceGroupbox.ResumeLayout(false);
            this.ItemsGroupBox.ResumeLayout(false);
            this.PriceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox HairdresserGroupBox;
        private System.Windows.Forms.GroupBox ServiceGroupbox;
        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.TextBox PriceTextbox2;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.Button ServiceButton;
        private System.Windows.Forms.ComboBox HairdresserComboBox;
        private System.Windows.Forms.ListBox ServiceListBox;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ListBox PriceListBox;
    }
}

