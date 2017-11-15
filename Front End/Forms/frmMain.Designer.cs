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
            this.RbtnCustomAPI = new MetroFramework.Controls.MetroRadioButton();
            this.RbtnGLPKAPI = new MetroFramework.Controls.MetroRadioButton();
            this.LblAPI = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProblem)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPreview
            // 
            this.LblPreview.AutoSize = true;
            this.LblPreview.Location = new System.Drawing.Point(23, 142);
            this.LblPreview.Name = "LblPreview";
            this.LblPreview.Size = new System.Drawing.Size(139, 19);
            this.LblPreview.TabIndex = 2;
            this.LblPreview.Text = "Preview do problema:";
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSend.Location = new System.Drawing.Point(23, 420);
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
            this.BtnAddVar.Location = new System.Drawing.Point(584, 164);
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
            this.BtnDeleteVar.Location = new System.Drawing.Point(584, 193);
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
            this.GridViewProblem.Location = new System.Drawing.Point(23, 164);
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
            this.GridViewProblem.Size = new System.Drawing.Size(555, 250);
            this.GridViewProblem.TabIndex = 11;
            this.GridViewProblem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProblem_CellEndEdit);
            this.GridViewProblem.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridViewProblem_DataError);
            // 
            // BtnRemoveRestriction
            // 
            this.BtnRemoveRestriction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveRestriction.Location = new System.Drawing.Point(584, 251);
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
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(159, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Tipo Função Ojetiva (FO):";
            // 
            // RbtnMax
            // 
            this.RbtnMax.AutoSize = true;
            this.RbtnMax.Checked = true;
            this.RbtnMax.Location = new System.Drawing.Point(165, 4);
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
            this.RbtnMin.Location = new System.Drawing.Point(263, 4);
            this.RbtnMin.Name = "RbtnMin";
            this.RbtnMin.Size = new System.Drawing.Size(91, 15);
            this.RbtnMin.TabIndex = 15;
            this.RbtnMin.Text = "Minimização";
            this.RbtnMin.UseSelectable = true;
            // 
            // BtnAddRestriction
            // 
            this.BtnAddRestriction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddRestriction.Location = new System.Drawing.Point(584, 222);
            this.BtnAddRestriction.Name = "BtnAddRestriction";
            this.BtnAddRestriction.Size = new System.Drawing.Size(113, 23);
            this.BtnAddRestriction.TabIndex = 16;
            this.BtnAddRestriction.Text = "Adicionar restrição";
            this.BtnAddRestriction.UseSelectable = true;
            this.BtnAddRestriction.Click += new System.EventHandler(this.BtnAddRestriction_Click);
            // 
            // RbtnCustomAPI
            // 
            this.RbtnCustomAPI.AutoSize = true;
            this.RbtnCustomAPI.Location = new System.Drawing.Point(191, 4);
            this.RbtnCustomAPI.Name = "RbtnCustomAPI";
            this.RbtnCustomAPI.Size = new System.Drawing.Size(65, 15);
            this.RbtnCustomAPI.TabIndex = 19;
            this.RbtnCustomAPI.Text = "Custom";
            this.RbtnCustomAPI.UseSelectable = true;
            // 
            // RbtnGLPKAPI
            // 
            this.RbtnGLPKAPI.AutoSize = true;
            this.RbtnGLPKAPI.Checked = true;
            this.RbtnGLPKAPI.Location = new System.Drawing.Point(134, 4);
            this.RbtnGLPKAPI.Name = "RbtnGLPKAPI";
            this.RbtnGLPKAPI.Size = new System.Drawing.Size(51, 15);
            this.RbtnGLPKAPI.TabIndex = 18;
            this.RbtnGLPKAPI.TabStop = true;
            this.RbtnGLPKAPI.Text = "GLPK";
            this.RbtnGLPKAPI.UseSelectable = true;
            // 
            // LblAPI
            // 
            this.LblAPI.AutoSize = true;
            this.LblAPI.Location = new System.Drawing.Point(3, 0);
            this.LblAPI.Name = "LblAPI";
            this.LblAPI.Size = new System.Drawing.Size(125, 19);
            this.LblAPI.TabIndex = 17;
            this.LblAPI.Text = "API Para Resolução:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.RbtnGLPKAPI);
            this.metroPanel1.Controls.Add(this.RbtnCustomAPI);
            this.metroPanel1.Controls.Add(this.LblAPI);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 77);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(257, 21);
            this.metroPanel1.TabIndex = 20;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.RbtnMax);
            this.metroPanel2.Controls.Add(this.RbtnMin);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 111);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(354, 28);
            this.metroPanel2.TabIndex = 21;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 460);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.BtnAddRestriction);
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
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
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
        private MetroFramework.Controls.MetroRadioButton RbtnCustomAPI;
        private MetroFramework.Controls.MetroRadioButton RbtnGLPKAPI;
        private MetroFramework.Controls.MetroLabel LblAPI;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}