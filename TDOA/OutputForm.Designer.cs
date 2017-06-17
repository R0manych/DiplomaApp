namespace TDOA
{
    partial class OutputForm
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
            this.outputDataControl1 = new TDOA.OutputDataControl();
            this.SuspendLayout();
            // 
            // outputDataControl1
            // 
            this.outputDataControl1.Location = new System.Drawing.Point(12, 12);
            this.outputDataControl1.Name = "outputDataControl1";
            this.outputDataControl1.Size = new System.Drawing.Size(346, 160);
            this.outputDataControl1.TabIndex = 0;
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 188);
            this.Controls.Add(this.outputDataControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutputForm";
            this.Text = "Результат";
            this.ResumeLayout(false);

        }

        #endregion

        private OutputDataControl outputDataControl1;
    }
}