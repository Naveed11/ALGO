namespace sorting_algo
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
			this.btnrandom = new System.Windows.Forms.Button();
			this.btnbubble = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblrandom = new System.Windows.Forms.Label();
			this.lblsort = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rtime = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnrandom
			// 
			this.btnrandom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnrandom.Location = new System.Drawing.Point(12, 259);
			this.btnrandom.Name = "btnrandom";
			this.btnrandom.Size = new System.Drawing.Size(214, 38);
			this.btnrandom.TabIndex = 1;
			this.btnrandom.Text = "Create Random Array";
			this.btnrandom.UseVisualStyleBackColor = true;
			this.btnrandom.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnbubble
			// 
			this.btnbubble.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnbubble.Location = new System.Drawing.Point(12, 303);
			this.btnbubble.Name = "btnbubble";
			this.btnbubble.Size = new System.Drawing.Size(214, 38);
			this.btnbubble.TabIndex = 2;
			this.btnbubble.Text = "Bubble Sort";
			this.btnbubble.UseVisualStyleBackColor = true;
			this.btnbubble.Click += new System.EventHandler(this.btnbubble_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Array Size";
			// 
			// lblrandom
			// 
			this.lblrandom.AutoSize = true;
			this.lblrandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblrandom.Location = new System.Drawing.Point(220, 21);
			this.lblrandom.Name = "lblrandom";
			this.lblrandom.Size = new System.Drawing.Size(0, 16);
			this.lblrandom.TabIndex = 5;
			// 
			// lblsort
			// 
			this.lblsort.AutoSize = true;
			this.lblsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsort.Location = new System.Drawing.Point(132, 355);
			this.lblsort.Name = "lblsort";
			this.lblsort.Size = new System.Drawing.Size(0, 16);
			this.lblsort.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Sorted Array";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(14, 351);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(212, 39);
			this.button1.TabIndex = 11;
			this.button1.Text = "Insertion Sort";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listView1.Location = new System.Drawing.Point(523, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(352, 486);
			this.listView1.TabIndex = 14;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(145, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 22);
			this.label2.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(139, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 21);
			this.label3.TabIndex = 16;
			// 
			// rtime
			// 
			this.rtime.AutoSize = true;
			this.rtime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtime.Location = new System.Drawing.Point(5, 166);
			this.rtime.Name = "rtime";
			this.rtime.Size = new System.Drawing.Size(114, 21);
			this.rtime.TabIndex = 17;
			this.rtime.Text = "Running Time";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(145, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 21);
			this.label5.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(367, 259);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "label6";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 514);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.rtime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblsort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblrandom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnbubble);
			this.Controls.Add(this.btnrandom);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnrandom;
		private System.Windows.Forms.Button btnbubble;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblrandom;
		private System.Windows.Forms.Label lblsort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Index;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label rtime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}

