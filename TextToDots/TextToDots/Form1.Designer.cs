
namespace TextToDots
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPixelWidth = new System.Windows.Forms.Label();
            this.lblPixelHeight = new System.Windows.Forms.Label();
            this.picBoxOutputBitmap = new System.Windows.Forms.PictureBox();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.cmbFonts = new System.Windows.Forms.ComboBox();
            this.chkBoxBold = new System.Windows.Forms.CheckBox();
            this.chkBoxInvert = new System.Windows.Forms.CheckBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblImageWidth = new System.Windows.Forms.Label();
            this.lblImageHeight = new System.Windows.Forms.Label();
            this.txtPixelWidth = new System.Windows.Forms.NumericUpDown();
            this.txtPixelHeight = new System.Windows.Forms.NumericUpDown();
            this.txtImageWidth = new System.Windows.Forms.NumericUpDown();
            this.txtImageHeight = new System.Windows.Forms.NumericUpDown();
            this.txtFontSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOutputBitmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(72, 52);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(70, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "z";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(181, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Text to Pixel Fonts";
            // 
            // lblPixelWidth
            // 
            this.lblPixelWidth.AutoSize = true;
            this.lblPixelWidth.Location = new System.Drawing.Point(148, 56);
            this.lblPixelWidth.Name = "lblPixelWidth";
            this.lblPixelWidth.Size = new System.Drawing.Size(60, 13);
            this.lblPixelWidth.TabIndex = 4;
            this.lblPixelWidth.Text = "Pixel Width";
            // 
            // lblPixelHeight
            // 
            this.lblPixelHeight.AutoSize = true;
            this.lblPixelHeight.Location = new System.Drawing.Point(298, 56);
            this.lblPixelHeight.Name = "lblPixelHeight";
            this.lblPixelHeight.Size = new System.Drawing.Size(63, 13);
            this.lblPixelHeight.TabIndex = 6;
            this.lblPixelHeight.Text = "Pixel Height";
            // 
            // picBoxOutputBitmap
            // 
            this.picBoxOutputBitmap.Location = new System.Drawing.Point(11, 137);
            this.picBoxOutputBitmap.Name = "picBoxOutputBitmap";
            this.picBoxOutputBitmap.Size = new System.Drawing.Size(281, 276);
            this.picBoxOutputBitmap.TabIndex = 7;
            this.picBoxOutputBitmap.TabStop = false;
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOutput.Location = new System.Drawing.Point(301, 137);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(306, 276);
            this.rtxtOutput.TabIndex = 8;
            this.rtxtOutput.Text = "";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(12, 109);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(28, 13);
            this.lblFont.TabIndex = 10;
            this.lblFont.Text = "Font";
            // 
            // cmbFonts
            // 
            this.cmbFonts.FormattingEnabled = true;
            this.cmbFonts.Location = new System.Drawing.Point(72, 105);
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(121, 21);
            this.cmbFonts.TabIndex = 11;
            this.cmbFonts.SelectedIndexChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // chkBoxBold
            // 
            this.chkBoxBold.AutoSize = true;
            this.chkBoxBold.Checked = true;
            this.chkBoxBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxBold.Location = new System.Drawing.Point(199, 107);
            this.chkBoxBold.Name = "chkBoxBold";
            this.chkBoxBold.Size = new System.Drawing.Size(47, 17);
            this.chkBoxBold.TabIndex = 12;
            this.chkBoxBold.Text = "Bold";
            this.chkBoxBold.UseVisualStyleBackColor = true;
            this.chkBoxBold.CheckStateChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // chkBoxInvert
            // 
            this.chkBoxInvert.AutoSize = true;
            this.chkBoxInvert.Location = new System.Drawing.Point(486, 114);
            this.chkBoxInvert.Name = "chkBoxInvert";
            this.chkBoxInvert.Size = new System.Drawing.Size(89, 17);
            this.chkBoxInvert.TabIndex = 13;
            this.chkBoxInvert.Text = "Inversion 0/1";
            this.chkBoxInvert.UseVisualStyleBackColor = true;
            this.chkBoxInvert.CheckStateChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(12, 82);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(51, 13);
            this.lblFontSize.TabIndex = 15;
            this.lblFontSize.Text = "Font Size";
            // 
            // lblImageWidth
            // 
            this.lblImageWidth.AutoSize = true;
            this.lblImageWidth.Location = new System.Drawing.Point(148, 82);
            this.lblImageWidth.Name = "lblImageWidth";
            this.lblImageWidth.Size = new System.Drawing.Size(67, 13);
            this.lblImageWidth.TabIndex = 17;
            this.lblImageWidth.Text = "Image Width";
            // 
            // lblImageHeight
            // 
            this.lblImageHeight.AutoSize = true;
            this.lblImageHeight.Location = new System.Drawing.Point(298, 82);
            this.lblImageHeight.Name = "lblImageHeight";
            this.lblImageHeight.Size = new System.Drawing.Size(70, 13);
            this.lblImageHeight.TabIndex = 19;
            this.lblImageHeight.Text = "Image Height";
            // 
            // txtPixelWidth
            // 
            this.txtPixelWidth.Location = new System.Drawing.Point(222, 52);
            this.txtPixelWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtPixelWidth.Name = "txtPixelWidth";
            this.txtPixelWidth.Size = new System.Drawing.Size(70, 20);
            this.txtPixelWidth.TabIndex = 20;
            this.txtPixelWidth.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtPixelWidth.ValueChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtPixelHeight
            // 
            this.txtPixelHeight.Location = new System.Drawing.Point(373, 52);
            this.txtPixelHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtPixelHeight.Name = "txtPixelHeight";
            this.txtPixelHeight.Size = new System.Drawing.Size(70, 20);
            this.txtPixelHeight.TabIndex = 21;
            this.txtPixelHeight.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtPixelHeight.ValueChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtImageWidth
            // 
            this.txtImageWidth.Location = new System.Drawing.Point(222, 78);
            this.txtImageWidth.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtImageWidth.Name = "txtImageWidth";
            this.txtImageWidth.Size = new System.Drawing.Size(70, 20);
            this.txtImageWidth.TabIndex = 22;
            this.txtImageWidth.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.txtImageWidth.ValueChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtImageHeight
            // 
            this.txtImageHeight.Location = new System.Drawing.Point(373, 78);
            this.txtImageHeight.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtImageHeight.Name = "txtImageHeight";
            this.txtImageHeight.Size = new System.Drawing.Size(70, 20);
            this.txtImageHeight.TabIndex = 23;
            this.txtImageHeight.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.txtImageHeight.ValueChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(72, 78);
            this.txtFontSize.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(70, 20);
            this.txtFontSize.TabIndex = 24;
            this.txtFontSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtFontSize.ValueChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.txtImageHeight);
            this.Controls.Add(this.txtImageWidth);
            this.Controls.Add(this.txtPixelHeight);
            this.Controls.Add(this.txtPixelWidth);
            this.Controls.Add(this.lblImageHeight);
            this.Controls.Add(this.lblImageWidth);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.chkBoxInvert);
            this.Controls.Add(this.chkBoxBold);
            this.Controls.Add(this.cmbFonts);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.picBoxOutputBitmap);
            this.Controls.Add(this.lblPixelHeight);
            this.Controls.Add(this.lblPixelWidth);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOutputBitmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPixelWidth;
        private System.Windows.Forms.Label lblPixelHeight;
        private System.Windows.Forms.PictureBox picBoxOutputBitmap;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cmbFonts;
        private System.Windows.Forms.CheckBox chkBoxBold;
        private System.Windows.Forms.CheckBox chkBoxInvert;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblImageWidth;
        private System.Windows.Forms.Label lblImageHeight;
        private System.Windows.Forms.NumericUpDown txtPixelWidth;
        private System.Windows.Forms.NumericUpDown txtPixelHeight;
        private System.Windows.Forms.NumericUpDown txtImageWidth;
        private System.Windows.Forms.NumericUpDown txtImageHeight;
        private System.Windows.Forms.NumericUpDown txtFontSize;
    }
}

