namespace FinalPractice.SportDB {
    export interface ProductForm {
        Title: Serenity.StringEditor;
        Price: Serenity.DecimalEditor;
    }

    export class ProductForm extends Serenity.PrefixedContext {
        static formKey = 'SportDB.Product';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductForm.init)  {
                ProductForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;

                Q.initFormType(ProductForm, [
                    'Title', w0,
                    'Price', w1
                ]);
            }
        }
    }
}

