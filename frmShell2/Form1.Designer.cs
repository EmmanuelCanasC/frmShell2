namespace frmShell2
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
            txtNumbers = new TextBox();
            txtSortedNumbers = new TextBox();
            btnSort = new Button();
            SuspendLayout();
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(139, 33);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(100, 23);
            txtNumbers.TabIndex = 0;
            // 
            // txtSortedNumbers
            // 
            txtSortedNumbers.Location = new Point(139, 87);
            txtSortedNumbers.Name = "txtSortedNumbers";
            txtSortedNumbers.Size = new Size(100, 23);
            txtSortedNumbers.TabIndex = 1;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(139, 139);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 2;
            btnSort.Text = "ordenar";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSort);
            Controls.Add(txtSortedNumbers);
            Controls.Add(txtNumbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumbers;
        private TextBox txtSortedNumbers;
        private Button btnSort;
    }
}