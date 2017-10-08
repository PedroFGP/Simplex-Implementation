namespace SimplexGUI
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.LblPreview = new MetroFramework.Controls.MetroLabel();
            this.BtnSend = new MetroFramework.Controls.MetroButton();
            this.BtnAddVar = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteVar = new MetroFramework.Controls.MetroButton();
            this.GridViewProblem = new MetroFramework.Controls.MetroGrid();
            this.BtnRemoveRestriction = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.RbtnMax = new MetroFramework.Controls.MetroRadioButton();
            this.RbtnMin = new MetroFramework.Controls.MetroRadioButton();
            this.BtnAddRestriction = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProblem)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPreview
            // 
            this.LblPreview.AutoSize = true;
            this.LblPreview.Location = new System.Drawing.Point(23, 103);
            this.LblPreview.Name = "LblPreview";
            this.LblPreview.Size = new System.Drawing.Size(139, 19);
            this.LblPreview.TabIndex = 2;
            this.LblPreview.Text = "Preview do problema:";
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSend.Location = new System.Drawing.Point(23, 350);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "Enviar";
            this.BtnSend.UseSelectable = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnAddVar
            // 
            this.BtnAddVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddVar.Location = new System.Drawing.Point(584, 125);
            this.BtnAddVar.Name = "BtnAddVar";
            this.BtnAddVar.Size = new System.Drawing.Size(113, 23);
            this.BtnAddVar.TabIndex = 9;
            this.BtnAddVar.Text = "Adicionar variável";
            this.BtnAddVar.UseSelectable = true;
            this.BtnAddVar.Click += new System.EventHandler(this.BtnAddVar_Click);
            // 
            // BtnDeleteVar
            // 
            this.BtnDeleteVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteVar.Location = new System.Drawing.Point(584, 154);
            this.BtnDeleteVar.Name = "BtnDeleteVar";
            this.BtnDeleteVar.Size = new System.Drawing.Size(113, 23);
            this.BtnDeleteVar.TabIndex = 10;
            this.BtnDeleteVar.Text = "Remover variável";
            this.BtnDeleteVar.UseSelectable = true;
            this.BtnDeleteVar.Click += new System.EventHandler(this.BtnDeleteVar_Click);
            // 
            // GridViewProblem
            // 
            this.GridViewProblem.AllowUserToAddRows = false;
            this.GridViewProblem.AllowUserToDeleteRows = false;
            this.GridViewProblem.AllowUserToResizeColumns = false;
            this.GridViewProblem.AllowUserToResizeRows = false;
            this.GridViewProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewProblem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridViewProblem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewProblem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridViewProblem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewProblem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewProblem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewProblem.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewProblem.EnableHeadersVisualStyles = false;
            this.GridViewProblem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridViewProblem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridViewProblem.Location = new System.Drawing.Point(23, 125);
            this.GridViewProblem.MultiSelect = false;
            this.GridViewProblem.Name = "GridViewProblem";
            this.GridViewProblem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewProblem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewProblem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridViewProblem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewProblem.Size = new System.Drawing.Size(555, 219);
            this.GridViewProblem.TabIndex = 11;
            this.GridViewProblem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProblem_CellEndEdit);
            this.GridViewProblem.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridViewProblem_DataError);
            // 
            // BtnRemoveRestriction
            // 
            this.BtnRemoveRestriction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveRestriction.Location = new System.Drawing.Point(584, 212);
            this.BtnRemoveRestriction.Name = "BtnRemoveRestriction";
            this.BtnRemoveRestriction.Size = new System.Drawing.Size(113, 23);
            this.BtnRemoveRestriction.TabIndex = 12;
            this.BtnRemoveRestriction.Text = "Remover restrição";
            this.BtnRemoveRestriction.UseSelectable = true;
            this.BtnRemoveRestriction.Click += new System.EventHandler(this.BtnRemoveRestriction_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(159, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Tipo Função Ojetiva (FO):";
            // 
            // RbtnMax
            // 
            this.RbtnMax.AutoSize = true;
            this.RbtnMax.Checked = true;
            this.RbtnMax.Location = new System.Drawing.Point(188, 72);
            this.RbtnMax.Name = "RbtnMax";
            this.RbtnMax.Size = new System.Drawing.Size(92, 15);
            this.RbtnMax.TabIndex = 14;
            this.RbtnMax.TabStop = true;
            this.RbtnMax.Text = "Maximização";
            this.RbtnMax.UseSelectable = true;
            // 
            // RbtnMin
            // 
            this.RbtnMin.AutoSize = true;
            this.RbtnMin.Location = new System.Drawing.Point(286, 72);
            this.RbtnMin.Name = "RbtnMin";
            this.RbtnMin.Size = new System.Drawing.Size(91, 15);
            this.RbtnMin.TabIndex = 15;
            this.RbtnMin.Text = "Minimização";
            this.RbtnMin.UseSelectable = true;
            // 
            // BtnAddRestriction
            // 
            this.BtnAddRestriction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddRestriction.Location = new System.Drawing.Point(584, 183);
            this.BtnAddRestriction.Name = "BtnAddRestriction";
            this.BtnAddRestriction.Size = new System.Drawing.Size(113, 23);
            this.BtnAddRestriction.TabIndex = 16;
            this.BtnAddRestriction.Text = "Adicionar restrição";
            this.BtnAddRestriction.UseSelectable = true;
            this.BtnAddRestriction.Click += new System.EventHandler(this.BtnAddRestriction_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 390);
            this.Controls.Add(this.BtnAddRestriction);
            this.Controls.Add(this.RbtnMin);
            this.Controls.Add(this.RbtnMax);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnRemoveRestriction);
            this.Controls.Add(this.GridViewProblem);
            this.Controls.Add(this.BtnDeleteVar);
            this.Controls.Add(this.BtnAddVar);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.LblPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 390);
            this.Name = "frmMain";
            this.Text = "Simplex GUI";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LblPreview;
        private MetroFramework.Controls.MetroButton BtnSend;
        private MetroFramework.Controls.MetroButton BtnAddVar;
        private MetroFramework.Controls.MetroButton BtnDeleteVar;
        private MetroFramework.Controls.MetroGrid GridViewProblem;
        private MetroFramework.Controls.MetroButton BtnRemoveRestriction;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton RbtnMax;
        private MetroFramework.Controls.MetroRadioButton RbtnMin;
        private MetroFramework.Controls.MetroButton BtnAddRestriction;
    }
}