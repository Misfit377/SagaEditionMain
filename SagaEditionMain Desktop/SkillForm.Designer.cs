namespace SagaEditionMain_Desktop
{
    partial class SkillForm
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
            this.lblSkillTraining = new System.Windows.Forms.Label();
            this.acrobaticsCheckBox = new System.Windows.Forms.CheckBox();
            this.lblDefensesDivider = new System.Windows.Forms.Label();
            this.submitSkillsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSkillTraining
            // 
            this.lblSkillTraining.AutoSize = true;
            this.lblSkillTraining.Location = new System.Drawing.Point(82, 9);
            this.lblSkillTraining.Name = "lblSkillTraining";
            this.lblSkillTraining.Size = new System.Drawing.Size(73, 15);
            this.lblSkillTraining.TabIndex = 0;
            this.lblSkillTraining.Text = "Skill Training";
            // 
            // acrobaticsCheckBox
            // 
            this.acrobaticsCheckBox.AutoSize = true;
            this.acrobaticsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acrobaticsCheckBox.Location = new System.Drawing.Point(72, 40);
            this.acrobaticsCheckBox.Name = "acrobaticsCheckBox";
            this.acrobaticsCheckBox.Size = new System.Drawing.Size(82, 19);
            this.acrobaticsCheckBox.TabIndex = 2;
            this.acrobaticsCheckBox.Text = "Acrobatics";
            this.acrobaticsCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblDefensesDivider
            // 
            this.lblDefensesDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDefensesDivider.Location = new System.Drawing.Point(8, 24);
            this.lblDefensesDivider.Name = "lblDefensesDivider";
            this.lblDefensesDivider.Size = new System.Drawing.Size(780, 2);
            this.lblDefensesDivider.TabIndex = 39;
            // 
            // submitSkillsButton
            // 
            this.submitSkillsButton.Location = new System.Drawing.Point(713, 415);
            this.submitSkillsButton.Name = "submitSkillsButton";
            this.submitSkillsButton.Size = new System.Drawing.Size(75, 23);
            this.submitSkillsButton.TabIndex = 40;
            this.submitSkillsButton.Text = "Submit";
            this.submitSkillsButton.UseVisualStyleBackColor = true;
            this.submitSkillsButton.Click += new System.EventHandler(this.submitSkillsButton_Click);
            // 
            // SkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitSkillsButton);
            this.Controls.Add(this.lblDefensesDivider);
            this.Controls.Add(this.acrobaticsCheckBox);
            this.Controls.Add(this.lblSkillTraining);
            this.Name = "SkillForm";
            this.Text = "SkillForm";
            this.Load += new System.EventHandler(this.SkillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSkillTraining;
        private CheckBox acrobaticsCheckBox;
        private Label lblDefensesDivider;
        private Button submitSkillsButton;
    }
}