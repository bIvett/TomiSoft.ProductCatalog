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
    /// Brief information about a manufacturer
    /// </summary>
    [DataContract]
    public class ManufacturerInfoDto : IEquatable<ManufacturerInfoDto>
    {
        /// <summary>
        /// The unique identifier of the manufacturer
        /// </summary>
        /// <value>The unique identifier of the manufacturer</value>
        [DataMember(Name="ManufacturerId", EmitDefaultValue=false)]
        public long ManufacturerId { get; set; }

        /// <summary>
        /// The manufacturer&#39;s name
        /// </summary>
        /// <value>The manufacturer&#39;s name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The manufacturer&#39;s country code in ISO 3166-2 format
        /// </summary>
        /// <value>The manufacturer&#39;s country code in ISO 3166-2 format</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The address of the manufacturer&#39;s headquarters
        /// </summary>
        /// <value>The address of the manufacturer&#39;s headquarters</value>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// The manufacturer&#39;s website
        /// </summary>
        /// <value>The manufacturer&#39;s website</value>
        [DataMember(Name="Website", EmitDefaultValue=true)]
        public string Website { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManufacturerInfoDto {\n");
            sb.Append("  ManufacturerId: ").Append(ManufacturerId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ManufacturerInfoDto)obj);
        }

        /// <summary>
        /// Returns true if ManufacturerInfoDto instances are equal
        /// </summary>
        /// <param name="other">Instance of ManufacturerInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManufacturerInfoDto other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ManufacturerId == other.ManufacturerId ||
                    
                    ManufacturerId.Equals(other.ManufacturerId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    CountryCode == other.CountryCode ||
                    CountryCode != null &&
                    CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
                ) && 
                (
                    Website == other.Website ||
                    Website != null &&
                    Website.Equals(other.Website)
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
                    
                    hashCode = hashCode * 59 + ManufacturerId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (CountryCode != null)
                    hashCode = hashCode * 59 + CountryCode.GetHashCode();
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                    if (Website != null)
                    hashCode = hashCode * 59 + Website.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ManufacturerInfoDto left, ManufacturerInfoDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ManufacturerInfoDto left, ManufacturerInfoDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
