using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salesforce.MarketingCloud.Validation
{
    public class ModelValidationException : Exception
    {
        public ModelValidationException(string modelType, ICollection<ValidationResult> validationResults)
        {
            this.ModelType = modelType;
            this.ValidationResults = validationResults;
        }

        public string ModelType { get; private set; }

        public ICollection<ValidationResult> ValidationResults { get; private set; }

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine($"{this.ModelType} validation error:");
        //    foreach (var validationResult in this.ValidationResults)
        //    {
        //        sb.AppendLine(validationResult.ErrorMessage);
        //    }

        //    return sb.ToString();
        //}
    }
}