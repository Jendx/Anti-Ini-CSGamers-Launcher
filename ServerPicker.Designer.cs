
namespace Databáze_II_Projekt
{
    partial class SpravceHracu
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
            this.labelAktualniHraci = new System.Windows.Forms.Label();
            this.dataGridViewBugy = new System.Windows.Forms.DataGridView();
            this.ColumnServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBugy)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAktualniHraci
            // 
            this.labelAktualniHraci.AutoSize = true;
            this.labelAktualniHraci.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.labelAktualniHraci.Location = new System.Drawing.Point(264, 9);
            this.labelAktualniHraci.Name = "labelAktualniHraci";
            this.labelAktualniHraci.Size = new System.Drawing.Size(79, 30);
            this.labelAktualniHraci.TabIndex = 16;
            this.labelAktualniHraci.Text = "Servers";
            // 
            // dataGridViewBugy
            // 
            this.dataGridViewBugy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBugy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnServer,
            this.ColumnEdit});
            this.dataGridViewBugy.Location = new System.Drawing.Point(10, 42);
            this.dataGridViewBugy.Name = "dataGridViewBugy";
            this.dataGridViewBugy.RowTemplate.Height = 25;
            this.dataGridViewBugy.Size = new System.Drawing.Size(684, 291);
            this.dataGridViewBugy.TabIndex = 15;
            this.dataGridViewBugy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBugy_CellContentClick);
            // 
            // ColumnServer
            // 
            this.ColumnServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnServer.HeaderText = "Server";
            this.ColumnServer.Name = "ColumnServer";
            this.ColumnServer.ReadOnly = true;
            this.ColumnServer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnEdit.HeaderText = "Connect";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Text = "Connect";
            this.ColumnEdit.ToolTipText = "Connect to the server";
            this.ColumnEdit.Width = 53;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(745, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 291);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(301, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Přidat Hráče";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(301, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Odebrat Hráče";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 281);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odebrat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.Location = new System.Drawing.Point(81, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Odstranit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Přezdívka";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SpravceHracu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(720, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelAktualniHraci);
            this.Controls.Add(this.dataGridViewBugy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpravceHracu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server picker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBugy)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAktualniHraci;
        private System.Windows.Forms.DataGridView dataGridViewBugy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnServer;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
    }
}