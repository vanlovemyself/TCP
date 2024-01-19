namespace TEST_TCP
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
            this.label1 = new System.Windows.Forms.Label();
            this.adrbox = new System.Windows.Forms.TextBox();
            this.portbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_led1 = new System.Windows.Forms.Button();
            this.btn_led2 = new System.Windows.Forms.Button();
            this.btn_led3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_cnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(217, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIAO TIẾP TCP/IP ESP";
            // 
            // adrbox
            // 
            this.adrbox.Location = new System.Drawing.Point(194, 131);
            this.adrbox.Name = "adrbox";
            this.adrbox.Size = new System.Drawing.Size(155, 20);
            this.adrbox.TabIndex = 1;
            // 
            // portbox
            // 
            this.portbox.Location = new System.Drawing.Point(465, 131);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(64, 20);
            this.portbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(93, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ANDRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(403, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "PORT";
            // 
            // btn_led1
            // 
            this.btn_led1.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_led1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_led1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_led1.Location = new System.Drawing.Point(182, 319);
            this.btn_led1.Name = "btn_led1";
            this.btn_led1.Size = new System.Drawing.Size(66, 48);
            this.btn_led1.TabIndex = 5;
            this.btn_led1.Text = "ON";
            this.btn_led1.UseVisualStyleBackColor = false;
            this.btn_led1.Click += new System.EventHandler(this.btn_led1_Click);
            // 
            // btn_led2
            // 
            this.btn_led2.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_led2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_led2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_led2.Location = new System.Drawing.Point(366, 319);
            this.btn_led2.Name = "btn_led2";
            this.btn_led2.Size = new System.Drawing.Size(66, 48);
            this.btn_led2.TabIndex = 6;
            this.btn_led2.Text = "ON";
            this.btn_led2.UseVisualStyleBackColor = false;
            this.btn_led2.Click += new System.EventHandler(this.btn_led2_Click);
            // 
            // btn_led3
            // 
            this.btn_led3.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_led3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_led3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_led3.Location = new System.Drawing.Point(543, 319);
            this.btn_led3.Name = "btn_led3";
            this.btn_led3.Size = new System.Drawing.Size(66, 48);
            this.btn_led3.TabIndex = 7;
            this.btn_led3.Text = "ON";
            this.btn_led3.UseVisualStyleBackColor = false;
            this.btn_led3.Click += new System.EventHandler(this.btn_led3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TEST_TCP.Properties.Resources.lightoff1;
            this.pictureBox1.Location = new System.Drawing.Point(153, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 100);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TEST_TCP.Properties.Resources.lightoff1;
            this.pictureBox2.Location = new System.Drawing.Point(337, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 100);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TEST_TCP.Properties.Resources.lightoff1;
            this.pictureBox3.Location = new System.Drawing.Point(513, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 100);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btn_cnt
            // 
            this.btn_cnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cnt.Location = new System.Drawing.Point(558, 128);
            this.btn_cnt.Name = "btn_cnt";
            this.btn_cnt.Size = new System.Drawing.Size(75, 23);
            this.btn_cnt.TabIndex = 11;
            this.btn_cnt.Text = "CONNECT";
            this.btn_cnt.UseVisualStyleBackColor = true;
            this.btn_cnt.Click += new System.EventHandler(this.btn_cnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_led3);
            this.Controls.Add(this.btn_led2);
            this.Controls.Add(this.btn_led1);
            this.Controls.Add(this.btn_cnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portbox);
            this.Controls.Add(this.adrbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adrbox;
        private System.Windows.Forms.TextBox portbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_led1;
        private System.Windows.Forms.Button btn_led2;
        private System.Windows.Forms.Button btn_led3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_cnt;
    }
}

