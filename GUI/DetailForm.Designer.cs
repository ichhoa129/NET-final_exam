namespace _102190064_NguyenIchHoa.GUI
{
    partial class NguyenIchHoa_DF
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
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.maTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusCbb = new System.Windows.Forms.ComboBox();
            this.tenNguyenLieuTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nguyên liệu";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(176, 140);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(202, 20);
            this.quantityTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // unitTxt
            // 
            this.unitTxt.Location = new System.Drawing.Point(176, 212);
            this.unitTxt.Name = "unitTxt";
            this.unitTxt.Size = new System.Drawing.Size(202, 20);
            this.unitTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tình trạng";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(65, 342);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(234, 342);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // maTxt
            // 
            this.maTxt.Location = new System.Drawing.Point(176, 27);
            this.maTxt.MaxLength = 5;
            this.maTxt.Name = "maTxt";
            this.maTxt.Size = new System.Drawing.Size(202, 20);
            this.maTxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã ";
            // 
            // statusCbb
            // 
            this.statusCbb.FormattingEnabled = true;
            this.statusCbb.Items.AddRange(new object[] {
            "Đã nhập hàng",
            "Chưa nhập hàng"});
            this.statusCbb.Location = new System.Drawing.Point(176, 275);
            this.statusCbb.Name = "statusCbb";
            this.statusCbb.Size = new System.Drawing.Size(202, 21);
            this.statusCbb.TabIndex = 12;
            // 
            // tenNguyenLieuTxt
            // 
            this.tenNguyenLieuTxt.Location = new System.Drawing.Point(176, 83);
            this.tenNguyenLieuTxt.MaxLength = 324234324;
            this.tenNguyenLieuTxt.Name = "tenNguyenLieuTxt";
            this.tenNguyenLieuTxt.Size = new System.Drawing.Size(202, 20);
            this.tenNguyenLieuTxt.TabIndex = 14;
            // 
            // NguyenIchHoa_DF
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 390);
            this.Controls.Add(this.tenNguyenLieuTxt);
            this.Controls.Add(this.statusCbb);
            this.Controls.Add(this.maTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unitTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NguyenIchHoa_DF";
            this.Text = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox maTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusCbb;
        private System.Windows.Forms.TextBox tenNguyenLieuTxt;
    }
}