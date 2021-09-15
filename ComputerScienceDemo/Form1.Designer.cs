
namespace ComputerScienceDemo
{
    partial class titleLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.Reactor1Label = new System.Windows.Forms.Label();
            this.Reactor2Label = new System.Windows.Forms.Label();
            this.Reactor2Statelabel = new System.Windows.Forms.Label();
            this.Reactor1StateLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuclear Reactor Control ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reactor1Label
            // 
            this.Reactor1Label.AutoSize = true;
            this.Reactor1Label.Font = new System.Drawing.Font("Javanese Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor1Label.Location = new System.Drawing.Point(85, 166);
            this.Reactor1Label.Name = "Reactor1Label";
            this.Reactor1Label.Size = new System.Drawing.Size(143, 66);
            this.Reactor1Label.TabIndex = 1;
            this.Reactor1Label.Text = "Reactor 1";
            this.Reactor1Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reactor2Label
            // 
            this.Reactor2Label.AutoSize = true;
            this.Reactor2Label.Font = new System.Drawing.Font("Javanese Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2Label.Location = new System.Drawing.Point(473, 166);
            this.Reactor2Label.Name = "Reactor2Label";
            this.Reactor2Label.Size = new System.Drawing.Size(148, 66);
            this.Reactor2Label.TabIndex = 2;
            this.Reactor2Label.Text = "Reactor 2";
            this.Reactor2Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Reactor2Statelabel
            // 
            this.Reactor2Statelabel.BackColor = System.Drawing.Color.Navy;
            this.Reactor2Statelabel.Location = new System.Drawing.Point(472, 232);
            this.Reactor2Statelabel.Name = "Reactor2Statelabel";
            this.Reactor2Statelabel.Size = new System.Drawing.Size(149, 146);
            this.Reactor2Statelabel.TabIndex = 3;
            this.Reactor2Statelabel.Click += new System.EventHandler(this.Reactor1Statelabel_Click);
            // 
            // Reactor1StateLabel
            // 
            this.Reactor1StateLabel.BackColor = System.Drawing.Color.Navy;
            this.Reactor1StateLabel.Location = new System.Drawing.Point(79, 232);
            this.Reactor1StateLabel.Name = "Reactor1StateLabel";
            this.Reactor1StateLabel.Size = new System.Drawing.Size(149, 146);
            this.Reactor1StateLabel.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(260, 401);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(186, 42);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(719, 487);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Reactor1StateLabel);
            this.Controls.Add(this.Reactor2Statelabel);
            this.Controls.Add(this.Reactor2Label);
            this.Controls.Add(this.Reactor1Label);
            this.Controls.Add(this.label1);
            this.Name = "titleLabel";
            this.Text = "DemoGame1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Reactor1Label;
        private System.Windows.Forms.Label Reactor2Label;
        private System.Windows.Forms.Label Reactor2Statelabel;
        private System.Windows.Forms.Label Reactor1StateLabel;
        private System.Windows.Forms.Button startButton;
    }
}

