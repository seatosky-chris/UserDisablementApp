using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDisablementLibrary
{
    public class UserModel
    {
        /// <summary>
        /// The GUID from AD for this user.
        /// </summary>
        /// <remarks>
        /// The AD user is chosen during the disablement process and
        /// the GUID is queried from AD at that time.
        /// Mandatory if ADType != None.
        /// </remarks>
        public string ADUserGUID { get; set; }

        /// <summary>
        /// True if this is an email only account (no AD).
        /// </summary>
        /// <remarks>
        /// Value chosen during the disablement process but
        /// can be forced to true if the global settings have ADType = None.
        /// Mandatory.
        /// </remarks>
        /// <see cref="CompanyConfigurationModel.ADType"/>
        public bool EmailOnly { get; set; }

        /// <summary>
        /// The ticket # in our PSA that led to the disablement of this user.
        /// </summary>
        /// <remarks>Entered during the disablement process. Mandatory.</remarks>
        public string TicketNumber { get; set; }

        /// <summary>
        /// The initials of the technician running this disablement process.
        /// </summary>
        /// <remarks>
        /// Entered during the disablement process.
        /// Used for setting the AD description.
        /// Mandatory.
        /// </remarks>
        public string TechniciansInititals { get; set; }

        /// <summary>
        /// The date and time to disable this user on.
        /// Can be used to schedule the disablement.
        /// </summary>
        public DateTime DisablementDate { get; set; }

        /// <summary>
        /// If true then a truncated disablement process will
        /// be used to make it easy to re-enable this user.
        /// </summary>
        public bool ReturningUser { get; set; }

        /// <summary>
        /// A date and time for when this user will return.
        /// Can be used to schedule re-enablement.
        /// </summary>
        /// <remarks>Only can be set if ReturningUser is true.</remarks>
        /// <see cref="ReturningUser"/>
        public DateTime ReturnDate { get; set; }

        /// <summary>
        /// A randomly generated password to change the users password
        /// to before disabling.
        /// </summary>
        /// <remarks>Randomly generated during the creation process. Mandatory.</remarks>
        public string NewPassword { get; set; }



        /// <summary>
        /// A list of O365 mailboxes (their GUID) to give
        /// delegation access - 'read and manage' access to.
        /// </summary>
        /// <remarks>
        /// The list of mailboxes will be loaded from O365 directly
        /// and can be chosen from.
        /// </remarks>
        public List<string> Delegation_ReadManage { get; set; }

        /// <summary>
        /// A list of O365 mailboxes (their GUID) to give
        /// delegation access - 'send as' access to.
        /// </summary>
        /// <remarks>
        /// The list of mailboxes will be loaded from O365 directly
        /// and can be chosen from.
        /// </remarks>
        public List<string> Delegation_SendAs { get; set; }

        /// <summary>
        /// A list of emails to setup email forwarding to.
        /// </summary>
        /// <remarks>
        /// These emails can either exist already in O365 or be
        /// custom additions.
        /// </remarks>
        public List<string> Delegation_Forwarding { get; set; }

        /// <summary>
        /// An email auto-response for internal use.
        /// </summary>
        public List<string> AutoResponse_Internal { get; set; }

        /// <summary>
        /// An email auto-response for external use.
        /// </summary>
        public List<string> AutoResponse_External { get; set; }
    }
}
