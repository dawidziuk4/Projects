namespace Pikselator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureOriginal = new System.Windows.Forms.PictureBox();
            this.picturePixelated = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPixelate = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePixelated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.Location = new System.Drawing.Point(12, 22);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(620, 432);
            this.pictureOriginal.TabIndex = 0;
            this.pictureOriginal.TabStop = false;
            // 
            // picturePixelated
            // 
            this.picturePixelated.Location = new System.Drawing.Point(735, 22);
            this.picturePixelated.Name = "picturePixelated";
            this.picturePixelated.Size = new System.Drawing.Size(620, 432);
            this.picturePixelated.TabIndex = 1;
            this.picturePixelated.TabStop = false;
            this.picturePixelated.Click += new System.EventHandler(this.PicturePixelated_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(60, 560);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(263, 154);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnPixelate
            // 
            this.btnPixelate.Location = new System.Drawing.Point(998, 560);
            this.btnPixelate.Name = "btnPixelate";
            this.btnPixelate.Size = new System.Drawing.Size(263, 154);
            this.btnPixelate.TabIndex = 3;
            this.btnPixelate.Text = "Pixelate";
            this.btnPixelate.UseVisualStyleBackColor = true;
            this.btnPixelate.Click += new System.EventHandler(this.BtnPixelate_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(404, 693);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "Assembler";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(535, 693);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "C#";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(395, 560);
            this.trackBar.Maximum = 32;
            this.trackBar.Minimum = 4;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(186, 56);
            this.trackBar.TabIndex = 9;
            this.trackBar.TickFrequency = 8;
            this.trackBar.Value = 4;
            this.trackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose number of threads:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time:";
            this.label2.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "4";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(747, 560);
            this.trackBar1.Maximum = 99;
            this.trackBar1.Minimum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(218, 56);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TickFrequency = 3;
            this.trackBar1.Value = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(824, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "13";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Choose power of pixelation:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 800);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnPixelate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picturePixelated);
            this.Controls.Add(this.pictureOriginal);
            this.Name = "Form1";
            this.Text = "Pikselator by Dawid Dziuk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePixelated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOriginal;
        private System.Windows.Forms.PictureBox picturePixelated;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPixelate;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

