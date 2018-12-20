namespace bugTracker.view
{
    partial class Dashboard
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnGit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFixedBug = new System.Windows.Forms.Button();
            this.btnAddBug = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblUserName);
            this.panelTop.Controls.Add(this.lblUserType);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(694, 119);
            this.panelTop.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(22, 87);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 15);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username";
            this.lblUserName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(22, 55);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(35, 15);
            this.lblUserType.TabIndex = 1;
            this.lblUserType.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(282, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug tracker";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.CadetBlue;
            this.panelBottom.Controls.Add(this.btnGit);
            this.panelBottom.Controls.Add(this.button3);
            this.panelBottom.Controls.Add(this.btnFixedBug);
            this.panelBottom.Controls.Add(this.btnAddBug);
            this.panelBottom.Controls.Add(this.btnAddProject);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 119);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(694, 400);
            this.panelBottom.TabIndex = 1;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint);
            // 
            // btnGit
            // 
            this.btnGit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGit.Location = new System.Drawing.Point(26, 297);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(99, 39);
            this.btnGit.TabIndex = 4;
            this.btnGit.Text = "Git Repository";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(26, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "View BugList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFixedBug
            // 
            this.btnFixedBug.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnFixedBug.Location = new System.Drawing.Point(26, 143);
            this.btnFixedBug.Name = "btnFixedBug";
            this.btnFixedBug.Size = new System.Drawing.Size(99, 58);
            this.btnFixedBug.TabIndex = 2;
            this.btnFixedBug.Text = "Bug Fixed Audit History";
            this.btnFixedBug.UseVisualStyleBackColor = true;
            this.btnFixedBug.Click += new System.EventHandler(this.btnFixedBug_Click);
            // 
            // btnAddBug
            // 
            this.btnAddBug.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddBug.Location = new System.Drawing.Point(26, 81);
            this.btnAddBug.Name = "btnAddBug";
            this.btnAddBug.Size = new System.Drawing.Size(99, 36);
            this.btnAddBug.TabIndex = 1;
            this.btnAddBug.Text = "Record Bug";
            this.btnAddBug.UseVisualStyleBackColor = true;
            this.btnAddBug.Click += new System.EventHandler(this.btnAddBug_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddProject.Location = new System.Drawing.Point(26, 19);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(99, 39);
            this.btnAddProject.TabIndex = 0;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 519);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFixedBug;
        private System.Windows.Forms.Button btnAddBug;
        private System.Windows.Forms.Button btnGit;
    }
}