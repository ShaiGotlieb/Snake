namespace MySnakeApp
{
    partial class SnakeForm
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
            this.components = new System.ComponentModel.Container();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.spacebarLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.scoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.scoreCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.logoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.headlineLabel.Location = new System.Drawing.Point(138, 14);
            this.headlineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(122, 37);
            this.headlineLabel.TabIndex = 0;
            this.headlineLabel.Text = "Snake!";
            // 
            // spacebarLabel
            // 
            this.spacebarLabel.AutoSize = true;
            this.spacebarLabel.Location = new System.Drawing.Point(114, 235);
            this.spacebarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spacebarLabel.Name = "spacebarLabel";
            this.spacebarLabel.Size = new System.Drawing.Size(179, 20);
            this.spacebarLabel.TabIndex = 1;
            this.spacebarLabel.Text = "press spacebar to begin";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreLabel,
            this.scoreCounter,
            this.logoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(435, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(67, 25);
            this.scoreLabel.Text = "SCORE";
            // 
            // scoreCounter
            // 
            this.scoreCounter.Name = "scoreCounter";
            this.scoreCounter.Size = new System.Drawing.Size(22, 25);
            this.scoreCounter.Text = "0";
            // 
            // logoLabel
            // 
            this.logoLabel.Margin = new System.Windows.Forms.Padding(160, 3, 0, 2);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(107, 25);
            this.logoLabel.Text = "Shai Gotlieb";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "©Shai Gotlieb ";
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(435, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.spacebarLabel);
            this.Controls.Add(this.headlineLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SnakeForm";
            this.Text = "Snake!";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SnakeForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label spacebarLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel scoreLabel;
        private System.Windows.Forms.ToolStripStatusLabel scoreCounter;
        private System.Windows.Forms.ToolStripStatusLabel logoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

