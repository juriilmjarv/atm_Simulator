namespace ATM_Simulator
{
    partial class ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AskForAccountNr = new System.Windows.Forms.Label();
            this.screenbutton1 = new System.Windows.Forms.Button();
            this.screenbutton2 = new System.Windows.Forms.Button();
            this.screenbutton3 = new System.Windows.Forms.Button();
            this.screenbutton4 = new System.Windows.Forms.Button();
            this.screenbutton5 = new System.Windows.Forms.Button();
            this.screenbutton6 = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.button1Cancel = new System.Windows.Forms.Button();
            this.button1Clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.textLabel3 = new System.Windows.Forms.Label();
            this.textLabel4 = new System.Windows.Forms.Label();
            this.textLabel5 = new System.Windows.Forms.Label();
            this.textLabel6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(136, 145);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // AskForAccountNr
            // 
            this.AskForAccountNr.AutoSize = true;
            this.AskForAccountNr.BackColor = System.Drawing.SystemColors.Highlight;
            this.AskForAccountNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskForAccountNr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AskForAccountNr.Location = new System.Drawing.Point(132, 105);
            this.AskForAccountNr.Name = "AskForAccountNr";
            this.AskForAccountNr.Size = new System.Drawing.Size(293, 20);
            this.AskForAccountNr.TabIndex = 1;
            this.AskForAccountNr.Text = "Please enter your account number: ";
            // 
            // screenbutton1
            // 
            this.screenbutton1.BackColor = System.Drawing.Color.DarkGray;
            this.screenbutton1.Location = new System.Drawing.Point(23, 98);
            this.screenbutton1.Name = "screenbutton1";
            this.screenbutton1.Size = new System.Drawing.Size(75, 23);
            this.screenbutton1.TabIndex = 5;
            this.screenbutton1.UseVisualStyleBackColor = false;
            this.screenbutton1.Click += new System.EventHandler(this.screenbutton1_Click);
            // 
            // screenbutton2
            // 
            this.screenbutton2.BackColor = System.Drawing.Color.DarkGray;
            this.screenbutton2.Location = new System.Drawing.Point(23, 163);
            this.screenbutton2.Name = "screenbutton2";
            this.screenbutton2.Size = new System.Drawing.Size(75, 23);
            this.screenbutton2.TabIndex = 6;
            this.screenbutton2.UseVisualStyleBackColor = false;
            this.screenbutton2.Click += new System.EventHandler(this.screenbutton2_Click);
            // 
            // screenbutton3
            // 
            this.screenbutton3.BackColor = System.Drawing.Color.DarkGray;
            this.screenbutton3.Location = new System.Drawing.Point(23, 228);
            this.screenbutton3.Name = "screenbutton3";
            this.screenbutton3.Size = new System.Drawing.Size(75, 23);
            this.screenbutton3.TabIndex = 7;
            this.screenbutton3.UseVisualStyleBackColor = false;
            this.screenbutton3.Click += new System.EventHandler(this.screenbutton3_Click);
            // 
            // screenbutton4
            // 
            this.screenbutton4.BackColor = System.Drawing.Color.DarkGray;
            this.screenbutton4.Location = new System.Drawing.Point(463, 98);
            this.screenbutton4.Name = "screenbutton4";
            this.screenbutton4.Size = new System.Drawing.Size(75, 23);
            this.screenbutton4.TabIndex = 8;
            this.screenbutton4.UseVisualStyleBackColor = false;
            this.screenbutton4.Click += new System.EventHandler(this.screenbutton4_Click);
            // 
            // screenbutton5
            // 
            this.screenbutton5.BackColor = System.Drawing.Color.DarkGray;
            this.screenbutton5.Location = new System.Drawing.Point(463, 163);
            this.screenbutton5.Name = "screenbutton5";
            this.screenbutton5.Size = new System.Drawing.Size(75, 23);
            this.screenbutton5.TabIndex = 9;
            this.screenbutton5.UseVisualStyleBackColor = false;
            this.screenbutton5.Click += new System.EventHandler(this.screenbutton5_Click);
            // 
            // screenbutton6
            // 
            this.screenbutton6.BackColor = System.Drawing.Color.DarkGray;
            this.screenbutton6.Location = new System.Drawing.Point(463, 228);
            this.screenbutton6.Name = "screenbutton6";
            this.screenbutton6.Size = new System.Drawing.Size(75, 23);
            this.screenbutton6.TabIndex = 10;
            this.screenbutton6.UseVisualStyleBackColor = false;
            this.screenbutton6.Click += new System.EventHandler(this.screenbutton6_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Silver;
            this.buttonEnter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEnter.Location = new System.Drawing.Point(380, 410);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 44);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // button1Cancel
            // 
            this.button1Cancel.BackColor = System.Drawing.Color.Silver;
            this.button1Cancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Cancel.ForeColor = System.Drawing.Color.Red;
            this.button1Cancel.Location = new System.Drawing.Point(380, 300);
            this.button1Cancel.Name = "button1Cancel";
            this.button1Cancel.Size = new System.Drawing.Size(75, 44);
            this.button1Cancel.TabIndex = 12;
            this.button1Cancel.Text = "CANCEL";
            this.button1Cancel.UseVisualStyleBackColor = false;
            this.button1Cancel.Click += new System.EventHandler(this.button1Cancel_Click);
            // 
            // button1Clear
            // 
            this.button1Clear.BackColor = System.Drawing.Color.Silver;
            this.button1Clear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Clear.ForeColor = System.Drawing.Color.Yellow;
            this.button1Clear.Location = new System.Drawing.Point(380, 355);
            this.button1Clear.Name = "button1Clear";
            this.button1Clear.Size = new System.Drawing.Size(75, 44);
            this.button1Clear.TabIndex = 13;
            this.button1Clear.Text = "CLEAR";
            this.button1Clear.UseVisualStyleBackColor = false;
            this.button1Clear.Click += new System.EventHandler(this.button1Clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(112, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 229);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLabel1.Location = new System.Drawing.Point(119, 98);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(126, 20);
            this.textLabel1.TabIndex = 15;
            this.textLabel1.Text = "Withdraw money";
            this.textLabel1.Visible = false;
            this.textLabel1.Click += new System.EventHandler(this.textLabel1_Click);
            // 
            // textLabel2
            // 
            this.textLabel2.AutoSize = true;
            this.textLabel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.textLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLabel2.Location = new System.Drawing.Point(120, 168);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(116, 20);
            this.textLabel2.TabIndex = 16;
            this.textLabel2.Text = "Check Balance";
            this.textLabel2.Visible = false;
            // 
            // textLabel3
            // 
            this.textLabel3.AutoSize = true;
            this.textLabel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.textLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLabel3.Location = new System.Drawing.Point(120, 233);
            this.textLabel3.Name = "textLabel3";
            this.textLabel3.Size = new System.Drawing.Size(35, 20);
            this.textLabel3.TabIndex = 17;
            this.textLabel3.Text = "Exit";
            this.textLabel3.Visible = false;
            // 
            // textLabel4
            // 
            this.textLabel4.AutoSize = true;
            this.textLabel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.textLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLabel4.Location = new System.Drawing.Point(321, 98);
            this.textLabel4.Name = "textLabel4";
            this.textLabel4.Size = new System.Drawing.Size(126, 20);
            this.textLabel4.TabIndex = 18;
            this.textLabel4.Text = "Withdraw money";
            this.textLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textLabel4.Visible = false;
            // 
            // textLabel5
            // 
            this.textLabel5.AutoSize = true;
            this.textLabel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.textLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLabel5.Location = new System.Drawing.Point(321, 168);
            this.textLabel5.Name = "textLabel5";
            this.textLabel5.Size = new System.Drawing.Size(126, 20);
            this.textLabel5.TabIndex = 19;
            this.textLabel5.Text = "Withdraw money";
            this.textLabel5.Visible = false;
            // 
            // textLabel6
            // 
            this.textLabel6.AutoSize = true;
            this.textLabel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.textLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLabel6.Location = new System.Drawing.Point(321, 233);
            this.textLabel6.Name = "textLabel6";
            this.textLabel6.Size = new System.Drawing.Size(126, 20);
            this.textLabel6.TabIndex = 20;
            this.textLabel6.Text = "Withdraw money";
            this.textLabel6.Visible = false;
            this.textLabel6.Click += new System.EventHandler(this.textLabel6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCustomerID.Location = new System.Drawing.Point(120, 59);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(204, 20);
            this.labelCustomerID.TabIndex = 22;
            this.labelCustomerID.Text = "Hello Customer Number:";
            this.labelCustomerID.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(380, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.textLabel6);
            this.Controls.Add(this.textLabel5);
            this.Controls.Add(this.textLabel4);
            this.Controls.Add(this.textLabel3);
            this.Controls.Add(this.textLabel2);
            this.Controls.Add(this.textLabel1);
            this.Controls.Add(this.button1Clear);
            this.Controls.Add(this.button1Cancel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.screenbutton6);
            this.Controls.Add(this.screenbutton5);
            this.Controls.Add(this.screenbutton4);
            this.Controls.Add(this.screenbutton3);
            this.Controls.Add(this.screenbutton2);
            this.Controls.Add(this.screenbutton1);
            this.Controls.Add(this.AskForAccountNr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AskForAccountNr;
        private System.Windows.Forms.Button screenbutton1;
        private System.Windows.Forms.Button screenbutton2;
        private System.Windows.Forms.Button screenbutton3;
        private System.Windows.Forms.Button screenbutton4;
        private System.Windows.Forms.Button screenbutton5;
        private System.Windows.Forms.Button screenbutton6;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button button1Cancel;
        private System.Windows.Forms.Button button1Clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.Label textLabel2;
        private System.Windows.Forms.Label textLabel3;
        private System.Windows.Forms.Label textLabel4;
        private System.Windows.Forms.Label textLabel5;
        private System.Windows.Forms.Label textLabel6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Button button1;
    }
}

