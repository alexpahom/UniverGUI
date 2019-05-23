namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.AddGood = new System.Windows.Forms.Button();
            this.EditGood = new System.Windows.Forms.Button();
            this.DropGood = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FilterInput = new System.Windows.Forms.TextBox();
            this.RId = new System.Windows.Forms.RadioButton();
            this.RType = new System.Windows.Forms.RadioButton();
            this.RModel = new System.Windows.Forms.RadioButton();
            this.RMan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(43, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(443, 242);
            this.dataGridView1.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(511, 298);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddGood
            // 
            this.AddGood.Location = new System.Drawing.Point(43, 298);
            this.AddGood.Name = "AddGood";
            this.AddGood.Size = new System.Drawing.Size(94, 23);
            this.AddGood.TabIndex = 4;
            this.AddGood.Text = "Create";
            this.AddGood.UseVisualStyleBackColor = true;
            this.AddGood.Click += new System.EventHandler(this.AddGood_Click);
            // 
            // EditGood
            // 
            this.EditGood.Location = new System.Drawing.Point(160, 298);
            this.EditGood.Name = "EditGood";
            this.EditGood.Size = new System.Drawing.Size(98, 23);
            this.EditGood.TabIndex = 5;
            this.EditGood.Text = "Edit";
            this.EditGood.UseVisualStyleBackColor = true;
            this.EditGood.Click += new System.EventHandler(this.EditGood_Click);
            // 
            // DropGood
            // 
            this.DropGood.Location = new System.Drawing.Point(282, 298);
            this.DropGood.Name = "DropGood";
            this.DropGood.Size = new System.Drawing.Size(96, 23);
            this.DropGood.TabIndex = 6;
            this.DropGood.Text = "Delete";
            this.DropGood.UseVisualStyleBackColor = true;
            this.DropGood.Click += new System.EventHandler(this.DropGood_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(405, 298);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(81, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FilterInput
            // 
            this.FilterInput.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FilterInput.Location = new System.Drawing.Point(511, 172);
            this.FilterInput.Name = "FilterInput";
            this.FilterInput.Size = new System.Drawing.Size(104, 20);
            this.FilterInput.TabIndex = 8;
            this.FilterInput.Text = "Search...";
            this.FilterInput.TextChanged += new System.EventHandler(this.FilterInput_TextChanged);
            // 
            // RId
            // 
            this.RId.AutoSize = true;
            this.RId.Checked = true;
            this.RId.Location = new System.Drawing.Point(511, 61);
            this.RId.Name = "RId";
            this.RId.Size = new System.Drawing.Size(93, 17);
            this.RId.TabIndex = 9;
            this.RId.TabStop = true;
            this.RId.Text = "Stock Number";
            this.RId.UseVisualStyleBackColor = true;
            // 
            // RType
            // 
            this.RType.AutoSize = true;
            this.RType.Location = new System.Drawing.Point(511, 84);
            this.RType.Name = "RType";
            this.RType.Size = new System.Drawing.Size(49, 17);
            this.RType.TabIndex = 10;
            this.RType.Text = "Type";
            this.RType.UseVisualStyleBackColor = true;
            // 
            // RModel
            // 
            this.RModel.AutoSize = true;
            this.RModel.Location = new System.Drawing.Point(511, 107);
            this.RModel.Name = "RModel";
            this.RModel.Size = new System.Drawing.Size(54, 17);
            this.RModel.TabIndex = 11;
            this.RModel.Text = "Model";
            this.RModel.UseVisualStyleBackColor = true;
            // 
            // RMan
            // 
            this.RMan.AutoSize = true;
            this.RMan.Location = new System.Drawing.Point(511, 130);
            this.RMan.Name = "RMan";
            this.RMan.Size = new System.Drawing.Size(88, 17);
            this.RMan.TabIndex = 12;
            this.RMan.Text = "Manufacturer";
            this.RMan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 374);
            this.Controls.Add(this.RMan);
            this.Controls.Add(this.RModel);
            this.Controls.Add(this.RType);
            this.Controls.Add(this.RId);
            this.Controls.Add(this.FilterInput);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DropGood);
            this.Controls.Add(this.EditGood);
            this.Controls.Add(this.AddGood);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddGood;
        private System.Windows.Forms.Button EditGood;
        private System.Windows.Forms.Button DropGood;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox FilterInput;
        private System.Windows.Forms.RadioButton RId;
        private System.Windows.Forms.RadioButton RType;
        private System.Windows.Forms.RadioButton RModel;
        private System.Windows.Forms.RadioButton RMan;
    }
}

