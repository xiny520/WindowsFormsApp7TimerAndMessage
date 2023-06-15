namespace WindowsFormsApp7TimerAndMessage
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
            this.components = new System.ComponentModel.Container();
            this.btnAOne = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScreen = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnATwo = new System.Windows.Forms.Button();
            this.btnAThree = new System.Windows.Forms.Button();
            this.btnAFour = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.miniCountdown = new System.Windows.Forms.Timer(this.components);
            this.lblMini = new System.Windows.Forms.Label();
            this.lblGo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAOne
            // 
            this.btnAOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAOne.Location = new System.Drawing.Point(489, 90);
            this.btnAOne.Name = "btnAOne";
            this.btnAOne.Size = new System.Drawing.Size(428, 82);
            this.btnAOne.TabIndex = 0;
            this.btnAOne.Text = "Answer 1";
            this.btnAOne.UseVisualStyleBackColor = true;
            this.btnAOne.Click += new System.EventHandler(this.button1_Click);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.Location = new System.Drawing.Point(1080, 94);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(106, 76);
            this.lblScreen.TabIndex = 1;
            this.lblScreen.Text = "00";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(344, 256);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 76);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnATwo
            // 
            this.btnATwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnATwo.Location = new System.Drawing.Point(489, 203);
            this.btnATwo.Name = "btnATwo";
            this.btnATwo.Size = new System.Drawing.Size(428, 78);
            this.btnATwo.TabIndex = 3;
            this.btnATwo.Text = "Answer 2";
            this.btnATwo.UseVisualStyleBackColor = true;
            this.btnATwo.Click += new System.EventHandler(this.btnATwo_Click);
            // 
            // btnAThree
            // 
            this.btnAThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAThree.Location = new System.Drawing.Point(489, 319);
            this.btnAThree.Name = "btnAThree";
            this.btnAThree.Size = new System.Drawing.Size(428, 78);
            this.btnAThree.TabIndex = 4;
            this.btnAThree.Text = "Answer 3";
            this.btnAThree.UseVisualStyleBackColor = true;
            this.btnAThree.Click += new System.EventHandler(this.btnAThree_Click);
            // 
            // btnAFour
            // 
            this.btnAFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAFour.Location = new System.Drawing.Point(489, 436);
            this.btnAFour.Name = "btnAFour";
            this.btnAFour.Size = new System.Drawing.Size(428, 78);
            this.btnAFour.TabIndex = 5;
            this.btnAFour.Text = "Answer 4";
            this.btnAFour.UseVisualStyleBackColor = true;
            this.btnAFour.Click += new System.EventHandler(this.btnAFour_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(81, 212);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(362, 185);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // miniCountdown
            // 
            this.miniCountdown.Interval = 1000;
            this.miniCountdown.Tick += new System.EventHandler(this.miniCountdown_Tick);
            // 
            // lblMini
            // 
            this.lblMini.AutoSize = true;
            this.lblMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMini.Location = new System.Drawing.Point(1082, 280);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(0, 63);
            this.lblMini.TabIndex = 7;
            // 
            // lblGo
            // 
            this.lblGo.AutoSize = true;
            this.lblGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGo.Location = new System.Drawing.Point(1055, 301);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(0, 63);
            this.lblGo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 594);
            this.Controls.Add(this.lblGo);
            this.Controls.Add(this.lblMini);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAFour);
            this.Controls.Add(this.btnAThree);
            this.Controls.Add(this.btnATwo);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.btnAOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAOne;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnATwo;
        private System.Windows.Forms.Button btnAThree;
        private System.Windows.Forms.Button btnAFour;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer miniCountdown;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblGo;
    }
}

