namespace KevinAldana_FinalLab
{
    partial class frmOrder
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
            this.lblOrder = new System.Windows.Forms.Label();
            this.lstbxOrder = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblOrderSubtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(133, 25);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(185, 41);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Your Order";
            // 
            // lstbxOrder
            // 
            this.lstbxOrder.FormattingEnabled = true;
            this.lstbxOrder.Location = new System.Drawing.Point(52, 69);
            this.lstbxOrder.Name = "lstbxOrder";
            this.lstbxOrder.Size = new System.Drawing.Size(367, 277);
            this.lstbxOrder.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(333, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(28, 367);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(154, 41);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblOrderSubtotal
            // 
            this.lblOrderSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderSubtotal.Location = new System.Drawing.Point(188, 365);
            this.lblOrderSubtotal.Name = "lblOrderSubtotal";
            this.lblOrderSubtotal.Size = new System.Drawing.Size(118, 43);
            this.lblOrderSubtotal.TabIndex = 4;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 427);
            this.Controls.Add(this.lblOrderSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstbxOrder);
            this.Controls.Add(this.lblOrder);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ListBox lstbxOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblOrderSubtotal;
    }
}