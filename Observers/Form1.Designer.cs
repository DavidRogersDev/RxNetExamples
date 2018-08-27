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
            this.btnStartPump.Location = new System.Drawing.Point(34, 29);
            this.btnStartPump.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartPump.Name = "btnStartPump";
            this.btnStartPump.Size = new System.Drawing.Size(106, 34);
            this.btnStartPump.TabIndex = 0;
            this.btnStartPump.Text = "&Start the Pump";
            this.btnStartPump.UseVisualStyleBackColor = true;
            this.btnStartPump.Click += new System.EventHandler(this.btnStartPump_Click);
            // 
            // txtObserverLog
            // 
            this.txtObserverLog.Location = new System.Drawing.Point(34, 76);
            this.txtObserverLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObserverLog.Multiline = true;
            this.txtObserverLog.Name = "txtObserverLog";
            this.txtObserverLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserverLog.Size = new System.Drawing.Size(514, 314);
            this.txtObserverLog.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 405);
            this.Controls.Add(this.txtObserverLog);
            this.Controls.Add(this.btnStartPump);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Observer Example Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartPump;
        private System.Windows.Forms.TextBox txtObserverLog;
    }
}

