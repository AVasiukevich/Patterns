namespace Task_4
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
            this.pct_main = new System.Windows.Forms.PictureBox();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_negative = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_main
            // 
            this.pct_main.Location = new System.Drawing.Point(12, 12);
            this.pct_main.Name = "pct_main";
            this.pct_main.Size = new System.Drawing.Size(399, 239);
            this.pct_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_main.TabIndex = 0;
            this.pct_main.TabStop = false;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(12, 257);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(93, 257);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(336, 257);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(174, 257);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_negative
            // 
            this.btn_negative.Location = new System.Drawing.Point(255, 257);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(75, 23);
            this.btn_negative.TabIndex = 5;
            this.btn_negative.Text = "Negative";
            this.btn_negative.UseVisualStyleBackColor = true;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 292);
            this.Controls.Add(this.btn_negative);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.pct_main);
            this.Name = "MainForm";
            this.Text = "EditImage";
            ((System.ComponentModel.ISupportInitialize)(this.pct_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_main;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_negative;
    }
}

