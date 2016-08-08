namespace RARJoiner
{
    partial class rarBinder
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
            this.buttonRarFile = new System.Windows.Forms.Button();
            this.buttonBaseFile = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRarLoc = new System.Windows.Forms.TextBox();
            this.textBoxBaseLoc = new System.Windows.Forms.TextBox();
            this.textBoxResultLoc = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonRarFile
            // 
            this.buttonRarFile.Location = new System.Drawing.Point(324, 11);
            this.buttonRarFile.Name = "buttonRarFile";
            this.buttonRarFile.Size = new System.Drawing.Size(28, 23);
            this.buttonRarFile.TabIndex = 0;
            this.buttonRarFile.Text = "...";
            this.buttonRarFile.UseVisualStyleBackColor = true;
            this.buttonRarFile.Click += new System.EventHandler(this.buttonRarFile_Click);
            // 
            // buttonBaseFile
            // 
            this.buttonBaseFile.Location = new System.Drawing.Point(324, 48);
            this.buttonBaseFile.Name = "buttonBaseFile";
            this.buttonBaseFile.Size = new System.Drawing.Size(28, 23);
            this.buttonBaseFile.TabIndex = 1;
            this.buttonBaseFile.Text = "...";
            this.buttonBaseFile.UseVisualStyleBackColor = true;
            this.buttonBaseFile.Click += new System.EventHandler(this.buttonBaseFile_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(12, 119);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(340, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RAR File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result Location:";
            // 
            // textBoxRarLoc
            // 
            this.textBoxRarLoc.Location = new System.Drawing.Point(70, 15);
            this.textBoxRarLoc.Name = "textBoxRarLoc";
            this.textBoxRarLoc.Size = new System.Drawing.Size(248, 20);
            this.textBoxRarLoc.TabIndex = 6;
            // 
            // textBoxBaseLoc
            // 
            this.textBoxBaseLoc.Location = new System.Drawing.Point(68, 51);
            this.textBoxBaseLoc.Name = "textBoxBaseLoc";
            this.textBoxBaseLoc.Size = new System.Drawing.Size(250, 20);
            this.textBoxBaseLoc.TabIndex = 7;
            // 
            // textBoxResultLoc
            // 
            this.textBoxResultLoc.Location = new System.Drawing.Point(102, 85);
            this.textBoxResultLoc.Name = "textBoxResultLoc";
            this.textBoxResultLoc.Size = new System.Drawing.Size(250, 20);
            this.textBoxResultLoc.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(171, 159);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // rarBinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 222);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBoxResultLoc);
            this.Controls.Add(this.textBoxBaseLoc);
            this.Controls.Add(this.textBoxRarLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonBaseFile);
            this.Controls.Add(this.buttonRarFile);
            this.Name = "rarBinder";
            this.Text = "RARBinder v1.0";
            this.Load += new System.EventHandler(this.rarJoiner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRarFile;
        private System.Windows.Forms.Button buttonBaseFile;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRarLoc;
        private System.Windows.Forms.TextBox textBoxBaseLoc;
        private System.Windows.Forms.TextBox textBoxResultLoc;
        private System.Windows.Forms.OpenFileDialog rarFileDialog;
        private System.Windows.Forms.OpenFileDialog baseFileDialog;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

