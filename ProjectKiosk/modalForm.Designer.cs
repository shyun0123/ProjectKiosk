namespace ProjectKiosk
{
    partial class modalForm
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
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new System.Drawing.Point(-2, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(397, 97);
            textBox1.TabIndex = 0;
            textBox1.Text = "이 키오스크는 메이저리그 FA 이적시장에서 선수를 구매하는것입니다.\r\n선수에게 계약기간을 제시하고 이를 선수가 거절할수도 있습니다.\r\n샐러리캡과 예산을 신경써서 최고의 선수를 영입하십시오.\r\n\r\n샐러리캡: 한 시즌에 선수 연봉으로 쓸수 있는 금액\r\n예산: 이번 FA에서 쓸수 있는 총 금액\r\n\r\n";
            // 
            // modalForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(394, 95);
            Controls.Add(textBox1);
            Name = "modalForm";
            Text = "도움말";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}