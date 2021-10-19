
namespace GorselFinalProject
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
            this.form2routebtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form2routebtn
            // 
            this.form2routebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.form2routebtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.form2routebtn.FlatAppearance.BorderSize = 4;
            this.form2routebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.form2routebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.form2routebtn.Font = new System.Drawing.Font("Arial Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2routebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.form2routebtn.Location = new System.Drawing.Point(918, 133);
            this.form2routebtn.Name = "form2routebtn";
            this.form2routebtn.Size = new System.Drawing.Size(298, 65);
            this.form2routebtn.TabIndex = 0;
            this.form2routebtn.Text = "Kayıt Ekle";
            this.form2routebtn.UseVisualStyleBackColor = false;
            this.form2routebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(41, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(807, 457);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "GYM KAYIT SİSTEMİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1256, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.form2routebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form2routebtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}

