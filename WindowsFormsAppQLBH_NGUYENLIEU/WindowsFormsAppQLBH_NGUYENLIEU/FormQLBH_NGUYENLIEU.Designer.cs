namespace WindowsFormsAppQLBH_NGUYENLIEU
{
    partial class FormQLBH_NGUYENLIEU
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
            this.lbl_MANL = new System.Windows.Forms.Label();
            this.txt_MANL = new System.Windows.Forms.TextBox();
            this.lbl_TENNL = new System.Windows.Forms.Label();
            this.txt_TENNL = new System.Windows.Forms.TextBox();
            this.lbl_DONVI = new System.Windows.Forms.Label();
            this.txt_DONVI = new System.Windows.Forms.TextBox();
            this.lbl_SLTONKHO = new System.Windows.Forms.Label();
            this.txt_SLTONKHO = new System.Windows.Forms.TextBox();
            this.lbl_BANGTEN = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.DataGridViewNGUYENLIEU = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNGUYENLIEU)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MANL
            // 
            this.lbl_MANL.AutoSize = true;
            this.lbl_MANL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MANL.Location = new System.Drawing.Point(44, 100);
            this.lbl_MANL.Name = "lbl_MANL";
            this.lbl_MANL.Size = new System.Drawing.Size(135, 21);
            this.lbl_MANL.TabIndex = 0;
            this.lbl_MANL.Text = "Mã Nguyên Liệu";
            // 
            // txt_MANL
            // 
            this.txt_MANL.Location = new System.Drawing.Point(219, 103);
            this.txt_MANL.Name = "txt_MANL";
            this.txt_MANL.Size = new System.Drawing.Size(100, 20);
            this.txt_MANL.TabIndex = 0;
            // 
            // lbl_TENNL
            // 
            this.lbl_TENNL.AutoSize = true;
            this.lbl_TENNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TENNL.Location = new System.Drawing.Point(44, 163);
            this.lbl_TENNL.Name = "lbl_TENNL";
            this.lbl_TENNL.Size = new System.Drawing.Size(138, 21);
            this.lbl_TENNL.TabIndex = 0;
            this.lbl_TENNL.Text = "Tên Nguyên Liệu";
            // 
            // txt_TENNL
            // 
            this.txt_TENNL.Location = new System.Drawing.Point(219, 163);
            this.txt_TENNL.Name = "txt_TENNL";
            this.txt_TENNL.Size = new System.Drawing.Size(100, 20);
            this.txt_TENNL.TabIndex = 1;
            // 
            // lbl_DONVI
            // 
            this.lbl_DONVI.AutoSize = true;
            this.lbl_DONVI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DONVI.Location = new System.Drawing.Point(44, 227);
            this.lbl_DONVI.Name = "lbl_DONVI";
            this.lbl_DONVI.Size = new System.Drawing.Size(62, 21);
            this.lbl_DONVI.TabIndex = 0;
            this.lbl_DONVI.Text = "Đơn Vị";
            // 
            // txt_DONVI
            // 
            this.txt_DONVI.Location = new System.Drawing.Point(219, 227);
            this.txt_DONVI.Name = "txt_DONVI";
            this.txt_DONVI.Size = new System.Drawing.Size(100, 20);
            this.txt_DONVI.TabIndex = 2;
            // 
            // lbl_SLTONKHO
            // 
            this.lbl_SLTONKHO.AutoSize = true;
            this.lbl_SLTONKHO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SLTONKHO.Location = new System.Drawing.Point(44, 285);
            this.lbl_SLTONKHO.Name = "lbl_SLTONKHO";
            this.lbl_SLTONKHO.Size = new System.Drawing.Size(146, 21);
            this.lbl_SLTONKHO.TabIndex = 0;
            this.lbl_SLTONKHO.Text = "Số lượng Tồn Kho";
            // 
            // txt_SLTONKHO
            // 
            this.txt_SLTONKHO.Location = new System.Drawing.Point(219, 285);
            this.txt_SLTONKHO.Name = "txt_SLTONKHO";
            this.txt_SLTONKHO.Size = new System.Drawing.Size(100, 20);
            this.txt_SLTONKHO.TabIndex = 3;
            // 
            // lbl_BANGTEN
            // 
            this.lbl_BANGTEN.AutoSize = true;
            this.lbl_BANGTEN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BANGTEN.Location = new System.Drawing.Point(290, 31);
            this.lbl_BANGTEN.Name = "lbl_BANGTEN";
            this.lbl_BANGTEN.Size = new System.Drawing.Size(224, 25);
            this.lbl_BANGTEN.TabIndex = 0;
            this.lbl_BANGTEN.Text = "QUẢN LÝ NGUYÊN LIỆU";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(31, 347);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 27);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(139, 347);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 27);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(257, 347);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 27);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // DataGridViewNGUYENLIEU
            // 
            this.DataGridViewNGUYENLIEU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewNGUYENLIEU.Location = new System.Drawing.Point(374, 85);
            this.DataGridViewNGUYENLIEU.Name = "DataGridViewNGUYENLIEU";
            this.DataGridViewNGUYENLIEU.Size = new System.Drawing.Size(401, 353);
            this.DataGridViewNGUYENLIEU.TabIndex = 0;
            this.DataGridViewNGUYENLIEU.TabStop = false;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(77, 406);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(85, 32);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm Kiếm ";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(205, 406);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 32);
            this.btn_Huy.TabIndex = 8;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // FormQLBH_NGUYENLIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.DataGridViewNGUYENLIEU);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_BANGTEN);
            this.Controls.Add(this.txt_SLTONKHO);
            this.Controls.Add(this.lbl_SLTONKHO);
            this.Controls.Add(this.txt_DONVI);
            this.Controls.Add(this.lbl_DONVI);
            this.Controls.Add(this.txt_TENNL);
            this.Controls.Add(this.lbl_TENNL);
            this.Controls.Add(this.txt_MANL);
            this.Controls.Add(this.lbl_MANL);
            this.Name = "FormQLBH_NGUYENLIEU";
            this.Text = "QLBH_NGUYENLIEU";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNGUYENLIEU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MANL;
        private System.Windows.Forms.TextBox txt_MANL;
        private System.Windows.Forms.Label lbl_TENNL;
        private System.Windows.Forms.TextBox txt_TENNL;
        private System.Windows.Forms.Label lbl_DONVI;
        private System.Windows.Forms.TextBox txt_DONVI;
        private System.Windows.Forms.Label lbl_SLTONKHO;
        private System.Windows.Forms.TextBox txt_SLTONKHO;
        private System.Windows.Forms.Label lbl_BANGTEN;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView DataGridViewNGUYENLIEU;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Huy;
    }
}


