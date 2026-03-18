namespace wf324
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
            txtSpeed = new TextBox();
            trackBarTime = new TrackBar();
            lblSpeed = new Label();
            lblTime = new Label();
            lblDistance = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarTime).BeginInit();
            SuspendLayout();
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(16, 45);
            txtSpeed.Margin = new Padding(4, 5, 4, 5);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(132, 27);
            txtSpeed.TabIndex = 0;
            // 
            // trackBarTime
            // 
            trackBarTime.Location = new Point(16, 117);
            trackBarTime.Margin = new Padding(4, 5, 4, 5);
            trackBarTime.Maximum = 40;
            trackBarTime.Minimum = 10;
            trackBarTime.Name = "trackBarTime";
            trackBarTime.Size = new Size(347, 56);
            trackBarTime.TabIndex = 1;
            trackBarTime.TickFrequency = 5;
            trackBarTime.Value = 10;
            trackBarTime.Scroll += trackBarTime_Scroll;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(16, 20);
            lblSpeed.Margin = new Padding(4, 0, 4, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(76, 20);
            lblSpeed.TabIndex = 2;
            lblSpeed.Text = "Скорость:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(16, 88);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(57, 20);
            lblTime.TabIndex = 3;
            lblTime.Text = "Время:";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(16, 195);
            lblDistance.Margin = new Padding(4, 0, 4, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(95, 20);
            lblDistance.TabIndex = 4;
            lblDistance.Text = "Расстояние: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 243);
            Controls.Add(lblDistance);
            Controls.Add(lblTime);
            Controls.Add(lblSpeed);
            Controls.Add(trackBarTime);
            Controls.Add(txtSpeed);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Расчет пройденного расстояния";
            ((System.ComponentModel.ISupportInitialize)trackBarTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDistance;
    }
}