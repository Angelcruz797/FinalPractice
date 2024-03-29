﻿namespace FinalPractice.SportDB {
    export interface OrderRow {
        OrderId?: number;
        CutormerId?: number;
        Status?: OrderStatus;
        ShipCity?: OrderCity;
        ReleaseDate?: string;
        ProductList?: OrderDetailsRow[];
        CutormerFirstname?: string;
        CutormerLastname?: string;
        CustomerFullname?: string;
        CutormerGender?: number;
    }

    export namespace OrderRow {
        export const idProperty = 'OrderId';
        export const localTextPrefix = 'SportDB.Order';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Default:Customer:View';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderId = "OrderId",
            CutormerId = "CutormerId",
            Status = "Status",
            ShipCity = "ShipCity",
            ReleaseDate = "ReleaseDate",
            ProductList = "ProductList",
            CutormerFirstname = "CutormerFirstname",
            CutormerLastname = "CutormerLastname",
            CustomerFullname = "CustomerFullname",
            CutormerGender = "CutormerGender"
        }
    }
}

