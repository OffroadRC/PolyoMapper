namespace PolyoMapper
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddColumns = new System.Windows.Forms.Button();
            this.btn_AddRow = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_RemoveColumns = new System.Windows.Forms.Button();
            this.numUpDown_RemoveColumns = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btn_RemoveRow = new System.Windows.Forms.Button();
            this.numUpDown_AddRow = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_RemoveRow = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RemoveColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_AddRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RemoveRow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C});
            this.dataGridView1.Location = new System.Drawing.Point(64, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // btn_AddColumns
            // 
            this.btn_AddColumns.Location = new System.Drawing.Point(865, 564);
            this.btn_AddColumns.Name = "btn_AddColumns";
            this.btn_AddColumns.Size = new System.Drawing.Size(55, 37);
            this.btn_AddColumns.TabIndex = 1;
            this.btn_AddColumns.Text = "Add Columns";
            this.btn_AddColumns.UseVisualStyleBackColor = true;
            this.btn_AddColumns.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AddRow
            // 
            this.btn_AddRow.Location = new System.Drawing.Point(743, 632);
            this.btn_AddRow.Name = "btn_AddRow";
            this.btn_AddRow.Size = new System.Drawing.Size(55, 37);
            this.btn_AddRow.TabIndex = 2;
            this.btn_AddRow.Text = "Add Row";
            this.btn_AddRow.UseVisualStyleBackColor = true;
            this.btn_AddRow.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(804, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(234, 174);
            this.dataGridView2.TabIndex = 3;
            // 
            // btn_RemoveColumns
            // 
            this.btn_RemoveColumns.Location = new System.Drawing.Point(804, 564);
            this.btn_RemoveColumns.Name = "btn_RemoveColumns";
            this.btn_RemoveColumns.Size = new System.Drawing.Size(55, 37);
            this.btn_RemoveColumns.TabIndex = 4;
            this.btn_RemoveColumns.Text = "Remove Columns";
            this.btn_RemoveColumns.UseVisualStyleBackColor = true;
            // 
            // numUpDown_RemoveColumns
            // 
            this.numUpDown_RemoveColumns.Location = new System.Drawing.Point(805, 608);
            this.numUpDown_RemoveColumns.Name = "numUpDown_RemoveColumns";
            this.numUpDown_RemoveColumns.Size = new System.Drawing.Size(54, 20);
            this.numUpDown_RemoveColumns.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(866, 608);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // btn_RemoveRow
            // 
            this.btn_RemoveRow.Location = new System.Drawing.Point(682, 632);
            this.btn_RemoveRow.Name = "btn_RemoveRow";
            this.btn_RemoveRow.Size = new System.Drawing.Size(55, 37);
            this.btn_RemoveRow.TabIndex = 7;
            this.btn_RemoveRow.Text = "Remove Row";
            this.btn_RemoveRow.UseVisualStyleBackColor = true;
            // 
            // numUpDown_AddRow
            // 
            this.numUpDown_AddRow.Location = new System.Drawing.Point(743, 675);
            this.numUpDown_AddRow.Name = "numUpDown_AddRow";
            this.numUpDown_AddRow.Size = new System.Drawing.Size(54, 20);
            this.numUpDown_AddRow.TabIndex = 9;
            // 
            // numUpDown_RemoveRow
            // 
            this.numUpDown_RemoveRow.Location = new System.Drawing.Point(682, 675);
            this.numUpDown_RemoveRow.Name = "numUpDown_RemoveRow";
            this.numUpDown_RemoveRow.Size = new System.Drawing.Size(54, 20);
            this.numUpDown_RemoveRow.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.numUpDown_AddRow);
            this.Controls.Add(this.numUpDown_RemoveRow);
            this.Controls.Add(this.btn_RemoveRow);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numUpDown_RemoveColumns);
            this.Controls.Add(this.btn_RemoveColumns);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_AddRow);
            this.Controls.Add(this.btn_AddColumns);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RemoveColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_AddRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RemoveRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.Button btn_AddColumns;
        private System.Windows.Forms.Button btn_AddRow;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_RemoveColumns;
        private System.Windows.Forms.NumericUpDown numUpDown_RemoveColumns;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btn_RemoveRow;
        private System.Windows.Forms.NumericUpDown numUpDown_AddRow;
        private System.Windows.Forms.NumericUpDown numUpDown_RemoveRow;
    }
}

