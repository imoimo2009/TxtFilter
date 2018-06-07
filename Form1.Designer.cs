namespace TxtFilter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.Tb_InFile = new System.Windows.Forms.TextBox();
            this.Tb_OutFile = new System.Windows.Forms.TextBox();
            this.Btn_Exec = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Btn_InOpen = new System.Windows.Forms.Button();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Tb_Search
            // 
            this.Tb_Search.AllowDrop = true;
            this.Tb_Search.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tb_Search.Location = new System.Drawing.Point(96, 12);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(495, 23);
            this.Tb_Search.TabIndex = 0;
            this.Tb_Search.TextChanged += new System.EventHandler(this.Tb_Search_TextChanged);
            // 
            // Tb_InFile
            // 
            this.Tb_InFile.AllowDrop = true;
            this.Tb_InFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tb_InFile.Location = new System.Drawing.Point(96, 41);
            this.Tb_InFile.Name = "Tb_InFile";
            this.Tb_InFile.Size = new System.Drawing.Size(467, 23);
            this.Tb_InFile.TabIndex = 1;
            this.Tb_InFile.TextChanged += new System.EventHandler(this.Tb_InFile_TextChanged);
            this.Tb_InFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tb_InFile_DragDrop);
            this.Tb_InFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tb_InFile_DragEnter);
            this.Tb_InFile.Leave += new System.EventHandler(this.Tb_InFile_Leave);
            // 
            // Tb_OutFile
            // 
            this.Tb_OutFile.AllowDrop = true;
            this.Tb_OutFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tb_OutFile.Location = new System.Drawing.Point(96, 70);
            this.Tb_OutFile.Name = "Tb_OutFile";
            this.Tb_OutFile.Size = new System.Drawing.Size(467, 23);
            this.Tb_OutFile.TabIndex = 2;
            // 
            // Btn_Exec
            // 
            this.Btn_Exec.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_Exec.Location = new System.Drawing.Point(455, 99);
            this.Btn_Exec.Name = "Btn_Exec";
            this.Btn_Exec.Size = new System.Drawing.Size(65, 22);
            this.Btn_Exec.TabIndex = 3;
            this.Btn_Exec.Text = "抽出";
            this.Btn_Exec.UseVisualStyleBackColor = true;
            this.Btn_Exec.Click += new System.EventHandler(this.Btn_Exec_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_Close.Location = new System.Drawing.Point(526, 98);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(65, 22);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "終了";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "検索文字列：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "入力ファイル：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "出力ファイル：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 101);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(439, 19);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // Btn_InOpen
            // 
            this.Btn_InOpen.Location = new System.Drawing.Point(569, 41);
            this.Btn_InOpen.Name = "Btn_InOpen";
            this.Btn_InOpen.Size = new System.Drawing.Size(22, 23);
            this.Btn_InOpen.TabIndex = 9;
            this.Btn_InOpen.Text = "...";
            this.Btn_InOpen.UseVisualStyleBackColor = true;
            this.Btn_InOpen.Click += new System.EventHandler(this.Btn_InOpen_Click);
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 127);
            this.Controls.Add(this.Btn_InOpen);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Exec);
            this.Controls.Add(this.Tb_OutFile);
            this.Controls.Add(this.Tb_InFile);
            this.Controls.Add(this.Tb_Search);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "テキスト抽出ツール";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Search;
        private System.Windows.Forms.TextBox Tb_InFile;
        private System.Windows.Forms.TextBox Tb_OutFile;
        private System.Windows.Forms.Button Btn_Exec;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Btn_InOpen;
        private System.ComponentModel.BackgroundWorker BackgroundWorker1;
    }
}

