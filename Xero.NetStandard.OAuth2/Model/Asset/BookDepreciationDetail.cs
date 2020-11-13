/* 
 * Xero Assets API
 *
 * This is the Xero Assets API
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

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// BookDepreciationDetail
    /// </summary>
    [DataContract]
    public partial class BookDepreciationDetail :  IEquatable<BookDepreciationDetail>, IValidatableObject
    {
        
        /// <summary>
        /// When an asset is disposed, this will be the sell price minus the purchase price if a profit was made.
        /// </summary>
        /// <value>When an asset is disposed, this will be the sell price minus the purchase price if a profit was made.</value>
        [DataMember(Name="currentCapitalGain", EmitDefaultValue=false)]
        public decimal? CurrentCapitalGain { get; set; }

        /// <summary>
        /// When an asset is disposed, this will be the lowest one of sell price or purchase price, minus the current book value.
        /// </summary>
        /// <value>When an asset is disposed, this will be the lowest one of sell price or purchase price, minus the current book value.</value>
        [DataMember(Name="currentGainLoss", EmitDefaultValue=false)]
        public decimal? CurrentGainLoss { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// </summary>
        /// <value>YYYY-MM-DD</value>
        [DataMember(Name="depreciationStartDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DepreciationStartDate { get; set; }

        /// <summary>
        /// The value of the asset you want to depreciate, if this is less than the cost of the asset.
        /// </summary>
        /// <value>The value of the asset you want to depreciate, if this is less than the cost of the asset.</value>
        [DataMember(Name="costLimit", EmitDefaultValue=false)]
        public decimal? CostLimit { get; set; }

        /// <summary>
        /// The value of the asset remaining when you&#39;ve fully depreciated it.
        /// </summary>
        /// <value>The value of the asset remaining when you&#39;ve fully depreciated it.</value>
        [DataMember(Name="residualValue", EmitDefaultValue=false)]
        public decimal? ResidualValue { get; set; }

        /// <summary>
        /// All depreciation prior to the current financial year.
        /// </summary>
        /// <value>All depreciation prior to the current financial year.</value>
        [DataMember(Name="priorAccumDepreciationAmount", EmitDefaultValue=false)]
        public decimal? PriorAccumDepreciationAmount { get; set; }

        /// <summary>
        /// All depreciation occurring in the current financial year.
        /// </summary>
        /// <value>All depreciation occurring in the current financial year.</value>
        [DataMember(Name="currentAccumDepreciationAmount", EmitDefaultValue=false)]
        public decimal? CurrentAccumDepreciationAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookDepreciationDetail {\n");
            sb.Append("  CurrentCapitalGain: ").Append(CurrentCapitalGain).Append("\n");
            sb.Append("  CurrentGainLoss: ").Append(CurrentGainLoss).Append("\n");
            sb.Append("  DepreciationStartDate: ").Append(DepreciationStartDate).Append("\n");
            sb.Append("  CostLimit: ").Append(CostLimit).Append("\n");
            sb.Append("  ResidualValue: ").Append(ResidualValue).Append("\n");
            sb.Append("  PriorAccumDepreciationAmount: ").Append(PriorAccumDepreciationAmount).Append("\n");
            sb.Append("  CurrentAccumDepreciationAmount: ").Append(CurrentAccumDepreciationAmount).Append("\n");
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
            return this.Equals(input as BookDepreciationDetail);
        }

        /// <summary>
        /// Returns true if BookDepreciationDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BookDepreciationDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookDepreciationDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentCapitalGain == input.CurrentCapitalGain ||
                    this.CurrentCapitalGain.Equals(input.CurrentCapitalGain)
                ) && 
                (
                    this.CurrentGainLoss == input.CurrentGainLoss ||
                    this.CurrentGainLoss.Equals(input.CurrentGainLoss)
                ) && 
                (
                    this.DepreciationStartDate == input.DepreciationStartDate ||
                    (this.DepreciationStartDate != null &&
                    this.DepreciationStartDate.Equals(input.DepreciationStartDate))
                ) && 
                (
                    this.CostLimit == input.CostLimit ||
                    this.CostLimit.Equals(input.CostLimit)
                ) && 
                (
                    this.ResidualValue == input.ResidualValue ||
                    this.ResidualValue.Equals(input.ResidualValue)
                ) && 
                (
                    this.PriorAccumDepreciationAmount == input.PriorAccumDepreciationAmount ||
                    this.PriorAccumDepreciationAmount.Equals(input.PriorAccumDepreciationAmount)
                ) && 
                (
                    this.CurrentAccumDepreciationAmount == input.CurrentAccumDepreciationAmount ||
                    this.CurrentAccumDepreciationAmount.Equals(input.CurrentAccumDepreciationAmount)
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
                hashCode = hashCode * 59 + this.CurrentCapitalGain.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentGainLoss.GetHashCode();
                if (this.DepreciationStartDate != null)
                    hashCode = hashCode * 59 + this.DepreciationStartDate.GetHashCode();
                hashCode = hashCode * 59 + this.CostLimit.GetHashCode();
                hashCode = hashCode * 59 + this.ResidualValue.GetHashCode();
                hashCode = hashCode * 59 + this.PriorAccumDepreciationAmount.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentAccumDepreciationAmount.GetHashCode();
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
