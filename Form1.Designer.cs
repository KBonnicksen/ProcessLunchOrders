namespace ProcessLunchOrders
{
    partial class frmLunchOrder
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
            this.grbMainCourse = new System.Windows.Forms.GroupBox();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.grbAddOns = new System.Windows.Forms.GroupBox();
            this.chkAddon3 = new System.Windows.Forms.CheckBox();
            this.chkAddon2 = new System.Windows.Forms.CheckBox();
            this.chkAddon1 = new System.Windows.Forms.CheckBox();
            this.grbOrderTotal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.grbMainCourse.SuspendLayout();
            this.grbAddOns.SuspendLayout();
            this.grbOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMainCourse
            // 
            this.grbMainCourse.AutoSize = true;
            this.grbMainCourse.Controls.Add(this.radSalad);
            this.grbMainCourse.Controls.Add(this.radPizza);
            this.grbMainCourse.Controls.Add(this.radHamburger);
            this.grbMainCourse.Location = new System.Drawing.Point(31, 28);
            this.grbMainCourse.Name = "grbMainCourse";
            this.grbMainCourse.Size = new System.Drawing.Size(272, 179);
            this.grbMainCourse.TabIndex = 0;
            this.grbMainCourse.TabStop = false;
            this.grbMainCourse.Text = "Main course";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(31, 134);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(114, 21);
            this.radSalad.TabIndex = 6;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad - $4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.Click += new System.EventHandler(this.radSalad_Click);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(31, 84);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(112, 21);
            this.radPizza.TabIndex = 7;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.Click += new System.EventHandler(this.RadPizza_Click);
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Location = new System.Drawing.Point(31, 35);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(149, 21);
            this.radHamburger.TabIndex = 8;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger - $6.95";
            this.radHamburger.UseVisualStyleBackColor = true;
            this.radHamburger.Click += new System.EventHandler(this.RadHamburger_Click);
            // 
            // grbAddOns
            // 
            this.grbAddOns.AutoSize = true;
            this.grbAddOns.Controls.Add(this.chkAddon3);
            this.grbAddOns.Controls.Add(this.chkAddon2);
            this.grbAddOns.Controls.Add(this.chkAddon1);
            this.grbAddOns.Location = new System.Drawing.Point(322, 28);
            this.grbAddOns.Name = "grbAddOns";
            this.grbAddOns.Size = new System.Drawing.Size(339, 179);
            this.grbAddOns.TabIndex = 0;
            this.grbAddOns.TabStop = false;
            this.grbAddOns.Text = "Add-on items";
            // 
            // chkAddon3
            // 
            this.chkAddon3.AutoSize = true;
            this.chkAddon3.Location = new System.Drawing.Point(30, 135);
            this.chkAddon3.Name = "chkAddon3";
            this.chkAddon3.Size = new System.Drawing.Size(98, 21);
            this.chkAddon3.TabIndex = 3;
            this.chkAddon3.Text = "checkBox1";
            this.chkAddon3.UseVisualStyleBackColor = true;
            this.chkAddon3.Visible = false;
            this.chkAddon3.CheckedChanged += new System.EventHandler(this.ChkAddOns_CheckedChanged);
            // 
            // chkAddon2
            // 
            this.chkAddon2.AutoSize = true;
            this.chkAddon2.Location = new System.Drawing.Point(30, 85);
            this.chkAddon2.Name = "chkAddon2";
            this.chkAddon2.Size = new System.Drawing.Size(98, 21);
            this.chkAddon2.TabIndex = 4;
            this.chkAddon2.Text = "checkBox2";
            this.chkAddon2.UseVisualStyleBackColor = true;
            this.chkAddon2.Visible = false;
            this.chkAddon2.CheckedChanged += new System.EventHandler(this.ChkAddOns_CheckedChanged);
            // 
            // chkAddon1
            // 
            this.chkAddon1.AutoSize = true;
            this.chkAddon1.Location = new System.Drawing.Point(30, 35);
            this.chkAddon1.Name = "chkAddon1";
            this.chkAddon1.Size = new System.Drawing.Size(98, 21);
            this.chkAddon1.TabIndex = 5;
            this.chkAddon1.Text = "checkBox3";
            this.chkAddon1.UseVisualStyleBackColor = true;
            this.chkAddon1.Visible = false;
            this.chkAddon1.CheckedChanged += new System.EventHandler(this.ChkAddOns_CheckedChanged);
            // 
            // grbOrderTotal
            // 
            this.grbOrderTotal.AutoSize = true;
            this.grbOrderTotal.Controls.Add(this.label1);
            this.grbOrderTotal.Controls.Add(this.label2);
            this.grbOrderTotal.Controls.Add(this.label3);
            this.grbOrderTotal.Controls.Add(this.txtTotal);
            this.grbOrderTotal.Controls.Add(this.txtTax);
            this.grbOrderTotal.Controls.Add(this.txtSubtotal);
            this.grbOrderTotal.Location = new System.Drawing.Point(31, 233);
            this.grbOrderTotal.Name = "grbOrderTotal";
            this.grbOrderTotal.Size = new System.Drawing.Size(355, 167);
            this.grbOrderTotal.TabIndex = 0;
            this.grbOrderTotal.TabStop = false;
            this.grbOrderTotal.Text = "Order total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax (7.75%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subtotal:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(172, 124);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 6;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(172, 80);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(172, 36);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(495, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(495, 254);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(114, 46);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 429);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbAddOns);
            this.Controls.Add(this.grbOrderTotal);
            this.Controls.Add(this.grbMainCourse);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.grbMainCourse.ResumeLayout(false);
            this.grbMainCourse.PerformLayout();
            this.grbAddOns.ResumeLayout(false);
            this.grbAddOns.PerformLayout();
            this.grbOrderTotal.ResumeLayout(false);
            this.grbOrderTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMainCourse;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.GroupBox grbAddOns;
        private System.Windows.Forms.CheckBox chkAddon3;
        private System.Windows.Forms.CheckBox chkAddon2;
        private System.Windows.Forms.CheckBox chkAddon1;
        private System.Windows.Forms.GroupBox grbOrderTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}

