namespace Seimo_rinkimai
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.duombazeDataSet = new Seimo_rinkimai.DuombazeDataSet();
            this.kandidataiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kandidataiTableAdapter = new Seimo_rinkimai.DuombazeDataSetTableAdapters.KandidataiTableAdapter();
            this.tableAdapterManager = new Seimo_rinkimai.DuombazeDataSetTableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVardas = new System.Windows.Forms.TextBox();
            this.textBoxPavarde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTeistumas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmzius = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNaujas = new System.Windows.Forms.Button();
            this.textBoxNaujasTeistumas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNaujasAmzius = new System.Windows.Forms.TextBox();
            this.textBoxNaujasVardas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNaujaPavarde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIstrinti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.duombazeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandidataiBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // duombazeDataSet
            // 
            this.duombazeDataSet.DataSetName = "DuombazeDataSet";
            this.duombazeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kandidataiBindingSource
            // 
            this.kandidataiBindingSource.DataMember = "Kandidatai";
            this.kandidataiBindingSource.DataSource = this.duombazeDataSet;
            // 
            // kandidataiTableAdapter
            // 
            this.kandidataiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KandidataiTableAdapter = this.kandidataiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Seimo_rinkimai.DuombazeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 173);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vardas";
            // 
            // textBoxVardas
            // 
            this.textBoxVardas.Location = new System.Drawing.Point(273, 51);
            this.textBoxVardas.Name = "textBoxVardas";
            this.textBoxVardas.ReadOnly = true;
            this.textBoxVardas.Size = new System.Drawing.Size(101, 20);
            this.textBoxVardas.TabIndex = 1;
            // 
            // textBoxPavarde
            // 
            this.textBoxPavarde.Location = new System.Drawing.Point(273, 77);
            this.textBoxPavarde.Name = "textBoxPavarde";
            this.textBoxPavarde.ReadOnly = true;
            this.textBoxPavarde.Size = new System.Drawing.Size(101, 20);
            this.textBoxPavarde.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pavardė";
            // 
            // textBoxTeistumas
            // 
            this.textBoxTeistumas.Location = new System.Drawing.Point(273, 129);
            this.textBoxTeistumas.Name = "textBoxTeistumas";
            this.textBoxTeistumas.ReadOnly = true;
            this.textBoxTeistumas.Size = new System.Drawing.Size(101, 20);
            this.textBoxTeistumas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teistumas";
            // 
            // textBoxAmzius
            // 
            this.textBoxAmzius.Location = new System.Drawing.Point(273, 103);
            this.textBoxAmzius.Name = "textBoxAmzius";
            this.textBoxAmzius.ReadOnly = true;
            this.textBoxAmzius.Size = new System.Drawing.Size(101, 20);
            this.textBoxAmzius.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amžius";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.textBoxTeistumas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAmzius);
            this.groupBox1.Controls.Add(this.textBoxVardas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPavarde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 203);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kandidatai";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNaujas);
            this.groupBox2.Controls.Add(this.textBoxNaujasTeistumas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNaujasAmzius);
            this.groupBox2.Controls.Add(this.textBoxNaujasVardas);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxNaujaPavarde);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 136);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Naujas kandidatas";
            // 
            // buttonNaujas
            // 
            this.buttonNaujas.Location = new System.Drawing.Point(272, 97);
            this.buttonNaujas.Name = "buttonNaujas";
            this.buttonNaujas.Size = new System.Drawing.Size(102, 23);
            this.buttonNaujas.TabIndex = 9;
            this.buttonNaujas.Text = "Įrašyti";
            this.buttonNaujas.UseVisualStyleBackColor = true;
            this.buttonNaujas.Click += new System.EventHandler(this.buttonNaujas_Click);
            // 
            // textBoxNaujasTeistumas
            // 
            this.textBoxNaujasTeistumas.Location = new System.Drawing.Point(273, 62);
            this.textBoxNaujasTeistumas.Name = "textBoxNaujasTeistumas";
            this.textBoxNaujasTeistumas.Size = new System.Drawing.Size(101, 20);
            this.textBoxNaujasTeistumas.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Teistumas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vardas";
            // 
            // textBoxNaujasAmzius
            // 
            this.textBoxNaujasAmzius.Location = new System.Drawing.Point(273, 36);
            this.textBoxNaujasAmzius.Name = "textBoxNaujasAmzius";
            this.textBoxNaujasAmzius.Size = new System.Drawing.Size(101, 20);
            this.textBoxNaujasAmzius.TabIndex = 7;
            // 
            // textBoxNaujasVardas
            // 
            this.textBoxNaujasVardas.Location = new System.Drawing.Point(96, 36);
            this.textBoxNaujasVardas.Name = "textBoxNaujasVardas";
            this.textBoxNaujasVardas.Size = new System.Drawing.Size(101, 20);
            this.textBoxNaujasVardas.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Amžius";
            // 
            // textBoxNaujaPavarde
            // 
            this.textBoxNaujaPavarde.Location = new System.Drawing.Point(96, 62);
            this.textBoxNaujaPavarde.Name = "textBoxNaujaPavarde";
            this.textBoxNaujaPavarde.Size = new System.Drawing.Size(101, 20);
            this.textBoxNaujaPavarde.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pavardė";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonIstrinti);
            this.groupBox3.Location = new System.Drawing.Point(12, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 55);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ištrinti pažymėtą";
            // 
            // buttonIstrinti
            // 
            this.buttonIstrinti.Location = new System.Drawing.Point(150, 19);
            this.buttonIstrinti.Name = "buttonIstrinti";
            this.buttonIstrinti.Size = new System.Drawing.Size(102, 23);
            this.buttonIstrinti.TabIndex = 0;
            this.buttonIstrinti.Text = "Ištrinti";
            this.buttonIstrinti.UseVisualStyleBackColor = true;
            this.buttonIstrinti.Click += new System.EventHandler(this.buttonIstrinti_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 429);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kandidatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duombazeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandidataiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DuombazeDataSet duombazeDataSet;
        private System.Windows.Forms.BindingSource kandidataiBindingSource;
        private DuombazeDataSetTableAdapters.KandidataiTableAdapter kandidataiTableAdapter;
        private DuombazeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVardas;
        private System.Windows.Forms.TextBox textBoxPavarde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTeistumas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAmzius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNaujas;
        private System.Windows.Forms.TextBox textBoxNaujasTeistumas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNaujasAmzius;
        private System.Windows.Forms.TextBox textBoxNaujasVardas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNaujaPavarde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIstrinti;
    }
}

