namespace Midterm.Project.Visual.Programming
{
    partial class FormSupply
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelProduct = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.ComboBox();
            this.supplySubmitButton = new System.Windows.Forms.Button();
            this.destinationWarehouse = new System.Windows.Forms.ComboBox();
            this.labelWarehouse = new System.Windows.Forms.Label();
            this.labelNewStock = new System.Windows.Forms.Label();
            this.numNewStock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arrivalDate = new System.Windows.Forms.MonthCalendar();
            this.requestsTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_FACTORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WAREHOUSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQUESTED_FOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIEVE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numNewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProduct
            // 
            this.labelProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProduct.ForeColor = System.Drawing.Color.White;
            this.labelProduct.Location = new System.Drawing.Point(671, 642);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(118, 25);
            this.labelProduct.TabIndex = 35;
            this.labelProduct.Text = "Product ID:";
            // 
            // productID
            // 
            this.productID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productID.FormattingEnabled = true;
            this.productID.Location = new System.Drawing.Point(795, 638);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(138, 33);
            this.productID.TabIndex = 31;
            // 
            // supplySubmitButton
            // 
            this.supplySubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supplySubmitButton.BackColor = System.Drawing.Color.White;
            this.supplySubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplySubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.supplySubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.supplySubmitButton.ForeColor = System.Drawing.Color.Black;
            this.supplySubmitButton.Location = new System.Drawing.Point(676, 847);
            this.supplySubmitButton.Name = "supplySubmitButton";
            this.supplySubmitButton.Size = new System.Drawing.Size(257, 61);
            this.supplySubmitButton.TabIndex = 27;
            this.supplySubmitButton.Text = "Submit";
            this.supplySubmitButton.UseVisualStyleBackColor = false;
            this.supplySubmitButton.Click += new System.EventHandler(this.SupplySubmitButton_Click);
            // 
            // destinationWarehouse
            // 
            this.destinationWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destinationWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.destinationWarehouse.FormattingEnabled = true;
            this.destinationWarehouse.Location = new System.Drawing.Point(472, 638);
            this.destinationWarehouse.Name = "destinationWarehouse";
            this.destinationWarehouse.Size = new System.Drawing.Size(138, 33);
            this.destinationWarehouse.TabIndex = 26;
            // 
            // labelWarehouse
            // 
            this.labelWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWarehouse.ForeColor = System.Drawing.Color.White;
            this.labelWarehouse.Location = new System.Drawing.Point(338, 642);
            this.labelWarehouse.Name = "labelWarehouse";
            this.labelWarehouse.Size = new System.Drawing.Size(128, 25);
            this.labelWarehouse.TabIndex = 23;
            this.labelWarehouse.Text = "Warehouse:";
            // 
            // labelNewStock
            // 
            this.labelNewStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNewStock.AutoSize = true;
            this.labelNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNewStock.ForeColor = System.Drawing.Color.White;
            this.labelNewStock.Location = new System.Drawing.Point(671, 703);
            this.labelNewStock.Name = "labelNewStock";
            this.labelNewStock.Size = new System.Drawing.Size(155, 25);
            this.labelNewStock.TabIndex = 37;
            this.labelNewStock.Text = "Product Count:";
            // 
            // numNewStock
            // 
            this.numNewStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numNewStock.Location = new System.Drawing.Point(852, 700);
            this.numNewStock.Name = "numNewStock";
            this.numNewStock.Size = new System.Drawing.Size(81, 31);
            this.numNewStock.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(568, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 44);
            this.label1.TabIndex = 43;
            this.label1.Text = "Requests";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(596, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 44);
            this.label2.TabIndex = 44;
            this.label2.Text = "Supply";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(338, 703);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "When Should the Items Arrive?";
            // 
            // arrivalDate
            // 
            this.arrivalDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrivalDate.Enabled = false;
            this.arrivalDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            this.arrivalDate.Location = new System.Drawing.Point(343, 746);
            this.arrivalDate.MinDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.TabIndex = 45;
            this.arrivalDate.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            this.arrivalDate.TitleForeColor = System.Drawing.Color.White;
            this.arrivalDate.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            // 
            // requestsTable
            // 
            this.requestsTable.AllowUserToAddRows = false;
            this.requestsTable.AllowUserToDeleteRows = false;
            this.requestsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.requestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CUSTOMER_FACTORY,
            this.WAREHOUSE,
            this.PRODUCT,
            this.QUANTITY,
            this.ORDER_DATE,
            this.REQUESTED_FOR,
            this.RECIEVE_DATE,
            this.STATUS});
            this.requestsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(252)))));
            this.requestsTable.Location = new System.Drawing.Point(92, 79);
            this.requestsTable.Name = "requestsTable";
            this.requestsTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.requestsTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.requestsTable.Size = new System.Drawing.Size(1119, 452);
            this.requestsTable.TabIndex = 47;
            // 
            // ID
            // 
            this.ID.DividerWidth = 4;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // CUSTOMER_FACTORY
            // 
            this.CUSTOMER_FACTORY.HeaderText = "CUSTOMER_FACTORY";
            this.CUSTOMER_FACTORY.Name = "CUSTOMER_FACTORY";
            this.CUSTOMER_FACTORY.ReadOnly = true;
            // 
            // WAREHOUSE
            // 
            this.WAREHOUSE.HeaderText = "WAREHOUSE";
            this.WAREHOUSE.Name = "WAREHOUSE";
            this.WAREHOUSE.ReadOnly = true;
            // 
            // PRODUCT
            // 
            this.PRODUCT.HeaderText = "PRODUCT";
            this.PRODUCT.Name = "PRODUCT";
            this.PRODUCT.ReadOnly = true;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            // 
            // ORDER_DATE
            // 
            this.ORDER_DATE.HeaderText = "ORDER_DATE";
            this.ORDER_DATE.Name = "ORDER_DATE";
            this.ORDER_DATE.ReadOnly = true;
            // 
            // REQUESTED_FOR
            // 
            this.REQUESTED_FOR.HeaderText = "REQUESTED_FOR";
            this.REQUESTED_FOR.Name = "REQUESTED_FOR";
            this.REQUESTED_FOR.ReadOnly = true;
            // 
            // RECIEVE_DATE
            // 
            this.RECIEVE_DATE.HeaderText = "RECIEVE_DATE";
            this.RECIEVE_DATE.Name = "RECIEVE_DATE";
            this.RECIEVE_DATE.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1295, 957);
            this.Controls.Add(this.requestsTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrivalDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNewStock);
            this.Controls.Add(this.labelNewStock);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.supplySubmitButton);
            this.Controls.Add(this.destinationWarehouse);
            this.Controls.Add(this.labelWarehouse);
            this.Name = "FormSupply";
            this.Text = "Requests And Provide Supply";
            this.Load += new System.EventHandler(this.FormTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox productID;
        private System.Windows.Forms.Button supplySubmitButton;
        private System.Windows.Forms.ComboBox destinationWarehouse;
        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.Label labelNewStock;
        private System.Windows.Forms.NumericUpDown numNewStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar arrivalDate;
        private System.Windows.Forms.DataGridView requestsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_FACTORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAREHOUSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQUESTED_FOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIEVE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
    }
}