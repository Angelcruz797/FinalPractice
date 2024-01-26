
namespace FinalPractice.SportDB {

    @Serenity.Decorators.registerClass()
    export class OrderGrid extends Serenity.EntityGrid<OrderRow, any> {
        protected getColumnsKey() { return 'SportDB.Order'; }
        protected getDialogType() { return OrderDialog; }
        protected getIdProperty() { return OrderRow.idProperty; }
        protected getInsertPermission() { return OrderRow.insertPermission; }
        protected getLocalTextPrefix() { return OrderRow.localTextPrefix; }
        protected getService() { return OrderService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}