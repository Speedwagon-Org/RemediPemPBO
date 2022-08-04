namespace RemediPemPBO
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
            this.orderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recordList = new System.Windows.Forms.DataGridView();
            this.totalRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderDetailList = new System.Windows.Forms.DataGridView();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // orderId
            // 
            this.orderId.Location = new System.Drawing.Point(71, 16);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(110, 20);
            this.orderId.TabIndex = 0;
            this.orderId.TextChanged += new System.EventHandler(this.orderId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order ID :";
            // 
            // recordList
            // 
            this.recordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordList.Location = new System.Drawing.Point(15, 38);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(166, 356);
            this.recordList.TabIndex = 2;
            this.recordList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordList_CellClick);
            // 
            // totalRecord
            // 
            this.totalRecord.AutoSize = true;
            this.totalRecord.Location = new System.Drawing.Point(98, 397);
            this.totalRecord.Name = "totalRecord";
            this.totalRecord.Size = new System.Drawing.Size(13, 13);
            this.totalRecord.TabIndex = 3;
            this.totalRecord.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Record";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact Name :";
            // 
            // contactName
            // 
            this.contactName.Location = new System.Drawing.Point(274, 38);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(342, 20);
            this.contactName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Detail List :";
            // 
            // orderDetailList
            // 
            this.orderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailList.Location = new System.Drawing.Point(190, 77);
            this.orderDetailList.Name = "orderDetailList";
            this.orderDetailList.Size = new System.Drawing.Size(425, 291);
            this.orderDetailList.TabIndex = 8;
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(515, 374);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(100, 20);
            this.totalPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Price :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.orderDetailList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalRecord);
            this.Controls.Add(this.recordList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderId);
            this.Name = "Form1";
            this.Text = "Soal 2";
            ((System.ComponentModel.ISupportInitialize)(this.recordList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView recordList;
        private System.Windows.Forms.Label totalRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contactName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView orderDetailList;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label5;
    }
}

