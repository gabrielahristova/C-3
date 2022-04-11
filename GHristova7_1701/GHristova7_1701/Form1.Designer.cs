
namespace GHristova7_1701
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
            this.lb_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_kind = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_S = new System.Windows.Forms.RadioButton();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.rb_L = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_standart = new System.Windows.Forms.RadioButton();
            this.rb_express = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(153, 119);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 17);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Име";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lb_kind
            // 
            this.lb_kind.AutoSize = true;
            this.lb_kind.Location = new System.Drawing.Point(156, 196);
            this.lb_kind.Name = "lb_kind";
            this.lb_kind.Size = new System.Drawing.Size(75, 17);
            this.lb_kind.TabIndex = 2;
            this.lb_kind.Text = "Вид дреха";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Тениска",
            "Пуловер",
            "Дънки",
            "Шорти",
            "Яке"});
            this.comboBox1.Location = new System.Drawing.Point(367, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поръчай";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_S
            // 
            this.rb_S.AutoSize = true;
            this.rb_S.Location = new System.Drawing.Point(27, 53);
            this.rb_S.Name = "rb_S";
            this.rb_S.Size = new System.Drawing.Size(90, 21);
            this.rb_S.TabIndex = 5;
            this.rb_S.TabStop = true;
            this.rb_S.Text = "размер S";
            this.rb_S.UseVisualStyleBackColor = true;
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(27, 108);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(92, 21);
            this.rb_M.TabIndex = 6;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "размер М";
            this.rb_M.UseVisualStyleBackColor = true;
            // 
            // rb_L
            // 
            this.rb_L.AutoSize = true;
            this.rb_L.Location = new System.Drawing.Point(27, 160);
            this.rb_L.Name = "rb_L";
            this.rb_L.Size = new System.Drawing.Size(89, 21);
            this.rb_L.TabIndex = 7;
            this.rb_L.TabStop = true;
            this.rb_L.Text = "размер L";
            this.rb_L.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // rb_standart
            // 
            this.rb_standart.AutoSize = true;
            this.rb_standart.Location = new System.Drawing.Point(23, 42);
            this.rb_standart.Name = "rb_standart";
            this.rb_standart.Size = new System.Drawing.Size(108, 21);
            this.rb_standart.TabIndex = 9;
            this.rb_standart.TabStop = true;
            this.rb_standart.Text = "Стандартна";
            this.rb_standart.UseVisualStyleBackColor = true;
            // 
            // rb_express
            // 
            this.rb_express.AutoSize = true;
            this.rb_express.Location = new System.Drawing.Point(23, 99);
            this.rb_express.Name = "rb_express";
            this.rb_express.Size = new System.Drawing.Size(99, 21);
            this.rb_express.TabIndex = 10;
            this.rb_express.TabStop = true;
            this.rb_express.Text = "Експресна";
            this.rb_express.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_S);
            this.groupBox1.Controls.Add(this.rb_M);
            this.groupBox1.Controls.Add(this.rb_L);
            this.groupBox1.Location = new System.Drawing.Point(144, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_standart);
            this.groupBox2.Controls.Add(this.rb_express);
            this.groupBox2.Location = new System.Drawing.Point(562, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 145);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Доставка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_kind);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_name);
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

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_kind;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_S;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.RadioButton rb_L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_standart;
        private System.Windows.Forms.RadioButton rb_express;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

