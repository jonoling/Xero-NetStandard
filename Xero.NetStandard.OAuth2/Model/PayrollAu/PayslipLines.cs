/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// PayslipLines
    /// </summary>
    [DataContract]
    public partial class PayslipLines :  IEquatable<PayslipLines>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets EarningsLines
        /// </summary>
        [DataMember(Name="EarningsLines", EmitDefaultValue=false)]
        public List<EarningsLine> EarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets LeaveEarningsLines
        /// </summary>
        [DataMember(Name="LeaveEarningsLines", EmitDefaultValue=false)]
        public List<LeaveEarningsLine> LeaveEarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetEarningsLines
        /// </summary>
        [DataMember(Name="TimesheetEarningsLines", EmitDefaultValue=false)]
        public List<EarningsLine> TimesheetEarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets DeductionLines
        /// </summary>
        [DataMember(Name="DeductionLines", EmitDefaultValue=false)]
        public List<DeductionLine> DeductionLines { get; set; }

        /// <summary>
        /// Gets or Sets LeaveAccrualLines
        /// </summary>
        [DataMember(Name="LeaveAccrualLines", EmitDefaultValue=false)]
        public List<LeaveAccrualLine> LeaveAccrualLines { get; set; }

        /// <summary>
        /// Gets or Sets ReimbursementLines
        /// </summary>
        [DataMember(Name="ReimbursementLines", EmitDefaultValue=false)]
        public List<ReimbursementLine> ReimbursementLines { get; set; }

        /// <summary>
        /// Gets or Sets SuperannuationLines
        /// </summary>
        [DataMember(Name="SuperannuationLines", EmitDefaultValue=false)]
        public List<SuperannuationLine> SuperannuationLines { get; set; }

        /// <summary>
        /// Gets or Sets TaxLines
        /// </summary>
        [DataMember(Name="TaxLines", EmitDefaultValue=false)]
        public List<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayslipLines {\n");
            sb.Append("  EarningsLines: ").Append(EarningsLines).Append("\n");
            sb.Append("  LeaveEarningsLines: ").Append(LeaveEarningsLines).Append("\n");
            sb.Append("  TimesheetEarningsLines: ").Append(TimesheetEarningsLines).Append("\n");
            sb.Append("  DeductionLines: ").Append(DeductionLines).Append("\n");
            sb.Append("  LeaveAccrualLines: ").Append(LeaveAccrualLines).Append("\n");
            sb.Append("  ReimbursementLines: ").Append(ReimbursementLines).Append("\n");
            sb.Append("  SuperannuationLines: ").Append(SuperannuationLines).Append("\n");
            sb.Append("  TaxLines: ").Append(TaxLines).Append("\n");
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
            return this.Equals(input as PayslipLines);
        }

        /// <summary>
        /// Returns true if PayslipLines instances are equal
        /// </summary>
        /// <param name="input">Instance of PayslipLines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayslipLines input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarningsLines == input.EarningsLines ||
                    this.EarningsLines != null &&
                    input.EarningsLines != null &&
                    this.EarningsLines.SequenceEqual(input.EarningsLines)
                ) && 
                (
                    this.LeaveEarningsLines == input.LeaveEarningsLines ||
                    this.LeaveEarningsLines != null &&
                    input.LeaveEarningsLines != null &&
                    this.LeaveEarningsLines.SequenceEqual(input.LeaveEarningsLines)
                ) && 
                (
                    this.TimesheetEarningsLines == input.TimesheetEarningsLines ||
                    this.TimesheetEarningsLines != null &&
                    input.TimesheetEarningsLines != null &&
                    this.TimesheetEarningsLines.SequenceEqual(input.TimesheetEarningsLines)
                ) && 
                (
                    this.DeductionLines == input.DeductionLines ||
                    this.DeductionLines != null &&
                    input.DeductionLines != null &&
                    this.DeductionLines.SequenceEqual(input.DeductionLines)
                ) && 
                (
                    this.LeaveAccrualLines == input.LeaveAccrualLines ||
                    this.LeaveAccrualLines != null &&
                    input.LeaveAccrualLines != null &&
                    this.LeaveAccrualLines.SequenceEqual(input.LeaveAccrualLines)
                ) && 
                (
                    this.ReimbursementLines == input.ReimbursementLines ||
                    this.ReimbursementLines != null &&
                    input.ReimbursementLines != null &&
                    this.ReimbursementLines.SequenceEqual(input.ReimbursementLines)
                ) && 
                (
                    this.SuperannuationLines == input.SuperannuationLines ||
                    this.SuperannuationLines != null &&
                    input.SuperannuationLines != null &&
                    this.SuperannuationLines.SequenceEqual(input.SuperannuationLines)
                ) && 
                (
                    this.TaxLines == input.TaxLines ||
                    this.TaxLines != null &&
                    input.TaxLines != null &&
                    this.TaxLines.SequenceEqual(input.TaxLines)
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
                if (this.EarningsLines != null)
                    hashCode = hashCode * 59 + this.EarningsLines.GetHashCode();
                if (this.LeaveEarningsLines != null)
                    hashCode = hashCode * 59 + this.LeaveEarningsLines.GetHashCode();
                if (this.TimesheetEarningsLines != null)
                    hashCode = hashCode * 59 + this.TimesheetEarningsLines.GetHashCode();
                if (this.DeductionLines != null)
                    hashCode = hashCode * 59 + this.DeductionLines.GetHashCode();
                if (this.LeaveAccrualLines != null)
                    hashCode = hashCode * 59 + this.LeaveAccrualLines.GetHashCode();
                if (this.ReimbursementLines != null)
                    hashCode = hashCode * 59 + this.ReimbursementLines.GetHashCode();
                if (this.SuperannuationLines != null)
                    hashCode = hashCode * 59 + this.SuperannuationLines.GetHashCode();
                if (this.TaxLines != null)
                    hashCode = hashCode * 59 + this.TaxLines.GetHashCode();
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
