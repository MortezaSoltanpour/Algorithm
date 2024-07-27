namespace Algorithm
{
    partial class Prefix
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            lblResult = new Label();
            label1 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            btnFound = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "flower", "flow", "flen", "flown", "ab", "cd" });
            listBox1.Location = new Point(356, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(156, 244);
            listBox1.TabIndex = 9;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F);
            lblResult.Location = new Point(197, 367);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(41, 32);
            lblResult.TabIndex = 7;
            lblResult.Text = "[0]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 8;
            label1.Text = "New item";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(197, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add item >>";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(356, 262);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnFound
            // 
            btnFound.Location = new Point(16, 362);
            btnFound.Name = "btnFound";
            btnFound.Size = new Size(122, 52);
            btnFound.TabIndex = 6;
            btnFound.Text = "FoundDuplication";
            btnFound.UseVisualStyleBackColor = true;
            btnFound.Click += btnFound_Click;
            // 
            // Prefix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnFound);
            Name = "Prefix";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prefix";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Label lblResult;
        private Label label1;
        private Button btnAdd;
        private Button btnClear;
        private Button btnFound;
    }
}