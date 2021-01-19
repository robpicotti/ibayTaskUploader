namespace ibayTaskUploader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmdUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.cmdAll = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvOppDetail = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblOpp = new System.Windows.Forms.Label();
            this.txtOpp = new System.Windows.Forms.TextBox();
            this.lblProj = new System.Windows.Forms.Label();
            this.txtProj = new System.Windows.Forms.TextBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOppDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 618);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblWork);
            this.panel4.Controls.Add(this.txtWork);
            this.panel4.Controls.Add(this.lblProj);
            this.panel4.Controls.Add(this.txtProj);
            this.panel4.Controls.Add(this.lblOpp);
            this.panel4.Controls.Add(this.txtOpp);
            this.panel4.Controls.Add(this.lblClient);
            this.panel4.Controls.Add(this.txtClient);
            this.panel4.Controls.Add(this.cmdAll);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 267);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1401, 39);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1401, 220);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(1401, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.cmdUpload);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1401, 47);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1309, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(309, 14);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(994, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // cmdUpload
            // 
            this.cmdUpload.BackColor = System.Drawing.Color.Lime;
            this.cmdUpload.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpload.Location = new System.Drawing.Point(139, 9);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(139, 32);
            this.cmdUpload.TabIndex = 2;
            this.cmdUpload.Text = "Upload to database";
            this.cmdUpload.UseVisualStyleBackColor = false;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Task File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvAll);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 306);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(992, 312);
            this.panel5.TabIndex = 3;
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
            // 
            // dgvAll
            // 
            this.dgvAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAll.EnableHeadersVisualStyles = false;
            this.dgvAll.Location = new System.Drawing.Point(0, 0);
            this.dgvAll.MultiSelect = false;
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.Size = new System.Drawing.Size(990, 310);
            this.dgvAll.TabIndex = 0;
            this.dgvAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAll_MouseClick);
            // 
            // cmdAll
            // 
            this.cmdAll.BackColor = System.Drawing.Color.Black;
            this.cmdAll.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAll.ForeColor = System.Drawing.Color.White;
            this.cmdAll.Location = new System.Drawing.Point(12, 3);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(93, 30);
            this.cmdAll.TabIndex = 0;
            this.cmdAll.Text = "Get Jobs";
            this.cmdAll.UseVisualStyleBackColor = false;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.dgvOppDetail);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(992, 306);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(409, 312);
            this.panel6.TabIndex = 4;
            // 
            // dgvOppDetail
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOppDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOppDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOppDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOppDetail.EnableHeadersVisualStyles = false;
            this.dgvOppDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvOppDetail.MultiSelect = false;
            this.dgvOppDetail.Name = "dgvOppDetail";
            this.dgvOppDetail.ReadOnly = true;
            this.dgvOppDetail.Size = new System.Drawing.Size(407, 310);
            this.dgvOppDetail.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(18, 310);
            this.panel7.TabIndex = 1;
            // 
            // txtClient
            // 
            this.txtClient.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(177, 12);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 1;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(126, 15);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(40, 14);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "client:";
            // 
            // lblOpp
            // 
            this.lblOpp.AutoSize = true;
            this.lblOpp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpp.Location = new System.Drawing.Point(300, 15);
            this.lblOpp.Name = "lblOpp";
            this.lblOpp.Size = new System.Drawing.Size(74, 14);
            this.lblOpp.TabIndex = 4;
            this.lblOpp.Text = "opportunity:";
            // 
            // txtOpp
            // 
            this.txtOpp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpp.Location = new System.Drawing.Point(380, 12);
            this.txtOpp.Name = "txtOpp";
            this.txtOpp.Size = new System.Drawing.Size(100, 20);
            this.txtOpp.TabIndex = 3;
            this.txtOpp.TextChanged += new System.EventHandler(this.txtOpp_TextChanged);
            // 
            // lblProj
            // 
            this.lblProj.AutoSize = true;
            this.lblProj.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProj.Location = new System.Drawing.Point(518, 16);
            this.lblProj.Name = "lblProj";
            this.lblProj.Size = new System.Drawing.Size(76, 14);
            this.lblProj.TabIndex = 6;
            this.lblProj.Text = "project type:";
            // 
            // txtProj
            // 
            this.txtProj.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProj.Location = new System.Drawing.Point(598, 13);
            this.txtProj.Name = "txtProj";
            this.txtProj.Size = new System.Drawing.Size(100, 20);
            this.txtProj.TabIndex = 5;
            this.txtProj.TextChanged += new System.EventHandler(this.txtProj_TextChanged);
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWork.Location = new System.Drawing.Point(742, 16);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(66, 14);
            this.lblWork.TabIndex = 8;
            this.lblWork.Text = "work type:";
            // 
            // txtWork
            // 
            this.txtWork.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWork.Location = new System.Drawing.Point(822, 13);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(100, 20);
            this.txtWork.TabIndex = 7;
            this.txtWork.TextChanged += new System.EventHandler(this.txtWork_TextChanged);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 207);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1401, 13);
            this.panel8.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 618);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ibay Task uploader";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOppDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.Button cmdAll;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvOppDetail;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblOpp;
        private System.Windows.Forms.TextBox txtOpp;
        private System.Windows.Forms.Label lblProj;
        private System.Windows.Forms.TextBox txtProj;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.Panel panel8;
    }
}

