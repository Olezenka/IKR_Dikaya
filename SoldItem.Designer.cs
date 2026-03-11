namespace IKR_Dikaya
{
    partial class SoldItem
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
            this.labelRole = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOutletsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solditemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solditemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRole
            // 
            this.labelRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRole.Location = new System.Drawing.Point(434, 87);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(354, 41);
            this.labelRole.TabIndex = 13;
            this.labelRole.Text = "labelRole";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFIO
            // 
            this.labelFIO.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFIO.Location = new System.Drawing.Point(11, 92);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(349, 95);
            this.labelFIO.TabIndex = 12;
            this.labelFIO.Text = "labelFIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 83);
            this.panel1.TabIndex = 10;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(37, 17);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(172, 47);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Проданный товар";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDGoodDataGridViewTextBoxColumn,
            this.iDWorkerDataGridViewTextBoxColumn,
            this.dateofsaleDataGridViewTextBoxColumn,
            this.iDOutletsDataGridViewTextBoxColumn,
            this.goodsDataGridViewTextBoxColumn,
            this.outletsDataGridViewTextBoxColumn,
            this.workersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.solditemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 286);
            this.dataGridView1.TabIndex = 14;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // iDGoodDataGridViewTextBoxColumn
            // 
            this.iDGoodDataGridViewTextBoxColumn.DataPropertyName = "ID_Good";
            this.iDGoodDataGridViewTextBoxColumn.HeaderText = "ID_Good";
            this.iDGoodDataGridViewTextBoxColumn.Name = "iDGoodDataGridViewTextBoxColumn";
            // 
            // iDWorkerDataGridViewTextBoxColumn
            // 
            this.iDWorkerDataGridViewTextBoxColumn.DataPropertyName = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.HeaderText = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.Name = "iDWorkerDataGridViewTextBoxColumn";
            // 
            // dateofsaleDataGridViewTextBoxColumn
            // 
            this.dateofsaleDataGridViewTextBoxColumn.DataPropertyName = "Date_of_sale";
            this.dateofsaleDataGridViewTextBoxColumn.HeaderText = "Date_of_sale";
            this.dateofsaleDataGridViewTextBoxColumn.Name = "dateofsaleDataGridViewTextBoxColumn";
            // 
            // iDOutletsDataGridViewTextBoxColumn
            // 
            this.iDOutletsDataGridViewTextBoxColumn.DataPropertyName = "ID_Outlets";
            this.iDOutletsDataGridViewTextBoxColumn.HeaderText = "ID_Outlets";
            this.iDOutletsDataGridViewTextBoxColumn.Name = "iDOutletsDataGridViewTextBoxColumn";
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            // 
            // outletsDataGridViewTextBoxColumn
            // 
            this.outletsDataGridViewTextBoxColumn.DataPropertyName = "Outlets";
            this.outletsDataGridViewTextBoxColumn.HeaderText = "Outlets";
            this.outletsDataGridViewTextBoxColumn.Name = "outletsDataGridViewTextBoxColumn";
            // 
            // workersDataGridViewTextBoxColumn
            // 
            this.workersDataGridViewTextBoxColumn.DataPropertyName = "Workers";
            this.workersDataGridViewTextBoxColumn.HeaderText = "Workers";
            this.workersDataGridViewTextBoxColumn.Name = "workersDataGridViewTextBoxColumn";
            // 
            // solditemBindingSource
            // 
            this.solditemBindingSource.DataSource = typeof(IKR_Dikaya.FolderModel.Sold_item);
            // 
            // SoldItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.panel1);
            this.Name = "SoldItem";
            this.Text = "SoldItem";
            this.Load += new System.EventHandler(this.SoldItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solditemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofsaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOutletsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource solditemBindingSource;
    }
}