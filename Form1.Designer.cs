namespace Proxy
{
    partial class Form1
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
            this.Proxy = new System.Windows.Forms.Button();
            this.NoProxy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Proxy
            // 
            this.Proxy.Location = new System.Drawing.Point(97, 136);
            this.Proxy.Name = "Proxy";
            this.Proxy.Size = new System.Drawing.Size(75, 23);
            this.Proxy.TabIndex = 0;
            this.Proxy.Text = "Proxy";
            this.Proxy.UseVisualStyleBackColor = true;
            this.Proxy.Click += new System.EventHandler(this.Proxy_Click);
            // 
            // NoProxy
            // 
            this.NoProxy.Location = new System.Drawing.Point(97, 197);
            this.NoProxy.Name = "NoProxy";
            this.NoProxy.Size = new System.Drawing.Size(75, 23);
            this.NoProxy.TabIndex = 1;
            this.NoProxy.Text = "NoProxy";
            this.NoProxy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.NoProxy);
            this.Controls.Add(this.Proxy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Proxy;
        private System.Windows.Forms.Button NoProxy;
    }
}

