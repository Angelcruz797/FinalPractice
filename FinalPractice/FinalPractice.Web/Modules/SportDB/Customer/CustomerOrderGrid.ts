namespace FinalPractice.SportDB {
    @Serenity.Decorators.registerClass()
    export class CustomerOrderGrid extends Serenity.EntityGrid<OrderRow, any>
    {
        protected getColumnsKey() { return "SportDB.CustomerOrder"; }
        protected getIdProperty() { return OrderRow.idProperty; }

        //see details in CustomerOrder
        protected getDialogType() { return CustomerOrderDialog; }

        protected getLocalTextPrefix() { return OrderRow.localTextPrefix; }
        protected getService() { return OrderService.baseUrl; }
        constructor(container: JQuery) {
            super(container);
        }
        //disable buttons in order tap in CustomerForm
        protected getButtons() {
            return null;
        }
        protected getInitialTitle() {
            return null;
        }
        protected usePager() {
            return false;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.customerId;
        }

        private _customerId: number;

        get customerId() {
            return this._customerId;
        }

        //validation filtering orders by customerId
        set customerId(value: number) {
            if (this._customerId != value) {
                this._customerId = value;
                this.setEquality(OrderRow.Fields.CutormerId, value);
                this.refresh();
            }
        }
    }
}
