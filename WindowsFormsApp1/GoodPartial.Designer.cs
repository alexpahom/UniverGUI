namespace WindowsFormsApp1
{
    partial class GoodPartial
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ManTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.LId = new System.Windows.Forms.Label();
            this.LType = new System.Windows.Forms.Label();
            this.LModel = new System.Windows.Forms.Label();
            this.LMan = new System.Windows.Forms.Label();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.LError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(159, 40);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(105, 20);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.TextChanged += new System.EventHandler(this.Good_Partial_TextChanged);
            // 
            // ManTextBox
            // 
            this.ManTextBox.Location = new System.Drawing.Point(159, 204);
            this.ManTextBox.Name = "ManTextBox";
            this.ManTextBox.Size = new System.Drawing.Size(105, 20);
            this.ManTextBox.TabIndex = 1;
            this.ManTextBox.TextChanged += new System.EventHandler(this.Good_Partial_TextChanged);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(159, 149);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(105, 20);
            this.ModelTextBox.TabIndex = 2;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.Good_Partial_TextChanged);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(159, 94);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(105, 20);
            this.TypeTextBox.TabIndex = 3;
            this.TypeTextBox.TextChanged += new System.EventHandler(this.Good_Partial_TextChanged);
            // 
            // LId
            // 
            this.LId.AutoSize = true;
            this.LId.Location = new System.Drawing.Point(56, 43);
            this.LId.Name = "LId";
            this.LId.Size = new System.Drawing.Size(75, 13);
            this.LId.TabIndex = 4;
            this.LId.Text = "Stock Number";
            // 
            // LType
            // 
            this.LType.AutoSize = true;
            this.LType.Location = new System.Drawing.Point(56, 97);
            this.LType.Name = "LType";
            this.LType.Size = new System.Drawing.Size(31, 13);
            this.LType.TabIndex = 5;
            this.LType.Text = "Type";
            // 
            // LModel
            // 
            this.LModel.AutoSize = true;
            this.LModel.Location = new System.Drawing.Point(56, 152);
            this.LModel.Name = "LModel";
            this.LModel.Size = new System.Drawing.Size(36, 13);
            this.LModel.TabIndex = 6;
            this.LModel.Text = "Model";
            // 
            // LMan
            // 
            this.LMan.AutoSize = true;
            this.LMan.Location = new System.Drawing.Point(56, 207);
            this.LMan.Name = "LMan";
            this.LMan.Size = new System.Drawing.Size(70, 13);
            this.LMan.TabIndex = 7;
            this.LMan.Text = "Manufacturer";
            // 
            // BUpdate
            // 
            this.BUpdate.Location = new System.Drawing.Point(59, 316);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(75, 23);
            this.BUpdate.TabIndex = 8;
            this.BUpdate.Text = "Save";
            this.BUpdate.UseVisualStyleBackColor = true;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(178, 316);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 9;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // LError
            // 
            this.LError.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LError.Location = new System.Drawing.Point(9, 260);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(309, 23);
            this.LError.TabIndex = 10;
            this.LError.Text = "Трололо";
            this.LError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LError.Visible = false;
            // 
            // GoodPartial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 377);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.LMan);
            this.Controls.Add(this.LModel);
            this.Controls.Add(this.LType);
            this.Controls.Add(this.LId);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ManTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Name = "GoodPartial";
            this.Text = "GoodPartial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox ManTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label LId;
        private System.Windows.Forms.Label LType;
        private System.Windows.Forms.Label LModel;
        private System.Windows.Forms.Label LMan;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Label LError;
    }
}