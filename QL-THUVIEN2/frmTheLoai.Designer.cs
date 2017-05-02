namespace QL_THUVIEN2
{
    partial class frmTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheLoai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ten = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpn1madg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttqlnvxoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.bttthemmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ten);
            this.panel1.Controls.Add(this.ma);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.bttqlnvxoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.bttthemmoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 441);
            this.panel1.TabIndex = 1;
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(334, 91);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(180, 26);
            this.ten.TabIndex = 30;
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(334, 22);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(180, 26);
            this.ma.TabIndex = 29;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Image = global::QL_THUVIEN2.Properties.Resources.rewind1;
            this.btnThoat.Location = new System.Drawing.Point(405, 141);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 56);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgvpn1madg});
            this.dgv.Location = new System.Drawing.Point(-3, 218);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(542, 223);
            this.dgv.TabIndex = 8;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTL";
            this.Column1.HeaderText = "Mã Thể Loại";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvpn1madg
            // 
            this.dgvpn1madg.DataPropertyName = "TenTL";
            this.dgvpn1madg.HeaderText = "Tên Thể Loại";
            this.dgvpn1madg.Name = "dgvpn1madg";
            // 
            // bttqlnvxoa
            // 
            this.bttqlnvxoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttqlnvxoa.Image = global::QL_THUVIEN2.Properties.Resources.window_remove;
            this.bttqlnvxoa.Location = new System.Drawing.Point(13, 156);
            this.bttqlnvxoa.Name = "bttqlnvxoa";
            this.bttqlnvxoa.Size = new System.Drawing.Size(134, 55);
            this.bttqlnvxoa.TabIndex = 26;
            this.bttqlnvxoa.Text = "Xóa";
            this.bttqlnvxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttqlnvxoa.UseVisualStyleBackColor = true;
            this.bttqlnvxoa.Click += new System.EventHandler(this.bttqlnvxoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.Image = global::QL_THUVIEN2.Properties.Resources.window_edit;
            this.btnSua.Location = new System.Drawing.Point(13, 85);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 62);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // bttthemmoi
            // 
            this.bttthemmoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttthemmoi.Image = global::QL_THUVIEN2.Properties.Resources.window_add;
            this.bttthemmoi.Location = new System.Drawing.Point(14, 16);
            this.bttthemmoi.Name = "bttthemmoi";
            this.bttthemmoi.Size = new System.Drawing.Size(133, 56);
            this.bttthemmoi.TabIndex = 23;
            this.bttthemmoi.Text = "Thêm Mới";
            this.bttthemmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttthemmoi.UseVisualStyleBackColor = true;
            this.bttthemmoi.Click += new System.EventHandler(this.bttthemmoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thể Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thể Loại";
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 442);
            this.Controls.Add(this.panel1);
            this.Name = "frmTheLoai";
            this.Text = "Thể Loại";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bttqlnvxoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button bttthemmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpn1madg;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox ma;
    }
}