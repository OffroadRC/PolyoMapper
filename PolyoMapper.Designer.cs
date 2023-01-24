namespace PolyoMapper
{
    partial class PolyoMapper
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addColumns = new System.Windows.Forms.Button();
            this.btn_addRows = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numBx_addColumns = new System.Windows.Forms.NumericUpDown();
            this.numBx_addRows = new System.Windows.Forms.NumericUpDown();
            this.btn_removeColumns = new System.Windows.Forms.Button();
            this.numBx_removeColumns = new System.Windows.Forms.NumericUpDown();
            this.btn_removeRows = new System.Windows.Forms.Button();
            this.numBx_removeRows = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bx_debug = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBx_addColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBx_addRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBx_removeColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBx_removeRows)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C});
            this.dataGridView1.Location = new System.Drawing.Point(64, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            //Set the column width of the row headers so you can see numbers greater than 100
            this.dataGridView1.RowHeadersWidth = 65;
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
            // btn_addColumns
            // 
            this.btn_addColumns.Location = new System.Drawing.Point(865, 563);
            this.btn_addColumns.Name = "btn_addColumns";
            this.btn_addColumns.Size = new System.Drawing.Size(55, 37);
            this.btn_addColumns.TabIndex = 1;
            this.btn_addColumns.Text = "Add Columns";
            this.btn_addColumns.UseVisualStyleBackColor = true;
            this.btn_addColumns.Click += new System.EventHandler(this.btn_addColumns_Click);
            // 
            // btn_addRows
            // 
            this.btn_addRows.Location = new System.Drawing.Point(743, 632);
            this.btn_addRows.Name = "btn_addRows";
            this.btn_addRows.Size = new System.Drawing.Size(55, 37);
            this.btn_addRows.TabIndex = 2;
            this.btn_addRows.Text = "Add Rows";
            this.btn_addRows.UseVisualStyleBackColor = true;
            this.btn_addRows.Click += new System.EventHandler(this.btn_addRows_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(804, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(234, 174);
            this.dataGridView2.TabIndex = 3;
            // 
            // numBx_addColumns
            // 
            this.numBx_addColumns.BackColor = System.Drawing.SystemColors.Window;
            this.numBx_addColumns.Location = new System.Drawing.Point(865, 606);
            this.numBx_addColumns.Name = "numBx_addColumns";
            this.numBx_addColumns.Size = new System.Drawing.Size(55, 20);
            this.numBx_addColumns.TabIndex = 6;
            this.numBx_addColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBx_addRows
            // 
            this.numBx_addRows.Location = new System.Drawing.Point(743, 675);
            this.numBx_addRows.Name = "numBx_addRows";
            this.numBx_addRows.Size = new System.Drawing.Size(55, 20);
            this.numBx_addRows.TabIndex = 7;
            this.numBx_addRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_removeColumns
            // 
            this.btn_removeColumns.Location = new System.Drawing.Point(804, 563);
            this.btn_removeColumns.Name = "btn_removeColumns";
            this.btn_removeColumns.Size = new System.Drawing.Size(55, 37);
            this.btn_removeColumns.TabIndex = 8;
            this.btn_removeColumns.Text = "Remove Columns";
            this.btn_removeColumns.UseVisualStyleBackColor = true;
            // 
            // numBx_removeColumns
            // 
            this.numBx_removeColumns.BackColor = System.Drawing.SystemColors.Window;
            this.numBx_removeColumns.Location = new System.Drawing.Point(804, 606);
            this.numBx_removeColumns.Name = "numBx_removeColumns";
            this.numBx_removeColumns.Size = new System.Drawing.Size(55, 20);
            this.numBx_removeColumns.TabIndex = 9;
            this.numBx_removeColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_removeRows
            // 
            this.btn_removeRows.Location = new System.Drawing.Point(682, 632);
            this.btn_removeRows.Name = "btn_removeRows";
            this.btn_removeRows.Size = new System.Drawing.Size(55, 37);
            this.btn_removeRows.TabIndex = 10;
            this.btn_removeRows.Text = "Remove Rows";
            this.btn_removeRows.UseVisualStyleBackColor = true;
            // 
            // numBx_removeRows
            // 
            this.numBx_removeRows.Location = new System.Drawing.Point(682, 675);
            this.numBx_removeRows.Name = "numBx_removeRows";
            this.numBx_removeRows.Size = new System.Drawing.Size(55, 20);
            this.numBx_removeRows.TabIndex = 11;
            this.numBx_removeRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bx_debug
            // 
            this.bx_debug.Location = new System.Drawing.Point(64, 642);
            this.bx_debug.Name = "bx_debug";
            this.bx_debug.Size = new System.Drawing.Size(617, 96);
            this.bx_debug.TabIndex = 9;
            this.bx_debug.Text = "";
            // 
            // PolyoMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.numBx_removeRows);
            this.Controls.Add(this.bx_debug);
            this.Controls.Add(this.btn_removeRows);
            this.Controls.Add(this.numBx_removeColumns);
            this.Controls.Add(this.btn_removeColumns);
            this.Controls.Add(this.numBx_addRows);
            this.Controls.Add(this.numBx_addColumns);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_addRows);
            this.Controls.Add(this.btn_addColumns);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PolyoMapper";
            this.Text = "PolyoMapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBx_addColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBx_addRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBx_removeColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBx_removeRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.Button btn_addColumns;
        private System.Windows.Forms.Button btn_addRows;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown numBx_addColumns;
        private System.Windows.Forms.NumericUpDown numBx_addRows;
        private System.Windows.Forms.Button btn_removeColumns;
        private System.Windows.Forms.NumericUpDown numBx_removeColumns;
        private System.Windows.Forms.Button btn_removeRows;
        private System.Windows.Forms.NumericUpDown numBx_removeRows;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox bx_debug;
    }
}

