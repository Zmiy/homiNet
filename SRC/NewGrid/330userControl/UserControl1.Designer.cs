namespace _330userControl
{
    partial class uc330GridCell
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblMaxCount = new System.Windows.Forms.Label();
            this.gbxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.lblMaxCount);
            this.gbxProduct.Controls.Add(this.numericUpDown1);
            this.gbxProduct.Controls.Add(this.lblProductName);
            this.gbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxProduct.Location = new System.Drawing.Point(0, 0);
            this.gbxProduct.Margin = new System.Windows.Forms.Padding(0);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Padding = new System.Windows.Forms.Padding(0);
            this.gbxProduct.Size = new System.Drawing.Size(108, 101);
            this.gbxProduct.TabIndex = 0;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "0";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductName.AutoEllipsis = true;
            this.lblProductName.Location = new System.Drawing.Point(4, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(101, 57);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name of Product";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Location = new System.Drawing.Point(7, 76);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 19);
            this.numericUpDown1.TabIndex = 1;
            // 
            // lblMaxCount
            // 
            this.lblMaxCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaxCount.AutoSize = true;
            this.lblMaxCount.Location = new System.Drawing.Point(62, 77);
            this.lblMaxCount.Name = "lblMaxCount";
            this.lblMaxCount.Size = new System.Drawing.Size(13, 17);
            this.lblMaxCount.TabIndex = 2;
            this.lblMaxCount.Text = "/";
            // 
            // uc330GridCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxProduct);
            this.Name = "uc330GridCell";
            this.Size = new System.Drawing.Size(108, 101);
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbxProduct;
        public System.Windows.Forms.Label lblMaxCount;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Label lblProductName;


    }
}
