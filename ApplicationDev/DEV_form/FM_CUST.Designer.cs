
namespace DEV_form
{
    partial class FM_CUST
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
            this.groubBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPump = new System.Windows.Forms.RadioButton();
            this.rdbSang = new System.Windows.Forms.RadioButton();
            this.rdbJeol = new System.Windows.Forms.RadioButton();
            this.rdbCar = new System.Windows.Forms.RadioButton();
            this.chCOnly = new System.Windows.Forms.CheckBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groubBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groubBox1
            // 
            this.groubBox1.Controls.Add(this.label6);
            this.groubBox1.Controls.Add(this.groupBox1);
            this.groubBox1.Controls.Add(this.chCOnly);
            this.groubBox1.Controls.Add(this.dtpEnd);
            this.groubBox1.Controls.Add(this.dtpStart);
            this.groubBox1.Controls.Add(this.btnSearch);
            this.groubBox1.Controls.Add(this.txtCustCode);
            this.groubBox1.Controls.Add(this.txtCustName);
            this.groubBox1.Controls.Add(this.label3);
            this.groubBox1.Controls.Add(this.label5);
            this.groubBox1.Controls.Add(this.label1);
            this.groubBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groubBox1.Location = new System.Drawing.Point(0, 0);
            this.groubBox1.Name = "groubBox1";
            this.groubBox1.Size = new System.Drawing.Size(1451, 172);
            this.groubBox1.TabIndex = 0;
            this.groubBox1.TabStop = false;
            this.groubBox1.Text = "거래처조회";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(848, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "~";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPump);
            this.groupBox1.Controls.Add(this.rdbSang);
            this.groupBox1.Controls.Add(this.rdbJeol);
            this.groupBox1.Controls.Add(this.rdbCar);
            this.groupBox1.Location = new System.Drawing.Point(223, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "종목";
            // 
            // rdbPump
            // 
            this.rdbPump.AutoSize = true;
            this.rdbPump.Location = new System.Drawing.Point(334, 26);
            this.rdbPump.Name = "rdbPump";
            this.rdbPump.Size = new System.Drawing.Size(105, 24);
            this.rdbPump.TabIndex = 9;
            this.rdbPump.TabStop = true;
            this.rdbPump.Text = "펌프압축기";
            this.rdbPump.UseVisualStyleBackColor = true;
            // 
            // rdbSang
            // 
            this.rdbSang.AutoSize = true;
            this.rdbSang.Location = new System.Drawing.Point(6, 26);
            this.rdbSang.Name = "rdbSang";
            this.rdbSang.Size = new System.Drawing.Size(110, 24);
            this.rdbSang.TabIndex = 5;
            this.rdbSang.TabStop = true;
            this.rdbSang.Text = "상용차 부품";
            this.rdbSang.UseVisualStyleBackColor = true;
            // 
            // rdbJeol
            // 
            this.rdbJeol.AutoSize = true;
            this.rdbJeol.Location = new System.Drawing.Point(238, 26);
            this.rdbJeol.Name = "rdbJeol";
            this.rdbJeol.Size = new System.Drawing.Size(90, 24);
            this.rdbJeol.TabIndex = 6;
            this.rdbJeol.TabStop = true;
            this.rdbJeol.Text = "절삭가공";
            this.rdbJeol.UseVisualStyleBackColor = true;
            // 
            // rdbCar
            // 
            this.rdbCar.AutoSize = true;
            this.rdbCar.Location = new System.Drawing.Point(122, 26);
            this.rdbCar.Name = "rdbCar";
            this.rdbCar.Size = new System.Drawing.Size(110, 24);
            this.rdbCar.TabIndex = 8;
            this.rdbCar.TabStop = true;
            this.rdbCar.Text = "자동차 부품";
            this.rdbCar.UseVisualStyleBackColor = true;
            // 
            // chCOnly
            // 
            this.chCOnly.AutoSize = true;
            this.chCOnly.Location = new System.Drawing.Point(60, 80);
            this.chCOnly.Name = "chCOnly";
            this.chCOnly.Size = new System.Drawing.Size(126, 24);
            this.chCOnly.TabIndex = 4;
            this.chCOnly.Text = "고객사만 검색";
            this.chCOnly.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(874, 28);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(142, 27);
            this.dtpEnd.TabIndex = 2;
            this.dtpEnd.UseWaitCursor = true;
            this.dtpEnd.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(700, 27);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(142, 27);
            this.dtpStart.TabIndex = 2;
            this.dtpStart.UseWaitCursor = true;
            this.dtpStart.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(717, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(129, 31);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(187, 27);
            this.txtCustCode.TabIndex = 1;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(413, 32);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(187, 27);
            this.txtCustName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "거래처코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "거래일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "거래처명";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.dgvGrid);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1451, 584);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "거래처정보";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(109, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvGrid
            // 
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGrid.Location = new System.Drawing.Point(3, 72);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 29;
            this.dgvGrid.Size = new System.Drawing.Size(1445, 509);
            this.dgvGrid.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FM_CUST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 775);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groubBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_CUST";
            this.Text = "거래처 조회";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fm_cust_load);
            this.groubBox1.ResumeLayout(false);
            this.groubBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groubBox1;
        private System.Windows.Forms.RadioButton rdbSang;
        private System.Windows.Forms.CheckBox chCOnly;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.RadioButton rdbPump;
        private System.Windows.Forms.RadioButton rdbJeol;
        private System.Windows.Forms.RadioButton rdbCar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}