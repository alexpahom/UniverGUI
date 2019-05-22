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
            this.FilterButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.AddGood = new System.Windows.Forms.Button();
            this.EditGood = new System.Windows.Forms.Button();
            this.DropGood = new System.Windows.Forms.Button();
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
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(607, 337);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Фильтр";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(43, 337);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddGood
            // 
            this.AddGood.Location = new System.Drawing.Point(43, 298);
            this.AddGood.Name = "AddGood";
            this.AddGood.Size = new System.Drawing.Size(114, 23);
            this.AddGood.TabIndex = 4;
            this.AddGood.Text = "Добавить";
            this.AddGood.UseVisualStyleBackColor = true;
            this.AddGood.Click += new System.EventHandler(this.AddGood_Click);
            // 
            // EditGood
            // 
            this.EditGood.Location = new System.Drawing.Point(175, 298);
            this.EditGood.Name = "EditGood";
            this.EditGood.Size = new System.Drawing.Size(114, 23);
            this.EditGood.TabIndex = 5;
            this.EditGood.Text = "Редактировать";
            this.EditGood.UseVisualStyleBackColor = true;
            this.EditGood.Click += new System.EventHandler(this.EditGood_Click);
            // 
            // DropGood
            // 
            this.DropGood.Location = new System.Drawing.Point(308, 298);
            this.DropGood.Name = "DropGood";
            this.DropGood.Size = new System.Drawing.Size(114, 23);
            this.DropGood.TabIndex = 6;
            this.DropGood.Text = "Удалить";
            this.DropGood.UseVisualStyleBackColor = true;
            this.DropGood.Click += new System.EventHandler(this.DropGood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 445);
            this.Controls.Add(this.DropGood);
            this.Controls.Add(this.EditGood);
            this.Controls.Add(this.AddGood);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddGood;
        private System.Windows.Forms.Button EditGood;
        private System.Windows.Forms.Button DropGood;
    }
}

