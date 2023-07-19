namespace Bai2
{
    partial class QLHS_DataGridView
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
            txtDTB = new TextBox();
            txtDiaChi = new TextBox();
            txtTenHS = new TextBox();
            cbLop = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtMaHS = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnReset = new Button();
            dataGridHocSInh = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHocSInh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(298, 21);
            label1.Name = "label1";
            label1.Size = new Size(318, 38);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH HỌC SINH";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDTB);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenHS);
            groupBox1.Controls.Add(cbLop);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtMaHS);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(918, 206);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin học sinh";
            // 
            // txtDTB
            // 
            txtDTB.Location = new Point(586, 156);
            txtDTB.Name = "txtDTB";
            txtDTB.Size = new Size(245, 27);
            txtDTB.TabIndex = 11;
            txtDTB.KeyPress += txtDTB_KeyPress;
            txtDTB.Validating += txtDTB_Validating;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(586, 95);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(245, 27);
            txtDiaChi.TabIndex = 10;
            txtDiaChi.KeyPress += txtDiaChi_KeyPress;
            // 
            // txtTenHS
            // 
            txtTenHS.Location = new Point(586, 42);
            txtTenHS.Name = "txtTenHS";
            txtTenHS.Size = new Size(245, 27);
            txtTenHS.TabIndex = 9;
            txtTenHS.KeyPress += txtTenHS_KeyPress;
            // 
            // cbLop
            // 
            cbLop.DisplayMember = "MaLop";
            cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLop.Items.AddRange(new object[] { "SD18301", "SD18302", "SD18303", "SD18304", "SD18305" });
            cbLop.Location = new Point(153, 155);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(250, 28);
            cbLop.TabIndex = 8;
            cbLop.ValueMember = "MaLop";
            cbLop.SelectedIndexChanged += cbLop_SelectedIndexChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(153, 96);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 7;
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(153, 42);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(250, 27);
            txtMaHS.TabIndex = 6;
            txtMaHS.KeyPress += txtMaHS_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(458, 155);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 5;
            label7.Text = "Điểm TB:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 192, 0);
            label6.Location = new Point(458, 99);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(458, 43);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 3;
            label5.Text = "Tên học sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(26, 155);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 2;
            label4.Text = "Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(26, 99);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(26, 43);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã học sinh:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnReset);
            groupBox2.Location = new Point(12, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(918, 75);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(725, 23);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 32);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(563, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(413, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnReset
            // 
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(254, 26);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dataGridHocSInh
            // 
            dataGridHocSInh.BackgroundColor = Color.MistyRose;
            dataGridHocSInh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHocSInh.Location = new Point(12, 362);
            dataGridHocSInh.Name = "dataGridHocSInh";
            dataGridHocSInh.ReadOnly = true;
            dataGridHocSInh.RowHeadersWidth = 51;
            dataGridHocSInh.RowTemplate.Height = 29;
            dataGridHocSInh.Size = new Size(918, 324);
            dataGridHocSInh.TabIndex = 13;
            dataGridHocSInh.SelectionChanged += dataGridHocSInh_SelectionChanged;
            // 
            // QLHS_DataGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 647);
            Controls.Add(dataGridHocSInh);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "QLHS_DataGridView";
            Text = "Form1";
            TransparencyKey = Color.Cyan;
            Load += QLHS_DataGridView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridHocSInh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbLop;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtMaHS;
        private TextBox txtDTB;
        private TextBox txtDiaChi;
        private TextBox txtTenHS;
        private GroupBox groupBox2;
        private Button btnReset;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
        private DataGridView dataGridHocSInh;
    }
}