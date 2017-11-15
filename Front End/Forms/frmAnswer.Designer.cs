namespace SimplexGUI.Forms
{
    partial class frmAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnswer));
            this.TbxAnswer = new MetroFramework.Controls.MetroTextBox();
            this.BtnClose = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TbxAnswer
            // 
            // 
            // 
            // 
            this.TbxAnswer.CustomButton.Image = null;
            this.TbxAnswer.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TbxAnswer.CustomButton.Name = "";
            this.TbxAnswer.CustomButton.Size = new System.Drawing.Size(363, 363);
            this.TbxAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbxAnswer.CustomButton.TabIndex = 1;
            this.TbxAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbxAnswer.CustomButton.UseSelectable = true;
            this.TbxAnswer.CustomButton.Visible = false;
            this.TbxAnswer.Lines = new string[0];
            this.TbxAnswer.Location = new System.Drawing.Point(23, 63);
            this.TbxAnswer.MaxLength = 32767;
            this.TbxAnswer.Multiline = true;
            this.TbxAnswer.Name = "TbxAnswer";
            this.TbxAnswer.PasswordChar = '\0';
            this.TbxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbxAnswer.SelectedText = "";
            this.TbxAnswer.SelectionLength = 0;
            this.TbxAnswer.SelectionStart = 0;
            this.TbxAnswer.ShortcutsEnabled = true;
            this.TbxAnswer.Size = new System.Drawing.Size(554, 365);
            this.TbxAnswer.TabIndex = 0;
            this.TbxAnswer.UseSelectable = true;
            this.TbxAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbxAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(23, 434);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Fechar";
            this.BtnClose.UseSelectable = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TbxAnswer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnswer";
            this.Text = "Resultado";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TbxAnswer;
        private MetroFramework.Controls.MetroButton BtnClose;
    }
}