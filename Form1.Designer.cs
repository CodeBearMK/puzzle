﻿namespace puzzle
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.imgCats = new System.Windows.Forms.ImageList(this.components);
            this.btnChk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn11
            // 
            this.btn11.ImageList = this.imgCats;
            this.btn11.Location = new System.Drawing.Point(20, 27);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(119, 112);
            this.btn11.TabIndex = 0;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn12
            // 
            this.btn12.ImageList = this.imgCats;
            this.btn12.Location = new System.Drawing.Point(136, 27);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(119, 112);
            this.btn12.TabIndex = 1;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn13
            // 
            this.btn13.ImageList = this.imgCats;
            this.btn13.Location = new System.Drawing.Point(251, 27);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(119, 112);
            this.btn13.TabIndex = 2;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // btn21
            // 
            this.btn21.ImageList = this.imgCats;
            this.btn21.Location = new System.Drawing.Point(20, 138);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(119, 112);
            this.btn21.TabIndex = 3;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btn22
            // 
            this.btn22.ImageList = this.imgCats;
            this.btn22.Location = new System.Drawing.Point(136, 138);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(119, 112);
            this.btn22.TabIndex = 4;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // btn23
            // 
            this.btn23.ImageList = this.imgCats;
            this.btn23.Location = new System.Drawing.Point(251, 138);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(119, 112);
            this.btn23.TabIndex = 5;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.btn23_Click);
            // 
            // btn31
            // 
            this.btn31.ImageList = this.imgCats;
            this.btn31.Location = new System.Drawing.Point(20, 245);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(119, 122);
            this.btn31.TabIndex = 6;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Click += new System.EventHandler(this.btn31_Click);
            // 
            // btn32
            // 
            this.btn32.ImageList = this.imgCats;
            this.btn32.Location = new System.Drawing.Point(136, 245);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(119, 122);
            this.btn32.TabIndex = 7;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.Click += new System.EventHandler(this.btn32_Click);
            // 
            // btn33
            // 
            this.btn33.ImageList = this.imgCats;
            this.btn33.Location = new System.Drawing.Point(251, 245);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(119, 122);
            this.btn33.TabIndex = 8;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Click += new System.EventHandler(this.btn33_Click);
            // 
            // imgCats
            // 
            this.imgCats.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCats.ImageStream")));
            this.imgCats.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCats.Images.SetKeyName(0, "cat11.jpg");
            this.imgCats.Images.SetKeyName(1, "cat12.jpg");
            this.imgCats.Images.SetKeyName(2, "cat13.jpg");
            this.imgCats.Images.SetKeyName(3, "cat21.jpg");
            this.imgCats.Images.SetKeyName(4, "cat22.jpg");
            this.imgCats.Images.SetKeyName(5, "cat23.jpg");
            this.imgCats.Images.SetKeyName(6, "cat31.jpg");
            this.imgCats.Images.SetKeyName(7, "cat32.jpg");
            this.imgCats.Images.SetKeyName(8, "cat33.jpg");
            // 
            // btnChk
            // 
            this.btnChk.Location = new System.Drawing.Point(146, 385);
            this.btnChk.Name = "btnChk";
            this.btnChk.Size = new System.Drawing.Size(99, 32);
            this.btnChk.TabIndex = 9;
            this.btnChk.Text = "檢查";
            this.btnChk.UseVisualStyleBackColor = true;
            this.btnChk.Click += new System.EventHandler(this.btnChk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 429);
            this.Controls.Add(this.btnChk);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.ImageList imgCats;
        private System.Windows.Forms.Button btnChk;
    }
}

