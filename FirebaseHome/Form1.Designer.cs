namespace FirebaseHome
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TV_ON = new System.Windows.Forms.Button();
            this.TV_OFF = new System.Windows.Forms.Button();
            this.Blind_ON = new System.Windows.Forms.Button();
            this.Blind_OFF = new System.Windows.Forms.Button();
            this.Air_ON = new System.Windows.Forms.Button();
            this.Air_OFF = new System.Windows.Forms.Button();
            this.TV_LED_ON = new System.Windows.Forms.Button();
            this.TV_LED_OFF = new System.Windows.Forms.Button();
            this.BED_ON = new System.Windows.Forms.Button();
            this.BED_OFF = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.Hum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "블라인드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "에어컨";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "TV전등";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "침대전등";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "현재온도 : ";
            // 
            // TV_ON
            // 
            this.TV_ON.Location = new System.Drawing.Point(327, 49);
            this.TV_ON.Name = "TV_ON";
            this.TV_ON.Size = new System.Drawing.Size(75, 23);
            this.TV_ON.TabIndex = 6;
            this.TV_ON.Text = "ON";
            this.TV_ON.UseVisualStyleBackColor = true;
            this.TV_ON.Click += new System.EventHandler(this.TV_ON_Click);
            // 
            // TV_OFF
            // 
            this.TV_OFF.Location = new System.Drawing.Point(399, 49);
            this.TV_OFF.Name = "TV_OFF";
            this.TV_OFF.Size = new System.Drawing.Size(75, 23);
            this.TV_OFF.TabIndex = 7;
            this.TV_OFF.Text = "OFF";
            this.TV_OFF.UseVisualStyleBackColor = true;
            this.TV_OFF.Click += new System.EventHandler(this.TV_OFF_Click);
            // 
            // Blind_ON
            // 
            this.Blind_ON.Location = new System.Drawing.Point(327, 116);
            this.Blind_ON.Name = "Blind_ON";
            this.Blind_ON.Size = new System.Drawing.Size(75, 23);
            this.Blind_ON.TabIndex = 8;
            this.Blind_ON.Text = "ON";
            this.Blind_ON.UseVisualStyleBackColor = true;
            this.Blind_ON.Click += new System.EventHandler(this.Blind_ON_Click);
            // 
            // Blind_OFF
            // 
            this.Blind_OFF.Location = new System.Drawing.Point(399, 116);
            this.Blind_OFF.Name = "Blind_OFF";
            this.Blind_OFF.Size = new System.Drawing.Size(75, 23);
            this.Blind_OFF.TabIndex = 9;
            this.Blind_OFF.Text = "OFF";
            this.Blind_OFF.UseVisualStyleBackColor = true;
            this.Blind_OFF.Click += new System.EventHandler(this.Blind_OFF_Click);
            // 
            // Air_ON
            // 
            this.Air_ON.Location = new System.Drawing.Point(327, 181);
            this.Air_ON.Name = "Air_ON";
            this.Air_ON.Size = new System.Drawing.Size(75, 23);
            this.Air_ON.TabIndex = 10;
            this.Air_ON.Text = "ON";
            this.Air_ON.UseVisualStyleBackColor = true;
            this.Air_ON.Click += new System.EventHandler(this.Air_ON_Click);
            // 
            // Air_OFF
            // 
            this.Air_OFF.Location = new System.Drawing.Point(399, 181);
            this.Air_OFF.Name = "Air_OFF";
            this.Air_OFF.Size = new System.Drawing.Size(75, 23);
            this.Air_OFF.TabIndex = 11;
            this.Air_OFF.Text = "OFF";
            this.Air_OFF.UseVisualStyleBackColor = true;
            this.Air_OFF.Click += new System.EventHandler(this.Air_OFF_Click);
            // 
            // TV_LED_ON
            // 
            this.TV_LED_ON.Location = new System.Drawing.Point(327, 307);
            this.TV_LED_ON.Name = "TV_LED_ON";
            this.TV_LED_ON.Size = new System.Drawing.Size(75, 23);
            this.TV_LED_ON.TabIndex = 12;
            this.TV_LED_ON.Text = "ON";
            this.TV_LED_ON.UseVisualStyleBackColor = true;
            this.TV_LED_ON.Click += new System.EventHandler(this.TV_LED_ON_Click);
            // 
            // TV_LED_OFF
            // 
            this.TV_LED_OFF.Location = new System.Drawing.Point(399, 307);
            this.TV_LED_OFF.Name = "TV_LED_OFF";
            this.TV_LED_OFF.Size = new System.Drawing.Size(75, 23);
            this.TV_LED_OFF.TabIndex = 13;
            this.TV_LED_OFF.Text = "OFF";
            this.TV_LED_OFF.UseVisualStyleBackColor = true;
            this.TV_LED_OFF.Click += new System.EventHandler(this.TV_LED_OFF_Click);
            // 
            // BED_ON
            // 
            this.BED_ON.Location = new System.Drawing.Point(327, 248);
            this.BED_ON.Name = "BED_ON";
            this.BED_ON.Size = new System.Drawing.Size(75, 23);
            this.BED_ON.TabIndex = 14;
            this.BED_ON.Text = "ON";
            this.BED_ON.UseVisualStyleBackColor = true;
            this.BED_ON.Click += new System.EventHandler(this.BED_ON_Click);
            // 
            // BED_OFF
            // 
            this.BED_OFF.Location = new System.Drawing.Point(399, 248);
            this.BED_OFF.Name = "BED_OFF";
            this.BED_OFF.Size = new System.Drawing.Size(75, 23);
            this.BED_OFF.TabIndex = 15;
            this.BED_OFF.Text = "OFF";
            this.BED_OFF.UseVisualStyleBackColor = true;
            this.BED_OFF.Click += new System.EventHandler(this.BED_OFF_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "현재습도:";
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(412, 359);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(52, 15);
            this.Temp.TabIndex = 17;
            this.Temp.Text = "온도값";
            // 
            // Hum
            // 
            this.Hum.AutoSize = true;
            this.Hum.Location = new System.Drawing.Point(412, 396);
            this.Hum.Name = "Hum";
            this.Hum.Size = new System.Drawing.Size(52, 15);
            this.Hum.TabIndex = 18;
            this.Hum.Text = "습도값";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.Hum);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BED_OFF);
            this.Controls.Add(this.BED_ON);
            this.Controls.Add(this.TV_LED_OFF);
            this.Controls.Add(this.TV_LED_ON);
            this.Controls.Add(this.Air_OFF);
            this.Controls.Add(this.Air_ON);
            this.Controls.Add(this.Blind_OFF);
            this.Controls.Add(this.Blind_ON);
            this.Controls.Add(this.TV_OFF);
            this.Controls.Add(this.TV_ON);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "똑똑한우리집";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TV_ON;
        private System.Windows.Forms.Button TV_OFF;
        private System.Windows.Forms.Button Blind_ON;
        private System.Windows.Forms.Button Blind_OFF;
        private System.Windows.Forms.Button Air_ON;
        private System.Windows.Forms.Button Air_OFF;
        private System.Windows.Forms.Button TV_LED_ON;
        private System.Windows.Forms.Button TV_LED_OFF;
        private System.Windows.Forms.Button BED_ON;
        private System.Windows.Forms.Button BED_OFF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label Hum;
    }
}

