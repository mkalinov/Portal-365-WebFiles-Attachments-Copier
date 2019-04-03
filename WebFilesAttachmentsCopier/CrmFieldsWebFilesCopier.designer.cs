namespace WebFilesAttachmentsCopier
{
    partial class CrmFieldsWebFilesCopier
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupSource = new System.Windows.Forms.GroupBox();
            this.ddlSourcePortal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.linkSource = new System.Windows.Forms.LinkLabel();
            this.groupAttachmentsCopySettings = new System.Windows.Forms.GroupBox();
            this.btnCopywebFiles = new System.Windows.Forms.Button();
            this.cbxAttachmentsKeepIDs = new System.Windows.Forms.CheckBox();
            this.cbxIncludeTextNotes = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupIntro = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupSiteSettings = new System.Windows.Forms.GroupBox();
            this.btnCopySiteSettings = new System.Windows.Forms.Button();
            this.groupBackupIDs = new System.Windows.Forms.GroupBox();
            this.btnRollBack = new System.Windows.Forms.Button();
            this.btnSelectIDsBackup = new System.Windows.Forms.Button();
            this.txtAttachmentsIDsBackUpFile = new System.Windows.Forms.TextBox();
            this.groupTarget = new System.Windows.Forms.GroupBox();
            this.ddlTargetPortal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTarget = new System.Windows.Forms.Button();
            this.linkTarget = new System.Windows.Forms.LinkLabel();
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.cbxReverseCopyWebFiles = new System.Windows.Forms.CheckBox();
            this.cbxCopyWebFiles = new System.Windows.Forms.CheckBox();
            this.cbxCopySiteSettings = new System.Windows.Forms.CheckBox();
            this.setBackupFile = new System.Windows.Forms.OpenFileDialog();
            this.lblReverse2 = new System.Windows.Forms.Label();
            this.lblReverse1 = new System.Windows.Forms.Label();
            this.lblTutorial3 = new System.Windows.Forms.Label();
            this.lblTutorial2 = new System.Windows.Forms.Label();
            this.lblTutorial1 = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.groupSource.SuspendLayout();
            this.groupAttachmentsCopySettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupIntro.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupSiteSettings.SuspendLayout();
            this.groupBackupIDs.SuspendLayout();
            this.groupTarget.SuspendLayout();
            this.groupActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1688, 27);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(107, 24);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // groupSource
            // 
            this.groupSource.Controls.Add(this.ddlSourcePortal);
            this.groupSource.Controls.Add(this.label8);
            this.groupSource.Controls.Add(this.btnSource);
            this.groupSource.Controls.Add(this.linkSource);
            this.groupSource.Location = new System.Drawing.Point(4, 4);
            this.groupSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSource.Name = "groupSource";
            this.groupSource.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSource.Size = new System.Drawing.Size(715, 224);
            this.groupSource.TabIndex = 6;
            this.groupSource.TabStop = false;
            this.groupSource.Text = "Source";
            // 
            // ddlSourcePortal
            // 
            this.ddlSourcePortal.FormattingEnabled = true;
            this.ddlSourcePortal.Location = new System.Drawing.Point(272, 118);
            this.ddlSourcePortal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlSourcePortal.Name = "ddlSourcePortal";
            this.ddlSourcePortal.Size = new System.Drawing.Size(417, 28);
            this.ddlSourcePortal.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Source Portal";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(19, 38);
            this.btnSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(229, 48);
            this.btnSource.TabIndex = 4;
            this.btnSource.Text = "Select Source Connection";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnChangeEnvironment_Click);
            // 
            // linkSource
            // 
            this.linkSource.AutoSize = true;
            this.linkSource.Font = new System.Drawing.Font("Arial", 10F);
            this.linkSource.Location = new System.Drawing.Point(272, 42);
            this.linkSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkSource.Name = "linkSource";
            this.linkSource.Size = new System.Drawing.Size(154, 44);
            this.linkSource.TabIndex = 2;
            this.linkSource.TabStop = true;
            this.linkSource.Text = "Source CRM:   {0}\r\n{1}";
            this.linkSource.UseCompatibleTextRendering = true;
            this.linkSource.Visible = false;
            // 
            // groupAttachmentsCopySettings
            // 
            this.groupAttachmentsCopySettings.Controls.Add(this.btnCopywebFiles);
            this.groupAttachmentsCopySettings.Controls.Add(this.cbxAttachmentsKeepIDs);
            this.groupAttachmentsCopySettings.Controls.Add(this.cbxIncludeTextNotes);
            this.groupAttachmentsCopySettings.Location = new System.Drawing.Point(4, 254);
            this.groupAttachmentsCopySettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupAttachmentsCopySettings.Name = "groupAttachmentsCopySettings";
            this.groupAttachmentsCopySettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupAttachmentsCopySettings.Size = new System.Drawing.Size(715, 166);
            this.groupAttachmentsCopySettings.TabIndex = 7;
            this.groupAttachmentsCopySettings.TabStop = false;
            this.groupAttachmentsCopySettings.Text = "Copy Options";
            this.groupAttachmentsCopySettings.Visible = false;
            // 
            // btnCopywebFiles
            // 
            this.btnCopywebFiles.Location = new System.Drawing.Point(500, 123);
            this.btnCopywebFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopywebFiles.Name = "btnCopywebFiles";
            this.btnCopywebFiles.Size = new System.Drawing.Size(191, 36);
            this.btnCopywebFiles.TabIndex = 8;
            this.btnCopywebFiles.Text = "Copy Web Files";
            this.btnCopywebFiles.UseVisualStyleBackColor = true;
            this.btnCopywebFiles.Click += new System.EventHandler(this.btnCopywebFiles_Click);
            // 
            // cbxAttachmentsKeepIDs
            // 
            this.cbxAttachmentsKeepIDs.AutoSize = true;
            this.cbxAttachmentsKeepIDs.Location = new System.Drawing.Point(31, 87);
            this.cbxAttachmentsKeepIDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAttachmentsKeepIDs.Name = "cbxAttachmentsKeepIDs";
            this.cbxAttachmentsKeepIDs.Size = new System.Drawing.Size(326, 24);
            this.cbxAttachmentsKeepIDs.TabIndex = 7;
            this.cbxAttachmentsKeepIDs.Text = "Keep List Of Created Notes for rollback";
            this.cbxAttachmentsKeepIDs.UseVisualStyleBackColor = true;
            this.cbxAttachmentsKeepIDs.CheckedChanged += new System.EventHandler(this.cbxAttachmentsKeepIDs_CheckedChanged);
            // 
            // cbxIncludeTextNotes
            // 
            this.cbxIncludeTextNotes.AutoSize = true;
            this.cbxIncludeTextNotes.Location = new System.Drawing.Point(31, 38);
            this.cbxIncludeTextNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxIncludeTextNotes.Name = "cbxIncludeTextNotes";
            this.cbxIncludeTextNotes.Size = new System.Drawing.Size(174, 24);
            this.cbxIncludeTextNotes.TabIndex = 6;
            this.cbxIncludeTextNotes.Text = "Include Text Nodes";
            this.cbxIncludeTextNotes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupIntro);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.groupActions);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1652, 887);
            this.panel1.TabIndex = 8;
            // 
            // groupIntro
            // 
            this.groupIntro.Controls.Add(this.lblReverse2);
            this.groupIntro.Controls.Add(this.lblReverse1);
            this.groupIntro.Controls.Add(this.lblTutorial3);
            this.groupIntro.Controls.Add(this.lblTutorial2);
            this.groupIntro.Controls.Add(this.lblTutorial1);
            this.groupIntro.Location = new System.Drawing.Point(429, 17);
            this.groupIntro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupIntro.Name = "groupIntro";
            this.groupIntro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupIntro.Size = new System.Drawing.Size(1189, 202);
            this.groupIntro.TabIndex = 14;
            this.groupIntro.TabStop = false;
            this.groupIntro.Text = "Introduction";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupSource, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupAttachmentsCopySettings, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupTarget, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 242);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1601, 626);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupSiteSettings, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBackupIDs, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(804, 254);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(773, 310);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // groupSiteSettings
            // 
            this.groupSiteSettings.Controls.Add(this.btnCopySiteSettings);
            this.groupSiteSettings.Location = new System.Drawing.Point(4, 174);
            this.groupSiteSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSiteSettings.Name = "groupSiteSettings";
            this.groupSiteSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSiteSettings.Size = new System.Drawing.Size(711, 86);
            this.groupSiteSettings.TabIndex = 12;
            this.groupSiteSettings.TabStop = false;
            this.groupSiteSettings.Text = "Site Settings";
            this.groupSiteSettings.Visible = false;
            // 
            // btnCopySiteSettings
            // 
            this.btnCopySiteSettings.Location = new System.Drawing.Point(503, 26);
            this.btnCopySiteSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopySiteSettings.Name = "btnCopySiteSettings";
            this.btnCopySiteSettings.Size = new System.Drawing.Size(191, 32);
            this.btnCopySiteSettings.TabIndex = 0;
            this.btnCopySiteSettings.Text = "Copy Site Settings";
            this.btnCopySiteSettings.UseVisualStyleBackColor = true;
            this.btnCopySiteSettings.Click += new System.EventHandler(this.btnCopySiteSettings_Click);
            // 
            // groupBackupIDs
            // 
            this.groupBackupIDs.Controls.Add(this.btnRollBack);
            this.groupBackupIDs.Controls.Add(this.btnSelectIDsBackup);
            this.groupBackupIDs.Controls.Add(this.txtAttachmentsIDsBackUpFile);
            this.groupBackupIDs.Location = new System.Drawing.Point(4, 4);
            this.groupBackupIDs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBackupIDs.Name = "groupBackupIDs";
            this.groupBackupIDs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBackupIDs.Size = new System.Drawing.Size(711, 162);
            this.groupBackupIDs.TabIndex = 8;
            this.groupBackupIDs.TabStop = false;
            this.groupBackupIDs.Text = "Roll back Web Files Import";
            this.groupBackupIDs.Visible = false;
            this.groupBackupIDs.VisibleChanged += new System.EventHandler(this.groupBackupIDs_VisibleChanged);
            // 
            // btnRollBack
            // 
            this.btnRollBack.Location = new System.Drawing.Point(503, 123);
            this.btnRollBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRollBack.Name = "btnRollBack";
            this.btnRollBack.Size = new System.Drawing.Size(191, 32);
            this.btnRollBack.TabIndex = 60;
            this.btnRollBack.Text = "Execute Rollback";
            this.btnRollBack.UseVisualStyleBackColor = true;
            this.btnRollBack.Click += new System.EventHandler(this.btnRollBack_Click);
            // 
            // btnSelectIDsBackup
            // 
            this.btnSelectIDsBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectIDsBackup.Location = new System.Drawing.Point(16, 48);
            this.btnSelectIDsBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectIDsBackup.Name = "btnSelectIDsBackup";
            this.btnSelectIDsBackup.Size = new System.Drawing.Size(143, 32);
            this.btnSelectIDsBackup.TabIndex = 59;
            this.btnSelectIDsBackup.Text = "Select File";
            this.btnSelectIDsBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectIDsBackup.UseCompatibleTextRendering = true;
            this.btnSelectIDsBackup.UseVisualStyleBackColor = false;
            this.btnSelectIDsBackup.Click += new System.EventHandler(this.btnSelectIDsBackup_Click);
            // 
            // txtAttachmentsIDsBackUpFile
            // 
            this.txtAttachmentsIDsBackUpFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAttachmentsIDsBackUpFile.Location = new System.Drawing.Point(204, 52);
            this.txtAttachmentsIDsBackUpFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAttachmentsIDsBackUpFile.Multiline = true;
            this.txtAttachmentsIDsBackUpFile.Name = "txtAttachmentsIDsBackUpFile";
            this.txtAttachmentsIDsBackUpFile.ReadOnly = true;
            this.txtAttachmentsIDsBackUpFile.Size = new System.Drawing.Size(488, 48);
            this.txtAttachmentsIDsBackUpFile.TabIndex = 58;
            // 
            // groupTarget
            // 
            this.groupTarget.Controls.Add(this.ddlTargetPortal);
            this.groupTarget.Controls.Add(this.label9);
            this.groupTarget.Controls.Add(this.btnTarget);
            this.groupTarget.Controls.Add(this.linkTarget);
            this.groupTarget.Location = new System.Drawing.Point(804, 4);
            this.groupTarget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTarget.Name = "groupTarget";
            this.groupTarget.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTarget.Size = new System.Drawing.Size(715, 224);
            this.groupTarget.TabIndex = 14;
            this.groupTarget.TabStop = false;
            this.groupTarget.Text = "Target";
            // 
            // ddlTargetPortal
            // 
            this.ddlTargetPortal.FormattingEnabled = true;
            this.ddlTargetPortal.Location = new System.Drawing.Point(281, 122);
            this.ddlTargetPortal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlTargetPortal.Name = "ddlTargetPortal";
            this.ddlTargetPortal.Size = new System.Drawing.Size(417, 28);
            this.ddlTargetPortal.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Target Portal";
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(20, 38);
            this.btnTarget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(229, 48);
            this.btnTarget.TabIndex = 5;
            this.btnTarget.Text = "Select Target Connection";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnChangeEnvironment_Click);
            // 
            // linkTarget
            // 
            this.linkTarget.AutoSize = true;
            this.linkTarget.Font = new System.Drawing.Font("Arial", 10F);
            this.linkTarget.Location = new System.Drawing.Point(281, 42);
            this.linkTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkTarget.Name = "linkTarget";
            this.linkTarget.Size = new System.Drawing.Size(142, 44);
            this.linkTarget.TabIndex = 3;
            this.linkTarget.TabStop = true;
            this.linkTarget.Text = "Target CRM:  {0}\r\n{1}";
            this.linkTarget.UseCompatibleTextRendering = true;
            this.linkTarget.Visible = false;
            // 
            // groupActions
            // 
            this.groupActions.Controls.Add(this.cbxReverseCopyWebFiles);
            this.groupActions.Controls.Add(this.cbxCopyWebFiles);
            this.groupActions.Controls.Add(this.cbxCopySiteSettings);
            this.groupActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupActions.ForeColor = System.Drawing.Color.Navy;
            this.groupActions.Location = new System.Drawing.Point(17, 17);
            this.groupActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupActions.Name = "groupActions";
            this.groupActions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupActions.Size = new System.Drawing.Size(393, 202);
            this.groupActions.TabIndex = 11;
            this.groupActions.TabStop = false;
            this.groupActions.Text = "Select Process";
            // 
            // cbxReverseCopyWebFiles
            // 
            this.cbxReverseCopyWebFiles.AutoSize = true;
            this.cbxReverseCopyWebFiles.Location = new System.Drawing.Point(12, 96);
            this.cbxReverseCopyWebFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxReverseCopyWebFiles.Name = "cbxReverseCopyWebFiles";
            this.cbxReverseCopyWebFiles.Size = new System.Drawing.Size(238, 24);
            this.cbxReverseCopyWebFiles.TabIndex = 9;
            this.cbxReverseCopyWebFiles.Text = "Reverse Web Files Copy";
            this.cbxReverseCopyWebFiles.UseVisualStyleBackColor = true;
            this.cbxReverseCopyWebFiles.CheckedChanged += new System.EventHandler(this.cbxReverseCopyWebFiles_CheckedChanged);
            // 
            // cbxCopyWebFiles
            // 
            this.cbxCopyWebFiles.AutoSize = true;
            this.cbxCopyWebFiles.Location = new System.Drawing.Point(13, 39);
            this.cbxCopyWebFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCopyWebFiles.Name = "cbxCopyWebFiles";
            this.cbxCopyWebFiles.Size = new System.Drawing.Size(163, 24);
            this.cbxCopyWebFiles.TabIndex = 8;
            this.cbxCopyWebFiles.Text = "Copy Web Files";
            this.cbxCopyWebFiles.UseVisualStyleBackColor = true;
            this.cbxCopyWebFiles.CheckedChanged += new System.EventHandler(this.cbxCopyWebFiles_CheckedChanged);
            // 
            // cbxCopySiteSettings
            // 
            this.cbxCopySiteSettings.AutoSize = true;
            this.cbxCopySiteSettings.Location = new System.Drawing.Point(12, 153);
            this.cbxCopySiteSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCopySiteSettings.Name = "cbxCopySiteSettings";
            this.cbxCopySiteSettings.Size = new System.Drawing.Size(339, 24);
            this.cbxCopySiteSettings.TabIndex = 7;
            this.cbxCopySiteSettings.Text = "Copy Site Settings. Non- Reversible!";
            this.cbxCopySiteSettings.UseVisualStyleBackColor = true;
            this.cbxCopySiteSettings.CheckedChanged += new System.EventHandler(this.cbxCopySiteSettings_CheckedChanged);
            // 
            // setBackupFile
            // 
            this.setBackupFile.Filter = "XML files (*.xml)|*.xml";
            // 
            // lblReverse2
            // 
            this.lblReverse2.AutoSize = true;
            this.lblReverse2.Location = new System.Drawing.Point(22, 130);
            this.lblReverse2.Name = "lblReverse2";
            this.lblReverse2.Size = new System.Drawing.Size(651, 20);
            this.lblReverse2.TabIndex = 12;
            this.lblReverse2.Text = "2. Select file holding you saved while import of attachments and hit \"Execute Rol" +
    "lback\"";
            this.lblReverse2.Visible = false;
            // 
            // lblReverse1
            // 
            this.lblReverse1.AutoSize = true;
            this.lblReverse1.Location = new System.Drawing.Point(22, 90);
            this.lblReverse1.Name = "lblReverse1";
            this.lblReverse1.Size = new System.Drawing.Size(314, 20);
            this.lblReverse1.TabIndex = 11;
            this.lblReverse1.Text = "1. Connect to the target crm environment";
            this.lblReverse1.Visible = false;
            // 
            // lblTutorial3
            // 
            this.lblTutorial3.AutoSize = true;
            this.lblTutorial3.Location = new System.Drawing.Point(22, 110);
            this.lblTutorial3.Name = "lblTutorial3";
            this.lblTutorial3.Size = new System.Drawing.Size(636, 20);
            this.lblTutorial3.TabIndex = 9;
            this.lblTutorial3.Text = "3. If you wish to include text notes along with files please check \"Include Text " +
    "Notes\"";
            this.lblTutorial3.Visible = false;
            // 
            // lblTutorial2
            // 
            this.lblTutorial2.AutoSize = true;
            this.lblTutorial2.Location = new System.Drawing.Point(22, 70);
            this.lblTutorial2.Name = "lblTutorial2";
            this.lblTutorial2.Size = new System.Drawing.Size(859, 20);
            this.lblTutorial2.TabIndex = 8;
            this.lblTutorial2.Text = "2. If you wish to be able to delete imported files check \"Keep list Of Created No" +
    "tes for rollback\" and select location";
            this.lblTutorial2.Visible = false;
            // 
            // lblTutorial1
            // 
            this.lblTutorial1.AutoSize = true;
            this.lblTutorial1.Location = new System.Drawing.Point(22, 39);
            this.lblTutorial1.Name = "lblTutorial1";
            this.lblTutorial1.Size = new System.Drawing.Size(651, 20);
            this.lblTutorial1.TabIndex = 7;
            this.lblTutorial1.Text = "1. Connect to sorce and target crm environments and select portals to sync Web Fi" +
    "les";
            this.lblTutorial1.Visible = false;
            // 
            // CrmFieldsWebFilesCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrmFieldsWebFilesCopier";
            this.Size = new System.Drawing.Size(1688, 946);
            this.Load += new System.EventHandler(this.CrmFieldsWebFilesCopier_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupSource.ResumeLayout(false);
            this.groupSource.PerformLayout();
            this.groupAttachmentsCopySettings.ResumeLayout(false);
            this.groupAttachmentsCopySettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupIntro.ResumeLayout(false);
            this.groupIntro.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupSiteSettings.ResumeLayout(false);
            this.groupBackupIDs.ResumeLayout(false);
            this.groupBackupIDs.PerformLayout();
            this.groupTarget.ResumeLayout(false);
            this.groupTarget.PerformLayout();
            this.groupActions.ResumeLayout(false);
            this.groupActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.GroupBox groupSource;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.LinkLabel linkTarget;
        private System.Windows.Forms.LinkLabel linkSource;
        private System.Windows.Forms.GroupBox groupAttachmentsCopySettings;
        private System.Windows.Forms.Button btnCopywebFiles;
        private System.Windows.Forms.CheckBox cbxIncludeTextNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.GroupBox groupBackupIDs;
        private System.Windows.Forms.Button btnSelectIDsBackup;
        private System.Windows.Forms.TextBox txtAttachmentsIDsBackUpFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog setBackupFile;
        private System.Windows.Forms.Button btnRollBack;
        private System.Windows.Forms.CheckBox cbxCopySiteSettings;
        private System.Windows.Forms.CheckBox cbxReverseCopyWebFiles;
        private System.Windows.Forms.CheckBox cbxCopyWebFiles;
        private System.Windows.Forms.GroupBox groupIntro;
        private System.Windows.Forms.ComboBox ddlSourcePortal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlTargetPortal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupSiteSettings;
        private System.Windows.Forms.Button btnCopySiteSettings;
        private System.Windows.Forms.GroupBox groupTarget;
        private System.Windows.Forms.CheckBox cbxAttachmentsKeepIDs;
        private System.Windows.Forms.Label lblReverse2;
        private System.Windows.Forms.Label lblReverse1;
        private System.Windows.Forms.Label lblTutorial3;
        private System.Windows.Forms.Label lblTutorial2;
        private System.Windows.Forms.Label lblTutorial1;
    }
}
