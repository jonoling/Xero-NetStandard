/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.4.4
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Defines CalendarType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CalendarType
    {
        /// <summary>
        /// Enum WEEKLY for value: WEEKLY
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY = 1,

        /// <summary>
        /// Enum FORTNIGHTLY for value: FORTNIGHTLY
        /// </summary>
        [EnumMember(Value = "FORTNIGHTLY")]
        FORTNIGHTLY = 2,

        /// <summary>
        /// Enum FOURWEEKLY for value: FOURWEEKLY
        /// </summary>
        [EnumMember(Value = "FOURWEEKLY")]
        FOURWEEKLY = 3,

        /// <summary>
        /// Enum MONTHLY for value: MONTHLY
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY = 4,

        /// <summary>
        /// Enum TWICEMONTHLY for value: TWICEMONTHLY
        /// </summary>
        [EnumMember(Value = "TWICEMONTHLY")]
        TWICEMONTHLY = 5,

        /// <summary>
        /// Enum QUARTERLY for value: QUARTERLY
        /// </summary>
        [EnumMember(Value = "QUARTERLY")]
        QUARTERLY = 6

    }

}
