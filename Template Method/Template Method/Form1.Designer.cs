namespace Template_Method
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
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.cboCredits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cboClients
            // 
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(125, 106);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(121, 21);
            this.cboClients.TabIndex = 0;
            // 
            // cboCredits
            // 
            this.cboCredits.FormattingEnabled = true;
            this.cboCredits.Location = new System.Drawing.Point(125, 190);
            this.cboCredits.Name = "cboCredits";
            this.cboCredits.Size = new System.Drawing.Size(121, 21);
            this.cboCredits.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Credits";
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(128, 266);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(128, 316);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(299, 122);
            this.result.TabIndex = 5;
            this.result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCredits);
            this.Controls.Add(this.cboClients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.ComboBox cboCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.RichTextBox result;
    }
}

