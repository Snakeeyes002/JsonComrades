namespace JsonComrades.Forms
{
    partial class ToDoForm
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
            this.dgToDo = new System.Windows.Forms.DataGridView();
            this.bPostForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgToDo
            // 
            this.dgToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgToDo.Location = new System.Drawing.Point(13, 13);
            this.dgToDo.Name = "dgToDo";
            this.dgToDo.RowTemplate.Height = 24;
            this.dgToDo.Size = new System.Drawing.Size(601, 425);
            this.dgToDo.TabIndex = 0;
            this.dgToDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgToDo_CellContentClick);
            // 
            // bPostForm
            // 
            this.bPostForm.Location = new System.Drawing.Point(630, 35);
            this.bPostForm.Name = "bPostForm";
            this.bPostForm.Size = new System.Drawing.Size(75, 23);
            this.bPostForm.TabIndex = 1;
            this.bPostForm.Text = "Post";
            this.bPostForm.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bPostForm);
            this.Controls.Add(this.dgToDo);
            this.Name = "ToDoForm";
            this.Text = "ToDoForm";
            this.Load += new System.EventHandler(this.ToDoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgToDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgToDo;
        private System.Windows.Forms.Button bPostForm;
        private System.Windows.Forms.Button button2;
    }
}