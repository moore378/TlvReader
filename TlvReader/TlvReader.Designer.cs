namespace TlvReader
{
    partial class TlvReader
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
            this.txtHex = new System.Windows.Forms.RichTextBox();
            this.dataGridViewTLV = new System.Windows.Forms.DataGridView();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTLV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(12, 12);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(706, 84);
            this.txtHex.TabIndex = 0;
            this.txtHex.Text = "";
            // 
            // dataGridViewTLV
            // 
            this.dataGridViewTLV.AllowUserToAddRows = false;
            this.dataGridViewTLV.AllowUserToDeleteRows = false;
            this.dataGridViewTLV.AllowUserToOrderColumns = true;
            this.dataGridViewTLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTLV.Location = new System.Drawing.Point(13, 137);
            this.dataGridViewTLV.Name = "dataGridViewTLV";
            this.dataGridViewTLV.ReadOnly = true;
            this.dataGridViewTLV.Size = new System.Drawing.Size(705, 287);
            this.dataGridViewTLV.TabIndex = 1;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(643, 104);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 2;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(562, 104);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TlvReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.dataGridViewTLV);
            this.Controls.Add(this.txtHex);
            this.Name = "TlvReader";
            this.Text = "TLV Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHex;
        private System.Windows.Forms.DataGridView dataGridViewTLV;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClear;
    }
}

