/// <reference path="../Order/OrderDialog.ts" />

namespace FinalPractice.SportDB {

    //Use for show details in customerOrder

    @Serenity.Decorators.registerClass()
    export class CustomerOrderDialog extends OrderDialog {

        constructor() {
            super();
        }

        updateInterface() {
            super.updateInterface();

            Serenity.EditorUtils.setReadOnly(this.form.CutormerId, true);
        }
    }
}
