namespace dle20
{
    partial class MainForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApplyColor = new System.Windows.Forms.Button();
            this.txtSecondColor = new System.Windows.Forms.TextBox();
            this.txtFirstColor = new System.Windows.Forms.TextBox();
            this.lblHeaderInfo = new System.Windows.Forms.Label();
            this.lblColorName = new System.Windows.Forms.Label();
            this.lblTimesApplied = new System.Windows.Forms.Label();
            this.lblTimesAppliedCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(441, 318);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 46);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApplyColor
            // 
            this.btnApplyColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyColor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyColor.Location = new System.Drawing.Point(216, 318);
            this.btnApplyColor.Name = "btnApplyColor";
            this.btnApplyColor.Size = new System.Drawing.Size(100, 46);
            this.btnApplyColor.TabIndex = 3;
            this.btnApplyColor.Text = "Apply";
            this.btnApplyColor.UseVisualStyleBackColor = false;
            this.btnApplyColor.Click += new System.EventHandler(this.btnApplyColor_Click);
            // 
            // txtSecondColor
            // 
            this.txtSecondColor.BackColor = System.Drawing.SystemColors.Control;
            this.txtSecondColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondColor.Location = new System.Drawing.Point(306, 250);
            this.txtSecondColor.Name = "txtSecondColor";
            this.txtSecondColor.Size = new System.Drawing.Size(167, 22);
            this.txtSecondColor.TabIndex = 2;
            // 
            // txtFirstColor
            // 
            this.txtFirstColor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstColor.Location = new System.Drawing.Point(306, 204);
            this.txtFirstColor.Name = "txtFirstColor";
            this.txtFirstColor.Size = new System.Drawing.Size(167, 22);
            this.txtFirstColor.TabIndex = 0;
            // 
            // lblHeaderInfo
            // 
            this.lblHeaderInfo.AutoSize = true;
            this.lblHeaderInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderInfo.Location = new System.Drawing.Point(211, 92);
            this.lblHeaderInfo.Name = "lblHeaderInfo";
            this.lblHeaderInfo.Size = new System.Drawing.Size(281, 30);
            this.lblHeaderInfo.TabIndex = 4;
            this.lblHeaderInfo.Text = "The Current Color Scheme is:";
            // 
            // lblColorName
            // 
            this.lblColorName.AutoSize = true;
            this.lblColorName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorName.ForeColor = System.Drawing.Color.DimGray;
            this.lblColorName.Location = new System.Drawing.Point(486, 92);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(55, 30);
            this.lblColorName.TabIndex = 5;
            this.lblColorName.Text = "Grey";
            // 
            // lblTimesApplied
            // 
            this.lblTimesApplied.AutoSize = true;
            this.lblTimesApplied.Location = new System.Drawing.Point(313, 161);
            this.lblTimesApplied.Name = "lblTimesApplied";
            this.lblTimesApplied.Size = new System.Drawing.Size(128, 13);
            this.lblTimesApplied.TabIndex = 6;
            this.lblTimesApplied.Text = "Number of Times Applied:";
            // 
            // lblTimesAppliedCount
            // 
            this.lblTimesAppliedCount.AutoSize = true;
            this.lblTimesAppliedCount.Location = new System.Drawing.Point(447, 161);
            this.lblTimesAppliedCount.Name = "lblTimesAppliedCount";
            this.lblTimesAppliedCount.Size = new System.Drawing.Size(13, 13);
            this.lblTimesAppliedCount.TabIndex = 7;
            this.lblTimesAppliedCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimesAppliedCount);
            this.Controls.Add(this.lblTimesApplied);
            this.Controls.Add(this.lblColorName);
            this.Controls.Add(this.lblHeaderInfo);
            this.Controls.Add(this.txtFirstColor);
            this.Controls.Add(this.txtSecondColor);
            this.Controls.Add(this.btnApplyColor);
            this.Controls.Add(this.btnReset);
            this.Name = "MainForm";
            this.Text = "42";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnApplyColor;
        private System.Windows.Forms.TextBox txtSecondColor;
        private System.Windows.Forms.TextBox txtFirstColor;
        private System.Windows.Forms.Label lblHeaderInfo;
        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.Label lblTimesApplied;
        private System.Windows.Forms.Label lblTimesAppliedCount;
    }
}

