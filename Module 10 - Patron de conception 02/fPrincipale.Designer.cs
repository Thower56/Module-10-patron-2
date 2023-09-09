namespace Module_10___Patron_de_conception_02
{
    partial class fPrincipale
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
            this.DGVProduits = new System.Windows.Forms.DataGridView();
            this.DGVDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVPrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.bSimuler = new System.Windows.Forms.Button();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduits)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProduits
            // 
            this.DGVProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVDescription,
            this.DGVQuantite,
            this.DGVPrixUnitaire,
            this.DGVTotal});
            this.DGVProduits.Location = new System.Drawing.Point(12, 34);
            this.DGVProduits.Name = "DGVProduits";
            this.DGVProduits.RowHeadersWidth = 51;
            this.DGVProduits.RowTemplate.Height = 24;
            this.DGVProduits.Size = new System.Drawing.Size(588, 181);
            this.DGVProduits.TabIndex = 0;
            this.DGVProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DGVDescription
            // 
            this.DGVDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVDescription.HeaderText = "Description";
            this.DGVDescription.MinimumWidth = 6;
            this.DGVDescription.Name = "DGVDescription";
            // 
            // DGVQuantite
            // 
            this.DGVQuantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVQuantite.HeaderText = "Quantite";
            this.DGVQuantite.MinimumWidth = 6;
            this.DGVQuantite.Name = "DGVQuantite";
            // 
            // DGVPrixUnitaire
            // 
            this.DGVPrixUnitaire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVPrixUnitaire.HeaderText = "PrixUnitaire";
            this.DGVPrixUnitaire.MinimumWidth = 6;
            this.DGVPrixUnitaire.Name = "DGVPrixUnitaire";
            // 
            // DGVTotal
            // 
            this.DGVTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVTotal.HeaderText = "Total";
            this.DGVTotal.MinimumWidth = 6;
            this.DGVTotal.Name = "DGVTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articles :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudQuantite);
            this.groupBox1.Controls.Add(this.bSimuler);
            this.groupBox1.Controls.Add(this.nudPrix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulateur scanner";
            // 
            // nudQuantite
            // 
            this.nudQuantite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantite.Location = new System.Drawing.Point(350, 28);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(107, 24);
            this.nudQuantite.TabIndex = 7;
            this.nudQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bSimuler
            // 
            this.bSimuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSimuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bSimuler.Location = new System.Drawing.Point(502, 59);
            this.bSimuler.Name = "bSimuler";
            this.bSimuler.Size = new System.Drawing.Size(83, 30);
            this.bSimuler.TabIndex = 6;
            this.bSimuler.Text = "Simuler";
            this.bSimuler.UseVisualStyleBackColor = true;
            this.bSimuler.Click += new System.EventHandler(this.bSimuler_Click);
            // 
            // nudPrix
            // 
            this.nudPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrix.Location = new System.Drawing.Point(502, 29);
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(80, 24);
            this.nudPrix.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prix";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantite";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(95, 25);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(168, 24);
            this.tbDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(522, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Payer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(407, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Location = new System.Drawing.Point(454, 221);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(147, 24);
            this.tbTotal.TabIndex = 5;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 403);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVProduits);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MinimumSize = new System.Drawing.Size(630, 450);
            this.Name = "fPrincipale";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.fPrincipale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProduits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSimuler;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVPrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTotal;
        private System.Windows.Forms.NumericUpDown nudQuantite;
    }
}