namespace Veri_Yapıları_2.Ödev_2.Soru
{
    partial class frmCalismaZamani
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
            this.btnRandomVeri = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandomVeri
            // 
            this.btnRandomVeri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRandomVeri.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandomVeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandomVeri.Location = new System.Drawing.Point(18, 12);
            this.btnRandomVeri.Name = "btnRandomVeri";
            this.btnRandomVeri.Size = new System.Drawing.Size(392, 53);
            this.btnRandomVeri.TabIndex = 0;
            this.btnRandomVeri.Text = "Random Veri Üret";
            this.btnRandomVeri.UseVisualStyleBackColor = false;
            this.btnRandomVeri.Click += new System.EventHandler(this.btnRandomVeri_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelectionSort.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectionSort.Location = new System.Drawing.Point(226, 71);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(184, 52);
            this.btnSelectionSort.TabIndex = 3;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = false;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInsertionSort.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsertionSort.Location = new System.Drawing.Point(18, 129);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(184, 52);
            this.btnInsertionSort.TabIndex = 4;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = false;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQuickSort.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuickSort.Location = new System.Drawing.Point(226, 129);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(184, 52);
            this.btnQuickSort.TabIndex = 5;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = false;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHeapSort.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHeapSort.Location = new System.Drawing.Point(122, 187);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(184, 55);
            this.btnHeapSort.TabIndex = 7;
            this.btnHeapSort.Text = "Heap Sort";
            this.btnHeapSort.UseVisualStyleBackColor = false;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBubbleSort.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBubbleSort.Location = new System.Drawing.Point(18, 71);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(184, 52);
            this.btnBubbleSort.TabIndex = 8;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = false;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // frmCalismaZamani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 254);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnRandomVeri);
            this.Name = "frmCalismaZamani";
            this.Text = "Çalışma Zamanı Kıyaslamaları";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandomVeri;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnBubbleSort;
    }
}

