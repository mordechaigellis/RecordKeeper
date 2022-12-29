namespace RecordKeeperWinForm
{
    partial class frmMain
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.GRecordSummary = new System.Windows.Forms.DataGridView();
            this.gPartyList = new System.Windows.Forms.DataGridView();
            this.gPresidentList = new System.Windows.Forms.DataGridView();
            this.tblConnection = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNewPresident = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRecordSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPartyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPresidentList)).BeginInit();
            this.tblConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.GRecordSummary, 0, 1);
            this.tblMain.Controls.Add(this.gPartyList, 1, 1);
            this.tblMain.Controls.Add(this.gPresidentList, 0, 2);
            this.tblMain.Controls.Add(this.tblConnection, 0, 0);
            this.tblMain.Controls.Add(this.btnNewPresident, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.Size = new System.Drawing.Size(1049, 720);
            this.tblMain.TabIndex = 0;
            // 
            // GRecordSummary
            // 
            this.GRecordSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRecordSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRecordSummary.Location = new System.Drawing.Point(3, 69);
            this.GRecordSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GRecordSummary.Name = "GRecordSummary";
            this.GRecordSummary.RowHeadersWidth = 51;
            this.GRecordSummary.RowTemplate.Height = 25;
            this.GRecordSummary.Size = new System.Drawing.Size(518, 319);
            this.GRecordSummary.TabIndex = 0;
            // 
            // gPartyList
            // 
            this.gPartyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPartyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPartyList.Location = new System.Drawing.Point(527, 69);
            this.gPartyList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gPartyList.Name = "gPartyList";
            this.gPartyList.RowHeadersWidth = 51;
            this.gPartyList.RowTemplate.Height = 25;
            this.gPartyList.Size = new System.Drawing.Size(519, 319);
            this.gPartyList.TabIndex = 1;
            // 
            // gPresidentList
            // 
            this.gPresidentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPresidentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPresidentList.Location = new System.Drawing.Point(3, 396);
            this.gPresidentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gPresidentList.Name = "gPresidentList";
            this.gPresidentList.RowHeadersWidth = 51;
            this.gPresidentList.RowTemplate.Height = 25;
            this.gPresidentList.Size = new System.Drawing.Size(518, 320);
            this.gPresidentList.TabIndex = 2;
            // 
            // tblConnection
            // 
            this.tblConnection.ColumnCount = 5;
            this.tblMain.SetColumnSpan(this.tblConnection, 2);
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.Controls.Add(this.label1, 0, 0);
            this.tblConnection.Controls.Add(this.label2, 1, 0);
            this.tblConnection.Controls.Add(this.label3, 2, 0);
            this.tblConnection.Controls.Add(this.label4, 3, 0);
            this.tblConnection.Controls.Add(this.txtServer, 0, 1);
            this.tblConnection.Controls.Add(this.txtDB, 1, 1);
            this.tblConnection.Controls.Add(this.txtUserName, 2, 1);
            this.tblConnection.Controls.Add(this.txtPassword, 3, 1);
            this.tblConnection.Controls.Add(this.btnConnect, 4, 1);
            this.tblConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConnection.Location = new System.Drawing.Point(3, 4);
            this.tblConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblConnection.Name = "tblConnection";
            this.tblConnection.RowCount = 2;
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblConnection.Size = new System.Drawing.Size(1043, 57);
            this.tblConnection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 10);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 10);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 10);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 10);
            this.label4.TabIndex = 3;
            this.label4.Text = "password";
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Location = new System.Drawing.Point(3, 14);
            this.txtServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(202, 27);
            this.txtServer.TabIndex = 4;
            // 
            // txtDB
            // 
            this.txtDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDB.Location = new System.Drawing.Point(211, 14);
            this.txtDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(202, 27);
            this.txtDB.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(419, 14);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(202, 27);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(627, 14);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 27);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(835, 14);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.tblConnection.SetRowSpan(this.btnConnect, 2);
            this.btnConnect.Size = new System.Drawing.Size(205, 39);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnNewPresident
            // 
            this.btnNewPresident.AutoSize = true;
            this.btnNewPresident.Location = new System.Drawing.Point(527, 396);
            this.btnNewPresident.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewPresident.Name = "btnNewPresident";
            this.btnNewPresident.Size = new System.Drawing.Size(130, 40);
            this.btnNewPresident.TabIndex = 4;
            this.btnNewPresident.Text = "New President";
            this.btnNewPresident.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 720);
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRecordSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPartyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPresidentList)).EndInit();
            this.tblConnection.ResumeLayout(false);
            this.tblConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView GRecordSummary;
        private DataGridView gPartyList;
        private DataGridView gPresidentList;
        private TableLayoutPanel tblConnection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServer;
        private TextBox txtDB;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnConnect;
        private Button btnNewPresident;
    }
}