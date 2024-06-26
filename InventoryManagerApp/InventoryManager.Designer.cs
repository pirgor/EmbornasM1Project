namespace InventoryManagerApp
{
    partial class InventoryManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemsTable = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            txtID = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            label3 = new Label();
            txtBrand = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)itemsTable).BeginInit();
            SuspendLayout();
            // 
            // itemsTable
            // 
            itemsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            itemsTable.BackgroundColor = SystemColors.ButtonFace;
            itemsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsTable.Location = new Point(17, 255);
            itemsTable.Name = "itemsTable";
            itemsTable.Size = new Size(616, 295);
            itemsTable.TabIndex = 0;
            itemsTable.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(135, 216);
            button1.Name = "button1";
            button1.Size = new Size(115, 33);
            button1.TabIndex = 1;
            button1.Text = "Show Items";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Montserrat", 12F);
            button2.Location = new Point(297, 216);
            button2.Name = "button2";
            button2.Size = new Size(119, 33);
            button2.TabIndex = 2;
            button2.Text = "Find by ID";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(297, 187);
            txtID.Name = "txtID";
            txtID.Size = new Size(119, 23);
            txtID.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Montserrat", 12F);
            button3.Location = new Point(297, 148);
            button3.Name = "button3";
            button3.Size = new Size(119, 33);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Montserrat", 12F);
            button4.Location = new Point(297, 109);
            button4.Name = "button4";
            button4.Size = new Size(119, 33);
            button4.TabIndex = 5;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Montserrat", 12F);
            button5.Location = new Point(297, 70);
            button5.Name = "button5";
            button5.Size = new Size(119, 33);
            button5.TabIndex = 6;
            button5.Text = "Add New";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Futura BdCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 6);
            label1.Name = "label1";
            label1.Size = new Size(349, 57);
            label1.TabIndex = 7;
            label1.Text = "Inventory Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            label2.Location = new Point(9, 94);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(184, 23);
            txtName.TabIndex = 9;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(66, 123);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(184, 23);
            txtCode.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            label3.Location = new Point(11, 123);
            label3.Name = "label3";
            label3.Size = new Size(53, 22);
            label3.TabIndex = 10;
            label3.Text = "Code";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(66, 156);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(184, 23);
            txtBrand.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            label4.Location = new Point(9, 153);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 12;
            label4.Text = "Brand";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(66, 187);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(184, 23);
            txtPrice.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 187);
            label5.Name = "label5";
            label5.Size = new Size(53, 22);
            label5.TabIndex = 14;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(128, 128, 255);
            label6.Image = Properties.Resources.GGYg5SsaEAAh8O4__1_;
            label6.Location = new Point(433, 40);
            label6.Name = "label6";
            label6.Size = new Size(200, 209);
            label6.TabIndex = 16;
            // 
            // InventoryManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(650, 565);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(txtBrand);
            Controls.Add(label4);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtID);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(itemsTable);
            Name = "InventoryManager";
            Text = "Inventory Manager by Embornas";
            ((System.ComponentModel.ISupportInitialize)itemsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView itemsTable;
        private Button button1;
        private Button button2;
        private TextBox txtID;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtCode;
        private Label label3;
        private TextBox txtBrand;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private Label label6;
    }
}
