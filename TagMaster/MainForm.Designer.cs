namespace TagMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imgSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnTagImage = new System.Windows.Forms.Button();
            this.grdTags = new System.Windows.Forms.DataGridView();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.nbrOfTagsRequested = new System.Windows.Forms.NumericUpDown();
            this.lblCaptionNbrOfRequestedTags = new System.Windows.Forms.Label();
            this.btnDBTest = new System.Windows.Forms.Button();
            this.btnTagText = new System.Windows.Forms.Button();
            this.txtTextInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrOfTagsRequested)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSelectedImage
            // 
            this.imgSelectedImage.Image = ((System.Drawing.Image)(resources.GetObject("imgSelectedImage.Image")));
            this.imgSelectedImage.Location = new System.Drawing.Point(26, 59);
            this.imgSelectedImage.Name = "imgSelectedImage";
            this.imgSelectedImage.Size = new System.Drawing.Size(306, 324);
            this.imgSelectedImage.TabIndex = 0;
            this.imgSelectedImage.TabStop = false;
            // 
            // btnTagImage
            // 
            this.btnTagImage.Location = new System.Drawing.Point(26, 389);
            this.btnTagImage.Name = "btnTagImage";
            this.btnTagImage.Size = new System.Drawing.Size(306, 23);
            this.btnTagImage.TabIndex = 1;
            this.btnTagImage.Text = "Tag Image";
            this.btnTagImage.UseVisualStyleBackColor = true;
            this.btnTagImage.Click += new System.EventHandler(this.btnTagImage_Click);
            // 
            // grdTags
            // 
            this.grdTags.AllowUserToDeleteRows = false;
            this.grdTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTags.Location = new System.Drawing.Point(360, 30);
            this.grdTags.Name = "grdTags";
            this.grdTags.Size = new System.Drawing.Size(650, 353);
            this.grdTags.TabIndex = 2;
            this.grdTags.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTags_CellValueChanged);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(26, 30);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(306, 23);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // nbrOfTagsRequested
            // 
            this.nbrOfTagsRequested.Location = new System.Drawing.Point(26, 418);
            this.nbrOfTagsRequested.Name = "nbrOfTagsRequested";
            this.nbrOfTagsRequested.Size = new System.Drawing.Size(58, 20);
            this.nbrOfTagsRequested.TabIndex = 4;
            this.nbrOfTagsRequested.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblCaptionNbrOfRequestedTags
            // 
            this.lblCaptionNbrOfRequestedTags.AutoSize = true;
            this.lblCaptionNbrOfRequestedTags.Location = new System.Drawing.Point(90, 420);
            this.lblCaptionNbrOfRequestedTags.Name = "lblCaptionNbrOfRequestedTags";
            this.lblCaptionNbrOfRequestedTags.Size = new System.Drawing.Size(77, 13);
            this.lblCaptionNbrOfRequestedTags.TabIndex = 5;
            this.lblCaptionNbrOfRequestedTags.Text = "tags requested";
            // 
            // btnDBTest
            // 
            this.btnDBTest.Location = new System.Drawing.Point(633, 389);
            this.btnDBTest.Name = "btnDBTest";
            this.btnDBTest.Size = new System.Drawing.Size(82, 23);
            this.btnDBTest.TabIndex = 6;
            this.btnDBTest.Text = "testDatabase";
            this.btnDBTest.UseVisualStyleBackColor = true;
            this.btnDBTest.Click += new System.EventHandler(this.btnDBTest_Click);
            // 
            // btnTagText
            // 
            this.btnTagText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTagText.Location = new System.Drawing.Point(1033, 389);
            this.btnTagText.Name = "btnTagText";
            this.btnTagText.Size = new System.Drawing.Size(306, 23);
            this.btnTagText.TabIndex = 7;
            this.btnTagText.Text = "Tag Text";
            this.btnTagText.UseVisualStyleBackColor = true;
            this.btnTagText.Click += new System.EventHandler(this.btnTagText_Click);
            // 
            // txtTextInput
            // 
            this.txtTextInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextInput.Location = new System.Drawing.Point(1033, 30);
            this.txtTextInput.Multiline = true;
            this.txtTextInput.Name = "txtTextInput";
            this.txtTextInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextInput.Size = new System.Drawing.Size(306, 353);
            this.txtTextInput.TabIndex = 8;
            this.txtTextInput.Text = resources.GetString("txtTextInput.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 449);
            this.Controls.Add(this.txtTextInput);
            this.Controls.Add(this.btnTagText);
            this.Controls.Add(this.btnDBTest);
            this.Controls.Add(this.lblCaptionNbrOfRequestedTags);
            this.Controls.Add(this.nbrOfTagsRequested);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.grdTags);
            this.Controls.Add(this.btnTagImage);
            this.Controls.Add(this.imgSelectedImage);
            this.Name = "MainForm";
            this.Text = "TagMaster - Proof of concept";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrOfTagsRequested)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSelectedImage;
        private System.Windows.Forms.Button btnTagImage;
        private System.Windows.Forms.DataGridView grdTags;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.NumericUpDown nbrOfTagsRequested;
        private System.Windows.Forms.Label lblCaptionNbrOfRequestedTags;
        private System.Windows.Forms.Button btnDBTest;
        private System.Windows.Forms.Button btnTagText;
        private System.Windows.Forms.TextBox txtTextInput;
    }
}

