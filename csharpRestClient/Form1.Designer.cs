namespace csharpRestClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblRequest = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpAuthType = new System.Windows.Forms.GroupBox();
            this.rdbNTLM = new System.Windows.Forms.RadioButton();
            this.rdbBasicAuthentication = new System.Windows.Forms.RadioButton();
            this.grpTechnique = new System.Windows.Forms.GroupBox();
            this.rdbNetworkCredentialClass = new System.Windows.Forms.RadioButton();
            this.rdbRollYourOwn = new System.Windows.Forms.RadioButton();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpAuthType.SuspendLayout();
            this.grpTechnique.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRestURI
            // 
            this.txtRestURI.Location = new System.Drawing.Point(94, 12);
            this.txtRestURI.Name = "txtRestURI";
            this.txtRestURI.Size = new System.Drawing.Size(406, 23);
            this.txtRestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(94, 176);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(547, 262);
            this.txtResponse.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(506, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(135, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(12, 15);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(76, 15);
            this.lblRequest.TabIndex = 3;
            this.lblRequest.Text = "Request URI: ";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(25, 176);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(63, 15);
            this.lblResponse.TabIndex = 4;
            this.lblResponse.Text = "Response: ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(94, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 23);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(300, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // grpAuthType
            // 
            this.grpAuthType.Controls.Add(this.rdbNTLM);
            this.grpAuthType.Controls.Add(this.rdbBasicAuthentication);
            this.grpAuthType.Location = new System.Drawing.Point(94, 70);
            this.grpAuthType.Name = "grpAuthType";
            this.grpAuthType.Size = new System.Drawing.Size(200, 100);
            this.grpAuthType.TabIndex = 7;
            this.grpAuthType.TabStop = false;
            this.grpAuthType.Text = "Auth Type";
            // 
            // rdbNTLM
            // 
            this.rdbNTLM.AutoSize = true;
            this.rdbNTLM.Location = new System.Drawing.Point(6, 47);
            this.rdbNTLM.Name = "rdbNTLM";
            this.rdbNTLM.Size = new System.Drawing.Size(117, 19);
            this.rdbNTLM.TabIndex = 1;
            this.rdbNTLM.Text = "NTLM (Windows)";
            this.rdbNTLM.UseVisualStyleBackColor = true;
            // 
            // rdbBasicAuthentication
            // 
            this.rdbBasicAuthentication.AutoSize = true;
            this.rdbBasicAuthentication.Checked = true;
            this.rdbBasicAuthentication.Location = new System.Drawing.Point(6, 22);
            this.rdbBasicAuthentication.Name = "rdbBasicAuthentication";
            this.rdbBasicAuthentication.Size = new System.Drawing.Size(134, 19);
            this.rdbBasicAuthentication.TabIndex = 0;
            this.rdbBasicAuthentication.TabStop = true;
            this.rdbBasicAuthentication.Text = "Basic Authentication";
            this.rdbBasicAuthentication.UseVisualStyleBackColor = true;
            // 
            // grpTechnique
            // 
            this.grpTechnique.Controls.Add(this.rdbNetworkCredentialClass);
            this.grpTechnique.Controls.Add(this.rdbRollYourOwn);
            this.grpTechnique.Location = new System.Drawing.Point(300, 70);
            this.grpTechnique.Name = "grpTechnique";
            this.grpTechnique.Size = new System.Drawing.Size(200, 100);
            this.grpTechnique.TabIndex = 8;
            this.grpTechnique.TabStop = false;
            this.grpTechnique.Text = "Technique";
            // 
            // rdbNetworkCredentialClass
            // 
            this.rdbNetworkCredentialClass.AutoSize = true;
            this.rdbNetworkCredentialClass.Location = new System.Drawing.Point(6, 47);
            this.rdbNetworkCredentialClass.Name = "rdbNetworkCredentialClass";
            this.rdbNetworkCredentialClass.Size = new System.Drawing.Size(157, 19);
            this.rdbNetworkCredentialClass.TabIndex = 1;
            this.rdbNetworkCredentialClass.Text = "Network Credential Class";
            this.rdbNetworkCredentialClass.UseVisualStyleBackColor = true;
            // 
            // rdbRollYourOwn
            // 
            this.rdbRollYourOwn.AutoSize = true;
            this.rdbRollYourOwn.Checked = true;
            this.rdbRollYourOwn.Location = new System.Drawing.Point(6, 22);
            this.rdbRollYourOwn.Name = "rdbRollYourOwn";
            this.rdbRollYourOwn.Size = new System.Drawing.Size(100, 19);
            this.rdbRollYourOwn.TabIndex = 0;
            this.rdbRollYourOwn.TabStop = true;
            this.rdbRollYourOwn.Text = "Roll Your Own";
            this.rdbRollYourOwn.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 15);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User Name: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(231, 44);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 15);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.grpTechnique);
            this.Controls.Add(this.grpAuthType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRestURI);
            this.Name = "Form1";
            this.Text = "c# REST Cçoemt";
            this.grpAuthType.ResumeLayout(false);
            this.grpAuthType.PerformLayout();
            this.grpTechnique.ResumeLayout(false);
            this.grpTechnique.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRestURI;
        private TextBox txtResponse;
        private Button btnGo;
        private Label lblRequest;
        private Label lblResponse;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private GroupBox grpAuthType;
        private GroupBox grpTechnique;
        private Label lblUserName;
        private Label lblPassword;
        private RadioButton rdbNTLM;
        private RadioButton rdbBasicAuthentication;
        private RadioButton rdbNetworkCredentialClass;
        private RadioButton rdbRollYourOwn;
    }
}