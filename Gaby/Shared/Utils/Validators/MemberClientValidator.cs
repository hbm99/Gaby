//using System;
//using Gaby.Shared.Model;
//using FluentValidation;

//namespace Gaby.Shared.Utils.Validators
//{
//    public class MemberClientValidator : AbstractValidator<MemberClient>
//    {
//        public MemberClientValidator()
//        {
//            CascadeMode = CascadeMode.Stop;

//            RuleFor(client => client.Name).NotEmpty().WithMessage("Nombre es un campo requerido.")
//                .Length(3, 50).WithMessage("Nombre debe tener entre 3 y 50 caracteres.");

//            RuleFor(client => client.PhoneNumber).NotEmpty().WithMessage("Número de teléfono es un campo requerido.")
//                .Length(8, 11).WithMessage("Número de teléfono debe tener entre 8 y 11 caracteres.");

//            RuleFor(client => client.Gender).IsInEnum().WithMessage("Género es un campo requerido.");

//            RuleFor(client => client.Offers).NotEmpty().WithMessage("Ofertas es un campo requerido.");

//            //RuleForEach(client => client.Offers).SetValidator(new OfferValidator());

//            //RuleFor(client => client.Address).SetValidator(new HomeAddressValidator());

//            //RuleForEach(client => client.InscriptionDates).SetValidator(new InscriptionDateValidator());
//        }
//    }
//}

