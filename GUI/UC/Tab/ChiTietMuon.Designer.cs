﻿namespace GUI.UC.Tab
{
    partial class ChiTietMuon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCTM = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labTTT = new System.Windows.Forms.Label();
            this.labNgayTra = new System.Windows.Forms.Label();
            this.labTC = new System.Windows.Forms.Label();
            this.labNgayhTra = new System.Windows.Forms.Label();
            this.labNgayLap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labMDG = new System.Windows.Forms.Label();
            this.labSP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTM)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCTM);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 500);
            this.panel1.TabIndex = 0;
            // 
            // dgvCTM
            // 
            this.dgvCTM.AllowUserToAddRows = false;
            this.dgvCTM.AllowUserToDeleteRows = false;
            this.dgvCTM.AllowUserToResizeRows = false;
            this.dgvCTM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTM.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCTM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTM.Location = new System.Drawing.Point(0, 187);
            this.dgvCTM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCTM.MultiSelect = false;
            this.dgvCTM.Name = "dgvCTM";
            this.dgvCTM.ReadOnly = true;
            this.dgvCTM.RowHeadersVisible = false;
            this.dgvCTM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTM.Size = new System.Drawing.Size(645, 313);
            this.dgvCTM.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labTTT);
            this.panel2.Controls.Add(this.labNgayTra);
            this.panel2.Controls.Add(this.labTC);
            this.panel2.Controls.Add(this.labNgayhTra);
            this.panel2.Controls.Add(this.labNgayLap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labMDG);
            this.panel2.Controls.Add(this.labSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 187);
            this.panel2.TabIndex = 4;
            // 
            // labTTT
            // 
            this.labTTT.AutoSize = true;
            this.labTTT.Location = new System.Drawing.Point(16, 159);
            this.labTTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTTT.Name = "labTTT";
            this.labTTT.Size = new System.Drawing.Size(144, 17);
            this.labTTT.TabIndex = 8;
            this.labTTT.Text = "Tổng tiền thanh toán:";
            // 
            // labNgayTra
            // 
            this.labNgayTra.AutoSize = true;
            this.labNgayTra.Location = new System.Drawing.Point(361, 126);
            this.labNgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNgayTra.Name = "labNgayTra";
            this.labNgayTra.Size = new System.Drawing.Size(66, 17);
            this.labNgayTra.TabIndex = 7;
            this.labNgayTra.Text = "Ngày trả:";
            // 
            // labTC
            // 
            this.labTC.AutoSize = true;
            this.labTC.Location = new System.Drawing.Point(16, 126);
            this.labTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTC.Name = "labTC";
            this.labTC.Size = new System.Drawing.Size(98, 17);
            this.labTC.TabIndex = 6;
            this.labTC.Text = "Tổng tiền cọc:";
            // 
            // labNgayhTra
            // 
            this.labNgayhTra.AutoSize = true;
            this.labNgayhTra.Location = new System.Drawing.Point(361, 92);
            this.labNgayhTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNgayhTra.Name = "labNgayhTra";
            this.labNgayhTra.Size = new System.Drawing.Size(94, 17);
            this.labNgayhTra.TabIndex = 4;
            this.labNgayhTra.Text = "Ngày hẹn trả:";
            // 
            // labNgayLap
            // 
            this.labNgayLap.AutoSize = true;
            this.labNgayLap.Location = new System.Drawing.Point(361, 59);
            this.labNgayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNgayLap.Name = "labNgayLap";
            this.labNgayLap.Size = new System.Drawing.Size(68, 17);
            this.labNgayLap.TabIndex = 3;
            this.labNgayLap.Text = "Ngày lập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(199, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "THƯ VIỆN SÁCH ABC";
            // 
            // labMDG
            // 
            this.labMDG.AutoSize = true;
            this.labMDG.Location = new System.Drawing.Point(16, 92);
            this.labMDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMDG.Name = "labMDG";
            this.labMDG.Size = new System.Drawing.Size(81, 17);
            this.labMDG.TabIndex = 1;
            this.labMDG.Text = "Mã độc giả:";
            // 
            // labSP
            // 
            this.labSP.AutoSize = true;
            this.labSP.BackColor = System.Drawing.Color.White;
            this.labSP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labSP.Location = new System.Drawing.Point(16, 59);
            this.labSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSP.Name = "labSP";
            this.labSP.Size = new System.Drawing.Size(68, 17);
            this.labSP.TabIndex = 0;
            this.labSP.Text = "Số phiếu:";
            this.labSP.Click += new System.EventHandler(this.labSP_Click);
            // 
            // ChiTietMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 500);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietMuon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu mượn trả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietMuon_FormClosing);
            this.Load += new System.EventHandler(this.ChiTietMuon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labTTT;
        private System.Windows.Forms.Label labNgayTra;
        private System.Windows.Forms.Label labTC;
        private System.Windows.Forms.Label labNgayhTra;
        private System.Windows.Forms.Label labNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labMDG;
        private System.Windows.Forms.Label labSP;
        private System.Windows.Forms.DataGridView dgvCTM;
    }
}