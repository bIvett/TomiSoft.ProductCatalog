/*
 * TomiSoft Product Database Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
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
    /// 
    /// </summary>
    [DataContract]
    public class ErrorResultDto : IEquatable<ErrorResultDto>
    {

        /// <summary>
        /// An error code representing the root cause of the failure
        /// </summary>
        /// <value>An error code representing the root cause of the failure</value>
        [TypeConverter(typeof(CustomEnumConverter<ErrorCodeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ErrorCodeEnum
        {
            
            /// <summary>
            /// Enum SuccessfulEnum for Successful
            /// </summary>
            [EnumMember(Value = "Successful")]
            SuccessfulEnum = 1,
            
            /// <summary>
            /// Enum GenericErrorEnum for GenericError
            /// </summary>
            [EnumMember(Value = "GenericError")]
            GenericErrorEnum = 2,
            
            /// <summary>
            /// Enum UnauthorizedAccessEnum for UnauthorizedAccess
            /// </summary>
            [EnumMember(Value = "UnauthorizedAccess")]
            UnauthorizedAccessEnum = 3,
            
            /// <summary>
            /// Enum ProductNotFoundEnum for ProductNotFound
            /// </summary>
            [EnumMember(Value = "ProductNotFound")]
            ProductNotFoundEnum = 4
        }

        /// <summary>
        /// An error code representing the root cause of the failure
        /// </summary>
        /// <value>An error code representing the root cause of the failure</value>
        [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum ErrorCode { get; set; }

        /// <summary>
        /// A human-friendly error message in English
        /// </summary>
        /// <value>A human-friendly error message in English</value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorResultDto {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ErrorResultDto)obj);
        }

        /// <summary>
        /// Returns true if ErrorResultDto instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResultDto other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ErrorCode == other.ErrorCode ||
                    
                    ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
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
                    
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                    if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ErrorResultDto left, ErrorResultDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ErrorResultDto left, ErrorResultDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}