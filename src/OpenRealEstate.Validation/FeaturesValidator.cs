using FluentValidation;
using OpenRealEstate.Core;

namespace OpenRealEstate.Validation
{
    public class FeaturesValidator : AbstractValidator<Features>
    {
        /// <summary>
        /// Validates the following:
        /// <para>
        /// Minimum (Default):
        /// - CarParking
        /// </para>
        /// </summary>
        public FeaturesValidator()
        {
            RuleFor(feature => feature.CarParking)
                .SetValidator(new CarParkingValidator());

            // NOTE: Tags can be null or contains a list of tags.
            //       Byte properties are from 0->255, so they don't need a validator check.
        }
    }
}
