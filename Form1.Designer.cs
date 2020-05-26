namespace ComPortRead
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SendTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.ReceiveTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BtnReceive = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.butClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Send:";
            // 
            // SendTextBox1
            // 
            this.SendTextBox1.Location = new System.Drawing.Point(58, 177);
            this.SendTextBox1.Name = "SendTextBox1";
            this.SendTextBox1.Size = new System.Drawing.Size(294, 25);
            this.SendTextBox1.TabIndex = 3;
            this.SendTextBox1.Text = "";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(164, 11);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(89, 23);
            this.BtnOpen.TabIndex = 4;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(263, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(89, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(196, 208);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // ReceiveTextBox2
            // 
            this.ReceiveTextBox2.Location = new System.Drawing.Point(58, 40);
            this.ReceiveTextBox2.Name = "ReceiveTextBox2";
            this.ReceiveTextBox2.Size = new System.Drawing.Size(294, 131);
            this.ReceiveTextBox2.TabIndex = 3;
            this.ReceiveTextBox2.Text = "";
            // 
            // BtnReceive
            // 
            this.BtnReceive.Location = new System.Drawing.Point(277, 208);
            this.BtnReceive.Name = "BtnReceive";
            this.BtnReceive.Size = new System.Drawing.Size(75, 23);
            this.BtnReceive.TabIndex = 6;
            this.BtnReceive.Text = "Receive";
            this.BtnReceive.UseVisualStyleBackColor = true;
            this.BtnReceive.Click += new System.EventHandler(this.BtnReceive_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receive:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(115, 208);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 8;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.ButClear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 235);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnReceive);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.ReceiveTextBox2);
            this.Controls.Add(this.SendTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox SendTextBox1;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.RichTextBox ReceiveTextBox2;
        private System.Windows.Forms.Button BtnReceive;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

