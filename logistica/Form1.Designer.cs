﻿namespace logistica
{
    partial class logistica_form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
             #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consumatori_num = new System.Windows.Forms.NumericUpDown();
            this.produttori_num = new System.Windows.Forms.NumericUpDown();
            this.produttori_label = new System.Windows.Forms.Label();
            this.consumatori_label = new System.Windows.Forms.Label();
            this.genera_btn = new System.Windows.Forms.Button();
            this.panel_table = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.productor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_btn = new System.Windows.Forms.Button();
            this.panel_text = new System.Windows.Forms.Panel();
            this.table_copy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.genera_numeri_btn = new System.Windows.Forms.Button();
            this.rigenera_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consumatori_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori_num)).BeginInit();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_copy)).BeginInit();
            this.SuspendLayout();
            // 
            // consumatori_num
            // 
            this.consumatori_num.AutoSize = true;
            this.consumatori_num.Location = new System.Drawing.Point(144, 57);
            this.consumatori_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consumatori_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.consumatori_num.Name = "consumatori_num";
            this.consumatori_num.Size = new System.Drawing.Size(120, 22);
            this.consumatori_num.TabIndex = 0;
            this.consumatori_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // produttori_num
            // 
            this.produttori_num.AutoSize = true;
            this.produttori_num.Location = new System.Drawing.Point(144, 28);
            this.produttori_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.produttori_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.produttori_num.Name = "produttori_num";
            this.produttori_num.Size = new System.Drawing.Size(120, 22);
            this.produttori_num.TabIndex = 1;
            this.produttori_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // produttori_label
            // 
            this.produttori_label.AutoSize = true;
            this.produttori_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produttori_label.Location = new System.Drawing.Point(21, 28);
            this.produttori_label.Name = "produttori_label";
            this.produttori_label.Size = new System.Drawing.Size(90, 20);
            this.produttori_label.TabIndex = 2;
            this.produttori_label.Text = "produttori";
            // 
            // consumatori_label
            // 
            this.consumatori_label.AutoSize = true;
            this.consumatori_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumatori_label.Location = new System.Drawing.Point(21, 55);
            this.consumatori_label.Name = "consumatori_label";
            this.consumatori_label.Size = new System.Drawing.Size(112, 20);
            this.consumatori_label.TabIndex = 3;
            this.consumatori_label.Text = "consumatori";
            // 
            // genera_btn
            // 
            this.genera_btn.AutoSize = true;
            this.genera_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.genera_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genera_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genera_btn.Location = new System.Drawing.Point(321, 30);
            this.genera_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genera_btn.Name = "genera_btn";
            this.genera_btn.Size = new System.Drawing.Size(136, 48);
            this.genera_btn.TabIndex = 4;
            this.genera_btn.Text = "Genera";
            this.genera_btn.UseVisualStyleBackColor = false;
            this.genera_btn.Click += new System.EventHandler(this.genera_btn_Click);
            // 
            // panel_table
            // 
            this.panel_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_table.Controls.Add(this.table);
            this.panel_table.Location = new System.Drawing.Point(16, 127);
            this.panel_table.Margin = new System.Windows.Forms.Padding(4);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(1100, 703);
            this.panel_table.TabIndex = 6;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productor});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Margin = new System.Windows.Forms.Padding(4);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 70;
            this.table.Size = new System.Drawing.Size(1100, 703);
            this.table.TabIndex = 6;
            this.table.Visible = false;
            // 
            // productor
            // 
            this.productor.HeaderText = "Productors";
            this.productor.MinimumWidth = 6;
            this.productor.Name = "productor";
            this.productor.ReadOnly = true;
            this.productor.Width = 125;
            // 
            // start_btn
            // 
            this.start_btn.AutoSize = true;
            this.start_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Enabled = false;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(813, 30);
            this.start_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(136, 48);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // panel_text
            // 
            this.panel_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_text.Controls.Add(this.table_copy);
            this.panel_text.Controls.Add(this.text);
            this.panel_text.Location = new System.Drawing.Point(1177, 127);
            this.panel_text.Margin = new System.Windows.Forms.Padding(4);
            this.panel_text.Name = "panel_text";
            this.panel_text.Size = new System.Drawing.Size(719, 703);
            this.panel_text.TabIndex = 9;
            this.panel_text.Visible = false;
            // 
            // table_copy
            // 
            this.table_copy.AllowUserToAddRows = false;
            this.table_copy.AllowUserToDeleteRows = false;
            this.table_copy.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_copy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_copy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_copy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.table_copy.Location = new System.Drawing.Point(27, 58);
            this.table_copy.Margin = new System.Windows.Forms.Padding(4);
            this.table_copy.Name = "table_copy";
            this.table_copy.RowHeadersWidth = 70;
            this.table_copy.Size = new System.Drawing.Size(620, 273);
            this.table_copy.TabIndex = 12;
            this.table_copy.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Productors";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // text
            // 
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Margin = new System.Windows.Forms.Padding(4);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(719, 703);
            this.text.TabIndex = 9;
            this.text.Text = "NORD-OVEST SYSTEM:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // genera_numeri_btn
            // 
            this.genera_numeri_btn.AutoSize = true;
            this.genera_numeri_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.genera_numeri_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genera_numeri_btn.Enabled = false;
            this.genera_numeri_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genera_numeri_btn.Location = new System.Drawing.Point(568, 30);
            this.genera_numeri_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genera_numeri_btn.Name = "genera_numeri_btn";
            this.genera_numeri_btn.Size = new System.Drawing.Size(136, 48);
            this.genera_numeri_btn.TabIndex = 11;
            this.genera_numeri_btn.Text = "Genera numeri";
            this.genera_numeri_btn.UseVisualStyleBackColor = false;
            this.genera_numeri_btn.Click += new System.EventHandler(this.genera_numeri_btn_Click);
            // 
            // rigenera_btn
            // 
            this.rigenera_btn.AutoSize = true;
            this.rigenera_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rigenera_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rigenera_btn.Enabled = false;
            this.rigenera_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rigenera_btn.Location = new System.Drawing.Point(1069, 30);
            this.rigenera_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rigenera_btn.Name = "rigenera_btn";
            this.rigenera_btn.Size = new System.Drawing.Size(136, 48);
            this.rigenera_btn.TabIndex = 12;
            this.rigenera_btn.Text = "Rigenera";
            this.rigenera_btn.UseVisualStyleBackColor = false;
            this.rigenera_btn.Click += new System.EventHandler(this.rigenera_btn_Click);
            // 
            // logistica_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.rigenera_btn);
            this.Controls.Add(this.genera_numeri_btn);
            this.Controls.Add(this.panel_text);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.genera_btn);
            this.Controls.Add(this.consumatori_label);
            this.Controls.Add(this.produttori_label);
            this.Controls.Add(this.produttori_num);
            this.Controls.Add(this.consumatori_num);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1970, 1057);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "logistica_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logistica";
            ((System.ComponentModel.ISupportInitialize)(this.consumatori_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori_num)).EndInit();
            this.panel_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel_text.ResumeLayout(false);
            this.panel_text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_copy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown consumatori_num;
        private System.Windows.Forms.NumericUpDown produttori_num;
        private System.Windows.Forms.Label produttori_label;
        private System.Windows.Forms.Label consumatori_label;
        private System.Windows.Forms.Button genera_btn;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Panel panel_text;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productor;
        private System.Windows.Forms.Button genera_numeri_btn;
        private System.Windows.Forms.DataGridView table_copy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button rigenera_btn;
    }
}

