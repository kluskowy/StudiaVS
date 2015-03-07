namespace Liczby
{
    partial class OknoLiczby
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
            this.btnNapiszSlownie = new System.Windows.Forms.Button();
            this.tbxLiczba = new System.Windows.Forms.TextBox();
            this.tbxSlownie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNapiszSlownie
            // 
            this.btnNapiszSlownie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapiszSlownie.Location = new System.Drawing.Point(724, 44);
            this.btnNapiszSlownie.Name = "btnNapiszSlownie";
            this.btnNapiszSlownie.Size = new System.Drawing.Size(134, 28);
            this.btnNapiszSlownie.TabIndex = 0;
            this.btnNapiszSlownie.Text = "Napisz słownie";
            this.btnNapiszSlownie.UseVisualStyleBackColor = true;
            this.btnNapiszSlownie.Click += new System.EventHandler(this.btnNapiszSlownie_Click);
            // 
            // tbxLiczba
            // 
            this.tbxLiczba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLiczba.Location = new System.Drawing.Point(12, 12);
            this.tbxLiczba.Name = "tbxLiczba";
            this.tbxLiczba.Size = new System.Drawing.Size(846, 26);
            this.tbxLiczba.TabIndex = 1;
            // 
            // tbxSlownie
            // 
            this.tbxSlownie.BackColor = System.Drawing.SystemColors.Control;
            this.tbxSlownie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSlownie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSlownie.Location = new System.Drawing.Point(12, 78);
            this.tbxSlownie.Multiline = true;
            this.tbxSlownie.Name = "tbxSlownie";
            this.tbxSlownie.ReadOnly = true;
            this.tbxSlownie.Size = new System.Drawing.Size(846, 464);
            this.tbxSlownie.TabIndex = 3;
            // 
            // OknoLiczby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 554);
            this.Controls.Add(this.tbxSlownie);
            this.Controls.Add(this.tbxLiczba);
            this.Controls.Add(this.btnNapiszSlownie);
            this.Name = "OknoLiczby";
            this.Text = "Liczby pisane słownie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNapiszSlownie;
        private System.Windows.Forms.TextBox tbxLiczba;
        private System.Windows.Forms.TextBox tbxSlownie;
    }
}

