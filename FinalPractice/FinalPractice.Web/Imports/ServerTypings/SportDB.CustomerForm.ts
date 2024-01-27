namespace FinalPractice.SportDB {
    export interface CustomerForm {
        Firstname: Serenity.StringEditor;
        Lastname: Serenity.StringEditor;
        Gender: Serenity.EnumEditor;
        Address: Serenity.StringEditor;
    }

    export class CustomerForm extends Serenity.PrefixedContext {
        static formKey = 'SportDB.Customer';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomerForm.init)  {
                CustomerForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EnumEditor;

                Q.initFormType(CustomerForm, [
                    'Firstname', w0,
                    'Lastname', w0,
                    'Gender', w1,
                    'Address', w0
                ]);
            }
        }
    }
}

