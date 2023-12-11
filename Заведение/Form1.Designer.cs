namespace Заведение
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbPushachi = new System.Windows.Forms.RadioButton();
            this.rdbNePushachi = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtbBroi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rdbKesh = new System.Windows.Forms.RadioButton();
            this.rdbKarta = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Брой на гостите на масата:";
            // 
            // rdbPushachi
            // 
            this.rdbPushachi.AutoSize = true;
            this.rdbPushachi.Location = new System.Drawing.Point(26, 31);
            this.rdbPushachi.Name = "rdbPushachi";
            this.rdbPushachi.Size = new System.Drawing.Size(80, 17);
            this.rdbPushachi.TabIndex = 3;
            this.rdbPushachi.TabStop = true;
            this.rdbPushachi.Text = "За пушачи ";
            this.rdbPushachi.UseVisualStyleBackColor = true;
            // 
            // rdbNePushachi
            // 
            this.rdbNePushachi.AutoSize = true;
            this.rdbNePushachi.Location = new System.Drawing.Point(26, 66);
            this.rdbNePushachi.Name = "rdbNePushachi";
            this.rdbNePushachi.Size = new System.Drawing.Size(95, 17);
            this.rdbNePushachi.TabIndex = 4;
            this.rdbNePushachi.TabStop = true;
            this.rdbNePushachi.Text = "За не пушачи ";
            this.rdbNePushachi.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtbBroi
            // 
            this.txtbBroi.Location = new System.Drawing.Point(43, 174);
            this.txtbBroi.Name = "txtbBroi";
            this.txtbBroi.Size = new System.Drawing.Size(100, 20);
            this.txtbBroi.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPushachi);
            this.groupBox1.Controls.Add(this.rdbNePushachi);
            this.groupBox1.Location = new System.Drawing.Point(43, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каква маса желаете";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.rdbKesh);
            this.groupBox2.Controls.Add(this.rdbKarta);
            this.groupBox2.Location = new System.Drawing.Point(305, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 159);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Начин на плащане";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ше оставите ли бакшиш";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "0,05 над сметката";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(219, 62);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Не";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(158, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(41, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Да";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rdbKesh
            // 
            this.rdbKesh.AutoSize = true;
            this.rdbKesh.Location = new System.Drawing.Point(26, 27);
            this.rdbKesh.Name = "rdbKesh";
            this.rdbKesh.Size = new System.Drawing.Size(58, 17);
            this.rdbKesh.TabIndex = 3;
            this.rdbKesh.TabStop = true;
            this.rdbKesh.Text = " В кеш";
            this.rdbKesh.UseVisualStyleBackColor = true;
            // 
            // rdbKarta
            // 
            this.rdbKarta.AutoSize = true;
            this.rdbKarta.Location = new System.Drawing.Point(26, 112);
            this.rdbKarta.Name = "rdbKarta";
            this.rdbKarta.Size = new System.Drawing.Size(64, 17);
            this.rdbKarta.TabIndex = 4;
            this.rdbKarta.TabStop = true;
            this.rdbKarta.Text = "С карта";
            this.rdbKarta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Преглед";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 66);
            this.button2.TabIndex = 10;
            this.button2.Text = "Нататък";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbBroi);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbPushachi;
        private System.Windows.Forms.RadioButton rdbNePushachi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtbBroi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbKesh;
        private System.Windows.Forms.RadioButton rdbKarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

