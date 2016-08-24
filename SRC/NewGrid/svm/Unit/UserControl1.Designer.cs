namespace Unit
{
    partial class uscUnit
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
            this.btnUnit = new System.Windows.Forms.Button();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.nudUnit = new System.Windows.Forms.NumericUpDown();
            this.gbxUnit = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnit)).BeginInit();
            this.gbxUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnit
            // 
            this.btnUnit.BackColor = System.Drawing.Color.Red;
            this.btnUnit.FlatAppearance.BorderSize = 0;
            this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.Location = new System.Drawing.Point(4, 14);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(99, 36);
            this.btnUnit.TabIndex = 0;
            this.btnUnit.Text = "Not use";
            this.btnUnit.UseVisualStyleBackColor = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(6, 24);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(97, 21);
            this.cmbUnit.TabIndex = 1;
            this.cmbUnit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmbUnit_MouseUp);
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            this.cmbUnit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmbUnit_PreviewKeyDown);
            // 
            // nudUnit
            // 
            this.nudUnit.Location = new System.Drawing.Point(5, 52);
            this.nudUnit.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudUnit.Name = "nudUnit";
            this.nudUnit.Size = new System.Drawing.Size(97, 20);
            this.nudUnit.TabIndex = 3;
            this.nudUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudUnit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.nudUnit_PreviewKeyDown);
            this.nudUnit.ValueChanged += new System.EventHandler(this.nudUnit_ValueChanged);
            this.nudUnit.Validating += new System.ComponentModel.CancelEventHandler(this.nudUnit_Validating);
            // 
            // gbxUnit
            // 
            this.gbxUnit.Controls.Add(this.nudUnit);
            this.gbxUnit.Controls.Add(this.btnUnit);
            this.gbxUnit.Controls.Add(this.cmbUnit);
            this.gbxUnit.Location = new System.Drawing.Point(3, 2);
            this.gbxUnit.Name = "gbxUnit";
            this.gbxUnit.Size = new System.Drawing.Size(109, 78);
            this.gbxUnit.TabIndex = 4;
            this.gbxUnit.TabStop = false;
            this.gbxUnit.Text = "groupBox1";
            // 
            // uscUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxUnit);
            this.Name = "uscUnit";
            this.Size = new System.Drawing.Size(115, 80);
            this.Load += new System.EventHandler(this.uscUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnit)).EndInit();
            this.gbxUnit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.NumericUpDown nudUnit;
        private System.Windows.Forms.GroupBox gbxUnit;
    }
}
