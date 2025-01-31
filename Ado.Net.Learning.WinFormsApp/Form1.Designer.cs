namespace Ado.Net.Learning.WinFormsApp
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            textBoxIns = new TextBox();
            button1 = new Button();
            btnDel = new Button();
            TxtDel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(451, 426);
            dataGridView1.TabIndex = 1;
            // 
            // textBoxIns
            // 
            textBoxIns.BackColor = SystemColors.ActiveCaption;
            textBoxIns.Location = new Point(208, 83);
            textBoxIns.Name = "textBoxIns";
            textBoxIns.Size = new Size(100, 23);
            textBoxIns.TabIndex = 2;
            textBoxIns.Text = "Game Name ";
            textBoxIns.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(221, 112);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Inserer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(221, 213);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 5;
            btnDel.Text = "Supprimer";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // TxtDel
            // 
            TxtDel.BackColor = SystemColors.ActiveCaption;
            TxtDel.Location = new Point(208, 184);
            TxtDel.Name = "TxtDel";
            TxtDel.Size = new Size(100, 23);
            TxtDel.TabIndex = 6;
            TxtDel.Text = "Game Name ";
            TxtDel.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtDel);
            Controls.Add(btnDel);
            Controls.Add(button1);
            Controls.Add(textBoxIns);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxIns;
        private Button button1;
        private Button btnDel;
        private TextBox TxtDel;
    }
}
