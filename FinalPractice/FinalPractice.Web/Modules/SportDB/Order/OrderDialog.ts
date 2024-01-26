
namespace FinalPractice.SportDB {

    @Serenity.Decorators.registerClass()
    export class OrderDialog extends Serenity.EntityDialog<OrderRow, any> {
        protected getFormKey() { return OrderForm.formKey; }
        protected getIdProperty() { return OrderRow.idProperty; }
        protected getLocalTextPrefix() { return OrderRow.localTextPrefix; }
        protected getService() { return OrderService.baseUrl; }
        protected getDeletePermission() { return OrderRow.deletePermission; }
        protected getInsertPermission() { return OrderRow.insertPermission; }
        protected getUpdatePermission() { return OrderRow.updatePermission; }

        protected form = new OrderForm(this.idPrefix);

    }
}