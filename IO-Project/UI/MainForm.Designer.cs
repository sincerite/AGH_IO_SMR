namespace IO_Project.UI
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btShowGraphTestForm = new System.Windows.Forms.Button();
            this.btShowCoreTestForm = new System.Windows.Forms.Button();
            this.btShowInputTestForm = new System.Windows.Forms.Button();
            this.btShowToolsTestForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.btShowToolsTestForm);
            this.panel1.Controls.Add(this.btShowInputTestForm);
            this.panel1.Controls.Add(this.btShowCoreTestForm);
            this.panel1.Controls.Add(this.btShowGraphTestForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debug panel";
            // 
            // btShowGraphTestForm
            // 
            this.btShowGraphTestForm.Location = new System.Drawing.Point(110, 3);
            this.btShowGraphTestForm.Name = "btShowGraphTestForm";
            this.btShowGraphTestForm.Size = new System.Drawing.Size(102, 23);
            this.btShowGraphTestForm.TabIndex = 1;
            this.btShowGraphTestForm.Text = "Graph Test Form";
            this.btShowGraphTestForm.UseVisualStyleBackColor = true;
            this.btShowGraphTestForm.Click += new System.EventHandler(this.BtShowGraphTestForm_Click);
            // 
            // btShowCoreTestForm
            // 
            this.btShowCoreTestForm.Location = new System.Drawing.Point(218, 3);
            this.btShowCoreTestForm.Name = "btShowCoreTestForm";
            this.btShowCoreTestForm.Size = new System.Drawing.Size(102, 23);
            this.btShowCoreTestForm.TabIndex = 1;
            this.btShowCoreTestForm.Text = "Core Test Form";
            this.btShowCoreTestForm.UseVisualStyleBackColor = true;
            this.btShowCoreTestForm.Click += new System.EventHandler(this.BtShowCoreTestForm_Click);
            // 
            // btShowInputTestForm
            // 
            this.btShowInputTestForm.Location = new System.Drawing.Point(326, 3);
            this.btShowInputTestForm.Name = "btShowInputTestForm";
            this.btShowInputTestForm.Size = new System.Drawing.Size(102, 23);
            this.btShowInputTestForm.TabIndex = 1;
            this.btShowInputTestForm.Text = "Input Test Form";
            this.btShowInputTestForm.UseVisualStyleBackColor = true;
            this.btShowInputTestForm.Click += new System.EventHandler(this.BtShowInputTestForm_Click);
            // 
            // btShowToolsTestForm
            // 
            this.btShowToolsTestForm.Location = new System.Drawing.Point(434, 3);
            this.btShowToolsTestForm.Name = "btShowToolsTestForm";
            this.btShowToolsTestForm.Size = new System.Drawing.Size(102, 23);
            this.btShowToolsTestForm.TabIndex = 1;
            this.btShowToolsTestForm.Text = "Tools Test Form";
            this.btShowToolsTestForm.UseVisualStyleBackColor = true;
            this.btShowToolsTestForm.Click += new System.EventHandler(this.BtShowToolsTestForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Projekt IO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btShowGraphTestForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShowToolsTestForm;
        private System.Windows.Forms.Button btShowInputTestForm;
        private System.Windows.Forms.Button btShowCoreTestForm;
    }
}