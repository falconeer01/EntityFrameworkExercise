namespace ProductsEF
{
    partial class Main_Entrance
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
            this.CatOp = new System.Windows.Forms.Button();
            this.ProdOp = new System.Windows.Forms.Button();
            this.Stats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatOp
            // 
            this.CatOp.Location = new System.Drawing.Point(13, 14);
            this.CatOp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatOp.Name = "CatOp";
            this.CatOp.Size = new System.Drawing.Size(152, 114);
            this.CatOp.TabIndex = 0;
            this.CatOp.Text = "Category Operations";
            this.CatOp.UseVisualStyleBackColor = true;
            this.CatOp.Click += new System.EventHandler(this.CatOp_Click);
            // 
            // ProdOp
            // 
            this.ProdOp.Location = new System.Drawing.Point(173, 14);
            this.ProdOp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdOp.Name = "ProdOp";
            this.ProdOp.Size = new System.Drawing.Size(152, 114);
            this.ProdOp.TabIndex = 1;
            this.ProdOp.Text = "Product Operations";
            this.ProdOp.UseVisualStyleBackColor = true;
            this.ProdOp.Click += new System.EventHandler(this.ProdOp_Click);
            // 
            // Stats
            // 
            this.Stats.Location = new System.Drawing.Point(333, 14);
            this.Stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(152, 114);
            this.Stats.TabIndex = 2;
            this.Stats.Text = "Statistics";
            this.Stats.UseVisualStyleBackColor = true;
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // Main_Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 142);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.ProdOp);
            this.Controls.Add(this.CatOp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main_Entrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Entrance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatOp;
        private System.Windows.Forms.Button ProdOp;
        private System.Windows.Forms.Button Stats;
    }
}