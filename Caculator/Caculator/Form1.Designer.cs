
namespace Caculator
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
            this.btn_Cong = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.Label();
            this.btn_Chia = new System.Windows.Forms.Button();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.btn_Tru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cong
            // 
            this.btn_Cong.Location = new System.Drawing.Point(170, 279);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(75, 58);
            this.btn_Cong.TabIndex = 0;
            this.btn_Cong.Text = "+";
            this.btn_Cong.UseVisualStyleBackColor = true;
            this.btn_Cong.Click += new System.EventHandler(this.btn_Cong_Click);
            // 
            // txt_1
            // 
            this.txt_1.AutoSize = true;
            this.txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.Location = new System.Drawing.Point(125, 50);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(58, 24);
            this.txt_1.TabIndex = 1;
            this.txt_1.Text = "Số 1:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(210, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 29);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(210, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 29);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(210, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 29);
            this.textBox3.TabIndex = 6;
            // 
            // txt_kq
            // 
            this.txt_kq.AutoSize = true;
            this.txt_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kq.Location = new System.Drawing.Point(125, 194);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(81, 24);
            this.txt_kq.TabIndex = 7;
            this.txt_kq.Text = "Kết quả";
            // 
            // txt_2
            // 
            this.txt_2.AutoSize = true;
            this.txt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2.Location = new System.Drawing.Point(125, 112);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(58, 24);
            this.txt_2.TabIndex = 8;
            this.txt_2.Text = "Số 2:";
            // 
            // btn_Chia
            // 
            this.btn_Chia.Location = new System.Drawing.Point(468, 279);
            this.btn_Chia.Name = "btn_Chia";
            this.btn_Chia.Size = new System.Drawing.Size(75, 58);
            this.btn_Chia.TabIndex = 9;
            this.btn_Chia.Text = "/";
            this.btn_Chia.UseVisualStyleBackColor = true;
            this.btn_Chia.Click += new System.EventHandler(this.btn_Chia_Click);
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.Location = new System.Drawing.Point(371, 279);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(75, 58);
            this.btn_Nhan.TabIndex = 10;
            this.btn_Nhan.Text = "*";
            this.btn_Nhan.UseVisualStyleBackColor = true;
            this.btn_Nhan.Click += new System.EventHandler(this.btn_Nhan_Click);
            // 
            // btn_Tru
            // 
            this.btn_Tru.Location = new System.Drawing.Point(277, 279);
            this.btn_Tru.Name = "btn_Tru";
            this.btn_Tru.Size = new System.Drawing.Size(75, 58);
            this.btn_Tru.TabIndex = 11;
            this.btn_Tru.Text = "-";
            this.btn_Tru.UseVisualStyleBackColor = true;
            this.btn_Tru.Click += new System.EventHandler(this.btn_Tru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 403);
            this.Controls.Add(this.btn_Tru);
            this.Controls.Add(this.btn_Nhan);
            this.Controls.Add(this.btn_Chia);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.btn_Cong);
            this.Name = "Form1";
            this.Text = "MayTinh_41_ngan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cong;
        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txt_kq;
        private System.Windows.Forms.Label txt_2;
        private System.Windows.Forms.Button btn_Chia;
        private System.Windows.Forms.Button btn_Nhan;
        private System.Windows.Forms.Button btn_Tru;
    }
}

