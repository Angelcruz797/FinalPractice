namespace FinalPractice.SportDB {
    export interface OrderForm {
        CutormerId: Serenity.LookupEditor;
        Status: Serenity.EnumEditor;
        ShipCity: Serenity.EnumEditor;
        ReleaseDate: Serenity.DateEditor;
        ProductList: OrderrDetailsEditor;
    }

    export class OrderForm extends Serenity.PrefixedContext {
        static formKey = 'SportDB.Order';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderForm.init)  {
                OrderForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.EnumEditor;
                var w2 = s.DateEditor;
                var w3 = OrderrDetailsEditor;

                Q.initFormType(OrderForm, [
                    'CutormerId', w0,
                    'Status', w1,
                    'ShipCity', w1,
                    'ReleaseDate', w2,
                    'ProductList', w3
                ]);
            }
        }
    }
}

