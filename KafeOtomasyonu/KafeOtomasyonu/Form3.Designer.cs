namespace KafeOtomasyonu
{
    partial class Form3
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
            this.nakit_btn = new System.Windows.Forms.Button();
            this.kkodeme_btn = new System.Windows.Forms.Button();
            this.kk_txt = new System.Windows.Forms.TextBox();
            this.giris_lbl = new System.Windows.Forms.Label();
            this.basarili_txt = new System.Windows.Forms.Label();
            this.ilerleme_pb = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nakit_btn
            // 
            this.nakit_btn.Location = new System.Drawing.Point(375, 58);
            this.nakit_btn.Name = "nakit_btn";
            this.nakit_btn.Size = new System.Drawing.Size(73, 42);
            this.nakit_btn.TabIndex = 0;
            this.nakit_btn.Text = "Nakit Ödeme";
            this.nakit_btn.UseVisualStyleBackColor = true;
            this.nakit_btn.Click += new System.EventHandler(this.nakit_btn_Click);
            // 
            // kkodeme_btn
            // 
            this.kkodeme_btn.Location = new System.Drawing.Point(242, 58);
            this.kkodeme_btn.Name = "kkodeme_btn";
            this.kkodeme_btn.Size = new System.Drawing.Size(69, 44);
            this.kkodeme_btn.TabIndex = 1;
            this.kkodeme_btn.Text = "Kredi Kartı ile ödeme";
            this.kkodeme_btn.UseVisualStyleBackColor = true;
            this.kkodeme_btn.Click += new System.EventHandler(this.kkodeme_btn_Click);
            // 
            // kk_txt
            // 
            this.kk_txt.Location = new System.Drawing.Point(44, 71);
            this.kk_txt.MaxLength = 16;
            this.kk_txt.Name = "kk_txt";
            this.kk_txt.Size = new System.Drawing.Size(154, 20);
            this.kk_txt.TabIndex = 2;
            // 
            // giris_lbl
            // 
            this.giris_lbl.AutoSize = true;
            this.giris_lbl.Location = new System.Drawing.Point(44, 52);
            this.giris_lbl.Name = "giris_lbl";
            this.giris_lbl.Size = new System.Drawing.Size(139, 13);
            this.giris_lbl.TabIndex = 3;
            this.giris_lbl.Text = "Kredi Kartı Numaranızı giriniz";
            // 
            // basarili_txt
            // 
            this.basarili_txt.AutoSize = true;
            this.basarili_txt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basarili_txt.Location = new System.Drawing.Point(27, 18);
            this.basarili_txt.Name = "basarili_txt";
            this.basarili_txt.Size = new System.Drawing.Size(619, 24);
            this.basarili_txt.TabIndex = 4;
            this.basarili_txt.Text = "Ödemeniz Başarıyla Tamamlandı Anasayfaya Yönlendiriliyorsunuz";
            // 
            // ilerleme_pb
            // 
            this.ilerleme_pb.Location = new System.Drawing.Point(31, 68);
            this.ilerleme_pb.Name = "ilerleme_pb";
            this.ilerleme_pb.Size = new System.Drawing.Size(615, 23);
            this.ilerleme_pb.Step = 100;
            this.ilerleme_pb.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 139);
            this.Controls.Add(this.ilerleme_pb);
            this.Controls.Add(this.basarili_txt);
            this.Controls.Add(this.giris_lbl);
            this.Controls.Add(this.kk_txt);
            this.Controls.Add(this.kkodeme_btn);
            this.Controls.Add(this.nakit_btn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nakit_btn;
        private System.Windows.Forms.Button kkodeme_btn;
        private System.Windows.Forms.TextBox kk_txt;
        private System.Windows.Forms.Label giris_lbl;
        private System.Windows.Forms.Label basarili_txt;
        private System.Windows.Forms.ProgressBar ilerleme_pb;
        private System.Windows.Forms.Timer timer1;
    }
}