namespace Memory_Game_X
{
    partial class StartGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ImmpossibleClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Day Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(235, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory Game X";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Lime;
            this.PlayButton.Font = new System.Drawing.Font("Day Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayButton.Location = new System.Drawing.Point(279, 162);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(219, 43);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Normal Mode";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ImmpossibleClick
            // 
            this.ImmpossibleClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ImmpossibleClick.Font = new System.Drawing.Font("Day Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImmpossibleClick.Location = new System.Drawing.Point(295, 229);
            this.ImmpossibleClick.Name = "ImmpossibleClick";
            this.ImmpossibleClick.Size = new System.Drawing.Size(197, 47);
            this.ImmpossibleClick.TabIndex = 2;
            this.ImmpossibleClick.Text = "Hell Mode";
            this.ImmpossibleClick.UseVisualStyleBackColor = false;
            this.ImmpossibleClick.Click += new System.EventHandler(this.ImmpossibleClick_Click);
            // 
            // StartGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(778, 304);
            this.Controls.Add(this.ImmpossibleClick);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.label1);
            this.Name = "StartGameForm";
            this.Text = "Memory Game X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ImmpossibleClick;
    }
}

