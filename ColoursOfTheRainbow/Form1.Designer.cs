namespace ColoursOfTheRainbow
{
    partial class Main
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
            this.btn_ShowList = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddColour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3_AddName = new System.Windows.Forms.TextBox();
            this.textBox4_AddHex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1_AddRGB = new System.Windows.Forms.TextBox();
            this.listView1_showColour = new System.Windows.Forms.ListView();
            this.column1_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2_hex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column3_rgb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1_colourSample = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_colourSample)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ShowList
            // 
            this.btn_ShowList.Location = new System.Drawing.Point(385, 116);
            this.btn_ShowList.Name = "btn_ShowList";
            this.btn_ShowList.Size = new System.Drawing.Size(107, 23);
            this.btn_ShowList.TabIndex = 0;
            this.btn_ShowList.Text = "Show List";
            this.btn_ShowList.UseVisualStyleBackColor = true;
            this.btn_ShowList.Click += new System.EventHandler(this.btn_ShowList_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(170, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(197, 22);
            this.title.TabIndex = 1;
            this.title.Text = "Colours of the Rainbow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Display list of colours in database: ";
            // 
            // btn_AddColour
            // 
            this.btn_AddColour.Location = new System.Drawing.Point(213, 302);
            this.btn_AddColour.Name = "btn_AddColour";
            this.btn_AddColour.Size = new System.Drawing.Size(132, 23);
            this.btn_AddColour.TabIndex = 9;
            this.btn_AddColour.Text = "Add Colour";
            this.btn_AddColour.UseVisualStyleBackColor = true;
            this.btn_AddColour.Click += new System.EventHandler(this.btn_AddColour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Colour to Database";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Colour Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Colour HEX code";
            // 
            // textBox3_AddName
            // 
            this.textBox3_AddName.Location = new System.Drawing.Point(52, 259);
            this.textBox3_AddName.Name = "textBox3_AddName";
            this.textBox3_AddName.Size = new System.Drawing.Size(134, 20);
            this.textBox3_AddName.TabIndex = 13;
            // 
            // textBox4_AddHex
            // 
            this.textBox4_AddHex.Location = new System.Drawing.Point(218, 259);
            this.textBox4_AddHex.MaxLength = 7;
            this.textBox4_AddHex.Name = "textBox4_AddHex";
            this.textBox4_AddHex.Size = new System.Drawing.Size(127, 20);
            this.textBox4_AddHex.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Colour RGB code";
            // 
            // textBox1_AddRGB
            // 
            this.textBox1_AddRGB.Location = new System.Drawing.Point(384, 259);
            this.textBox1_AddRGB.MaxLength = 11;
            this.textBox1_AddRGB.Name = "textBox1_AddRGB";
            this.textBox1_AddRGB.Size = new System.Drawing.Size(127, 20);
            this.textBox1_AddRGB.TabIndex = 16;
            // 
            // listView1_showColour
            // 
            this.listView1_showColour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1_name,
            this.column2_hex,
            this.column3_rgb});
            this.listView1_showColour.FullRowSelect = true;
            this.listView1_showColour.HideSelection = false;
            this.listView1_showColour.Location = new System.Drawing.Point(52, 366);
            this.listView1_showColour.Name = "listView1_showColour";
            this.listView1_showColour.Size = new System.Drawing.Size(456, 163);
            this.listView1_showColour.TabIndex = 17;
            this.listView1_showColour.UseCompatibleStateImageBehavior = false;
            this.listView1_showColour.View = System.Windows.Forms.View.Details;
            this.listView1_showColour.SelectedIndexChanged += new System.EventHandler(this.listView1_showColour_SelectedIndexChanged_1);
            // 
            // column1_name
            // 
            this.column1_name.Text = "Colour Name";
            this.column1_name.Width = 150;
            // 
            // column2_hex
            // 
            this.column2_hex.Text = "Hex Code";
            this.column2_hex.Width = 150;
            // 
            // column3_rgb
            // 
            this.column3_rgb.Text = "RGB Code";
            this.column3_rgb.Width = 150;
            // 
            // pictureBox1_colourSample
            // 
            this.pictureBox1_colourSample.Location = new System.Drawing.Point(146, 559);
            this.pictureBox1_colourSample.Name = "pictureBox1_colourSample";
            this.pictureBox1_colourSample.Size = new System.Drawing.Size(265, 112);
            this.pictureBox1_colourSample.TabIndex = 18;
            this.pictureBox1_colourSample.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 710);
            this.Controls.Add(this.pictureBox1_colourSample);
            this.Controls.Add(this.listView1_showColour);
            this.Controls.Add(this.textBox1_AddRGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4_AddHex);
            this.Controls.Add(this.textBox3_AddName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddColour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_ShowList);
            this.Name = "Main";
            this.Text = "Colours of the Rainbow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_colourSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowList;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddColour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3_AddName;
        private System.Windows.Forms.TextBox textBox4_AddHex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1_AddRGB;
        private System.Windows.Forms.ListView listView1_showColour;
        private System.Windows.Forms.ColumnHeader column1_name;
        private System.Windows.Forms.ColumnHeader column2_hex;
        private System.Windows.Forms.ColumnHeader column3_rgb;
        private System.Windows.Forms.PictureBox pictureBox1_colourSample;
    }
}

