
namespace BSOD_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneElipse3 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.emIc = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.BxText = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errCode = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneRoundedComboBox1 = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(387, 230);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Text = "Give Me A BSOD";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.TargetControl = this.siticoneButton1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "EmoteIcon";
            // 
            // emIc
            // 
            this.emIc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emIc.DefaultText = "";
            this.emIc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emIc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emIc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emIc.DisabledState.Parent = this.emIc;
            this.emIc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emIc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.emIc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emIc.FocusedState.Parent = this.emIc;
            this.emIc.ForeColor = System.Drawing.Color.White;
            this.emIc.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emIc.HoveredState.Parent = this.emIc;
            this.emIc.Location = new System.Drawing.Point(13, 88);
            this.emIc.Name = "emIc";
            this.emIc.PasswordChar = '\0';
            this.emIc.PlaceholderText = "";
            this.emIc.SelectedText = "";
            this.emIc.ShadowDecoration.Parent = this.emIc;
            this.emIc.Size = new System.Drawing.Size(113, 36);
            this.emIc.TabIndex = 3;
            // 
            // BxText
            // 
            this.BxText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BxText.DefaultText = "";
            this.BxText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BxText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BxText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BxText.DisabledState.Parent = this.BxText;
            this.BxText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BxText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BxText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BxText.FocusedState.Parent = this.BxText;
            this.BxText.ForeColor = System.Drawing.Color.White;
            this.BxText.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BxText.HoveredState.Parent = this.BxText;
            this.BxText.Location = new System.Drawing.Point(13, 171);
            this.BxText.Name = "BxText";
            this.BxText.PasswordChar = '\0';
            this.BxText.PlaceholderText = "";
            this.BxText.SelectedText = "";
            this.BxText.ShadowDecoration.Parent = this.BxText;
            this.BxText.Size = new System.Drawing.Size(356, 36);
            this.BxText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // errCode
            // 
            this.errCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.errCode.DefaultText = "";
            this.errCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.errCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.errCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.errCode.DisabledState.Parent = this.errCode;
            this.errCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.errCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.errCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.errCode.FocusedState.Parent = this.errCode;
            this.errCode.ForeColor = System.Drawing.Color.White;
            this.errCode.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.errCode.HoveredState.Parent = this.errCode;
            this.errCode.Location = new System.Drawing.Point(13, 243);
            this.errCode.Name = "errCode";
            this.errCode.PasswordChar = '\0';
            this.errCode.PlaceholderText = "";
            this.errCode.SelectedText = "";
            this.errCode.ShadowDecoration.Parent = this.errCode;
            this.errCode.Size = new System.Drawing.Size(356, 36);
            this.errCode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Error Code";
            // 
            // siticoneRoundedComboBox1
            // 
            this.siticoneRoundedComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneRoundedComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneRoundedComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.siticoneRoundedComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneRoundedComboBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedComboBox1.FormattingEnabled = true;
            this.siticoneRoundedComboBox1.HoveredState.Parent = this.siticoneRoundedComboBox1;
            this.siticoneRoundedComboBox1.ItemHeight = 30;
            this.siticoneRoundedComboBox1.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Yellow",
            "Green",
            "Red"});
            this.siticoneRoundedComboBox1.ItemsAppearance.Parent = this.siticoneRoundedComboBox1;
            this.siticoneRoundedComboBox1.Location = new System.Drawing.Point(173, 88);
            this.siticoneRoundedComboBox1.Name = "siticoneRoundedComboBox1";
            this.siticoneRoundedComboBox1.ShadowDecoration.Parent = this.siticoneRoundedComboBox1;
            this.siticoneRoundedComboBox1.Size = new System.Drawing.Size(140, 36);
            this.siticoneRoundedComboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(579, 287);
            this.Controls.Add(this.siticoneRoundedComboBox1);
            this.Controls.Add(this.errCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BxText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emIc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneButton1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSOD Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox errCode;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox BxText;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox emIc;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse3;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox siticoneRoundedComboBox1;
    }
}

