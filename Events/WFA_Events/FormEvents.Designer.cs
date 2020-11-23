
namespace WFA_Events
{
    partial class FormEvents
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.textBoxTitleHardware = new System.Windows.Forms.TextBox();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Location = new System.Drawing.Point(24, 199);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(789, 250);
            this.richTextBoxMain.TabIndex = 1;
            this.richTextBoxMain.Text = "";
            // 
            // textBoxTitleHardware
            // 
            this.textBoxTitleHardware.Location = new System.Drawing.Point(24, 173);
            this.textBoxTitleHardware.Name = "textBoxTitleHardware";
            this.textBoxTitleHardware.Size = new System.Drawing.Size(789, 20);
            this.textBoxTitleHardware.TabIndex = 2;
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(24, 37);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(789, 20);
            this.textBoxTimer.TabIndex = 3;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.textBoxTitleHardware);
            this.Controls.Add(this.richTextBoxMain);
            this.Name = "FormEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Events";
            this.Load += new System.EventHandler(this.FormEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.TextBox textBoxTitleHardware;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button button1;
    }
}

