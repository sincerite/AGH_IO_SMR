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
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation5 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.btAnalyze.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAnalyze.BackColor = System.Drawing.SystemColors.Control;
            this.btAnalyze.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btAnalyze.Enabled = false;
            this.btAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.btAnalyze.Location = new System.Drawing.Point(684, 43);
            this.btAnalyze.Name = "btAnalyze";
            this.btAnalyze.Size = new System.Drawing.Size(136, 41);
            this.btAnalyze.TabIndex = 0;
            this.btAnalyze.Text = "Analyze";
            this.btAnalyze.UseVisualStyleBackColor = false;
            this.btAnalyze.Click += new System.EventHandler(this.AnalyzeButton_Click);
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btShowToolsTestForm);
            this.panel1.Controls.Add(this.btShowInputTestForm);
            this.panel1.Controls.Add(this.btShowCoreTestForm);
            this.panel1.Controls.Add(this.btShowGraphTestForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 30);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.btShowToolsTestForm.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowToolsTestForm.Location = new System.Drawing.Point(670, 2);
            this.btShowToolsTestForm.Name = "btShowToolsTestForm";
            this.btShowToolsTestForm.Size = new System.Drawing.Size(102, 23);
            this.btShowToolsTestForm.TabIndex = 1;
            this.btShowToolsTestForm.Text = "Tools Test Form";
            this.btShowToolsTestForm.UseVisualStyleBackColor = true;
            this.btShowToolsTestForm.Click += new System.EventHandler(this.BtShowToolsTestForm_Click);
            this.btShowInputTestForm.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowInputTestForm.Location = new System.Drawing.Point(458, 1);
            this.btShowInputTestForm.Name = "btShowInputTestForm";
            this.btShowInputTestForm.Size = new System.Drawing.Size(102, 23);
            this.btShowInputTestForm.TabIndex = 1;
            this.btShowInputTestForm.Text = "Input Test Form";
            this.btShowInputTestForm.UseVisualStyleBackColor = true;
            this.btShowInputTestForm.Click += new System.EventHandler(this.BtShowInputTestForm_Click);
            this.btShowCoreTestForm.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowCoreTestForm.Location = new System.Drawing.Point(274, 1);
            this.btShowCoreTestForm.Name = "btShowCoreTestForm";
            this.btShowCoreTestForm.Size = new System.Drawing.Size(102, 23);
            this.btShowCoreTestForm.TabIndex = 1;
            this.btShowCoreTestForm.Text = "Core Test Form";
            this.btShowCoreTestForm.UseVisualStyleBackColor = true;
            this.btShowCoreTestForm.Click += new System.EventHandler(this.BtShowCoreTestForm_Click);
            this.btShowGraphTestForm.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowGraphTestForm.Location = new System.Drawing.Point(110, 1);
            this.btShowGraphTestForm.Name = "btShowGraphTestForm";
            this.btShowGraphTestForm.Size = new System.Drawing.Size(102, 23);
            this.btShowGraphTestForm.TabIndex = 1;
            this.btShowGraphTestForm.Text = "Graph Test Form";
            this.btShowGraphTestForm.UseVisualStyleBackColor = true;
            this.btShowGraphTestForm.Click += new System.EventHandler(this.BtShowGraphTestForm_Click);
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debug panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.gViewer1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.Enabled = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(25, 135);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.Margin = new System.Windows.Forms.Padding(2);
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
            this.gViewer1.Size = new System.Drawing.Size(805, 394);
            this.gViewer1.TabIndex = 2;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = planeTransformation5;
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            this.gViewer1.Load += new System.EventHandler(this.gViewer1_Load);
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chbSixthStory);
            this.panel2.Controls.Add(this.chbThirdStory);
            this.panel2.Controls.Add(this.chbSecondStory);
            this.panel2.Controls.Add(this.chbFirstStory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(25, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 32);
            this.panel2.TabIndex = 3;
            this.chbSixthStory.AutoSize = true;
            this.chbSixthStory.Location = new System.Drawing.Point(576, 6);
            this.chbSixthStory.Margin = new System.Windows.Forms.Padding(2);
            this.chbSixthStory.Name = "chbSixthStory";
            this.chbSixthStory.Size = new System.Drawing.Size(100, 17);
            this.chbSixthStory.TabIndex = 7;
            this.chbSixthStory.Text = "Methods to files";
            this.chbSixthStory.UseVisualStyleBackColor = true;
            this.chbSixthStory.CheckedChanged += new System.EventHandler(this.chbSixthStory_CheckedChanged);
            this.chbThirdStory.AutoSize = true;
            this.chbThirdStory.Location = new System.Drawing.Point(404, 6);
            this.chbThirdStory.Margin = new System.Windows.Forms.Padding(2);
            this.chbThirdStory.Name = "chbThirdStory";
            this.chbThirdStory.Size = new System.Drawing.Size(142, 17);
            this.chbThirdStory.TabIndex = 6;
            this.chbThirdStory.Text = "Methods to namespaces";
            this.chbThirdStory.UseVisualStyleBackColor = true;
            this.chbThirdStory.CheckedChanged += new System.EventHandler(this.chbThirdStory_CheckedChanged);
            this.chbSecondStory.AutoSize = true;
            this.chbSecondStory.Location = new System.Drawing.Point(262, 6);
            this.chbSecondStory.Margin = new System.Windows.Forms.Padding(2);
            this.chbSecondStory.Name = "chbSecondStory";
            this.chbSecondStory.Size = new System.Drawing.Size(122, 17);
            this.chbSecondStory.TabIndex = 5;
            this.chbSecondStory.Text = "Methods to methods";
            this.chbSecondStory.UseVisualStyleBackColor = true;
            this.chbSecondStory.CheckedChanged += new System.EventHandler(this.chbSecondStory_CheckedChanged);
            this.chbFirstStory.AutoSize = true;
            this.chbFirstStory.Location = new System.Drawing.Point(165, 6);
            this.chbFirstStory.Margin = new System.Windows.Forms.Padding(2);
            this.chbFirstStory.Name = "chbFirstStory";
            this.chbFirstStory.Size = new System.Drawing.Size(80, 17);
            this.chbFirstStory.TabIndex = 4;
            this.chbFirstStory.Text = "Files to files";
            this.chbFirstStory.UseVisualStyleBackColor = true;
            this.chbFirstStory.CheckedChanged += new System.EventHandler(this.chbFirstStory_CheckedChanged);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label2.Location = new System.Drawing.Point(91, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Layers:";
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Graph viewer";
            this.inButton.BackColor = System.Drawing.SystemColors.Control;
            this.inButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.inButton.Location = new System.Drawing.Point(528, 43);
            this.inButton.Margin = new System.Windows.Forms.Padding(2);
            this.inButton.Name = "inButton";
            this.inButton.Size = new System.Drawing.Size(131, 41);
            this.inButton.TabIndex = 4;
            this.inButton.Text = "Load files";
            this.inButton.UseVisualStyleBackColor = false;
            this.inButton.Click += new System.EventHandler(this.inButton_Click);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label4.Location = new System.Drawing.Point(249, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 63);
            this.label4.TabIndex = 5;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
    }
}