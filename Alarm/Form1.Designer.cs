
namespace Alarm
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.time_lbl = new System.Windows.Forms.Label();
            this.time_lbl2 = new System.Windows.Forms.Label();
            this.alarm_lbl = new System.Windows.Forms.Label();
            this.AlarmBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.set_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alarm_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.time_lbl.Location = new System.Drawing.Point(12, 26);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(143, 30);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.Text = "Current time:";
            // 
            // time_lbl2
            // 
            this.time_lbl2.AutoSize = true;
            this.time_lbl2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_lbl2.Location = new System.Drawing.Point(149, 31);
            this.time_lbl2.Name = "time_lbl2";
            this.time_lbl2.Size = new System.Drawing.Size(22, 25);
            this.time_lbl2.TabIndex = 1;
            this.time_lbl2.Text = "0";
            // 
            // alarm_lbl
            // 
            this.alarm_lbl.AutoSize = true;
            this.alarm_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarm_lbl.Location = new System.Drawing.Point(12, 73);
            this.alarm_lbl.Name = "alarm_lbl";
            this.alarm_lbl.Size = new System.Drawing.Size(128, 30);
            this.alarm_lbl.TabIndex = 2;
            this.alarm_lbl.Text = "Alarm time:";
            // 
            // AlarmBox
            // 
            this.AlarmBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AlarmBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlarmBox.Location = new System.Drawing.Point(136, 74);
            this.AlarmBox.Name = "AlarmBox";
            this.AlarmBox.Size = new System.Drawing.Size(100, 33);
            this.AlarmBox.TabIndex = 3;
            this.AlarmBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // set_btn
            // 
            this.set_btn.BackColor = System.Drawing.Color.Aqua;
            this.set_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.set_btn.Location = new System.Drawing.Point(47, 128);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(124, 48);
            this.set_btn.TabIndex = 4;
            this.set_btn.Text = "Set alarm";
            this.set_btn.UseVisualStyleBackColor = false;
            this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Aqua;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stop_btn.Location = new System.Drawing.Point(226, 128);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(124, 48);
            this.stop_btn.TabIndex = 5;
            this.stop_btn.Text = "Stop alarm";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alarm:";
            // 
            // alarm_status
            // 
            this.alarm_status.AutoSize = true;
            this.alarm_status.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alarm_status.Location = new System.Drawing.Point(84, 216);
            this.alarm_status.Name = "alarm_status";
            this.alarm_status.Size = new System.Drawing.Size(43, 30);
            this.alarm_status.TabIndex = 7;
            this.alarm_status.Text = "Off";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(400, 268);
            this.Controls.Add(this.alarm_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.set_btn);
            this.Controls.Add(this.AlarmBox);
            this.Controls.Add(this.alarm_lbl);
            this.Controls.Add(this.time_lbl2);
            this.Controls.Add(this.time_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label time_lbl2;
        private System.Windows.Forms.Label alarm_lbl;
        private System.Windows.Forms.TextBox AlarmBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alarm_status;
    }
}

