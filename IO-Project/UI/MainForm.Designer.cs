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
        private void InitializeComponent() {
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation1 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
            this.btAnalyze = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btShowToolsTestForm = new System.Windows.Forms.Button();
            this.btShowInputTestForm = new System.Windows.Forms.Button();
            this.btShowCoreTestForm = new System.Windows.Forms.Button();
            this.btShowGraphTestForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbSixthStory = new System.Windows.Forms.CheckBox();
            this.chbThirdStory = new System.Windows.Forms.CheckBox();
            this.chbSecondStory = new System.Windows.Forms.CheckBox();
            this.chbFirstStory = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAnalyze
            // 
            this.btAnalyze.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.btAnalyze.Location = new System.Drawing.Point(755, 13);
            this.btAnalyze.Name = "btAnalyze";
            this.btAnalyze.Size = new System.Drawing.Size(159, 47);
            this.btAnalyze.TabIndex = 0;
            this.btAnalyze.Text = "Analyze";
            this.btAnalyze.UseVisualStyleBackColor = true;
            this.btAnalyze.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.btShowToolsTestForm);
            this.panel1.Controls.Add(this.btShowInputTestForm);
            this.panel1.Controls.Add(this.btShowCoreTestForm);
            this.panel1.Controls.Add(this.btShowGraphTestForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 35);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btShowToolsTestForm
            // 
            this.btShowToolsTestForm.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowToolsTestForm.Location = new System.Drawing.Point(782, 5);
            this.btShowToolsTestForm.Name = "btShowToolsTestForm";
            this.btShowToolsTestForm.Size = new System.Drawing.Size(119, 27);
            this.btShowToolsTestForm.TabIndex = 1;
            this.btShowToolsTestForm.Text = "Tools Test Form";
            this.btShowToolsTestForm.UseVisualStyleBackColor = true;
            this.btShowToolsTestForm.Click += new System.EventHandler(this.BtShowToolsTestForm_Click);
            // 
            // btShowInputTestForm
            // 
            this.btShowInputTestForm.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowInputTestForm.Location = new System.Drawing.Point(534, 3);
            this.btShowInputTestForm.Name = "btShowInputTestForm";
            this.btShowInputTestForm.Size = new System.Drawing.Size(119, 27);
            this.btShowInputTestForm.TabIndex = 1;
            this.btShowInputTestForm.Text = "Input Test Form";
            this.btShowInputTestForm.UseVisualStyleBackColor = true;
            this.btShowInputTestForm.Click += new System.EventHandler(this.BtShowInputTestForm_Click);
            // 
            // btShowCoreTestForm
            // 
            this.btShowCoreTestForm.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowCoreTestForm.Location = new System.Drawing.Point(320, 3);
            this.btShowCoreTestForm.Name = "btShowCoreTestForm";
            this.btShowCoreTestForm.Size = new System.Drawing.Size(119, 27);
            this.btShowCoreTestForm.TabIndex = 1;
            this.btShowCoreTestForm.Text = "Core Test Form";
            this.btShowCoreTestForm.UseVisualStyleBackColor = true;
            this.btShowCoreTestForm.Click += new System.EventHandler(this.BtShowCoreTestForm_Click);
            // 
            // btShowGraphTestForm
            // 
            this.btShowGraphTestForm.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowGraphTestForm.Location = new System.Drawing.Point(128, 3);
            this.btShowGraphTestForm.Name = "btShowGraphTestForm";
            this.btShowGraphTestForm.Size = new System.Drawing.Size(119, 27);
            this.btShowGraphTestForm.TabIndex = 1;
            this.btShowGraphTestForm.Text = "Graph Test Form";
            this.btShowGraphTestForm.UseVisualStyleBackColor = true;
            this.btShowGraphTestForm.Click += new System.EventHandler(this.BtShowGraphTestForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debug panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gViewer1
            // 
            this.gViewer1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(10, 115);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(892, 339);
            this.gViewer1.TabIndex = 2;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = planeTransformation1;
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            this.gViewer1.Load += new System.EventHandler(this.gViewer1_Load);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.chbSixthStory);
            this.panel2.Controls.Add(this.chbThirdStory);
            this.panel2.Controls.Add(this.chbSecondStory);
            this.panel2.Controls.Add(this.chbFirstStory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 37);
            this.panel2.TabIndex = 3;
            // 
            // chbSixthStory
            // 
            this.chbSixthStory.AutoSize = true;
            this.chbSixthStory.Location = new System.Drawing.Point(686, 7);
            this.chbSixthStory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbSixthStory.Name = "chbSixthStory";
            this.chbSixthStory.Size = new System.Drawing.Size(81, 19);
            this.chbSixthStory.TabIndex = 7;
            this.chbSixthStory.Text = "Sixth story";
            this.chbSixthStory.UseVisualStyleBackColor = true;
            // 
            // chbThirdStory
            // 
            this.chbThirdStory.AutoSize = true;
            this.chbThirdStory.Location = new System.Drawing.Point(509, 7);
            this.chbThirdStory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbThirdStory.Name = "chbThirdStory";
            this.chbThirdStory.Size = new System.Drawing.Size(82, 19);
            this.chbThirdStory.TabIndex = 6;
            this.chbThirdStory.Text = "Third story";
            this.chbThirdStory.UseVisualStyleBackColor = true;
            // 
            // chbSecondStory
            // 
            this.chbSecondStory.AutoSize = true;
            this.chbSecondStory.Location = new System.Drawing.Point(359, 7);
            this.chbSecondStory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbSecondStory.Name = "chbSecondStory";
            this.chbSecondStory.Size = new System.Drawing.Size(94, 19);
            this.chbSecondStory.TabIndex = 5;
            this.chbSecondStory.Text = "Second story";
            this.chbSecondStory.UseVisualStyleBackColor = true;
            // 
            // chbFirstStory
            // 
            this.chbFirstStory.AutoSize = true;
            this.chbFirstStory.Location = new System.Drawing.Point(222, 7);
            this.chbFirstStory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbFirstStory.Name = "chbFirstStory";
            this.chbFirstStory.Size = new System.Drawing.Size(77, 19);
            this.chbFirstStory.TabIndex = 4;
            this.chbFirstStory.Text = "First story";
            this.chbFirstStory.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Layers";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input files";
            // 
            // inButton
            // 
            this.inButton.Location = new System.Drawing.Point(320, 29);
            this.inButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inButton.Name = "inButton";
            this.inButton.Size = new System.Drawing.Size(129, 31);
            this.inButton.TabIndex = 4;
            this.inButton.UseVisualStyleBackColor = true;
            this.inButton.Click += new System.EventHandler(this.inButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 519);
            this.Controls.Add(this.inButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btAnalyze);
            this.Name = "MainForm";
            this.Text = "Projekt IO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btAnalyze;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btShowGraphTestForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShowToolsTestForm;
        private System.Windows.Forms.Button btShowInputTestForm;
        private System.Windows.Forms.Button btShowCoreTestForm;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbSixthStory;
        private System.Windows.Forms.CheckBox chbThirdStory;
        private System.Windows.Forms.CheckBox chbSecondStory;
        private System.Windows.Forms.CheckBox chbFirstStory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inButton;
    }
}