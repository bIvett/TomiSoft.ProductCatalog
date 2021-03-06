/*
 * TomiSoft Product Database Api
 *
 * This document describes the API provided by the TomiSoft.ProductCatalog.Server microservice. This microservice provides information about products, based on barcode.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: sinkutamas@gmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TomiSoft.ProductCatalog.Server.OpenApiGenerated.Converters;

namespace TomiSoft.ProductCatalog.Server.OpenApiGenerated.Models
{ 
    /// <summary>
    /// Provides modified information about a product that needs to be updated. If the category or the manufacturer should not be changed, their original value must be provided. To remove the product name for a specific language, provide the language code with null-value. To add a new or modify an existing product name translation, provide the language code with a non-null, non-empty string value.
    /// </summary>
    [DataContract]
    public class PatchProductRequestDto : IEquatable<PatchProductRequestDto>
    {
        /// <summary>
        /// The unique identifier of the manufacturer
        /// </summary>
        /// <value>The unique identifier of the manufacturer</value>
        [DataMember(Name="ManufacturerId", EmitDefaultValue=true)]
        public long? ManufacturerId { get; set; }

        /// <summary>
        /// The unique ID of the category.
        /// </summary>
        /// <value>The unique ID of the category.</value>
        [DataMember(Name="CategoryId", EmitDefaultValue=true)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// A key-value pair object representing the product name for a specific language.
        /// </summary>
        /// <value>A key-value pair object representing the product name for a specific language.</value>
        [Required]
        [DataMember(Name="ProductName", EmitDefaultValue=false)]
        public Dictionary<string, string> ProductName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchProductRequestDto {\n");
            sb.Append("  ManufacturerId: ").Append(ManufacturerId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((PatchProductRequestDto)obj);
        }

        /// <summary>
        /// Returns true if PatchProductRequestDto instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchProductRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchProductRequestDto other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ManufacturerId == other.ManufacturerId ||
                    ManufacturerId != null &&
                    ManufacturerId.Equals(other.ManufacturerId)
                ) && 
                (
                    CategoryId == other.CategoryId ||
                    CategoryId != null &&
                    CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    ProductName == other.ProductName ||
                    ProductName != null &&
                    other.ProductName != null &&
                    ProductName.SequenceEqual(other.ProductName)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ManufacturerId != null)
                    hashCode = hashCode * 59 + ManufacturerId.GetHashCode();
                    if (CategoryId != null)
                    hashCode = hashCode * 59 + CategoryId.GetHashCode();
                    if (ProductName != null)
                    hashCode = hashCode * 59 + ProductName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PatchProductRequestDto left, PatchProductRequestDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PatchProductRequestDto left, PatchProductRequestDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
