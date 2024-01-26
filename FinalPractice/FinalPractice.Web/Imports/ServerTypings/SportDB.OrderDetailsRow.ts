namespace FinalPractice.SportDB {
    export interface OrderDetailsRow {
        OrderDetailsId?: number;
        OrderId?: number;
        ProductId?: number;
        Quantity?: number;
        UnitPrice?: number;
        LineTotal?: number;
        OrderCutormerId?: number;
        OrderStatus?: number;
        OrderReleaseDate?: string;
        OrderTotal?: number;
        ProductTitle?: string;
        ProductPrice?: number;
    }

    export namespace OrderDetailsRow {
        export const idProperty = 'OrderDetailsId';
        export const localTextPrefix = 'SportDB.OrderDetails';
        export const lookupKey = 'SportDB.OrderDetalis';

        export function getLookup(): Q.Lookup<OrderDetailsRow> {
            return Q.getLookup<OrderDetailsRow>('SportDB.OrderDetalis');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderDetailsId = "OrderDetailsId",
            OrderId = "OrderId",
            ProductId = "ProductId",
            Quantity = "Quantity",
            UnitPrice = "UnitPrice",
            LineTotal = "LineTotal",
            OrderCutormerId = "OrderCutormerId",
            OrderStatus = "OrderStatus",
            OrderReleaseDate = "OrderReleaseDate",
            OrderTotal = "OrderTotal",
            ProductTitle = "ProductTitle",
            ProductPrice = "ProductPrice"
        }
    }
}

