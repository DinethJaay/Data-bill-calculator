namespace dialogbill
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
            this.txtunitatday = new System.Windows.Forms.TextBox();
            this.txtunitatnight = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.cmbdatapack = new System.Windows.Forms.ComboBox();
            this.lbldatapackage = new System.Windows.Forms.Label();
            this.lblunitofday = new System.Windows.Forms.Label();
            this.lblunitatnight = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtunitatday
            // 
            this.txtunitatday.Location = new System.Drawing.Point(459, 140);
            this.txtunitatday.Name = "txtunitatday";
            this.txtunitatday.Size = new System.Drawing.Size(273, 22);
            this.txtunitatday.TabIndex = 0;
            // 
            // txtunitatnight
            // 
            this.txtunitatnight.Location = new System.Drawing.Point(459, 213);
            this.txtunitatnight.Name = "txtunitatnight";
            this.txtunitatnight.Size = new System.Drawing.Size(273, 22);
            this.txtunitatnight.TabIndex = 1;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(459, 294);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(273, 22);
            this.txttotal.TabIndex = 2;
            // 
            // cmbdatapack
            // 
            this.cmbdatapack.FormattingEnabled = true;
            this.cmbdatapack.Items.AddRange(new object[] {
            "Day Blast",
            "Night Blast"});
            this.cmbdatapack.Location = new System.Drawing.Point(459, 52);
            this.cmbdatapack.Name = "cmbdatapack";
            this.cmbdatapack.Size = new System.Drawing.Size(273, 24);
            this.cmbdatapack.TabIndex = 3;
            // 
            // lbldatapackage
            // 
            this.lbldatapackage.AutoSize = true;
            this.lbldatapackage.Location = new System.Drawing.Point(240, 55);
            this.lbldatapackage.Name = "lbldatapackage";
            this.lbldatapackage.Size = new System.Drawing.Size(94, 16);
            this.lbldatapackage.TabIndex = 4;
            this.lbldatapackage.Text = "Data Package";
            // 
            // lblunitofday
            // 
            this.lblunitofday.AutoSize = true;
            this.lblunitofday.Location = new System.Drawing.Point(240, 140);
            this.lblunitofday.Name = "lblunitofday";
            this.lblunitofday.Size = new System.Drawing.Size(79, 16);
            this.lblunitofday.TabIndex = 5;
            this.lblunitofday.Text = "Units at Day";
            // 
            // lblunitatnight
            // 
            this.lblunitatnight.AutoSize = true;
            this.lblunitatnight.Location = new System.Drawing.Point(240, 219);
            this.lblunitatnight.Name = "lblunitatnight";
            this.lblunitatnight.Size = new System.Drawing.Size(85, 16);
            this.lblunitatnight.TabIndex = 6;
            this.lblunitatnight.Text = "Units at Night";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(240, 300);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(38, 16);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "Total";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(657, 377);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(459, 377);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(243, 377);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 10;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblunitatnight);
            this.Controls.Add(this.lblunitofday);
            this.Controls.Add(this.lbldatapackage);
            this.Controls.Add(this.cmbdatapack);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtunitatnight);
            this.Controls.Add(this.txtunitatday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtunitatday;
        private System.Windows.Forms.TextBox txtunitatnight;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cmbdatapack;
        private System.Windows.Forms.Label lbldatapackage;
        private System.Windows.Forms.Label lblunitofday;
        private System.Windows.Forms.Label lblunitatnight;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
    }
}

