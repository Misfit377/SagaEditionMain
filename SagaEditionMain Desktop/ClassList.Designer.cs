namespace SagaEditionMain_Desktop
{
    partial class ClassList
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
            this.submitClassesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitClassesButton
            // 
            this.submitClassesButton.Location = new System.Drawing.Point(684, 403);
            this.submitClassesButton.Name = "submitClassesButton";
            this.submitClassesButton.Size = new System.Drawing.Size(75, 23);
            this.submitClassesButton.TabIndex = 0;
            this.submitClassesButton.Text = "Submit";
            this.submitClassesButton.UseVisualStyleBackColor = true;
            this.submitClassesButton.Click += new System.EventHandler(this.submitClassesButton_Click);
            // 
            // ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitClassesButton);
            this.Name = "ClassList";
            this.Text = "ClassList";
            this.ResumeLayout(false);

        }

        #endregion

        private Button submitClassesButton;
    }
}