/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Retry policy for the individual webhooks that are a part of your subscription. If a message fails to deliver, it will execute through this retry policy.  Automatic suspend and resume:  If you experience downtime and have &#x60;deactivateFlag &#x3D; true&#x60; any new messages will be held in a \&quot;SUSPENDED\&quot; status. When your healthCheckUrl returns healthy again, the subscription will automatically be re-enabled and your messages will be sent. We will ping your healthCheckUrl routinely using a POST call with an empty payload to check availability. If your endpoint returns an unhealthy status of !&#x3D; 200, we will check the healthCheckUrl at a more frequent rate until it is healthy again.  If you experience downtime and have &#x60;deactivateFlag &#x3D; false&#x60; and your message exhausts all retry attempts the message will go to a \&quot;FAILED\&quot; status. Support will be notified and will reach out to suggest you execute the \&quot;REPLAY\&quot; endpoint at a later date when your server is healthy.   Reference the below values for formulas and calculations related to the frequency of retries depending on algorithm and configuration. 
    /// </summary>
    [DataContract]
    public partial class Notificationsubscriptionsv2webhooksRetryPolicy :  IEquatable<Notificationsubscriptionsv2webhooksRetryPolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notificationsubscriptionsv2webhooksRetryPolicy" /> class.
        /// </summary>
        /// <param name="Algorithm">This is used to calculate the Retry Sequence.  Sample calculations using firstRetry&#x3D;10, interval&#x3D;30, maxNumberOfRetries&#x3D;3 Arithmetic &#x3D; a+r(n-1) Retry 1 - 10 minutes Retry 2 - 10+30x1 &#x3D; 40 minutes Retry 3 - 10+30x2 &#x3D; 70 minutes  Geometric &#x3D; ar^(n-1) Retry 1 - 10 minutes Retry 2 - 10x30^1 &#x3D; 300 minutes Retry 3 - 10x30^2 &#x3D; 9,000 minutes .</param>
        /// <param name="FirstRetry">When to initiate first retry, after the initial call failed. (in mins)..</param>
        /// <param name="Interval">The interval between retries (in mins)..</param>
        /// <param name="NumberOfRetries">The number of retries per sequence..</param>
        /// <param name="DeactivateFlag">Deactivate the subscription if your retries fail to deliver.  If this is set to &#x60;true&#x60;, the automatic suspend and resume feature will occur. This would prevent new webhooks from attempting to deliver and to queue up until your healthCheckUrl returns 200 again, then all messages will be sent.  If this is set to &#x60;false&#x60;, new individual messages will continue to retry and exhaust all failures, but the subscription will stay active. .</param>
        /// <param name="RepeatSequenceCount">The number of times to repeat the complete retry sequence. 0 &#x3D;&gt; don&#39;t repeat the retry sequence 1 &#x3D;&gt; repeat the retry sequence once (R1, R2, R3)+ (R1, R2, R3) 2 &#x3D;&gt; repeat the retry sequence twice (R1, R2, R3) + (R1, R2, R3) + (R1, R2, R3) .</param>
        /// <param name="RepeatSequenceWaitTime">The time to wait to before repeating the complete retry sequence. Amount of time to wait between each sequence. Sample calculation using repeatSequenceWaitTime&#x3D;10 (R1, R2, R3) + (10) + (R1, R2, R3) + (10) + (R1, R2, R3) .</param>
        /// <param name="AdditionalAttributes">Additional data, if any..</param>
        public Notificationsubscriptionsv2webhooksRetryPolicy(string Algorithm = default(string), int? FirstRetry = default(int?), int? Interval = default(int?), int? NumberOfRetries = default(int?), string DeactivateFlag = default(string), int? RepeatSequenceCount = default(int?), int? RepeatSequenceWaitTime = default(int?), List<Dictionary<string, string>> AdditionalAttributes = default(List<Dictionary<string, string>>))
        {
            this.Algorithm = Algorithm;
            this.FirstRetry = FirstRetry;
            this.Interval = Interval;
            this.NumberOfRetries = NumberOfRetries;
            this.DeactivateFlag = DeactivateFlag;
            this.RepeatSequenceCount = RepeatSequenceCount;
            this.RepeatSequenceWaitTime = RepeatSequenceWaitTime;
            this.AdditionalAttributes = AdditionalAttributes;
        }
        
        /// <summary>
        /// This is used to calculate the Retry Sequence.  Sample calculations using firstRetry&#x3D;10, interval&#x3D;30, maxNumberOfRetries&#x3D;3 Arithmetic &#x3D; a+r(n-1) Retry 1 - 10 minutes Retry 2 - 10+30x1 &#x3D; 40 minutes Retry 3 - 10+30x2 &#x3D; 70 minutes  Geometric &#x3D; ar^(n-1) Retry 1 - 10 minutes Retry 2 - 10x30^1 &#x3D; 300 minutes Retry 3 - 10x30^2 &#x3D; 9,000 minutes 
        /// </summary>
        /// <value>This is used to calculate the Retry Sequence.  Sample calculations using firstRetry&#x3D;10, interval&#x3D;30, maxNumberOfRetries&#x3D;3 Arithmetic &#x3D; a+r(n-1) Retry 1 - 10 minutes Retry 2 - 10+30x1 &#x3D; 40 minutes Retry 3 - 10+30x2 &#x3D; 70 minutes  Geometric &#x3D; ar^(n-1) Retry 1 - 10 minutes Retry 2 - 10x30^1 &#x3D; 300 minutes Retry 3 - 10x30^2 &#x3D; 9,000 minutes </value>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// When to initiate first retry, after the initial call failed. (in mins).
        /// </summary>
        /// <value>When to initiate first retry, after the initial call failed. (in mins).</value>
        [DataMember(Name="firstRetry", EmitDefaultValue=false)]
        public int? FirstRetry { get; set; }

        /// <summary>
        /// The interval between retries (in mins).
        /// </summary>
        /// <value>The interval between retries (in mins).</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The number of retries per sequence.
        /// </summary>
        /// <value>The number of retries per sequence.</value>
        [DataMember(Name="numberOfRetries", EmitDefaultValue=false)]
        public int? NumberOfRetries { get; set; }

        /// <summary>
        /// Deactivate the subscription if your retries fail to deliver.  If this is set to &#x60;true&#x60;, the automatic suspend and resume feature will occur. This would prevent new webhooks from attempting to deliver and to queue up until your healthCheckUrl returns 200 again, then all messages will be sent.  If this is set to &#x60;false&#x60;, new individual messages will continue to retry and exhaust all failures, but the subscription will stay active. 
        /// </summary>
        /// <value>Deactivate the subscription if your retries fail to deliver.  If this is set to &#x60;true&#x60;, the automatic suspend and resume feature will occur. This would prevent new webhooks from attempting to deliver and to queue up until your healthCheckUrl returns 200 again, then all messages will be sent.  If this is set to &#x60;false&#x60;, new individual messages will continue to retry and exhaust all failures, but the subscription will stay active. </value>
        [DataMember(Name="deactivateFlag", EmitDefaultValue=false)]
        public string DeactivateFlag { get; set; }

        /// <summary>
        /// The number of times to repeat the complete retry sequence. 0 &#x3D;&gt; don&#39;t repeat the retry sequence 1 &#x3D;&gt; repeat the retry sequence once (R1, R2, R3)+ (R1, R2, R3) 2 &#x3D;&gt; repeat the retry sequence twice (R1, R2, R3) + (R1, R2, R3) + (R1, R2, R3) 
        /// </summary>
        /// <value>The number of times to repeat the complete retry sequence. 0 &#x3D;&gt; don&#39;t repeat the retry sequence 1 &#x3D;&gt; repeat the retry sequence once (R1, R2, R3)+ (R1, R2, R3) 2 &#x3D;&gt; repeat the retry sequence twice (R1, R2, R3) + (R1, R2, R3) + (R1, R2, R3) </value>
        [DataMember(Name="repeatSequenceCount", EmitDefaultValue=false)]
        public int? RepeatSequenceCount { get; set; }

        /// <summary>
        /// The time to wait to before repeating the complete retry sequence. Amount of time to wait between each sequence. Sample calculation using repeatSequenceWaitTime&#x3D;10 (R1, R2, R3) + (10) + (R1, R2, R3) + (10) + (R1, R2, R3) 
        /// </summary>
        /// <value>The time to wait to before repeating the complete retry sequence. Amount of time to wait between each sequence. Sample calculation using repeatSequenceWaitTime&#x3D;10 (R1, R2, R3) + (10) + (R1, R2, R3) + (10) + (R1, R2, R3) </value>
        [DataMember(Name="repeatSequenceWaitTime", EmitDefaultValue=false)]
        public int? RepeatSequenceWaitTime { get; set; }

        /// <summary>
        /// Additional data, if any.
        /// </summary>
        /// <value>Additional data, if any.</value>
        [DataMember(Name="additionalAttributes", EmitDefaultValue=false)]
        public List<Dictionary<string, string>> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notificationsubscriptionsv2webhooksRetryPolicy {\n");
            if (Algorithm != null) sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            if (FirstRetry != null) sb.Append("  FirstRetry: ").Append(FirstRetry).Append("\n");
            if (Interval != null) sb.Append("  Interval: ").Append(Interval).Append("\n");
            if (NumberOfRetries != null) sb.Append("  NumberOfRetries: ").Append(NumberOfRetries).Append("\n");
            if (DeactivateFlag != null) sb.Append("  DeactivateFlag: ").Append(DeactivateFlag).Append("\n");
            if (RepeatSequenceCount != null) sb.Append("  RepeatSequenceCount: ").Append(RepeatSequenceCount).Append("\n");
            if (RepeatSequenceWaitTime != null) sb.Append("  RepeatSequenceWaitTime: ").Append(RepeatSequenceWaitTime).Append("\n");
            if (AdditionalAttributes != null) sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Notificationsubscriptionsv2webhooksRetryPolicy);
        }

        /// <summary>
        /// Returns true if Notificationsubscriptionsv2webhooksRetryPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of Notificationsubscriptionsv2webhooksRetryPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notificationsubscriptionsv2webhooksRetryPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Algorithm == other.Algorithm ||
                    this.Algorithm != null &&
                    this.Algorithm.Equals(other.Algorithm)
                ) && 
                (
                    this.FirstRetry == other.FirstRetry ||
                    this.FirstRetry != null &&
                    this.FirstRetry.Equals(other.FirstRetry)
                ) && 
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) && 
                (
                    this.NumberOfRetries == other.NumberOfRetries ||
                    this.NumberOfRetries != null &&
                    this.NumberOfRetries.Equals(other.NumberOfRetries)
                ) && 
                (
                    this.DeactivateFlag == other.DeactivateFlag ||
                    this.DeactivateFlag != null &&
                    this.DeactivateFlag.Equals(other.DeactivateFlag)
                ) && 
                (
                    this.RepeatSequenceCount == other.RepeatSequenceCount ||
                    this.RepeatSequenceCount != null &&
                    this.RepeatSequenceCount.Equals(other.RepeatSequenceCount)
                ) && 
                (
                    this.RepeatSequenceWaitTime == other.RepeatSequenceWaitTime ||
                    this.RepeatSequenceWaitTime != null &&
                    this.RepeatSequenceWaitTime.Equals(other.RepeatSequenceWaitTime)
                ) && 
                (
                    this.AdditionalAttributes == other.AdditionalAttributes ||
                    this.AdditionalAttributes != null &&
                    this.AdditionalAttributes.SequenceEqual(other.AdditionalAttributes)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Algorithm != null)
                    hash = hash * 59 + this.Algorithm.GetHashCode();
                if (this.FirstRetry != null)
                    hash = hash * 59 + this.FirstRetry.GetHashCode();
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                if (this.NumberOfRetries != null)
                    hash = hash * 59 + this.NumberOfRetries.GetHashCode();
                if (this.DeactivateFlag != null)
                    hash = hash * 59 + this.DeactivateFlag.GetHashCode();
                if (this.RepeatSequenceCount != null)
                    hash = hash * 59 + this.RepeatSequenceCount.GetHashCode();
                if (this.RepeatSequenceWaitTime != null)
                    hash = hash * 59 + this.RepeatSequenceWaitTime.GetHashCode();
                if (this.AdditionalAttributes != null)
                    hash = hash * 59 + this.AdditionalAttributes.GetHashCode();
                return hash;
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
