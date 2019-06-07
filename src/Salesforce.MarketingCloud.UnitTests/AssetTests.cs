using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using NUnit.Framework;
using Salesforce.MarketingCloud.Model;
using Salesforce.MarketingCloud.Validation;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class AssetTests
    {
        [Test]
        public void Validate_SingleInvalidProperty_ReturnsSingleValidationResult()
        {
            var validatableAsset = CreateAsset("A");

            var validationResults = validatableAsset.Validate(null).ToList();

            Assert.AreEqual(1, validationResults.Count);
            var nameValidationResult = validationResults[0];
            Assert.AreEqual("Invalid value for Name, length must be greater than 2.", nameValidationResult.ErrorMessage);
            CollectionAssert.AreEquivalent(new [] { "Name" }, nameValidationResult.MemberNames);
        }

        [Test]
        public void Validate_TwoInvalidProperties_ReturnsMultipleValidationResults()
        {
            var validatableAsset = CreateAsset("A", "D");

            var validationResults = validatableAsset.Validate(null).ToList();

            Assert.AreEqual(2, validationResults.Count);

            var nameValidationResult = validationResults.Single(vr => vr.ErrorMessage.Contains("Name"));
            Assert.AreEqual("Invalid value for Name, length must be greater than 2.", nameValidationResult.ErrorMessage);
            CollectionAssert.AreEquivalent(new[] { "Name" }, nameValidationResult.MemberNames);

            var descriptionValidationResult = validationResults.Single(vr => vr.ErrorMessage.Contains("Description"));
            Assert.AreEqual("Invalid value for Description, length must be greater than 3.", descriptionValidationResult.ErrorMessage);
            CollectionAssert.AreEquivalent(new[] { "Description" }, descriptionValidationResult.MemberNames);
        }

        private IValidatableObject CreateAsset(string name, string description = "Description")
        {
            var customerKey = Guid.NewGuid().ToString();
            var assetType = new AssetType(196, "textblock", "Text Block");

            var asset = new Asset(null, customerKey, null, null, assetType, null, null, null, name, description);

            return asset;
        }
    }
}