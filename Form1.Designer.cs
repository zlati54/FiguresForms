namespace FiguresForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.lblNumberOfFigures = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRectangle
            // 
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.Location = new System.Drawing.Point(12, 465);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Text = "rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTriangle.Location = new System.Drawing.Point(102, 465);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.Text = "triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircle.Location = new System.Drawing.Point(192, 465);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // lblNumberOfFigures
            // 
            this.lblNumberOfFigures.AutoSize = true;
            this.lblNumberOfFigures.Location = new System.Drawing.Point(400, 469);
            this.lblNumberOfFigures.Name = "lblNumberOfFigures";
            this.lblNumberOfFigures.Size = new System.Drawing.Size(99, 15);
            this.lblNumberOfFigures.TabIndex = 3;
            this.lblNumberOfFigures.Text = "Rendered figures:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(282, 465);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 512);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblNumberOfFigures);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnRectangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRectangle;
        private Button btnTriangle;
        private Button btnCircle;
        private Label lblNumberOfFigures;
        private Button btnStop;
    }
}