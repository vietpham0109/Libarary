﻿namespace GUI.UC
{
    partial class UCMuonTra
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
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.flat_Button1 = new GUI.ComponentForm.Flat_Button();
            this.btnMuon = new GUI.ComponentForm.Flat_Button();
            this.pnlUseMuonTra = new System.Windows.Forms.Panel();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlToolbar.Controls.Add(this.flat_Button1);
            this.pnlToolbar.Controls.Add(this.btnMuon);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1096, 43);
            this.pnlToolbar.TabIndex = 0;
            // 
            // flat_Button1
            // 
            this.flat_Button1.Active = false;
            this.flat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.flat_Button1.BackgroundColorClick = System.Drawing.Color.Empty;
            this.flat_Button1.BackgroundColorHover = System.Drawing.Color.Empty;
            this.flat_Button1.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.flat_Button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flat_Button1.ForeColor = System.Drawing.Color.Black;
            this.flat_Button1.IconAlignment = 3;
            this.flat_Button1.IconClick = null;
            this.flat_Button1.IconHover = null;
            this.flat_Button1.IconNormal = null;
            this.flat_Button1.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.flat_Button1.IconSize = new System.Drawing.Size(0, 0);
            this.flat_Button1.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flat_Button1.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flat_Button1.LineColorNormal = System.Drawing.Color.Green;
            this.flat_Button1.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.flat_Button1.LineSize = 3;
            this.flat_Button1.Location = new System.Drawing.Point(107, 0);
            this.flat_Button1.Margin = new System.Windows.Forms.Padding(5);
            this.flat_Button1.MinimumSize = new System.Drawing.Size(31, 28);
            this.flat_Button1.Name = "flat_Button1";
            this.flat_Button1.Size = new System.Drawing.Size(107, 43);
            this.flat_Button1.TabIndex = 2;
            this.flat_Button1.Text = "Cuốn Sách";
            this.flat_Button1.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.flat_Button1.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.flat_Button1.TextColorClick = System.Drawing.Color.Empty;
            this.flat_Button1.TextColorHover = System.Drawing.Color.GreenYellow;
            this.flat_Button1.TextColorNormal = System.Drawing.Color.IndianRed;
            this.flat_Button1.UseActive = true;
            this.flat_Button1.UseBackgroundHoverClick = false;
            this.flat_Button1.UseIconHoverClick = false;
            this.flat_Button1.UseLineHoverClick = true;
            this.flat_Button1.UseTextHoverClick = false;
            this.flat_Button1.Click += new System.EventHandler(this.flat_Button1_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.Active = false;
            this.btnMuon.BackColor = System.Drawing.Color.Transparent;
            this.btnMuon.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnMuon.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnMuon.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuon.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.ForeColor = System.Drawing.Color.Black;
            this.btnMuon.IconAlignment = 3;
            this.btnMuon.IconClick = null;
            this.btnMuon.IconHover = null;
            this.btnMuon.IconNormal = null;
            this.btnMuon.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnMuon.IconSize = new System.Drawing.Size(0, 0);
            this.btnMuon.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMuon.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMuon.LineColorNormal = System.Drawing.Color.Green;
            this.btnMuon.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnMuon.LineSize = 3;
            this.btnMuon.Location = new System.Drawing.Point(0, 0);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(5);
            this.btnMuon.MinimumSize = new System.Drawing.Size(31, 28);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(107, 43);
            this.btnMuon.TabIndex = 0;
            this.btnMuon.Text = "Mượn sách";
            this.btnMuon.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnMuon.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnMuon.TextColorClick = System.Drawing.Color.Empty;
            this.btnMuon.TextColorHover = System.Drawing.Color.GreenYellow;
            this.btnMuon.TextColorNormal = System.Drawing.Color.Black;
            this.btnMuon.UseActive = true;
            this.btnMuon.UseBackgroundHoverClick = false;
            this.btnMuon.UseIconHoverClick = false;
            this.btnMuon.UseLineHoverClick = true;
            this.btnMuon.UseTextHoverClick = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // pnlUseMuonTra
            // 
            this.pnlUseMuonTra.ForeColor = System.Drawing.Color.Black;
            this.pnlUseMuonTra.Location = new System.Drawing.Point(19, 51);
            this.pnlUseMuonTra.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUseMuonTra.Name = "pnlUseMuonTra";
            this.pnlUseMuonTra.Size = new System.Drawing.Size(1077, 537);
            this.pnlUseMuonTra.TabIndex = 1;
            // 
            // UCMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUseMuonTra);
            this.Controls.Add(this.pnlToolbar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCMuonTra";
            this.Size = new System.Drawing.Size(1096, 588);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private ComponentForm.Flat_Button btnMuon;
        private System.Windows.Forms.Panel pnlUseMuonTra;
        private ComponentForm.Flat_Button flat_Button1;
    }
}
