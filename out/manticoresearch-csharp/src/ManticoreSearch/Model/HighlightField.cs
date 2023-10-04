/*
 * Manticore Search Client
 *
 * Сlient for Manticore Search. 
 *
 * The version of the OpenAPI document: 3.3.0
 * Contact: info@manticoresearch.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ManticoreSearch.Client.FileParameter;
using OpenAPIDateConverter = ManticoreSearch.Client.OpenAPIDateConverter;

namespace ManticoreSearch.Model
{
    /// <summary>
    /// Query Highlight field with options set
    /// </summary>
    [DataContract(Name = "highlightField")]
    public partial class HighlightField : IEquatable<HighlightField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HighlightField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightField" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="limit">limit (default to 256).</param>
        /// <param name="limitWords">limitWords (default to 0).</param>
        /// <param name="limitSnippets">limitSnippets (default to 0).</param>
        public HighlightField(string name = default(string), int limit = 256, int limitWords = 0, int limitSnippets = 0)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for HighlightField and cannot be null");
            }
            this.Name = name;
            this.Limit = limit;
            this.LimitWords = limitWords;
            this.LimitSnippets = limitSnippets;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or Sets LimitWords
        /// </summary>
        [DataMember(Name = "limit_words", EmitDefaultValue = false)]
        public int LimitWords { get; set; }

        /// <summary>
        /// Gets or Sets LimitSnippets
        /// </summary>
        [DataMember(Name = "limit_snippets", EmitDefaultValue = false)]
        public int LimitSnippets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HighlightField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  LimitWords: ").Append(LimitWords).Append("\n");
            sb.Append("  LimitSnippets: ").Append(LimitSnippets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HighlightField);
        }

        /// <summary>
        /// Returns true if HighlightField instances are equal
        /// </summary>
        /// <param name="input">Instance of HighlightField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HighlightField input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.LimitWords == input.LimitWords ||
                    this.LimitWords.Equals(input.LimitWords)
                ) && 
                (
                    this.LimitSnippets == input.LimitSnippets ||
                    this.LimitSnippets.Equals(input.LimitSnippets)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.LimitWords.GetHashCode();
                hashCode = (hashCode * 59) + this.LimitSnippets.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
