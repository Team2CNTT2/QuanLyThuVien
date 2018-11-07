namespace QL_THUVIEN2
{
    partial class Reader
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
            this.paneldg = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvchitiet = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.none = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.txtns = new System.Windows.Forms.DateTimePicker();
            this.dgvdsdg = new System.Windows.Forms.DataGridView();
            this.dgvma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtstd = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtttcnten = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttsua = new System.Windows.Forms.Button();
            this.bttthemmoi = new System.Windows.Forms.Button();
            this.paneldg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsdg)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldg
            // 
            this.paneldg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paneldg.Controls.Add(this.groupBox1);
            this.paneldg.Controls.Add(this.button2);
            this.paneldg.Controls.Add(this.txtgt);
            this.paneldg.Controls.Add(this.txtns);
            this.paneldg.Controls.Add(this.bttxoa);
            this.paneldg.Controls.Add(this.bttsua);
            this.paneldg.Controls.Add(this.bttthemmoi);
            this.paneldg.Controls.Add(this.dgvdsdg);
            this.paneldg.Controls.Add(this.txtstd);
            this.paneldg.Controls.Add(this.txtdc);
            this.paneldg.Controls.Add(this.txtten);
            this.paneldg.Controls.Add(this.txtma);
            this.paneldg.Controls.Add(this.label19);
            this.paneldg.Controls.Add(this.label17);
            this.paneldg.Controls.Add(this.label16);
            this.paneldg.Controls.Add(this.label14);
            this.paneldg.Controls.Add(this.label13);
            this.paneldg.Controls.Add(this.txtttcnten);
            this.paneldg.Controls.Add(this.label11);
            this.paneldg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldg.Location = new System.Drawing.Point(0, 0);
            this.paneldg.Name = "paneldg";
            this.paneldg.Size = new System.Drawing.Size(1030, 611);
            this.paneldg.TabIndex = 3;
            this.paneldg.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvchitiet);
            this.groupBox1.Location = new System.Drawing.Point(664, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 307);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết mượn sách";
            // 
            // dgvchitiet
            // 
            this.dgvchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.none});
            this.dgvchitiet.Location = new System.Drawing.Point(17, 25);
            this.dgvchitiet.Name = "dgvchitiet";
            this.dgvchitiet.Size = new System.Drawing.Size(293, 247);
            this.dgvchitiet.TabIndex = 27;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "Masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // none
            // 
            this.none.DataPropertyName = "tongSM";
            this.none.HeaderText = "Số lượng mượn";
            this.none.Name = "none";
            this.none.Width = 150;
            // 
            // txtgt
            // 
            this.txtgt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtgt.Location = new System.Drawing.Point(226, 150);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(178, 26);
            this.txtgt.TabIndex = 25;
            // 
            // txtns
            // 
            this.txtns.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtns.CalendarForeColor = System.Drawing.Color.White;
            this.txtns.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtns.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtns.CustomFormat = "dd-MM-yyyy";
            this.txtns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtns.Location = new System.Drawing.Point(622, 147);
            this.txtns.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(200, 26);
            this.txtns.TabIndex = 24;
            // 
            // dgvdsdg
            // 
            this.dgvdsdg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdsdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdsdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvma,
            this.dgvten,
            this.dgvgt,
            this.dgvdc,
            this.dgvsdt,
            this.dgvns});
            this.dgvdsdg.Location = new System.Drawing.Point(35, 232);
            this.dgvdsdg.Name = "dgvdsdg";
            this.dgvdsdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdsdg.Size = new System.Drawing.Size(591, 251);
            this.dgvdsdg.TabIndex = 3;
            this.dgvdsdg.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsdg_RowEnter);
            // 
            // dgvma
            // 
            this.dgvma.DataPropertyName = "MaDG";
            this.dgvma.HeaderText = "Reader ID";
            this.dgvma.Name = "dgvma";
            // 
            // dgvten
            // 
            this.dgvten.DataPropertyName = "TenDG";
            this.dgvten.HeaderText = "Name";
            this.dgvten.Name = "dgvten";
            // 
            // dgvgt
            // 
            this.dgvgt.DataPropertyName = "GioiTinh";
            this.dgvgt.HeaderText = "Gender";
            this.dgvgt.Name = "dgvgt";
            // 
            // dgvdc
            // 
            this.dgvdc.DataPropertyName = "DiaChi";
            this.dgvdc.HeaderText = "Address";
            this.dgvdc.Name = "dgvdc";
            // 
            // dgvsdt
            // 
            this.dgvsdt.DataPropertyName = "SDT";
            this.dgvsdt.HeaderText = "Phone number";
            this.dgvsdt.Name = "dgvsdt";
            // 
            // dgvns
            // 
            this.dgvns.DataPropertyName = "NgaySinh";
            this.dgvns.HeaderText = "Date of birth";
            this.dgvns.Name = "dgvns";
            // 
            // txtstd
            // 
            this.txtstd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtstd.Location = new System.Drawing.Point(622, 108);
            this.txtstd.Name = "txtstd";
            this.txtstd.Size = new System.Drawing.Size(200, 26);
            this.txtstd.TabIndex = 16;
            // 
            // txtdc
            // 
            this.txtdc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtdc.Location = new System.Drawing.Point(622, 73);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(200, 26);
            this.txtdc.TabIndex = 14;
            // 
            // txtten
            // 
            this.txtten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtten.Location = new System.Drawing.Point(226, 108);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(178, 26);
            this.txtten.TabIndex = 11;
            // 
            // txtma
            // 
            this.txtma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtma.Location = new System.Drawing.Point(226, 73);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(178, 26);
            this.txtma.TabIndex = 10;
            this.txtma.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Yellow;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(382, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(287, 24);
            this.label19.TabIndex = 8;
            this.label19.Text = "INFORMATION OF READER";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(500, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "Date of birth";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(500, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "Phone numer";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(500, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Address";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(119, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Gender";
            // 
            // txtttcnten
            // 
            this.txtttcnten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtttcnten.AutoSize = true;
            this.txtttcnten.ForeColor = System.Drawing.Color.Maroon;
            this.txtttcnten.Location = new System.Drawing.Point(119, 108);
            this.txtttcnten.Name = "txtttcnten";
            this.txtttcnten.Size = new System.Drawing.Size(46, 19);
            this.txtttcnten.TabIndex = 1;
            this.txtttcnten.Text = "Name";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(119, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Reader ID";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackgroundImage = global::QL_THUVIEN2.Properties.Resources.images__1_2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(649, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 59);
            this.button2.TabIndex = 26;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttxoa
            // 
            this.bttxoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttxoa.BackgroundImage = global::QL_THUVIEN2.Properties.Resources.delete;
            this.bttxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttxoa.Location = new System.Drawing.Point(479, 515);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(106, 59);
            this.bttxoa.TabIndex = 22;
            this.bttxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttxoa.UseVisualStyleBackColor = true;
            this.bttxoa.Click += new System.EventHandler(this.bttqlnvxoa_Click_1);
            // 
            // bttsua
            // 
            this.bttsua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttsua.BackgroundImage = global::QL_THUVIEN2.Properties.Resources.edit;
            this.bttsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttsua.Location = new System.Drawing.Point(298, 515);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(106, 59);
            this.bttsua.TabIndex = 20;
            this.bttsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttsua.UseVisualStyleBackColor = true;
            this.bttsua.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bttthemmoi
            // 
            this.bttthemmoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttthemmoi.BackgroundImage = global::QL_THUVIEN2.Properties.Resources._220px_Add1;
            this.bttthemmoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttthemmoi.Location = new System.Drawing.Point(110, 515);
            this.bttthemmoi.Name = "bttthemmoi";
            this.bttthemmoi.Size = new System.Drawing.Size(129, 59);
            this.bttthemmoi.TabIndex = 19;
            this.bttthemmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttthemmoi.UseVisualStyleBackColor = true;
            this.bttthemmoi.Click += new System.EventHandler(this.bttttcnluu_Click_1);
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 612);
            this.Controls.Add(this.paneldg);
            this.Name = "Reader";
            this.Text = "INFORMATION OF BOOK";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.paneldg.ResumeLayout(false);
            this.paneldg.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldg;
        private System.Windows.Forms.TextBox txtgt;
        private System.Windows.Forms.DateTimePicker txtns;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Button bttthemmoi;
        private System.Windows.Forms.DataGridView dgvdsdg;
        private System.Windows.Forms.TextBox txtstd;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtttcnten;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvchitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn none;
    }
}