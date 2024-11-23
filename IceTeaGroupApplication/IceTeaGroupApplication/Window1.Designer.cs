using System;

namespace IceTeaGroupApplication
{
    partial class Window1
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.Lable5 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.txtName = new Wisej.Web.TextBox();
            this.txtStreet = new Wisej.Web.TextBox();
            this.contextMenu3 = new Wisej.Web.ContextMenu(this.components);
            this.txtZip = new Wisej.Web.TextBox();
            this.txtCity = new Wisej.Web.TextBox();
            this.contextMenu4 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu5 = new Wisej.Web.ContextMenu(this.components);
            this.txtCountry = new Wisej.Web.TextBox();
            this.button4 = new Wisej.Web.Button();
            this.Edit = new Wisej.Web.Button();
            this.button6 = new Wisej.Web.Button();
            this.dataGridView = new Wisej.Web.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Zip";
            // 
            // Lable5
            // 
            this.Lable5.AutoSize = true;
            this.Lable5.Location = new System.Drawing.Point(553, 89);
            this.Lable5.Name = "Lable5";
            this.Lable5.Size = new System.Drawing.Size(26, 18);
            this.Lable5.TabIndex = 3;
            this.Lable5.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(40, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 30);
            this.txtName.TabIndex = 5;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(200, 147);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 30);
            this.txtStreet.TabIndex = 6;
            // 
            // contextMenu3
            // 
            this.contextMenu3.Name = "contextMenu3";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(368, 147);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 30);
            this.txtZip.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(534, 147);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 30);
            this.txtCity.TabIndex = 8;
            // 
            // contextMenu4
            // 
            this.contextMenu4.Name = "contextMenu4";
            // 
            // contextMenu5
            // 
            this.contextMenu5.Name = "contextMenu5";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(683, 147);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 30);
            this.txtCountry.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Add";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(298, 399);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 37);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(497, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 37);
            this.button6.TabIndex = 12;
            this.button6.Text = "Delete";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Location = new System.Drawing.Point(862, 147);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(256, 345);
            this.dataGridView.TabIndex = 13;
            //this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // Window1
            // 
            this.ClientSize = new System.Drawing.Size(1193, 644);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lable5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Window1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private Wisej.Web.Button button1;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button button3;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.ContextMenu contextMenu2;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.TextBox textBox3;
        private Wisej.Web.TextBox textBox4;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label Lable5;
        private Wisej.Web.Label label5;
        private Wisej.Web.TextBox txtName;
        private Wisej.Web.TextBox txtStreet;
        private Wisej.Web.ContextMenu contextMenu3;
        private Wisej.Web.TextBox txtZip;
        private Wisej.Web.TextBox txtCity;
        private Wisej.Web.ContextMenu contextMenu4;
        private Wisej.Web.ContextMenu contextMenu5;
        private Wisej.Web.TextBox txtCountry;
        private Wisej.Web.Button button4;
        private Wisej.Web.Button Edit;
        private Wisej.Web.Button button6;
        private Wisej.Web.DataGridView dataGridView;
    }
}

