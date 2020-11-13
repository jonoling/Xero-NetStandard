/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
 *
 * The version of the OpenAPI document: 2.4.0
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

namespace Xero.NetStandard.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// EmployeeStatutorySickLeave
    /// </summary>
    [DataContract]
    public partial class EmployeeStatutorySickLeave :  IEquatable<EmployeeStatutorySickLeave>, IValidatableObject
    {
        /// <summary>
        /// Defines EntitlementFailureReasons
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntitlementFailureReasonsEnum
        {
            /// <summary>
            /// Enum UnableToCalculateAwe for value: UnableToCalculateAwe
            /// </summary>
            [EnumMember(Value = "UnableToCalculateAwe")]
            UnableToCalculateAwe = 1,

            /// <summary>
            /// Enum AweLowerThanLel for value: AweLowerThanLel
            /// </summary>
            [EnumMember(Value = "AweLowerThanLel")]
            AweLowerThanLel = 2,

            /// <summary>
            /// Enum NotQualifiedInPreviousPiw for value: NotQualifiedInPreviousPiw
            /// </summary>
            [EnumMember(Value = "NotQualifiedInPreviousPiw")]
            NotQualifiedInPreviousPiw = 3,

            /// <summary>
            /// Enum ExceededMaximumEntitlementWeeksOfSsp for value: ExceededMaximumEntitlementWeeksOfSsp
            /// </summary>
            [EnumMember(Value = "ExceededMaximumEntitlementWeeksOfSsp")]
            ExceededMaximumEntitlementWeeksOfSsp = 4,

            /// <summary>
            /// Enum ExceededMaximumDurationOfPiw for value: ExceededMaximumDurationOfPiw
            /// </summary>
            [EnumMember(Value = "ExceededMaximumDurationOfPiw")]
            ExceededMaximumDurationOfPiw = 5,

            /// <summary>
            /// Enum SufficientNoticeNotGiven for value: SufficientNoticeNotGiven
            /// </summary>
            [EnumMember(Value = "SufficientNoticeNotGiven")]
            SufficientNoticeNotGiven = 6

        }


        /// <summary>
        /// If the leave requested was considered \&quot;not entitled\&quot;, the reasons why are listed here.
        /// </summary>
        /// <value>If the leave requested was considered \&quot;not entitled\&quot;, the reasons why are listed here.</value>
        [DataMember(Name="entitlementFailureReasons", EmitDefaultValue=false)]
        public List<EntitlementFailureReasonsEnum> EntitlementFailureReasons { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeStatutorySickLeave" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EmployeeStatutorySickLeave() 
        {  
          WorkPattern = new List<string>();  
          EntitlementFailureReasons = new List<EntitlementFailureReasonsEnum>(); 
        }
        
        /// <summary>
        /// The unique identifier (guid) of a statutory leave
        /// </summary>
        /// <value>The unique identifier (guid) of a statutory leave</value>
        [DataMember(Name="statutoryLeaveID", EmitDefaultValue=false)]
        public Guid? StatutoryLeaveID { get; set; }

        /// <summary>
        /// The unique identifier (guid) of the employee
        /// </summary>
        /// <value>The unique identifier (guid) of the employee</value>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// The unique identifier (guid) of the \&quot;Statutory Sick Leave (non-pensionable)\&quot; pay item
        /// </summary>
        /// <value>The unique identifier (guid) of the \&quot;Statutory Sick Leave (non-pensionable)\&quot; pay item</value>
        [DataMember(Name="leaveTypeID", EmitDefaultValue=false)]
        public Guid? LeaveTypeID { get; set; }

        /// <summary>
        /// The date when the leave starts
        /// </summary>
        /// <value>The date when the leave starts</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date when the leave ends
        /// </summary>
        /// <value>The date when the leave ends</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// the type of statutory leave
        /// </summary>
        /// <value>the type of statutory leave</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// the type of statutory leave
        /// </summary>
        /// <value>the type of statutory leave</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The days of the work week the employee is scheduled to work at the time the leave is taken
        /// </summary>
        /// <value>The days of the work week the employee is scheduled to work at the time the leave is taken</value>
        [DataMember(Name="workPattern", EmitDefaultValue=false)]
        public List<string> WorkPattern { get; set; }

        /// <summary>
        /// Whether the sick leave was pregnancy related
        /// </summary>
        /// <value>Whether the sick leave was pregnancy related</value>
        [DataMember(Name="isPregnancyRelated", EmitDefaultValue=false)]
        public bool? IsPregnancyRelated { get; set; }

        /// <summary>
        /// Whether the employee provided sufficent notice and documentation as required by the employer supporting the sick leave request
        /// </summary>
        /// <value>Whether the employee provided sufficent notice and documentation as required by the employer supporting the sick leave request</value>
        [DataMember(Name="sufficientNotice", EmitDefaultValue=false)]
        public bool? SufficientNotice { get; set; }

        /// <summary>
        /// Whether the leave was entitled to receive payment
        /// </summary>
        /// <value>Whether the leave was entitled to receive payment</value>
        [DataMember(Name="isEntitled", EmitDefaultValue=false)]
        public bool? IsEntitled { get; set; }

        /// <summary>
        /// The amount of requested time (in weeks)
        /// </summary>
        /// <value>The amount of requested time (in weeks)</value>
        [DataMember(Name="entitlementWeeksRequested", EmitDefaultValue=false)]
        public double? EntitlementWeeksRequested { get; set; }

        /// <summary>
        /// The amount of statutory sick leave time off (in weeks) that is available to take at the time the leave was requested
        /// </summary>
        /// <value>The amount of statutory sick leave time off (in weeks) that is available to take at the time the leave was requested</value>
        [DataMember(Name="entitlementWeeksQualified", EmitDefaultValue=false)]
        public double? EntitlementWeeksQualified { get; set; }

        /// <summary>
        /// A calculated amount of time (in weeks) that remains for the statutory sick leave period
        /// </summary>
        /// <value>A calculated amount of time (in weeks) that remains for the statutory sick leave period</value>
        [DataMember(Name="entitlementWeeksRemaining", EmitDefaultValue=false)]
        public double? EntitlementWeeksRemaining { get; set; }

        /// <summary>
        /// Whether another leave (Paternity, Shared Parental specifically) occurs during the requested leave&#39;s period. While this is allowed it could affect payment amounts
        /// </summary>
        /// <value>Whether another leave (Paternity, Shared Parental specifically) occurs during the requested leave&#39;s period. While this is allowed it could affect payment amounts</value>
        [DataMember(Name="overlapsWithOtherLeave", EmitDefaultValue=false)]
        public bool? OverlapsWithOtherLeave { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeStatutorySickLeave {\n");
            sb.Append("  StatutoryLeaveID: ").Append(StatutoryLeaveID).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  LeaveTypeID: ").Append(LeaveTypeID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WorkPattern: ").Append(WorkPattern).Append("\n");
            sb.Append("  IsPregnancyRelated: ").Append(IsPregnancyRelated).Append("\n");
            sb.Append("  SufficientNotice: ").Append(SufficientNotice).Append("\n");
            sb.Append("  IsEntitled: ").Append(IsEntitled).Append("\n");
            sb.Append("  EntitlementWeeksRequested: ").Append(EntitlementWeeksRequested).Append("\n");
            sb.Append("  EntitlementWeeksQualified: ").Append(EntitlementWeeksQualified).Append("\n");
            sb.Append("  EntitlementWeeksRemaining: ").Append(EntitlementWeeksRemaining).Append("\n");
            sb.Append("  OverlapsWithOtherLeave: ").Append(OverlapsWithOtherLeave).Append("\n");
            sb.Append("  EntitlementFailureReasons: ").Append(EntitlementFailureReasons).Append("\n");
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
            return this.Equals(input as EmployeeStatutorySickLeave);
        }

        /// <summary>
        /// Returns true if EmployeeStatutorySickLeave instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeStatutorySickLeave to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeStatutorySickLeave input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatutoryLeaveID == input.StatutoryLeaveID ||
                    (this.StatutoryLeaveID != null &&
                    this.StatutoryLeaveID.Equals(input.StatutoryLeaveID))
                ) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.LeaveTypeID == input.LeaveTypeID ||
                    (this.LeaveTypeID != null &&
                    this.LeaveTypeID.Equals(input.LeaveTypeID))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.WorkPattern == input.WorkPattern ||
                    this.WorkPattern != null &&
                    input.WorkPattern != null &&
                    this.WorkPattern.SequenceEqual(input.WorkPattern)
                ) && 
                (
                    this.IsPregnancyRelated == input.IsPregnancyRelated ||
                    this.IsPregnancyRelated.Equals(input.IsPregnancyRelated)
                ) && 
                (
                    this.SufficientNotice == input.SufficientNotice ||
                    this.SufficientNotice.Equals(input.SufficientNotice)
                ) && 
                (
                    this.IsEntitled == input.IsEntitled ||
                    this.IsEntitled.Equals(input.IsEntitled)
                ) && 
                (
                    this.EntitlementWeeksRequested == input.EntitlementWeeksRequested ||
                    this.EntitlementWeeksRequested.Equals(input.EntitlementWeeksRequested)
                ) && 
                (
                    this.EntitlementWeeksQualified == input.EntitlementWeeksQualified ||
                    this.EntitlementWeeksQualified.Equals(input.EntitlementWeeksQualified)
                ) && 
                (
                    this.EntitlementWeeksRemaining == input.EntitlementWeeksRemaining ||
                    this.EntitlementWeeksRemaining.Equals(input.EntitlementWeeksRemaining)
                ) && 
                (
                    this.OverlapsWithOtherLeave == input.OverlapsWithOtherLeave ||
                    this.OverlapsWithOtherLeave.Equals(input.OverlapsWithOtherLeave)
                ) && 
                (
                    this.EntitlementFailureReasons == input.EntitlementFailureReasons ||
                    this.EntitlementFailureReasons.SequenceEqual(input.EntitlementFailureReasons)
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
                if (this.StatutoryLeaveID != null)
                    hashCode = hashCode * 59 + this.StatutoryLeaveID.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.LeaveTypeID != null)
                    hashCode = hashCode * 59 + this.LeaveTypeID.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.WorkPattern != null)
                    hashCode = hashCode * 59 + this.WorkPattern.GetHashCode();
                hashCode = hashCode * 59 + this.IsPregnancyRelated.GetHashCode();
                hashCode = hashCode * 59 + this.SufficientNotice.GetHashCode();
                hashCode = hashCode * 59 + this.IsEntitled.GetHashCode();
                hashCode = hashCode * 59 + this.EntitlementWeeksRequested.GetHashCode();
                hashCode = hashCode * 59 + this.EntitlementWeeksQualified.GetHashCode();
                hashCode = hashCode * 59 + this.EntitlementWeeksRemaining.GetHashCode();
                hashCode = hashCode * 59 + this.OverlapsWithOtherLeave.GetHashCode();
                hashCode = hashCode * 59 + this.EntitlementFailureReasons.GetHashCode();
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
