/// <reference path="../../Common/Helpers/GridEditorBase.ts" />


namespace FinalPractice.SportDB {

    @Serenity.Decorators.registerEditor()
    export class OrderrDetailsEditor
        extends Common.GridEditorBase<OrderDetailsRow> {
        protected getColumnsKey() { return "SportDB.OrderDetails"; }
        protected getDialogType() { return OrderrDetailsEditDialog }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }
        constructor(container: JQuery) {
            super(container);
        }
        // add and rename button to add new products
        protected getAddButtonCaption() {
            return "Add Product";
        }

        validateEntity(row, id) {
            row.ProductId = Q.toId(row.ProductId);

            // validation if the product is already there
            var sameProduct = Q.tryFirst(this.view.getItems(), x => x.ProductId === row.ProductId);
            if (sameProduct && this.id(sameProduct) !== id) {
                Q.alert('This product is already in order details!');
                return false;
            }
            //set value to product name using Lookup
            row.ProductName = ProductRow.getLookup().itemById[row.ProductId].Title;
            //set value to price total
            row.LineTotal = (row.Quantity || 0) * (row.UnitPrice || 0);
            Q.notifySuccess("it was executed correctly");
            return true;
        }

    }
}