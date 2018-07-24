namespace Observers
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
            this.btnStartPump = new System.Windows.Forms.Button();
            this.txtObserverLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartPump
            // 
            this.btnStartPump.Location = new System.Drawing.Point(69, 55);
            this.btnStartPump.Name = "btnStartPump";
            this.btnStartPump.Size = new System.Drawing.Size(213, 66);
            this.btnStartPump.TabIndex = 0;
            this.btnStartPump.Text = "&Start the Pump";
            this.btnStartPump.UseVisualStyleBackColor = true;
            this.btnStartPump.Click += new System.EventHandler(this.btnStartPump_Click);
            // 
            // txtObserverLog
            // 
            this.txtObserverLog.Location = new System.Drawing.Point(69, 147);
            this.txtObserverLog.Multiline = true;
            this.txtObserverLog.Name = "txtObserverLog";
            this.txtObserverLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserverLog.Size = new System.Drawing.Size(1024, 600);
            this.txtObserverLog.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 779);
            this.Controls.Add(this.txtObserverLog);
            this.Controls.Add(this.btnStartPump);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartPump;
        private System.Windows.Forms.TextBox txtObserverLog;
    }
}

