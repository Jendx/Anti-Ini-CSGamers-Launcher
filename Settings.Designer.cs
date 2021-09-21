
namespace AntiIniUI
{
    partial class Settings
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxEpicSteam = new System.Windows.Forms.ComboBox();
            this.labelSteamPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEPIC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "This is path to the Steam folder (Usually in C:\\Program Files (x86)";
            this.textBox1.Location = new System.Drawing.Point(24, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Launcher Setup";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(17, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 73);
            this.button2.TabIndex = 4;
            this.button2.Text = "Apply Settings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxEpicSteam
            // 
            this.comboBoxEpicSteam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEpicSteam.FormattingEnabled = true;
            this.comboBoxEpicSteam.Items.AddRange(new object[] {
            "  Select Platform  ",
            "Steam",
            "Epic Games"});
            this.comboBoxEpicSteam.Location = new System.Drawing.Point(169, 76);
            this.comboBoxEpicSteam.MaxDropDownItems = 2;
            this.comboBoxEpicSteam.Name = "comboBoxEpicSteam";
            this.comboBoxEpicSteam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEpicSteam.TabIndex = 5;
            this.comboBoxEpicSteam.SelectedIndex = 0;
            this.comboBoxEpicSteam.SelectedIndexChanged += new System.EventHandler(this.comboBoxEpicSteam_SelectedIndexChanged);
            // 
            // labelSteamPath
            // 
            this.labelSteamPath.AutoSize = true;
            this.labelSteamPath.BackColor = System.Drawing.Color.Black;
            this.labelSteamPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSteamPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSteamPath.Location = new System.Drawing.Point(100, 128);
            this.labelSteamPath.Name = "labelSteamPath";
            this.labelSteamPath.Size = new System.Drawing.Size(92, 20);
            this.labelSteamPath.TabIndex = 6;
            this.labelSteamPath.Text = "Steam path";
            this.labelSteamPath.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Platform/ Launcher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ARKSurvivalEvolved path";
            this.label2.Visible = false;
            // 
            // textBoxEPIC
            // 
            this.textBoxEPIC.AccessibleDescription = "This is a folder where you have installed ARK";
            this.textBoxEPIC.Location = new System.Drawing.Point(24, 152);
            this.textBoxEPIC.Name = "textBoxEPIC";
            this.textBoxEPIC.Size = new System.Drawing.Size(227, 20);
            this.textBoxEPIC.TabIndex = 9;
            this.textBoxEPIC.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(303, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEPIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSteamPath);
            this.Controls.Add(this.comboBoxEpicSteam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSG Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSteamPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEPIC;
        private System.Windows.Forms.ComboBox comboBoxEpicSteam;
    }
}

