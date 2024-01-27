/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />


namespace FinalPractice.SportDB {

    @Serenity.Decorators.registerClass()
    export class OrderrDetailsEditDialog extends
        Common.GridEditorDialog<OrderDetailsRow> {
        protected getFormKey() { return OrderDetailsForm.formKey; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }
        protected form: OrderDetailsForm;
        constructor() {
            super();
            this.form = new OrderDetailsForm(this.idPrefix);

            //set value to Price in the form product list
            this.form.ProductId.changeSelect2(e => {
                var productId = Q.toId(this.form.ProductId.value);
                if (productId != null) {
                    this.form.UnitPrice.value = ProductRow.getLookup().itemById[productId].Price;
                }
            });
        }

    }
}