using System;
using System.Drawing;
using System.Windows.Forms;
namespace ConnectFour
{
    partial class Board
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
            this.one3 = new System.Windows.Forms.Button();
            this.zero0 = new System.Windows.Forms.Button();
            this.one2 = new System.Windows.Forms.Button();
            this.two0 = new System.Windows.Forms.Button();
            this.one1 = new System.Windows.Forms.Button();
            this.one0 = new System.Windows.Forms.Button();
            this.zero3 = new System.Windows.Forms.Button();
            this.zero2 = new System.Windows.Forms.Button();
            this.zero1 = new System.Windows.Forms.Button();
            this.two2 = new System.Windows.Forms.Button();
            this.two1 = new System.Windows.Forms.Button();
            this.three1 = new System.Windows.Forms.Button();
            this.three0 = new System.Windows.Forms.Button();
            this.three2 = new System.Windows.Forms.Button();
            this.two3 = new System.Windows.Forms.Button();
            this.three3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // one3
            // 
            this.one3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one3.Location = new System.Drawing.Point(321, 147);
            this.one3.Name = "one3";
            this.one3.Size = new System.Drawing.Size(90, 90);
            this.one3.TabIndex = 2;
            this.one3.UseVisualStyleBackColor = true;
            this.one3.Click += new System.EventHandler(this.two3_Click);
            // 
            // zero0
            // 
            this.zero0.BackColor = System.Drawing.Color.Transparent;
            this.zero0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zero0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero0.Location = new System.Drawing.Point(51, 57);
            this.zero0.Name = "zero0";
            this.zero0.Size = new System.Drawing.Size(90, 90);
            this.zero0.TabIndex = 0;
            this.zero0.UseVisualStyleBackColor = false;
            this.zero0.Click += new System.EventHandler(this.one0_Click);
            // 
            // one2
            // 
            this.one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one2.Location = new System.Drawing.Point(231, 147);
            this.one2.Name = "one2";
            this.one2.Size = new System.Drawing.Size(90, 90);
            this.one2.TabIndex = 1;
            this.one2.UseVisualStyleBackColor = true;
            this.one2.Click += new System.EventHandler(this.two2_Click);
            // 
            // two0
            // 
            this.two0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two0.Location = new System.Drawing.Point(51, 237);
            this.two0.Name = "two0";
            this.two0.Size = new System.Drawing.Size(90, 90);
            this.two0.TabIndex = 3;
            this.two0.UseVisualStyleBackColor = true;
            // 
            // one1
            // 
            this.one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one1.Location = new System.Drawing.Point(141, 147);
            this.one1.Name = "one1";
            this.one1.Size = new System.Drawing.Size(90, 90);
            this.one1.TabIndex = 4;
            this.one1.UseVisualStyleBackColor = true;
            this.one1.Click += new System.EventHandler(this.two1_Click);
            // 
            // one0
            // 
            this.one0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one0.Location = new System.Drawing.Point(51, 147);
            this.one0.Name = "one0";
            this.one0.Size = new System.Drawing.Size(90, 90);
            this.one0.TabIndex = 5;
            this.one0.UseVisualStyleBackColor = true;
            this.one0.Click += new System.EventHandler(this.two0_Click);
            // 
            // zero3
            // 
            this.zero3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero3.Location = new System.Drawing.Point(321, 57);
            this.zero3.Name = "zero3";
            this.zero3.Size = new System.Drawing.Size(90, 90);
            this.zero3.TabIndex = 6;
            this.zero3.UseVisualStyleBackColor = true;
            this.zero3.Click += new System.EventHandler(this.one3_Click);
            // 
            // zero2
            // 
            this.zero2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero2.Location = new System.Drawing.Point(231, 57);
            this.zero2.Name = "zero2";
            this.zero2.Size = new System.Drawing.Size(90, 90);
            this.zero2.TabIndex = 7;
            this.zero2.UseVisualStyleBackColor = true;
            this.zero2.Click += new System.EventHandler(this.one2_Click);
            // 
            // zero1
            // 
            this.zero1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zero1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero1.Location = new System.Drawing.Point(141, 57);
            this.zero1.Name = "zero1";
            this.zero1.Size = new System.Drawing.Size(90, 90);
            this.zero1.TabIndex = 8;
            this.zero1.UseVisualStyleBackColor = true;
            this.zero1.Click += new System.EventHandler(this.one1_Click);
            // 
            // two2
            // 
            this.two2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two2.Location = new System.Drawing.Point(231, 237);
            this.two2.Name = "two2";
            this.two2.Size = new System.Drawing.Size(90, 90);
            this.two2.TabIndex = 9;
            this.two2.UseVisualStyleBackColor = true;
            // 
            // two1
            // 
            this.two1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two1.Location = new System.Drawing.Point(141, 237);
            this.two1.Name = "two1";
            this.two1.Size = new System.Drawing.Size(90, 90);
            this.two1.TabIndex = 10;
            this.two1.UseVisualStyleBackColor = true;
            // 
            // three1
            // 
            this.three1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three1.Location = new System.Drawing.Point(141, 327);
            this.three1.Name = "three1";
            this.three1.Size = new System.Drawing.Size(90, 90);
            this.three1.TabIndex = 11;
            this.three1.UseVisualStyleBackColor = true;
            // 
            // three0
            // 
            this.three0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three0.Location = new System.Drawing.Point(51, 327);
            this.three0.Name = "three0";
            this.three0.Size = new System.Drawing.Size(90, 90);
            this.three0.TabIndex = 12;
            this.three0.UseVisualStyleBackColor = true;
            // 
            // three2
            // 
            this.three2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three2.Location = new System.Drawing.Point(231, 327);
            this.three2.Name = "three2";
            this.three2.Size = new System.Drawing.Size(90, 90);
            this.three2.TabIndex = 13;
            this.three2.UseVisualStyleBackColor = true;
            // 
            // two3
            // 
            this.two3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two3.Location = new System.Drawing.Point(321, 237);
            this.two3.Name = "two3";
            this.two3.Size = new System.Drawing.Size(90, 90);
            this.two3.TabIndex = 14;
            this.two3.UseVisualStyleBackColor = true;
            // 
            // three3
            // 
            this.three3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three3.Location = new System.Drawing.Point(321, 327);
            this.three3.Name = "three3";
            this.three3.Size = new System.Drawing.Size(90, 90);
            this.three3.TabIndex = 15;
            this.three3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 400);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(66, 11);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 23);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "Drop";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.START_Click_1);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(321, 12);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(90, 23);
            this.btn_3.TabIndex = 18;
            this.btn_3.Text = "Drop";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(231, 11);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(90, 23);
            this.btn_2.TabIndex = 19;
            this.btn_2.Text = "Drop";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(147, 11);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(84, 23);
            this.btn_1.TabIndex = 20;
            this.btn_1.Text = "Drop";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 523);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.three3);
            this.Controls.Add(this.two3);
            this.Controls.Add(this.three2);
            this.Controls.Add(this.three0);
            this.Controls.Add(this.three1);
            this.Controls.Add(this.two1);
            this.Controls.Add(this.two2);
            this.Controls.Add(this.zero1);
            this.Controls.Add(this.zero2);
            this.Controls.Add(this.zero3);
            this.Controls.Add(this.one0);
            this.Controls.Add(this.one1);
            this.Controls.Add(this.two0);
            this.Controls.Add(this.one3);
            this.Controls.Add(this.one2);
            this.Controls.Add(this.zero0);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Board";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);


            gameTree.setNewRoot(arr);
            int[,] bestState = gameTree.getBestState(gameTree.root);
            Array.Copy(bestState, arr, bestState.Length);

            Button[,] moreBtns = new Button[4, 4] { { zero0, one0, two0, three0 }, { zero1, one1, two1, three1 }, { zero2, one2, two2, three2 }, { zero3, one3, two3, three3 } };
            for (int i = 0; i < moreBtns.GetLength(0); i++)
            {
                for (int j = 0; j < moreBtns.GetLength(1); j++)
                {
                    if (arr[i, j] == 1) { moreBtns[j, i].BackColor = Color.Blue; }
                    else if (arr[i, j] == 2) { moreBtns[j, i].BackColor = Color.Red; }
                }



            }



        }

        #endregion

        private System.Windows.Forms.Button zero0;
        private System.Windows.Forms.Button one2;
        private System.Windows.Forms.Button two0;
        private System.Windows.Forms.Button one1;
        private System.Windows.Forms.Button one0;
        private System.Windows.Forms.Button zero3;
        private System.Windows.Forms.Button zero2;
        private System.Windows.Forms.Button zero1;
        private System.Windows.Forms.Button two2;
        private System.Windows.Forms.Button two1;
        private System.Windows.Forms.Button three1;
        private System.Windows.Forms.Button three0;
        private System.Windows.Forms.Button three2;
        private System.Windows.Forms.Button two3;
        private System.Windows.Forms.Button three3;
        private System.Windows.Forms.Button one3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
    }
}

