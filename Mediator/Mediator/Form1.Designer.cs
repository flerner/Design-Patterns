namespace Mediator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxUser1 = new System.Windows.Forms.TextBox();
            this.btnUser1 = new System.Windows.Forms.Button();
            this.listBoxUser1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxUser2 = new System.Windows.Forms.ListBox();
            this.btnUser2 = new System.Windows.Forms.Button();
            this.txtBoxUser2 = new System.Windows.Forms.TextBox();
            this.listBoxAllMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBoxUser1
            // 
            this.txtBoxUser1.Location = new System.Drawing.Point(12, 93);
            this.txtBoxUser1.Name = "txtBoxUser1";
            this.txtBoxUser1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUser1.TabIndex = 0;
            // 
            // btnUser1
            // 
            this.btnUser1.Location = new System.Drawing.Point(12, 154);
            this.btnUser1.Name = "btnUser1";
            this.btnUser1.Size = new System.Drawing.Size(75, 23);
            this.btnUser1.TabIndex = 1;
            this.btnUser1.Text = "Send";
            this.btnUser1.UseVisualStyleBackColor = true;
            this.btnUser1.Click += new System.EventHandler(this.btnUser1_Click);
            // 
            // listBoxUser1
            // 
            this.listBoxUser1.FormattingEnabled = true;
            this.listBoxUser1.Location = new System.Drawing.Point(12, 234);
            this.listBoxUser1.Name = "listBoxUser1";
            this.listBoxUser1.Size = new System.Drawing.Size(270, 134);
            this.listBoxUser1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From User1 to User2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "From User2 to User1";
            // 
            // listBoxUser2
            // 
            this.listBoxUser2.FormattingEnabled = true;
            this.listBoxUser2.Location = new System.Drawing.Point(674, 221);
            this.listBoxUser2.Name = "listBoxUser2";
            this.listBoxUser2.Size = new System.Drawing.Size(275, 147);
            this.listBoxUser2.TabIndex = 6;
            // 
            // btnUser2
            // 
            this.btnUser2.Location = new System.Drawing.Point(674, 154);
            this.btnUser2.Name = "btnUser2";
            this.btnUser2.Size = new System.Drawing.Size(75, 23);
            this.btnUser2.TabIndex = 5;
            this.btnUser2.Text = "Send";
            this.btnUser2.UseVisualStyleBackColor = true;
            this.btnUser2.Click += new System.EventHandler(this.btnUser2_Click);
            // 
            // txtBoxUser2
            // 
            this.txtBoxUser2.Location = new System.Drawing.Point(674, 93);
            this.txtBoxUser2.Name = "txtBoxUser2";
            this.txtBoxUser2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUser2.TabIndex = 4;
            // 
            // listBoxAllMessages
            // 
            this.listBoxAllMessages.FormattingEnabled = true;
            this.listBoxAllMessages.Location = new System.Drawing.Point(311, 78);
            this.listBoxAllMessages.Name = "listBoxAllMessages";
            this.listBoxAllMessages.Size = new System.Drawing.Size(269, 290);
            this.listBoxAllMessages.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 518);
            this.Controls.Add(this.listBoxAllMessages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxUser2);
            this.Controls.Add(this.btnUser2);
            this.Controls.Add(this.txtBoxUser2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUser1);
            this.Controls.Add(this.btnUser1);
            this.Controls.Add(this.txtBoxUser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUser1;
        private System.Windows.Forms.Button btnUser1;
        private System.Windows.Forms.ListBox listBoxUser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxUser2;
        private System.Windows.Forms.Button btnUser2;
        private System.Windows.Forms.TextBox txtBoxUser2;
        private System.Windows.Forms.ListBox listBoxAllMessages;
    }
}

