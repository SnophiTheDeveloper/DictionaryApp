namespace Odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Öğrendim = new System.Windows.Forms.Button();
            this.listBoxT = new System.Windows.Forms.ListBox();
            this.listboxE = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Öğrendim
            // 
            this.Öğrendim.Location = new System.Drawing.Point(241, 268);
            this.Öğrendim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Öğrendim.Name = "Öğrendim";
            this.Öğrendim.Size = new System.Drawing.Size(125, 49);
            this.Öğrendim.TabIndex = 6;
            this.Öğrendim.Text = "Checked";
            this.Öğrendim.UseVisualStyleBackColor = true;
            this.Öğrendim.Click += new System.EventHandler(this.Öğrendim_Click);
            // 
            // listBoxT
            // 
            this.listBoxT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxT.Enabled = false;
            this.listBoxT.FormattingEnabled = true;
            this.listBoxT.ItemHeight = 16;
            this.listBoxT.Items.AddRange(new object[] {
            "mavi",
            "kırmızı",
            "turuncu",
            "mor",
            "yeşil",
            "gri",
            "siyah"});
            this.listBoxT.Location = new System.Drawing.Point(336, 64);
            this.listBoxT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxT.Name = "listBoxT";
            this.listBoxT.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxT.Size = new System.Drawing.Size(195, 196);
            this.listBoxT.TabIndex = 5;
            this.listBoxT.SelectedIndexChanged += new System.EventHandler(this.listBoxT_SelectedIndexChanged);
            // 
            // listboxE
            // 
            this.listboxE.Enabled = false;
            this.listboxE.FormattingEnabled = true;
            this.listboxE.ItemHeight = 16;
            this.listboxE.Items.AddRange(new object[] {
            "blue",
            "red",
            "orange",
            "purple",
            "green",
            "grey",
            "black"});
            this.listboxE.Location = new System.Drawing.Point(80, 64);
            this.listboxE.Margin = new System.Windows.Forms.Padding(4);
            this.listboxE.Name = "listboxE";
            this.listboxE.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listboxE.Size = new System.Drawing.Size(193, 180);
            this.listboxE.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 401);
            this.Controls.Add(this.Öğrendim);
            this.Controls.Add(this.listBoxT);
            this.Controls.Add(this.listboxE);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ListBox listBoxT;
        public System.Windows.Forms.ListBox listboxE;
        private System.Windows.Forms.Button Öğrendim;
    }
}

