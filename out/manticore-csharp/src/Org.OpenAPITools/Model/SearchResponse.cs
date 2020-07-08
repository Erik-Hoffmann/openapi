/* 
 * Manticore Search API
 *
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@manticoresearch.com
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Response object of a search request
    /// </summary>
    [DataContract]
    public partial class SearchResponse :  IEquatable<SearchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="took">took.</param>
        /// <param name="timedOut">timedOut.</param>
        /// <param name="hits">hits.</param>
        /// <param name="profile">profile.</param>
        public SearchResponse(int took = default(int), bool timedOut = default(bool), Dictionary<string, SearchResponseHits> hits = default(Dictionary<string, SearchResponseHits>), Object profile = default(Object))
        {
            this.Took = took;
            this.TimedOut = timedOut;
            this.Hits = hits;
            this.Profile = profile;
        }
        
        /// <summary>
        /// Gets or Sets Took
        /// </summary>
        [DataMember(Name="took", EmitDefaultValue=false)]
        public int Took { get; set; }

        /// <summary>
        /// Gets or Sets TimedOut
        /// </summary>
        [DataMember(Name="timed_out", EmitDefaultValue=false)]
        public bool TimedOut { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name="hits", EmitDefaultValue=false)]
        public Dictionary<string, SearchResponseHits> Hits { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public Object Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResponse {\n");
            sb.Append("  Took: ").Append(Took).Append("\n");
            sb.Append("  TimedOut: ").Append(TimedOut).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(input as SearchResponse);
        }

        /// <summary>
        /// Returns true if SearchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Took == input.Took ||
                    (this.Took != null &&
                    this.Took.Equals(input.Took))
                ) && 
                (
                    this.TimedOut == input.TimedOut ||
                    (this.TimedOut != null &&
                    this.TimedOut.Equals(input.TimedOut))
                ) && 
                (
                    this.Hits == input.Hits ||
                    this.Hits != null &&
                    input.Hits != null &&
                    this.Hits.SequenceEqual(input.Hits)
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
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
                if (this.Took != null)
                    hashCode = hashCode * 59 + this.Took.GetHashCode();
                if (this.TimedOut != null)
                    hashCode = hashCode * 59 + this.TimedOut.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
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