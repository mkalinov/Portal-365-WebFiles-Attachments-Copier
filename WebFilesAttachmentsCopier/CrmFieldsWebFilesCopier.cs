using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.Collections.Specialized;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox.Extensibility.Args;
using DMM365.DataContainers;
using DMM365.Helper;


namespace WebFilesAttachmentsCopier
{
    public partial class CrmFieldsWebFilesCopier : PluginControlBase, IXrmToolBoxPluginControl, IStatusBarMessenger, INoConnectionRequired, IPayPalPlugin, IHelpPlugin

    {

        #region declarations

        //private Settings mySettings;
        public event EventHandler OnRequestConnection;
        
        private ConnectionDetail sourceDetail;
        private ConnectionDetail targetDetail;
        IOrganizationService sourceService;
        IOrganizationService targetService;
        List<CrmEntityContainer> sourcePortals;
        List<CrmEntityContainer> targetPortals;

        bool isLog = false;

        #endregion declarations


        #region IPayPalPlugin

        string IPayPalPlugin.DonationDescription => "Thanks in advance";

        string IPayPalPlugin.EmailAccount => "michael.kalinov@gmail.com";

        #endregion IPayPalPlugin


        #region IHelpPlugin

        string IHelpPlugin.HelpUrl => "https://github.com/mkalinov/WebFilesAttachmentsCopier";

        #endregion IHelpPlugin


        #region IStatusBarMessenger

        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

        #endregion IStatusBarMessenger


        #region PluginControlBase


        public CrmFieldsWebFilesCopier()
        {
            InitializeComponent();
        }


        private void CrmFieldsWebFilesCopier_Load(object sender, EventArgs e)
        {
           // ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrmFieldsWebFilesCopier_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            //SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName = "", object parameter = null)
        {

            if (actionName == "Target")
            {
                targetService = newService;
                targetDetail = detail;
                displayConnectionDetails(detail, "Target");
            }
            else
            {
                sourceService = newService;
                sourceDetail = detail;
                displayConnectionDetails(detail, "Source");
            }

            StartPortalSelection(!ReferenceEquals(targetService, null)
                && !ReferenceEquals(sourceService, null));

        }


        #endregion PluginControlBase


        #region Connection Change

        private void btnChangeEnvironment_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (ReferenceEquals(btn, null))
            {
                MessageBox.Show("Error on environment change");
                return;
            }
            if (OnRequestConnection != null)
            {
                var arg = new RequestConnectionEventArgs
                {
                    ActionName = btn.Name.IndexOf("Target") > -1 ? "Target" : "Source",
                    Control = this
                };
                OnRequestConnection(this, arg);
            }
        }


        #endregion Connection Change
                          

        #region  WebFilesSync

        private void btnCopywebFiles_Click(object sender, EventArgs e)
        {
            CopyWebFiles();
        }

        private void btnSelectIDsBackup_Click(object sender, EventArgs e)
        {
            //get data file             
            setBackupIDsfile();

        }

        private void cbxAttachmentsKeepIDs_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (ReferenceEquals(cb, null)) return;

            groupBackupIDs.Visible = btnSelectIDsBackup.Enabled = cb.Checked;

            if (!cb.Checked)
            {
                txtAttachmentsIDsBackUpFile.Text = string.Empty;                
                return;
            }

            MessageBox.Show("Select/create an xml file to keep list of created IDs");
            setBackupIDsfile();
        }

        private void setBackupIDsfile()
        {
            if (setBackupFile.ShowDialog() == DialogResult.OK)
            {
                txtAttachmentsIDsBackUpFile.Text = setBackupFile.FileName;
            }

        }

        private void btnRollBack_Click(object sender, EventArgs e)
        {
            RollBackAttachments();

        }

        private void groupBackupIDs_VisibleChanged(object sender, EventArgs e)
        {
            GroupBox gb = sender as GroupBox;
            if (ReferenceEquals(gb, null)) return;

            btnRollBack.Visible = cbxReverseCopyWebFiles.Checked;
        }

        private void cbxReverseCopyWebFiles_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (ReferenceEquals(cb, null)) return;

            btnRollBack.Visible = cbxReverseCopyWebFiles.Checked;
            lblReverse1.Visible = lblReverse2.Visible = cb.Checked;

