
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
            this.labelStopWatch = new System.Windows.Forms.Label();
            this.buttonStopWatchStart = new System.Windows.Forms.Button();
            this.buttonStopWatchStop = new System.Windows.Forms.Button();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.buttonStopWatchDeltaStop = new System.Windows.Forms.Button();
            this.buttonStopWatchDeltaStart = new System.Windows.Forms.Button();
            this.labelStopWatchDelta = new System.Windows.Forms.Label();
            this.timerStopWatchDelta = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClock.Location = new System.Drawing.Point(12, 9);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(105, 45);
            this.labelClock.TabIndex = 1;
            this.labelClock.Text = "label1";
            // 
            // buttonReadTime
            // 
            this.buttonReadTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReadTime.Location = new System.Drawing.Point(12, 73);
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
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // labelStopWatch
            // 
            this.labelStopWatch.AutoSize = true;
            this.labelStopWatch.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStopWatch.Location = new System.Drawing.Point(229, 9);
            this.labelStopWatch.Name = "labelStopWatch";
            this.labelStopWatch.Size = new System.Drawing.Size(299, 54);
            this.labelStopWatch.TabIndex = 3;
            this.labelStopWatch.Text = "labelStopWatch";
            // 
            // buttonStopWatchStart
            // 
            this.buttonStopWatchStart.Location = new System.Drawing.Point(238, 77);
            this.buttonStopWatchStart.Name = "buttonStopWatchStart";
            this.buttonStopWatchStart.Size = new System.Drawing.Size(84, 91);
            this.buttonStopWatchStart.TabIndex = 4;
            this.buttonStopWatchStart.Text = "Start";
            this.buttonStopWatchStart.UseVisualStyleBackColor = true;
            this.buttonStopWatchStart.Click += new System.EventHandler(this.buttonStopWatchStart_Click);
            // 
            // buttonStopWatchStop
            // 
            this.buttonStopWatchStop.Location = new System.Drawing.Point(340, 77);
            this.buttonStopWatchStop.Name = "buttonStopWatchStop";
            this.buttonStopWatchStop.Size = new System.Drawing.Size(100, 91);
            this.buttonStopWatchStop.TabIndex = 5;
            this.buttonStopWatchStop.Text = "Stop";
            this.buttonStopWatchStop.UseVisualStyleBackColor = true;
            this.buttonStopWatchStop.Click += new System.EventHandler(this.buttonStopWatchStop_Click);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // buttonStopWatchDeltaStop
            // 
            this.buttonStopWatchDeltaStop.Location = new System.Drawing.Point(340, 279);
            this.buttonStopWatchDeltaStop.Name = "buttonStopWatchDeltaStop";
            this.buttonStopWatchDeltaStop.Size = new System.Drawing.Size(100, 91);
            this.buttonStopWatchDeltaStop.TabIndex = 8;
            this.buttonStopWatchDeltaStop.Text = "Stop";
            this.buttonStopWatchDeltaStop.UseVisualStyleBackColor = true;
            this.buttonStopWatchDeltaStop.Click += new System.EventHandler(this.buttonStopWatchDeltaStop_Click);
            // 
            // buttonStopWatchDeltaStart
            // 
            this.buttonStopWatchDeltaStart.Location = new System.Drawing.Point(238, 279);
            this.buttonStopWatchDeltaStart.Name = "buttonStopWatchDeltaStart";
            this.buttonStopWatchDeltaStart.Size = new System.Drawing.Size(84, 91);
            this.buttonStopWatchDeltaStart.TabIndex = 7;
            this.buttonStopWatchDeltaStart.Text = "Start";
            this.buttonStopWatchDeltaStart.UseVisualStyleBackColor = true;
            this.buttonStopWatchDeltaStart.Click += new System.EventHandler(this.buttonStopWatchDeltaStart_Click);
            // 
            // labelStopWatchDelta
            // 
            this.labelStopWatchDelta.AutoSize = true;
            this.labelStopWatchDelta.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStopWatchDelta.Location = new System.Drawing.Point(229, 211);
            this.labelStopWatchDelta.Name = "labelStopWatchDelta";
            this.labelStopWatchDelta.Size = new System.Drawing.Size(392, 54);
            this.labelStopWatchDelta.TabIndex = 6;
            this.labelStopWatchDelta.Text = "labelStopWatchDelta";
            // 
            // timerStopWatchDelta
            // 
            this.timerStopWatchDelta.Interval = 1;
            this.timerStopWatchDelta.Tick += new System.EventHandler(this.timerStopWatchDelta_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStopWatchDeltaStop);
            this.Controls.Add(this.buttonStopWatchDeltaStart);
            this.Controls.Add(this.labelStopWatchDelta);
            this.Controls.Add(this.buttonStopWatchStop);
            this.Controls.Add(this.buttonStopWatchStart);
            this.Controls.Add(this.labelStopWatch);
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
        private System.Windows.Forms.Label labelStopWatch;
        private System.Windows.Forms.Button buttonStopWatchStart;
        private System.Windows.Forms.Button buttonStopWatchStop;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Button buttonStopWatchDeltaStop;
        private System.Windows.Forms.Button buttonStopWatchDeltaStart;
        private System.Windows.Forms.Label labelStopWatchDelta;
        private System.Windows.Forms.Timer timerStopWatchDelta;
    }
}

