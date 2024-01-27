﻿
namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            txtCarID = new TextBox();
            lbCarName = new Label();
            txtCarName = new TextBox();
            lbManufacturer = new Label();
            txtManufacturer = new TextBox();
            lbPrice = new Label();
            txtPrice = new TextBox();
            lbReleaseYear = new Label();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(24, 32);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(46, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "CarID";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(130, 25);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(213, 27);
            txtCarID.TabIndex = 1;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(24, 84);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(71, 20);
            lbCarName.TabIndex = 0;
            lbCarName.Text = "CarName";
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(130, 77);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(213, 27);
            txtCarName.TabIndex = 1;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(24, 143);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 0;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(130, 136);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(213, 27);
            txtManufacturer.TabIndex = 1;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(430, 32);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(536, 25);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(214, 27);
            txtPrice.TabIndex = 1;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(430, 84);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 0;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(536, 77);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(214, 27);
            txtReleaseYear.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(130, 200);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(331, 200);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(536, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(35, 249);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(734, 170);
            dgvCarList.TabIndex = 3;
            //dgvCarList.CellContentClick += dgvCarList_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(331, 445);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private TextBox txtCarID;
        private Label lbCarName;
        private TextBox txtCarName;
        private Label lbManufacturer;
        private TextBox txtManufacturer;
        private Label lbPrice;
        private TextBox txtPrice;
        private Label lbReleaseYear;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}