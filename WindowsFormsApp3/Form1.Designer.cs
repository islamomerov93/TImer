namespace WindowsFormsApp3
{
    partial class timeForm
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
            this.bakuBtn = new System.Windows.Forms.Button();
            this.londonBtn = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.timeLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bakuBtn
            // 
            this.bakuBtn.BackColor = System.Drawing.Color.DimGray;
            this.bakuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bakuBtn.ForeColor = System.Drawing.Color.Lime;
            this.bakuBtn.Location = new System.Drawing.Point(-5, 378);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Size = new System.Drawing.Size(200, 80);
            this.bakuBtn.TabIndex = 0;
            this.bakuBtn.Text = "BAKU";
            this.bakuBtn.UseVisualStyleBackColor = false;
            this.bakuBtn.Click += new System.EventHandler(this.bakuBtn_Click);
            this.bakuBtn.MouseEnter += new System.EventHandler(this.bakuBtn_MouseEnter);
            this.bakuBtn.MouseLeave += new System.EventHandler(this.bakuBtn_MouseLeave);
            // 
            // londonBtn
            // 
            this.londonBtn.BackColor = System.Drawing.Color.DimGray;
            this.londonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.londonBtn.ForeColor = System.Drawing.Color.Lime;
            this.londonBtn.Location = new System.Drawing.Point(785, 374);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Size = new System.Drawing.Size(200, 80);
            this.londonBtn.TabIndex = 1;
            this.londonBtn.Text = "LONDON";
            this.londonBtn.UseVisualStyleBackColor = false;
            this.londonBtn.Click += new System.EventHandler(this.londonBtn_Click);
            this.londonBtn.MouseEnter += new System.EventHandler(this.londonBtn_MouseEnter);
            this.londonBtn.MouseLeave += new System.EventHandler(this.londonBtn_MouseLeave);
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.SystemColors.Menu;
            this.calendar.ForeColor = System.Drawing.Color.White;
            this.calendar.Location = new System.Drawing.Point(340, 253);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            this.calendar.TitleBackColor = System.Drawing.Color.White;
            this.calendar.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.calendar.TrailingForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // timeLbl
            // 
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Location = new System.Drawing.Point(-5, 2);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(990, 242);
            this.timeLbl.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._D6133EF1FB25AC313FBFF8D71D9FFB83CC04F2C8FF57B392EE_pimgpsh_fullsize_distr;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.londonBtn);
            this.Controls.Add(this.bakuBtn);
            this.Name = "timeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bakuBtn;
        private System.Windows.Forms.Button londonBtn;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer timer1;
    }
}

