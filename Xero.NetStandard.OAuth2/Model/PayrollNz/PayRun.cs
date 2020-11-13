/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// PayRun
    /// </summary>
    [DataContract]
    public partial class PayRun :  IEquatable<PayRun>, IValidatableObject
    {
        /// <summary>
        /// Pay run status
        /// </summary>
        /// <value>Pay run status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PayRunStatusEnum
        {
            /// <summary>
            /// Enum Draft for value: Draft
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft = 1,

            /// <summary>
            /// Enum Posted for value: Posted
            /// </summary>
            [EnumMember(Value = "Posted")]
            Posted = 2

        }

        /// <summary>
        /// Pay run status
        /// </summary>
        /// <value>Pay run status</value>
        [DataMember(Name="payRunStatus", EmitDefaultValue=false)]
        public PayRunStatusEnum PayRunStatus { get; set; }
        /// <summary>
        /// Pay run type
        /// </summary>
        /// <value>Pay run type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PayRunTypeEnum
        {
            /// <summary>
            /// Enum Scheduled for value: Scheduled
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled = 1,

            /// <summary>
            /// Enum Unscheduled for value: Unscheduled
            /// </summary>
            [EnumMember(Value = "Unscheduled")]
            Unscheduled = 2,

            /// <summary>
            /// Enum EarlierYearUpdate for value: EarlierYearUpdate
            /// </summary>
            [EnumMember(Value = "EarlierYearUpdate")]
            EarlierYearUpdate = 3

        }

        /// <summary>
        /// Pay run type
        /// </summary>
        /// <value>Pay run type</value>
        [DataMember(Name="payRunType", EmitDefaultValue=false)]
        public PayRunTypeEnum PayRunType { get; set; }
        /// <summary>
        /// Calendar type of the pay run
        /// </summary>
        /// <value>Calendar type of the pay run</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CalendarTypeEnum
        {
            /// <summary>
            /// Enum Weekly for value: Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly = 1,

            /// <summary>
            /// Enum Fortnightly for value: Fortnightly
            /// </summary>
            [EnumMember(Value = "Fortnightly")]
            Fortnightly = 2,

            /// <summary>
            /// Enum FourWeekly for value: FourWeekly
            /// </summary>
            [EnumMember(Value = "FourWeekly")]
            FourWeekly = 3,

            /// <summary>
            /// Enum Monthly for value: Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly = 4,

            /// <summary>
            /// Enum Annual for value: Annual
            /// </summary>
            [EnumMember(Value = "Annual")]
            Annual = 5,

            /// <summary>
            /// Enum Quarterly for value: Quarterly
            /// </summary>
            [EnumMember(Value = "Quarterly")]
            Quarterly = 6

        }

        /// <summary>
        /// Calendar type of the pay run
        /// </summary>
        /// <value>Calendar type of the pay run</value>
        [DataMember(Name="calendarType", EmitDefaultValue=false)]
        public CalendarTypeEnum CalendarType { get; set; }
        
        /// <summary>
        /// Xero unique identifier for the pay run
        /// </summary>
        /// <value>Xero unique identifier for the pay run</value>
        [DataMember(Name="payRunID", EmitDefaultValue=false)]
        public Guid? PayRunID { get; set; }

        /// <summary>
        /// Xero unique identifier for the payroll calendar
        /// </summary>
        /// <value>Xero unique identifier for the payroll calendar</value>
        [DataMember(Name="payrollCalendarID", EmitDefaultValue=false)]
        public Guid? PayrollCalendarID { get; set; }

        /// <summary>
        /// Period start date of the payroll calendar
        /// </summary>
        /// <value>Period start date of the payroll calendar</value>
        [DataMember(Name="periodStartDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PeriodStartDate { get; set; }

        /// <summary>
        /// Period end date of the payroll calendar
        /// </summary>
        /// <value>Period end date of the payroll calendar</value>
        [DataMember(Name="periodEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PeriodEndDate { get; set; }

        /// <summary>
        /// Payment date of the pay run
        /// </summary>
        /// <value>Payment date of the pay run</value>
        [DataMember(Name="paymentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Total cost of the pay run
        /// </summary>
        /// <value>Total cost of the pay run</value>
        [DataMember(Name="totalCost", EmitDefaultValue=false)]
        public decimal? TotalCost { get; set; }

        /// <summary>
        /// Total pay of the pay run
        /// </summary>
        /// <value>Total pay of the pay run</value>
        [DataMember(Name="totalPay", EmitDefaultValue=false)]
        public decimal? TotalPay { get; set; }

        /// <summary>
        /// Posted date time of the pay run
        /// </summary>
        /// <value>Posted date time of the pay run</value>
        [DataMember(Name="postedDateTime", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PostedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets PaySlips
        /// </summary>
        [DataMember(Name="paySlips", EmitDefaultValue=false)]
        public List<PaySlip> PaySlips { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayRun {\n");
            sb.Append("  PayRunID: ").Append(PayRunID).Append("\n");
            sb.Append("  PayrollCalendarID: ").Append(PayrollCalendarID).Append("\n");
            sb.Append("  PeriodStartDate: ").Append(PeriodStartDate).Append("\n");
            sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  TotalCost: ").Append(TotalCost).Append("\n");
            sb.Append("  TotalPay: ").Append(TotalPay).Append("\n");
            sb.Append("  PayRunStatus: ").Append(PayRunStatus).Append("\n");
            sb.Append("  PayRunType: ").Append(PayRunType).Append("\n");
            sb.Append("  CalendarType: ").Append(CalendarType).Append("\n");
            sb.Append("  PostedDateTime: ").Append(PostedDateTime).Append("\n");
            sb.Append("  PaySlips: ").Append(PaySlips).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PayRun);
        }

        /// <summary>
        /// Returns true if PayRun instances are equal
        /// </summary>
        /// <param name="input">Instance of PayRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayRunID == input.PayRunID ||
                    (this.PayRunID != null &&
                    this.PayRunID.Equals(input.PayRunID))
                ) && 
                (
                    this.PayrollCalendarID == input.PayrollCalendarID ||
                    (this.PayrollCalendarID != null &&
                    this.PayrollCalendarID.Equals(input.PayrollCalendarID))
                ) && 
                (
                    this.PeriodStartDate == input.PeriodStartDate ||
                    (this.PeriodStartDate != null &&
                    this.PeriodStartDate.Equals(input.PeriodStartDate))
                ) && 
                (
                    this.PeriodEndDate == input.PeriodEndDate ||
                    (this.PeriodEndDate != null &&
                    this.PeriodEndDate.Equals(input.PeriodEndDate))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.TotalCost == input.TotalCost ||
                    this.TotalCost.Equals(input.TotalCost)
                ) && 
                (
                    this.TotalPay == input.TotalPay ||
                    this.TotalPay.Equals(input.TotalPay)
                ) && 
                (
                    this.PayRunStatus == input.PayRunStatus ||
                    this.PayRunStatus.Equals(input.PayRunStatus)
                ) && 
                (
                    this.PayRunType == input.PayRunType ||
                    this.PayRunType.Equals(input.PayRunType)
                ) && 
                (
                    this.CalendarType == input.CalendarType ||
                    this.CalendarType.Equals(input.CalendarType)
                ) && 
                (
                    this.PostedDateTime == input.PostedDateTime ||
                    (this.PostedDateTime != null &&
                    this.PostedDateTime.Equals(input.PostedDateTime))
                ) && 
                (
                    this.PaySlips == input.PaySlips ||
                    this.PaySlips != null &&
                    input.PaySlips != null &&
                    this.PaySlips.SequenceEqual(input.PaySlips)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PayRunID != null)
                    hashCode = hashCode * 59 + this.PayRunID.GetHashCode();
                if (this.PayrollCalendarID != null)
                    hashCode = hashCode * 59 + this.PayrollCalendarID.GetHashCode();
                if (this.PeriodStartDate != null)
                    hashCode = hashCode * 59 + this.PeriodStartDate.GetHashCode();
                if (this.PeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PeriodEndDate.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                hashCode = hashCode * 59 + this.TotalCost.GetHashCode();
                hashCode = hashCode * 59 + this.TotalPay.GetHashCode();
                hashCode = hashCode * 59 + this.PayRunStatus.GetHashCode();
                hashCode = hashCode * 59 + this.PayRunType.GetHashCode();
                hashCode = hashCode * 59 + this.CalendarType.GetHashCode();
                if (this.PostedDateTime != null)
                    hashCode = hashCode * 59 + this.PostedDateTime.GetHashCode();
                if (this.PaySlips != null)
                    hashCode = hashCode * 59 + this.PaySlips.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
