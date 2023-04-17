
namespace ClockWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelClock = new System.Windows.Forms.Label();
            this.buttonReadTime = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClock.Location = new System.Drawing.Point(55, 31);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(105, 45);
            this.labelClock.TabIndex = 1;
            this.labelClock.Text = "label1";
            // 
            // buttonReadTime
            // 
            this.buttonReadTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReadTime.Location = new System.Drawing.Point(55, 112);
            this.buttonReadTime.Name = "buttonReadTime";
            this.buttonReadTime.Size = new System.Drawing.Size(131, 95);
            this.buttonReadTime.TabIndex = 2;
            this.buttonReadTime.Text = "Odczytaj czas";
            this.buttonReadTime.UseVisualStyleBackColor = true;
            this.buttonReadTime.Click += new System.EventHandler(this.buttonReadTime_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReadTime);
            this.Controls.Add(this.labelClock);
            this.Name = "MainForm";
            this.Text = "Zegar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button buttonReadTime;
        private System.Windows.Forms.Timer timerClock;
    }
}

