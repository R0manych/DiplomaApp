namespace TDOA
{
    partial class OutputDataControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelR1 = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(38, 40);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(120, 26);
            this.textBoxX.TabIndex = 0;
            // 
            // textBoxR1
            // 
            this.textBoxR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR1.Location = new System.Drawing.Point(38, 123);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.ReadOnly = true;
            this.textBoxR1.Size = new System.Drawing.Size(120, 26);
            this.textBoxR1.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.Location = new System.Drawing.Point(209, 40);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(120, 26);
            this.textBoxY.TabIndex = 2;
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR1.Location = new System.Drawing.Point(6, 69);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(0, 20);
            this.labelR1.TabIndex = 19;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(183, 40);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 20);
            this.labelY.TabIndex = 20;
            this.labelY.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Координаты исследуемого объекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "R1";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(10, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(322, 48);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Дистанция между исследуеммым объектом и первым опорным узлом";
            // 
            // OutputDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelR1);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.textBoxX);
            this.Name = "OutputDataControl";
            this.Size = new System.Drawing.Size(346, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}
