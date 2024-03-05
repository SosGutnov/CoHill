
namespace CoHill
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
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSos2 = new System.Windows.Forms.Label();
            this.labelSos1 = new System.Windows.Forms.Label();
            this.textBoxSos2 = new System.Windows.Forms.TextBox();
            this.textBoxSos1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeColumns = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.ColumnHeadersVisible = false;
            this.dataGridViewMain.Location = new System.Drawing.Point(290, 98);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 50;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(212, 194);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(213, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "ШИфрр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(43, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 29);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(43, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 29);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ввод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вывод";
            // 
            // labelSos2
            // 
            this.labelSos2.AutoSize = true;
            this.labelSos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSos2.Location = new System.Drawing.Point(620, 236);
            this.labelSos2.Name = "labelSos2";
            this.labelSos2.Size = new System.Drawing.Size(69, 24);
            this.labelSos2.TabIndex = 9;
            this.labelSos2.Text = "Вывод";
            // 
            // labelSos1
            // 
            this.labelSos1.AutoSize = true;
            this.labelSos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSos1.Location = new System.Drawing.Point(620, 98);
            this.labelSos1.Name = "labelSos1";
            this.labelSos1.Size = new System.Drawing.Size(56, 24);
            this.labelSos1.TabIndex = 8;
            this.labelSos1.Text = "Ввод";
            // 
            // textBoxSos2
            // 
            this.textBoxSos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSos2.Location = new System.Drawing.Point(624, 263);
            this.textBoxSos2.Name = "textBoxSos2";
            this.textBoxSos2.Size = new System.Drawing.Size(146, 29);
            this.textBoxSos2.TabIndex = 7;
            // 
            // textBoxSos1
            // 
            this.textBoxSos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSos1.Location = new System.Drawing.Point(624, 125);
            this.textBoxSos1.Name = "textBoxSos1";
            this.textBoxSos1.Size = new System.Drawing.Size(146, 29);
            this.textBoxSos1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(624, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "РАСшифрр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelSos2);
            this.Controls.Add(this.labelSos1);
            this.Controls.Add(this.textBoxSos2);
            this.Controls.Add(this.textBoxSos1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "Form1";
            this.Text = "Шифр Хилла";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSos2;
        private System.Windows.Forms.Label labelSos1;
        private System.Windows.Forms.TextBox textBoxSos2;
        private System.Windows.Forms.TextBox textBoxSos1;
        private System.Windows.Forms.Button button2;
    }
}

