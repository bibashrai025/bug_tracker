namespace bugTracker.view
{
    partial class FormAddBug
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtLineTo = new System.Windows.Forms.TextBox();
            this.lblLineto = new System.Windows.Forms.Label();
            this.txtLineFrom = new System.Windows.Forms.TextBox();
            this.lblLineFrom = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.lbllblPackage = new System.Windows.Forms.Label();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.lblBugName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.btnImage);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cboProject);
            this.panel1.Controls.Add(this.lblProject);
            this.panel1.Controls.Add(this.txtLineTo);
            this.panel1.Controls.Add(this.lblLineto);
            this.panel1.Controls.Add(this.txtLineFrom);
            this.panel1.Controls.Add(this.lblLineFrom);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.txtImagePath);
            this.panel1.Controls.Add(this.txtMethod);
            this.panel1.Controls.Add(this.lblMethod);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.txtPackage);
            this.panel1.Controls.Add(this.lbllblPackage);
            this.panel1.Controls.Add(this.txtBugName);
            this.panel1.Controls.Add(this.lblBugName);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 585);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(21, 371);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(588, 144);
            this.txtCode.TabIndex = 10;
            this.txtCode.Text = "";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(335, 314);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(64, 22);
            this.btnImage.TabIndex = 9;
            this.btnImage.Text = "Upload Snipset";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(522, 531);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(335, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(91, 102);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(226, 23);
            this.cboProject.TabIndex = 4;
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(3, 102);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(47, 15);
            this.lblProject.TabIndex = 3;
            this.lblProject.Text = "Project ";
            // 
            // txtLineTo
            // 
            this.txtLineTo.Location = new System.Drawing.Point(237, 275);
            this.txtLineTo.Name = "txtLineTo";
            this.txtLineTo.Size = new System.Drawing.Size(80, 22);
            this.txtLineTo.TabIndex = 2;
            // 
            // lblLineto
            // 
            this.lblLineto.AutoSize = true;
            this.lblLineto.Location = new System.Drawing.Point(178, 278);
            this.lblLineto.Name = "lblLineto";
            this.lblLineto.Size = new System.Drawing.Size(53, 15);
            this.lblLineto.TabIndex = 1;
            this.lblLineto.Text = "Line end";
            // 
            // txtLineFrom
            // 
            this.txtLineFrom.Location = new System.Drawing.Point(91, 275);
            this.txtLineFrom.Name = "txtLineFrom";
            this.txtLineFrom.Size = new System.Drawing.Size(81, 22);
            this.txtLineFrom.TabIndex = 2;
            // 
            // lblLineFrom
            // 
            this.lblLineFrom.AutoSize = true;
            this.lblLineFrom.Location = new System.Drawing.Point(3, 275);
            this.lblLineFrom.Name = "lblLineFrom";
            this.lblLineFrom.Size = new System.Drawing.Size(57, 15);
            this.lblLineFrom.TabIndex = 1;
            this.lblLineFrom.Text = "Line start";
            this.lblLineFrom.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 344);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(67, 15);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code block";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(406, 314);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(203, 22);
            this.txtImagePath.TabIndex = 2;
            this.txtImagePath.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(91, 230);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(226, 22);
            this.txtMethod.TabIndex = 2;
            this.txtMethod.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(3, 226);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(50, 15);
            this.lblMethod.TabIndex = 1;
            this.lblMethod.Text = "Method";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(91, 186);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(226, 22);
            this.txtClass.TabIndex = 2;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(3, 182);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(36, 15);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Class";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(91, 144);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(226, 22);
            this.txtPackage.TabIndex = 2;
            // 
            // lbllblPackage
            // 
            this.lbllblPackage.AutoSize = true;
            this.lbllblPackage.Location = new System.Drawing.Point(3, 141);
            this.lbllblPackage.Name = "lbllblPackage";
            this.lbllblPackage.Size = new System.Drawing.Size(51, 15);
            this.lbllblPackage.TabIndex = 1;
            this.lbllblPackage.Text = "Package";
            this.lbllblPackage.Click += new System.EventHandler(this.lbllblPackage_Click);
            // 
            // txtBugName
            // 
            this.txtBugName.Location = new System.Drawing.Point(91, 67);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(226, 22);
            this.txtBugName.TabIndex = 2;
            // 
            // lblBugName
            // 
            this.lblBugName.AutoSize = true;
            this.lblBugName.Location = new System.Drawing.Point(3, 63);
            this.lblBugName.Name = "lblBugName";
            this.lblBugName.Size = new System.Drawing.Size(56, 15);
            this.lblBugName.TabIndex = 1;
            this.lblBugName.Text = "Bug Title";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 15);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "label2";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 7);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "openFileDialog1";
            // 
            // FormAddBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(646, 585);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAddBug";
            this.Text = "FormAddBug";
            this.Load += new System.EventHandler(this.FormAddBug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtLineTo;
        private System.Windows.Forms.Label lblLineto;
        private System.Windows.Forms.TextBox txtLineFrom;
        private System.Windows.Forms.Label lblLineFrom;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Label lbllblPackage;
        private System.Windows.Forms.TextBox txtBugName;
        private System.Windows.Forms.Label lblBugName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.RichTextBox txtCode;
    }
}