namespace WinApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TransportTable = new System.Windows.Forms.ListView();
            this.TransportTypeClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlightNumberClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartureClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketPriceClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeSeatsClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DepartureTb = new System.Windows.Forms.TextBox();
            this.FlightNumberTb = new System.Windows.Forms.TextBox();
            this.TransportTypeTb = new System.Windows.Forms.TextBox();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.FreeSeatsTb = new System.Windows.Forms.TextBox();
            this.TicketPriceTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBttn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IndexTb = new System.Windows.Forms.TextBox();
            this.CategoryTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ResultTb = new System.Windows.Forms.TextBox();
            this.FindCostBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о транспорте";
            // 
            // TransportTable
            // 
            this.TransportTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransportTypeClmn,
            this.FlightNumberClmn,
            this.DepartureClmn,
            this.DestinationClmn,
            this.TicketPriceClmn,
            this.FreeSeatsClmn});
            this.TransportTable.HideSelection = false;
            this.TransportTable.Location = new System.Drawing.Point(9, 59);
            this.TransportTable.Name = "TransportTable";
            this.TransportTable.Size = new System.Drawing.Size(766, 181);
            this.TransportTable.TabIndex = 1;
            this.TransportTable.UseCompatibleStateImageBehavior = false;
            // 
            // TransportTypeClmn
            // 
            this.TransportTypeClmn.Text = "Тип транспорта";
            this.TransportTypeClmn.Width = 127;
            // 
            // FlightNumberClmn
            // 
            this.FlightNumberClmn.Text = "Номер рейса";
            this.FlightNumberClmn.Width = 127;
            // 
            // DepartureClmn
            // 
            this.DepartureClmn.Text = "Пункт отправления";
            this.DepartureClmn.Width = 127;
            // 
            // DestinationClmn
            // 
            this.DestinationClmn.Text = "Пункт прибытия";
            this.DestinationClmn.Width = 127;
            // 
            // TicketPriceClmn
            // 
            this.TicketPriceClmn.Text = "Цена билетов";
            this.TicketPriceClmn.Width = 127;
            // 
            // FreeSeatsClmn
            // 
            this.FreeSeatsClmn.Text = "Свободные места";
            this.FreeSeatsClmn.Width = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип транспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер рейса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(295, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пункт отпр.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(419, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пункт приб.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена билетов";
            // 
            // DepartureTb
            // 
            this.DepartureTb.Location = new System.Drawing.Point(275, 268);
            this.DepartureTb.Name = "DepartureTb";
            this.DepartureTb.Size = new System.Drawing.Size(120, 20);
            this.DepartureTb.TabIndex = 4;
            // 
            // FlightNumberTb
            // 
            this.FlightNumberTb.Location = new System.Drawing.Point(145, 268);
            this.FlightNumberTb.Name = "FlightNumberTb";
            this.FlightNumberTb.Size = new System.Drawing.Size(120, 20);
            this.FlightNumberTb.TabIndex = 3;
            // 
            // TransportTypeTb
            // 
            this.TransportTypeTb.Location = new System.Drawing.Point(15, 268);
            this.TransportTypeTb.Name = "TransportTypeTb";
            this.TransportTypeTb.Size = new System.Drawing.Size(120, 20);
            this.TransportTypeTb.TabIndex = 2;
            // 
            // DestinationTb
            // 
            this.DestinationTb.Location = new System.Drawing.Point(405, 268);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.Size = new System.Drawing.Size(120, 20);
            this.DestinationTb.TabIndex = 5;
            // 
            // FreeSeatsTb
            // 
            this.FreeSeatsTb.Location = new System.Drawing.Point(661, 268);
            this.FreeSeatsTb.Name = "FreeSeatsTb";
            this.FreeSeatsTb.Size = new System.Drawing.Size(120, 20);
            this.FreeSeatsTb.TabIndex = 7;
            // 
            // TicketPriceTb
            // 
            this.TicketPriceTb.Location = new System.Drawing.Point(535, 268);
            this.TicketPriceTb.Name = "TicketPriceTb";
            this.TicketPriceTb.Size = new System.Drawing.Size(120, 20);
            this.TicketPriceTb.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(671, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Своб. места";
            // 
            // addBttn
            // 
            this.addBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.addBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.addBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBttn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBttn.ForeColor = System.Drawing.Color.White;
            this.addBttn.Location = new System.Drawing.Point(275, 308);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(253, 23);
            this.addBttn.TabIndex = 8;
            this.addBttn.Text = "Добавить";
            this.addBttn.UseVisualStyleBackColor = false;
            this.addBttn.Click += new System.EventHandler(this.addBttn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Вывод цены билета";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(13, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Номер транспорта";
            // 
            // IndexTb
            // 
            this.IndexTb.Location = new System.Drawing.Point(27, 409);
            this.IndexTb.Name = "IndexTb";
            this.IndexTb.Size = new System.Drawing.Size(100, 20);
            this.IndexTb.TabIndex = 9;
            // 
            // CategoryTb
            // 
            this.CategoryTb.Location = new System.Drawing.Point(231, 409);
            this.CategoryTb.Name = "CategoryTb";
            this.CategoryTb.Size = new System.Drawing.Size(100, 20);
            this.CategoryTb.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(221, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Категория билета";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(454, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Результат";
            // 
            // ResultTb
            // 
            this.ResultTb.Location = new System.Drawing.Point(437, 409);
            this.ResultTb.Name = "ResultTb";
            this.ResultTb.Size = new System.Drawing.Size(100, 20);
            this.ResultTb.TabIndex = 19;
            // 
            // FindCostBttn
            // 
            this.FindCostBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.FindCostBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.FindCostBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindCostBttn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindCostBttn.ForeColor = System.Drawing.Color.White;
            this.FindCostBttn.Location = new System.Drawing.Point(624, 406);
            this.FindCostBttn.Name = "FindCostBttn";
            this.FindCostBttn.Size = new System.Drawing.Size(75, 23);
            this.FindCostBttn.TabIndex = 20;
            this.FindCostBttn.Text = "Найти";
            this.FindCostBttn.UseVisualStyleBackColor = false;
            this.FindCostBttn.Click += new System.EventHandler(this.FindCostBttn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.FindCostBttn);
            this.Controls.Add(this.ResultTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CategoryTb);
            this.Controls.Add(this.IndexTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addBttn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TicketPriceTb);
            this.Controls.Add(this.FreeSeatsTb);
            this.Controls.Add(this.DestinationTb);
            this.Controls.Add(this.TransportTypeTb);
            this.Controls.Add(this.FlightNumberTb);
            this.Controls.Add(this.DepartureTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransportTable);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView TransportTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DepartureTb;
        private System.Windows.Forms.TextBox FlightNumberTb;
        private System.Windows.Forms.TextBox TransportTypeTb;
        private System.Windows.Forms.TextBox DestinationTb;
        private System.Windows.Forms.TextBox FreeSeatsTb;
        private System.Windows.Forms.TextBox TicketPriceTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBttn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IndexTb;
        private System.Windows.Forms.TextBox CategoryTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ResultTb;
        private System.Windows.Forms.Button FindCostBttn;
        private System.Windows.Forms.ColumnHeader TransportTypeClmn;
        private System.Windows.Forms.ColumnHeader FlightNumberClmn;
        private System.Windows.Forms.ColumnHeader DepartureClmn;
        private System.Windows.Forms.ColumnHeader DestinationClmn;
        private System.Windows.Forms.ColumnHeader TicketPriceClmn;
        private System.Windows.Forms.ColumnHeader FreeSeatsClmn;
    }
}

