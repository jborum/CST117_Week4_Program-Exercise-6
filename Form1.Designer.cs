namespace Exercise6
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
            this.buttonRollDice = new System.Windows.Forms.Button();
            this.txtDie1 = new System.Windows.Forms.TextBox();
            this.txtDie2 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRollDice
            // 
            this.buttonRollDice.BackgroundImage = global::Exercise6.Properties.Resources.Image_RollDice;
            this.buttonRollDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollDice.ForeColor = System.Drawing.Color.Red;
            this.buttonRollDice.Location = new System.Drawing.Point(16, 18);
            this.buttonRollDice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRollDice.Name = "buttonRollDice";
            this.buttonRollDice.Size = new System.Drawing.Size(300, 308);
            this.buttonRollDice.TabIndex = 0;
            this.buttonRollDice.Text = "Roll Dice";
            this.buttonRollDice.UseVisualStyleBackColor = true;
            this.buttonRollDice.Click += new System.EventHandler(this.buttonRollDice_Click);
            // 
            // txtDie1
            // 
            this.txtDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDie1.ForeColor = System.Drawing.Color.Black;
            this.txtDie1.Location = new System.Drawing.Point(339, 18);
            this.txtDie1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDie1.Multiline = true;
            this.txtDie1.Name = "txtDie1";
            this.txtDie1.Size = new System.Drawing.Size(148, 152);
            this.txtDie1.TabIndex = 1;
            this.txtDie1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDie2
            // 
            this.txtDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDie2.ForeColor = System.Drawing.Color.Black;
            this.txtDie2.Location = new System.Drawing.Point(519, 18);
            this.txtDie2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDie2.Multiline = true;
            this.txtDie2.Name = "txtDie2";
            this.txtDie2.Size = new System.Drawing.Size(148, 152);
            this.txtDie2.TabIndex = 2;
            this.txtDie2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(339, 235);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(330, 91);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 343);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.txtDie2);
            this.Controls.Add(this.txtDie1);
            this.Controls.Add(this.buttonRollDice);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRollDice;
        private System.Windows.Forms.TextBox txtDie1;
        private System.Windows.Forms.TextBox txtDie2;
        private System.Windows.Forms.Button buttonClose;
    }
}

