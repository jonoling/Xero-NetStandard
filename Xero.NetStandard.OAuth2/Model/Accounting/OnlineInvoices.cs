/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// OnlineInvoices
    /// </summary>
    [DataContract]
    public partial class OnlineInvoices :  IEquatable<OnlineInvoices>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _OnlineInvoices
        /// </summary>
        [DataMember(Name="OnlineInvoices", EmitDefaultValue=false)]
        public List<OnlineInvoice> _OnlineInvoices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlineInvoices {\n");
            sb.Append("  _OnlineInvoices: ").Append(_OnlineInvoices).Append("\n");
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
            return this.Equals(input as OnlineInvoices);
        }

        /// <summary>
        /// Returns true if OnlineInvoices instances are equal
        /// </summary>
        /// <param name="input">Instance of OnlineInvoices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnlineInvoices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._OnlineInvoices == input._OnlineInvoices ||
                    this._OnlineInvoices != null &&
                    input._OnlineInvoices != null &&
                    this._OnlineInvoices.SequenceEqual(input._OnlineInvoices)
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
                if (this._OnlineInvoices != null)
                    hashCode = hashCode * 59 + this._OnlineInvoices.GetHashCode();
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
