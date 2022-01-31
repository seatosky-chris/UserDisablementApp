using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDisablementLibrary
{
    public class CustomAttributesModel
    {
        /// <summary>
        /// The name of the AD Attribute to set (seen in the Attribute Editor).
        /// </summary>
        public string ADAttribute { get; set; }

        /// <summary>
        /// The value to set this attribute to.
        /// </summary>
        public string AttributeValue { get; set; }

        /// <summary>
        /// A list of EmployeeTypes to apply this attribute to.
        /// </summary>
        /// <remarks>
        /// Disabled if AllUsers = true
        /// </remarks>
        /// <see cref="CompanyConfigurationModel.EmployeeTypes"/>
        /// <see cref="AllUsers"/>
        public List<int> EmployeeTypes { get; set; } = new List<int>();

        /// <summary>
        /// A list of Locations to apply this attribute to.
        /// </summary>
        /// <remarks>
        /// Disabled if AllUsers = true
        /// </remarks>
        /// <see cref="CompanyConfigurationModel.Locations"/>
        /// <see cref="AllUsers"/>
        public List<int> Locations { get; set; } = new List<int>();

        /// <summary>
        /// If true, this attribute will be applied to all users.
        /// </summary>
        public bool AllUsers { get; set; }
    }
}
