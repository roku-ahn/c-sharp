namespace BackgroudWorkerExample
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
            this._bw = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.lb_per = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_reset2 = new System.Windows.Forms.Button();
            this.bt_stopasy = new System.Windows.Forms.Button();
            this.bt_startAsy = new System.Windows.Forms.Button();
            this.lb_result2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this._bw2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // _bw
            // 
            this._bw.WorkerReportsProgress = true;
            this._bw.WorkerSupportsCancellation = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(758, 31);
            this.progressBar1.TabIndex = 0;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(9, 43);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(101, 33);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(138, 43);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(101, 33);
            this.bt_stop.TabIndex = 2;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // lb_per
            // 
            this.lb_per.AutoSize = true;
            this.lb_per.Location = new System.Drawing.Point(17, 17);
            this.lb_per.Name = "lb_per";
            this.lb_per.Size = new System.Drawing.Size(38, 12);
            this.lb_per.TabIndex = 3;
            this.lb_per.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.lb_per);
            this.groupBox1.Controls.Add(this.bt_stop);
            this.groupBox1.Controls.Add(this.bt_start);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(665, 43);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(79, 33);
            this.bt_reset.TabIndex = 4;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_reset2);
            this.groupBox2.Controls.Add(this.bt_stopasy);
            this.groupBox2.Controls.Add(this.bt_startAsy);
            this.groupBox2.Controls.Add(this.lb_result2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(3, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // bt_reset2
            // 
            this.bt_reset2.Location = new System.Drawing.Point(652, 31);
            this.bt_reset2.Name = "bt_reset2";
            this.bt_reset2.Size = new System.Drawing.Size(79, 23);
            this.bt_reset2.TabIndex = 5;
            this.bt_reset2.Text = "Reset";
            this.bt_reset2.UseVisualStyleBackColor = true;
            this.bt_reset2.Click += new System.EventHandler(this.bt_reset2_Click);
            // 
            // bt_stopasy
            // 
            this.bt_stopasy.Location = new System.Drawing.Point(531, 31);
            this.bt_stopasy.Name = "bt_stopasy";
            this.bt_stopasy.Size = new System.Drawing.Size(101, 23);
            this.bt_stopasy.TabIndex = 4;
            this.bt_stopasy.Text = "stop Async";
            this.bt_stopasy.UseVisualStyleBackColor = true;
            this.bt_stopasy.Click += new System.EventHandler(this.bt_stopasy_Click);
            // 
            // bt_startAsy
            // 
            this.bt_startAsy.Location = new System.Drawing.Point(428, 31);
            this.bt_startAsy.Name = "bt_startAsy";
            this.bt_startAsy.Size = new System.Drawing.Size(97, 23);
            this.bt_startAsy.TabIndex = 3;
            this.bt_startAsy.Text = "start Async";
            this.bt_startAsy.UseVisualStyleBackColor = true;
            this.bt_startAsy.Click += new System.EventHandler(this.bt_startAsy_Click);
            // 
            // lb_result2
            // 
            this.lb_result2.AutoSize = true;
            this.lb_result2.Location = new System.Drawing.Point(125, 31);
            this.lb_result2.Name = "lb_result2";
            this.lb_result2.Size = new System.Drawing.Size(38, 12);
            this.lb_result2.TabIndex = 2;
            this.lb_result2.Text = "label2";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 26);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 21);
            this.numericUpDown1.TabIndex = 1;
            // 
            // _bw2
            // 
            this._bw2.WorkerReportsProgress = true;
            this._bw2.WorkerSupportsCancellation = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 227);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker _bw;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Label lb_per;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_stopasy;
        private System.Windows.Forms.Button bt_startAsy;
        private System.Windows.Forms.Label lb_result2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_reset2;
        private System.ComponentModel.BackgroundWorker _bw2;
    }
}

