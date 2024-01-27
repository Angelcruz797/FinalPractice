
namespace FinalPractice.SportDB {

    @Serenity.Decorators.registerClass()
    export class CustomerDialog extends Serenity.EntityDialog<CustomerRow, any> {
        protected getFormKey() { return CustomerForm.formKey; }
        protected getIdProperty() { return CustomerRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerRow.localTextPrefix; }
        protected getNameProperty() { return CustomerRow.nameProperty; }
        protected getService() { return CustomerService.baseUrl; }
        protected getDeletePermission() { return CustomerRow.deletePermission; }
        protected getInsertPermission() { return CustomerRow.insertPermission; }
        protected getUpdatePermission() { return CustomerRow.updatePermission; }

        protected form = new CustomerForm(this.idPrefix);


        private orderGrid: CustomerOrderGrid;

        constructor() {
            super();
            //show another tap in CustomerForm
            this.orderGrid = new CustomerOrderGrid(this.byId("OrderGrid"));
            this.tabs.on('tabsactivate', (e, i) => {
                this.arrange();
            });
        }

        //filtering orders by customerId
        protected afterLoadEntity() {
            super.afterLoadEntity();
            this.orderGrid.customerId = this.entityId;
        }

    }
}