
namespace Faculty_List_Creator
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
            menuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            facultyToolStripMenuItem = new ToolStripMenuItem();
            deansNameToolStripMenuItem = new ToolStripMenuItem();
            abbreviationToolStripMenuItem = new ToolStripMenuItem();
            FacultyLabel = new Label();
            nameLabel = new Label();
            abbrevLabel = new Label();
            abbrevBox = new TextBox();
            nameBox = new TextBox();
            facultyBox = new TextBox();
            appendButton = new Button();
            outputBox = new TextBox();
            outputLabel = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, editToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(326, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facultyToolStripMenuItem, deansNameToolStripMenuItem, abbreviationToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(91, 20);
            editToolStripMenuItem.Text = "Edit Windows";
            // 
            // facultyToolStripMenuItem
            // 
            facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            facultyToolStripMenuItem.Size = new Size(144, 22);
            facultyToolStripMenuItem.Text = "Faculty";
            facultyToolStripMenuItem.Click += facultyToolStripMenuItem_Click;
            // 
            // deansNameToolStripMenuItem
            // 
            deansNameToolStripMenuItem.Name = "deansNameToolStripMenuItem";
            deansNameToolStripMenuItem.Size = new Size(144, 22);
            deansNameToolStripMenuItem.Text = "Dean's Name";
            deansNameToolStripMenuItem.Click += deansNameToolStripMenuItem_Click;
            // 
            // abbreviationToolStripMenuItem
            // 
            abbreviationToolStripMenuItem.Name = "abbreviationToolStripMenuItem";
            abbreviationToolStripMenuItem.Size = new Size(144, 22);
            abbreviationToolStripMenuItem.Text = "Abbreviation";
            abbreviationToolStripMenuItem.Click += abbreviationToolStripMenuItem_Click;
            // 
            // FacultyLabel
            // 
            FacultyLabel.AutoSize = true;
            FacultyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FacultyLabel.Location = new Point(12, 57);
            FacultyLabel.Name = "FacultyLabel";
            FacultyLabel.Size = new Size(69, 21);
            FacultyLabel.TabIndex = 1;
            FacultyLabel.Text = "Faculty:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(12, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(114, 21);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Dean's Name:";
            // 
            // abbrevLabel
            // 
            abbrevLabel.AutoSize = true;
            abbrevLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            abbrevLabel.Location = new Point(12, 159);
            abbrevLabel.Name = "abbrevLabel";
            abbrevLabel.Size = new Size(114, 21);
            abbrevLabel.TabIndex = 3;
            abbrevLabel.Text = "Abbreviation:";
            // 
            // abbrevBox
            // 
            abbrevBox.Enabled = false;
            abbrevBox.Location = new Point(157, 157);
            abbrevBox.Name = "abbrevBox";
            abbrevBox.ReadOnly = true;
            abbrevBox.Size = new Size(157, 23);
            abbrevBox.TabIndex = 4;
            // 
            // nameBox
            // 
            nameBox.Enabled = false;
            nameBox.Location = new Point(157, 107);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(157, 23);
            nameBox.TabIndex = 5;
            // 
            // facultyBox
            // 
            facultyBox.Enabled = false;
            facultyBox.Location = new Point(157, 59);
            facultyBox.Name = "facultyBox";
            facultyBox.ReadOnly = true;
            facultyBox.Size = new Size(157, 23);
            facultyBox.TabIndex = 6;
            // 
            // appendButton
            // 
            appendButton.Location = new Point(12, 224);
            appendButton.Name = "appendButton";
            appendButton.Size = new Size(148, 27);
            appendButton.TabIndex = 7;
            appendButton.Text = "Append to File";
            appendButton.UseVisualStyleBackColor = true;
            appendButton.Click += appendButton_Click;
            // 
            // outputBox
            // 
            outputBox.Location = new Point(175, 224);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(139, 23);
            outputBox.TabIndex = 8;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(175, 206);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(100, 15);
            outputLabel.TabIndex = 9;
            outputLabel.Text = "Output file name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 263);
            Controls.Add(outputLabel);
            Controls.Add(outputBox);
            Controls.Add(appendButton);
            Controls.Add(facultyBox);
            Controls.Add(nameBox);
            Controls.Add(abbrevBox);
            Controls.Add(abbrevLabel);
            Controls.Add(nameLabel);
            Controls.Add(FacultyLabel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Faculty List Creator";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem facultyToolStripMenuItem;
        private ToolStripMenuItem deansNameToolStripMenuItem;
        private ToolStripMenuItem abbreviationToolStripMenuItem;
        private Label FacultyLabel;
        private Label nameLabel;
        private Label abbrevLabel;
        private TextBox abbrevBox;
        private TextBox nameBox;
        private TextBox facultyBox;
        private Button appendButton;
        private TextBox outputBox;
        private Label outputLabel;
    }
}
