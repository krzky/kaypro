namespace Trial1KayPro
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sendbtn = new System.Windows.Forms.Button();
            this.menubtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gudebtn = new System.Windows.Forms.Button();
            this.literaturebtn = new System.Windows.Forms.Button();
            this.pwrbox = new System.Windows.Forms.TextBox();
            this.wattbox = new System.Windows.Forms.TextBox();
            this.ampbox = new System.Windows.Forms.TextBox();
            this.voltbox = new System.Windows.Forms.TextBox();
            this.pwrlbl = new System.Windows.Forms.Label();
            this.wattlbl = new System.Windows.Forms.Label();
            this.amplbl = new System.Windows.Forms.Label();
            this.voltlbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.sendbtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.menubtn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(780, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(128, 116);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // sendbtn
            // 
            this.sendbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendbtn.Location = new System.Drawing.Point(3, 3);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(58, 110);
            this.sendbtn.TabIndex = 0;
            this.sendbtn.Text = "SEND";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // menubtn
            // 
            this.menubtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menubtn.Location = new System.Drawing.Point(67, 3);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(58, 110);
            this.menubtn.TabIndex = 1;
            this.menubtn.Text = "MENU";
            this.menubtn.UseVisualStyleBackColor = true;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 495);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // refreshtimer
            // 
            this.refreshtimer.Enabled = true;
            this.refreshtimer.Interval = 1000;
            this.refreshtimer.Tick += new System.EventHandler(this.refreshtimer_Tick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.gudebtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.literaturebtn, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(911, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(192, 116);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // gudebtn
            // 
            this.gudebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gudebtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gudebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gudebtn.Location = new System.Drawing.Point(3, 3);
            this.gudebtn.Name = "gudebtn";
            this.gudebtn.Size = new System.Drawing.Size(186, 52);
            this.gudebtn.TabIndex = 3;
            this.gudebtn.Text = "POWER GUIDE";
            this.gudebtn.UseVisualStyleBackColor = false;
            // 
            // literaturebtn
            // 
            this.literaturebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.literaturebtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.literaturebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.literaturebtn.Location = new System.Drawing.Point(3, 61);
            this.literaturebtn.Name = "literaturebtn";
            this.literaturebtn.Size = new System.Drawing.Size(186, 52);
            this.literaturebtn.TabIndex = 2;
            this.literaturebtn.Text = "LITERATURE";
            this.literaturebtn.UseVisualStyleBackColor = false;
            this.literaturebtn.Click += new System.EventHandler(this.literaturebtn_Click);
            // 
            // pwrbox
            // 
            this.pwrbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwrbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwrbox.Location = new System.Drawing.Point(109, 90);
            this.pwrbox.Multiline = true;
            this.pwrbox.Name = "pwrbox";
            this.pwrbox.Size = new System.Drawing.Size(647, 20);
            this.pwrbox.TabIndex = 7;
            this.pwrbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wattbox
            // 
            this.wattbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wattbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wattbox.Enabled = false;
            this.wattbox.Location = new System.Drawing.Point(109, 62);
            this.wattbox.Multiline = true;
            this.wattbox.Name = "wattbox";
            this.wattbox.Size = new System.Drawing.Size(647, 19);
            this.wattbox.TabIndex = 6;
            this.wattbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ampbox
            // 
            this.ampbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ampbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ampbox.Enabled = false;
            this.ampbox.Location = new System.Drawing.Point(109, 34);
            this.ampbox.Multiline = true;
            this.ampbox.Name = "ampbox";
            this.ampbox.Size = new System.Drawing.Size(647, 19);
            this.ampbox.TabIndex = 5;
            this.ampbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // voltbox
            // 
            this.voltbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voltbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voltbox.Enabled = false;
            this.voltbox.Location = new System.Drawing.Point(109, 6);
            this.voltbox.Multiline = true;
            this.voltbox.Name = "voltbox";
            this.voltbox.Size = new System.Drawing.Size(647, 19);
            this.voltbox.TabIndex = 4;
            this.voltbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pwrlbl
            // 
            this.pwrlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pwrlbl.AutoSize = true;
            this.pwrlbl.Location = new System.Drawing.Point(6, 87);
            this.pwrlbl.Name = "pwrlbl";
            this.pwrlbl.Size = new System.Drawing.Size(94, 26);
            this.pwrlbl.TabIndex = 3;
            this.pwrlbl.Text = "HIGHLIGHTED POWER";
            this.pwrlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pwrlbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // wattlbl
            // 
            this.wattlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wattlbl.AutoSize = true;
            this.wattlbl.Location = new System.Drawing.Point(6, 65);
            this.wattlbl.Name = "wattlbl";
            this.wattlbl.Size = new System.Drawing.Size(94, 13);
            this.wattlbl.TabIndex = 2;
            this.wattlbl.Text = "WATT";
            this.wattlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wattlbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // amplbl
            // 
            this.amplbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amplbl.AutoSize = true;
            this.amplbl.Location = new System.Drawing.Point(6, 37);
            this.amplbl.Name = "amplbl";
            this.amplbl.Size = new System.Drawing.Size(94, 13);
            this.amplbl.TabIndex = 1;
            this.amplbl.Text = "AMPERE";
            this.amplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.amplbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // voltlbl
            // 
            this.voltlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.voltlbl.AutoSize = true;
            this.voltlbl.Location = new System.Drawing.Point(6, 9);
            this.voltlbl.Name = "voltlbl";
            this.voltlbl.Size = new System.Drawing.Size(94, 13);
            this.voltlbl.TabIndex = 0;
            this.voltlbl.Text = "VOLTAGE";
            this.voltlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.voltlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.voltlbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.amplbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.wattlbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pwrlbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.voltbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ampbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.wattbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pwrbox, 1, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1110, 641);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "KzPRO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer refreshtimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button gudebtn;
        private System.Windows.Forms.Button literaturebtn;
        private System.Windows.Forms.TextBox pwrbox;
        private System.Windows.Forms.TextBox wattbox;
        private System.Windows.Forms.TextBox ampbox;
        private System.Windows.Forms.TextBox voltbox;
        private System.Windows.Forms.Label pwrlbl;
        private System.Windows.Forms.Label wattlbl;
        private System.Windows.Forms.Label amplbl;
        private System.Windows.Forms.Label voltlbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

