namespace Sequential_And_Binary_Search
{
    partial class Form2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.button_Random = new System.Windows.Forms.Button();
            this.labelSequentialTitle = new System.Windows.Forms.Label();
            this.labelRandom = new System.Windows.Forms.Label();
            this.labelSequential = new System.Windows.Forms.Label();
            this.button_SequentialSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_BinaryTitle = new System.Windows.Forms.Label();
            this.label_BinaryExplanation = new System.Windows.Forms.Label();
            this.label_BinaryOn = new System.Windows.Forms.Label();
            this.label_BinarySuitableSituation = new System.Windows.Forms.Label();
            this.textBox_Binary = new System.Windows.Forms.TextBox();
            this.button_Binary = new System.Windows.Forms.Button();
            this.label_Binary = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Random
            // 
            this.button_Random.Location = new System.Drawing.Point(180, 342);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(75, 23);
            this.button_Random.TabIndex = 0;
            this.button_Random.Text = "產生亂數";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_SequentialRandom_Click);
            // 
            // labelSequentialTitle
            // 
            this.labelSequentialTitle.AutoSize = true;
            this.labelSequentialTitle.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSequentialTitle.ForeColor = System.Drawing.Color.Blue;
            this.labelSequentialTitle.Location = new System.Drawing.Point(20, 9);
            this.labelSequentialTitle.Name = "labelSequentialTitle";
            this.labelSequentialTitle.Size = new System.Drawing.Size(157, 21);
            this.labelSequentialTitle.TabIndex = 1;
            this.labelSequentialTitle.Text = "循序排列搜尋法";
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRandom.Location = new System.Drawing.Point(177, 306);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(136, 16);
            this.labelRandom.TabIndex = 2;
            this.labelRandom.Text = "產生十個亂數值：";
            // 
            // labelSequential
            // 
            this.labelSequential.AutoSize = true;
            this.labelSequential.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSequential.Location = new System.Drawing.Point(20, 166);
            this.labelSequential.Name = "labelSequential";
            this.labelSequential.Size = new System.Drawing.Size(104, 16);
            this.labelSequential.TabIndex = 3;
            this.labelSequential.Text = "搜尋的數值：";
            // 
            // button_SequentialSearch
            // 
            this.button_SequentialSearch.Location = new System.Drawing.Point(132, 126);
            this.button_SequentialSearch.Name = "button_SequentialSearch";
            this.button_SequentialSearch.Size = new System.Drawing.Size(75, 23);
            this.button_SequentialSearch.TabIndex = 4;
            this.button_SequentialSearch.Text = "搜尋";
            this.button_SequentialSearch.UseVisualStyleBackColor = true;
            this.button_SequentialSearch.Click += new System.EventHandler(this.button_SequentialSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "缺點：搜尋效率(平均次數N + 1 / 2)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "時間複雜度：平均為O(N)，最小為O(1)";
            // 
            // label_BinaryTitle
            // 
            this.label_BinaryTitle.AutoSize = true;
            this.label_BinaryTitle.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_BinaryTitle.ForeColor = System.Drawing.Color.Blue;
            this.label_BinaryTitle.Location = new System.Drawing.Point(379, 9);
            this.label_BinaryTitle.Name = "label_BinaryTitle";
            this.label_BinaryTitle.Size = new System.Drawing.Size(115, 21);
            this.label_BinaryTitle.TabIndex = 8;
            this.label_BinaryTitle.Text = "二元搜尋法";
            // 
            // label_BinaryExplanation
            // 
            this.label_BinaryExplanation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_BinaryExplanation.Location = new System.Drawing.Point(380, 45);
            this.label_BinaryExplanation.Name = "label_BinaryExplanation";
            this.label_BinaryExplanation.Size = new System.Drawing.Size(408, 62);
            this.label_BinaryExplanation.TabIndex = 9;
            this.label_BinaryExplanation.Text = "必須先將資料排序。　　　　　　　　　　　　　　　　先將資料排列，再分割成兩部分，並利用鍵值與中間值來比較打大小。";
            // 
            // label_BinaryOn
            // 
            this.label_BinaryOn.AutoSize = true;
            this.label_BinaryOn.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_BinaryOn.Location = new System.Drawing.Point(382, 246);
            this.label_BinaryOn.Name = "label_BinaryOn";
            this.label_BinaryOn.Size = new System.Drawing.Size(142, 13);
            this.label_BinaryOn.TabIndex = 14;
            this.label_BinaryOn.Text = "時間複雜度：log2(N) + 1";
            // 
            // label_BinarySuitableSituation
            // 
            this.label_BinarySuitableSituation.AutoSize = true;
            this.label_BinarySuitableSituation.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_BinarySuitableSituation.ForeColor = System.Drawing.Color.Red;
            this.label_BinarySuitableSituation.Location = new System.Drawing.Point(379, 209);
            this.label_BinarySuitableSituation.Name = "label_BinarySuitableSituation";
            this.label_BinarySuitableSituation.Size = new System.Drawing.Size(172, 15);
            this.label_BinarySuitableSituation.TabIndex = 13;
            this.label_BinarySuitableSituation.Text = "適合時機：已經排序完成";
            // 
            // textBox_Binary
            // 
            this.textBox_Binary.Location = new System.Drawing.Point(382, 126);
            this.textBox_Binary.Name = "textBox_Binary";
            this.textBox_Binary.Size = new System.Drawing.Size(100, 22);
            this.textBox_Binary.TabIndex = 12;
            // 
            // button_Binary
            // 
            this.button_Binary.Location = new System.Drawing.Point(493, 126);
            this.button_Binary.Name = "button_Binary";
            this.button_Binary.Size = new System.Drawing.Size(75, 23);
            this.button_Binary.TabIndex = 11;
            this.button_Binary.Text = "搜尋";
            this.button_Binary.UseVisualStyleBackColor = true;
            this.button_Binary.Click += new System.EventHandler(this.button_Binary_Click);
            // 
            // label_Binary
            // 
            this.label_Binary.AutoSize = true;
            this.label_Binary.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Binary.Location = new System.Drawing.Point(379, 166);
            this.label_Binary.Name = "label_Binary";
            this.label_Binary.Size = new System.Drawing.Size(104, 16);
            this.label_Binary.TabIndex = 10;
            this.label_Binary.Text = "搜尋的數值：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "SortRandom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_BinaryOn);
            this.Controls.Add(this.label_BinarySuitableSituation);
            this.Controls.Add(this.textBox_Binary);
            this.Controls.Add(this.button_Binary);
            this.Controls.Add(this.label_Binary);
            this.Controls.Add(this.label_BinaryExplanation);
            this.Controls.Add(this.label_BinaryTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_SequentialSearch);
            this.Controls.Add(this.labelSequential);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.labelSequentialTitle);
            this.Controls.Add(this.button_Random);
            this.Name = "Form2";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.Label labelSequentialTitle;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label labelSequential;
        private System.Windows.Forms.Button button_SequentialSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_BinaryTitle;
        private System.Windows.Forms.Label label_BinaryExplanation;
        private System.Windows.Forms.Label label_BinaryOn;
        private System.Windows.Forms.Label label_BinarySuitableSituation;
        private System.Windows.Forms.TextBox textBox_Binary;
        private System.Windows.Forms.Button button_Binary;
        private System.Windows.Forms.Label label_Binary;
        private System.Windows.Forms.Button button1;
    }
}

