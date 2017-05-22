namespace TDOA
{
    partial class MainForm
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
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.inputDataControl1 = new TDOA.InputDataControl();
            this.SuspendLayout();
            // 
            // outputDataControl1
            // 
            this.outputDataControl1.Location = new System.Drawing.Point(11, 190);
            this.outputDataControl1.Name = "outputDataControl1";
            this.outputDataControl1.Size = new System.Drawing.Size(499, 49);
            this.outputDataControl1.TabIndex = 1;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.Location = new System.Drawing.Point(12, 245);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(123, 42);
            this.buttonSolve.TabIndex = 2;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(370, 245);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(123, 42);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // inputDataControl1
            // 
            this.inputDataControl1.Location = new System.Drawing.Point(11, 12);
            this.inputDataControl1.Name = "inputDataControl1";
            this.inputDataControl1.Size = new System.Drawing.Size(503, 155);
            this.inputDataControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 304);
            this.Controls.Add(this.inputDataControl1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.outputDataControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private OutputDataControl outputDataControl1;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonClose;
        private InputDataControl inputDataControl1;
    }
}