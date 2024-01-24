
namespace FinalPractice.SportDB {
    export class ProductForm extends Serenity.PrefixedContext {
        static formKey = 'SportDB.Product';
    }

    export interface ProductForm {
        Title: Serenity.StringEditor;
        Price: Serenity.IntegerEditor;
    }

    [,
        ['Title', () => Serenity.StringEditor],
        ['Price', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(ProductForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}