namespace Lab1SGBD_NoInput
{
    partial class Form1
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
            this.dataGridGenres = new System.Windows.Forms.DataGridView();
            this.updateDB = new System.Windows.Forms.Button();
            this.dataGridVideos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGenres
            // 
            this.dataGridGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGenres.Location = new System.Drawing.Point(114, 12);
            this.dataGridGenres.Name = "dataGridGenres";
            this.dataGridGenres.Size = new System.Drawing.Size(240, 150);
            this.dataGridGenres.TabIndex = 0;
            // 
            // updateDB
            // 
            this.updateDB.Location = new System.Drawing.Point(473, 395);
            this.updateDB.Name = "updateDB";
            this.updateDB.Size = new System.Drawing.Size(75, 23);
            this.updateDB.TabIndex = 1;
            this.updateDB.Text = "Update";
            this.updateDB.UseVisualStyleBackColor = true;
            this.updateDB.Click += new System.EventHandler(this.updateDB_Click);
            // 
            // dataGridVideos
            // 
            this.dataGridVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVideos.Location = new System.Drawing.Point(114, 213);
            this.dataGridVideos.Name = "dataGridVideos";
            this.dataGridVideos.Size = new System.Drawing.Size(434, 150);
            this.dataGridVideos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridVideos);
            this.Controls.Add(this.updateDB);
            this.Controls.Add(this.dataGridGenres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGenres;
        private System.Windows.Forms.Button updateDB;
        private System.Windows.Forms.DataGridView dataGridVideos;
    }
}

