namespace JsonComrades.Forms
{
    partial class FormComments
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
            this.dataGV_Comments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Comments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_Comments
            // 
            this.dataGV_Comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Comments.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGV_Comments.Location = new System.Drawing.Point(0, 0);
            this.dataGV_Comments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGV_Comments.Name = "dataGV_Comments";
            this.dataGV_Comments.Size = new System.Drawing.Size(1067, 523);
            this.dataGV_Comments.TabIndex = 0;
            this.dataGV_Comments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Comments_CellContentClick);
            // 
            // FormComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGV_Comments);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComments";
            this.Text = "FormComments";
            this.Load += new System.EventHandler(this.FormComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Comments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_Comments;
    }
}