            if (!cb.Checked)
            {
                reSetUI();
            }
            else
            {
                cbxCopyWebFiles.Checked = cbxCopySiteSettings.Checked = !cb.Checked;
                groupSiteSettings.Visible = groupAttachmentsCopySettings.Visible = groupSource.Visible = !cb.Checked;
                groupBackupIDs.Visible = btnSelectIDsBackup.Enabled = cb.Checked; 
            }

        }

        private void cbxCopyWebFiles_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (ReferenceEquals(cb, null)) return;
            
            lblTutorial1.Visible = lblTutorial2.Visible = lblTutorial3.Visible = cb.Checked;

            if (!cb.Checked)
            {
                reSetUI();
                //cleanAttachmentsSetting(cb.Checked);
            }
            else
            {

                cbxReverseCopyWebFiles.Checked = cbxCopySiteSettings.Checked = !cb.Checked;
                groupSiteSettings.Visible = !cb.Checked;
                groupAttachmentsCopySettings.Visible = groupSource.Visible = cb.Checked;
                groupBackupIDs.Visible = btnSelectIDsBackup.Enabled = cbxAttachmentsKeepIDs.Checked;
            }

        }


        #endregion WebFilesSync


        #region  Portal Settings sync

        private void btnCopySiteSettings_Click(object sender, EventArgs e)
        {
            CopySiteSettings();
        }

        private void cbxCopySiteSettings_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (ReferenceEquals(cb, null)) return;

            if (!cb.Checked)
            {
                reSetUI();
            }
            else
            {
                //two sources,  two portals
                groupSiteSettings.Visible = groupSource.Visible = cb.Checked;
                groupBackupIDs.Visible = groupAttachmentsCopySettings.Visible = !cb.Checked;
                cbxCopyWebFiles.Checked = cbxReverseCopyWebFiles.Checked = !cb.Checked;
            }

        }



        #endregion Portal Settings sync


        #region Helpers

        private void CopyWebFiles()
        {
            bool keepIds = cbxAttachmentsKeepIDs.Checked;
            bool includeNotes = cbxIncludeTextNotes.Checked;
            string message = string.Empty;
            List<Guid> ids = new List<Guid>();
            List<CrmEntityContainer> listOfWebFilesSource = new List<CrmEntityContainer>();
            List<CrmEntityContainer> listOfWebFilesTarget = new List<CrmEntityContainer>();

            //validate dropdouns portal selected
            if (!validateGroupCombos(groupSource))
            {
                MessageBox.Show("Please select a Source portal", "Mandatory field");
                return;
            }

            if (!validateGroupCombos(groupTarget))
            {
                MessageBox.Show("Please select a Target portal", "Mandatory field");
                return;
            }


            //vlidate not the same portal for same connections
            if (sourceDetail.ConnectionName == targetDetail.ConnectionName
                && ddlSourcePortal.SelectedValue == ddlTargetPortal.SelectedValue)
            {
                MessageBox.Show("Copy from source portal to  itself is not supported. Please select different target.", "WRONG SET");
                return;
            }

            if (keepIds)
            {
                if (!GlobalHelper.isValidString(txtAttachmentsIDsBackUpFile.Text) || !IOHelper.isFileExist(txtAttachmentsIDsBackUpFile.Text, ".xml"))
                {
                    MessageBox.Show("Attachment IDs backup file was not found", "File Not Found");
                    return;
                }
            }

            if (DialogResult.Yes == MessageBox.Show("You're going to copy Web Files attachments \r\n from '" + sourceDetail.OrganizationFriendlyName + "' crm, Portal '" + ddlSourcePortal.Text + "' \r\n to '" + targetDetail.OrganizationFriendlyName + "' cmr, Portal '" + ddlTargetPortal.Text + "' \r\n Recording of newly created attachemnts for potential rollback is " + (keepIds ? "'ON'" : "'OFF'") + " \r\n\n Execute?", "CONFIRM COPY", MessageBoxButtons.YesNo))
            {
                string bkLocation = txtAttachmentsIDsBackUpFile.Text;
                string sourcePortalName = ddlSourcePortal.Text;
                string sourcePortalId = ddlSourcePortal.SelectedValue.ToString();
                string targetPortalName = ddlTargetPortal.Text;
                string targetPortalId = ddlTargetPortal.SelectedValue.ToString();
                int counter = 0;
                int filesCount = 0;
                int filesFailed = 0;
                isLog = false;



                WorkAsync(new WorkAsyncInfo
                {
                    Message = $"Copy has begun ...",
                    Work = (bw, e) =>
                    {

                        listOfWebFilesSource = CrmHelper.getWebFilesByPortalId(sourceService, sourcePortalName, sourcePortalId, false);
                        listOfWebFilesTarget = CrmHelper.getWebFilesByPortalId(targetService, targetPortalName, targetPortalId, false);


                        foreach (CrmEntityContainer enSource in listOfWebFilesSource)
                        {
                            counter++;
                            //get single web file with same name, skip if plural
                            List<CrmEntityContainer> enTargets = listOfWebFilesTarget.Where(t => t.name == enSource.name).ToList();
                            if (ReferenceEquals(enTargets, null) || enTargets.Count == 0) continue;

                            Entity latestAttacnment = CrmHelper.getLattestAttachmentByEntity(sourceService, enSource.id, enSource.logicalName, includeNotes);
                            if (ReferenceEquals(latestAttacnment, null)) continue;

                            //copy to all found target webfiles
                            foreach (CrmEntityContainer enTarget in enTargets)
                            {
                                try
                                {
                                    Guid? newNote = CrmHelper.cloneAnnotationForSpecificID(targetService, latestAttacnment, enTarget.crmEntityRef);
                                    if (newNote.HasValue) ids.Add(newNote.Value);
                                    filesCount++;
                                }
                                catch (Exception ex)
                                {
                                    LogError(ex.Message);
                                    isLog = true;
                                    filesFailed++;
                                    continue;
                                }

                            }
                            decimal p = (counter / listOfWebFilesSource.Count) * 100;
                            int? progress = (int?)Math.Round(p, 0);
                            SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(progress, "Copy in progress ..."));

                        }

                        if (ids.Count > 0 && keepIds) IOHelper.SerializeObjectToXmlFile<List<Guid>>(ids, bkLocation);

                        message = $"Attachments found in source portal - {listOfWebFilesSource.Count}, \r\n  copied - {filesCount}, \r\n failed = {filesFailed} \r\n" + (keepIds ? $"  Attachments backed up - {ids.Count}" : "");

                    },
                    PostWorkCallBack = e =>
                    {
                        if (e.Error != null)
                        {
                            MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (isLog)
                        {
                            MessageBox.Show(this, "There were some errors on the execution. Please see log. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isLog = false;
                            return;
                        }
                        MessageBox.Show(message, "RESULT");

                    },
                    ProgressChanged = e => { SetWorkingMessage(e.UserState.ToString()); }
                });
            }

        }

        private void CopySiteSettings()
        {
            string message = string.Empty;

            //validate dropdouns portal selected
            if (!validateGroupCombos(groupSource))
            {
                MessageBox.Show("Please select a Source portal", "Mandatory field");
                return;
            }

            if (!validateGroupCombos(groupTarget))
            {
                MessageBox.Show("Please select a Target portal", "Mandatory field");
                return;
            }

            //vlidate not the same portal for same connections
            if (sourceDetail.ConnectionName == targetDetail.ConnectionName
                && ddlSourcePortal.SelectedValue == ddlTargetPortal.SelectedValue)
            {
                MessageBox.Show("Copy from source portal to  itself is not supported. Please select different target.", "WRONG SET");
                return;
            }


            if (DialogResult.Yes == MessageBox.Show("You're going to copy/update Site Settings \r\n from '" + sourceDetail.OrganizationFriendlyName + "' crm, Portal '" + ddlSourcePortal.Text + "' \r\n to '" + targetDetail.OrganizationFriendlyName + "' cmr, Portal '" + ddlTargetPortal.Text + " \r\n\n Execute?", "CONFIRM COPY", MessageBoxButtons.YesNo))
            {
                string sourcePortalName = ddlSourcePortal.Text;
                string sourcePortalId = ddlSourcePortal.SelectedValue.ToString();
                string targetPortalName = ddlTargetPortal.Text;
                string targetPortalId = ddlTargetPortal.SelectedValue.ToString();
                int counterUpdate = 0;
                int counterUpdateFailed = 0;
                int filesCreated = 0;
                int filesCreateFailed = 0;
                isLog = false;


                WorkAsync(new WorkAsyncInfo
                {
                    Message = $"",
                    Work = (bw, e) =>
                    {

                        List<CrmEntityContainer> listOfSSetingsSource = CrmHelper.getListOfSettingPerPortal(sourceService, sourcePortalName, sourcePortalId, false);
                        List<CrmEntityContainer> listOfSSetingsTarget = CrmHelper.getListOfSettingPerPortal(targetService, targetPortalName, targetPortalId, true);


                        if (ReferenceEquals(listOfSSetingsTarget, null) || listOfSSetingsTarget.Count == 0)
                            throw new Exception("No active Site Settings in Target portal");


                        List<Guid> result = new List<Guid>();
                        foreach (CrmEntityContainer enSource in listOfSSetingsSource)
                        {
                            //check mandatory field
                            bool isValueSource = enSource.crmEntity.Contains("adx_value");
                            //not mandatory
                            bool isDescription = enSource.crmEntity.Contains("adx_description");

                            //get single site setting with same name, skip if plural
                            List<CrmEntityContainer> enTargets = listOfSSetingsTarget.Where(t => t.name == enSource.name).ToList();
                            //if not found => create
                            if (ReferenceEquals(enTargets, null) || enTargets.Count == 0)
                            {
                                //copy site setting
                                Entity ss = new Entity("adx_sitesetting");
                                ss["adx_name"] = enSource.crmEntity["adx_name"];
                                ss["adx_websiteid"] = new EntityReference("adx_website", new Guid(ddlTargetPortal.SelectedValue.ToString()));

                                if (isValueSource)
                                    ss["adx_value"] = enSource.crmEntity["adx_value"];
                                if (isDescription)
                                    ss["adx_description"] = enSource.crmEntity["adx_description"];

                                try
                                {
                                    targetService.Create(ss);
                                    filesCreated++;
                                }
                                catch (Exception ex)
                                {
                                    LogError(ex.Message);
                                    isLog = true;
                                    filesCreateFailed++;
                                    continue;
                                }

                            }
                            else //update
                            {
                                foreach (CrmEntityContainer enTarget in enTargets)
                                {
                                    //update site setting
                                    try
                                    {
                                        bool isTargetValue = enTarget.crmEntity.Contains("adx_value");
                                        //execute update only if target value absent or different from source
                                        if (!isTargetValue && !isValueSource) continue;
                                        if (!isTargetValue
                                            ||
                                            (isTargetValue
                                            && enTarget.crmEntity["adx_value"].ToString() != (isValueSource ? enSource.crmEntity["adx_value"].ToString() : string.Empty)))
                                        {
                                            enTarget.crmEntity["adx_value"] = (isValueSource ? enSource.crmEntity["adx_value"] : string.Empty);
                                            enTarget.crmEntity["adx_description"] = (isDescription ? enSource.crmEntity["adx_description"] : string.Empty);

                                            targetService.Update(enTarget.crmEntity);

                                            counterUpdate++;
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        LogError(ex.Message);
                                        isLog = true;
                                        counterUpdateFailed++;
                                        continue;
                                    }
                                }
                            }

                            decimal p = ((counterUpdate + filesCreated) / listOfSSetingsSource.Count) * 100;
                            int? progress = (int?)Math.Round(p, 0);
                            SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(progress, "Copy in progress ..."));

                        }

                        message = $"Settings (active/inactive)  total source - {listOfSSetingsSource.Count}, \r\n total active settings in target - {listOfSSetingsTarget.Count}, \r\n  created - {filesCreated}, \r\n create failed = {filesCreateFailed} \r\n updated - {counterUpdate}, \r\n update failed = {counterUpdateFailed} ";


                    },
                    PostWorkCallBack = e =>
                    {
                        if (e.Error != null)
                        {
                            MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (isLog)
                        {
                            MessageBox.Show(this, "There were some errors on the execution. Please see log. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isLog = false;
                            return;
                        }

                        MessageBox.Show(message, "RESULT");

                    },
                    ProgressChanged = e => { SetWorkingMessage(e.UserState.ToString()); }
                });
            }
        }

        private void RollBackAttachments()
        {
            List<Guid> ids = new List<Guid>();
            //identify type of action
            bool keepIds = cbxAttachmentsKeepIDs.Checked;
            bool includeNotes = cbxIncludeTextNotes.Checked;
            string message = string.Empty;
            int counter = 0;
            int filesFailed = 0;
            isLog = false;

            //validate backup file   
            if (!GlobalHelper.isValidString(txtAttachmentsIDsBackUpFile.Text) || !IOHelper.isFileExist(txtAttachmentsIDsBackUpFile.Text, ".xml"))
            {
                MessageBox.Show("Attachment IDs backup file was not found");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("You're going to copy/update Site Settings \r\n from '"+ targetDetail.OrganizationFriendlyName + "' cmr, Portal '" + ddlTargetPortal.Text + " based on lest of ids  lokated in '" + txtAttachmentsIDsBackUpFile.Text + "' file. \r\n\n Execute?", "CONFIRM COPY", MessageBoxButtons.YesNo))
            {

                WorkAsync(new WorkAsyncInfo
                {
                    Message = $"Rolling back Web Files attachments",
                    Work = (bw, e) =>
                    {

                        ids = IOHelper.DeserializeXmlFromFile<List<Guid>>(txtAttachmentsIDsBackUpFile.Text);
                    //execute
                    foreach (Guid item in ids)
                        {
                            try
                            {
                               
                                targetService.Delete("annotation", item);
                                counter++;
                                decimal p = (counter / ids.Count) * 100;
                                int? progress = (int?)Math.Round(p, 0);
                                SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(progress, "Copy in progress ..."));
                            }
                            catch (Exception ex)
                            {
                                LogError(ex.Message);
                                isLog = true;
                                filesFailed++;
                                continue;
                            }
                        }
                        message = $"Total - {ids.Count.ToString()}, \r\n attachments removed from  {targetDetail.OrganizationFriendlyName} - {counter}, \r\n failed - {filesFailed}";
                    },
                    PostWorkCallBack = e =>
                    {
                        if (e.Error != null)
                        {
                            MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (isLog)
                        {
                            MessageBox.Show(this, "There were some errors on the execution. Please see log. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isLog = false;
                            return;
                        }

                        MessageBox.Show(message, "RESULT");

                    },
                    ProgressChanged = e => { SetWorkingMessage(e.UserState.ToString()); }
                });

            }
        }

        private void getListOfPortals(string environment)
        {
            IOrganizationService currentService = (environment.ToLower() == "Target".ToLower()) ? targetService : sourceService;
            List<CrmEntityContainer> portals = (environment.ToLower() == "Target".ToLower()) ? targetPortals : sourcePortals;
            ComboBox cb = (environment.ToLower() == "Target".ToLower()) ? ddlTargetPortal : ddlSourcePortal;


            WorkAsync(new WorkAsyncInfo
            {
                Message = $"",
                Work = (bw, e) =>
                {
                    portals = CrmHelper.getListOfPortals(currentService);
                },

                PostWorkCallBack = e =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(this, e.Error.Message, $"Error in {environment}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    populateDropDown(cb, portals);

                },
                ProgressChanged = e => { SetWorkingMessage(e.UserState.ToString()); }
            });
        }

        private void StartPortalSelection(bool isConnectionReady)
        {
            //set visible/hidden

            //fill/empty dropdowns
            if (isConnectionReady)
            {
                getListOfPortals("Target");
                getListOfPortals("Source");
            }
            else
            {
                if(!ReferenceEquals(sourcePortals, null)) sourcePortals.Clear();
                if(!ReferenceEquals(targetPortals, null)) targetPortals.Clear();
            }
        }

        private void displayConnectionDetails(ConnectionDetail detail, string serviceType)
        {
            switch (serviceType)
            {
                case "Source":
                    linkSource.Text = "Source CRM:   {0} \r\n{1}";
                    linkSource.Text = string.Format(linkSource.Text, detail.ConnectionName, detail.WebApplicationUrl);
                    linkSource.Visible = true;
                    break;

                case "Target":
                    linkTarget.Text = "Target CRM:   {0} \r\n{1}";
                    linkTarget.Text = string.Format(linkTarget.Text, detail.ConnectionName, detail.WebApplicationUrl);
                    linkTarget.Visible = true;
                    break;
            }
        }

        private void populateDropDown(ComboBox cb, List<CrmEntityContainer> ds)
        {
            cb.DataSource = ds;
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.SelectedItem = null;

        }

        private bool validateGroupCombos(GroupBox targetGroup)
        {

            foreach (var tbx in targetGroup.Controls.OfType<ComboBox>())
            {
                if (!GlobalHelper.isValidString(tbx.Text) && tbx.Enabled)
                {
                    tbx.BackColor = Color.LightSalmon;
                    return false;
                }
                else tbx.BackColor = Color.White;
            }

            return true;
        }

        private void cleanAttachmentsSetting(bool _checked)
        {
            foreach (Control item in groupAttachmentsCopySettings.Controls)
            {
                if (item is CheckBox) ((CheckBox)item).Checked = _checked;
            }
        }

        private void reSetUI()
        {

            if (!cbxCopySiteSettings.Checked && !cbxCopyWebFiles.Checked && !cbxReverseCopyWebFiles.Checked)
            {
                cleanAttachmentsSetting(cbxReverseCopyWebFiles.Checked);
                groupSiteSettings.Visible = groupAttachmentsCopySettings.Visible = groupBackupIDs.Visible = cbxReverseCopyWebFiles.Checked;
                groupSource.Visible = !cbxReverseCopyWebFiles.Checked;

                lblReverse1.Visible = lblReverse2.Visible = cbxReverseCopyWebFiles.Checked;
                lblTutorial1.Visible = lblTutorial2.Visible = lblTutorial3.Visible = cbxCopyWebFiles.Checked;
                btnSelectIDsBackup.Enabled = cbxReverseCopyWebFiles.Checked;


            }
        }

        #endregion Helpers

    }
}