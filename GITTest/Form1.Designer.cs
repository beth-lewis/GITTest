namespace GITTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBeth = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dMU_BoxDataSet = new GITTest.DMU_BoxDataSet();
            this.tblHallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHallTableAdapter = new GITTest.DMU_BoxDataSetTableAdapters.tblHallTableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.concertTicketsDataSet = new GITTest.ConcertTicketsDataSet();
            this.tblTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTicketTableAdapter = new GITTest.ConcertTicketsDataSetTableAdapters.tblTicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dMU_BoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertTicketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git clone and pull test DOM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "BranchTest";
            // 
            // lblBeth
            // 
            this.lblBeth.AutoSize = true;
            this.lblBeth.Location = new System.Drawing.Point(65, 223);
            this.lblBeth.Name = "lblBeth";
            this.lblBeth.Size = new System.Drawing.Size(28, 13);
            this.lblBeth.TabIndex = 4;
            this.lblBeth.Text = "beth";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tblHallBindingSource;
            this.listBox1.DisplayMember = "HallName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(241, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            this.listBox1.ValueMember = "HallName";
            // 
            // dMU_BoxDataSet
            // 
            this.dMU_BoxDataSet.DataSetName = "DMU_BoxDataSet";
            this.dMU_BoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHallBindingSource
            // 
            this.tblHallBindingSource.DataMember = "tblHall";
            this.tblHallBindingSource.DataSource = this.dMU_BoxDataSet;
            // 
            // tblHallTableAdapter
            // 
            this.tblHallTableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.tblTicketBindingSource;
            this.listBox2.DisplayMember = "Artist";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(367, 36);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 6;
            this.listBox2.ValueMember = "Artist";
            // 
            // concertTicketsDataSet
            // 
            this.concertTicketsDataSet.DataSetName = "ConcertTicketsDataSet";
            this.concertTicketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTicketBindingSource
            // 
            this.tblTicketBindingSource.DataMember = "tblTicket";
            this.tblTicketBindingSource.DataSource = this.concertTicketsDataSet;
            // 
            // tblTicketTableAdapter
            // 
            this.tblTicketTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 373);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblBeth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMU_BoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertTicketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTicketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBeth;
        private System.Windows.Forms.ListBox listBox1;
        private DMU_BoxDataSet dMU_BoxDataSet;
        private System.Windows.Forms.BindingSource tblHallBindingSource;
        private DMU_BoxDataSetTableAdapters.tblHallTableAdapter tblHallTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private ConcertTicketsDataSet concertTicketsDataSet;
        private System.Windows.Forms.BindingSource tblTicketBindingSource;
        private ConcertTicketsDataSetTableAdapters.tblTicketTableAdapter tblTicketTableAdapter;
    }
}

