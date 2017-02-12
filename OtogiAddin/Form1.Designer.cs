namespace OtogiAddin
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.startFightButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.processLabel = new System.Windows.Forms.Label();
            this.stopTrackButton = new System.Windows.Forms.Button();
            this.stopFightButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Genymotion for personal use - Sony Xperia Z - 4.3 - API 18 - 1080x1920 (800x1280," +
    " 160dpi) - 192.168.172.101";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F);
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otogi視窗名稱";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 429F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 30);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "追蹤滑鼠座標";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startFightButton
            // 
            this.startFightButton.Location = new System.Drawing.Point(493, 87);
            this.startFightButton.Name = "startFightButton";
            this.startFightButton.Size = new System.Drawing.Size(83, 23);
            this.startFightButton.TabIndex = 6;
            this.startFightButton.Text = "開始打怪";
            this.startFightButton.UseVisualStyleBackColor = true;
            this.startFightButton.Click += new System.EventHandler(this.startFightButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "還剩";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timesTextBox
            // 
            this.timesTextBox.Location = new System.Drawing.Point(55, 56);
            this.timesTextBox.Name = "timesTextBox";
            this.timesTextBox.Size = new System.Drawing.Size(100, 25);
            this.timesTextBox.TabIndex = 8;
            this.timesTextBox.Text = "0";
            this.timesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timesTextBox.TextChanged += new System.EventHandler(this.timesTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "次";
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(15, 122);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(67, 15);
            this.processLabel.TabIndex = 10;
            this.processLabel.Text = "現在進程";
            // 
            // stopTrackButton
            // 
            this.stopTrackButton.Location = new System.Drawing.Point(493, 58);
            this.stopTrackButton.Name = "stopTrackButton";
            this.stopTrackButton.Size = new System.Drawing.Size(83, 23);
            this.stopTrackButton.TabIndex = 11;
            this.stopTrackButton.Text = "停止追蹤";
            this.stopTrackButton.UseVisualStyleBackColor = true;
            this.stopTrackButton.Click += new System.EventHandler(this.stopTrackButton_Click);
            // 
            // stopFightButton
            // 
            this.stopFightButton.Location = new System.Drawing.Point(493, 87);
            this.stopFightButton.Name = "stopFightButton";
            this.stopFightButton.Size = new System.Drawing.Size(83, 23);
            this.stopFightButton.TabIndex = 12;
            this.stopFightButton.Text = "停止打怪";
            this.stopFightButton.UseVisualStyleBackColor = true;
            this.stopFightButton.Click += new System.EventHandler(this.stopFightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 172);
            this.Controls.Add(this.stopFightButton);
            this.Controls.Add(this.stopTrackButton);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startFightButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "OtogiAddin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startFightButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Button stopTrackButton;
        private System.Windows.Forms.Button stopFightButton;
    }
}

