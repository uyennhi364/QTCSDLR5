namespace WindowsFormsAppQLBH_MON
{
    partial class FormQLBH_MON
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
            this.lbl_MAMON = new System.Windows.Forms.Label();
            this.text_MAMON = new System.Windows.Forms.TextBox();
            this.lbl_TENMON = new System.Windows.Forms.Label();
            this.text_TENMON = new System.Windows.Forms.TextBox();
            this.lbl_GIABAN = new System.Windows.Forms.Label();
            this.text_GIABAN = new System.Windows.Forms.TextBox();
            this.lbl_DONVI = new System.Windows.Forms.Label();
            this.text_DONVI = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.DataGridView_MON = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_MON)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MAMON
            // 
            this.lbl_MAMON.AutoSize = true;
            this.lbl_MAMON.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MAMON.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MAMON.Location = new System.Drawing.Point(32, 78);
            this.lbl_MAMON.Name = "lbl_MAMON";
            this.lbl_MAMON.Size = new System.Drawing.Size(67, 20);
            this.lbl_MAMON.TabIndex = 0;
            this.lbl_MAMON.Text = "Mã Món";
            // 
            // text_MAMON
            // 
            this.text_MAMON.Location = new System.Drawing.Point(130, 80);
            this.text_MAMON.Name = "text_MAMON";
            this.text_MAMON.Size = new System.Drawing.Size(100, 20);
            this.text_MAMON.TabIndex = 0;
            // 
            // lbl_TENMON
            // 
            this.lbl_TENMON.AutoSize = true;
            this.lbl_TENMON.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TENMON.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TENMON.Location = new System.Drawing.Point(32, 135);
            this.lbl_TENMON.Name = "lbl_TENMON";
            this.lbl_TENMON.Size = new System.Drawing.Size(70, 20);
            this.lbl_TENMON.TabIndex = 0;
            this.lbl_TENMON.Text = "Tên Món";
            // 
            // text_TENMON
            // 
            this.text_TENMON.Location = new System.Drawing.Point(130, 137);
            this.text_TENMON.Name = "text_TENMON";
            this.text_TENMON.Size = new System.Drawing.Size(182, 20);
            this.text_TENMON.TabIndex = 1;
            // 
            // lbl_GIABAN
            // 
            this.lbl_GIABAN.AutoSize = true;
            this.lbl_GIABAN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GIABAN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GIABAN.Location = new System.Drawing.Point(32, 198);
            this.lbl_GIABAN.Name = "lbl_GIABAN";
            this.lbl_GIABAN.Size = new System.Drawing.Size(63, 20);
            this.lbl_GIABAN.TabIndex = 0;
            this.lbl_GIABAN.Text = "Giá Bán";
            // 
            // text_GIABAN
            // 
            this.text_GIABAN.Location = new System.Drawing.Point(130, 200);
            this.text_GIABAN.Name = "text_GIABAN";
            this.text_GIABAN.Size = new System.Drawing.Size(100, 20);
            this.text_GIABAN.TabIndex = 2;
            // 
            // lbl_DONVI
            // 
            this.lbl_DONVI.AutoSize = true;
            this.lbl_DONVI.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DONVI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DONVI.Location = new System.Drawing.Point(32, 263);
            this.lbl_DONVI.Name = "lbl_DONVI";
            this.lbl_DONVI.Size = new System.Drawing.Size(56, 20);
            this.lbl_DONVI.TabIndex = 0;
            this.lbl_DONVI.Text = "Đơn Vị";
            // 
            // text_DONVI
            // 
            this.text_DONVI.Location = new System.Drawing.Point(130, 263);
            this.text_DONVI.Name = "text_DONVI";
            this.text_DONVI.Size = new System.Drawing.Size(100, 20);
            this.text_DONVI.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(48, 357);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(155, 357);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(272, 357);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // DataGridView_MON
            // 
            this.DataGridView_MON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_MON.Location = new System.Drawing.Point(380, 78);
            this.DataGridView_MON.Name = "DataGridView_MON";
            this.DataGridView_MON.Size = new System.Drawing.Size(460, 377);
            this.DataGridView_MON.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "QUẢN LÝ MÓN";
            // 
            // FormQLBH_MON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGridView_MON);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.text_DONVI);
            this.Controls.Add(this.lbl_DONVI);
            this.Controls.Add(this.text_GIABAN);
            this.Controls.Add(this.lbl_GIABAN);
            this.Controls.Add(this.text_TENMON);
            this.Controls.Add(this.lbl_TENMON);
            this.Controls.Add(this.text_MAMON);
            this.Controls.Add(this.lbl_MAMON);
            this.Name = "FormQLBH_MON";
            this.Text = " QLBH_MON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_MON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MAMON;
        private System.Windows.Forms.TextBox text_MAMON;
        private System.Windows.Forms.Label lbl_TENMON;
        private System.Windows.Forms.TextBox text_TENMON;
        private System.Windows.Forms.Label lbl_GIABAN;
        private System.Windows.Forms.TextBox text_GIABAN;
        private System.Windows.Forms.Label lbl_DONVI;
        private System.Windows.Forms.TextBox text_DONVI;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView DataGridView_MON;
        private System.Windows.Forms.Label label5;
        
        }
}

