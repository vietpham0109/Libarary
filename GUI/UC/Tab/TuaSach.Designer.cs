﻿namespace GUI.UC.Tab
{
    partial class TuaSach
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
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                ctrl.Dispose();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.btnTL = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.btnTG = new System.Windows.Forms.Button();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNDTT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCapNhat = new GUI.ComponentForm.Thin_Button();
            this.btnXoa = new GUI.ComponentForm.Thin_Button();
            this.btnSua = new GUI.ComponentForm.Thin_Button();
            this.btnThem = new GUI.ComponentForm.Thin_Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMTS = new System.Windows.Forms.TextBox();
            this.dgvTuaSach = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTL);
            this.panel1.Controls.Add(this.btnTL);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTG);
            this.panel1.Controls.Add(this.btnTG);
            this.panel1.Controls.Add(this.cbbNXB);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNDTT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNamXB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMTS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 290);
            this.panel1.TabIndex = 0;
            // 
            // txtTL
            // 
            this.txtTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTL.Location = new System.Drawing.Point(400, 178);
            this.txtTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTL.MaximumSize = new System.Drawing.Size(309, 24);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(285, 24);
            this.txtTL.TabIndex = 7;
            // 
            // btnTL
            // 
            this.btnTL.Location = new System.Drawing.Point(695, 178);
            this.btnTL.Margin = new System.Windows.Forms.Padding(4);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(40, 31);
            this.btnTL.TabIndex = 28;
            this.btnTL.TabStop = false;
            this.btnTL.Text = "...";
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(396, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Thể loại";
            // 
            // txtTG
            // 
            this.txtTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.Location = new System.Drawing.Point(400, 228);
            this.txtTG.Margin = new System.Windows.Forms.Padding(4);
            this.txtTG.MaximumSize = new System.Drawing.Size(309, 24);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(285, 24);
            this.txtTG.TabIndex = 8;
            // 
            // btnTG
            // 
            this.btnTG.Location = new System.Drawing.Point(695, 226);
            this.btnTG.Margin = new System.Windows.Forms.Padding(4);
            this.btnTG.Name = "btnTG";
            this.btnTG.Size = new System.Drawing.Size(40, 31);
            this.btnTG.TabIndex = 24;
            this.btnTG.TabStop = false;
            this.btnTG.Text = "...";
            this.btnTG.UseVisualStyleBackColor = true;
            this.btnTG.Click += new System.EventHandler(this.btnTG_Click);
            // 
            // cbbNXB
            // 
            this.cbbNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNXB.FormattingEnabled = true;
            this.cbbNXB.Location = new System.Drawing.Point(400, 129);
            this.cbbNXB.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNXB.MaximumSize = new System.Drawing.Size(332, 0);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(332, 26);
            this.cbbNXB.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Peru;
            this.label9.Location = new System.Drawing.Point(769, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nội dung tóm tắt";
            // 
            // txtNDTT
            // 
            this.txtNDTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDTT.Location = new System.Drawing.Point(757, 31);
            this.txtNDTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtNDTT.Multiline = true;
            this.txtNDTT.Name = "txtNDTT";
            this.txtNDTT.Size = new System.Drawing.Size(317, 244);
            this.txtNDTT.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(396, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tác giả";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Active = false;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BoderColorDisable = System.Drawing.Color.Red;
            this.btnCapNhat.BorderColorClick = System.Drawing.Color.Empty;
            this.btnCapNhat.BorderColorHover = System.Drawing.Color.Empty;
            this.btnCapNhat.BorderColorNomal = System.Drawing.Color.Green;
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCapNhat.InnerColorDisable = System.Drawing.Color.Transparent;
            this.btnCapNhat.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapNhat.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnCapNhat.Location = new System.Drawing.Point(205, 247);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 28);
            this.btnCapNhat.SizeBorder = 1;
            this.btnCapNhat.TabIndex = 19;
            this.btnCapNhat.TabStop = false;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnCapNhat.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnCapNhat.TextColorClick = System.Drawing.Color.Empty;
            this.btnCapNhat.TextColorDisable = System.Drawing.Color.Black;
            this.btnCapNhat.TextColorHover = System.Drawing.Color.Empty;
            this.btnCapNhat.TextColorNomal = System.Drawing.Color.Black;
            this.btnCapNhat.UseActive = false;
            this.btnCapNhat.UseBorderColorHoverClick = false;
            this.btnCapNhat.UseInnerColorHoverClick = true;
            this.btnCapNhat.UseTextColorHoverClick = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Active = false;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BoderColorDisable = System.Drawing.Color.Red;
            this.btnXoa.BorderColorClick = System.Drawing.Color.Empty;
            this.btnXoa.BorderColorHover = System.Drawing.Color.Empty;
            this.btnXoa.BorderColorNomal = System.Drawing.Color.Green;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.InnerColorDisable = System.Drawing.Color.Transparent;
            this.btnXoa.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(205, 212);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.SizeBorder = 1;
            this.btnXoa.TabIndex = 18;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnXoa.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnXoa.TextColorClick = System.Drawing.Color.Empty;
            this.btnXoa.TextColorDisable = System.Drawing.Color.Black;
            this.btnXoa.TextColorHover = System.Drawing.Color.Empty;
            this.btnXoa.TextColorNomal = System.Drawing.Color.Black;
            this.btnXoa.UseActive = false;
            this.btnXoa.UseBorderColorHoverClick = false;
            this.btnXoa.UseInnerColorHoverClick = true;
            this.btnXoa.UseTextColorHoverClick = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Active = false;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BoderColorDisable = System.Drawing.Color.Red;
            this.btnSua.BorderColorClick = System.Drawing.Color.Empty;
            this.btnSua.BorderColorHover = System.Drawing.Color.Empty;
            this.btnSua.BorderColorNomal = System.Drawing.Color.Green;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSua.InnerColorDisable = System.Drawing.Color.Transparent;
            this.btnSua.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnSua.Location = new System.Drawing.Point(51, 247);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.SizeBorder = 1;
            this.btnSua.TabIndex = 17;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnSua.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnSua.TextColorClick = System.Drawing.Color.Empty;
            this.btnSua.TextColorDisable = System.Drawing.Color.Black;
            this.btnSua.TextColorHover = System.Drawing.Color.Empty;
            this.btnSua.TextColorNomal = System.Drawing.Color.Black;
            this.btnSua.UseActive = true;
            this.btnSua.UseBorderColorHoverClick = false;
            this.btnSua.UseInnerColorHoverClick = true;
            this.btnSua.UseTextColorHoverClick = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Active = false;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BoderColorDisable = System.Drawing.Color.Red;
            this.btnThem.BorderColorClick = System.Drawing.Color.Empty;
            this.btnThem.BorderColorHover = System.Drawing.Color.Empty;
            this.btnThem.BorderColorNomal = System.Drawing.Color.Green;
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.InnerColorDisable = System.Drawing.Color.Transparent;
            this.btnThem.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnThem.Location = new System.Drawing.Point(51, 212);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.SizeBorder = 1;
            this.btnThem.TabIndex = 16;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnThem.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnThem.TextColorClick = System.Drawing.Color.Empty;
            this.btnThem.TextColorDisable = System.Drawing.Color.Black;
            this.btnThem.TextColorHover = System.Drawing.Color.Empty;
            this.btnThem.TextColorNomal = System.Drawing.Color.Black;
            this.btnThem.UseActive = true;
            this.btnThem.UseBorderColorHoverClick = false;
            this.btnThem.UseInnerColorHoverClick = true;
            this.btnThem.UseTextColorHoverClick = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(396, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nhà xuất bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(396, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngôn ngữ chính";
            // 
            // txtNN
            // 
            this.txtNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNN.Location = new System.Drawing.Point(400, 80);
            this.txtNN.Margin = new System.Windows.Forms.Padding(4);
            this.txtNN.MaximumSize = new System.Drawing.Size(332, 24);
            this.txtNN.MaxLength = 15;
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(332, 24);
            this.txtNN.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(396, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vị trí";
            // 
            // txtVT
            // 
            this.txtVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVT.Location = new System.Drawing.Point(400, 31);
            this.txtVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtVT.MaximumSize = new System.Drawing.Size(332, 24);
            this.txtVT.MaxLength = 8;
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(332, 24);
            this.txtVT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá sách";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(28, 178);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.MaximumSize = new System.Drawing.Size(332, 24);
            this.txtGia.MaxLength = 15;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(332, 24);
            this.txtGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm xuất bản";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.Location = new System.Drawing.Point(28, 129);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamXB.MaximumSize = new System.Drawing.Size(332, 24);
            this.txtNamXB.MaxLength = 4;
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(332, 24);
            this.txtNamXB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tựa sách";
            // 
            // txtTS
            // 
            this.txtTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS.Location = new System.Drawing.Point(28, 80);
            this.txtTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTS.MaximumSize = new System.Drawing.Size(332, 24);
            this.txtTS.MaxLength = 50;
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(332, 24);
            this.txtTS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tựa sách";
            // 
            // txtMTS
            // 
            this.txtMTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMTS.Location = new System.Drawing.Point(27, 31);
            this.txtMTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMTS.MaximumSize = new System.Drawing.Size(332, 24);
            this.txtMTS.MaxLength = 10;
            this.txtMTS.Name = "txtMTS";
            this.txtMTS.Size = new System.Drawing.Size(332, 24);
            this.txtMTS.TabIndex = 0;
            // 
            // dgvTuaSach
            // 
            this.dgvTuaSach.AllowUserToAddRows = false;
            this.dgvTuaSach.AllowUserToDeleteRows = false;
            this.dgvTuaSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvTuaSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTuaSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuaSach.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTuaSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTuaSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuaSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTuaSach.Location = new System.Drawing.Point(0, 290);
            this.dgvTuaSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTuaSach.MultiSelect = false;
            this.dgvTuaSach.Name = "dgvTuaSach";
            this.dgvTuaSach.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTuaSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvTuaSach.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTuaSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuaSach.Size = new System.Drawing.Size(1096, 255);
            this.dgvTuaSach.TabIndex = 1;
            this.dgvTuaSach.TabStop = false;
            this.dgvTuaSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuaSach_CellClick);
            // 
            // TuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTuaSach);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TuaSach";
            this.Size = new System.Drawing.Size(1096, 545);
            this.Load += new System.EventHandler(this.TuaSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuaSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTuaSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMTS;
        private ComponentForm.Thin_Button btnCapNhat;
        private ComponentForm.Thin_Button btnXoa;
        private ComponentForm.Thin_Button btnSua;
        private ComponentForm.Thin_Button btnThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNDTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbNXB;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.Button btnTG;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.Label label10;
    }
}
