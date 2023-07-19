namespace Bai1
{
    partial class QuanLyHocSinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtDiemTB = new TextBox();
            cbLop = new ComboBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtTenHS = new TextBox();
            txtMaHS = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(231, 20);
            label1.Name = "label1";
            label1.Size = new Size(326, 38);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH HỌC SINH";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiemTB);
            groupBox1.Controls.Add(cbLop);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtTenHS);
            groupBox1.Controls.Add(txtMaHS);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 387);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin học sinh";
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(238, 333);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(390, 27);
            txtDiemTB.TabIndex = 12;
            txtDiemTB.KeyPress += txtDiemTB_KeyPress;
            txtDiemTB.Validating += txtDiemTB_Validating;
            // 
            // cbLop
            // 
            cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLop.FormattingEnabled = true;
            cbLop.Items.AddRange(new object[] { "SD18301", "SD18302", "SD18303", "SD18304", "SD18305" });
            cbLop.Location = new Point(237, 277);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(391, 28);
            cbLop.TabIndex = 11;
            cbLop.SelectedIndexChanged += cbLop_SelectedIndexChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(238, 224);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(390, 27);
            txtDiaChi.TabIndex = 10;
            txtDiaChi.KeyPress += txtDiaChi_KeyPress;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(237, 170);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(391, 27);
            dtpNgaySinh.TabIndex = 9;
            dtpNgaySinh.Value = new DateTime(2023, 7, 18, 0, 0, 0, 0);
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // txtTenHS
            // 
            txtTenHS.Location = new Point(238, 112);
            txtTenHS.Name = "txtTenHS";
            txtTenHS.Size = new Size(390, 27);
            txtTenHS.TabIndex = 8;
            txtTenHS.KeyPress += txtTenHS_KeyPress;
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(238, 63);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(390, 27);
            txtMaHS.TabIndex = 7;
            txtMaHS.KeyPress += txtMaHS_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(82, 333);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 6;
            label7.Text = "Điểm trung bình:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(82, 277);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 5;
            label6.Text = "Lớp:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(82, 224);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(82, 170);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(82, 112);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên học sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(82, 63);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã học sinh:";
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(291, 491);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(478, 491);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(664, 491);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnReset
            // 
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(105, 491);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // QuanLyHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 580);
            Controls.Add(btnReset);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "QuanLyHocSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH SÁCH HỌC SINH";
            TransparencyKey = Color.FromArgb(0, 192, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbLop;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtTenHS;
        private TextBox txtMaHS;
        private TextBox txtDiemTB;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnReset;
    }
}