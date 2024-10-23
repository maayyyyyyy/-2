using System;

namespace Kfkfkfkf
{
    partial class Avtorisacia
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.avto = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // avto
            // 
            this.avto.Location = new System.Drawing.Point(289, 266);
            this.avto.Name = "avto";
            this.avto.Size = new System.Drawing.Size(313, 84);
            this.avto.TabIndex = 0;
            this.avto.Text = "НАЖМИ";
            this.avto.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(310, 42);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(364, 20);
            this.login.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(313, 126);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(376, 20);
            this.pass.TabIndex = 2;
            // 
            // Avtorisacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.avto);
            this.Name = "Avtorisacia";
            this.Text = "Avtorisacia";
            this.Load += new System.EventHandler(this.Avtorisacia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Avtorisacia_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button avto;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
    }
}

