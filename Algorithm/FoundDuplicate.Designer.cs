namespace Algorithm
{
    partial class FoundDuplicate
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
            btnFound = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            btnClear = new Button();
            textBox1 = new TextBox();
            btnAdd = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnFound
            // 
            btnFound.Location = new Point(25, 368);
            btnFound.Name = "btnFound";
            btnFound.Size = new Size(122, 52);
            btnFound.TabIndex = 0;
            btnFound.Text = "FoundDuplication";
            btnFound.UseVisualStyleBackColor = true;
            btnFound.Click += btnFound_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "New item";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(365, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 244);
            listBox1.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(365, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(206, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add item >>";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(260, 405);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(21, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "[0]";
            // 
            // FoundDuplicate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 443);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnFound);
            Name = "FoundDuplicate";
            Text = "FoundDuplicate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFound;
        private Label label1;
        private ListBox listBox1;
        private Button btnClear;
        private TextBox textBox1;
        private Button btnAdd;
        private Label lblResult;
    }
}