
namespace Trenirovochka
{
    partial class MainMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewRecordButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.FindRecordButton = new System.Windows.Forms.Button();
            this.DeleteBox = new System.Windows.Forms.TextBox();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.UpdateRecordButton = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 415);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название монеты";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // NewRecordButton
            // 
            this.NewRecordButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewRecordButton.Location = new System.Drawing.Point(401, 85);
            this.NewRecordButton.Name = "NewRecordButton";
            this.NewRecordButton.Size = new System.Drawing.Size(530, 65);
            this.NewRecordButton.TabIndex = 2;
            this.NewRecordButton.Text = "Добавить новую запись";
            this.NewRecordButton.UseVisualStyleBackColor = true;
            this.NewRecordButton.Click += new System.EventHandler(this.NewRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRecordButton.Location = new System.Drawing.Point(543, 279);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(388, 65);
            this.DeleteRecordButton.TabIndex = 3;
            this.DeleteRecordButton.Text = "Удалить запись";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // FindRecordButton
            // 
            this.FindRecordButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindRecordButton.Location = new System.Drawing.Point(543, 350);
            this.FindRecordButton.Name = "FindRecordButton";
            this.FindRecordButton.Size = new System.Drawing.Size(388, 65);
            this.FindRecordButton.TabIndex = 4;
            this.FindRecordButton.Text = "Поиск по номеру";
            this.FindRecordButton.UseVisualStyleBackColor = true;
            this.FindRecordButton.Click += new System.EventHandler(this.FindRecordButton_Click);
            // 
            // DeleteBox
            // 
            this.DeleteBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBox.Location = new System.Drawing.Point(421, 284);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(100, 53);
            this.DeleteBox.TabIndex = 5;
            // 
            // FindBox
            // 
            this.FindBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindBox.Location = new System.Drawing.Point(421, 355);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(100, 53);
            this.FindBox.TabIndex = 6;
            // 
            // UpdateRecordButton
            // 
            this.UpdateRecordButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRecordButton.Location = new System.Drawing.Point(401, 156);
            this.UpdateRecordButton.Name = "UpdateRecordButton";
            this.UpdateRecordButton.Size = new System.Drawing.Size(530, 65);
            this.UpdateRecordButton.TabIndex = 7;
            this.UpdateRecordButton.Text = "Обновить запись";
            this.UpdateRecordButton.UseVisualStyleBackColor = true;
            this.UpdateRecordButton.Click += new System.EventHandler(this.UpdateRecordButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUserButton.Location = new System.Drawing.Point(401, 12);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(530, 67);
            this.NewUserButton.TabIndex = 8;
            this.NewUserButton.Text = "Добавить нового пользователя";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.UpdateRecordButton);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.DeleteBox);
            this.Controls.Add(this.FindRecordButton);
            this.Controls.Add(this.DeleteRecordButton);
            this.Controls.Add(this.NewRecordButton);
            this.Controls.Add(this.listView1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button NewRecordButton;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button FindRecordButton;
        private System.Windows.Forms.TextBox DeleteBox;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.Button UpdateRecordButton;
        private System.Windows.Forms.Button NewUserButton;
    }
}