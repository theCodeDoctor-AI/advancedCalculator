
namespace MainView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.buttonSuccessLabel = new System.Windows.Forms.Label();
            this.allDoneButton = new System.Windows.Forms.Button();
            this.meanBtn = new System.Windows.Forms.Button();
            this.medianBtn = new System.Windows.Forms.Button();
            this.modeBtn = new System.Windows.Forms.Button();
            this.quartileBtn = new System.Windows.Forms.Button();
            this.percentileBtn = new System.Windows.Forms.Button();
            this.iqrBtn = new System.Windows.Forms.Button();
            this.varianceBtn = new System.Windows.Forms.Button();
            this.stddevBtn = new System.Windows.Forms.Button();
            this.meanTxt = new System.Windows.Forms.TextBox();
            this.medianTxt = new System.Windows.Forms.TextBox();
            this.modeTxt = new System.Windows.Forms.TextBox();
            this.quartileTxt = new System.Windows.Forms.TextBox();
            this.percentileTxt = new System.Windows.Forms.TextBox();
            this.iqrTxt = new System.Windows.Forms.TextBox();
            this.varianceTxt = new System.Windows.Forms.TextBox();
            this.stddevTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(327, 99);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(662, 27);
            this.inputTxt.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(482, 35);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(50, 20);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "label1";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSuccessLabel
            // 
            this.buttonSuccessLabel.AutoEllipsis = true;
            this.buttonSuccessLabel.AutoSize = true;
            this.buttonSuccessLabel.Location = new System.Drawing.Point(630, 206);
            this.buttonSuccessLabel.Name = "buttonSuccessLabel";
            this.buttonSuccessLabel.Size = new System.Drawing.Size(50, 20);
            this.buttonSuccessLabel.TabIndex = 2;
            this.buttonSuccessLabel.Text = "label1";
            // 
            // allDoneButton
            // 
            this.allDoneButton.Location = new System.Drawing.Point(609, 142);
            this.allDoneButton.Name = "allDoneButton";
            this.allDoneButton.Size = new System.Drawing.Size(94, 29);
            this.allDoneButton.TabIndex = 3;
            this.allDoneButton.Text = "All Done!";
            this.allDoneButton.UseVisualStyleBackColor = true;
            // 
            // meanBtn
            // 
            this.meanBtn.Location = new System.Drawing.Point(27, 256);
            this.meanBtn.Name = "meanBtn";
            this.meanBtn.Size = new System.Drawing.Size(94, 29);
            this.meanBtn.TabIndex = 4;
            this.meanBtn.Text = "Mean";
            this.meanBtn.UseVisualStyleBackColor = true;
            // 
            // medianBtn
            // 
            this.medianBtn.Location = new System.Drawing.Point(171, 326);
            this.medianBtn.Name = "medianBtn";
            this.medianBtn.Size = new System.Drawing.Size(94, 29);
            this.medianBtn.TabIndex = 5;
            this.medianBtn.Text = "Median";
            this.medianBtn.UseVisualStyleBackColor = true;
            // 
            // modeBtn
            // 
            this.modeBtn.Location = new System.Drawing.Point(362, 389);
            this.modeBtn.Name = "modeBtn";
            this.modeBtn.Size = new System.Drawing.Size(94, 29);
            this.modeBtn.TabIndex = 6;
            this.modeBtn.Text = "Mode";
            this.modeBtn.UseVisualStyleBackColor = true;
            // 
            // quartileBtn
            // 
            this.quartileBtn.Location = new System.Drawing.Point(509, 457);
            this.quartileBtn.Name = "quartileBtn";
            this.quartileBtn.Size = new System.Drawing.Size(94, 29);
            this.quartileBtn.TabIndex = 7;
            this.quartileBtn.Text = "Quartile";
            this.quartileBtn.UseVisualStyleBackColor = true;
            // 
            // percentileBtn
            // 
            this.percentileBtn.Location = new System.Drawing.Point(693, 457);
            this.percentileBtn.Name = "percentileBtn";
            this.percentileBtn.Size = new System.Drawing.Size(94, 29);
            this.percentileBtn.TabIndex = 8;
            this.percentileBtn.Text = "Percentile";
            this.percentileBtn.UseVisualStyleBackColor = true;
            // 
            // iqrBtn
            // 
            this.iqrBtn.Location = new System.Drawing.Point(855, 389);
            this.iqrBtn.Name = "iqrBtn";
            this.iqrBtn.Size = new System.Drawing.Size(94, 29);
            this.iqrBtn.TabIndex = 9;
            this.iqrBtn.Text = "IQR";
            this.iqrBtn.UseVisualStyleBackColor = true;
            // 
            // varianceBtn
            // 
            this.varianceBtn.Location = new System.Drawing.Point(1004, 326);
            this.varianceBtn.Name = "varianceBtn";
            this.varianceBtn.Size = new System.Drawing.Size(94, 29);
            this.varianceBtn.TabIndex = 10;
            this.varianceBtn.Text = "Variance";
            this.varianceBtn.UseVisualStyleBackColor = true;
            // 
            // stddevBtn
            // 
            this.stddevBtn.Location = new System.Drawing.Point(1168, 256);
            this.stddevBtn.Name = "stddevBtn";
            this.stddevBtn.Size = new System.Drawing.Size(94, 29);
            this.stddevBtn.TabIndex = 11;
            this.stddevBtn.Text = "Std dev.";
            this.stddevBtn.UseVisualStyleBackColor = true;
            // 
            // meanTxt
            // 
            this.meanTxt.Location = new System.Drawing.Point(127, 256);
            this.meanTxt.Name = "meanTxt";
            this.meanTxt.Size = new System.Drawing.Size(125, 27);
            this.meanTxt.TabIndex = 12;
            // 
            // medianTxt
            // 
            this.medianTxt.Location = new System.Drawing.Point(271, 328);
            this.medianTxt.Name = "medianTxt";
            this.medianTxt.Size = new System.Drawing.Size(125, 27);
            this.medianTxt.TabIndex = 13;
            // 
            // modeTxt
            // 
            this.modeTxt.Location = new System.Drawing.Point(462, 389);
            this.modeTxt.Name = "modeTxt";
            this.modeTxt.Size = new System.Drawing.Size(125, 27);
            this.modeTxt.TabIndex = 14;
            // 
            // quartileTxt
            // 
            this.quartileTxt.Location = new System.Drawing.Point(378, 457);
            this.quartileTxt.Name = "quartileTxt";
            this.quartileTxt.Size = new System.Drawing.Size(125, 27);
            this.quartileTxt.TabIndex = 15;
            // 
            // percentileTxt
            // 
            this.percentileTxt.Location = new System.Drawing.Point(793, 459);
            this.percentileTxt.Name = "percentileTxt";
            this.percentileTxt.Size = new System.Drawing.Size(125, 27);
            this.percentileTxt.TabIndex = 16;
            // 
            // iqrTxt
            // 
            this.iqrTxt.Location = new System.Drawing.Point(724, 389);
            this.iqrTxt.Name = "iqrTxt";
            this.iqrTxt.Size = new System.Drawing.Size(125, 27);
            this.iqrTxt.TabIndex = 17;
            // 
            // varianceTxt
            // 
            this.varianceTxt.Location = new System.Drawing.Point(873, 328);
            this.varianceTxt.Name = "varianceTxt";
            this.varianceTxt.Size = new System.Drawing.Size(125, 27);
            this.varianceTxt.TabIndex = 18;
            // 
            // stddevTxt
            // 
            this.stddevTxt.Location = new System.Drawing.Point(1037, 258);
            this.stddevTxt.Name = "stddevTxt";
            this.stddevTxt.Size = new System.Drawing.Size(125, 27);
            this.stddevTxt.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 542);
            this.Controls.Add(this.stddevTxt);
            this.Controls.Add(this.varianceTxt);
            this.Controls.Add(this.iqrTxt);
            this.Controls.Add(this.percentileTxt);
            this.Controls.Add(this.quartileTxt);
            this.Controls.Add(this.modeTxt);
            this.Controls.Add(this.medianTxt);
            this.Controls.Add(this.meanTxt);
            this.Controls.Add(this.stddevBtn);
            this.Controls.Add(this.varianceBtn);
            this.Controls.Add(this.iqrBtn);
            this.Controls.Add(this.percentileBtn);
            this.Controls.Add(this.quartileBtn);
            this.Controls.Add(this.modeBtn);
            this.Controls.Add(this.medianBtn);
            this.Controls.Add(this.meanBtn);
            this.Controls.Add(this.allDoneButton);
            this.Controls.Add(this.buttonSuccessLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.inputTxt);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label buttonSuccessLabel;
        private System.Windows.Forms.Button allDoneButton;
        private System.Windows.Forms.Button meanBtn;
        private System.Windows.Forms.Button medianBtn;
        private System.Windows.Forms.Button modeBtn;
        private System.Windows.Forms.Button quartileBtn;
        private System.Windows.Forms.Button percentileBtn;
        private System.Windows.Forms.Button iqrBtn;
        private System.Windows.Forms.Button varianceBtn;
        private System.Windows.Forms.Button stddevBtn;
        private System.Windows.Forms.TextBox meanTxt;
        private System.Windows.Forms.TextBox medianTxt;
        private System.Windows.Forms.TextBox modeTxt;
        private System.Windows.Forms.TextBox quartileTxt;
        private System.Windows.Forms.TextBox percentileTxt;
        private System.Windows.Forms.TextBox iqrTxt;
        private System.Windows.Forms.TextBox varianceTxt;
        private System.Windows.Forms.TextBox stddevTxt;
    }
}

