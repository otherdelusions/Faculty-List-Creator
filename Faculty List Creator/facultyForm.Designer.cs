namespace Faculty_List_Creator
{
    partial class facultyForm
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
            facultyCancelButton = new Button();
            facultyOKButton = new Button();
            newfacultyBox = new TextBox();
            newfacultyLabel = new Label();
            SuspendLayout();
            // 
            // facultyCancelButton
            // 
            facultyCancelButton.DialogResult = DialogResult.Cancel;
            facultyCancelButton.Location = new Point(98, 116);
            facultyCancelButton.Name = "facultyCancelButton";
            facultyCancelButton.Size = new Size(74, 33);
            facultyCancelButton.TabIndex = 1;
            facultyCancelButton.Text = "Cancel";
            facultyCancelButton.UseVisualStyleBackColor = true;
            facultyCancelButton.Click += facultyCancelButton_Click;
            // 
            // facultyOKButton
            // 
            facultyOKButton.DialogResult = DialogResult.OK;
            facultyOKButton.Location = new Point(12, 116);
            facultyOKButton.Name = "facultyOKButton";
            facultyOKButton.Size = new Size(74, 33);
            facultyOKButton.TabIndex = 2;
            facultyOKButton.Text = "OK";
            facultyOKButton.UseVisualStyleBackColor = true;
            facultyOKButton.Click += facultyOKButton_Click;
            // 
            // newfacultyBox
            // 
            newfacultyBox.Location = new Point(12, 73);
            newfacultyBox.Name = "newfacultyBox";
            newfacultyBox.Size = new Size(160, 23);
            newfacultyBox.TabIndex = 3;
            // 
            // newfacultyLabel
            // 
            newfacultyLabel.AutoSize = true;
            newfacultyLabel.Location = new Point(15, 41);
            newfacultyLabel.Name = "newfacultyLabel";
            newfacultyLabel.Size = new Size(106, 15);
            newfacultyLabel.TabIndex = 4;
            newfacultyLabel.Text = "New faculty name:";
            // 
            // facultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 161);
            Controls.Add(newfacultyLabel);
            Controls.Add(newfacultyBox);
            Controls.Add(facultyOKButton);
            Controls.Add(facultyCancelButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "facultyForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fill in Form";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button facultyCancelButton;
        private Button facultyOKButton;
        private TextBox newfacultyBox;
        private Label newfacultyLabel;
    }
}