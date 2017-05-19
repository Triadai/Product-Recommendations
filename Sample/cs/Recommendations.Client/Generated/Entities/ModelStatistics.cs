// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Recommendations.Client.Entities
{
    using System.Linq;

    /// <summary>
    /// The model statistics gathered during model training
    /// </summary>
    public partial class ModelStatistics
    {
        /// <summary>
        /// Initializes a new instance of the ModelStatistics class.
        /// </summary>
        public ModelStatistics() { }

        /// <summary>
        /// Initializes a new instance of the ModelStatistics class.
        /// </summary>
        /// <param name="trainingDuration">The core training duration</param>
        /// <param name="totalDuration">The total duration</param>
        /// <param name="catalogParsing">The catalog file parsing
        /// report</param>
        /// <param name="usageEventsParsing">The usage events files parsing
        /// report</param>
        /// <param name="numberOfCatalogItems">The number of items found in
        /// catalog</param>
        /// <param name="numberOfUsageItems">The number of valid (which are
        /// present in catalog if provided) unique items found in usage
        /// files</param>
        /// <param name="numberOfUsers">The number of unique users found in
        /// usage files</param>
        /// <param name="catalogCoverage">The ratio of unique items found in
        /// usage files and total items in catalog</param>
        /// <param name="evaluation">The model evaluation report</param>
        /// <param name="catalogFeatureWeights">The calculated catalog feature
        /// weights</param>
        public ModelStatistics(string trainingDuration = default(string), string totalDuration = default(string), ParsingReport catalogParsing = default(ParsingReport), ParsingReport usageEventsParsing = default(ParsingReport), int? numberOfCatalogItems = default(int?), int? numberOfUsageItems = default(int?), int? numberOfUsers = default(int?), double? catalogCoverage = default(double?), ModelEvaluationResult evaluation = default(ModelEvaluationResult), System.Collections.Generic.IList<double?> catalogFeatureWeights = default(System.Collections.Generic.IList<double?>))
        {
            TrainingDuration = trainingDuration;
            TotalDuration = totalDuration;
            CatalogParsing = catalogParsing;
            UsageEventsParsing = usageEventsParsing;
            NumberOfCatalogItems = numberOfCatalogItems;
            NumberOfUsageItems = numberOfUsageItems;
            NumberOfUsers = numberOfUsers;
            CatalogCoverage = catalogCoverage;
            Evaluation = evaluation;
            CatalogFeatureWeights = catalogFeatureWeights;
        }

        /// <summary>
        /// Gets or sets the core training duration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "trainingDuration")]
        public string TrainingDuration { get; set; }

        /// <summary>
        /// Gets or sets the total duration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "totalDuration")]
        public string TotalDuration { get; set; }

        /// <summary>
        /// Gets or sets the catalog file parsing report
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "catalogParsing")]
        public ParsingReport CatalogParsing { get; set; }

        /// <summary>
        /// Gets or sets the usage events files parsing report
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "usageEventsParsing")]
        public ParsingReport UsageEventsParsing { get; set; }

        /// <summary>
        /// Gets or sets the number of items found in catalog
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "numberOfCatalogItems")]
        public int? NumberOfCatalogItems { get; set; }

        /// <summary>
        /// Gets or sets the number of valid (which are present in catalog if
        /// provided) unique items found in usage files
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "numberOfUsageItems")]
        public int? NumberOfUsageItems { get; set; }

        /// <summary>
        /// Gets or sets the number of unique users found in usage files
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "numberOfUsers")]
        public int? NumberOfUsers { get; set; }

        /// <summary>
        /// Gets or sets the ratio of unique items found in usage files and
        /// total items in catalog
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "catalogCoverage")]
        public double? CatalogCoverage { get; set; }

        /// <summary>
        /// Gets or sets the model evaluation report
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "evaluation")]
        public ModelEvaluationResult Evaluation { get; set; }

        /// <summary>
        /// Gets or sets the calculated catalog feature weights
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "catalogFeatureWeights")]
        public System.Collections.Generic.IList<double?> CatalogFeatureWeights { get; set; }

    }
}
