namespace WindowsFormsAppQLBH_LOHANG
{
    partial class FormQLBH_LOHANG
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
            this.lbl_MALH = new System.Windows.Forms.Label();
            this.txt_MALH = new System.Windows.Forms.TextBox();
            this.lbl_HSD = new System.Windows.Forms.Label();
            this.datetime_HSD = new System.Windows.Forms.DateTimePicker();
            this.lbl_GIANHAN = new System.Windows.Forms.Label();
            this.txt_GIANHAN = new System.Windows.Forms.TextBox();
            this.lbl_MANL = new System.Windows.Forms.Label();
            this.txt_MANL = new System.Windows.Forms.TextBox();
            this.lbl_BANG = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.DataGridViewLOHANG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MALH
            // 
            this.lbl_MALH.AutoSize = true;
            this.lbl_MALH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MALH.Location = new System.Drawing.Point(42, 96);
            this.lbl_MALH.Name = "lbl_MALH";
            this.lbl_MALH.Size = new System.Drawing.Size(101, 21);
            this.lbl_MALH.TabIndex = 0;
            this.lbl_MALH.Text = "Mã Lô Hàng";
            // 
            // txt_MALH
            // 
            this.txt_MALH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MALH.Location = new System.Drawing.Point(206, 96);
            this.txt_MALH.Name = "txt_MALH";
            this.txt_MALH.Size = new System.Drawing.Size(100, 26);
            this.txt_MALH.TabIndex = 0;
            // 
            // lbl_HSD
            // 
            this.lbl_HSD.AutoSize = true;
            this.lbl_HSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HSD.Location = new System.Drawing.Point(42, 149);
            this.lbl_HSD.Name = "lbl_HSD";
            this.lbl_HSD.Size = new System.Drawing.Size(111, 21);
            this.lbl_HSD.TabIndex = 0;
            this.lbl_HSD.Text = "Hạn Sử Dụng";
            // 
            // datetime_HSD
            // 
            this.datetime_HSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_HSD.Location = new System.Drawing.Point(206, 149);
            this.datetime_HSD.Name = "datetime_HSD";
            this.datetime_HSD.Size = new System.Drawing.Size(200, 26);
            this.datetime_HSD.TabIndex = 1;
            // 
            // lbl_GIANHAN
            // 
            this.lbl_GIANHAN.AutoSize = true;
            this.lbl_GIANHAN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GIANHAN.Location = new System.Drawing.Point(42, 200);
            this.lbl_GIANHAN.Name = "lbl_GIANHAN";
            this.lbl_GIANHAN.Size = new System.Drawing.Size(81, 21);
            this.lbl_GIANHAN.TabIndex = 0;
            this.lbl_GIANHAN.Text = "Giá Nhận";
            // 
            // txt_GIANHAN
            // 
            this.txt_GIANHAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GIANHAN.Location = new System.Drawing.Point(206, 198);
            this.txt_GIANHAN.Name = "txt_GIANHAN";
            this.txt_GIANHAN.Size = new System.Drawing.Size(100, 26);
            this.txt_GIANHAN.TabIndex = 2;
            // 
            // lbl_MANL
            // 
            this.lbl_MANL.AutoSize = true;
            this.lbl_MANL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MANL.Location = new System.Drawing.Point(42, 257);
            this.lbl_MANL.Name = "lbl_MANL";
            this.lbl_MANL.Size = new System.Drawing.Size(135, 21);
            this.lbl_MANL.TabIndex = 6;
            this.lbl_MANL.Text = "Mã Nguyên Liệu";
            // 
            // txt_MANL
            // 
            this.txt_MANL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MANL.Location = new System.Drawing.Point(206, 257);
            this.txt_MANL.Name = "txt_MANL";
            this.txt_MANL.Size = new System.Drawing.Size(100, 26);
            this.txt_MANL.TabIndex = 7;
            // 
            // lbl_BANG
            // 
            this.lbl_BANG.AutoSize = true;
            this.lbl_BANG.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BANG.Location = new System.Drawing.Point(283, 23);
            this.lbl_BANG.Name = "lbl_BANG";
            this.lbl_BANG.Size = new System.Drawing.Size(232, 32);
            this.lbl_BANG.TabIndex = 8;
            this.lbl_BANG.Text = "QUẢN LÝ LÔ HÀNG";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(46, 348);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 34);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(162, 348);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 34);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(275, 348);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 34);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // DataGridViewLOHANG
            // 
            this.DataGridViewLOHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLOHANG.Location = new System.Drawing.Point(427, 70);
            this.DataGridViewLOHANG.Name = "DataGridViewLOHANG";
            this.DataGridViewLOHANG.Size = new System.Drawing.Size(352, 346);
            this.DataGridViewLOHANG.TabIndex = 0;
            this.DataGridViewLOHANG.TabStop = false;
            // 
            // FormQLBH_LOHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewLOHANG);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_BANG);
            this.Controls.Add(this.txt_MANL);
            this.Controls.Add(this.lbl_MANL);
            this.Controls.Add(this.txt_GIANHAN);
            this.Controls.Add(this.lbl_GIANHAN);
            this.Controls.Add(this.datetime_HSD);
            this.Controls.Add(this.lbl_HSD);
            this.Controls.Add(this.txt_MALH);
            this.Controls.Add(this.lbl_MALH);
            this.Name = "FormQLBH_LOHANG";
            this.Text = "QLBH_LOHANG";
            this.Load += new System.EventHandler(this.FormQLBH_LOHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MALH;
        private System.Windows.Forms.TextBox txt_MALH;
        private System.Windows.Forms.Label lbl_HSD;
        private System.Windows.Forms.DateTimePicker datetime_HSD;
        private System.Windows.Forms.Label lbl_GIANHAN;
        private System.Windows.Forms.TextBox txt_GIANHAN;
        private System.Windows.Forms.Label lbl_MANL;
        private System.Windows.Forms.TextBox txt_MANL;
        private System.Windows.Forms.Label lbl_BANG;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView DataGridViewLOHANG;
    }
}

