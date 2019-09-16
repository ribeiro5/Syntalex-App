namespace SyntalexApp
{
    partial class Interface
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
            this.textCitation = new System.Windows.Forms.TextBox();
            this.Citation_Label = new System.Windows.Forms.Label();
            this.choose_interface = new System.Windows.Forms.ComboBox();
            this.ChooseInterface = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Text_Date = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.reject = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCitation
            // 
            this.textCitation.Location = new System.Drawing.Point(349, 181);
            this.textCitation.Name = "textCitation";
            this.textCitation.Size = new System.Drawing.Size(100, 20);
            this.textCitation.TabIndex = 2;
            this.textCitation.TextChanged += new System.EventHandler(this.textCitation_TextChanged);
            // 
            // Citation_Label
            // 
            this.Citation_Label.AutoSize = true;
            this.Citation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Citation_Label.Location = new System.Drawing.Point(351, 165);
            this.Citation_Label.Name = "Citation_Label";
            this.Citation_Label.Size = new System.Drawing.Size(50, 13);
            this.Citation_Label.TabIndex = 3;
            this.Citation_Label.Text = "Citation";
            this.Citation_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // choose_interface
            // 
            this.choose_interface.ForeColor = System.Drawing.SystemColors.WindowText;
            this.choose_interface.FormattingEnabled = true;
            this.choose_interface.Items.AddRange(new object[] {
            "Named Entities",
            "Text Classification"});
            this.choose_interface.Location = new System.Drawing.Point(37, 109);
            this.choose_interface.Name = "choose_interface";
            this.choose_interface.Size = new System.Drawing.Size(121, 21);
            this.choose_interface.TabIndex = 4;
            this.choose_interface.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ChooseInterface
            // 
            this.ChooseInterface.AutoSize = true;
            this.ChooseInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseInterface.Location = new System.Drawing.Point(39, 93);
            this.ChooseInterface.Name = "ChooseInterface";
            this.ChooseInterface.Size = new System.Drawing.Size(115, 15);
            this.ChooseInterface.TabIndex = 5;
            this.ChooseInterface.Text = "Choose Interface";
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(468, 98);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(62, 17);
            this.Results.TabIndex = 6;
            this.Results.Text = "Results";
            this.Results.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(522, 165);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(34, 13);
            this.Date.TabIndex = 8;
            this.Date.Text = "Date";
            // 
            // Text_Date
            // 
            this.Text_Date.Location = new System.Drawing.Point(520, 181);
            this.Text_Date.Name = "Text_Date";
            this.Text_Date.Size = new System.Drawing.Size(100, 20);
            this.Text_Date.TabIndex = 7;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.Location = new System.Drawing.Point(33, 207);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(152, 29);
            this.openFile.TabIndex = 9;
            this.openFile.Text = "Select Training File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // accept
            // 
            this.accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.Location = new System.Drawing.Point(321, 290);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 10;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            // 
            // reject
            // 
            this.reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject.Location = new System.Drawing.Point(455, 290);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(75, 23);
            this.reject.TabIndex = 11;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = true;
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.Location = new System.Drawing.Point(596, 290);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(75, 23);
            this.modify.TabIndex = 12;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(299, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(185, 31);
            this.title.TabIndex = 13;
            this.title.Text = "Syntalex App";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.reject);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Text_Date);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.ChooseInterface);
            this.Controls.Add(this.choose_interface);
            this.Controls.Add(this.Citation_Label);
            this.Controls.Add(this.textCitation);
            this.Name = "Interface";
            this.Text = "interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCitation;
        private System.Windows.Forms.Label Citation_Label;
        private System.Windows.Forms.ComboBox choose_interface;
        private System.Windows.Forms.Label ChooseInterface;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox Text_Date;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Label title;
    }
}

