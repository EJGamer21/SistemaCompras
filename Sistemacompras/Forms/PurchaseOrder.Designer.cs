﻿namespace Sistemacompras.Forms
{
    partial class PurchaseOrderForm
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
            this.UnitCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusCbx = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DatePckr = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BrandCbx = new System.Windows.Forms.ComboBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RequestCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UnitCbx
            // 
            this.UnitCbx.FormattingEnabled = true;
            this.UnitCbx.Location = new System.Drawing.Point(132, 262);
            this.UnitCbx.Name = "UnitCbx";
            this.UnitCbx.Size = new System.Drawing.Size(121, 21);
            this.UnitCbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad";
            // 
            // ItemCbx
            // 
            this.ItemCbx.FormattingEnabled = true;
            this.ItemCbx.Location = new System.Drawing.Point(132, 183);
            this.ItemCbx.Name = "ItemCbx";
            this.ItemCbx.Size = new System.Drawing.Size(121, 21);
            this.ItemCbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // StatusCbx
            // 
            this.StatusCbx.FormattingEnabled = true;
            this.StatusCbx.Location = new System.Drawing.Point(132, 142);
            this.StatusCbx.Name = "StatusCbx";
            this.StatusCbx.Size = new System.Drawing.Size(121, 21);
            this.StatusCbx.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(132, 391);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 36);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Guardar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(132, 20);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.ReadOnly = true;
            this.IdTxt.Size = new System.Drawing.Size(121, 20);
            this.IdTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Solicitud";
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(132, 223);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(121, 20);
            this.QuantityTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Id Solicitud";
            // 
            // DatePckr
            // 
            this.DatePckr.Location = new System.Drawing.Point(132, 101);
            this.DatePckr.Name = "DatePckr";
            this.DatePckr.Size = new System.Drawing.Size(121, 20);
            this.DatePckr.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Marca";
            // 
            // BrandCbx
            // 
            this.BrandCbx.FormattingEnabled = true;
            this.BrandCbx.Location = new System.Drawing.Point(132, 304);
            this.BrandCbx.Name = "BrandCbx";
            this.BrandCbx.Size = new System.Drawing.Size(121, 21);
            this.BrandCbx.TabIndex = 19;
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(132, 345);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(121, 20);
            this.PriceTxt.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Costo Unitario";
            // 
            // RequestCbx
            // 
            this.RequestCbx.FormattingEnabled = true;
            this.RequestCbx.Location = new System.Drawing.Point(132, 61);
            this.RequestCbx.Name = "RequestCbx";
            this.RequestCbx.Size = new System.Drawing.Size(121, 21);
            this.RequestCbx.TabIndex = 23;
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 439);
            this.Controls.Add(this.RequestCbx);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BrandCbx);
            this.Controls.Add(this.DatePckr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StatusCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitCbx);
            this.Name = "PurchaseOrderForm";
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UnitCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ItemCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StatusCbx;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DatePckr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BrandCbx;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RequestCbx;
    }
}