namespace TrackViewTest
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cms_tvTrack = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label_selected = new System.Windows.Forms.Label();
            this.lbl_ClickResult = new System.Windows.Forms.Label();
            this.lbl_Loca = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_AddPrj = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.label_x = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbProjector = new System.Windows.Forms.PictureBox();
            this.tv_Projector = new System.Windows.Forms.TreeView();
            this.cms_tvPrj = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cms_tvTrack.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjector)).BeginInit();
            this.cms_tvPrj.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(426, 184);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 382);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.cms_tvTrack;
            this.treeView1.Location = new System.Drawing.Point(26, 25);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(346, 540);
            this.treeView1.TabIndex = 1;
            // 
            // cms_tvTrack
            // 
            this.cms_tvTrack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.cms_tvTrack.Name = "cms_tvPrj";
            this.cms_tvTrack.Size = new System.Drawing.Size(173, 28);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.addToolStripMenuItem.Text = "Add Projector";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(273, 574);
            this.btnAddTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(99, 26);
            this.btnAddTrack.TabIndex = 2;
            this.btnAddTrack.Text = "Add Track";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btn_AddTrak_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(426, 570);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(934, 17);
            this.hScrollBar1.TabIndex = 4;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1363, 184);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 381);
            this.vScrollBar1.TabIndex = 5;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label_selected
            // 
            this.label_selected.AutoSize = true;
            this.label_selected.Location = new System.Drawing.Point(1133, 130);
            this.label_selected.Name = "label_selected";
            this.label_selected.Size = new System.Drawing.Size(74, 15);
            this.label_selected.TabIndex = 6;
            this.label_selected.Text = "Selected :";
            // 
            // lbl_ClickResult
            // 
            this.lbl_ClickResult.AutoSize = true;
            this.lbl_ClickResult.Location = new System.Drawing.Point(1210, 130);
            this.lbl_ClickResult.Name = "lbl_ClickResult";
            this.lbl_ClickResult.Size = new System.Drawing.Size(45, 15);
            this.lbl_ClickResult.TabIndex = 8;
            this.lbl_ClickResult.Text = "label2";
            // 
            // lbl_Loca
            // 
            this.lbl_Loca.AutoSize = true;
            this.lbl_Loca.Location = new System.Drawing.Point(1290, 130);
            this.lbl_Loca.Name = "lbl_Loca";
            this.lbl_Loca.Size = new System.Drawing.Size(45, 15);
            this.lbl_Loca.TabIndex = 9;
            this.lbl_Loca.Text = "label2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1432, 712);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.lbl_Loca);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lbl_ClickResult);
            this.tabPage1.Controls.Add(this.hScrollBar1);
            this.tabPage1.Controls.Add(this.label_selected);
            this.tabPage1.Controls.Add(this.vScrollBar1);
            this.tabPage1.Controls.Add(this.btnAddTrack);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1424, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_AddPrj);
            this.tabPage2.Controls.Add(this.btn_View);
            this.tabPage2.Controls.Add(this.label_x);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.tv_Projector);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1424, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_AddPrj
            // 
            this.btn_AddPrj.Location = new System.Drawing.Point(246, 460);
            this.btn_AddPrj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddPrj.Name = "btn_AddPrj";
            this.btn_AddPrj.Size = new System.Drawing.Size(86, 29);
            this.btn_AddPrj.TabIndex = 7;
            this.btn_AddPrj.Text = "Add";
            this.btn_AddPrj.UseVisualStyleBackColor = true;
            this.btn_AddPrj.Click += new System.EventHandler(this.btn_AddPrj_Click);
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(246, 580);
            this.btn_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(86, 29);
            this.btn_View.TabIndex = 6;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(194, 550);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(16, 15);
            this.label_x.TabIndex = 5;
            this.label_x.Text = "X";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 546);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 25);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 546);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 25);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 496);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbProjector);
            this.groupBox1.Location = new System.Drawing.Point(371, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1027, 611);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projector Layout";
            // 
            // pbProjector
            // 
            this.pbProjector.Location = new System.Drawing.Point(7, 25);
            this.pbProjector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbProjector.Name = "pbProjector";
            this.pbProjector.Size = new System.Drawing.Size(1014, 579);
            this.pbProjector.TabIndex = 6;
            this.pbProjector.TabStop = false;
            this.pbProjector.Paint += new System.Windows.Forms.PaintEventHandler(this.pbProjector_Paint);
            // 
            // tv_Projector
            // 
            this.tv_Projector.Location = new System.Drawing.Point(59, 45);
            this.tv_Projector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tv_Projector.Name = "tv_Projector";
            this.tv_Projector.Size = new System.Drawing.Size(271, 406);
            this.tv_Projector.TabIndex = 0;
            this.tv_Projector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tv_Projector_MouseUp);
            // 
            // cms_tvPrj
            // 
            this.cms_tvPrj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cms_tvPrj.Name = "cms_tvPrj";
            this.cms_tvPrj.Size = new System.Drawing.Size(189, 56);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.deleteToolStripMenuItem.Text = "Delete Projector";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 720);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cms_tvTrack.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProjector)).EndInit();
            this.cms_tvPrj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label_selected;
        private System.Windows.Forms.Label lbl_ClickResult;
        private System.Windows.Forms.Label lbl_Loca;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbProjector;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.TreeView tv_Projector;
        private System.Windows.Forms.Button btn_AddPrj;
        private System.Windows.Forms.ContextMenuStrip cms_tvTrack;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_tvPrj;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

