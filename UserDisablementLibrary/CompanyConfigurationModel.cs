using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAppSharedLibrary;
using static UserAppSharedLibrary.CompanyConfigurationSharedModel;

namespace UserDisablementLibrary
{

    public class CompanyConfigurationModel
    {
        /// <summary>
        /// True if AD to O365 sync is setup and running.
        /// </summary>
        public bool ADO365SyncOn { get; set; }

        /// <summary>
        /// The AD type in-use, if any. Is it On Premise, Azure, or No AD?
        /// </summary>
        /// <value>OnPremise, Azure, or None</value>
        public ADTypeConfiguration ADType { get; set; }

        /// <summary>
        /// The Email type in-use, if any. Is it Office 365, Exchange, or No Email?
        /// </summary>
        /// <value>O365, Exchange, or None</value>
        public EmailTypeConfiguration EmailType { get; set; }



        /// <summary>
        /// A list of all the AD Folder defaults.
        /// </summary>
        /// <remarks>
        /// This is configured in the global settings.
        /// It is stored and loaded from the DB on load.
        /// This data is shared with the User Creation app.
        /// In the disablement app we only use the actual folder locations.
        /// </remarks>
        /// <see cref="ADFolderDefaultModel"/>
        public List<ADFolderDefaultModel> ADFolders { get; set; } = new List<ADFolderDefaultModel>();

        /// <summary>
        /// A list of all the AD Custom Attributes loaded.
        /// </summary>
        /// <remarks>
        /// This is configured in the global settings.
        /// It is stored and loaded from the DB on load.
        /// </remarks>
        /// <see cref="CustomAttributesModel"/>
        public List<CustomAttributesModel> CustomAttributes { get; set; } = new List<CustomAttributesModel>();

        /// <summary>
        /// The file path to backup the AD groups too.
        /// </summary>
        /// <remarks>
        /// This is configured in the global settings.
        /// It is stored and loaded from the DB on load.
        /// </remarks>
        public string ADGroupExportLocation { get; set; }



        /// <summary>
        /// The API credential details needed to connect to Azure / O365.
        /// </summary>
        public APICredentialsModel AzureO365APICredentials { get; set; }

        /// <summary>
        /// The API credential details needed to connect to IT Glue.
        /// </summary>
        public APICredentialsModel ITGAPICredentials { get; set; }

        /// <summary>
        /// The API credential details needed to connect to the Email Forwarder.
        /// </summary>
        public APICredentialsModel EmailForwarderAPICredentials { get; set; }

        /// <summary>
        /// The API credential details needed to connect to the Azure Storage Blob.
        /// </summary>
        /// <remarks>
        /// If set will enable email backups to the Storage Blob.
        /// If not setup, backups will not occur.
        /// </remarks>
        public APICredentialsModel AzureBlobAPICredentials { get; set; }
    }
}
