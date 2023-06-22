namespace FM
{
		partial class Form1
		{
			private System.ComponentModel.IContainer components = null;
			private System.Windows.Forms.Button btnGenerarAnimal;
			private System.Windows.Forms.PictureBox pictureBoxAnimal;
			private System.Windows.Forms.Label lblAnimal;

			protected override void Dispose(bool disposing)
			{
				if (disposing && (components != null))
				{
					components.Dispose();
				}
				base.Dispose(disposing);
			}

			private void InitializeComponent()
			{
			this.btnGenerarAnimal = new System.Windows.Forms.Button();
			this.lblAnimal = new System.Windows.Forms.Label();
			this.pictureBoxAnimal = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGenerarAnimal
			// 
			this.btnGenerarAnimal.Location = new System.Drawing.Point(172, 376);
			this.btnGenerarAnimal.Margin = new System.Windows.Forms.Padding(4);
			this.btnGenerarAnimal.Name = "btnGenerarAnimal";
			this.btnGenerarAnimal.Size = new System.Drawing.Size(160, 49);
			this.btnGenerarAnimal.TabIndex = 0;
			this.btnGenerarAnimal.Text = "Generar Animal";
			this.btnGenerarAnimal.UseVisualStyleBackColor = true;
			this.btnGenerarAnimal.Click += new System.EventHandler(this.btnGenerarAnimal_Click);
			// 
			// lblAnimal
			// 
			this.lblAnimal.AutoSize = true;
			this.lblAnimal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnimal.Location = new System.Drawing.Point(16, 222);
			this.lblAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAnimal.Name = "lblAnimal";
			this.lblAnimal.Size = new System.Drawing.Size(0, 29);
			this.lblAnimal.TabIndex = 1;
			// 
			// pictureBoxAnimal
			// 
			this.pictureBoxAnimal.Location = new System.Drawing.Point(144, 79);
			this.pictureBoxAnimal.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxAnimal.Name = "pictureBoxAnimal";
			this.pictureBoxAnimal.Size = new System.Drawing.Size(221, 244);
			this.pictureBoxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAnimal.TabIndex = 2;
			this.pictureBoxAnimal.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 471);
			this.Controls.Add(this.pictureBoxAnimal);
			this.Controls.Add(this.lblAnimal);
			this.Controls.Add(this.btnGenerarAnimal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

			}
		}
	

}

