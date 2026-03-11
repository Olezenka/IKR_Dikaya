namespace IKR_Dikaya
{
    partial class AddWorkers_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label middle_NameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label second_NameLabel;
            System.Windows.Forms.Label roleLabel1;
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.middle_NameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.second_NameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            first_NameLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            middle_NameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            second_NameLabel = new System.Windows.Forms.Label();
            roleLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(36, 134);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 1;
            first_NameLabel.Text = "First Name:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(36, 81);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Login:";
            // 
            // middle_NameLabel
            // 
            middle_NameLabel.AutoSize = true;
            middle_NameLabel.Location = new System.Drawing.Point(36, 184);
            middle_NameLabel.Name = "middle_NameLabel";
            middle_NameLabel.Size = new System.Drawing.Size(72, 13);
            middle_NameLabel.TabIndex = 7;
            middle_NameLabel.Text = "Middle Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(36, 108);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password:";
            // 
            // second_NameLabel
            // 
            second_NameLabel.AutoSize = true;
            second_NameLabel.Location = new System.Drawing.Point(36, 159);
            second_NameLabel.Name = "second_NameLabel";
            second_NameLabel.Size = new System.Drawing.Size(78, 13);
            second_NameLabel.TabIndex = 13;
            second_NameLabel.Text = "Second Name:";
            second_NameLabel.Click += new System.EventHandler(this.second_NameLabel_Click);
            // 
            // roleLabel1
            // 
            roleLabel1.AutoSize = true;
            roleLabel1.Location = new System.Drawing.Point(36, 210);
            roleLabel1.Name = "roleLabel1";
            roleLabel1.Size = new System.Drawing.Size(32, 13);
            roleLabel1.TabIndex = 15;
            roleLabel1.Text = "Role:";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataSource = typeof(IKR_Dikaya.FolderModel.Workers);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(120, 131);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.first_NameTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(120, 78);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(121, 20);
            this.loginTextBox.TabIndex = 6;
            // 
            // middle_NameTextBox
            // 
            this.middle_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Middle_Name", true));
            this.middle_NameTextBox.Location = new System.Drawing.Point(120, 181);
            this.middle_NameTextBox.Name = "middle_NameTextBox";
            this.middle_NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.middle_NameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(120, 105);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // second_NameTextBox
            // 
            this.second_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Second_Name", true));
            this.second_NameTextBox.Location = new System.Drawing.Point(120, 156);
            this.second_NameTextBox.Name = "second_NameTextBox";
            this.second_NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.second_NameTextBox.TabIndex = 14;
            this.second_NameTextBox.TextChanged += new System.EventHandler(this.second_NameTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rolesBindingSource;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(IKR_Dikaya.FolderModel.Roles);
            this.rolesBindingSource.CurrentChanged += new System.EventHandler(this.rolesBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "Добавить сотрудника";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(68, 264);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 29);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddWorkers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 320);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(roleLabel1);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(middle_NameLabel);
            this.Controls.Add(this.middle_NameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(second_NameLabel);
            this.Controls.Add(this.second_NameTextBox);
            this.MaximumSize = new System.Drawing.Size(285, 359);
            this.MinimumSize = new System.Drawing.Size(285, 359);
            this.Name = "AddWorkers_Form";
            this.Text = "AddWorkers_Form";
            this.Load += new System.EventHandler(this.AddWorkers_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox middle_NameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox second_NameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
    }
}