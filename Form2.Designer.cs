namespace Windows_Forms__.NET_Framework_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Машина = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Выезд = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Выполнение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Начальная_остановка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Конечная_остановка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Груз = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(293, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 65);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Зарегистрировать пользователя";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Машина,
            this.Выезд,
            this.Выполнение,
            this.Начальная_остановка,
            this.Конечная_остановка,
            this.Груз});
            this.dataGridView1.Location = new System.Drawing.Point(26, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 324);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(776, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(776, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(776, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(776, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(776, 187);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(776, 213);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(122, 20);
            this.textBox6.TabIndex = 12;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Машина
            // 
            this.Машина.HeaderText = "Машина";
            this.Машина.Name = "Машина";
            // 
            // Выезд
            // 
            this.Выезд.HeaderText = "Время выезда";
            this.Выезд.Name = "Выезд";
            // 
            // Выполнение
            // 
            this.Выполнение.HeaderText = "Выполнение";
            this.Выполнение.Name = "Выполнение";
            // 
            // Начальная_остановка
            // 
            this.Начальная_остановка.HeaderText = "Начальная остановка";
            this.Начальная_остановка.Name = "Начальная_остановка";
            // 
            // Конечная_остановка
            // 
            this.Конечная_остановка.HeaderText = "Конечная остановка";
            this.Конечная_остановка.Name = "Конечная_остановка";
            // 
            // Груз
            // 
            this.Груз.HeaderText = "Груз";
            this.Груз.Name = "Груз";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(776, 239);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(122, 20);
            this.textBox7.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 412);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Перевозка";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Машина;
        private System.Windows.Forms.DataGridViewTextBoxColumn Выезд;
        private System.Windows.Forms.DataGridViewTextBoxColumn Выполнение;
        private System.Windows.Forms.DataGridViewTextBoxColumn Начальная_остановка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Конечная_остановка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Груз;
        private System.Windows.Forms.TextBox textBox7;
    }
}