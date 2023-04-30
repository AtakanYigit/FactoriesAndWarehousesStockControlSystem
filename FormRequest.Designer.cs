namespace Midterm.Project.Visual.Programming
{
    partial class FormRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLogoRequest = new System.Windows.Forms.Label();
            this.labelWarehouse = new System.Windows.Forms.Label();
            this.destinationWarehouse = new System.Windows.Forms.ComboBox();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.labelCompany = new System.Windows.Forms.Label();
            this.requestedManufacturer = new System.Windows.Forms.ComboBox();
            this.requestedProduct = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.requestedDate = new System.Windows.Forms.MonthCalendar();
            this.requestedNumber = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentStockData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockSearchWarehouse = new System.Windows.Forms.ComboBox();
            this.stockSearchWarehouseLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.requestedNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentStockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogoRequest
            // 
            this.lblLogoRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogoRequest.AutoSize = true;
            this.lblLogoRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.lblLogoRequest.ForeColor = System.Drawing.Color.White;
            this.lblLogoRequest.Location = new System.Drawing.Point(480, 521);
            this.lblLogoRequest.Name = "lblLogoRequest";
            this.lblLogoRequest.Size = new System.Drawing.Size(316, 44);
            this.lblLogoRequest.TabIndex = 3;
            this.lblLogoRequest.Text = "Request An Item";
            this.lblLogoRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWarehouse
            // 
            this.labelWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWarehouse.ForeColor = System.Drawing.Color.White;
            this.labelWarehouse.Location = new System.Drawing.Point(391, 587);
            this.labelWarehouse.Name = "labelWarehouse";
            this.labelWarehouse.Size = new System.Drawing.Size(242, 25);
            this.labelWarehouse.TabIndex = 5;
            this.labelWarehouse.Text = "Destination Warehouse:";
            // 
            // destinationWarehouse
            // 
            this.destinationWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destinationWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.destinationWarehouse.FormattingEnabled = true;
            this.destinationWarehouse.Location = new System.Drawing.Point(633, 583);
            this.destinationWarehouse.Name = "destinationWarehouse";
            this.destinationWarehouse.Size = new System.Drawing.Size(138, 33);
            this.destinationWarehouse.TabIndex = 2;
            // 
            // buttonRequest
            // 
            this.buttonRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRequest.BackColor = System.Drawing.Color.White;
            this.buttonRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRequest.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.buttonRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            this.buttonRequest.Location = new System.Drawing.Point(811, 772);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(248, 79);
            this.buttonRequest.TabIndex = 6;
            this.buttonRequest.Text = "Make a Request";
            this.buttonRequest.UseVisualStyleBackColor = false;
            this.buttonRequest.Click += new System.EventHandler(this.RequestProduct);
            // 
            // labelCompany
            // 
            this.labelCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCompany.ForeColor = System.Drawing.Color.White;
            this.labelCompany.Location = new System.Drawing.Point(156, 587);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(67, 25);
            this.labelCompany.TabIndex = 12;
            this.labelCompany.Text = "From:";
            // 
            // requestedManufacturer
            // 
            this.requestedManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.requestedManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.requestedManufacturer.FormattingEnabled = true;
            this.requestedManufacturer.Location = new System.Drawing.Point(224, 583);
            this.requestedManufacturer.Name = "requestedManufacturer";
            this.requestedManufacturer.Size = new System.Drawing.Size(138, 33);
            this.requestedManufacturer.TabIndex = 1;
            // 
            // requestedProduct
            // 
            this.requestedProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.requestedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.requestedProduct.FormattingEnabled = true;
            this.requestedProduct.Location = new System.Drawing.Point(873, 583);
            this.requestedProduct.Name = "requestedProduct";
            this.requestedProduct.Size = new System.Drawing.Size(186, 33);
            this.requestedProduct.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(782, 646);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(208, 25);
            this.labelAmount.TabIndex = 18;
            this.labelAmount.Text = "Number of Products:";
            // 
            // labelProduct
            // 
            this.labelProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProduct.ForeColor = System.Drawing.Color.White;
            this.labelProduct.Location = new System.Drawing.Point(781, 587);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(92, 25);
            this.labelProduct.TabIndex = 19;
            this.labelProduct.Text = "Product:";
            // 
            // requestedDate
            // 
            this.requestedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.requestedDate.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.requestedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            this.requestedDate.Location = new System.Drawing.Point(161, 689);
            this.requestedDate.MinDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.requestedDate.Name = "requestedDate";
            this.requestedDate.TabIndex = 4;
            this.requestedDate.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            this.requestedDate.TitleForeColor = System.Drawing.Color.White;
            this.requestedDate.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            // 
            // requestedNumber
            // 
            this.requestedNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.requestedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.requestedNumber.Location = new System.Drawing.Point(1001, 642);
            this.requestedNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.requestedNumber.Name = "requestedNumber";
            this.requestedNumber.Size = new System.Drawing.Size(58, 32);
            this.requestedNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 44);
            this.label1.TabIndex = 42;
            this.label1.Text = "Current Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(156, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "When Do You Want To Recieve The Item?";
            // 
            // currentStockData
            // 
            this.currentStockData.AllowUserToAddRows = false;
            this.currentStockData.AllowUserToDeleteRows = false;
            this.currentStockData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentStockData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.currentStockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentStockData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRODUCT_NAME,
            this.QUANTITY,
            this.CATEGORY});
            this.currentStockData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(252)))));
            this.currentStockData.Location = new System.Drawing.Point(88, 111);
            this.currentStockData.Name = "currentStockData";
            this.currentStockData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentStockData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(105)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.currentStockData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.currentStockData.Size = new System.Drawing.Size(1119, 391);
            this.currentStockData.TabIndex = 45;
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
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.DividerWidth = 4;
            this.PRODUCT_NAME.HeaderText = "PRODUCT_NAME";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.ReadOnly = true;
            this.PRODUCT_NAME.Width = 335;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            this.QUANTITY.Width = 335;
            // 
            // CATEGORY
            // 
            this.CATEGORY.DividerWidth = 4;
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.ReadOnly = true;
            this.CATEGORY.Width = 335;
            // 
            // stockSearchWarehouse
            // 
            this.stockSearchWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockSearchWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockSearchWarehouse.FormattingEnabled = true;
            this.stockSearchWarehouse.Location = new System.Drawing.Point(217, 56);
            this.stockSearchWarehouse.Name = "stockSearchWarehouse";
            this.stockSearchWarehouse.Size = new System.Drawing.Size(186, 33);
            this.stockSearchWarehouse.TabIndex = 46;
            this.stockSearchWarehouse.SelectedIndexChanged += new System.EventHandler(this.stockSearchWarehouse_SelectedIndexChanged);
            // 
            // stockSearchWarehouseLabel
            // 
            this.stockSearchWarehouseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockSearchWarehouseLabel.AutoSize = true;
            this.stockSearchWarehouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockSearchWarehouseLabel.ForeColor = System.Drawing.Color.White;
            this.stockSearchWarehouseLabel.Location = new System.Drawing.Point(83, 59);
            this.stockSearchWarehouseLabel.Name = "stockSearchWarehouseLabel";
            this.stockSearchWarehouseLabel.Size = new System.Drawing.Size(128, 25);
            this.stockSearchWarehouseLabel.TabIndex = 47;
            this.stockSearchWarehouseLabel.Text = "Warehouse:";
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1281, 903);
            this.Controls.Add(this.stockSearchWarehouseLabel);
            this.Controls.Add(this.stockSearchWarehouse);
            this.Controls.Add(this.currentStockData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestedNumber);
            this.Controls.Add(this.requestedDate);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.requestedProduct);
            this.Controls.Add(this.requestedManufacturer);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.destinationWarehouse);
            this.Controls.Add(this.labelWarehouse);
            this.Controls.Add(this.lblLogoRequest);
            this.Name = "FormRequest";
            this.Text = "Current Stock And Request";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestedNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentStockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogoRequest;
        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.ComboBox destinationWarehouse;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.ComboBox requestedManufacturer;
        private System.Windows.Forms.ComboBox requestedProduct;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.MonthCalendar requestedDate;
        private System.Windows.Forms.NumericUpDown requestedNumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView currentStockData;
        private System.Windows.Forms.ComboBox stockSearchWarehouse;
        private System.Windows.Forms.Label stockSearchWarehouseLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}