
namespace Trenirovochka
{
    partial class AddNewRecord
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
            this.AddNewRecordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newrecordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newdateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddNewRecordButton
            // 
            this.AddNewRecordButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewRecordButton.Location = new System.Drawing.Point(116, 358);
            this.AddNewRecordButton.Name = "AddNewRecordButton";
            this.AddNewRecordButton.Size = new System.Drawing.Size(539, 80);
            this.AddNewRecordButton.TabIndex = 0;
            this.AddNewRecordButton.Text = "Добавить новую запись";
            this.AddNewRecordButton.UseVisualStyleBackColor = true;
            this.AddNewRecordButton.Click += new System.EventHandler(this.AddNewRecordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название монеты";
            // 
            // newrecordBox
            // 
            this.newrecordBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newrecordBox.Location = new System.Drawing.Point(391, 109);
            this.newrecordBox.Name = "newrecordBox";
            this.newrecordBox.Size = new System.Drawing.Size(235, 53);
            this.newrecordBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(262, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата";
            // 
            // newdateBox
            // 
            this.newdateBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newdateBox.Location = new System.Drawing.Point(391, 178);
            this.newdateBox.Name = "newdateBox";
            this.newdateBox.Size = new System.Drawing.Size(64, 53);
            this.newdateBox.TabIndex = 5;
            // 
            // AddNewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.newdateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newrecordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNewRecordButton);
            this.Name = "AddNewRecord";
            this.Text = "AddNewRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewRecordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newrecordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newdateBox;
    }
}