namespace _102190064_NguyenIchHoa
{
    partial class NguyenIchHoa_MF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.foodCbb = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortCbb = new System.Windows.Forms.ComboBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.mainDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // foodCbb
            // 
            this.foodCbb.FormattingEnabled = true;
            this.foodCbb.Location = new System.Drawing.Point(97, 28);
            this.foodCbb.Name = "foodCbb";
            this.foodCbb.Size = new System.Drawing.Size(121, 21);
            this.foodCbb.TabIndex = 2;
            this.foodCbb.SelectedValueChanged += new System.EventHandler(this.foodCbb_SelectedValueChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(562, 29);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 20);
            this.searchTxt.TabIndex = 3;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortCbb);
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Controls.Add(this.delBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.mainDgv);
            this.groupBox1.Location = new System.Drawing.Point(33, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 308);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý sản phẩm";
            // 
            // sortCbb
            // 
            this.sortCbb.FormattingEnabled = true;
            this.sortCbb.Location = new System.Drawing.Point(548, 270);
            this.sortCbb.Name = "sortCbb";
            this.sortCbb.Size = new System.Drawing.Size(121, 21);
            this.sortCbb.TabIndex = 5;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(438, 270);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 4;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(314, 270);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Del";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(191, 270);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(64, 270);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // mainDgv
            // 
            this.mainDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDgv.Location = new System.Drawing.Point(6, 30);
            this.mainDgv.Name = "mainDgv";
            this.mainDgv.Size = new System.Drawing.Size(727, 227);
            this.mainDgv.TabIndex = 0;
            // 
            // NguyenIchHoa_MF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.foodCbb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NguyenIchHoa_MF";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox foodCbb;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView mainDgv;
        private System.Windows.Forms.ComboBox sortCbb;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

