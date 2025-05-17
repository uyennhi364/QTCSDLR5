namespace WindowsFormsAppQLBH_LOHANG
{
    partial class FormLOHANG
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
            this.DateTime_HSD = new System.Windows.Forms.DateTimePicker();
            this.lbl_GIANHAN = new System.Windows.Forms.Label();
            this.txt_GIANHAN = new System.Windows.Forms.TextBox();
            this.lbl_MANL = new System.Windows.Forms.Label();
            this.txt_MANL = new System.Windows.Forms.TextBox();
            this.lbl_BANGTEN = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.DataGridView_LOHANG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_LOHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MALH
            // 
            this.lbl_MALH.AutoSize = true;
            this.lbl_MALH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MALH.Location = new System.Drawing.Point(96, 61);
            this.lbl_MALH.Name = "lbl_MALH";
            this.lbl_MALH.Size = new System.Drawing.Size(101, 21);
            this.lbl_MALH.TabIndex = 0;
            this.lbl_MALH.Text = "Mã Lô Hàng";
            // 
            // txt_MALH
            // 
            this.txt_MALH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MALH.Location = new System.Drawing.Point(296, 53);
            this.txt_MALH.Name = "txt_MALH";
            this.txt_MALH.Size = new System.Drawing.Size(244, 29);
            this.txt_MALH.TabIndex = 0;
            // 
            // lbl_HSD
            // 
            this.lbl_HSD.AutoSize = true;
            this.lbl_HSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HSD.Location = new System.Drawing.Point(96, 107);
            this.lbl_HSD.Name = "lbl_HSD";
            this.lbl_HSD.Size = new System.Drawing.Size(111, 21);
            this.lbl_HSD.TabIndex = 0;
            this.lbl_HSD.Text = "Hạn Sử Dụng";
            // 
            // DateTime_HSD
            // 
            this.DateTime_HSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_HSD.Location = new System.Drawing.Point(296, 99);
            this.DateTime_HSD.Name = "DateTime_HSD";
            this.DateTime_HSD.Size = new System.Drawing.Size(244, 29);
            this.DateTime_HSD.TabIndex = 1;
            // 
            // lbl_GIANHAN
            // 
            this.lbl_GIANHAN.AutoSize = true;
            this.lbl_GIANHAN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GIANHAN.Location = new System.Drawing.Point(96, 155);
            this.lbl_GIANHAN.Name = "lbl_GIANHAN";
            this.lbl_GIANHAN.Size = new System.Drawing.Size(81, 21);
            this.lbl_GIANHAN.TabIndex = 0;
            this.lbl_GIANHAN.Text = "Giá Nhận";
            // 
            // txt_GIANHAN
            // 
            this.txt_GIANHAN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GIANHAN.Location = new System.Drawing.Point(296, 147);
            this.txt_GIANHAN.Name = "txt_GIANHAN";
            this.txt_GIANHAN.Size = new System.Drawing.Size(244, 29);
            this.txt_GIANHAN.TabIndex = 2;
            // 
            // lbl_MANL
            // 
            this.lbl_MANL.AutoSize = true;
            this.lbl_MANL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MANL.Location = new System.Drawing.Point(96, 204);
            this.lbl_MANL.Name = "lbl_MANL";
            this.lbl_MANL.Size = new System.Drawing.Size(135, 21);
            this.lbl_MANL.TabIndex = 0;
            this.lbl_MANL.Text = "Mã Nguyên Liệu";
            // 
            // txt_MANL
            // 
            this.txt_MANL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MANL.Location = new System.Drawing.Point(296, 196);
            this.txt_MANL.Name = "txt_MANL";
            this.txt_MANL.Size = new System.Drawing.Size(244, 29);
            this.txt_MANL.TabIndex = 3;
            // 
            // lbl_BANGTEN
            // 
            this.lbl_BANGTEN.AutoSize = true;
            this.lbl_BANGTEN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BANGTEN.Location = new System.Drawing.Point(290, 9);
            this.lbl_BANGTEN.Name = "lbl_BANGTEN";
            this.lbl_BANGTEN.Size = new System.Drawing.Size(232, 32);
            this.lbl_BANGTEN.TabIndex = 0;
            this.lbl_BANGTEN.Text = "QUẢN LÝ LÔ HÀNG";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(156, 256);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 30);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(321, 255);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(521, 255);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 30);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // DataGridView_LOHANG
            // 
            this.DataGridView_LOHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_LOHANG.Location = new System.Drawing.Point(156, 303);
            this.DataGridView_LOHANG.Name = "DataGridView_LOHANG";
            this.DataGridView_LOHANG.Size = new System.Drawing.Size(440, 143);
            this.DataGridView_LOHANG.TabIndex = 0;
            this.DataGridView_LOHANG.TabStop = false;
            // 
            // FormLOHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView_LOHANG);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_BANGTEN);
            this.Controls.Add(this.txt_MANL);
            this.Controls.Add(this.lbl_MANL);
            this.Controls.Add(this.txt_GIANHAN);
            this.Controls.Add(this.lbl_GIANHAN);
            this.Controls.Add(this.DateTime_HSD);
            this.Controls.Add(this.lbl_HSD);
            this.Controls.Add(this.txt_MALH);
            this.Controls.Add(this.lbl_MALH);
            this.Name = "FormLOHANG";
            this.Text = "QLBH_LOHANG";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_LOHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MALH;
        private System.Windows.Forms.TextBox txt_MALH;
        private System.Windows.Forms.Label lbl_HSD;
        private System.Windows.Forms.DateTimePicker DateTime_HSD;
        private System.Windows.Forms.Label lbl_GIANHAN;
        private System.Windows.Forms.TextBox txt_GIANHAN;
        private System.Windows.Forms.Label lbl_MANL;
        private System.Windows.Forms.TextBox txt_MANL;
        private System.Windows.Forms.Label lbl_BANGTEN;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView DataGridView_LOHANG;
    }
}

